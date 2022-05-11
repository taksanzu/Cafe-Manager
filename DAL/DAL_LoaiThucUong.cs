using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiThucUong
    {
        private static DAL_LoaiThucUong instance;

        public static DAL_LoaiThucUong Instance
        {
            get { if (instance == null) instance = new DAL_LoaiThucUong(); return DAL_LoaiThucUong.instance; }
            private set { DAL_LoaiThucUong.instance = value; }
        }

        private DAL_LoaiThucUong() { }
        public List<DTO_LoaiThucUong> GetListLTU()
        {
            List<DTO_LoaiThucUong> list = new List<DTO_LoaiThucUong>();

            string query = "select * from LoaiThucUong";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_LoaiThucUong ltu = new DTO_LoaiThucUong(item);
                list.Add(ltu);
            }

            return list;
        }
        public DTO_LoaiThucUong GetCategoryByID(int lTUId)
        {
            DTO_LoaiThucUong loaiThucUong = null;

            string query = "select * from LoaiThucUong where lTUId = " + lTUId;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                loaiThucUong = new DTO_LoaiThucUong(item);
                return loaiThucUong;
            }

            return loaiThucUong;
        }
        public bool InsertLDrink(string lTUName)
        {
            string query = string.Format("INSERT LoaiThucUong ( lTUName)" +
                "VALUES  ( N'{0}')", lTUName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateLDrink(int lTUId, string lTUName)
        {
            string query = string.Format("UPDATE LoaiThucUong " +
                "SET lTUName = N'{1}' WHERE lTUId = {0}", lTUId,lTUName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
