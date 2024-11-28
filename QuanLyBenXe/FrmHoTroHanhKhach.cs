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
    public partial class FrmHoTroHanhKhach : Form
    {
        public FrmHoTroHanhKhach()
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

        private void btnThongTinLienHe_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmThongTinLienHe());
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmHuongDan());
        }

        private void btnKhieuNai_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmKhieuNai());
        }

        private void FrmHoTroHanhKhach_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmThongTinLienHe());

        }
    }
}
