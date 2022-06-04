using DAL;
using DTO;
using FontAwesome.Sharp;
using Quản_lý_quán_bar.fAdminCF;
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
                IconButton btn = new IconButton() { Width = DAL_Table.TableWidth, Height = DAL_Table.TableHeight };
                btn.IconChar = IconChar.Chair;
                btn.IconSize = 30;
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.Text = item.TableName +Environment.NewLine + item.Status;  
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
            //CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString(/*"c", culture*/);
        }    
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as DTO_Table).TableID;
            lsvBill.Tag = (sender as Button).Tag;
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

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            DTO_Table table = lsvBill.Tag as DTO_Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int hDId = DAL_HoaDon.Instance.GetUncheckBillIDByTableID(table.TableID);
            int tUId = (cbFood.SelectedItem as DTO_ThucUong).TUId;
            int count = (int)nmFoodCount.Value;

            if (hDId == -1)
            {
                DAL_HoaDon.Instance.InsertBill(table.TableID);
                DAL_InfoHoaDon.Instance.InsertBillInfo(DAL_HoaDon.Instance.GetMaxIDBill(), tUId, count);
            }
            else
            {
                DAL_InfoHoaDon.Instance.InsertBillInfo(hDId, tUId, count);
            }

            ShowHoaDon(table.TableID);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DTO_Table table = lsvBill.Tag as DTO_Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int hDId = DAL_HoaDon.Instance.GetUncheckBillIDByTableID(table.TableID);
            int discount = (int)nmDisCount.Value;
            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split('.')[0]);

            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (hDId != -1)
            {
                if (MessageBox.Show(String.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.TableName, totalPrice, discount, finalTotalPrice), "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DAL_HoaDon.Instance.CheckOut(hDId, discount, (float)finalTotalPrice);
                    ShowHoaDon(table.TableID);
                    LoadTable();
                }
            }
        }
        public void f_UpdateTU(object sender, EventArgs e)
        {
            LoadDrinkListByCategoryID((cbCategory.SelectedItem as DTO_LoaiThucUong).LTUId);
            if (lsvBill.Tag != null)
                ShowHoaDon((lsvBill.Tag as DTO_Table).TableID);
        }
    }
}
