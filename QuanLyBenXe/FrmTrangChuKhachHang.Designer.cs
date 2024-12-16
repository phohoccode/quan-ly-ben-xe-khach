namespace QuanLyBenXe
{
    partial class FrmTrangChuKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChuKhachHang));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnLichSuDatVe = new System.Windows.Forms.Button();
            this.btnHoTroKhachHang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(256, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1130, 769);
            this.panelContainer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.btnLichSuDatVe);
            this.panel1.Controls.Add(this.btnHoTroKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 769);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẾN XE XANH";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.CausesValidation = false;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(14, 177);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(210, 21);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Xin chào! ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBenXe.Properties.Resources.bus_stop;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::QuanLyBenXe.Properties.Resources.logout__1_;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(14, 706);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(220, 40);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = global::QuanLyBenXe.Properties.Resources.house;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(18, 250);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(220, 40);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnLichSuDatVe
            // 
            this.btnLichSuDatVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSuDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuDatVe.ForeColor = System.Drawing.Color.White;
            this.btnLichSuDatVe.Image = global::QuanLyBenXe.Properties.Resources.history__1_;
            this.btnLichSuDatVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuDatVe.Location = new System.Drawing.Point(18, 302);
            this.btnLichSuDatVe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLichSuDatVe.Name = "btnLichSuDatVe";
            this.btnLichSuDatVe.Size = new System.Drawing.Size(220, 40);
            this.btnLichSuDatVe.TabIndex = 1;
            this.btnLichSuDatVe.Text = "Lịch sử dặt vé";
            this.btnLichSuDatVe.UseVisualStyleBackColor = true;
            this.btnLichSuDatVe.Click += new System.EventHandler(this.btnLichSuDatVe_Click);
            // 
            // btnHoTroKhachHang
            // 
            this.btnHoTroKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoTroKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoTroKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnHoTroKhachHang.Image = global::QuanLyBenXe.Properties.Resources.technical_support;
            this.btnHoTroKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoTroKhachHang.Location = new System.Drawing.Point(18, 354);
            this.btnHoTroKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHoTroKhachHang.Name = "btnHoTroKhachHang";
            this.btnHoTroKhachHang.Size = new System.Drawing.Size(220, 40);
            this.btnHoTroKhachHang.TabIndex = 1;
            this.btnHoTroKhachHang.Text = "Hỗ trợ khách hàng";
            this.btnHoTroKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoTroKhachHang.UseVisualStyleBackColor = true;
            this.btnHoTroKhachHang.Click += new System.EventHandler(this.btnHoTroKhachHang_Click);
            // 
            // FrmTrangChuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1386, 769);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrangChuKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ khách hàng";
            this.Load += new System.EventHandler(this.FrmTrangChuKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnHoTroKhachHang;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnLichSuDatVe;
    }
}