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
    public partial class fTTH : Form
    {
        BindingSource HangList = new BindingSource();
        public fTTH()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            dgvwH.DataSource = HangList;
            LoadListH();
            AddHangBinding();
            LoadCategoryIntoCombobox(cbbxLoaiH);
        }
        void LoadListH()
        {
            HangList.DataSource = DAL_Hang.Instance.GetListH();

        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = DAL_LoaiHang.Instance.GetListLH();
            cb.DisplayMember = "lHName";
        }
        void AddHangBinding()
        {
            tbxMaH.DataBindings.Add(new Binding("Text", dgvwH.DataSource, "hId", true, DataSourceUpdateMode.Never));
            tbxTenH.DataBindings.Add(new Binding("Text", dgvwH.DataSource, "hName", true, DataSourceUpdateMode.Never));
            nrUDSoLuong.DataBindings.Add(new Binding("Text", dgvwH.DataSource, "hCount", true, DataSourceUpdateMode.Never));
            tbxDonVi.DataBindings.Add(new Binding("Text", dgvwH.DataSource, "hValues", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Text", dgvwH.DataSource, "hPrice", true, DataSourceUpdateMode.Never));
            dtpNgayNhap.DataBindings.Add(new Binding("Text", dgvwH.DataSource, "hDate", true, DataSourceUpdateMode.Never));

        }

        private void tbxMaH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvwH.SelectedCells.Count > 0)
                {
                    int lHId = Convert.ToInt32(dgvwH.SelectedCells[1].OwningRow.Cells["lHId"].Value);

                    DTO_LoaiHang cateogory = DAL_LoaiHang.Instance.GetLHByID(lHId);

                    cbbxLoaiH.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (DTO_LoaiHang item in cbbxLoaiH.Items)
                    {
                        if (item.LHId == cateogory.LHId)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbbxLoaiH.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void ibtnThemH_Click(object sender, EventArgs e)
        {
            string hName = tbxTenH.Text;
            int lHId = (cbbxLoaiH.SelectedItem as DTO_LoaiHang).LHId;
            int hCount = (int)nrUDSoLuong.Value;
            string hValues = tbxDonVi.Text;
            int hPrice = (int)numericUpDown1.Value;

            if (DAL_Hang.Instance.InsertHang(lHId, hName, hCount, hValues, hPrice))
            {
                MessageBox.Show("Thêm hàng thành công");
                LoadListH();
                
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm hàng");
            }
        }

        private void ibtnSuaH_Click(object sender, EventArgs e)
        {
            int hId = Convert.ToInt32(tbxMaH.Text);
            string hName = tbxTenH.Text;
            int lHId = (cbbxLoaiH.SelectedItem as DTO_LoaiHang).LHId;
            int hCount = (int)nrUDSoLuong.Value;
            string hValues = tbxDonVi.Text;
            int hPrice = (int)numericUpDown1.Value;

            if (DAL_Hang.Instance.UpdateHang(hId, lHId, hName, hCount, hValues, hPrice))
            {
                MessageBox.Show("Sửa hàng thành công");
                LoadListH();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa hàng");
            }
        }

        private void ibtnXoaH_Click(object sender, EventArgs e)
        {
            int hId = Convert.ToInt32(tbxMaH.Text);

            if (DAL_Hang.Instance.DeleteHang(hId))
            {
                MessageBox.Show("Xóa hàng thành công");
                LoadListH();

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa hàng");
            }
        }

        private void ibtnXemH_Click(object sender, EventArgs e)
        {
            LoadListH();
        }
    }
}
