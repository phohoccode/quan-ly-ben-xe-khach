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
    public partial class FrmQuanLyNguoiDung : Form
    {
        public FrmQuanLyNguoiDung()
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



        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmDanhSachNguoiDung());    
        }

        private void btnDanhSachND_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmDanhSachNguoiDung());
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmChamCongNhanVien());
        }
    }
}
