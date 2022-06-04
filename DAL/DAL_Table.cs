using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Table
    {
        private static DAL_Table instance;
        public static DAL_Table Instance
        {
            get { if (instance == null) instance = new DAL_Table(); return DAL_Table.instance; }
            private set { DAL_Table.instance = value; }
        }
        private DAL_Table(){}
        public static int TableWidth = 90;
        public static int TableHeight = 90;
        public List<DTO_Table> LoadTableList()
        {
            List<DTO_Table> tablelist = new List<DTO_Table>();
            DataTable data = Dataprovider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                DTO_Table table = new DTO_Table(item);
                tablelist.Add(table);
            }    
            return tablelist;
        }
        public void InsertTable(int N)
        {
            Dataprovider.Instance.ExecuteNonQuery("exec USP_InsertTable @n", new object[] { N });
        }
        public void DeleteTable(int N)
        {
            Dataprovider.Instance.ExecuteNonQuery("exec USP_DeleteTable @n", new object[] { N });
        }
        public List<DTO_Table> GetListTable()
        {
            List<DTO_Table> list = new List<DTO_Table>();

            string query = "select * from Ban";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_Table ban = new DTO_Table(item);
                list.Add(ban);
            }

            return list;
        }
    }
}
