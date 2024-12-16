using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class FrmQuanLyNhanVien : Form
    {
        public FrmQuanLyNhanVien()
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

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmNhanVien());
        }

        private void btnDsKhachHang_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyKhachHang());
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmChamCongNhanVien());
        }

        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmNhanVien());

          
        }
    }
}
