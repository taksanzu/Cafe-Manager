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
    public partial class fTTNV : Form
    {
        BindingSource NhanVienList = new BindingSource();

        public fTTNV()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvwEmployee.DataSource = NhanVienList;
            AddNVBinding();
            LoadListNV();
        }
        void LoadListNV()
        {
            NhanVienList.DataSource = DAL_NhanVien.Instance.GetListNV();
        }
        void AddNVBinding()
        {
            tbxMaNV.DataBindings.Add(new Binding("Text", dgvwEmployee.DataSource, "nVId", true, DataSourceUpdateMode.Never));
            tbxTenNV.DataBindings.Add(new Binding("Text", dgvwEmployee.DataSource, "nVName", true, DataSourceUpdateMode.Never));
            tbxCV.DataBindings.Add(new Binding("Text", dgvwEmployee.DataSource, "nVChucVu", true, DataSourceUpdateMode.Never));
            tbxSDT.DataBindings.Add(new Binding("Text", dgvwEmployee.DataSource, "nVSDT", true, DataSourceUpdateMode.Never));
            tbxEmail.DataBindings.Add(new Binding("Text", dgvwEmployee.DataSource, "nVEmail", true, DataSourceUpdateMode.Never));
            nmLuong.DataBindings.Add(new Binding("Value", dgvwEmployee.DataSource, "nVLuong", true, DataSourceUpdateMode.Never));
        }
        private void ibtnAddEmployee_Click(object sender, EventArgs e)
        {
            string nVName = tbxTenNV.Text;
            string nVChucVu = tbxCV.Text;
            string nVSDT = tbxSDT.Text;
            string nVEmail = tbxEmail.Text;
            int nVLuong = (int)nmLuong.Value;

            if (DAL_NhanVien.Instance.InsertNV(nVName, nVChucVu, nVSDT, nVEmail, nVLuong))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                LoadListNV();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên");
            }
        }

        private void ibtnFixEmployee_Click(object sender, EventArgs e)
        {
            int nVId = Convert.ToInt32(tbxMaNV.Text);
            string nVName = tbxTenNV.Text;
            string nVChucVu = tbxCV.Text;
            string nVSDT = tbxSDT.Text;
            string nVEmail = tbxEmail.Text;
            int nVLuong = (int)nmLuong.Value;

            if (DAL_NhanVien.Instance.UpdateNV(nVId, nVName, nVChucVu, nVSDT, nVEmail, nVLuong))
            {
                MessageBox.Show("Sửa nhân viên thành công");
                LoadListNV();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhân viên");
            }
        }

        private void ibtnWatchEmployee_Click(object sender, EventArgs e)
        { 
            
            LoadListNV();
        }

        private void ibtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int nVId = Convert.ToInt32(tbxMaNV.Text);
            

            if (DAL_NhanVien.Instance.DeleteNV(nVId))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                LoadListNV();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa nhân viên");
            }
        }
        List<DTO_NhanVien> SearchNVByName(string name)
        {
            List<DTO_NhanVien> listNV = DAL_NhanVien.Instance.SearchNVByName(name);

            return listNV;
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            NhanVienList.DataSource = SearchNVByName(tbxSearch.Text);
        }
    }
}
