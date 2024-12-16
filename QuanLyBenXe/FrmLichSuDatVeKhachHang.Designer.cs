namespace QuanLyBenXe
{
    partial class FrmLichSuDatVeKhachHang
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
            this.dgvLichSuDatVe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuDatVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuDatVe
            // 
            this.dgvLichSuDatVe.AllowUserToAddRows = false;
            this.dgvLichSuDatVe.AllowUserToDeleteRows = false;
            this.dgvLichSuDatVe.AllowUserToResizeColumns = false;
            this.dgvLichSuDatVe.AllowUserToResizeRows = false;
            this.dgvLichSuDatVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuDatVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuDatVe.Location = new System.Drawing.Point(12, 103);
            this.dgvLichSuDatVe.Name = "dgvLichSuDatVe";
            this.dgvLichSuDatVe.Size = new System.Drawing.Size(1106, 654);
            this.dgvLichSuDatVe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(356, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH SỬ ĐẶT VÉ CỦA BẠN";
            // 
            // FrmLichSuDatVeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 769);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLichSuDatVe);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLichSuDatVeKhachHang";
            this.Text = "FrmLichSuDatVeKhachHang";
            this.Load += new System.EventHandler(this.FrmLichSuDatVeKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuDatVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuDatVe;
        private System.Windows.Forms.Label label1;
    }
}