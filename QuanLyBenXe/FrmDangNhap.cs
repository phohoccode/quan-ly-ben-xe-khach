using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmDangNhap : Form
    {

        public static string username = "";
        public static string roleId = "";
        public static string email = "";
        public static string userId = "";

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private bool checkValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void showForm(Form formToShow)
        {
            if (formToShow != null)
            {
                formToShow.Show();
            }
            else
            {
                MessageBox.Show("Form không hợp lệ.");
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string emailLogin = txtEmail.Text.Trim();
            string passwordLogin = txtPassword.Text.Trim();

            if (!checkValidEmail(emailLogin))
            {
                MessageBox.Show("Email không đúng định dạng. Vui lòng kiểm tra lại!");
                txtEmail.Focus();
                return;
            }

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
                string Sql_FindKhachHang = $@"SELECT * FROM KHACHHANG WHERE Email = '{emailLogin}' and MatKhau = '{passwordLogin}'";

                SqlDataReader drd_KhachHang = conn.executeSQL(Sql_FindKhachHang);

                if (drd_KhachHang.HasRows)
                {
                    while (drd_KhachHang.Read())
                    {
                        username = drd_KhachHang["HoTen"].ToString();
                        roleId = drd_KhachHang["MaQuyenHan"].ToString();
                        email = drd_KhachHang["Email"].ToString();
                        userId = drd_KhachHang["MaKhachHang"].ToString();

                        if (roleId == "1")
                        {
                            showForm(new FrmTrangChuKhachHang());
                        }

                        this.Hide();
                    }

                    drd_KhachHang.Close();
                }
                else
                {
                    drd_KhachHang.Close();

                    string Sql_FindNhanVien = $@"SELECT * FROM NHANVIEN WHERE Email = '{emailLogin}' and MatKhau = '{passwordLogin}'";

                    SqlDataReader drd_NhanVien = conn.executeSQL(Sql_FindNhanVien);

                    if (drd_NhanVien.HasRows)
                    {
                        while (drd_NhanVien.Read())
                        {
                            username = drd_NhanVien["HoTen"].ToString();
                            roleId = drd_NhanVien["MaQuyenHan"].ToString();
                            email = drd_NhanVien["Email"].ToString();
                            userId = drd_NhanVien["MaNhanVien"].ToString();


                            if (roleId == "2")
                            {
                                showForm(new FrmTrangChuNhanVien());
                            }
                            else if (roleId == "3")
                            {
                                showForm(new FrmTrangChuAdmin());

                            }

                            this.Hide();
                        }

                        drd_KhachHang.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập không chính xác!");
                    }

                    drd_NhanVien.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại sau!");
            }
            finally
            {
                conn.closeConn();
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showForm(new FrmDangKy());
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showForm(new FrmQuenMatKhau());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
