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

namespace Quản_lý_quán_bar.fAdminCF
{
    public partial class fBan : Form
    {
        BindingSource BanList = new BindingSource();
        public fBan()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            dgvwBan.DataSource = BanList;
            LoadListBan();
            AddTableBinding();
            
        }
        void LoadListBan()
        {
            BanList.DataSource = DAL_Table.Instance.GetListTable();
        }
        void AddTableBinding()
        {
            tbxMaBan.DataBindings.Add(new Binding("Text", dgvwBan.DataSource, "tableID", true, DataSourceUpdateMode.Never));
            tbxTenBan.DataBindings.Add(new Binding("Text", dgvwBan.DataSource, "tableName", true, DataSourceUpdateMode.Never));
            tbxTinhTrang.DataBindings.Add(new Binding ("Text", dgvwBan.DataSource,"Status", true, DataSourceUpdateMode.Never));
        }

        private void ibtnThemBan_Click(object sender, EventArgs e)
        {
            int n = (int)nmUDSoBan.Value;
            DAL_Table.Instance.InsertTable(n);
            LoadListBan();
        }

        private void ibtnXoaBan_Click(object sender, EventArgs e)
        {
            int n = (int)nmUDSoBan.Value;
            DAL_Table.Instance.DeleteTable(n);
            LoadListBan();
        }

        private void ibtnXemBan_Click(object sender, EventArgs e)
        {
            LoadListBan();
        }
    }
}
