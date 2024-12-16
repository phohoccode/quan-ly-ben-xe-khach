namespace QuanLyBenXe
{
    partial class FrmQuanLyVeXe
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
            this.btnLichSuDatVe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLichSuDatVe);
            this.panel1.Controls.Add(this.btnDatVe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 761);
            this.panel1.TabIndex = 0;
            // 
            // btnLichSuDatVe
            // 
            this.btnLichSuDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuDatVe.Image = global::QuanLyBenXe.Properties.Resources.transaction_history__1_;
            this.btnLichSuDatVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuDatVe.Location = new System.Drawing.Point(12, 71);
            this.btnLichSuDatVe.Name = "btnLichSuDatVe";
            this.btnLichSuDatVe.Size = new System.Drawing.Size(197, 40);
            this.btnLichSuDatVe.TabIndex = 1;
            this.btnLichSuDatVe.Text = "Lịch sử đặt vé";
            this.btnLichSuDatVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSuDatVe.UseVisualStyleBackColor = true;
            this.btnLichSuDatVe.Click += new System.EventHandler(this.btnLichSuDatVe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatVe.Image = global::QuanLyBenXe.Properties.Resources.ticket_flight;
            this.btnDatVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatVe.Location = new System.Drawing.Point(12, 12);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(197, 40);
            this.btnDatVe.TabIndex = 1;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(230, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(900, 761);
            this.panelContainer.TabIndex = 1;
            // 
            // FrmQuanLyVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 761);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLyVeXe";
            this.Text = "FrmQuanLyVeXe";
            this.Load += new System.EventHandler(this.FrmQuanLyVeXe_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnLichSuDatVe;
        private System.Windows.Forms.Panel panelContainer;
    }
}