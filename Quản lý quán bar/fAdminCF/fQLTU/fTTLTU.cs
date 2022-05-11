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

namespace Quản_lý_quán_bar.fAdminCF.fQLTU
{
    public partial class fTTLTU : Form
    {
        BindingSource LoaiThucUongList = new BindingSource();
        public fTTLTU()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            dgvwLTU.DataSource = LoaiThucUongList;
            LoadListLTU();
            AddLDrinkBinding();
        }
        private void ibtnThemLTU_Click(object sender, EventArgs e)
        {
            string lTUName = tbxTenLTU.Text;

            if (DAL_LoaiThucUong.Instance.InsertLDrink(lTUName))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListLTU();
                if (insertLDrink != null)
                    insertLDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }

        }
        private event EventHandler insertLDrink;
        public event EventHandler InsertLDrink
        {
            add { insertLDrink += value; }
            remove { insertLDrink -= value; }
        }
        void AddLDrinkBinding()
        {
            tbxMaLTU.DataBindings.Add(new Binding("Text", dgvwLTU.DataSource, "lTUId", true, DataSourceUpdateMode.Never));
            tbxTenLTU.DataBindings.Add(new Binding("Text", dgvwLTU.DataSource, "LTUName", true, DataSourceUpdateMode.Never));  
        }
        void LoadListLTU()
        {
            LoaiThucUongList.DataSource = DAL_LoaiThucUong.Instance.GetListLTU();
        }

        private void ibtnXemLTU_Click(object sender, EventArgs e)
        {
            LoadListLTU();
        }

        private void ibtnSuaLTU_Click(object sender, EventArgs e)
        {
            int lTUId =Convert.ToInt32(tbxMaLTU.Text);
            string lTUName = tbxTenLTU.Text;


            if (DAL_LoaiThucUong.Instance.UpdateLDrink(lTUId,lTUName))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListLTU();
                if (updateLTU != null)
                    updateLTU(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private event EventHandler updateLTU;
        public event EventHandler UpdateLTU
        {
            add { updateLTU += value; }
            remove { updateLTU -= value; }
        }
    }
}
