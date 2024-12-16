using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmLichSuDatVeKhachHang : Form
    {
        public FrmLichSuDatVeKhachHang()
        {
            InitializeComponent();
        }

        private void FrmLichSuDatVeKhachHang_Load(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                conn.closeConn();
                MessageBox.Show("Kết nối thất bại");
                return;
            }

            try
            {
                string MaKhachHang = FrmDangNhap.userId;

                string Sql_Select = $@"SELECT
                    lv.TenLoaiVe as N'Loại vé',
                    lt.TuyenDuong AS [Tuyến Đường],
                    lt.DiemXuatPhat AS [Điểm Xuất Phát],
                    lt.DiemDen AS [Điểm Đến],
                    lt.NgayKhoiHanh AS [Ngày Khởi Hành],
                    lt.GioKhoiHanh AS [Giờ Khởi Hành]
                  FROM LICHSUDATVE lsdv, XEKHACH xk, LICHTRINH lt, KHACHHANG kh, LOAIVE lv
                  WHERE lsdv.MaKhachHang = kh.MaKhachHang AND
                        lsdv.MaXe = xk.MaXe AND
                        xk.MaXe = lt.MaXe AND lsdv.TrangThaiVe = 0 AND 
                        lsdv.MaLoaiVe = lv.MaLoaiVe AND 
                        kh.MaKhachHang = '{MaKhachHang}'
                ";

                SqlDataReader drd = conn.executeSQL(Sql_Select);

                DataTable dt = new DataTable();

                if (drd.HasRows)
                {
                    dt.Load(drd);
                    dgvLichSuDatVe.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Lịch sử đặt vé đang trống");
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
    }
}
