using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

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
            //// Xóa dữ liệu cũ trong chart
            //chartDoanhThu.Series.Clear();

            //// Tạo series cho tổng số vé bán được
            //var seriesSoVeBanDuoc = new System.Windows.Forms.DataVisualization.Charting.Series
            //{
            //    Name = "Số vé bán được",
            //    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
            //    XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
            //};

            //// Tạo series cho tổng doanh thu
            //var seriesTongDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Series
            //{
            //    Name = "Tổng doanh thu",
            //    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
            //    XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
            //};

            //// Tạo dictionary để nhóm và cộng dồn số vé và doanh thu theo ngày
            //var groupedData = new Dictionary<string, (int totalTickets, decimal totalRevenue)>();

            //// Thêm dữ liệu từ DataTable vào groupedData
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    string ngayGiaoDich = Convert.ToDateTime(row["Ngày giao dịch"]).ToString("dd/MM/yyyy"); // Lấy ngày giao dịch
            //    int soVeBanDuoc = Convert.ToInt32(row["Số vé bán được"]);
            //    decimal tongDoanhThu = Convert.ToDecimal(row["Thành tiền"]);

            //    // Nếu ngày đã tồn tại trong groupedData, cộng dồn số vé và doanh thu
            //    if (groupedData.ContainsKey(ngayGiaoDich))
            //    {
            //        groupedData[ngayGiaoDich] = (groupedData[ngayGiaoDich].totalTickets + soVeBanDuoc, groupedData[ngayGiaoDich].totalRevenue + tongDoanhThu);
            //    }
            //    else
            //    {
            //        // Nếu ngày chưa tồn tại trong groupedData, thêm mới
            //        groupedData.Add(ngayGiaoDich, (soVeBanDuoc, tongDoanhThu));
            //    }
            //}

            //// Sắp xếp dữ liệu theo thứ tự ngày giảm dần (từ ngày mới đến ngày cũ) và lấy 3 ngày gần nhất
            //var lastThreeDays = groupedData.OrderByDescending(x => DateTime.ParseExact(x.Key, "dd/MM/yyyy", null))
            //                               .Take(3) // Lấy 3 ngày gần nhất
            //                               .ToDictionary(x => x.Key, x => x.Value);

            //// Thêm dữ liệu vào chart từ lastThreeDays
            //foreach (var entry in lastThreeDays)
            //{
            //    string ngayGiaoDich = entry.Key;
            //    int totalTickets = entry.Value.totalTickets;
            //    decimal totalRevenue = entry.Value.totalRevenue;

            //    // Thêm dữ liệu vào series
            //    seriesSoVeBanDuoc.Points.AddXY(ngayGiaoDich, totalTickets);
            //    seriesTongDoanhThu.Points.AddXY(ngayGiaoDich, totalRevenue);
            //}

            //// Thêm series vào chart
            //chartDoanhThu.Series.Add(seriesSoVeBanDuoc);
            //chartDoanhThu.Series.Add(seriesTongDoanhThu);

            //// Tùy chỉnh hiển thị trục X và Y
            //chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày giao dịch gần đây"; // Hiển thị theo ngày
            //chartDoanhThu.ChartAreas[0].AxisY.Title = "Biểu đồ doanh thu"; // Tiêu đề trục Y
            //chartDoanhThu.ChartAreas[0].RecalculateAxesScale(); // Cập nhật lại tỉ lệ trục


            // Xóa dữ liệu cũ trong chart
            chartDoanhThu.Series.Clear();

            // Tạo series cho tổng số vé bán được
            var seriesSoVeBanDuoc = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Số vé bán được",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
            };

            // Tạo series cho tổng doanh thu
            var seriesTongDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Tổng doanh thu",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
            };

            // Tạo dictionary để nhóm và cộng dồn số vé và doanh thu theo ngày
            var groupedData = new Dictionary<string, (int totalTickets, decimal totalRevenue)>();

            // Thêm dữ liệu từ DataTable vào groupedData
            foreach (DataRow row in dataTable.Rows)
            {
                string ngayGiaoDich = Convert.ToDateTime(row["Ngày giao dịch"]).ToString("dd/MM/yyyy"); // Lấy ngày giao dịch
                int soVeBanDuoc = Convert.ToInt32(row["Số vé bán được"]);
                decimal tongDoanhThu = Convert.ToDecimal(row["Thành tiền"]);

                // Nếu ngày đã tồn tại trong groupedData, cộng dồn số vé và doanh thu
                if (groupedData.ContainsKey(ngayGiaoDich))
                {
                    groupedData[ngayGiaoDich] = (groupedData[ngayGiaoDich].totalTickets + soVeBanDuoc, groupedData[ngayGiaoDich].totalRevenue + tongDoanhThu);
                }
                else
                {
                    // Nếu ngày chưa tồn tại trong groupedData, thêm mới
                    groupedData.Add(ngayGiaoDich, (soVeBanDuoc, tongDoanhThu));
                }
            }

          

            // Thêm dữ liệu vào chart từ sortedData
            foreach (var entry in groupedData)
            {
                string ngayGiaoDich = entry.Key;
                int totalTickets = entry.Value.totalTickets;
                decimal totalRevenue = entry.Value.totalRevenue;

                // Thêm dữ liệu vào series
                seriesSoVeBanDuoc.Points.AddXY(ngayGiaoDich, totalTickets);
                seriesTongDoanhThu.Points.AddXY(ngayGiaoDich, totalRevenue);
            }

            // Thêm series vào chart
            chartDoanhThu.Series.Add(seriesSoVeBanDuoc);
            chartDoanhThu.Series.Add(seriesTongDoanhThu);

            // Tùy chỉnh hiển thị trục X và Y
            chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày giao dịch"; // Hiển thị theo ngày
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Biểu đồ doanh thu"; // Tiêu đề trục Y
            chartDoanhThu.ChartAreas[0].RecalculateAxesScale(); // Cập nhật lại tỉ lệ trục

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
                            ROW_NUMBER() OVER (ORDER BY CONVERT(DATE, VX.NgayDatVe) ASC, SUM(LV.GiaVe) DESC) AS N'Số thứ tự',
                            CONVERT(DATE, VX.NgayDatVe) AS N'Ngày giao dịch',
                            LV.TenLoaiVe AS N'Loại vé', 
                            COUNT(VX.MaVe) AS N'Số vé bán được',  
                            SUM(LV.GiaVe) AS N'Thành tiền' 
                        FROM VEXE VX
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
                decimal tongDoanhThu = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    tongDoanhThu += Convert.ToDecimal(row["Thành tiền"]);
                }

                lblTongdoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:N0} VNĐ";

                // Vẽ biểu đồ
                UpdateChart(dataTable);

            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng liên hệ quản trị viên.");
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
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            float x = 100; // Vị trí X để bắt đầu vẽ
            float y = 100; // Vị trí Y để bắt đầu vẽ
            float rowHeight = 25; // Chiều cao của mỗi dòng
            float columnWidth = 120; // Chiều rộng mặc định của cột
            int columns = dgvDoanhThu.Columns.Count; // Số lượng cột
            int rows = dgvDoanhThu.Rows.Count; // Số lượng dòng

            // tiêu đề
            graphics.DrawString("BÁO CÁO DOANH THU", new Font("Arial", 14, FontStyle.Bold), brush, x, y);
            y += rowHeight * 2; // Tăng khoảng cách để không chồng lên tiêu đề cột

            // Vẽ tiêu đề cột
            for (int i = 0; i < columns; i++)
            {
                graphics.FillRectangle(Brushes.LightGray, x, y, columnWidth, rowHeight);
                graphics.DrawRectangle(Pens.Black, x, y, columnWidth, rowHeight);
                graphics.DrawString(dgvDoanhThu.Columns[i].HeaderText, font, brush, x + 2, y + 2);
                x += columnWidth; // Tính toán x cho cột tiếp theo
            }
            y += rowHeight; // Cập nhật y cho dòng tiếp theo

            // Vẽ nội dung bảng
            for (int i = 0; i < rows; i++)
            {
                x = 100; // Reset x về vị trí bắt đầu
                for (int j = 0; j < columns; j++)
                {
                    graphics.DrawRectangle(Pens.Black, x, y, columnWidth, rowHeight); // Vẽ viền

                    var cellValue = dgvDoanhThu.Rows[i].Cells[j].Value;


                    if (dgvDoanhThu.Columns[j].HeaderText == "Ngày giao dịch" && cellValue is DateTime dateValue)
                    {
                        graphics.DrawString(dateValue.ToString("yyyy-MM-dd"), font, brush, x + 2, y + 2);
                    }
                    else
                    {
                        graphics.DrawString(cellValue?.ToString() ?? "", font, brush, x + 2, y + 2);
                    }

                    x += columnWidth; // Tính toán x cho cột tiếp theo
                }
                y += rowHeight; // Cập nhật y cho dòng tiếp theo
            }

            float pageWidth = graphics.VisibleClipBounds.Width;

            // Cập nhật vị trí vẽ để căn phải
            y += rowHeight;
            float textWidth = graphics.MeasureString(lblTongdoanhThu.Text, new Font("Arial", 12, FontStyle.Bold)).Width;
            graphics.DrawString(lblTongdoanhThu.Text, new Font("Arial", 12, FontStyle.Bold), brush, pageWidth - textWidth - 150, y);

            y += rowHeight * 10;
            textWidth = graphics.MeasureString("Vĩnh Long, ngày.. tháng... năm .....", new Font("Arial", 12, FontStyle.Italic)).Width;
            graphics.DrawString("Vĩnh Long, ngày.. tháng... năm .....", new Font("Arial", 12, FontStyle.Italic), brush, pageWidth - textWidth - 150, y);

            y += rowHeight;
            textWidth = graphics.MeasureString("Ký tên", new Font("Arial", 12)).Width;
            graphics.DrawString("Ký tên", new Font("Arial", 12), brush, pageWidth - textWidth - 150, y);

            // Kiểm tra xem có cần tiếp tục in không
            e.HasMorePages = false;
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            // Cấu hình sự kiện in
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Mở hộp thoại in
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
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
