using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmQuanLyKhieuNai : Form
    {

        private bool err = false;
        public FrmQuanLyKhieuNai()
        {
            InitializeComponent();
        }

        private void sendComplaint(string email, string subject, string body)
        {
            var fromAddress = new MailAddress("phohoccode@gmail.com", "Quản lý bến xe");
            const string password = "edfr elqg nlvh sltj";

            var message = new MailMessage
            {
                From = fromAddress,
                Subject = subject,
                Body = body,
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
        }

        private void LoadDataFromKhieuNai(string mode)
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
                string Sql_Select = "";
                string condition = "";
                string timeCustom = dtpTuyChinh.Value.ToString("yyyy/MM/dd");

                // Xử lý điều kiện tùy thuộc vào trạng thái khiếu nại
                switch (mode)
                {
                    case "await": condition = "WHERE KN.TrangThai = 0;"; break;
                    case "done": condition = "WHERE KN.TrangThai = 1;"; break;
                    case "cancel": condition = "WHERE KN.TrangThai = 2;"; break;
                    case "all": condition = ""; break;
                    case "today": condition = "WHERE CONVERT(DATE, KN.NgayTao) = CONVERT(DATE, GETDATE());"; break;
                    case "custom": condition = $@"WHERE CONVERT(DATE, KN.NgayTao) = '{timeCustom}';"; break;
                    default: break;
                }


                Sql_Select = $@"
                     SELECT 
                        KN.MaKhieuNai as N'Mã khiếu nại',
                        KH.HoTen AS N'Tên hành khách',
                        Kh.Email,
                        KN.LyDoKhieuNai as N'Lý do khiếu nại',
                        KN.MoTa as N'Mô tả chi tiết',
                        KN.NgayTao as N'Ngày khiếu nại',
                        CASE 
                            WHEN KN.TrangThai = 0 THEN N'Chưa giải quyết'
                            WHEN KN.TrangThai = 1 THEN N'Đã giải quyết'
                            WHEN KN.TrangThai = 2 THEN N'Đã hủy'
                        END AS N'Trạng thái'
                    FROM KHIEUNAI KN
                    INNER JOIN KHACHHANG KH ON KN.MaKhachHang = KH.MaKhachHang
                    {condition}
                ";

                // Đổ dữ liệu vào DataGridView tương ứng với trạng thái
                SqlDataReader drd = conn.executeSQL(Sql_Select);
                DataTable dataTable = new DataTable();
                dataTable.Load(drd);

                dgvKhieuNai.DataSource = dataTable;


                drd.Close();
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

        private void XuLyHanhDong(string action, int maKhieuNai)
        {
            Connection conn = new Connection();
            bool check_conn = conn.openConn();
            err = false;

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }

            try
            {
                string sqlUpdate = "";

                if (action == "solve")
                {
                    sqlUpdate = $@"
                        UPDATE KHIEUNAI
                        SET TrangThai = 1
                        WHERE MaKhieuNai = {maKhieuNai};
                    ";
                }
                else if (action == "cancel")
                {
                    sqlUpdate = $@"
                        UPDATE KHIEUNAI
                        SET TrangThai = 2
                        WHERE MaKhieuNai = {maKhieuNai};
                    ";
                }


                int rows = conn.executeUpdate(sqlUpdate);

                if (rows > 0)
                {
                    MessageBox.Show("Đã xử lý khiếu nại thành công");

                }
                else
                {
                    MessageBox.Show("Xử lý khiếu nại thất bại!");
                }


                LoadDataFromKhieuNai("await");
                cbCheDoHienThi.SelectedIndex = 0;

                err = false;
            }
            catch (Exception)
            {
                err = true;
                MessageBox.Show("Có lỗi xảy ra khi xử lý hành động.");
            }
            finally
            {
                conn.closeConn();
            }
        }

        private void FrmQuanLyKhieuNai_Load(object sender, EventArgs e)
        {
            LoadDataFromKhieuNai("await");
            cbHanhDong.SelectedIndex = 0;
            cbLyDoHuyKN.SelectedIndex = 0;
            cbCheDoHienThi.SelectedIndex = 0;
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgvKhieuNai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần thực hiện!");
                return;
            }


            int maKhieuNai = Convert.ToInt32(dgvKhieuNai.SelectedRows[0].Cells["Mã khiếu nại"].Value);
            string email = dgvKhieuNai.SelectedRows[0].Cells["Email"].Value.ToString();
            string tenHanhKhach = dgvKhieuNai.SelectedRows[0].Cells["Tên hành khách"].Value.ToString();
            string ngayKhieuNai = dgvKhieuNai.SelectedRows[0].Cells["Ngày khiếu nại"].Value.ToString();
            string lyDoKhieuNai = dgvKhieuNai.SelectedRows[0].Cells["Lý do khiếu nại"].Value.ToString();
            string trangThai = dgvKhieuNai.SelectedRows[0].Cells["Trạng thái"].Value.ToString();

            bool kiemTraTrangThai = true;

            if (trangThai == "Đã giải quyết" || trangThai == "Đã hủy")
            {
                MessageBox.Show("Khiếu nại này đã được giải quyết hoặc đã bị hủy!");
                kiemTraTrangThai = false;
                return;
            }

            if (kiemTraTrangThai)
            {
                if (cbHanhDong.SelectedIndex == 0)
                {
                    string lyDoHuyBo = cbLyDoHuyKN.SelectedItem.ToString();

                    XuLyHanhDong("cancel", maKhieuNai);

                    if (!err)
                    {
                        string body = $@"
                        <h1>Xin chào {tenHanhKhach}!,</h1>
                        <p>Chúng tôi đã nhận được khiếu nại của bạn vào ngày {ngayKhieuNai} với lý do là: {lyDoKhieuNai}</p>
                        <p><strong>Chúng tôi rất tiếc khi phải thông báo rằng khiếu nại của bạn đã bị hủy.</strong></p>
                        <p>Lý do hủy: {lyDoHuyBo}</p>   
                        <p>Vui lòng liên hệ với chúng tôi nếu bạn cần thêm thông tin.</p>
                        <p>Trân trọng,</p>
                        <p>Đội ngũ hỗ trợ khách hàng</p>
                    ";

                        btnXacNhan.Enabled = false;
                        btnXoa.Enabled = false;

                        await Task.Run(() => sendComplaint(email, "Phản hồi khiếu nại!", body));
                        MessageBox.Show("Đã gửi phản hồi khiếu nại về người dùng!");

                        btnXacNhan.Enabled = true;
                        btnXoa.Enabled = true;
                    }


                }
                else if (cbHanhDong.SelectedIndex == 1)
                {
                    XuLyHanhDong("solve", maKhieuNai);

                    if (!err)
                    {
                        string body = $@"
                        <h1>Xin chào {tenHanhKhach}!,</h1>
                        <p>Chúng tôi đã nhận được khiếu nại của bạn vào ngày {ngayKhieuNai} với lý do là: {lyDoKhieuNai}</p>
                        <p><strong>Chúng tôi đã xem xét khiếu nại của bạn và đã giải quyết thoả đang!</strong></p>
                        <p>Vui lòng liên hệ với chúng tôi nếu bạn cần thêm thông tin.</p>
                        <p>Trân trọng,</p>
                        <p>Đội ngũ hỗ trợ khách hàng</p>
                    ";


                        btnXacNhan.Enabled = false;
                        btnXoa.Enabled = false;

                        await Task.Run(() => sendComplaint(email, "Phản hồi khiếu nại!", body));

                        MessageBox.Show("Đã gửi phản hồi khiếu nại về người dùng!");
                        btnXacNhan.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
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

            if (dgvKhieuNai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
               "Bạn có chắc chắn muốn xóa khiếu nại này?",
               "Xác nhận xóa",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                int maKhieuNai = Convert.ToInt32(dgvKhieuNai.SelectedRows[0].Cells["Mã khiếu nại"].Value);

                try
                {
                    string sqlDelete = $@"
                    DELETE FROM KHIEUNAI
                    WHERE MaKhieuNai = {maKhieuNai};
                ";

                    int rows = conn.executeUpdate(sqlDelete);

                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa khiếu nại thành công!");
                        LoadDataFromKhieuNai("await");
                        cbCheDoHienThi.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Xóa khiếu nại thất bại!");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa khiếu nại.");
                }
                finally
                {
                    conn.closeConn();
                }
            }
        }

        private void cbCheDoHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbCheDoHienThi.SelectedIndex)
            {
                case 0:
                    panelTuyChinh.Visible = false;
                    gbXuLyKN.Enabled = true;
                    LoadDataFromKhieuNai("await");
                    break;
                case 1:
                    panelTuyChinh.Visible = false;
                    gbXuLyKN.Enabled = false;
                    LoadDataFromKhieuNai("done");
                    break;
                case 2:
                    panelTuyChinh.Visible = false;
                    gbXuLyKN.Enabled = false;
                    LoadDataFromKhieuNai("cancel");
                    break;
                case 3:
                    panelTuyChinh.Visible = false;
                    gbXuLyKN.Enabled = true;
                    LoadDataFromKhieuNai("all");
                    break;
                case 4:
                    panelTuyChinh.Visible = false;
                    gbXuLyKN.Enabled = true;
                    LoadDataFromKhieuNai("today");
                    break;
                case 5:
                    panelTuyChinh.Visible = true;
                    gbXuLyKN.Enabled = true;
                    break;
                default: break;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDataFromKhieuNai("custom");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpTuyChinh.Value = DateTime.Now;
            LoadDataFromKhieuNai("today");
        }

        private void cbHanhDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHanhDong.SelectedIndex == 0)
            {
                panelLyDoKhieuNai.Visible = true;
            }
            else
            {
                panelLyDoKhieuNai.Visible = false;
            }
        }
    }
}
