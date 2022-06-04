using DAL;
using DTO;
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

        private void ibtnSuaLH_Click(object sender, EventArgs e)
        {
            int lHId = Convert.ToInt32(tbxMaLH.Text);
            string lHName = tbxTenLH.Text;


            if (DAL_LoaiHang.Instance.UpdateLH(lHId, lHName))
            {
                MessageBox.Show("Sửa loại thành công");
                LoadListLH();
                if (updateLH != null)
                    updateLH(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa loại hàng");
            }
        }
        private event EventHandler updateLH;
        public event EventHandler UpdateLH
        {
            add { updateLH += value; }
            remove { updateLH -= value; }
        }
        

        private void ibtnXemLH_Click(object sender, EventArgs e)
        {
            LoadListLH();
        }

        private void ibtnXoaLH_Click(object sender, EventArgs e)
        {
            int lHId = Convert.ToInt32(tbxMaLH.Text);
            string lHName = tbxTenLH.Text;
            DialogResult result =
                MessageBox.Show("Bạn có chắc xóa loại hàng " + lHName + "? \n Nó sẽ xóa luôn những hàng thuộc danh mục này!", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (DAL_LoaiHang.Instance.DeleteLH(lHId))
                {
                    MessageBox.Show("Xóa món thành công");
                    LoadListLH();
                    if (deleteLH != null)
                        deleteLH(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thức uống");
                }
            }
        }
        private event EventHandler deleteLH;
        public event EventHandler DeleteLH
        {
            add { deleteLH += value; }
            remove { deleteLH -= value; }
        }
        List<DTO_LoaiHang> SearchLHByName(string name)
        {
            List<DTO_LoaiHang> listLH = DAL_LoaiHang.Instance.SearchLHByName(name);

            return listLH;
        }

        private void tbxSearchLH_TextChanged(object sender, EventArgs e)
        {
            LoaiHangList.DataSource = SearchLHByName(tbxSearchLH.Text);
        }
    }
}
