using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmChamCongNhanVien : Form
    {
        public FrmChamCongNhanVien()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            // Tạo đối tượng Connection
            Connection db = new Connection();

            bool check_conn = db.openConn();

            if (check_conn == false)
            {
                db.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }

            try
            {
                string query = @"
                   SELECT 
                        nv.MaNhanVien AS N'Mã nhân viên',
                        nv.HoTen AS N'Họ tên',   
                        nv.NgaySinh AS N'Ngày sinh',
                        cv.TenCongViec AS N'Tên công việc',
                        COALESCE(cc.NgayChamCong, CONVERT(date, GETDATE())) AS N'Ngày chấm công',
                        CASE 
                            WHEN COALESCE(cc.TrangThai, 0) = 0 THEN N'Chưa chấm công'
                            WHEN cc.TrangThai = 1 THEN N'Đã chấm công'
                        END AS N'Trạng thái'
                    FROM NHANVIEN nv
                    LEFT JOIN CHAMCONG cc ON nv.MaNhanVien = cc.MaNhanVien
                    JOIN CONGVIEC cv ON nv.MaCongViec = cv.MaCongViec;";


                SqlDataReader drd = db.executeSQL(query);

                if (drd.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(drd);
                    dtgChamCong.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chấm công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
            finally
            {
                db.closeConn();
            }

        }

        private void FrmChamCongNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TimKiemNhanVien()
        {
            try
            {
                string maNhanVien = txtMsNhanVien.Text.Trim();

                if (maNhanVien == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên để tìm kiếm!");
                    return;
                }

                bool timthay = false;
                foreach (DataGridViewRow row in dtgChamCong.Rows)
                {
                    // Kiểm tra xem ô "Mã nhân viên" có giá trị null không
                    if (row.Cells["Mã nhân viên"].Value != null)
                    {
                        string maNhanVienRow = row.Cells["Mã nhân viên"].Value.ToString();

                        // Kiểm tra nếu mã nhân viên trong ô trùng với mã nhân viên cần tìm
                        if (maNhanVienRow == maNhanVien)
                        {
                            // Cập nhật thông tin vào các textbox
                            txtHoTen.Text = row.Cells["Họ tên"].Value.ToString();
                            txtTrangThai.Text = row.Cells["Trạng thái"].Value.ToString();
                            txtNgaySinh.Text = Convert.ToDateTime(row.Cells["Ngày sinh"].Value).ToString("dd/MM/yyyy");
                            txtCongViec.Text = row.Cells["Tên công việc"].Value.ToString();
                            timthay = true;
                            break; // Dừng vòng lặp khi tìm thấy
                        }
                    }
                }


                if (!timthay)
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã " + maNhanVien);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }

        private void hanhDongChamCong(string hanhdong)
        {
            Connection db = new Connection();

            bool check_conn = db.openConn();
            if (check_conn == false)
            {
                db.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;
            }

            try
            {
                string MaNhanVien = txtMsNhanVien.Text.Trim();
                string NgayChamCong = DateTime.Now.ToString("yyyy-MM-dd");
                string TrangThai = txtTrangThai.Text.Trim();


                if (MaNhanVien == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên!");
                    return;
                }

                string Sql_Insert = "";
                string Sql_Update = "";
                int kq = -1;

                if (TrangThai == "Chưa chấm công")
                {
                    if (hanhdong == "chamcong")
                    {
                        Sql_Insert = $@"INSERT ChamCong (NgayChamCong, TrangThai, MaNhanVien) values ('{NgayChamCong}',1, {MaNhanVien})";
                    
                        kq = db.executeUpdate(Sql_Insert);

                        if (kq > 0)
                        {
                            MessageBox.Show("Chấm công thành công !!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Chấm công thất bại !!");
                        }
                    }
                    else if (hanhdong == "xoachamcong")
                    {
                        MessageBox.Show("Nhân viên chưa chấm công nên không thể xoá chấm công !!");
                    }
                }
                else
                {
                    if (hanhdong == "chamcong")
                    {
                        MessageBox.Show("Nhân viên đã chấm công nên không thể chấm công !!");
                    }
                    else if (hanhdong == "xoachamcong")
                    {
                        Sql_Update = $@"UPDATE ChamCong Set TrangThai = 0 WHERE MaNhanVien = '{MaNhanVien}'";
                      
                        kq = db.executeUpdate(Sql_Update);

                        if (kq > 0)
                        {
                            MessageBox.Show("Xoá chấm công thành công !!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Xoá chấm công thất bại !!");
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex);
            }
            finally
            {
                db.closeConn();
            }
        }


        private void btnChamCong_Click(object sender, EventArgs e)
        {
            hanhDongChamCong("chamcong");
            ResetForm();
        }

        private void btnXoaChamCong_Click(object sender, EventArgs e)
        {
            hanhDongChamCong("xoachamcong");
            ResetForm();
        }



        private void InBangLuong(PrintPageEventArgs args, string MaNhanVien, decimal tongLuong, DataTable dataTable)
        {
            Graphics g = args.Graphics;
            Font font = new Font("Arial", 14); // Chữ thông thường lớn hơn
            Font boldFont = new Font("Arial", 16, FontStyle.Bold); // Font đậm lớn cho tiêu đề và tổng lương
            Font headerFont = new Font("Arial", 14, FontStyle.Bold); // Font cho tiêu đề bảng
            int yPos = 20;

            // Tiêu đề
            g.DrawString("Bảng Lương Tháng Của Nhân Viên", boldFont, Brushes.Black, 100, yPos);
            yPos += 40;

            // Vẽ đường viền dưới tiêu đề
            g.DrawLine(Pens.Black, 100, yPos, 500, yPos);
            yPos += 10;

            // Lấy thông tin nhân viên từ DataTable
            DataRow firstRow = dataTable.Rows[0];
            string hoTen = firstRow["HoTen"].ToString();
            string ngaySinh = Convert.ToDateTime(firstRow["NgaySinh"]).ToString("dd/MM/yyyy");
            string sdt = firstRow["SoDienThoai"].ToString();
            string diaChi = firstRow["DiaChi"].ToString();
            string congViec = firstRow["TenCongViec"].ToString();

            // In thông tin nhân viên, căn trái và sử dụng font lớn
            g.DrawString($"Mã nhân viên: {MaNhanVien}", font, Brushes.Black, 100, yPos);
            yPos += 30;
            g.DrawString($"Họ và tên: {hoTen}", font, Brushes.Black, 100, yPos);
            yPos += 30;
            g.DrawString($"Ngày sinh: {ngaySinh}", font, Brushes.Black, 100, yPos);
            yPos += 30;
            g.DrawString($"Số điện thoại: {sdt}", font, Brushes.Black, 100, yPos);
            yPos += 30;
            g.DrawString($"Địa chỉ: {diaChi}", font, Brushes.Black, 100, yPos);
            yPos += 30;
            g.DrawString($"Công việc: {congViec}", font, Brushes.Black, 100, yPos);
            yPos += 40;

            // Vẽ đường viền dưới thông tin nhân viên
            g.DrawLine(Pens.Black, 100, yPos, 500, yPos);
            yPos += 10;

            // Tiêu đề cho bảng chấm công
            g.DrawString("Ngày Chấm Công", headerFont, Brushes.Black, 100, yPos);
            g.DrawString("Trạng Thái", headerFont, Brushes.Black, 300, yPos);
            yPos += 30;

            // Vẽ đường viền dưới tiêu đề bảng
            g.DrawLine(Pens.Black, 100, yPos, 500, yPos);
            yPos += 10;

            // Duyệt qua bảng dữ liệu và in thông tin chấm công
            int rowIndex = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                string ngayChamCong = Convert.ToDateTime(row["NgayChamCong"]).ToString("dd/MM/yyyy");
                int trangThai = Convert.ToInt32(row["TrangThai"]);

                string trangThaiText = "";

                if (trangThai == 1)
                {
                    trangThaiText = "Đã chấm công";
                }
                else if (trangThai == 2)
                {
                    trangThaiText = "Chưa chấm công";
                }

                // Thêm màu nền nhẹ cho các dòng để làm nổi bật
                if (rowIndex % 2 == 0)
                {
                    g.FillRectangle(Brushes.LightGray, 100, yPos, 400, 30);
                }

                // Căn chỉnh thông tin cho cột
                g.DrawString($"{ngayChamCong}", font, Brushes.Black, 100, yPos);
                g.DrawString($"{trangThaiText}", font, Brushes.Black, 300, yPos);
                yPos += 30;

                rowIndex++;
            }

            // Vẽ đường viền dưới bảng
            g.DrawLine(Pens.Black, 100, yPos, 500, yPos);
            yPos += 20;

            // In tổng lương, căn phải và làm nổi bật
            g.DrawString($"Tổng Lương Tháng: {tongLuong:N0} VND", boldFont, Brushes.Black, 100, yPos);
        }

        private void ResetForm()
        {
            txtMsNhanVien.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            txtTrangThai.Text = string.Empty;
            txtCongViec.Text = string.Empty;

            // Reset các RadioButton

            // Đặt lại DateTimePicker về ngày hiện tại
            dtpNgayChamCong.Value = DateTime.Now;
        }

        private void dtgChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void cheDoNut(bool mode)
        {
            btnTimKiem.Enabled = mode;
            btnInLuong.Enabled = mode;
            btnChamCong.Enabled = mode;
            btnXoaChamCong.Enabled = mode;
        }



        private void btnInLuong_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMsNhanVien.Text.Trim();

            if (maNhanVien != "")
            {
                Connection conn = new Connection();

                bool check_conn = conn.openConn();

                if (!check_conn)
                {
                    conn.closeConn();
                    MessageBox.Show("Kết nối thất bại");
                    return;

                }

                // Lấy tháng và năm từ DateTimePicker
                int thang = dtpNgayChamCong.Value.Month;
                int nam = dtpNgayChamCong.Value.Year;

                // Truy vấn lấy dữ liệu chấm công của nhân viên trong tháng
                string query = $@"
                    SELECT 
                        nv.MaNhanVien,
                        nv.HoTen,
                        nv.NgaySinh,
                        nv.SoDienThoai,
                        nv.DiaChi,
                        cv.TenCongViec,
                        cc.NgayChamCong,
                        cc.TrangThai
                    FROM 
                        NhanVien nv
                    INNER JOIN 
                        ChamCong cc ON nv.MaNhanVien = cc.MaNhanVien
                    JOIN    
                        CongViec cv ON nv.MaCongViec = cv.MaCongViec
                    WHERE 
                        nv.MaNhanVien = '{maNhanVien}'
                        AND MONTH(cc.NgayChamCong) = '{thang}'
                        AND YEAR(cc.NgayChamCong) = '{nam}'
                    ORDER BY 
                        cc.NgayChamCong;";

                SqlDataReader drd = conn.executeSQL(query);

                DataTable dataTable = new DataTable();

                dataTable.Load(drd);


                decimal tongLuong = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    int trangThai = Convert.ToInt32(row["TrangThai"]);

                    if (trangThai == 1) // Nếu có mặt thì tính lương 250k
                    {
                        tongLuong += 250000; // Tính lương cho ngày có mặt
                    }
                    // Nếu trạng thái là "Vắng mặt" thì không cộng lương

                }

                // Tạo và in báo cáo lương
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (s, args) => InBangLuong(args, maNhanVien, tongLuong, dataTable);
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog(); // Hiển thị cửa sổ xem trước khi in


                drd.Close();
                conn.closeConn();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để in bản lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpNgayChamCong_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayLuaChon = dtpNgayChamCong.Value.Date;
            DateTime ngayHienTai = DateTime.Now.Date;


            if (ngayLuaChon == ngayHienTai)
            {
                cheDoNut(true);
                LoadData();
            }
            else
            {
                cheDoNut(false);

                // Tạo đối tượng Connection
                Connection db = new Connection();

                bool check_conn = db.openConn();

                if (check_conn == false)
                {
                    db.closeConn();
                    MessageBox.Show("Kết nối thất bại");
                    return;

                }

                try
                {
                    string query = $@"
                       SELECT 
                            nv.MaNhanVien AS N'Mã nhân viên',
                            nv.HoTen AS N'Họ tên',   
                            nv.NgaySinh AS N'Ngày sinh',
                            cv.TenCongViec AS N'Tên công việc',
                            COALESCE(cc.NgayChamCong, CONVERT(date, GETDATE())) AS N'Ngày chấm công',
                            CASE 
                                WHEN COALESCE(cc.TrangThai, 0) = 0 THEN N'Chưa chấm công'
                                WHEN cc.TrangThai = 1 THEN N'Có mặt'
                                WHEN cc.TrangThai = 2 THEN N'Vắng'
                            END AS N'Trạng thái'
                        FROM NHANVIEN nv
                        LEFT JOIN CHAMCONG cc ON nv.MaNhanVien = cc.MaNhanVien
                        JOIN CONGVIEC cv ON nv.MaCongViec = cv.MaCongViec
                        WHERE CAST(cc.NgayChamCong AS DATE) = '{ngayLuaChon}';
                    ";


                    SqlDataReader drd = db.executeSQL(query);

                    if (drd.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(drd);
                        dtgChamCong.DataSource = dt;
                    }
                    else
                    {
                        cheDoNut(true);
                        MessageBox.Show("Không có dữ liệu chấm công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);

                }
                finally
                {
                    db.closeConn();
                }

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Reset các TextBox
            txtMsNhanVien.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
       
            txtCongViec.Text = string.Empty;

            // Reset các RadioButton

            // Đặt lại DateTimePicker về ngày hiện tại
            dtpNgayChamCong.Value = DateTime.Now;
            dtgChamCong.DataSource = null;
            LoadData();
        }
    }
}
