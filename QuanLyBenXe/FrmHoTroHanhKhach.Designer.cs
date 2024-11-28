namespace QuanLyBenXe
{
    partial class FrmHoTroHanhKhach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKhieuNai = new System.Windows.Forms.Button();
            this.btnThongTinLienHe = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnKhieuNai);
            this.panel1.Controls.Add(this.btnThongTinLienHe);
            this.panel1.Controls.Add(this.btnHuongDan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 758);
            this.panel1.TabIndex = 3;
            // 
            // btnKhieuNai
            // 
            this.btnKhieuNai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhieuNai.Image = global::QuanLyBenXe.Properties.Resources.bad;
            this.btnKhieuNai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhieuNai.Location = new System.Drawing.Point(10, 120);
            this.btnKhieuNai.Name = "btnKhieuNai";
            this.btnKhieuNai.Size = new System.Drawing.Size(200, 42);
            this.btnKhieuNai.TabIndex = 1;
            this.btnKhieuNai.Text = "Gửi khiếu nại";
            this.btnKhieuNai.UseVisualStyleBackColor = true;
            this.btnKhieuNai.Click += new System.EventHandler(this.btnKhieuNai_Click);
            // 
            // btnThongTinLienHe
            // 
            this.btnThongTinLienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinLienHe.Image = global::QuanLyBenXe.Properties.Resources.telephone;
            this.btnThongTinLienHe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinLienHe.Location = new System.Drawing.Point(10, 12);
            this.btnThongTinLienHe.Name = "btnThongTinLienHe";
            this.btnThongTinLienHe.Size = new System.Drawing.Size(200, 42);
            this.btnThongTinLienHe.TabIndex = 1;
            this.btnThongTinLienHe.Text = "Thông tin liên hệ";
            this.btnThongTinLienHe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTinLienHe.UseVisualStyleBackColor = true;
            this.btnThongTinLienHe.Click += new System.EventHandler(this.btnThongTinLienHe_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuongDan.Image = global::QuanLyBenXe.Properties.Resources.user_guide__1_;
            this.btnHuongDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuongDan.Location = new System.Drawing.Point(10, 66);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(200, 42);
            this.btnHuongDan.TabIndex = 1;
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(226, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(904, 758);
            this.panelContainer.TabIndex = 4;
            // 
            // FrmHoTroHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHoTroHanhKhach";
            this.Text = "FrmHoTroHanhKhach";
            this.Load += new System.EventHandler(this.FrmHoTroHanhKhach_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKhieuNai;
        private System.Windows.Forms.Button btnThongTinLienHe;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Panel panelContainer;
    }
}