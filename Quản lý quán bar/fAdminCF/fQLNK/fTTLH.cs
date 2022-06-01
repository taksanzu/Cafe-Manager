using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar.fAdminCF.fQLNK
{
    public partial class fTTLH : Form
    {
        BindingSource LoaiHangList = new BindingSource();
        public fTTLH()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            dgvwLH.DataSource = LoaiHangList;
            LoadListLH();
            AddLHBinding();
        }
        void LoadListLH()
        {
            LoaiHangList.DataSource = DAL_LoaiHang.Instance.GetListLH();
        }
        void AddLHBinding()
        {
            tbxMaLH.DataBindings.Add(new Binding("Text", dgvwLH.DataSource, "lHId", true, DataSourceUpdateMode.Never));
            tbxTenLH.DataBindings.Add(new Binding("Text", dgvwLH.DataSource, "lHName", true, DataSourceUpdateMode.Never));
        }
    }
}
