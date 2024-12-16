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
    public partial class FrmQuanLyVeXe : Form
    {
        public FrmQuanLyVeXe()
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

        private void FrmQuanLyVeXe_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmDatVe());
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmDatVe());
        }

        private void btnLichSuDatVe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmLichSuDatVe());
        }
    }
}
