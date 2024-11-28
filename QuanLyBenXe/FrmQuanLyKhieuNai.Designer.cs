namespace QuanLyBenXe
{
    partial class FrmQuanLyKhieuNai
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelTuyChinh = new System.Windows.Forms.Panel();
            this.dtpTuyChinh = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cbCheDoHienThi = new System.Windows.Forms.ComboBox();
            this.dgvKhieuNai = new System.Windows.Forms.DataGridView();
            this.gbXuLyKN = new System.Windows.Forms.GroupBox();
            this.panelLyDoKhieuNai = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLyDoHuyKN = new System.Windows.Forms.ComboBox();
            this.cbHanhDong = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.panelTuyChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhieuNai)).BeginInit();
            this.gbXuLyKN.SuspendLayout();
            this.panelLyDoKhieuNai.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelTuyChinh);
            this.groupBox4.Controls.Add(this.cbCheDoHienThi);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 194);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chế độ hiển thị";
            // 
            // panelTuyChinh
            // 
            this.panelTuyChinh.Controls.Add(this.dtpTuyChinh);
            this.panelTuyChinh.Controls.Add(this.btnLamMoi);
            this.panelTuyChinh.Controls.Add(this.btnLoc);
            this.panelTuyChinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTuyChinh.Location = new System.Drawing.Point(3, 82);
            this.panelTuyChinh.Name = "panelTuyChinh";
            this.panelTuyChinh.Size = new System.Drawing.Size(349, 109);
            this.panelTuyChinh.TabIndex = 11;
            this.panelTuyChinh.Visible = false;
            // 
            // dtpTuyChinh
            // 
            this.dtpTuyChinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuyChinh.Location = new System.Drawing.Point(86, 8);
            this.dtpTuyChinh.Name = "dtpTuyChinh";
            this.dtpTuyChinh.Size = new System.Drawing.Size(171, 26);
            this.dtpTuyChinh.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Image = global::QuanLyBenXe.Properties.Resources.refresh__1_;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(171, 58);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(117, 40);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Image = global::QuanLyBenXe.Properties.Resources.filter__1_;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(62, 58);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(79, 40);
            this.btnLoc.TabIndex = 8;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbCheDoHienThi
            // 
            this.cbCheDoHienThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheDoHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCheDoHienThi.FormattingEnabled = true;
            this.cbCheDoHienThi.Items.AddRange(new object[] {
            "Chưa giải quyết",
            "Đã giải quyết",
            "Đã huỷ",
            "Tất cả",
            "Hôm nay",
            "Thời gian tuỳ chỉnh"});
            this.cbCheDoHienThi.Location = new System.Drawing.Point(26, 36);
            this.cbCheDoHienThi.Name = "cbCheDoHienThi";
            this.cbCheDoHienThi.Size = new System.Drawing.Size(306, 29);
            this.cbCheDoHienThi.TabIndex = 10;
            this.cbCheDoHienThi.SelectedIndexChanged += new System.EventHandler(this.cbCheDoHienThi_SelectedIndexChanged);
            // 
            // dgvKhieuNai
            // 
            this.dgvKhieuNai.AllowUserToAddRows = false;
            this.dgvKhieuNai.AllowUserToDeleteRows = false;
            this.dgvKhieuNai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKhieuNai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhieuNai.Location = new System.Drawing.Point(12, 235);
            this.dgvKhieuNai.Name = "dgvKhieuNai";
            this.dgvKhieuNai.ReadOnly = true;
            this.dgvKhieuNai.Size = new System.Drawing.Size(1106, 514);
            this.dgvKhieuNai.TabIndex = 5;
            // 
            // gbXuLyKN
            // 
            this.gbXuLyKN.Controls.Add(this.panelLyDoKhieuNai);
            this.gbXuLyKN.Controls.Add(this.cbHanhDong);
            this.gbXuLyKN.Controls.Add(this.btnXacNhan);
            this.gbXuLyKN.Location = new System.Drawing.Point(470, 12);
            this.gbXuLyKN.Name = "gbXuLyKN";
            this.gbXuLyKN.Size = new System.Drawing.Size(421, 194);
            this.gbXuLyKN.TabIndex = 6;
            this.gbXuLyKN.TabStop = false;
            this.gbXuLyKN.Text = "Xử lý khiếu nại";
            // 
            // panelLyDoKhieuNai
            // 
            this.panelLyDoKhieuNai.Controls.Add(this.label1);
            this.panelLyDoKhieuNai.Controls.Add(this.cbLyDoHuyKN);
            this.panelLyDoKhieuNai.Location = new System.Drawing.Point(6, 82);
            this.panelLyDoKhieuNai.Name = "panelLyDoKhieuNai";
            this.panelLyDoKhieuNai.Size = new System.Drawing.Size(409, 108);
            this.panelLyDoKhieuNai.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lý do huỷ bỏ khiếu nại";
            // 
            // cbLyDoHuyKN
            // 
            this.cbLyDoHuyKN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLyDoHuyKN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLyDoHuyKN.FormattingEnabled = true;
            this.cbLyDoHuyKN.Items.AddRange(new object[] {
            "Thông tin cung cấp không chính xác",
            "Khiếu nại đã được xử lý từ trước",
            "Ngôn từ không phù hợp",
            "Spam quá nhiều "});
            this.cbLyDoHuyKN.Location = new System.Drawing.Point(21, 40);
            this.cbLyDoHuyKN.Name = "cbLyDoHuyKN";
            this.cbLyDoHuyKN.Size = new System.Drawing.Size(375, 29);
            this.cbLyDoHuyKN.TabIndex = 10;
            // 
            // cbHanhDong
            // 
            this.cbHanhDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHanhDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHanhDong.FormattingEnabled = true;
            this.cbHanhDong.Items.AddRange(new object[] {
            "Huỷ bỏ",
            "Đã giải quyết"});
            this.cbHanhDong.Location = new System.Drawing.Point(27, 32);
            this.cbHanhDong.Name = "cbHanhDong";
            this.cbHanhDong.Size = new System.Drawing.Size(223, 29);
            this.cbHanhDong.TabIndex = 7;
            this.cbHanhDong.SelectedIndexChanged += new System.EventHandler(this.cbHanhDong_SelectedIndexChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Image = global::QuanLyBenXe.Properties.Resources.verified;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(279, 25);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(123, 40);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QuanLyBenXe.Properties.Resources.delete__1_;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1038, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmQuanLyKhieuNai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 761);
            this.Controls.Add(this.gbXuLyKN);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvKhieuNai);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLyKhieuNai";
            this.Text = "FrmQuanLyKhieuNai";
            this.Load += new System.EventHandler(this.FrmQuanLyKhieuNai_Load);
            this.groupBox4.ResumeLayout(false);
            this.panelTuyChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhieuNai)).EndInit();
            this.gbXuLyKN.ResumeLayout(false);
            this.panelLyDoKhieuNai.ResumeLayout(false);
            this.panelLyDoKhieuNai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvKhieuNai;
        private System.Windows.Forms.GroupBox gbXuLyKN;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cbHanhDong;
        private System.Windows.Forms.Panel panelLyDoKhieuNai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLyDoHuyKN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbCheDoHienThi;
        private System.Windows.Forms.Panel panelTuyChinh;
        private System.Windows.Forms.DateTimePicker dtpTuyChinh;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLamMoi;
    }
}