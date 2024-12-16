using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private bool checkContrainsNumber(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool checkValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void showForm(Form formToShow)
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

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (checkContrainsNumber(username))
            {
                MessageBox.Show("Họ và tên không được chứa số!");
                txtUsername.Focus();
                return;
            }


            if (!checkValidEmail(email))
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
                string Sql_FindEmail = $@"SELECT Email FROM KHACHHANG WHERE Email = '{email}'";

                SqlDataReader drd = conn.executeSQL(Sql_FindEmail);

                if (drd.HasRows)
                {
                    MessageBox.Show("Email đã được đăng ký bởi tài khoản khác!");
                    txtEmail.Clear();
                    txtEmail.Focus();
                    conn.closeConn();
                    return;
                }

                drd.Close();


                string Sql_Register =
                    $@"INSERT INTO KHACHHANG (HoTen, Email, Matkhau, MaQuyenHan, TrangThai) VALUES (N'{username}','{email}', '{password}', 1, 0)";


                int rows = conn.executeUpdate(Sql_Register);

                if (rows > 0)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                    this.Close();
                    showForm(new FrmDangNhap());
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại!");
                }

                conn.closeConn();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại sau!");
            }

        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();    
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
