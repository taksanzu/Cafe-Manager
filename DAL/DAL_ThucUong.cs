using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThucUong
    {
        private static DAL_ThucUong instance;

        public static DAL_ThucUong Instance
        {
            get { if (instance == null) instance = new DAL_ThucUong(); return DAL_ThucUong.instance; }
            private set { DAL_ThucUong.instance = value; }
        }

        private DAL_ThucUong() { }
        public List<DTO_ThucUong> GetDrinkByCategoryID(int lTUId)
        {
            List<DTO_ThucUong> list = new List<DTO_ThucUong>();

            string query = "select * from ThucUong where lTUId = " + lTUId;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_ThucUong food = new DTO_ThucUong(item);
                list.Add(food);
            }

            return list;
        }
        public List<DTO_ThucUong> GetListDrink()
        {
            List<DTO_ThucUong> list = new List<DTO_ThucUong>();

            string query = "select * from ThucUong";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_ThucUong food = new DTO_ThucUong(item);
                list.Add(food);
            }

            return list;
        }
        public bool InsertDrink(string tUName, int lTUId, int tUPrice)
        {
            string query = string.Format("INSERT ThucUong ( tUName, lTUId, tUPrice )" +
                "VALUES  ( N'{0}', {1}, {2})", tUName, lTUId, tUPrice);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateDrink(int tUId, string tUName, int lTUId, int tUPrice)
        {
            string query = string.Format("UPDATE ThucUong " +
                "SET tUName = N'{1}', lTUId = {2}, tUPrice = {3} WHERE tUId = {0}", tUId, tUName, lTUId, tUPrice);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
