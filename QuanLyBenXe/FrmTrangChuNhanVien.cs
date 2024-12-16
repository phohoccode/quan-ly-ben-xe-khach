using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmTrangChuNhanVien : Form
    {
        public FrmTrangChuNhanVien()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form formToShow)
        {
            panelContainer.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }

        private void btnQuanLyVeXe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyVeXe());
        }

        private void btnQuanLyLichTrinh_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyLichTrinh());
        }

        private void btnQuanLyXeKhach_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyXeKhach());
        }

        private void btnQuanLyKhieuNai_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyKhieuNai());
        }

        private void btnQuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyDoanhThu());
        }

        private void btnHoTroHanhKhach_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmHoTroHanhKhach());
        }

        private void FrmTrangChuNhanVien_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Xin chào! " + FrmDangNhap.username;
            ShowFormInPanel(new FrmQuanLyKhachHang());

        }

        private void FrmTrangChuNhanVien_Shown(object sender, EventArgs e)
        {
            Connection conn = new Connection();

            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối dữ liệu thất bại!");
                return;
            }

            try
            {
                string maNhanVien = FrmDangNhap.userId;

                string Sql_find = $@" SELECT * FROM CHAMCONG WHERE MaNhanVien = '{maNhanVien}' ";

                SqlDataReader drd = conn.executeSQL(Sql_find);

                if (!drd.HasRows)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn chưa chấm công ngày hôm nay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.OK)
                    {
                        string Sql_insert = $@"
                        INSERT INTO CHAMCONG (MaNhanVien, NgayChamCong, TrangThai) VALUES ('{maNhanVien}', '{DateTime.Now.ToString("yyyy-MM-dd")}', 1)
                    ";

                        drd.Close();
                        int kq = conn.executeUpdate(Sql_insert);

                        if (kq > 0)
                        {
                            MessageBox.Show("Chấm công thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Chấm công thất bại!");
                        }
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

        

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyKhachHang());
        }
    }
}
