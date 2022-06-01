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
    }
}
