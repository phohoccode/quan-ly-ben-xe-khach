using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmKhieuNai : Form
    {
        public FrmKhieuNai()
        {
            InitializeComponent();
        }

        private bool validateForm()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMoTa.Text))
            {
                return false;
            }

            return true;
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

        private void sendComplaint()
        {
            var fromAddress = new MailAddress("phohoccode@gmail.com", "Quản lý bến xe");
            const string password = "edfr elqg nlvh sltj";
            const string title = "Khiếu nại từ người dùng - Quản lý Bến xe";


            // thông tin khiếu nại từ người dùng
            string email = txtEmail.Text;


            bool isValidEmail = checkValidEmail(email);

            if (!isValidEmail)
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }


            string tenNguoiDung = txtUsername.Text;

            string lyDoKhieuNai = cbLyDoKhieuNai.SelectedItem?.ToString() ?? "Không xác định";
            string moTa = txtMoTa.Text;

            // Nội dung email
            string content = $@"
                <div style='font-family: Arial, sans-serif; line-height: 1.6;'>
                    <h3 style='color: #555;'>Thông tin người gửi:</h3>
                    <p><strong>Họ và tên:</strong> {tenNguoiDung}</p>
                    <p><strong>Email:</strong> {email}</p>
                    <h3 style='color: #555;'>Chi tiết khiếu nại:</h3>
                    <p><strong>Lý do khiếu nại:</strong> {lyDoKhieuNai}</p>
                    <p><strong>Mô tả:</strong> {moTa}</p>
                    <br>
                    <footer >Được gửi từ hệ thống Quản lý Bến xe</footer>
                </div>";

            var message = new MailMessage
            {
                From = fromAddress,
                Subject = title,
                Body = content,
                IsBodyHtml = true
            };

            message.To.Add(email);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(fromAddress.Address, password)
            };


            smtp.Send(message);

            MessageBox.Show("Gửi khiếu nại thành công!");
        }

        private void addData()
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
                string MaKhachHang = txtUserId.Text;
                string lyDoKhieuNai = cbLyDoKhieuNai.SelectedItem.ToString();
                string moTa = txtMoTa.Text;


                string Sql_Insert = $@"
                    INSERT INTO KHIEUNAI (MaKhachHang, LyDoKhieuNai, MoTa)
                    VALUES ('{MaKhachHang}', N'{lyDoKhieuNai}', N'{moTa}')";

                int rows = conn.executeUpdate(Sql_Insert);

                if (rows > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng liên hệ quản trị viên.");
            }
            finally
            {
                conn.closeConn();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool isValid = validateForm();

            if (!isValid)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khiếu nại!");
                return;
            }


            if (cbXacNhan.Checked)
            {
                btnLamMoi.Enabled = false;
                btnXacNhan.Enabled = false;
                sendComplaint();
                addData();
                btnLamMoi.Enabled = true;
                btnXacNhan.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng xác nhận điều khoản trước khi gửi khiếu nại!");
            }
        }

        private void FrmKhieuNai_Load(object sender, EventArgs e)
        {
            txtUserId.Text = FrmDangNhap.userId;
            txtEmail.Text = FrmDangNhap.email;
            txtUsername.Text = FrmDangNhap.username;
            cbLyDoKhieuNai.SelectedIndex = 0;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
