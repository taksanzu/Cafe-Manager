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
    }
}
