namespace QuanLyBenXe
{
    partial class FrmQuanLyLichTrinh
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
            this.btn_RP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.cbx_maxe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tuyenduong = new System.Windows.Forms.TextBox();
            this.txt_dd = new System.Windows.Forms.TextBox();
            this.txt_dxp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_trangthai = new System.Windows.Forms.ComboBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpk_ngay = new System.Windows.Forms.DateTimePicker();
            this.dtpk_gio = new System.Windows.Forms.DateTimePicker();
            this.txt_malichtrinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_RP
            // 
            this.btn_RP.Image = global::QuanLyBenXe.Properties.Resources.printer__1_;
            this.btn_RP.Location = new System.Drawing.Point(1021, 90);
            this.btn_RP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RP.Name = "btn_RP";
            this.btn_RP.Size = new System.Drawing.Size(97, 45);
            this.btn_RP.TabIndex = 69;
            this.btn_RP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RP.UseVisualStyleBackColor = true;
            this.btn_RP.Click += new System.EventHandler(this.btn_RP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 62;
            this.label10.Text = "Điểm Đến:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::QuanLyBenXe.Properties.Resources.delete__1_;
            this.btn_xoa.Location = new System.Drawing.Point(882, 18);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 42);
            this.btn_xoa.TabIndex = 58;
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Image = global::QuanLyBenXe.Properties.Resources.loupe;
            this.btn_tim.Location = new System.Drawing.Point(628, 8);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(66, 40);
            this.btn_tim.TabIndex = 13;
            this.btn_tim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tim);
            this.groupBox2.Controls.Add(this.btn_tim);
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(211, 201);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(725, 48);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập từ khóa";
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(18, 21);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(602, 23);
            this.txt_tim.TabIndex = 3;
            // 
            // cbx_maxe
            // 
            this.cbx_maxe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_maxe.FormattingEnabled = true;
            this.cbx_maxe.Location = new System.Drawing.Point(215, 58);
            this.cbx_maxe.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_maxe.Name = "cbx_maxe";
            this.cbx_maxe.Size = new System.Drawing.Size(173, 29);
            this.cbx_maxe.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tuyến Đường:";
            // 
            // txt_tuyenduong
            // 
            this.txt_tuyenduong.Location = new System.Drawing.Point(660, 94);
            this.txt_tuyenduong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tuyenduong.Name = "txt_tuyenduong";
            this.txt_tuyenduong.Size = new System.Drawing.Size(178, 26);
            this.txt_tuyenduong.TabIndex = 65;
            // 
            // txt_dd
            // 
            this.txt_dd.Location = new System.Drawing.Point(211, 132);
            this.txt_dd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dd.Name = "txt_dd";
            this.txt_dd.Size = new System.Drawing.Size(178, 26);
            this.txt_dd.TabIndex = 64;
            // 
            // txt_dxp
            // 
            this.txt_dxp.Location = new System.Drawing.Point(215, 94);
            this.txt_dxp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dxp.Name = "txt_dxp";
            this.txt_dxp.Size = new System.Drawing.Size(173, 26);
            this.txt_dxp.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 21);
            this.label9.TabIndex = 61;
            this.label9.Text = "Điểm Xuất Phát:";
            // 
            // cbx_trangthai
            // 
            this.cbx_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_trangthai.FormattingEnabled = true;
            this.cbx_trangthai.Location = new System.Drawing.Point(660, 127);
            this.cbx_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_trangthai.Name = "cbx_trangthai";
            this.cbx_trangthai.Size = new System.Drawing.Size(178, 29);
            this.cbx_trangthai.TabIndex = 60;
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::QuanLyBenXe.Properties.Resources.write;
            this.btn_sua.Location = new System.Drawing.Point(1021, 16);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 46);
            this.btn_sua.TabIndex = 57;
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::QuanLyBenXe.Properties.Resources.add__1_;
            this.btn_them.Location = new System.Drawing.Point(885, 89);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 46);
            this.btn_them.TabIndex = 56;
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 59;
            this.label8.Text = "Mã Xe:";
            // 
            // dtpk_ngay
            // 
            this.dtpk_ngay.CustomFormat = "dd/MM/yyyy";
            this.dtpk_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ngay.Location = new System.Drawing.Point(660, 55);
            this.dtpk_ngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_ngay.Name = "dtpk_ngay";
            this.dtpk_ngay.Size = new System.Drawing.Size(178, 26);
            this.dtpk_ngay.TabIndex = 54;
            // 
            // dtpk_gio
            // 
            this.dtpk_gio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpk_gio.Location = new System.Drawing.Point(660, 22);
            this.dtpk_gio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_gio.Name = "dtpk_gio";
            this.dtpk_gio.Size = new System.Drawing.Size(178, 26);
            this.dtpk_gio.TabIndex = 53;
            this.dtpk_gio.Value = new System.DateTime(2024, 12, 2, 7, 24, 0, 0);
            // 
            // txt_malichtrinh
            // 
            this.txt_malichtrinh.Enabled = false;
            this.txt_malichtrinh.Location = new System.Drawing.Point(215, 22);
            this.txt_malichtrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_malichtrinh.Name = "txt_malichtrinh";
            this.txt_malichtrinh.Size = new System.Drawing.Size(173, 26);
            this.txt_malichtrinh.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Mã Lịch Trình:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Trạng Thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Giờ Khởi Hành:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 21);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1100, 433);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1106, 456);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lịch Trình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày Khởi Hành:";
            // 
            // FrmQuanLyLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 761);
            this.Controls.Add(this.btn_RP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbx_maxe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tuyenduong);
            this.Controls.Add(this.txt_dd);
            this.Controls.Add(this.txt_dxp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_trangthai);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpk_ngay);
            this.Controls.Add(this.dtpk_gio);
            this.Controls.Add(this.txt_malichtrinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLyLichTrinh";
            this.Text = "FrmQuanLyLichTrinh";
            this.Load += new System.EventHandler(this.FrmQuanLyLichTrinh_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.ComboBox cbx_maxe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tuyenduong;
        private System.Windows.Forms.TextBox txt_dd;
        private System.Windows.Forms.TextBox txt_dxp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_trangthai;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpk_ngay;
        private System.Windows.Forms.DateTimePicker dtpk_gio;
        private System.Windows.Forms.TextBox txt_malichtrinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}