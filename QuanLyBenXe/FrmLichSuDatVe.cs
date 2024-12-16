using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenXe
{

    public partial class FrmLichSuDatVe : Form
    {
        Connection db = new Connection();


        public FrmLichSuDatVe()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            Connection connection = new Connection();
            bool check_conn = connection.openConn();
            if (check_conn == false)
            {
                db.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }

            try
            {
                string query = @"SELECT
                    lsdv.MaLichSuDatVe AS [Mã Lịch Sử Đặt Vé],
                    kh.MaKhachHang AS [Mã Khách Hàng],
                    kh.HoTen AS [Họ Tên],
                    lsdv.TrangThaiVe AS [Trạng Thái Vé],              
                    lt.TuyenDuong AS [Tuyến Đường],
                    lt.DiemXuatPhat AS [Điểm Xuất Phát],
                    lt.DiemDen AS [Điểm Đến],
                    lt.NgayKhoiHanh AS [Ngày Khởi Hành],
                    lt.GioKhoiHanh AS [Giờ Khởi Hành]
                
                  FROM LICHSUDATVE lsdv, XEKHACH xk, LICHTRINH lt, KHACHHANG kh
                  WHERE lsdv.MaKhachHang = kh.MaKhachHang AND lsdv.MaXe = xk.MaXe AND xk.MaXe = lt.MaXe AND lsdv.TrangThaiVe = 0
           ";
                SqlDataReader reader = connection.executeSQL(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgLichSuDatVe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
            finally
            {
               connection.closeConn();
            }


        }

        private void FrmLichSuDatVe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            bool check_conn = connection.openConn();
            if (check_conn == false)
            {
                db.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;

            }

            try
            {
                string TimKiem = txtTimKiem.Text;

                string query = $@"SELECT 
                lsdv.MaLichSuDatVe AS [Mã Lịch Sử Đặt Vé],
                kh.MaKhachHang AS [Mã Khách Hàng],
                kh.HoTen AS [Họ Tên],
                lsdv.TrangThaiVe AS [Trạng Thái Vé],              
                lt.TuyenDuong AS [Tuyến Đường],
                lt.DiemXuatPhat AS [Điểm Xuất Phát],
                lt.DiemDen AS [Điểm Đến],
                lt.NgayKhoiHanh AS [Ngày Khởi Sẵn],
                lt.GioKhoiHanh AS [Giờ Khởi Hành]
                
              FROM LICHSUDATVE lsdv, XEKHACH xk, LICHTRINH lt, KHACHHANG kh
              WHERE lsdv.MaKhachHang = kh.MaKhachHang AND lsdv.MaXe = xk.MaXe AND xk.MaXe = lt.MaXe AND lsdv.TrangThaiVe = 0 AND kh.HoTen like N'%{TimKiem}%'
           ";
                SqlDataReader reader = connection.executeSQL(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgLichSuDatVe.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
