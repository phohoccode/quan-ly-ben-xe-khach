using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmQuanLyLichTrinh : Form
    {
        public FrmQuanLyLichTrinh()
        {
            InitializeComponent();
        }


        void resetForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
            dtpk_ngay.Value = DateTime.Today;
            dtpk_gio.Value = DateTime.Now; // Reset giờ về hiện tại
            btn_sua.Enabled = false;
            btn_sua.Text = "Sửa";
            btn_xoa.Enabled = false;
            btn_them.Enabled = true;
        }

        void VoHieuHoa()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = false;
                }
            }
            cbx_maxe.Enabled = false; // Vô hiệu hóa ComboBox mã xe khi xem chi tiết
            dtpk_ngay.Enabled = false;
            dtpk_gio.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true; // Kích hoạt nút Xóa khi xem chi tiết
            btn_them.Enabled = false;
            txt_malichtrinh.Enabled = false;
        }

        void HieuHoa()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                }
            }
            cbx_maxe.Enabled = true; // Kích hoạt ComboBox mã xe khi chỉnh sửa
            dtpk_ngay.Enabled = true;
            dtpk_gio.Enabled = true;
            btn_sua.Text = "Lưu";
            btn_xoa.Enabled = false; // Vô hiệu hóa nút Xóa khi chỉnh sửa
            btn_them.Enabled = false;
            txt_malichtrinh.Enabled = false;
        }

        void loaddgv()
        {
            Connection kn = new Connection();
            if (kn.openConn())
            {
                string sql = "SELECT MaLichTrinh as 'Mã lịch Trình', MaXe as 'Mã Xe', TuyenDuong as 'Tuyến Đường', DiemXuatPhat as 'Điểm Xuất Phát', DiemDen as 'Điểm Đến', NgayKhoiHanh as 'Ngày Khởi Hành',GioKhoiHanh as 'Giờ Khởi Hành', CASE WHEN TrangThai = 0 THEN N'Hoạt Động' WHEN TrangThai = 1 THEN N'Tạm Hoãn' WHEN TrangThai = 2 THEN N'Hủy' END as 'Trạng Thái'  FROM LICHTRINH";
                kn.executeSQL(sql);
                DataTable dt = new DataTable();
                dt.Load(kn.drd);
                dgv.DataSource = dt;
                kn.drd.Close();
                kn.closeConn();
            }
            else
            {
                MessageBox.Show("Không thể kết nối CSDL");
            }
        }

        public bool Kttt()
        {
            if (txt_dxp.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm xuất phát!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_dxp.Focus();
                return false;
            }
            if (txt_dd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm đến!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_dd.Focus();
                return false;
            }
            if (txt_tuyenduong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tuyến đường!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tuyenduong.Focus();
                return false;
            }
            if (cbx_trangthai.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbx_trangthai.Focus();
                return false;
            }
            DateTime dateTime = DateTime.Now;
            if (dtpk_ngay.Value < dateTime.Date)
            {
                MessageBox.Show("Ngày khởi hành không được nhỏ hơn ngày hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpk_ngay.Focus();
                return false;
            }
            if (dtpk_gio.Value.TimeOfDay < DateTime.Now.TimeOfDay && dtpk_ngay.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Giờ khởi hành không được nhỏ hơn giờ hiện tại nếu ngày khởi hành là hôm nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpk_gio.Focus();
                return false;
            }
            return true; // Trả về true nếu tất cả các kiểm tra đều hợp lệ
        }


        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                string mlt = row.Cells[0].Value.ToString();

                Connection kn = new Connection();
                if (kn.openConn())
                {
                    string sql = "SELECT MaLichTrinh, MaXe, TuyenDuong, DiemXuatPhat, DiemDen, NgayKhoiHanh, GioKhoiHanh, TrangThai FROM LICHTRINH WHERE MaLichTrinh= '" + mlt + "'";
                    kn.executeSQL(sql);

                    while (kn.drd.Read())
                    {
                        txt_malichtrinh.Text = kn.drd["MaLichTrinh"].ToString();
                        cbx_maxe.SelectedItem = kn.drd["MaXe"].ToString(); // Chọn mã xe từ ComboBox                       
                        txt_tuyenduong.Text = kn.drd["TuyenDuong"].ToString();
                        DateTime dt = Convert.ToDateTime(kn.drd["NgayKhoiHanh"]);
                        TimeSpan ts = TimeSpan.Parse(kn.drd["GioKhoiHanh"].ToString());
                        dtpk_ngay.Value = dt;
                        dtpk_gio.Value = DateTime.Today.Add(ts);
                        txt_dxp.Text = kn.drd["DiemXuatPhat"].ToString();
                        txt_dd.Text = kn.drd["DiemDen"].ToString();
                        int trangThai = Convert.ToInt32(kn.drd["TrangThai"]);
                        cbx_trangthai.SelectedIndex = trangThai;
                    }

                    kn.drd.Close();
                    kn.closeConn();
                    VoHieuHoa();
                }
                else
                {
                    MessageBox.Show("Không thể kết nối CSDL");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng.");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (Kttt())
            {
                try
                {
                    Connection kn = new Connection();
                    if (kn.openConn())
                    {
                        string sql = "INSERT INTO LICHTRINH(MaXe, TuyenDuong, DiemXuatPhat, DiemDen, NgayKhoiHanh, GioKhoiHanh, TrangThai) " +
                                     "VALUES (" + cbx_maxe.SelectedItem.ToString() + ", " +
                                     "N'" + txt_tuyenduong.Text + "', " +
                                     "N'" + txt_dxp.Text + "', " +
                                     "N'" + txt_dd.Text + "', " +
                                     "'" + dtpk_ngay.Value.ToString("yyyy-MM-dd") + "', " +
                                     "'" + dtpk_gio.Value.ToString("HH:mm") + "', " +
                                     cbx_trangthai.SelectedIndex + ")";

                        kn.executeUpdate(sql);
                        kn.closeConn();

                        loaddgv();
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetForm();
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            // Kiểm tra nếu đang ở chế độ chỉnh sửa
            if (btn_sua.Text == "Lưu")
            {
                if (Kttt()) // Kiểm tra thông tin nhập
                {
                    try
                    {
                        Connection kn = new Connection();

                        if (kn.openConn())
                        {
                            string sql = "UPDATE LICHTRINH SET " +
                                         "MaXe = " + cbx_maxe.SelectedItem.ToString() + ", " +
                                         "TuyenDuong = N'" + txt_tuyenduong.Text + "', " +
                                         "DiemXuatPhat = N'" + txt_dxp.Text + "', " +
                                         "DiemDen = N'" + txt_dd.Text + "', " +
                                         "NgayKhoiHanh = '" + dtpk_ngay.Value.ToString("yyyy-MM-dd") + "', " +
                                         "GioKhoiHanh = '" + dtpk_gio.Value.ToString("HH:mm") + "', " +
                                         "TrangThai = " + cbx_trangthai.SelectedIndex +
                                         " WHERE MaLichTrinh = '" + txt_malichtrinh.Text + "'";

                            kn.executeUpdate(sql);
                            kn.closeConn();

                            loaddgv(); // Nạp lại dữ liệu sau khi sửa
                            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetForm(); // Reset form sau khi sửa
                        }
                        else
                        {
                            MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Chuyển sang chế độ chỉnh sửa
                HieuHoa(); // Kích hoạt các trường để chỉnh sửa
                btn_sua.Text = "Lưu"; // Đổi nút thành "Lưu"
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có một hàng được chọn trong DataGridView
            if (dgv.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Lấy giá trị Mã Lịch Trình từ hàng được chọn
                        string mlt = dgv.SelectedRows[0].Cells[0].Value.ToString();

                        // Tạo kết nối CSDL
                        Connection kn = new Connection();
                        if (kn.openConn())
                        {
                            // Thực hiện câu lệnh xóa dữ liệu
                            string sql = "DELETE FROM LICHTRINH WHERE MaLichTrinh = '" + mlt + "'";
                            kn.executeUpdate(sql);
                            kn.closeConn();

                            // Nạp lại dữ liệu sau khi xóa
                            loaddgv();
                            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetForm(); // Reset form sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string keyword = txt_tim.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tim.Focus();
                return;
            }

            Connection kn = new Connection();
            if (kn.openConn())
            {
                try
                {
                    // Truy vấn tìm kiếm
                    string sql = "SELECT MaLichTrinh as 'Mã lịch Trình', MaXe as 'Mã Xe', TuyenDuong as 'Tuyến Đường', DiemXuatPhat as 'Điểm Xuất Phát', DiemDen as 'Điểm Đến', NgayKhoiHanh as 'Ngày Khởi Hành', GioKhoiHanh as 'Giờ Khởi Hành', " +
                                 "CASE WHEN TrangThai = 0 THEN N'Hoạt Động' WHEN TrangThai = 1 THEN N'Tạm Hoãn' WHEN TrangThai = 2 THEN N'Hủy' END as 'Trạng Thái' " +
                                 "FROM LICHTRINH " +
                                 "WHERE MaLichTrinh LIKE '%" + keyword + "%' OR " +
                                 "MaXe LIKE '%" + keyword + "%' OR " +
                                 "TuyenDuong LIKE N'%" + keyword + "%' OR " +
                                 "DiemXuatPhat LIKE N'%" + keyword + "%' OR " +
                                 "DiemDen LIKE N'%" + keyword + "%'";

                    kn.executeSQL(sql);
                    DataTable dt = new DataTable();
                    dt.Load(kn.drd);
                    dgv.DataSource = dt; // Hiển thị kết quả tìm kiếm trong DataGridView
                    kn.drd.Close();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    kn.closeConn();
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RP_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng kết nối
                Connection kn = new Connection();

                // Kiểm tra mở kết nối
                if (!kn.openConn())
                {
                    MessageBox.Show("Không thể kết nối CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Câu lệnh truy vấn danh sách lịch trình
                string query = @"
                              SELECT 
                               MaLichTrinh AS 'Mã Lịch Trình', 
                               MaXe AS 'Mã Xe', 
                               TuyenDuong AS 'Tuyến Đường', 
                               DiemXuatPhat AS 'Điểm Xuất Phát', 
                               DiemDen AS 'Điểm Đến', 
                               NgayKhoiHanh AS 'Ngày Khởi Hành', 
                               GioKhoiHanh AS 'Giờ Khởi Hành', 
                               CASE 
                               WHEN TrangThai = 0 THEN N'Hoạt Động' 
                               WHEN TrangThai = 1 THEN N'Tạm Hoãn' 
                               WHEN TrangThai = 2 THEN N'Hủy' 
                               END AS 'Trạng Thái' 
                               FROM LICHTRINH
                               ORDER BY NgayKhoiHanh, GioKhoiHanh;";

                // Đổ dữ liệu vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, kn.conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Tạo và hiển thị báo cáo
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += (s, args) => InDanhSachLichTrinh(args, dataTable);
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
                    {
                        Document = printDocument
                    };
                    printPreviewDialog.ShowDialog(); // Hiển thị cửa sổ xem trước khi in
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu lịch trình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Đóng kết nối
                kn.closeConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InDanhSachLichTrinh(PrintPageEventArgs args, DataTable dataTable)
        {
            Graphics g = args.Graphics;
            Font font = new Font("Arial", 12); // Font thông thường
            Font boldFont = new Font("Arial", 12, FontStyle.Bold); // Font đậm
            Pen blackPen = new Pen(Color.Black, 1); // Bút kẻ viền
            int yPos = 50; // Căn trên của bảng
            int xPos = 20; // Căn trái của bảng
            int rowHeight = 40; // Chiều cao của mỗi dòng
            int[] columnWidths = { 70, 60, 110, 110, 110, 120, 100, 110 }; // Độ rộng cột

            // Lấy kích thước của trang in
            int pageWidth = (int)args.PageBounds.Width;

            // Tiêu đề
            StringFormat titleFormat = new StringFormat
            {
                Alignment = StringAlignment.Center, // Căn giữa theo chiều ngang
                LineAlignment = StringAlignment.Center // Căn giữa theo chiều dọc
            };
            g.DrawString("DANH SÁCH LỊCH TRÌNH", boldFont, Brushes.Black, new RectangleF(0, 10, pageWidth, 40), titleFormat);

            // Vẽ bảng tiêu đề cột
            string[] headers = { "Mã LT", "Mã Xe", "Tuyến Đường", "Điểm XP", "Điểm Đến", "Ngày", "Giờ", "Trạng Thái" };
            int x = xPos;
            for (int i = 0; i < headers.Length; i++)
            {
                // Vẽ nền tiêu đề
                g.FillRectangle(Brushes.LightGray, x, yPos, columnWidths[i], rowHeight);
                // Kẻ viền
                g.DrawRectangle(blackPen, x, yPos, columnWidths[i], rowHeight);
                // In tên tiêu đề cột (in đậm)
                StringFormat headerFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center, // Căn giữa theo chiều ngang
                    LineAlignment = StringAlignment.Center // Căn giữa theo chiều dọc
                };
                g.DrawString(headers[i], boldFont, Brushes.Black, new RectangleF(x, yPos, columnWidths[i], rowHeight), headerFormat);
                x += columnWidths[i];
            }
            yPos += rowHeight;

            // Vẽ dữ liệu từng dòng
            foreach (DataRow row in dataTable.Rows)
            {
                x = xPos; // Reset lại vị trí x cho từng dòng

                // Lấy dữ liệu từ DataTable
                string[] rowData = {
                    row["Mã Lịch Trình"].ToString(),
                    row["Mã Xe"].ToString(),
                    row["Tuyến Đường"].ToString(),
                    row["Điểm Xuất Phát"].ToString(),
                    row["Điểm Đến"].ToString(),
                    Convert.ToDateTime(row["Ngày Khởi Hành"]).ToString("dd/MM/yyyy"),
                    row["Giờ Khởi Hành"].ToString(),
                    row["Trạng Thái"].ToString()
                };

                for (int i = 0; i < rowData.Length; i++)
                {
                    // Kẻ viền từng ô
                    g.DrawRectangle(blackPen, x, yPos, columnWidths[i], rowHeight);
                    // In dữ liệu trong ô, căn giữa
                    StringFormat cellFormat = new StringFormat
                    {
                        Alignment = StringAlignment.Center, // Căn giữa theo chiều ngang
                        LineAlignment = StringAlignment.Center // Căn giữa theo chiều dọc
                    };

                    // Kiểm tra nội dung có bị tràn không
                    RectangleF cellRect = new RectangleF(x, yPos, columnWidths[i], rowHeight);
                    string content = rowData[i];
                    SizeF textSize = g.MeasureString(content, font);
                    if (textSize.Width > columnWidths[i])
                    {
                        // Nếu nội dung quá dài, cắt bớt và thêm dấu "..."
                        while (textSize.Width > columnWidths[i] - 10)
                        {
                            content = content.Substring(0, content.Length - 1);
                            textSize = g.MeasureString(content + "...", font);
                        }
                        content += "...";
                    }
                    g.DrawString(content, font, Brushes.Black, cellRect, cellFormat);
                    x += columnWidths[i];
                }
                yPos += rowHeight; // Tăng vị trí y cho dòng tiếp theo
            }

            // Kiểm tra nếu bảng vượt quá vùng in
            if (yPos > args.PageBounds.Height - 50)
            {
                MessageBox.Show("Bảng quá dài, cần điều chỉnh dữ liệu để phù hợp với trang in!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Vẽ viền tổng bảng
            g.DrawRectangle(blackPen, xPos, 50, columnWidths.Sum(), yPos - 50);
        }

        private void FrmQuanLyLichTrinh_Load(object sender, EventArgs e)
        {
            loaddgv();
            // Load dữ liệu vào ComboBox mã xe
            Connection kn = new Connection();
            if (kn.openConn())
            {
                string sql = "SELECT MaXe FROM XEKHACH";
                kn.executeSQL(sql);

                while (kn.drd.Read())
                {
                    cbx_maxe.Items.Add(kn.drd["MaXe"].ToString());
                }

                kn.drd.Close();
                kn.closeConn();
            }
            else
            {
                MessageBox.Show("Không thể kết nối CSDL");
            }
            cbx_trangthai.Items.Add("Hoạt Động");
            cbx_trangthai.Items.Add("Tạm Hoãn");
            cbx_trangthai.Items.Add("Hủy");
        }
    }
}
