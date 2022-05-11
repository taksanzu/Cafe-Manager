using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar.fMain
{
    public partial class fOrder : Form
    {
        public fOrder()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }
        #region Method
        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<DTO_Table> tableList = DAL_Table.Instance.LoadTableList();

            foreach (DTO_Table item in tableList)
            {
                Button btn = new Button() { Width = DAL_Table.TableWidth, Height = DAL_Table.TableHeight };
                btn.Text = item.TableName + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.WhiteSmoke;
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        void LoadCategory()
        {
            List<DTO_LoaiThucUong> listCategory = DAL_LoaiThucUong.Instance.GetListLTU();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "lTUName";
        }
        void LoadDrinkListByCategoryID(int lTUId)
        {
            List<DTO_ThucUong> listFood = DAL_ThucUong.Instance.GetDrinkByCategoryID(lTUId);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "tUName";
        }
        void ShowHoaDon(int tableID)
        {
            lsvBill.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(tableID);
            int totalPrice = 0;
            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }    
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as DTO_Table).TableID;
            ShowHoaDon(tableID);
        }
        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            DTO_LoaiThucUong selected = cb.SelectedItem as DTO_LoaiThucUong;
            id = selected.LTUId;
            LoadDrinkListByCategoryID(id);
        }
    }
}
