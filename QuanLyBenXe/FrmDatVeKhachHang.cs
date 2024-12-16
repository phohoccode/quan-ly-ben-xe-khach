using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmDatVeKhachHang : Form
    {
        public FrmDatVeKhachHang()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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
                string DiemXuatPhat = cbDiemXuatPhat.SelectedItem.ToString();
                string DiemDen = cbDiemDen.SelectedItem.ToString();

                string Sql_Find = $@"
                    SELECT * FROM LICHTRINH
                    WHERE DiemXuatPhat = N'{DiemXuatPhat}' AND DiemDen = N'{DiemDen}' AND TrangThai = 0
                ";

                SqlDataReader drd = conn.executeSQL(Sql_Find);

                DataTable dt = new DataTable();

                if (drd.HasRows)
                {
                    dt.Load(drd);
                    dgvChuyenXe.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chuyến xe phù hợp");
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

        private void LoadComboBox(SqlDataReader drd)
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
                // load dữ liệu vào điểm xuất phát và điểm đến 

                cbDiemDen.Items.Clear();
                cbDiemXuatPhat.Items.Clear();
                cbLoaiVe.Items.Clear();

                string Sql_Select_LichTrinh = @"
                SELECT DISTINCT DiemXuatPhat, DiemDen
                FROM LichTrinh 
                WHERE TrangThai = 0";

                SqlDataReader drd_LichTrinh = conn.executeSQL(Sql_Select_LichTrinh);

                while (drd_LichTrinh.Read())
                {
                    string DiemXuatPhat = drd_LichTrinh["DiemXuatPhat"].ToString();
                    string DiemDen = drd_LichTrinh["DiemDen"].ToString();

                    cbDiemDen.Items.Add(DiemDen);
                    cbDiemXuatPhat.Items.Add(DiemXuatPhat);
                }

                if (cbDiemDen.Items.Count > 0) cbDiemDen.SelectedIndex = 0;
                if (cbDiemXuatPhat.Items.Count > 0) cbDiemXuatPhat.SelectedIndex = 0;

                drd_LichTrinh.Close();


                // load dữ liệu vào loại vé

                string Sql_Select_LoaiVe = $@"
                    SELECT * FROM LoaiVe
                    WHERE TrangThai = 0
                ";

                SqlDataReader drd_LoaiVe = conn.executeSQL(Sql_Select_LoaiVe);

                while (drd_LoaiVe.Read())
                {
                    string TenLoaiVe = drd_LoaiVe["TenLoaiVe"].ToString();
                    string MaLoaiVe = drd_LoaiVe["MaLoaiVe"].ToString();

                    cbLoaiVe.Items.Add(TenLoaiVe + "-" + MaLoaiVe);

                    if (txtGiaVe.Text == "")
                    {
                        txtGiaVe.Text = drd_LoaiVe["GiaVe"].ToString();
                    }
                }

                if (cbLoaiVe.Items.Count > 0) cbLoaiVe.SelectedIndex = 0;

                drd_LoaiVe.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex);
            }
            finally
            {
                conn.closeConn();
            }

        }


        private void LoadData()
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
                string Sql_Select = $@"
                    SELECT 
                        xk.MaXe AS N'Mã xe',
                        xk.TenNhaXe AS N'Tên nhà xe',
                        xk.LoaiXe as N'Loại xe',
                        lt.DiemXuatPhat AS N'Điểm xuất phát',
                        lt.DiemDen AS N'Điểm đến', 
                        lt.TuyenDuong AS N'Tuyến đường',
                        lt.NgayKhoiHanh AS N'Ngày khởi hành',
                        lt.GioKhoiHanh AS 'Giờ khởi hành',
                        CASE 
                            WHEN lt.TrangThai = 0 THEN N'Hoạt động'
                            ELSE 'Khác'
                        END AS N'Trạng thái'
                    FROM XeKhach xk, LichTrinh lt
                    WHERE xk.MaXe = lt.MaXe and xk.TrangThai = 0 and lt.TrangThai = 0
                ";

                SqlDataReader drd = conn.executeSQL(Sql_Select);

                DataTable dt = new DataTable();

                dt.Load(drd);

                dgvChuyenXe.DataSource = dt;

                drd.Close();

                LoadComboBox(drd);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex);
            }
            finally
            {
                conn.closeConn();
            }
        }


        private void FrmDatVeKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();

            DataGridViewButtonColumn btnDatve = new DataGridViewButtonColumn();
            btnDatve.Name = "Đặt vé";
            btnDatve.HeaderText = "Thao Tác";
            btnDatve.Text = "Đặt vé";
            btnDatve.UseColumnTextForButtonValue = true; // Hiển thị Text trong button

            dgvChuyenXe.Columns.Insert(0, btnDatve);
        }

        private void cbLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
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
                string MaLoaiVe = cbLoaiVe.SelectedItem.ToString().Split('-')[1];

                string Sql_Select = $@"
                    SELECT * FROM LoaiVe
                    WHERE MaLoaiVe = '{MaLoaiVe}'
                ";

                SqlDataReader drd = conn.executeSQL(Sql_Select);

                if (drd.Read())
                {
                    txtGiaVe.Text = drd["GiaVe"].ToString();
                }

                drd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex);
            }
            finally
            {
                conn.closeConn();
            }


        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void dgvChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChuyenXe.Columns["Đặt vé"].Index)
            {
                string MaLoaiVe = cbLoaiVe.SelectedItem.ToString().Split('-')[1];
                string TenLoaiVe = cbLoaiVe.SelectedItem.ToString().Split('-')[0];
                string MaKhachHang = FrmDangNhap.userId;
                string MaXe = dgvChuyenXe.Rows[e.RowIndex].Cells["Mã xe"].Value.ToString();
                string NgayDatVe = DateTime.Now.ToString("yyyy-MM-dd");

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đặt loại " + TenLoaiVe, "Thông báo", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
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
                        string Sql_Insert = $@"
                            INSERT INTO LICHSUDATVE(MaKhachHang, MaXe, MaLoaiVe, NgayDatVe,TrangThaiVe)
                            VALUES('{MaKhachHang}', '{MaXe}', '{MaLoaiVe}', '{NgayDatVe}', 0)";
                     

                        int kq = conn.executeUpdate(Sql_Insert);

                        if (kq > 0)
                        {
                            MessageBox.Show("Đặt vé thành công");
                        }
                        else
                        {
                            MessageBox.Show("Đặt vé thất bại");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Lỗi kết nối " + ex);
                    }
                    finally
                    {
                        conn.closeConn();
                    }
                }
            }

        }

    }
}
