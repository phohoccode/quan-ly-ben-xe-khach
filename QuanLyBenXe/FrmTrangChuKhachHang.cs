using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmTrangChuKhachHang : Form
    {
        public FrmTrangChuKhachHang()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form formToShow)
        {
            panelContainer.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void FrmTrangChuKhachHang_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Xin chào! " + FrmDangNhap.username;
            ShowFormInPanel(new FrmDatVeKhachHang());

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmDatVeKhachHang());
        }

      

        private void btnHoTroKhachHang_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmHoTroHanhKhach());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Close();
        }

        private void btnLichSuDatVe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmLichSuDatVeKhachHang());
        }
    }
}
