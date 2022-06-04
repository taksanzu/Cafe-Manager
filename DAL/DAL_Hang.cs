using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Hang
    {
        private static DAL_Hang instance;

        public static DAL_Hang Instance
        {
            get { if (instance == null) instance = new DAL_Hang(); return DAL_Hang.instance; }
            private set { DAL_Hang.instance = value; }
        }

        private DAL_Hang() { }
        public List<DTO_Hang> GetListH()
        {
            List<DTO_Hang> list = new List<DTO_Hang>();

            string query = "select * from Hang";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_Hang H = new DTO_Hang(item);
                list.Add(H);
            }

            return list;
        }
        public List<DTO_Hang> GetHByCategoryID(int lHId)
        {
            List<DTO_Hang> list = new List<DTO_Hang>();

            string query = "select * from Hang where lHId = " + lHId;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_Hang h = new DTO_Hang(item);
                list.Add(h);
            }

            return list;
        }
        public bool InsertHang(int lHId, string hName, int hCount, string hValues, int hPrice)
        {
            string query = string.Format("INSERT Hang (lHId, hName, hCount, hValues, hPrice, hDate)" +
                "VALUES  ( {0}, N'{1}', {2}, N'{3}', {4}, getdate())", lHId, hName, hCount, hValues, hPrice);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateHang(int hId, int lHId, string hName, int hCount, string hValues, int hPrice)
        {
            string query = string.Format("update Hang " +
                "set lHId = {0}, hName =  N'{1}', hCount = {2}, hValues = N'{3}', hPrice = {4} " +
                "where hId = {5} ", lHId, hName, hCount, hValues, hPrice, hId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHang(int hId)
        {
            string query = string.Format("delete from Hang " +
                "WHERE hId = {0}", hId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<DTO_Hang> SearchHangByName(string name)
        {

            List<DTO_Hang> list = new List<DTO_Hang>();

            string query = string.Format("SELECT * FROM Hang WHERE dbo.fuConvertToUnsign1(hName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_Hang hang = new DTO_Hang(item);
                list.Add(hang);
            }

            return list;
        }
    }
}
