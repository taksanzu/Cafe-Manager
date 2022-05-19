using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon
    {
        private static DAL_HoaDon instance;

        public static DAL_HoaDon Instance
        {
            get { if (instance == null) instance = new DAL_HoaDon(); return DAL_HoaDon.instance; }
            private set { DAL_HoaDon.instance = value; }
        }

        private DAL_HoaDon() { }
        public int GetUncheckBillIDByTableID(int hDId)
        {
            DataTable data = Dataprovider.Instance.ExecuteQuery("SELECT * " +
                "FROM HoaDon WHERE tableID = " + hDId + " AND statusBill = 0");

            if (data.Rows.Count > 0)
            {
                DTO_HoaDon bill = new DTO_HoaDon(data.Rows[0]);
                return bill.HDId;
            }

            return -1;
        }
        public void InsertBill(int hDId)
        {
            Dataprovider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { hDId });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)Dataprovider.Instance.ExecuteScalar("SELECT MAX(hDId) FROM HoaDon");
            }
            catch
            {
                return 1;
            }
        }
    }
}
