using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmQuanLyLoaiVe : Form
    {
       

        public FrmQuanLyLoaiVe()
        {
            InitializeComponent();
        }

        private void LoadData()
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
                string query = $@"
                   SELECT 
                        MaLoaiVe AS N'Mã loại vé', 
                        TenLoaiVe AS N'Tên loại vé', 
                        GiaVe AS N'Giá vé', 
                        CASE 
                            WHEN TrangThai = 0 THEN N'Hoạt động'
                            WHEN TrangThai = 1 THEN N'Ngừng hoạt động'
                        END AS N'Trạng thái'
                    FROM LOAIVE
                    WHERE TrangThai = 0;
                ";

                SqlDataReader drd = conn.executeSQL(query);

                DataTable dt = new DataTable();

                dt.Load(drd);

                dgvLoaiVe.DataSource = dt;
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

        private bool kiemTraGia(string giaVe)
        {
            try
            {

                int giaVeXe = Convert.ToInt32(giaVe);

                if (giaVeXe < 0)
                {
                    MessageBox.Show("Giá vé phải lớn hơn 0!");
                    return false;
                }

                if (giaVeXe > 5000000)
                {
                    MessageBox.Show("Giá vé không được lớn hơn 5.000.000!");
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Giá vé không hợp lệ!");
                return false;
            }
        }

        private void FrmQuanLyLoaiVe_Load(object sender, EventArgs e)
        {
            LoadData();
            cbTrangThai.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                string tenLoaiVe = txtTenLoaiVe.Text;
                string giaVe = txtGiaVe.Text;

                string Sql_FindTenLoaiVe = $@"SELECT * FROM LOAIVE WHERE TenLoaiVe = N'{tenLoaiVe}'";

                SqlDataReader drd = conn.executeSQL(Sql_FindTenLoaiVe);

                if (drd.HasRows)
                {
                    MessageBox.Show("Tên loại vé đã tồn tại!");
                    drd.Close();
                    return;
                }

                drd.Close();


                if (tenLoaiVe == "" || giaVe == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                bool checkGia = kiemTraGia(giaVe);

                if (checkGia)
                {
                    string Sql_Insert = $@"
                    INSERT INTO LOAIVE(TenLoaiVe, GiaVe)
                    VALUES(N'{tenLoaiVe}', {giaVe})";

                    int result = conn.executeUpdate(Sql_Insert);

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm loại vé thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại vé thất bại!");
                    }
                }

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

        private void btnSua_Click(object sender, EventArgs e)
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
                string maLoaiVe = txtMaLoaiVe.Text;
                string tenLoaiVe = txtTenLoaiVe.Text;
                string giaVe = txtGiaVe.Text;


                if (maLoaiVe == "")
                {
                    MessageBox.Show("Vui lòng chọn loại vé cần sửa!");
                    return;
                }

                int rowSelected = dgvLoaiVe.CurrentCell.RowIndex;

                // Bỏ qua hàng đang chọn
                foreach (DataGridViewRow row in dgvLoaiVe.Rows)
                {
                    if (row.Index != rowSelected)
                    {
                        if (row.Cells["Tên loại vé"].Value.ToString() == tenLoaiVe)
                        {
                            MessageBox.Show("Tên loại vé đã tồn tại!");
                            return;
                        }
                    }
                }


                string Sql_Update = $@"
                    UPDATE LOAIVE
                    SET TrangThai = 1
                    WHERE MaLoaiVe = '{maLoaiVe}'";

                int kq = conn.executeUpdate(Sql_Update);

                if (kq > 0)
                {
                    string Sql_Insert = $@"
                        INSERT INTO LOAIVE(TenLoaiVe, GiaVe) VALUES (N'{tenLoaiVe}','{giaVe}')
                    ";

                    int kq_insert = conn.executeUpdate(Sql_Insert);

                    if (kq_insert > 0)
                    {
                        MessageBox.Show("Sửa loại vé thành công!");
                        LoadData();
                        resetForm();
                    }
                    else
                    {
                        MessageBox.Show("Sửa loại vé thất bại!");
                    }

                }
                else
                {
                    MessageBox.Show("Sửa loại vé thất bại!");
                }

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

        private void btnXoa_Click(object sender, EventArgs e)
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
                string maLoaiVe = txtMaLoaiVe.Text;

                if (maLoaiVe == "")
                {
                    MessageBox.Show("Vui lòng chọn loại vé cần xóa!");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                       "Bạn có chắc chắn muốn loại vé này?",
                       "Xác nhận xóa",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                string Sql_Delete = $@"
                    UPDATE LOAIVE
                    SET TrangThai = 1
                    WHERE MaLoaiVe = '{maLoaiVe}'";

                int kq = conn.executeUpdate(Sql_Delete);

                if (kq > 0)
                {
                    MessageBox.Show("Xoá loại vé thành công!");
                    LoadData();
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Xoá loại vé thất bại!");
                }

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

        private void btnTimKiem_Click(object sender, EventArgs e)
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
                string valueSearch = txtTimKiem.Text;

                if (valueSearch == "")
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                    return;
                }

                string query = $@"
                   SELECT 
                        MaLoaiVe AS N'Mã loại vé', 
                        TenLoaiVe AS N'Tên loại vé', 
                        GiaVe AS N'Giá vé', 
                        CASE 
                            WHEN TrangThai = 0 THEN N'Hoạt động'
                            WHEN TrangThai = 1 THEN N'Ngừng hoạt động'
                        END AS N'Trạng thái'
                    FROM LOAIVE
                    WHERE TrangThai = 0 AND TenLoaiVe LIKE N'%{valueSearch}%';
                ";

                SqlDataReader drd = conn.executeSQL(query);

                DataTable dt = new DataTable();

                dt.Load(drd);

                dgvLoaiVe.DataSource = dt;
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



        private void dgvLoaiVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string maLoaiVe = dgvLoaiVe.Rows[e.RowIndex].Cells["Mã loại vé"].Value.ToString();
                string tenLoaiVe = dgvLoaiVe.Rows[e.RowIndex].Cells["Tên loại vé"].Value.ToString();
                string giaVe = dgvLoaiVe.Rows[e.RowIndex].Cells["Giá vé"].Value.ToString();
                string trangThai = dgvLoaiVe.Rows[e.RowIndex].Cells["Trạng thái"].Value.ToString();

              
                txtMaLoaiVe.Text = maLoaiVe;
                txtTenLoaiVe.Text = tenLoaiVe;
                txtGiaVe.Text = giaVe;
                cbTrangThai.SelectedIndex = trangThai == "Hoạt động" ? 0 : 1;
            }
        }

        private void resetForm()
        {
            txtMaLoaiVe.Text = "";
            txtTenLoaiVe.Text = "";
            txtGiaVe.Text = "";
            txtTimKiem.Text = "";
            cbTrangThai.SelectedIndex = 0;
        }   

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            resetForm();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadData();
            }
        }
    }
}
