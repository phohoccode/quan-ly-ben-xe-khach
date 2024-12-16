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
    public partial class FrmQuanLyDoanhThu : Form
    {
        public FrmQuanLyDoanhThu()
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

        private void FrmQuanLyDoanhThu_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmThongKeDoanhThu());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmThongKeDoanhThu());
        }

        private void btnQuanLyLoaiVe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyLoaiVe());
        }
    }
}
