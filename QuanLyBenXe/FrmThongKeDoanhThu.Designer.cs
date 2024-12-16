namespace QuanLyBenXe
{
    partial class FrmThongKeDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeDoanhThu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelCustom = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.rdbTuyChinh = new System.Windows.Forms.RadioButton();
            this.rdbTatCa = new System.Windows.Forms.RadioButton();
            this.rdbHienTai = new System.Windows.Forms.RadioButton();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTongdoanhThu = new System.Windows.Forms.Label();
            this.btnInThongKe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelCustom);
            this.groupBox1.Controls.Add(this.rdbTuyChinh);
            this.groupBox1.Controls.Add(this.rdbTatCa);
            this.groupBox1.Controls.Add(this.rdbHienTai);
            this.groupBox1.Location = new System.Drawing.Point(611, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 282);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị dữ liệu thống kê";
            // 
            // panelCustom
            // 
            this.panelCustom.Controls.Add(this.btnLamMoi);
            this.panelCustom.Controls.Add(this.btnLoc);
            this.panelCustom.Controls.Add(this.time);
            this.panelCustom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCustom.Location = new System.Drawing.Point(3, 133);
            this.panelCustom.Name = "panelCustom";
            this.panelCustom.Size = new System.Drawing.Size(271, 146);
            this.panelCustom.TabIndex = 9;
            this.panelCustom.Visible = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Image = global::QuanLyBenXe.Properties.Resources.refresh__1_;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(128, 77);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(107, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Đặt lại";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Image = global::QuanLyBenXe.Properties.Resources.filter__1_;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(35, 77);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 40);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time.Location = new System.Drawing.Point(35, 29);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 26);
            this.time.TabIndex = 7;
            // 
            // rdbTuyChinh
            // 
            this.rdbTuyChinh.AutoSize = true;
            this.rdbTuyChinh.Location = new System.Drawing.Point(21, 102);
            this.rdbTuyChinh.Name = "rdbTuyChinh";
            this.rdbTuyChinh.Size = new System.Drawing.Size(118, 25);
            this.rdbTuyChinh.TabIndex = 8;
            this.rdbTuyChinh.Text = "Tuỳ chỉnh ";
            this.rdbTuyChinh.UseVisualStyleBackColor = true;
            this.rdbTuyChinh.CheckedChanged += new System.EventHandler(this.rdbTuyChinh_CheckedChanged);
            // 
            // rdbTatCa
            // 
            this.rdbTatCa.AutoSize = true;
            this.rdbTatCa.Location = new System.Drawing.Point(21, 71);
            this.rdbTatCa.Name = "rdbTatCa";
            this.rdbTatCa.Size = new System.Drawing.Size(91, 25);
            this.rdbTatCa.TabIndex = 8;
            this.rdbTatCa.Text = "Tất cả ";
            this.rdbTatCa.UseVisualStyleBackColor = true;
            this.rdbTatCa.CheckedChanged += new System.EventHandler(this.rdbTatCa_CheckedChanged);
            // 
            // rdbHienTai
            // 
            this.rdbHienTai.AutoSize = true;
            this.rdbHienTai.Checked = true;
            this.rdbHienTai.Location = new System.Drawing.Point(21, 40);
            this.rdbHienTai.Name = "rdbHienTai";
            this.rdbHienTai.Size = new System.Drawing.Size(91, 25);
            this.rdbHienTai.TabIndex = 8;
            this.rdbHienTai.TabStop = true;
            this.rdbHienTai.Text = "Hôm nay";
            this.rdbHienTai.UseVisualStyleBackColor = true;
            this.rdbHienTai.CheckedChanged += new System.EventHandler(this.rdbHienTai_CheckedChanged);
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(4, 378);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.Size = new System.Drawing.Size(591, 337);
            this.dgvDoanhThu.TabIndex = 4;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(4, 12);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số vé đã bán";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tổng tiền theo loại vé";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(884, 347);
            this.chartDoanhThu.TabIndex = 7;
            this.chartDoanhThu.Text = "chart1";
            // 
            // lblTongdoanhThu
            // 
            this.lblTongdoanhThu.AutoSize = true;
            this.lblTongdoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.lblTongdoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTongdoanhThu.Location = new System.Drawing.Point(0, 718);
            this.lblTongdoanhThu.Name = "lblTongdoanhThu";
            this.lblTongdoanhThu.Size = new System.Drawing.Size(136, 21);
            this.lblTongdoanhThu.TabIndex = 8;
            this.lblTongdoanhThu.Text = "Tổng doanh thu";
            // 
            // btnInThongKe
            // 
            this.btnInThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInThongKe.Image = global::QuanLyBenXe.Properties.Resources.printer__1_;
            this.btnInThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInThongKe.Location = new System.Drawing.Point(639, 663);
            this.btnInThongKe.Name = "btnInThongKe";
            this.btnInThongKe.Size = new System.Drawing.Size(200, 40);
            this.btnInThongKe.TabIndex = 6;
            this.btnInThongKe.Text = "In thống kê";
            this.btnInThongKe.UseVisualStyleBackColor = true;
            this.btnInThongKe.Click += new System.EventHandler(this.btnInThongKe_Click);
            // 
            // FrmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 761);
            this.Controls.Add(this.lblTongdoanhThu);
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.btnInThongKe);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmThongKeDoanhThu";
            this.Text = "FrmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.FrmThongKeDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCustom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Button btnInThongKe;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.RadioButton rdbTuyChinh;
        private System.Windows.Forms.RadioButton rdbTatCa;
        private System.Windows.Forms.RadioButton rdbHienTai;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label lblTongdoanhThu;
    }
}