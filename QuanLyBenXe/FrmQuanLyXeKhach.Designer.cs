namespace QuanLyBenXe
{
    partial class FrmQuanLyXeKhach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbx_loaixe = new System.Windows.Forms.ComboBox();
            this.cbx_trangthai = new System.Windows.Forms.ComboBox();
            this.txt_maxe = new System.Windows.Forms.TextBox();
            this.dgv_tim = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtpk_ngay = new System.Windows.Forms.DateTimePicker();
            this.txt_socho = new System.Windows.Forms.TextBox();
            this.txt_nhaxe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bienso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_RP
            // 
            this.btn_RP.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RP.Location = new System.Drawing.Point(954, 115);
            this.btn_RP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RP.Name = "btn_RP";
            this.btn_RP.Size = new System.Drawing.Size(94, 51);
            this.btn_RP.TabIndex = 69;
            this.btn_RP.Text = "IN";
            this.btn_RP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RP.UseVisualStyleBackColor = true;
            this.btn_RP.Click += new System.EventHandler(this.btn_RP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1106, 359);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Xe:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(5, 26);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1095, 329);
            this.dgv.TabIndex = 40;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // cbx_loaixe
            // 
            this.cbx_loaixe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_loaixe.FormattingEnabled = true;
            this.cbx_loaixe.Location = new System.Drawing.Point(128, 109);
            this.cbx_loaixe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_loaixe.Name = "cbx_loaixe";
            this.cbx_loaixe.Size = new System.Drawing.Size(161, 29);
            this.cbx_loaixe.TabIndex = 67;
            // 
            // cbx_trangthai
            // 
            this.cbx_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_trangthai.FormattingEnabled = true;
            this.cbx_trangthai.Location = new System.Drawing.Point(497, 107);
            this.cbx_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_trangthai.Name = "cbx_trangthai";
            this.cbx_trangthai.Size = new System.Drawing.Size(160, 29);
            this.cbx_trangthai.TabIndex = 66;
            // 
            // txt_maxe
            // 
            this.txt_maxe.Enabled = false;
            this.txt_maxe.Location = new System.Drawing.Point(128, 25);
            this.txt_maxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maxe.Name = "txt_maxe";
            this.txt_maxe.Size = new System.Drawing.Size(161, 26);
            this.txt_maxe.TabIndex = 65;
            // 
            // dgv_tim
            // 
            this.dgv_tim.AllowUserToAddRows = false;
            this.dgv_tim.AllowUserToDeleteRows = false;
            this.dgv_tim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tim.Location = new System.Drawing.Point(296, 565);
            this.dgv_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_tim.Name = "dgv_tim";
            this.dgv_tim.ReadOnly = true;
            this.dgv_tim.RowHeadersWidth = 62;
            this.dgv_tim.RowTemplate.Height = 28;
            this.dgv_tim.Size = new System.Drawing.Size(816, 185);
            this.dgv_tim.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.txt_tim);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 565);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(244, 185);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm:";
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(68, 122);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(101, 34);
            this.btn_tim.TabIndex = 20;
            this.btn_tim.Text = "TÌM";
            this.btn_tim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(15, 70);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(211, 26);
            this.txt_tim.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nhập Nhà Xe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 64;
            this.label9.Text = "Mã Xe:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(954, 61);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 50);
            this.btn_xoa.TabIndex = 61;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(825, 115);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 51);
            this.btn_sua.TabIndex = 60;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(825, 59);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 51);
            this.btn_them.TabIndex = 59;
            this.btn_them.Text = "THÊM";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtpk_ngay
            // 
            this.dtpk_ngay.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_ngay.CustomFormat = "dd/MM/yyyy";
            this.dtpk_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ngay.Location = new System.Drawing.Point(901, 25);
            this.dtpk_ngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_ngay.Name = "dtpk_ngay";
            this.dtpk_ngay.Size = new System.Drawing.Size(161, 26);
            this.dtpk_ngay.TabIndex = 58;
            // 
            // txt_socho
            // 
            this.txt_socho.Location = new System.Drawing.Point(496, 65);
            this.txt_socho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_socho.Name = "txt_socho";
            this.txt_socho.Size = new System.Drawing.Size(161, 26);
            this.txt_socho.TabIndex = 57;
            // 
            // txt_nhaxe
            // 
            this.txt_nhaxe.Location = new System.Drawing.Point(128, 65);
            this.txt_nhaxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nhaxe.Name = "txt_nhaxe";
            this.txt_nhaxe.Size = new System.Drawing.Size(161, 26);
            this.txt_nhaxe.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Trạng Thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số Chỗ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Biển Số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Loại Xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên Nhà Xe:";
            // 
            // txt_bienso
            // 
            this.txt_bienso.Location = new System.Drawing.Point(496, 24);
            this.txt_bienso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bienso.Name = "txt_bienso";
            this.txt_bienso.Size = new System.Drawing.Size(161, 26);
            this.txt_bienso.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(761, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 54;
            this.label6.Text = "Ngày Tạo:";
            // 
            // FrmQuanLyXeKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 761);
            this.Controls.Add(this.btn_RP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbx_loaixe);
            this.Controls.Add(this.cbx_trangthai);
            this.Controls.Add(this.txt_maxe);
            this.Controls.Add(this.dgv_tim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtpk_ngay);
            this.Controls.Add(this.txt_socho);
            this.Controls.Add(this.txt_nhaxe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bienso);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLyXeKhach";
            this.Text = "FrmQuanLyLichTrinh";
            this.Load += new System.EventHandler(this.FrmQuanLyXeKhach_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbx_loaixe;
        private System.Windows.Forms.ComboBox cbx_trangthai;
        private System.Windows.Forms.TextBox txt_maxe;
        private System.Windows.Forms.DataGridView dgv_tim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dtpk_ngay;
        private System.Windows.Forms.TextBox txt_socho;
        private System.Windows.Forms.TextBox txt_nhaxe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bienso;
        private System.Windows.Forms.Label label6;
    }
}