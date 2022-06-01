using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int tableID)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.tUName, bi.count, f.tUPrice, f.tUPrice*bi.count AS totalPrice " +
                "FROM InfoHoaDon AS bi, HoaDon AS b, ThucUong AS f " +
                "WHERE bi.hDId = b.hDId AND bi.tUID = f.tUID AND b.statusBill = 0 and b.tableID = " + tableID;
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
