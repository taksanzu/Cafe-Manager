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

namespace Quản_lý_quán_bar.fMain.fReportCF
{
    public partial class fMenu : Form
    {
        BindingSource ThucUongList = new BindingSource();
        public fMenu()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            dgvwMenu.DataSource = ThucUongList;
            LoadListDrink();
           

        }
        void LoadListDrink()
        {
            ThucUongList.DataSource = DAL_ThucUong.Instance.GetListDrink();

        }
        List<DTO_ThucUong> SearchDrinkByName(string name)
        {
            List<DTO_ThucUong> listdrink = DAL_ThucUong.Instance.SearchDrinkByName(name);

            return listdrink;
        }

        private void tbxSearchMN_TextChanged(object sender, EventArgs e)
        {
            ThucUongList.DataSource = SearchDrinkByName(tbxSearchMN.Text);
        }
    }
}
