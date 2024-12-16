namespace QuanLyBenXe
{
    partial class FrmDatVeKhachHang
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
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiVe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDiemXuatPhat = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDiemDen = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvChuyenXe = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenXe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.cbLoaiVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoaiVe.FormattingEnabled = true;
            this.cbLoaiVe.Location = new System.Drawing.Point(34, 134);
            this.cbLoaiVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiVe.Name = "cbLoaiVe";
            this.cbLoaiVe.Size = new System.Drawing.Size(214, 29);
            this.cbLoaiVe.TabIndex = 49;
            this.cbLoaiVe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiVe_SelectedIndexChanged);
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
            // cbDiemXuatPhat
            // 
            this.cbDiemXuatPhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiemXuatPhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDiemXuatPhat.FormattingEnabled = true;
            this.cbDiemXuatPhat.Location = new System.Drawing.Point(35, 68);
            this.cbDiemXuatPhat.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiemXuatPhat.Name = "cbDiemXuatPhat";
            this.cbDiemXuatPhat.Size = new System.Drawing.Size(214, 29);
            this.cbDiemXuatPhat.TabIndex = 39;
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
            this.label15.Text = "Điểm xuất phát";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = global::QuanLyBenXe.Properties.Resources.loupe;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(674, 39);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 40);
            this.btnTimKiem.TabIndex = 47;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label14.Size = new System.Drawing.Size(82, 21);
            this.label14.TabIndex = 41;
            this.label14.Text = "Điểm đến";
            // 
            // cbDiemDen
            // 
            this.cbDiemDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiemDen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDiemDen.FormattingEnabled = true;
            this.cbDiemDen.Location = new System.Drawing.Point(334, 68);
            this.cbDiemDen.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(214, 29);
            this.cbDiemDen.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtGiaVe);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbLoaiVe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbDiemXuatPhat);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbDiemDen);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(876, 193);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm chuyến xe";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Image = global::QuanLyBenXe.Properties.Resources.refresh__1_;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(674, 105);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(118, 40);
            this.btnLamMoi.TabIndex = 47;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvChuyenXe
            // 
            this.dgvChuyenXe.AllowUserToAddRows = false;
            this.dgvChuyenXe.AllowUserToDeleteRows = false;
            this.dgvChuyenXe.AllowUserToResizeColumns = false;
            this.dgvChuyenXe.AllowUserToResizeRows = false;
            this.dgvChuyenXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvChuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuyenXe.Location = new System.Drawing.Point(3, 21);
            this.dgvChuyenXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChuyenXe.Name = "dgvChuyenXe";
            this.dgvChuyenXe.ReadOnly = true;
            this.dgvChuyenXe.RowHeadersWidth = 62;
            this.dgvChuyenXe.RowTemplate.Height = 28;
            this.dgvChuyenXe.Size = new System.Drawing.Size(1100, 431);
            this.dgvChuyenXe.TabIndex = 48;
            this.dgvChuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenXe_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dgvChuyenXe);
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1106, 454);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách chuyến xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 35);
            this.label1.TabIndex = 67;
            this.label1.Text = "DANH SÁCH CÁC CHUYẾN XE HÔM NAY";
            // 
            // FrmDatVeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 769);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDatVeKhachHang";
            this.Text = "FrmDatVeKhachHang";
            this.Load += new System.EventHandler(this.FrmDatVeKhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenXe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDiemXuatPhat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbDiemDen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChuyenXe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
    }
}