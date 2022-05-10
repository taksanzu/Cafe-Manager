using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar.fAdminCF
{
    public partial class fTTNV : Form
    {
        public fTTNV()
        {
            InitializeComponent();
        }

        private void ibtnAddEmployee_Click(object sender, EventArgs e)
        {
            fTSXTTNV f = new fTSXTTNV();
            f.btnThem.Visible = true;
            f.btnSua.Visible = false;
            f.ShowDialog();

        }

        private void ibtnFixEmployee_Click(object sender, EventArgs e)
        {
            fTSXTTNV f = new fTSXTTNV();
            f.btnThem.Visible = false;
            f.btnSua.Visible = true;
            f.tbxMaNV.Enabled = false;
            f.ShowDialog();
        }

        private void ibtnWatchEmployee_Click(object sender, EventArgs e)
        {
            fTSXTTNV f = new fTSXTTNV();
            f.btnThem.Visible = false;
            f.btnSua.Visible = false;
            f.tbxMaNV.Enabled = false;
            f.tbxTenNV.Enabled = false;
            f.cbbxGioiTinh.Enabled = false;
            f.dtpNgaySinh.Enabled = false;
            f.tbxEmail.Enabled = false;
            f.tbxMoTa.Enabled = false;
            f.ShowDialog();
        }
    }
}
