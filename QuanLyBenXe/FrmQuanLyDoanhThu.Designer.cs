namespace QuanLyBenXe
{
    partial class FrmQuanLyDoanhThu
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
            this.btnQuanLyLoaiVe = new System.Windows.Forms.Button();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThongKeDoanhThu);
            this.panel1.Controls.Add(this.btnQuanLyLoaiVe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 761);
            this.panel1.TabIndex = 0;
            // 
            // btnQuanLyLoaiVe
            // 
            this.btnQuanLyLoaiVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyLoaiVe.Image = global::QuanLyBenXe.Properties.Resources.ticket__2_;
            this.btnQuanLyLoaiVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLoaiVe.Location = new System.Drawing.Point(5, 55);
            this.btnQuanLyLoaiVe.Name = "btnQuanLyLoaiVe";
            this.btnQuanLyLoaiVe.Size = new System.Drawing.Size(210, 40);
            this.btnQuanLyLoaiVe.TabIndex = 1;
            this.btnQuanLyLoaiVe.Text = "Quản lý loại vé";
            this.btnQuanLyLoaiVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyLoaiVe.UseVisualStyleBackColor = true;
            this.btnQuanLyLoaiVe.Click += new System.EventHandler(this.btnQuanLyLoaiVe_Click);
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.btnThongKeDoanhThu.Image = global::QuanLyBenXe.Properties.Resources.analytics;
            this.btnThongKeDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(5, 6);
            this.btnThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(210, 40);
            this.btnThongKeDoanhThu.TabIndex = 2;
            this.btnThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.btnThongKeDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(230, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(900, 761);
            this.panelContainer.TabIndex = 1;
            // 
            // FrmQuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 761);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLyDoanhThu";
            this.Load += new System.EventHandler(this.FrmQuanLyDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanLyLoaiVe;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Panel panelContainer;
    }
}