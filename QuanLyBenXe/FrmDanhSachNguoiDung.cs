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
    public partial class FrmDanhSachNguoiDung : Form
    {
        public FrmDanhSachNguoiDung()
        {
            InitializeComponent();
        }

        private void rdbNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            panelNhanVien.Visible = true;
        }

        private void rdbKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            panelNhanVien.Visible = false;
        }
    }
}
