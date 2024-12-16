using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmNhanVien : Form
    {
        // Tạo đối tượng Connection

        private bool err = false;
        int idNV = -1;

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            Connection db = new Connection();

            bool check_conn = db.openConn();

            if (!check_conn)
            {
                db.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }


            try
            {

                string query_nhanvien = @"
                    SELECT 
                        nv.MaNhanVien as N'Mã nhân viên',
                        nv.HoTen as N'Họ Tên',
                        nv.SoDienThoai AS N'Số điện thoại',
                        FORMAT(nv.NgaySinh, 'dd/MM/yyyy') AS N'Ngày Sinh',
                        CASE 
                            WHEN nv.GioiTinh = 0 THEN N'Nam'
                            WHEN nv.GioiTinh = 1 THEN N'Nữ'
                            ELSE N'Không xác định'
                        END AS N'Giới Tính',
                        nv.DiaChi AS N'Địa Chỉ',
                        cv.TenCongViec AS N'Công Việc',
                        nv.Email as N'Email',
                        nv.MatKhau as N'Mật Khẩu'
                    FROM Nhanvien nv, CongViec cv
                    WHERE nv.MaCongViec = cv.MaCongViec";

                SqlDataReader drd_nhanvien = db.executeSQL(query_nhanvien);

                DataTable dt = new DataTable();

                dt.Load(drd_nhanvien);

                dtgThongTinNhanVien.DataSource = dt;

                drd_nhanvien.Close();

                // load dữ liệu vào combobox
                string query_congviec = "SELECT * FROM CongViec";

                SqlDataReader drd_congviec = db.executeSQL(query_congviec);

                cbCongViec.Items.Clear();

                while (drd_congviec.Read())
                {
                    cbCongViec.Items.Add(drd_congviec["TenCongViec"].ToString() + " - " + drd_congviec["MaCongViec"].ToString());
                }

                cbCongViec.SelectedIndex = 0;

                drd_congviec.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
            finally
            {
                db.closeConn();
            }

        }

        private void Hoatdong(bool enable)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Enabled = enable;
            }

            txtDiaChi.Enabled = enable;
            txtHoTen.Enabled = enable;
            txtSDT.Enabled = enable;
            dtpNgaySinh.Enabled = enable;
            rdbNam.Enabled = enable;
            rdbNu.Enabled = enable;

        }

        private void ResetForm()
        {
            // Xóa nội dung các trường nhập liệu

            txtMSNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMSNV.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            cbCongViec.SelectedIndex = 0;


            // Đặt giá trị mặc định cho các điều khiển khác
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            // Xóa lựa chọn trong DataGridView (nếu có)
            if (dtgThongTinNhanVien.SelectedRows.Count > 0)
            {
                dtgThongTinNhanVien.ClearSelection();
            }

            // Đặt lại trạng thái ID nhân viên
            idNV = -1;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            // Reset tất cả các trường nhập liệu
            ResetForm();

            // Bật lại tất cả các điều khiển
            Hoatdong(true);
        }

        private void ClearFields()
        {
            txtMSNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            cbCongViec.SelectedIndex = 0;
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            Connection db = new Connection();
            bool check_conn = db.openConn();
            if (!check_conn)
            {
                db.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }

            try
            {
                // Lấy thông tin từ các TextBox
                string MsNhanVien = txtMSNV.Text.Trim();
                string HoTen = txtHoTen.Text.Trim();
                string SDT = txtSDT.Text.Trim();
                string DiaChi = txtDiaChi.Text.Trim();
                DateTime NgaySinh = dtpNgaySinh.Value.Date;
                string GioiTinh = rdbNam.Checked ? "0" : (rdbNu.Checked ? "1" : "");
                string CongViec = cbCongViec.SelectedItem.ToString();
                string email = txtEmail.Text.Trim();
                string password = txtMatKhau.Text.Trim();
                string macongviec = cbCongViec.SelectedItem.ToString().Split('-')[1].Trim();

                if (HoTen == "" || SDT == "" || DiaChi == "" || email == "" || password == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                int NamHienTai = DateTime.Now.Year;
                int NamSinh = NgaySinh.Year;

                if (NamHienTai - NamSinh < 18)
                {
                    MessageBox.Show("Nhân viên phải đủ 18 tuổi trở lên!");
                    return;
                }

                if (SDT.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải đủ 10 chữ số!");
                    return;
                }

             


                string query = $@"SELECT * FROM NHANVIEN WHERE Email ='{email}' ";
                SqlDataReader drd = db.executeSQL(query);
                
                if (drd.HasRows)
                {
                    MessageBox.Show("Email đã tồn tại !!!");
                    return;
                }
                drd.Close();

                string insert = $@"INSERT INTO Nhanvien (HoTen, SoDienThoai, DiaChi, NgaySinh, GioiTinh, MaCongViec, Email, MatKhau, MaQuyenHan) 
                                 VALUES (N'{HoTen}', '{SDT}', N'{DiaChi}', '{NgaySinh}','{GioiTinh}', '{macongviec}', '{email}', '{password}', 2)";
                int kq = db.executeUpdate(insert);

                if (kq > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadData(); // Tải lại dữ liệu
                    ClearFields(); // Xóa nội dung nhập
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn trong DataGridView không
                if (dtgThongTinNhanVien.SelectedRows.Count == 0 || dtgThongTinNhanVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dtgThongTinNhanVien.CurrentRow;


                int MaNhanVien = Convert.ToInt32(row.Cells["Mã nhân viên"].Value);

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này?\n" +
                    "MSNV: " + row.Cells["Mã nhân viên"].Value + "\n" +
                    "Họ tên: " + row.Cells["Họ tên"].Value,
                    "Xóa thông tin nhân viên",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (rs == DialogResult.Yes)
                {
                    // Tạo đối tượng Connection
                    Connection ojbConn = new Connection();

                    // Mở kết nối
                    if (ojbConn.openConn())
                    {
                        // Thực hiện câu lệnh DELETE
                        string delStr = "DELETE FROM Nhanvien WHERE MaNhanVien = " + MaNhanVien;
                        int kq = ojbConn.executeUpdate(delStr);

                        if (kq > 0)
                        {
                            MessageBox.Show("Xóa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu
                            ResetForm(); // Xóa nội dung trong các TextBox
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Đóng kết nối
                        ojbConn.closeConn();
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                //Hoatdong(true);
                //btnThem.Enabled = true;
                //btnXoa.Enabled = true;
                //btnLamLai.Enabled = true;
            }
            else if (btnSua.Text == "Lưu")
            {
                // Kiểm tra xem có nhân viên nào đã chọn để cập nhật không
                DataGridViewRow row = dtgThongTinNhanVien.CurrentRow;
                if (row == null)
                {
                    MessageBox.Show("Chưa chọn nhân viên để chỉnh sửa.");
                    return;
                }

                // Lấy idNhanVien từ dòng hiện tại
                int maNhanVien = Convert.ToInt32(row.Cells["Mã nhân viên"].Value);

                // Tạo đối tượng kết nối CSDL
                Connection ojbConn = new Connection();

                // Mở kết nối
                if (ojbConn.openConn())
                {

                    int gt = rdbNu.Checked ? 1 : 0;

                    string upStr = $@"update NhanVien 
                        set HoTen = N'{txtHoTen.Text}',
                            SoDienThoai = '{txtSDT.Text}',
                            DiaChi = N'{txtDiaChi.Text}',
                            NgaySinh = '{dtpNgaySinh.Value.Date}',
                            GioiTinh = {gt},
                            MaCongViec = {cbCongViec.SelectedIndex + 1},
                            Email = '{txtEmail.Text}',
                            MatKhau = '{txtMatKhau.Text}'
                        where MaNhanVien = '{txtMSNV.Text}'
                    ";

                    // Thực hiện câu lệnh UPDATE
                    int kq = ojbConn.executeUpdate(upStr);
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công !!!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin nhân viên !!!");
                    }

                    // Đóng kết nối
                    ojbConn.closeConn();

                    // Tải lại dữ liệu và reset form
                    LoadData();
                    Hoatdong(true);
                    ResetForm();
                    btnSua.Text = "Sửa";
                }
                else
                {
                    MessageBox.Show("Không thể kết nối CSDL !!!");
                    Hoatdong(false);
                    btnSua.Text = "Sửa";
                }
            }
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgThongTinNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgThongTinNhanVien.CurrentRow;
            if (row != null)
            {
                // Lấy MSNV từ cột tương ứng
                string MsNhanVien = row.Cells[0].Value.ToString();

                // Tạo đối tượng kết nối và mở kết nối
                Connection ojbConn = new Connection();
                if (ojbConn.openConn())
                {
                    // Câu lệnh SQL để truy vấn thông tin nhân viên theo MSNV
                    string select = $@"select * from nhanvien where MaNhanVien = '{MsNhanVien}'";

                    // Thực thi câu lệnh truy vấn
                    ojbConn.executeSQL(select);

                    // Kiểm tra xem có dữ liệu trả về không
                    if (ojbConn.drd.Read())
                    {
                        txtMSNV.Text = ojbConn.drd["MaNhanVien"].ToString();
                        txtHoTen.Text = ojbConn.drd["HoTen"].ToString();
                        txtSDT.Text = ojbConn.drd["SoDienThoai"].ToString();
                        txtDiaChi.Text = ojbConn.drd["DiaChi"].ToString();
                        txtEmail.Text = ojbConn.drd["Email"].ToString();
                        txtMatKhau.Text = ojbConn.drd["MatKhau"].ToString();
                        cbCongViec.SelectedIndex = Convert.ToInt32(ojbConn.drd["MaCongViec"].ToString()) - 1;

                        // Xử lý giới tính
                        int gt = Convert.ToInt32(ojbConn.drd["GioiTinh"]);
                        if (gt == 0)
                        {
                            rdbNam.Checked = true;
                        }
                        else
                        {
                            rdbNu.Checked = true;
                        }

                        // Đặt giá trị cho DateTimePicker
                        dtpNgaySinh.Value = Convert.ToDateTime(ojbConn.drd["NgaySinh"]);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên với mã số này.");
                    }

                    // Đóng kết nối
                    ojbConn.drd.Close();
                    ojbConn.closeConn();

                    // Không cho phép chỉnh sửa thông tin
                    //Hoatdong(false);
                }
                else
                {
                    MessageBox.Show("Không thể kết nối CSDL !!");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
