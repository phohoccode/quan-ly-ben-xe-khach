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
    public partial class FrmTrangChuAdmin : Form
    {
        public FrmTrangChuAdmin()
        {
            InitializeComponent();
        }

        private void FrmTrangChuAdmin_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Xin chào! " + FrmDangNhap.username;
            ShowFormInPanel(new FrmQuanLyNguoiDung());


        }

        private void ShowFormInPanel(Form formToShow)
        {
            panelContainer.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void btnHoTroHanhKhach_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmHoTroHanhKhach());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmThongKeDoanhThu());
        }

        private void btnQuanLyKhieuNai_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyKhieuNai());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyNguoiDung());
        }
    }
}
