using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyBenXe
{
    public partial class FrmThongKeDoanhThu : Form
    {
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void UpdateChart(DataTable dataTable)
        {

            // Xóa dữ liệu cũ trong biểu đồ
            chartDoanhThu.Series.Clear();

            // tạo 2 series để vẽ biểu đồ
            // series: 1 loạt các điểm dữ liệu

            var SoVeBanDuoc = new Series("Số vé bán được")
            {
                ChartType = SeriesChartType.Column // kiểu biểu đồ cột
            };

            var TongDoanhThu = new Series("Thành tiền")
            {
                ChartType = SeriesChartType.Column
            };

            // Thêm dữ liệu vào series
            foreach (DataRow row in dataTable.Rows)
            {
                string loaiVe = row["Loại vé"].ToString();
                int soVeBanDuoc = Convert.ToInt32(row["Số vé bán được"]);
                double tongDoanhThu = Convert.ToDouble(row["Thành tiền"]);

                // Thêm dữ liệu vào series
                SoVeBanDuoc.Points.AddXY(loaiVe, soVeBanDuoc);
                TongDoanhThu.Points.AddXY(loaiVe, tongDoanhThu);
            }

            // Thêm series vào biểu đồ
            chartDoanhThu.Series.Add(SoVeBanDuoc);
            chartDoanhThu.Series.Add(TongDoanhThu);


            // Đảm bảo rằng mỗi loại vé(giá trị trên trục X) đều được hiển thị, kể cả khi có nhiều loại vé.
            chartDoanhThu.ChartAreas[0].AxisX.Interval = 1;
        }


        private void LoadData(string hienthi)
        {
            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }


            try
            {

                string dateTime = time.Value.ToString("yyyy-MM-dd");
                string Sql_Select = "";

                string condition = "";

                if (hienthi == "current")
                {
                    condition = "WHERE VX.TrangThaiVe = 0 and VX.NgayDatVe = CAST(GETDATE() AS DATE)";
                }
                else if (hienthi == "all")
                {
                    condition = "WHERE VX.TrangThaiVe = 0";
                }
                else if (hienthi == "custom")
                {
                    condition = $@"WHERE VX.TrangThaiVe = 0 and CONVERT(DATE, VX.NgayDatVe) = '{dateTime}'";
                }

                Sql_Select = $@"
                       SELECT 
                            CONVERT(DATE, VX.NgayDatVe) AS N'Ngày giao dịch',
                            LV.TenLoaiVe AS N'Loại vé', 
                            COUNT(VX.MaLichSuDatVe) AS N'Số vé bán được',  
                            SUM(LV.GiaVe) AS N'Thành tiền' 
                        FROM LICHSUDATVE VX
                        INNER JOIN LOAIVE LV ON VX.MaLoaiVe = LV.MaLoaiVe
                        {condition}  
                        GROUP BY 
                            CONVERT(DATE, VX.NgayDatVe),
                            LV.TenLoaiVe
                        ORDER BY CONVERT(DATE, VX.NgayDatVe) ASC, SUM(LV.GiaVe) DESC;
                ";

                // Đổ dữ liệu
                SqlDataReader drd = conn.executeSQL(Sql_Select);
                DataTable dataTable = new DataTable();

                dataTable.Load(drd);
                dgvDoanhThu.DataSource = dataTable;
                drd.Close();

                // Tính tổng doanh thu
                double tongDoanhThu = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    tongDoanhThu += Convert.ToDouble(row["Thành tiền"]);
                }

                lblTongdoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:N0} VNĐ";

                // Vẽ biểu đồ
                UpdateChart(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng liên hệ quản trị viên." + ex);
            }
            finally
            {
                conn.closeConn();
            }
        }

        private void FrmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            LoadData("current");
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 14);
            Brush brush = Brushes.Black;

            float x = 50, y = 50, rowHeight = 25, columnWidth = 180;
            float pageWidth = graphics.VisibleClipBounds.Width;

            // Vẽ tiêu đề báo cáo
            var titleFont = new Font("Arial", 16, FontStyle.Bold);
            graphics.DrawString("BÁO CÁO DOANH THU", titleFont, brush, x, y);
            y += rowHeight * 2;

            // Vẽ tiêu đề cột
            for (int i = 0; i < dgvDoanhThu.Columns.Count; i++)
            {
                graphics.FillRectangle(Brushes.LightGray, x, y, columnWidth, rowHeight);
                graphics.DrawRectangle(Pens.Black, x, y, columnWidth, rowHeight);
                graphics.DrawString(dgvDoanhThu.Columns[i].HeaderText, font, brush, x + 2, y + 2);
                x += columnWidth;
            }
            y += rowHeight;

            // Vẽ nội dung bảng
            for (int i = 0; i < dgvDoanhThu.Rows.Count; i++)
            {
                x = 50;
                for (int j = 0; j < dgvDoanhThu.Columns.Count; j++)
                {
                    var cellValue = dgvDoanhThu.Rows[i].Cells[j].Value;
                    graphics.DrawRectangle(Pens.Black, x, y, columnWidth, rowHeight);

                    string text = "";
                 

                    // kiểm tra cột có phải là ngày giao dịch không
                    if (dgvDoanhThu.Columns[j].HeaderText == "Ngày giao dịch" && cellValue is DateTime dateValue)
                    {
                        text = dateValue.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        text = cellValue.ToString();
                    }

                    graphics.DrawString(text, font, brush, x + 2, y + 2);
                    x += columnWidth;
                }
                y += rowHeight;
            }

            // Vẽ thông tin tổng cộng
            var boldFont = new Font("Arial", 14, FontStyle.Bold);
            graphics.DrawString(lblTongdoanhThu.Text, boldFont, brush, pageWidth - 80 - graphics.MeasureString(lblTongdoanhThu.Text, boldFont).Width, y + 20);
            y += rowHeight * 10;

            // Vẽ phần ký tên
            var italicFont = new Font("Arial", 14, FontStyle.Italic);
            graphics.DrawString("Vĩnh Long, ngày.. tháng... năm .....", italicFont, brush, pageWidth - 80 - graphics.MeasureString("Vĩnh Long, ngày.. tháng... năm .....", italicFont).Width, y);
            y += rowHeight;
            graphics.DrawString("Ký tên", font, brush, pageWidth - 200 - graphics.MeasureString("Ký tên", font).Width, y + 20);

            // Không cần in thêm trang
            e.HasMorePages = false;

        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            // Cấu hình sự kiện in
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Tạo đối tượng PrintPreviewDialog
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;

            // Hiển thị hộp thoại preview
            previewDialog.ShowDialog();
        }

        private void rdbHienTai_CheckedChanged(object sender, EventArgs e)
        {
            LoadData("current");
            panelCustom.Visible = false;
        }

        private void rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadData("all");
            panelCustom.Visible = false;
        }

        private void rdbTuyChinh_CheckedChanged(object sender, EventArgs e)
        {
            LoadData("custom");
            panelCustom.Visible = true;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadData("custom");

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData("current");
            time.Value = DateTime.Now;
        }
    }
}
