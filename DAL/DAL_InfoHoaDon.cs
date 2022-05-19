using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_InfoHoaDon
    {
        private static DAL_InfoHoaDon instance;

        public static DAL_InfoHoaDon Instance
        {
            get { if (instance == null) instance = new DAL_InfoHoaDon(); return DAL_InfoHoaDon.instance; }
            private set { DAL_InfoHoaDon.instance = value; }
        }

        private DAL_InfoHoaDon() { }
        public List<DTO_InfoHoaDon> GetListBillInfo(int id)
        {
            List<DTO_InfoHoaDon> listBillInfo = new List<DTO_InfoHoaDon>();

            DataTable data = Dataprovider.Instance.ExecuteQuery("SELECT * FROM InfoHoaDon WHERE hDId = " + id);

            foreach (DataRow item in data.Rows)
            {
                DTO_InfoHoaDon info = new DTO_InfoHoaDon(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        public void InsertBillInfo(int hDId, int tUId, int count)
        {
            Dataprovider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { hDId, tUId, count });
        }
    }
}
