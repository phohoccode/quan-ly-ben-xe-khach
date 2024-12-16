using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmQuanLyKhachHang : Form
    {
        // Tạo đối tượng Connection
        Connection db = new Connection();

        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            Connection conn = new Connection();

            bool check = conn.openConn();

            if (!check)
            {
                MessageBox.Show("Không thể kết nối với CSDL!");
                return;
            }

            // 103: định dạng dd/MM/yyyy
            string Sql_Select = $@"
                SELECT 
                    MaKhachHang as 'Mã khách hàng',
                    HoTen as 'Họ tên',
                    CONVERT(VARCHAR(10), NgaySinh, 103) as 'Ngày sinh',
                    CASE 
                       WHEN GioiTinh = 1 THEN N'Nam'
                       WHEN GioiTinh = 0 THEN N'Nữ'
                       ELSE N'Không xác định'
                    END AS N'Giới Tính',
                    SoDienThoai as 'Số điện thoại',
                    DiaChi as 'Địa chỉ',
                    Email as 'Email'
                FROM KhachHang
                WHERE TrangThai = 0
            ";

            SqlDataReader drd = conn.executeSQL(Sql_Select);

            DataTable dt = new DataTable();

            dt.Load(drd);

            dgvKhachHang.DataSource = dt;

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();

            bool check = conn.openConn();

            if (!check)
            {
                MessageBox.Show("Không thể kết nối với CSDL!");
                return;
            }

            try
            {
                string MaKhachHang = txtMaKhachHang.Text;

                if (MaKhachHang == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string Sql_Delete = $@"UPDATE KhachHang SET TrangThai = 1 WHERE MaKhachHang = '{MaKhachHang}'";

                    int kq = conn.executeUpdate(Sql_Delete);

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        LoadData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
            finally
            {
                conn.closeConn();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();

            bool check = conn.openConn();

            if (!check)
            {
                MessageBox.Show("Không thể kết nối với CSDL!");
                return;
            }


            string HoTen = txtHoTenKH.Text;
            string NgaySinh = dtpNgaySinhKH.Value.ToString("yyyy-MM-dd");
            int GioiTinh = rdbNamKH.Checked ? 1 : 0;
            string SoDienThoai = txtSDTKH.Text;
            string DiaChi = txtDiaChiKH.Text;
            string Email = txtEmail.Text;
            string MatKhau = txtMatKhau.Text;

            string Sql_FindEmail = $@"SELECT * FROM KhachHang WHERE Email = '{Email}'";

            SqlDataReader drd = conn.executeSQL(Sql_FindEmail);

            if (drd.Read())
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống!");
                return;
            }

            drd.Close();

            string Sql_Insert = $@"
                INSERT INTO KhachHang(HoTen, NgaySinh, GioiTinh, SoDienThoai, DiaChi, Email, MatKhau, MaQuyenHan, TrangThai)
                VALUES(N'{HoTen}', '{NgaySinh}', {GioiTinh}, '{SoDienThoai}', N'{DiaChi}', '{Email}', '{MatKhau}', 1, 0)";

            int kq = conn.executeUpdate(Sql_Insert);

            if (kq > 0)
            {
                MessageBox.Show("Thêm thông tin khách hàng thành công!");
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm thông tin khách hàng thất bại!");
            }
        }



        private void btnIn_Click(object sender, EventArgs e)
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

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();

            bool check = conn.openConn();

            if (!check)
            {
                MessageBox.Show("Không thể kết nối với CSDL!");
                return;
            }

            try
            {
                string MaKhachHang = txtMaKhachHang.Text;
                string HoTen = txtHoTenKH.Text;
                string NgaySinh = dtpNgaySinhKH.Value.ToString("yyyy-MM-dd");
                int GioiTinh = rdbNamKH.Checked ? 1 : 0;
                string SoDienThoai = txtSDTKH.Text;
                string DiaChi = txtDiaChiKH.Text;
                string Email = txtEmail.Text;
                string MatKhau = txtMatKhau.Text;

                if (MaKhachHang == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                    return;
                }

                string Sql_Update = $@"
                    UPDATE KhachHang SET 
                        HoTen = N'{HoTen}', 
                        NgaySinh = '{NgaySinh}', 
                        GioiTinh = {GioiTinh}, 
                        SoDienThoai = '{SoDienThoai}', 
                        DiaChi = N'{DiaChi}', 
                        Email = '{Email}', 
                        MatKhau = '{MatKhau}'
                    WHERE MaKhachHang = '{MaKhachHang}'
                ";

                int kq = conn.executeUpdate(Sql_Update);

                if (kq > 0)
                {
                    MessageBox.Show("Sửa thông tin khách hàng thành công!");
                    LoadData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin khách hàng thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
            finally
            {
                conn.closeConn();
            }
        }

        private void ResetForm()
        {
            txtDiaChiKH.Clear();
            txtEmail.Clear();
            txtHoTenKH.Clear();
            txtMaKhachHang.Clear();
            txtMatKhau.Clear();
            txtSDTKH.Clear();
            rdbNamKH.Checked = true;
            rdbNuKH.Checked = false;
            dtpNgaySinhKH.Value = DateTime.Now;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDiaChiKH.Clear();
            txtEmail.Clear();
            txtHoTenKH.Clear();
            txtMaKhachHang.Clear();
            txtMatKhau.Clear();
            txtSDTKH.Clear();
            rdbNamKH.Checked = true;
            rdbNuKH.Checked = false;
            dtpNgaySinhKH.Value = DateTime.Now;

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvKhachHang.CurrentRow;
            if (row != null)
            {
                string MaKhachHang = row.Cells[0].Value.ToString();

                // Tạo đối tượng kết nối và mở kết nối
                Connection ojbConn = new Connection();
                if (ojbConn.openConn())
                {
                    // Câu lệnh SQL để truy vấn thông tin nhân viên theo MSNV
                    string select = $@"SELECT * FROM KHACHHANG where MaKhachHang = '{MaKhachHang}'";

                    // Thực thi câu lệnh truy vấn
                    ojbConn.executeSQL(select);

                    // Kiểm tra xem có dữ liệu trả về không
                    if (ojbConn.drd.Read())
                    {
                        txtMaKhachHang.Text = ojbConn.drd["MaKhachHang"].ToString();
                        txtHoTenKH.Text = ojbConn.drd["HoTen"].ToString();
                        txtSDTKH.Text = ojbConn.drd["SoDienThoai"].ToString();
                        txtDiaChiKH.Text = ojbConn.drd["DiaChi"].ToString();
                        txtEmail.Text = ojbConn.drd["Email"].ToString();
                        txtMatKhau.Text = ojbConn.drd["MatKhau"].ToString();

                        // Xử lý giới tính
                        int gt = Convert.ToInt32(ojbConn.drd["GioiTinh"]);
                        if (gt == 1)
                        {
                            rdbNamKH.Checked = true;
                        }
                        else
                        {
                            rdbNuKH.Checked = true;
                        }

                        // Đặt giá trị cho DateTimePicker
                        dtpNgaySinhKH.Value = Convert.ToDateTime(ojbConn.drd["NgaySinh"]);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên với mã số này.");
                    }

                    // Đóng kết nối
                    ojbConn.drd.Close();
                    ojbConn.closeConn();


                }
                else
                {
                    MessageBox.Show("Không thể kết nối CSDL !!");
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            float x = 50; // Vị trí X để bắt đầu vẽ
            float y = 50; // Vị trí Y để bắt đầu vẽ
            float rowHeight = 25; // Chiều cao của mỗi dòng

            // Mảng chứa chiều rộng của từng cột
            float[] columnWidths = { 120, 120, 80, 80, 120, 100 }; // Ví dụ: 6 cột với độ rộng khác nhau

            int columns = columnWidths.Length; // Số lượng cột cần in
            int rows = dgvKhachHang.Rows.Count; // Số lượng dòng

            // Tiêu đề
            graphics.DrawString("DANH SÁCH KHÁCH HÀNG", new Font("Arial", 14, FontStyle.Bold), brush, x, y);
            y += rowHeight * 2; // Tăng khoảng cách để không chồng lên tiêu đề cột

            // Vẽ tiêu đề cột
            for (int i = 0; i < columns; i++)
            {
                float currentColumnWidth = columnWidths[i]; // Lấy chiều rộng cột hiện tại
                graphics.FillRectangle(Brushes.LightGray, x, y, currentColumnWidth, rowHeight);
                graphics.DrawRectangle(Pens.Black, x, y, currentColumnWidth, rowHeight);
                graphics.DrawString(dgvKhachHang.Columns[i].HeaderText, font, brush, x + 2, y + 2);
                x += currentColumnWidth; // Tăng x theo độ rộng của cột hiện tại
            }
            y += rowHeight; // Cập nhật y cho dòng tiếp theo

            // Vẽ nội dung bảng
            for (int i = 0; i < rows; i++)
            {
                x = 50; // Reset x về vị trí bắt đầu
                for (int j = 0; j < columns; j++)
                {
                    float currentColumnWidth = columnWidths[j]; // Lấy chiều rộng cột hiện tại
                    graphics.DrawRectangle(Pens.Black, x, y, currentColumnWidth, rowHeight); // Vẽ viền

                    var cellValue = dgvKhachHang.Rows[i].Cells[j].Value;

                    if (dgvKhachHang.Columns[j].HeaderText == "Ngày sinh" && cellValue is DateTime dateValue)
                    {
                        // Định dạng ngày tháng
                        graphics.DrawString(dateValue.ToString("yyyy-MM-dd"), font, brush, x + 2, y + 2);
                    }
                    else
                    {
                        // Hiển thị giá trị khác
                        graphics.DrawString(cellValue?.ToString() ?? "", font, brush, x + 2, y + 2);
                    }

                    x += currentColumnWidth; // Tăng x theo độ rộng của cột hiện tại
                }
                y += rowHeight; // Cập nhật y cho dòng tiếp theo
            }

            // Kiểm tra xem có cần tiếp tục in không
            e.HasMorePages = false;

        }
    }
}
