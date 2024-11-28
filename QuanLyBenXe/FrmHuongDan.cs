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
    public partial class FrmHuongDan : Form
    {
        public FrmHuongDan()
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

        private void FrmHuongDan_Load(object sender, EventArgs e)
        {
            cbLoaiHuongDan.SelectedIndex = 0;
            ShowFormInPanel(new FrmHuongDanDatVe());
        }

        private void cbLoaiHuongDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiHuongDan.SelectedIndex == 0)
            {
                ShowFormInPanel(new FrmHuongDanDatVe());
            }
            else if (cbLoaiHuongDan.SelectedIndex == 1)
            {
                ShowFormInPanel(new FrmQuyTrinhKhieuNai());
            }
        }
    }
}
