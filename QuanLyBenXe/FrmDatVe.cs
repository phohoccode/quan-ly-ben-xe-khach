using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmDatVe : Form
    {

        public FrmDatVe()
        {
            InitializeComponent();
            HienDSDiemDi();
            HienDSDiemDen();
            HienDSLoaiVe();
        }

        private void HienDSDiemDi()
        {

            Connection connection = new Connection();
            bool check_conn = connection.openConn();
            if (check_conn == false)
            {
                connection.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }
            string Sql = $@"Select * from LichTrinh";

            SqlDataReader drd = connection.executeSQL(Sql);

            while (drd.Read())
            {
                string MaLoaiVe = drd["DiemXuatPhat"].ToString();


                cmbDiemDi.Items.Add(MaLoaiVe);
            }
            cmbDiemDi.SelectedIndex = 0;


        }
        private void HienDSDiemDen()
        {

            Connection connection = new Connection();
            bool check_conn = connection.openConn();
            if (check_conn == false)
            {
                connection.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }
            string Sql = $@"Select * from LichTrinh";

            SqlDataReader drd = connection.executeSQL(Sql);

            while (drd.Read())
            {
                string MaLoaiVe = drd["DiemDen"].ToString();


                cmbDiemDen.Items.Add(MaLoaiVe);
            }
            cmbDiemDen.SelectedIndex = 0;

        }
        private void HienDSLoaiVe()
        {
            Connection connection = new Connection();
            bool check_conn = connection.openConn();
            if (check_conn == false)
            {
                connection.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }
            string Sql = $@"SELECT * FROM LoaiVe WHERE TrangThai = 0";

            SqlDataReader drd = connection.executeSQL(Sql);

            while (drd.Read())
            {
                string MaLoaiVe = drd["MaLoaiVe"].ToString();
                string TenLoaiVe = drd["TenLoaiVe"].ToString();
                string GiaVe = drd["GiaVe"].ToString();
                if (txtGiaVe.Text == "")
                {
                    txtGiaVe.Text = GiaVe;
                }

                cbLoaiVe.Items.Add(TenLoaiVe + "-" + MaLoaiVe);
            }
            cbLoaiVe.SelectedIndex = 0;


        }

        private void LoadData()
        {
            Connection connection = new Connection();
            bool check_conn = connection.openConn();
            if (check_conn == false)
            {
                connection.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }

            string query = @"SELECT 
                xk.MaXe AS [Mã Xe],
                xk.TenNhaXe AS [Tên Nhà Xe],
                xk.SoChoNgoi AS [Số Chỗ Ngồi],
                xk.BienSo AS [Biển Số],
                xk.LoaiXe AS [Loại Xe],
                xk.TrangThai AS [TrangThai],              
                lt.TuyenDuong AS [Tuyến Đường],
                lt.DiemXuatPhat AS [Điểm Xuất Phát],
                lt.DiemDen AS [Điểm Đến],
                lt.NgayKhoiHanh AS [Ngày Khởi Hành],
                lt.GioKhoiHanh AS [Giờ Khởi Hành],
                lt.TrangThai AS [Trạng Thái]
            FROM XEKHACH xk
            JOIN LICHTRINH lt ON xk.MaXe = lt.MaXe   
           ";

            SqlDataReader reader = connection.executeSQL(query);

            DataTable dt = new DataTable();

            dt.Load(reader);   
         
            
            dtgLichTrinh.DataSource = dt;

         

            // Kiểm tra nếu cột "Đặt Vé" chưa tồn tại
            if (!dtgLichTrinh.Columns.Contains("btnDatVe"))
            {
                // Tạo cột button
                DataGridViewButtonColumn btnDatVe = new DataGridViewButtonColumn();
                btnDatVe.Name = "btnDatVe"; // Tên cột
                btnDatVe.HeaderText = "Đặt Vé"; // Tiêu đề cột
                btnDatVe.Text = "Đặt Vé"; // Text trên nút
                btnDatVe.UseColumnTextForButtonValue = true; // Hiển thị Text
                btnDatVe.Width = 80; // Đặt chiều rộng
                dtgLichTrinh.Columns.Add(btnDatVe);
            }
            dtgLichTrinh.Columns["Trạng Thái"].Visible = false;
        }


        private void FrmDatVe_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        public void VoHieuHoa()
        {
            // Vô hiệu hóa các TextBox
            txtHoTen.Enabled = false;

            txtSDT.Enabled = false;
        }

        private void btnTraThongTin_Click(object sender, EventArgs e)
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
                string query = $@"
                   SELECT * FROM KhachHang WHERE MaKhachHang = '{txtMaKhachHang.Text}' ";
                SqlDataReader reader = db.executeSQL(query);
                while (reader.Read())
                {
                    txtHoTen.Text = reader["HoTen"].ToString();
                    txtSDT.Text = reader["SoDienThoai"].ToString();
                }
                reader.Close();
                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
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

        private void btnTimKiem_Click(object sender, EventArgs e)
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
            string DiemDi = cmbDiemDi.SelectedItem?.ToString(); // Lấy giá trị từ ComboBox Điểm Đi
            string DiemDen = cmbDiemDen.SelectedItem?.ToString(); // Lấy giá trị từ ComboBox Điểm Đến
            string NgayKhoiHanh = dtpNgayKhoiHanh.Value.ToString("yyyy-MM-dd"); // Lấy ngày khởi hành (định dạng yyyy-MM-dd)

            // Kiểm tra xem người dùng có chọn giá trị nào không
            if (DiemDi == "" || DiemDen == "")
            {
                MessageBox.Show("Vui lòng chọn cả Điểm Đi và Điểm Đến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xây dựng câu truy vấn SQL
            string query = $@"SELECT 
                xk.MaXe AS [Mã Xe],
                xk.TenNhaXe AS [Tên Nhà Xe],
                xk.SoChoNgoi AS [Số Chỗ Ngồi],
                xk.BienSo AS [Biển Số],
                xk.LoaiXe AS [Loại Xe],
                xk.TrangThai AS [TrangThai],              
                lt.TuyenDuong AS [Tuyến Đường],
                lt.DiemXuatPhat AS [Điểm Xuất Phát],
                lt.DiemDen AS [Điểm Đến],
                lt.NgayKhoiHanh AS [Ngày Khởi Hành],
                lt.GioKhoiHanh AS [Giờ Khởi Hành],
                lt.TrangThai AS [Trạng Thái]
              
            FROM XEKHACH xk 
            JOIN LICHTRINH lt ON xk.MaXe = lt.MaXe  
            WHERE lt.DiemXuatPhat = N'{DiemDi}' AND
                  lt.DiemDen = N'{DiemDen}' AND
                  lt.NgayKhoiHanh = '{NgayKhoiHanh}';
                  
                  
           ";
            SqlDataReader reader = db.executeSQL(query);
            DataTable dt = new DataTable();
            dt.Load(reader);
            dtgLichTrinh.DataSource = dt;
            reader.Close();

        }

        private void dtgLichTrinh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgLichTrinh.Columns[e.ColumnIndex].Name == "btnDatVe")
            {
                int TrangThai = Convert.ToInt32(dtgLichTrinh.Rows[e.RowIndex].Cells["Trạng Thái"].Value);

                // Nếu trạng thái là "Hoạt động" (0), nút sẽ hoạt động
                if (TrangThai == 0)
                {
                    e.Value = "Đặt Vé";
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
                // Nếu trạng thái là "Không hoạt động" hoặc "Bảo trì", nút bị vô hiệu hóa
                else
                {
                    e.Value = "Không khả dụng";
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.ForeColor = Color.DarkGray;
                }
            }
        }

        private void dtgLichTrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgLichTrinh.Columns["btnDatVe"].Index)
            {
                int TrangThai = Convert.ToInt32(dtgLichTrinh.Rows[e.RowIndex].Cells["Trạng Thái"].Value);

                if (TrangThai != 0) // Nếu trạng thái không phải "Hoạt động"
                {
                    MessageBox.Show("Không thể đặt vé khi tuyến đường không hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu thông tin khách hàng chưa đầy đủ
                if (txtHoTen.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin từ dòng hiện tại của DataGridView
                string MsKhachHang = txtMaKhachHang.Text.Trim();
                string HoTen = txtHoTen.Text;

                string SDT = txtSDT.Text;
                string MaXe = dtgLichTrinh.Rows[e.RowIndex].Cells["Mã Xe"].Value.ToString();
                string TuyenDuong = dtgLichTrinh.Rows[e.RowIndex].Cells["Tuyến Đường"].Value.ToString();
                string DiemXuatPhat = dtgLichTrinh.Rows[e.RowIndex].Cells["Điểm Xuất Phát"].Value.ToString();
                string DiemDen = dtgLichTrinh.Rows[e.RowIndex].Cells["Điểm Đến"].Value.ToString();
                string NgayKhoiHanh = dtgLichTrinh.Rows[e.RowIndex].Cells["Ngày Khởi Hành"].Value.ToString();
                string GioKhoiHanh = dtgLichTrinh.Rows[e.RowIndex].Cells["Giờ Khởi Hành"].Value.ToString();
                string LoaiVe = cbLoaiVe.Text;
                string GiaVe = txtGiaVe.Text;
                string BienSo = dtgLichTrinh.Rows[e.RowIndex].Cells["Biển Số"].Value.ToString();
                string TenNhaXe = dtgLichTrinh.Rows[e.RowIndex].Cells["Tên Nhà Xe"].Value.ToString();
                // Tạo Form Thanh Toán và truyền thông tin vào
                FrmThanhToan frmThanhToan = new FrmThanhToan();
                frmThanhToan.SetThongTin(MsKhachHang, HoTen, SDT, MaXe, TuyenDuong, DiemXuatPhat, DiemDen, NgayKhoiHanh, GioKhoiHanh, LoaiVe, GiaVe, BienSo, TenNhaXe);

                // Hiển thị form Thanh Toán
                frmThanhToan.Show();

            }
        }

        private void cmbLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
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

                // vevip-1
                string MaLoaiVe = cbLoaiVe.Text.Split('-')[1].ToString();
                string query = $@"
                   SELECT * FROM LOAIVE WHERE MALOAIVE = '{MaLoaiVe}' ";
                SqlDataReader reader = db.executeSQL(query);
                while (reader.Read())
                {
                    txtGiaVe.Text = reader["GiaVe"].ToString();

                }
                reader.Close();
                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtMaKhachHang.Text = "";
            cbLoaiVe.SelectedIndex = 0;
            cmbDiemDen.SelectedIndex = 0;
            cmbDiemDi.SelectedIndex = 0;
            LoadData();
            dtpNgayKhoiHanh.Value = DateTime.Now;
        }
    }
}
