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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private void btnSuccess_Click(object sender, EventArgs e)
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
                string OTP = txtToken.Text;

                string Sql_CheckOTP = $@"Select * from XACMINHTAIKHOAN where MaToken = '{OTP}'";

                SqlDataReader drd = conn.executeSQL(Sql_CheckOTP);


                if (!drd.HasRows)
                {
                    MessageBox.Show("Mã xác thực không chính xác!");
                    conn.closeConn();
                    return;
                }

                drd.Close();


                string newPassword = txtPassword.Text;

                string Sql_UpdatePassword = $@"Update KHACHHANG set MatKhau = '{newPassword}'";

                int rows = conn.executeUpdate(Sql_UpdatePassword);

                if (rows > 0)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    this.Close();
                    showForm(new FrmDangNhap());
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại!");
                }


                conn.closeConn();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại sau!");
            }

           
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            showForm(new FrmQuenMatKhau());
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtToken.Focus();   
        }
    }
}
