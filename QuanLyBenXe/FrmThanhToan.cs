using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Web;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmThanhToan : Form
    {
        private PrintPreviewDialog printPreviewDialog;
        // Đối tượng PrintDocument để xử lý việc in
        private PrintDocument printDocument = new PrintDocument();
        private Timer countdownTimer;
        private int timeLeft = 10 * 60; // 10 phút = 600 giây

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Giảm thời gian còn lại mỗi giây
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateTimeDisplay();
            }
            else
            {
                countdownTimer.Stop();
                label1.Text = "Đã hết giờ!";
                MessageBox.Show("Đã hết 10 phút!", "Thông báo");
            }
        }

        private void UpdateTimeDisplay()
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            label15.Text = $"{minutes:D2}:{seconds:D2}"; // Định dạng mm:ss
        }

        public FrmThanhToan()
        {
            InitializeComponent();
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 giây
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

            // Hiển thị thời gian ban đầu
            UpdateTimeDisplay();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            // Khởi tạo PrintPreviewDialog
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Khởi tạo biến vị trí in trên giấy
            int yPosition = 20;
            int leftMargin = 40;
            int topMargin = 20;

            // Tiêu đề "VÉ XE" - làm nổi bật tiêu đề
            Font titleFont = new Font("Arial", 24, FontStyle.Bold); // Chữ to hơn
            StringFormat titleFormat = new StringFormat();
            titleFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("VÉ XE", titleFont, Brushes.Black, e.PageBounds.Width / 2, yPosition, titleFormat);
            yPosition += 40; // Khoảng cách sau tiêu đề

            // Đường kẻ dưới tiêu đề
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, e.PageBounds.Width - leftMargin, yPosition);
            yPosition += 10; // Khoảng cách sau đường kẻ

            // Font cho thông tin (Chữ lớn và đậm cho thông tin quan trọng)
            Font labelFont = new Font("Arial", 14); // Chữ to hơn
            Font labelBoldFont = new Font("Arial", 14, FontStyle.Bold); // Chữ in đậm cho thông tin quan trọng
            Brush textBrush = Brushes.Black;

            // In thông tin Mã Khách Hàng (in đậm)
            e.Graphics.DrawString("Mã Khách Hàng: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblMaKhachHang.Text, labelFont, textBrush, leftMargin + 180, yPosition); // Đẩy thông tin sang phải
            yPosition += 30;

            // In thông tin Họ Tên (in đậm)
            e.Graphics.DrawString("Họ Tên: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblHoTen.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;



            // In thông tin SĐT
            e.Graphics.DrawString("Biền Số: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblBienSo.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;

            // In thông tin Mã xe (in đậm)
            e.Graphics.DrawString("Mã xe: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblMaXe.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;

            // In thông tin Tuyến đường
            e.Graphics.DrawString("Tuyến đường: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblTuyenDuong.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;

            // In thông tin Điểm đi
            e.Graphics.DrawString("Điểm đi: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblDiemXuatPhat.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;

            // In thông tin Điểm đến
            e.Graphics.DrawString("Điểm đến: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblDiemDen.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;

            // In thông tin Ngày khởi hành (in đậm)
            e.Graphics.DrawString("Ngày Khởi Hành: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblNgayKhoiHanh.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;

            // In thông tin Giờ khởi hành
            e.Graphics.DrawString("Giờ khởi hành: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblGioKhoiHanh.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;
            // In thông tin Giờ khởi hành
            e.Graphics.DrawString("Loại vé: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblLoaiVe.Text, labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;
            // In thông tin Giờ khởi hành

            e.Graphics.DrawString("THÀNH TIỀN: ", labelBoldFont, textBrush, leftMargin, yPosition);
            e.Graphics.DrawString(lblGiaVe.Text + "VNĐ", labelFont, textBrush, leftMargin + 180, yPosition);
            yPosition += 30;

            // Đường kẻ phân tách phần cuối
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, e.PageBounds.Width - leftMargin, yPosition);
            yPosition += 10; // Khoảng cách sau đường kẻ

            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center; // Căn giữa
            e.Graphics.DrawString("Quý Khách Vui Lòng Mang Theo Vé Xe Khi Lên Xe !!!!", labelFont, textBrush, e.PageBounds.Width / 2, yPosition, centerFormat);
            yPosition += 30;

            // Căn giữa văn bản "Cảm ơn Quý Khách đã sử dụng dịch vụ của nhà xe !!!!"
            e.Graphics.DrawString("Cảm ơn Quý Khách đã sử dụng dịch vụ của nhà xe !!!!", labelFont, textBrush, e.PageBounds.Width / 2, yPosition, centerFormat);
            yPosition += 30;
            // Kiểm tra nếu vẫn còn đủ không gian trên trang
            if (yPosition >= e.MarginBounds.Bottom)
            {
                e.HasMorePages = true; // Đánh dấu là cần in trang tiếp theo
            }
            else
            {
                e.HasMorePages = false; // In xong, không cần trang tiếp theo
            }

        }

        

        public void SetThongTin(string maKhachHang, string hoTen, string sdt,
                                string maXe, string tuyenDuong, string diemXuatPhat,
                                string diemDen, string ngayKhoiHanh, string gioKhoiHanh, string loaiVe, string giaVe, string TenNhaXe, string BienSo)
        {
            lblMaKhachHang.Text = maKhachHang;
            lblHoTen.Text = hoTen;
            lblMaXe.Text = maXe;
            lblTuyenDuong.Text = tuyenDuong;
            lblDiemXuatPhat.Text = diemXuatPhat;
            lblDiemDen.Text = diemDen;
            lblNgayKhoiHanh.Text = ngayKhoiHanh;
            lblGioKhoiHanh.Text = gioKhoiHanh;
            lblLoaiVe.Text = loaiVe;
            lblGiaVe.Text = giaVe;
            lblTenNhaXe.Text = TenNhaXe;
            lblBienSo.Text = BienSo;
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void rdtChuyenKhoan_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem RadioButton "Chuyển khoản" có được chọn không
            if (rdtChuyenKhoan.Checked)
            {
                // Nếu được chọn, hiển thị PictureBox
                ptbQRCode.Visible = true;
            }
            else
            {
                // Nếu không được chọn, ẩn PictureBox
                ptbQRCode.Visible = false;
            }
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Connection
            Connection connection = new Connection();
            bool check = connection.openConn();
            if (!check)
            {
                MessageBox.Show("Kết nối thất bại ");
                return;
            }

            try
            {
                string MaKhachHang = lblMaKhachHang.Text;
                string MaXe = lblMaXe.Text;
                string MaLoaiVe = lblLoaiVe.Text.ToString().Split('-')[1];
                string NgayDatVe = DateTime.Now.ToString();


                string sql = $@"INSERT INTO LichSuDatVe (MaKhachHang, MaXe, MaLoaiVe, NgayDatVe, TrangThaiVe )
                          VALUES ('{MaKhachHang}','{MaXe}','{MaLoaiVe}','{NgayDatVe}', 0 )";
                int KQ = connection.executeUpdate(sql);
                if (KQ > 0)
                {
                    MessageBox.Show("Thêm thành công !!!");
                }
                else
                {
                    MessageBox.Show("Thất Bại");
                }
                connection.closeConn();

                printPreviewDialog.ShowDialog();
             
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);

            }
        }
    }
}
