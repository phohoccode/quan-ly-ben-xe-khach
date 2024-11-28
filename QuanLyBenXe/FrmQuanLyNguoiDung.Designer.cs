namespace QuanLyBenXe
{
    partial class FrmQuanLyNguoiDung
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnDanhSachND = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChamCong);
            this.panel1.Controls.Add(this.btnDanhSachND);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 761);
            this.panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(256, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(874, 761);
            this.panelContainer.TabIndex = 1;
            // 
            // btnChamCong
            // 
            this.btnChamCong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Image = global::QuanLyBenXe.Properties.Resources.verified_account;
            this.btnChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.Location = new System.Drawing.Point(9, 64);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(230, 44);
            this.btnChamCong.TabIndex = 1;
            this.btnChamCong.Text = "Chấm công nhân viên";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnDanhSachND
            // 
            this.btnDanhSachND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachND.Image = global::QuanLyBenXe.Properties.Resources.customer;
            this.btnDanhSachND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachND.Location = new System.Drawing.Point(9, 12);
            this.btnDanhSachND.Name = "btnDanhSachND";
            this.btnDanhSachND.Size = new System.Drawing.Size(230, 44);
            this.btnDanhSachND.TabIndex = 1;
            this.btnDanhSachND.Text = "Danh sách người dùng";
            this.btnDanhSachND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhSachND.UseVisualStyleBackColor = true;
            this.btnDanhSachND.Click += new System.EventHandler(this.btnDanhSachND_Click);
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 761);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuanLyNguoiDung";
            this.Text = "FrmQuanLyNguoiDung";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDanhSachND;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Panel panelContainer;
    }
}