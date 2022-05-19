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

namespace Quản_lý_quán_bar.fAdminCF
{
    public partial class fTTTU : Form
    {
        BindingSource ThucUongList = new BindingSource();
        public fTTTU()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            dgvwTU.DataSource = ThucUongList;
            LoadListDrink();
            LoadCategoryIntoCombobox(cbbxLoaiTU);
            AddDrinkBinding();
           
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = DAL_LoaiThucUong.Instance.GetListLTU();
            cb.DisplayMember = "lTUName";
        }
        void AddDrinkBinding()
        {
            tbxMaTU.DataBindings.Add(new Binding("Text", dgvwTU.DataSource, "tUId", true, DataSourceUpdateMode.Never));
            tbxTenTU.DataBindings.Add(new Binding("Text", dgvwTU.DataSource, "tUName", true, DataSourceUpdateMode.Never));
            nrUDDonGiaTU.DataBindings.Add(new Binding("Text", dgvwTU.DataSource, "tUPrice", true, DataSourceUpdateMode.Never));
        }
        void LoadListDrink()
        {
            ThucUongList.DataSource = DAL_ThucUong.Instance.GetListDrink();
            
        }

        private void tbxMaTU_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvwTU.SelectedCells.Count > 0)
                {
                    int lTUId = Convert.ToInt32(dgvwTU.SelectedCells[0].OwningRow.Cells["lTUId"].Value);

                    DTO_LoaiThucUong cateogory = DAL_LoaiThucUong.Instance.GetCategoryByID(lTUId);

                    cbbxLoaiTU.SelectedItem = cateogory;

                    int index = 0;
                    int i = 0;
                    foreach (DTO_LoaiThucUong item in cbbxLoaiTU.Items)
                    {
                        if (item.LTUId == cateogory.LTUId)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbbxLoaiTU.SelectedIndex = index;
                }
            }
            catch { }
            
            
        }

        private void ibtnThemTU_Click(object sender, EventArgs e)
        {
            string tUName = tbxTenTU.Text;
            int lTUId = (cbbxLoaiTU.SelectedItem as DTO_LoaiThucUong).LTUId;
            int tUPrice = (int)nrUDDonGiaTU.Value;

            if (DAL_ThucUong.Instance.InsertDrink(tUName, lTUId, tUPrice))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListDrink();
                if (insertDrink != null)
                    insertDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private event EventHandler insertDrink;
        public event EventHandler InsertDrink
        {
            add { insertDrink += value; }
            remove { insertDrink -= value; }
        }

        private void ibtnSuaTU_Click(object sender, EventArgs e)
        {

            int tUId = Convert.ToInt32(tbxMaTU.Text);
            string tUName = tbxTenTU.Text;
            int lTUId = Convert.ToInt32(cbbxLoaiTU.SelectedIndex);
            int tUPrice = (int) nrUDDonGiaTU.Value;


            if (DAL_ThucUong.Instance.UpdateDrink(tUId, tUName, lTUId, tUPrice))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListDrink();
                if (updateTU != null)
                    updateTU(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private event EventHandler updateTU;
        public event EventHandler UpdateTU
        {
            add { updateTU += value; }
            remove { updateTU -= value; }
        }
    }
}
