using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmQuanLyXeKhach : Form
    {
        public FrmQuanLyXeKhach()
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
            btn_sua.Enabled = false;
            btn_sua.Text = "Chỉnh sửa";
            btn_xoa.Enabled = false;
            btn_them.Enabled = true;
            txt_maxe.Enabled = false;
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
            dtpk_ngay.Enabled = false;
            btn_sua.Enabled = true;
            btn_sua.Text = "Chỉnh sửa";
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            txt_maxe.Enabled = false;
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
            dtpk_ngay.Enabled = true;
            btn_sua.Text = "Lưu";
            btn_xoa.Enabled = false;
            btn_them.Enabled = false;
        }

        void loaddgv()
        {
            //B1. Tạo đối tượng thuộc lớp Connection (Kết nối)
            Connection kn = new Connection();
            //B2. Mở kết nối
            if (kn.openConn())
            {
                //3. Thao tác dữ liệu (truy vấn)
                string sql = "SELECT MaXe as 'Mã Xe', TenNhaXe as 'Tên Nhà Xe', LoaiXe as 'Loại Xe', BienSo as 'Biển Số', SoChoNgoi as 'Số Chỗ Ngồi', CASE WHEN TrangThai = 0 THEN N'Hoạt Động' WHEN TrangThai = 1 THEN N'Ngừng Hoạt Động' WHEN TrangThai = 2 THEN N'Bảo Trì' END as 'Trạng Thái', NgayTao as 'Ngày Tạo' FROM XEKHACH";
                kn.executeSQL(sql);
                //Sau câu lệnh trên DataReader của lớp Connection (rdr) đã có dữ liệu
                //Nạp dữ liệu từ rdr của lớp Connection vào DataTable
                DataTable dt = new DataTable();
                dt.Load(kn.drd);
                //Đưa DataTable thành DataSource của DataGridView
                dgv.DataSource = dt;


                //Đóng kết nối
                kn.drd.Close();//Đóng DataReader đang đọc dữ liệu
                kn.closeConn();//Đóng kết nối đến CSDL
            }
            else
            {
                MessageBox.Show("Không thể kết nối CSDL");
            }
        }

        //KIEM TRA THONG TIN NHAP THIEU HAY KHONG
        public bool Kttt()
        {

            if (!int.TryParse(txt_socho.Text.Trim(), out int soCho) || soCho <= 0 || soCho > 50)
            {
                MessageBox.Show("Số chỗ ngồi không hợp lệ. Vui lòng nhập số từ 1 đến 50.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_socho.Focus();
                return false;
            }

            if (txt_nhaxe.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nhaxe.Focus();
                return false;
            }
            if (cbx_loaixe.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbx_loaixe.Focus();
                return false;
            }
            if (txt_bienso.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập biển số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_bienso.Focus();
                return false;
            }
            if (cbx_trangthai.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbx_trangthai.Focus();
                return false;
            }
            DateTime dateTime = DateTime.Now;
            if (dtpk_ngay.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày tạo không thể lớn hơn ngày hiện tại. Vui lòng chọn lại.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpk_ngay.Focus();
                return false;
            }


            return true; // Trả về true nếu tất cả các kiểm tra đều hợp lệ

        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            string tenNhaXe = txt_tim.Text.Trim(); // Lấy tên nhà xe từ TextBox
            if (string.IsNullOrWhiteSpace(tenNhaXe))
            {
                MessageBox.Show("Vui lòng nhập tên nhà xe để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tim.Focus();
                return;
            }

            // Tạo đối tượng kết nối
            Connection kn = new Connection();

            // Mở kết nối
            if (kn.openConn())
            {
                // Câu lệnh SQL tìm kiếm xe theo tên nhà xe
                string sql = "SELECT MaXe as 'Mã Xe', TenNhaXe as 'Tên Nhà Xe', LoaiXe as 'Loại Xe', BienSo as 'Biển Số', " +
                             "SoChoNgoi as 'Số Chỗ Ngồi', CASE WHEN TrangThai = 0 THEN N'Hoạt Động' " +
                             "WHEN TrangThai = 1 THEN N'Ngừng Hoạt Động' WHEN TrangThai = 2 THEN N'Bảo Trì' END as 'Trạng Thái', " +
                             "NgayTao as 'Ngày Tạo' " +
                             "FROM XEKHACH WHERE TenNhaXe LIKE N'%" + tenNhaXe + "%'";

                // Thực thi truy vấn
                kn.executeSQL(sql);

                // Nạp dữ liệu từ DataReader vào DataTable
                DataTable dt = new DataTable();
                dt.Load(kn.drd);

                // Gán dữ liệu cho DataGridView
                dgv_tim.DataSource = dt;



                // Đóng kết nối
                kn.drd.Close();
                kn.closeConn();
            }
            else
            {
                MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quanlyxe_Load(object sender, EventArgs e)
        {
            cbx_trangthai.Items.Add("Hoạt Động");
            cbx_trangthai.Items.Add("Ngừng Hoạt Động");
            cbx_trangthai.Items.Add("Bảo Trì");

            cbx_loaixe.Items.Add("Ghế Ngồi");
            cbx_loaixe.Items.Add("Giường Nằm");
            cbx_loaixe.SelectedIndex = 0;  // Thiết lập giá trị mặc định
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0) // Kiểm tra nếu có hàng nào được chọn
            {
                DataGridViewRow row = dgv.SelectedRows[0]; // Lấy hàng đầu tiên được chọn
                string msxe = row.Cells[0].Value.ToString();

                // Tạo đối tượng thuộc lớp Connection (Kết nối)
                Connection kn = new Connection();

                // Mở kết nối
                if (kn.openConn())
                {
                    // Thao tác dữ liệu (truy vấn)
                    string sql = "SELECT MaXe, BienSo, LoaiXe, SoChoNgoi, TenNhaXe, TrangThai, NgayTao FROM XEKHACH " +
                                 "WHERE MaXe= '" + msxe + "'";
                    kn.executeSQL(sql);

                    // Đọc dữ liệu
                    while (kn.drd.Read())
                    {
                        txt_maxe.Text = kn.drd["MaXe"].ToString();
                        txt_bienso.Text = kn.drd["BienSo"].ToString();
                        DateTime dt = Convert.ToDateTime(kn.drd["NgayTao"]);
                        dtpk_ngay.Value = dt;
                        txt_socho.Text = kn.drd["SoChoNgoi"].ToString();
                        txt_nhaxe.Text = kn.drd["TenNhaXe"].ToString();
                        int trangThai = Convert.ToInt32(kn.drd["TrangThai"]);
                        cbx_trangthai.SelectedIndex = trangThai; // Hoạt Động = 0, Ngừng Hoạt Động = 1, Bảo Trì = 2
                        string loaixe = kn.drd["LoaiXe"].ToString();
                        cbx_loaixe.SelectedItem = loaixe;
                    }

                    // Đóng kết nối
                    kn.drd.Close(); // Đóng DataReader đang đọc dữ liệu
                    kn.closeConn(); // Đóng kết nối đến CSDL
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
            //B1. Tạo đối tượng lớp Connection (xây dựng)
            Connection kn = new Connection();


            Kttt();

            //B2. Mở kết nối
            if (kn.openConn())
            {
                bool err = false;

                //B3. Xử lý dữ liệu
                //B3.1 Kiểm tra tính hợp lệ của dữ liệu (Validation)
                if (txt_bienso.Text == "")
                {
                    err = true;
                    MessageBox.Show("Biển số không được rỗng");
                }
                else
                {
                    string sql = "SELECT MaXe FROM XEKHACH WHERE BienSo='" + txt_bienso.Text + "'";
                    kn.executeSQL(sql);
                    if (kn.drd.Read())
                    {
                        err = true;
                        MessageBox.Show("Biển số " + txt_bienso.Text + " đã tồn tại trong CSDL");
                    }
                    kn.drd.Close();
                }

                //B3.2 Thêm dữ liệu
                if (!err) //if(err == false)
                {
                    string loaixe = cbx_loaixe.SelectedItem.ToString(); // Lấy giá trị từ ComboBox
                    int trangThai = cbx_trangthai.SelectedIndex; // Lấy giá trị số (0, 1, 2)
                    string ngay = dtpk_ngay.Value.ToString("yyyy-MM-dd");
                    string sINS = "INSERT INTO XEKHACH (TenNhaXe, SoChoNgoi, BienSo, LoaiXe, TrangThai, NgayTao) " +
                                  "VALUES (N'" + txt_nhaxe.Text + "', " +
                                  txt_socho.Text + ", " +
                                  "'" + txt_bienso.Text + "', " +
                                  "N'" + loaixe + "', " +
                                   trangThai + ", " +
                                  "GETDATE())"; // Sử dụng GETDATE() để lấy thời gian hiện tại

                    int kq = kn.executeUpdate(sINS);
                    if (kq > 0)
                        MessageBox.Show("Thêm thông tin xe khách thành công");
                    else
                        MessageBox.Show("Không thể thêm thông tin xe khách, liên hệ admin");

                    //B4. Đóng kết nối
                    kn.closeConn();
                    resetForm();
                    loaddgv();
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có chọn một bản ghi nào trong DataGridView không
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0]; // Lấy dòng đã chọn
                string maxe = row.Cells[0].Value.ToString(); // Lấy mã xe từ cột đầu tiên

                // Xác nhận người dùng có chắc chắn muốn xóa không
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // Tạo đối tượng kết nối
                    Connection kn = new Connection();
                    if (kn.openConn())
                    {
                        // Câu lệnh xóa xe dựa trên mã xe
                        string sql = "DELETE FROM XEKHACH WHERE MaXe = '" + maxe + "'";

                        // Thực thi câu lệnh
                        int kq = kn.executeUpdate(sql);
                        if (kq > 0)
                        {
                            MessageBox.Show("Xóa thông tin xe khách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa thông tin xe khách, liên hệ admin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Đóng kết nối
                        kn.closeConn();
                        loaddgv(); // Tải lại danh sách xe
                        resetForm(); // Reset các ô nhập liệu
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Chỉnh sửa") // Khi ở chế độ chỉnh sửa
            {
                HieuHoa(); // Cho phép chỉnh sửa các trường
            }
            else if (btn_sua.Text == "Lưu") // Khi ở chế độ lưu
            {
                // Kiểm tra tính hợp lệ của thông tin
                if (Kttt())
                {
                    // Thực hiện lưu thông tin
                    Connection kn = new Connection();
                    if (kn.openConn())
                    {
                        string maXe = txt_maxe.Text; // Lấy mã xe từ textbox
                        string bienSo = txt_bienso.Text;
                        string loaiXe = cbx_loaixe.SelectedItem.ToString();
                        int soCho = int.Parse(txt_socho.Text);
                        string nhaXe = txt_nhaxe.Text;
                        int trangThai = cbx_trangthai.SelectedIndex; // 0 = Hoạt Động, 1 = Ngừng Hoạt Động, 2 = Bảo Trì
                        string ngayTao = dtpk_ngay.Value.ToString("yyyy-MM-dd");

                        // Câu lệnh SQL cập nhật
                        string sql = "UPDATE XEKHACH SET " +
                                     "TenNhaXe = N'" + nhaXe + "', " +
                                     "LoaiXe = N'" + loaiXe + "', " +
                                     "BienSo = '" + bienSo + "', " +
                                     "SoChoNgoi = " + soCho + ", " +
                                     "TrangThai = " + trangThai + ", " +
                                     "NgayTao = '" + ngayTao + "' " +
                                     "WHERE MaXe = '" + maXe + "'";

                        // Thực thi câu lệnh
                        int kq = kn.executeUpdate(sql);
                        if (kq > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetForm(); // Reset form
                            loaddgv(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật thông tin, vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        kn.closeConn(); // Đóng kết nối
                    }
                }
            }
        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                // Câu lệnh truy vấn danh sách xe
                string query = @"
                    SELECT 
                        MaXe, 
                        TenNhaXe, 
                        LoaiXe, 
                        BienSo, 
                        SoChoNgoi, 
                        CASE 
                            WHEN TrangThai = 0 THEN N'Hoạt Động' 
                            WHEN TrangThai = 1 THEN N'Ngừng Hoạt Động' 
                            WHEN TrangThai = 2 THEN N'Bảo Trì' 
                        END AS TrangThai, 
                        NgayTao 
                    FROM 
                        XEKHACH 
                    ORDER BY 
                        TenNhaXe;";

                // Đổ dữ liệu vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, kn.conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Tạo và hiển thị báo cáo
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += (s, args) => InDanhSachXe(args, dataTable);
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
                    {
                        Document = printDocument
                    };
                    printPreviewDialog.ShowDialog(); // Hiển thị cửa sổ xem trước khi in
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu danh sách xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Đóng kết nối
                kn.closeConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int currentRow = 0; // Biến toàn cục để theo dõi dòng hiện tại trong danh sách
        private void InDanhSachXe(PrintPageEventArgs args, DataTable dataTable)
        {
            Graphics g = args.Graphics;
            Font font = new Font("Arial", 12); // Font thông thường
            Font boldFont = new Font("Arial", 12, FontStyle.Bold); // Font đậm
            Font titleFont = new Font("Arial", 16, FontStyle.Bold); // Font tiêu đề lớn hơn
            Pen blackPen = new Pen(Color.Black, 1); // Bút kẻ viền
            int yPos = 20; // Căn trên của bảng
            int xPos = 20; // Căn trái của bảng
            int rowHeight = 40; // Chiều cao của mỗi dòng
            int[] columnWidths = { 60, 120, 120, 100, 80, 120, 180 }; // Độ rộng từng cột

            // Lấy kích thước của trang in
            int pageWidth = (int)args.PageBounds.Width;

            // Vẽ tiêu đề "DANH SÁCH XE KHÁCH"
            StringFormat titleFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,      // Căn giữa theo chiều ngang
                LineAlignment = StringAlignment.Center  // Căn giữa theo chiều dọc
            };

            RectangleF titleRect = new RectangleF(0, yPos, pageWidth, 50); // Vị trí và kích thước của tiêu đề
            g.FillRectangle(Brushes.White, titleRect); // Nền trắng (nếu cần)
            g.DrawString("DANH SÁCH XE KHÁCH", titleFont, Brushes.Black, titleRect, titleFormat);
            yPos += 60; // Tăng vị trí Y để cách tiêu đề với bảng dữ liệu

            // Vẽ bảng tiêu đề cột
            string[] headers = { "Mã Xe", "Tên Nhà Xe", "Loại Xe", "Biển Số", "Số Chỗ", "Trạng Thái", "Ngày Tạo" };
            int x = xPos;
            for (int i = 0; i < headers.Length; i++)
            {
                // Vẽ nền tiêu đề
                g.FillRectangle(Brushes.LightGray, x, yPos, columnWidths[i], rowHeight);
                g.DrawRectangle(blackPen, x, yPos, columnWidths[i], rowHeight);
                StringFormat headerFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(headers[i], boldFont, Brushes.Black, new RectangleF(x, yPos, columnWidths[i], rowHeight), headerFormat);
                x += columnWidths[i];
            }
            yPos += rowHeight;

            // Vẽ dữ liệu từng dòng
            while (currentRow < dataTable.Rows.Count)
            {
                x = xPos; // Reset lại vị trí x cho từng dòng
                DataRow row = dataTable.Rows[currentRow];

                string[] rowData = {
            row["MaXe"].ToString(),
            row["TenNhaXe"].ToString(),
            row["LoaiXe"].ToString(),
            row["BienSo"].ToString(),
            row["SoChoNgoi"].ToString(),
            row["TrangThai"].ToString(),
            Convert.ToDateTime(row["NgayTao"]).ToString("dd/MM/yyyy HH:mm:ss")
        };

                for (int i = 0; i < rowData.Length; i++)
                {
                    g.DrawRectangle(blackPen, x, yPos, columnWidths[i], rowHeight);
                    StringFormat cellFormat = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    // Kiểm tra và cắt nội dung nếu quá dài
                    RectangleF cellRect = new RectangleF(x, yPos, columnWidths[i], rowHeight);
                    string content = rowData[i];
                    SizeF textSize = g.MeasureString(content, font);
                    if (textSize.Width > columnWidths[i])
                    {
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
                yPos += rowHeight;
                currentRow++;

                // Kiểm tra nếu vượt quá vùng in
                if (yPos + rowHeight > args.MarginBounds.Bottom)
                {
                    args.HasMorePages = true; // In trang tiếp theo
                    return;
                }
            }

            // Nếu in xong tất cả dữ liệu
            args.HasMorePages = false;
            currentRow = 0; // Reset dòng hiện tại cho lần in sau
        }

        private void FrmQuanLyXeKhach_Load(object sender, EventArgs e)
        {
            loaddgv();
            quanlyxe_Load(sender, e);
        }
    }
}
