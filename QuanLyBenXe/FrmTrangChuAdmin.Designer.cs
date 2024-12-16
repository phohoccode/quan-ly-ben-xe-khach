namespace QuanLyBenXe
{
    partial class FrmTrangChuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChuAdmin));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLyLichTrinh = new System.Windows.Forms.Button();
            this.btnQuanLyDoanhThu = new System.Windows.Forms.Button();
            this.btnQuanLyXeKhach = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyVeXe = new System.Windows.Forms.Button();
            this.btnQuanLyKhieuNai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(254, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1130, 761);
            this.panelContainer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.btnQuanLyKhachHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnQuanLyLichTrinh);
            this.panel1.Controls.Add(this.btnQuanLyDoanhThu);
            this.panel1.Controls.Add(this.btnQuanLyXeKhach);
            this.panel1.Controls.Add(this.btnQuanLyNhanVien);
            this.panel1.Controls.Add(this.btnQuanLyVeXe);
            this.panel1.Controls.Add(this.btnQuanLyKhieuNai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 761);
            this.panel1.TabIndex = 2;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKhachHang.Image = global::QuanLyBenXe.Properties.Resources.customer_satisfaction;
            this.btnQuanLyKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(16, 453);
            this.btnQuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(220, 40);
            this.btnQuanLyKhachHang.TabIndex = 1;
            this.btnQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.btnQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ BẾN XE";
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
            // btnQuanLyLichTrinh
            // 
            this.btnQuanLyLichTrinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyLichTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyLichTrinh.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyLichTrinh.Image = global::QuanLyBenXe.Properties.Resources.map_travel;
            this.btnQuanLyLichTrinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLichTrinh.Location = new System.Drawing.Point(16, 402);
            this.btnQuanLyLichTrinh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuanLyLichTrinh.Name = "btnQuanLyLichTrinh";
            this.btnQuanLyLichTrinh.Size = new System.Drawing.Size(220, 40);
            this.btnQuanLyLichTrinh.TabIndex = 1;
            this.btnQuanLyLichTrinh.Text = "Quản lý lịch trình";
            this.btnQuanLyLichTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyLichTrinh.UseVisualStyleBackColor = true;
            this.btnQuanLyLichTrinh.Click += new System.EventHandler(this.btnQuanLyLichTrinh_Click);
            // 
            // btnQuanLyDoanhThu
            // 
            this.btnQuanLyDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyDoanhThu.Image = global::QuanLyBenXe.Properties.Resources.analytics;
            this.btnQuanLyDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDoanhThu.Location = new System.Drawing.Point(16, 555);
            this.btnQuanLyDoanhThu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuanLyDoanhThu.Name = "btnQuanLyDoanhThu";
            this.btnQuanLyDoanhThu.Size = new System.Drawing.Size(220, 40);
            this.btnQuanLyDoanhThu.TabIndex = 1;
            this.btnQuanLyDoanhThu.Text = "Quản lý doanh thu";
            this.btnQuanLyDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyDoanhThu.UseVisualStyleBackColor = true;
            this.btnQuanLyDoanhThu.Click += new System.EventHandler(this.btnQuanLyDoanhThu_Click);
            // 
            // btnQuanLyXeKhach
            // 
            this.btnQuanLyXeKhach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyXeKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyXeKhach.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyXeKhach.Image = global::QuanLyBenXe.Properties.Resources.bus_school;
            this.btnQuanLyXeKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyXeKhach.Location = new System.Drawing.Point(16, 351);
            this.btnQuanLyXeKhach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuanLyXeKhach.Name = "btnQuanLyXeKhach";
            this.btnQuanLyXeKhach.Size = new System.Drawing.Size(220, 40);
            this.btnQuanLyXeKhach.TabIndex = 1;
            this.btnQuanLyXeKhach.Text = "Quản lý xe khách";
            this.btnQuanLyXeKhach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyXeKhach.UseVisualStyleBackColor = true;
            this.btnQuanLyXeKhach.Click += new System.EventHandler(this.btnQuanLyXeKhach_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.Image = global::QuanLyBenXe.Properties.Resources.programmer;
            this.btnQuanLyNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(16, 249);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(220, 40);
            this.btnQuanLyNhanVien.TabIndex = 1;
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyVeXe
            // 
            this.btnQuanLyVeXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyVeXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyVeXe.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyVeXe.Image = global::QuanLyBenXe.Properties.Resources.ticket;
            this.btnQuanLyVeXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyVeXe.Location = new System.Drawing.Point(16, 300);
            this.btnQuanLyVeXe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuanLyVeXe.Name = "btnQuanLyVeXe";
            this.btnQuanLyVeXe.Size = new System.Drawing.Size(220, 40);
            this.btnQuanLyVeXe.TabIndex = 1;
            this.btnQuanLyVeXe.Text = "Quản lý vé xe";
            this.btnQuanLyVeXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyVeXe.UseVisualStyleBackColor = true;
            this.btnQuanLyVeXe.Click += new System.EventHandler(this.btnQuanLyVeXe_Click);
            // 
            // btnQuanLyKhieuNai
            // 
            this.btnQuanLyKhieuNai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKhieuNai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhieuNai.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKhieuNai.Image = global::QuanLyBenXe.Properties.Resources.complain;
            this.btnQuanLyKhieuNai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhieuNai.Location = new System.Drawing.Point(16, 504);
            this.btnQuanLyKhieuNai.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuanLyKhieuNai.Name = "btnQuanLyKhieuNai";
            this.btnQuanLyKhieuNai.Size = new System.Drawing.Size(220, 40);
            this.btnQuanLyKhieuNai.TabIndex = 1;
            this.btnQuanLyKhieuNai.Text = "Quản lý khiếu nại";
            this.btnQuanLyKhieuNai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyKhieuNai.UseVisualStyleBackColor = true;
            this.btnQuanLyKhieuNai.Click += new System.EventHandler(this.btnQuanLyKhieuNai_Click);
            // 
            // FrmTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrangChuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẾN XE XANH";
            this.Load += new System.EventHandler(this.FrmTrangChuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLyLichTrinh;
        private System.Windows.Forms.Button btnQuanLyDoanhThu;
        private System.Windows.Forms.Button btnQuanLyXeKhach;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnQuanLyVeXe;
        private System.Windows.Forms.Button btnQuanLyKhieuNai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
    }
}

