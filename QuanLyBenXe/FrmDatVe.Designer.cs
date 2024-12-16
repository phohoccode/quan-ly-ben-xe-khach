namespace QuanLyBenXe
{
    partial class FrmDatVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgLichTrinh = new System.Windows.Forms.DataGridView();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiVe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDiemDi = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbDiemDen = new System.Windows.Forms.ComboBox();
            this.dtpNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.btnTraThongTin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichTrinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dtgLichTrinh);
            this.groupBox3.Location = new System.Drawing.Point(12, 378);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(876, 372);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách lịch trình";
            // 
            // dtgLichTrinh
            // 
            this.dtgLichTrinh.AllowUserToAddRows = false;
            this.dtgLichTrinh.AllowUserToDeleteRows = false;
            this.dtgLichTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgLichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLichTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLichTrinh.Location = new System.Drawing.Point(3, 21);
            this.dtgLichTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgLichTrinh.Name = "dtgLichTrinh";
            this.dtgLichTrinh.RowHeadersWidth = 62;
            this.dtgLichTrinh.RowTemplate.Height = 28;
            this.dtgLichTrinh.Size = new System.Drawing.Size(870, 349);
            this.dtgLichTrinh.TabIndex = 48;
            this.dtgLichTrinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLichTrinh_CellContentClick);
            this.dtgLichTrinh.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgLichTrinh_CellFormatting);
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Enabled = false;
            this.txtGiaVe.Location = new System.Drawing.Point(334, 135);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(214, 26);
            this.txtGiaVe.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(330, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Giá vé:";
            // 
            // cbLoaiVe
            // 
            this.cbLoaiVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiVe.FormattingEnabled = true;
            this.cbLoaiVe.Location = new System.Drawing.Point(34, 134);
            this.cbLoaiVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiVe.Name = "cbLoaiVe";
            this.cbLoaiVe.Size = new System.Drawing.Size(214, 29);
            this.cbLoaiVe.TabIndex = 49;
            this.cbLoaiVe.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiVe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Loại vé:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.txtGiaVe);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbLoaiVe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbDiemDi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbDiemDen);
            this.groupBox2.Controls.Add(this.dtpNgayKhoiHanh);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(876, 193);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin lịch trình";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbDiemDi
            // 
            this.cmbDiemDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiemDi.FormattingEnabled = true;
            this.cmbDiemDi.Location = new System.Drawing.Point(35, 68);
            this.cmbDiemDi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiemDi.Name = "cmbDiemDi";
            this.cmbDiemDi.Size = new System.Drawing.Size(214, 29);
            this.cmbDiemDi.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(608, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 21);
            this.label12.TabIndex = 46;
            this.label12.Text = "Chọn ngày khởi hành:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(31, 39);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 21);
            this.label15.TabIndex = 40;
            this.label15.Text = "Chọn điểm đi :";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(612, 131);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 30);
            this.btnTimKiem.TabIndex = 47;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(330, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 21);
            this.label14.TabIndex = 41;
            this.label14.Text = "Chọn điểm đến :";
            // 
            // cmbDiemDen
            // 
            this.cmbDiemDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiemDen.FormattingEnabled = true;
            this.cmbDiemDen.Location = new System.Drawing.Point(334, 68);
            this.cmbDiemDen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiemDen.Name = "cmbDiemDen";
            this.cmbDiemDen.Size = new System.Drawing.Size(214, 29);
            this.cmbDiemDen.TabIndex = 42;
            // 
            // dtpNgayKhoiHanh
            // 
            this.dtpNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKhoiHanh.Location = new System.Drawing.Point(642, 82);
            this.dtpNgayKhoiHanh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKhoiHanh.Name = "dtpNgayKhoiHanh";
            this.dtpNgayKhoiHanh.Size = new System.Drawing.Size(155, 26);
            this.dtpNgayKhoiHanh.TabIndex = 45;
            // 
            // btnTraThongTin
            // 
            this.btnTraThongTin.Location = new System.Drawing.Point(75, 73);
            this.btnTraThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraThongTin.Name = "btnTraThongTin";
            this.btnTraThongTin.Size = new System.Drawing.Size(155, 30);
            this.btnTraThongTin.TabIndex = 58;
            this.btnTraThongTin.Text = "Tra thông tin";
            this.btnTraThongTin.UseVisualStyleBackColor = true;
            this.btnTraThongTin.Click += new System.EventHandler(this.btnTraThongTin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 57;
            this.label5.Text = "Mã khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(51, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "SĐT:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(157, 79);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(232, 25);
            this.txtSDT.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(51, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(157, 37);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(232, 25);
            this.txtHoTen.TabIndex = 51;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(156, 18);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(157, 25);
            this.txtMaKhachHang.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Location = new System.Drawing.Point(435, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(450, 132);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(736, 130);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(107, 30);
            this.btnLamMoi.TabIndex = 61;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FrmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTraThongTin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDatVe";
            this.Text = "FrmDatVe";
            this.Load += new System.EventHandler(this.FrmDatVe_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichTrinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgLichTrinh;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDiemDi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbDiemDen;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiHanh;
        private System.Windows.Forms.Button btnTraThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
    }
}