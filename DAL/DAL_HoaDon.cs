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
        public int GetUncheckBillIDByTableID(int tableId)
        {
            DataTable data = Dataprovider.Instance.ExecuteQuery("select * from HoaDon where tableID = "+ tableId +" and statusBill = 0");

            if (data.Rows.Count > 0)
            {
                DTO_HoaDon bill = new DTO_HoaDon(data.Rows[0]);
                return bill.HDId;
            }

            return -1;
        }
        public void CheckOut(int hDId, int discount, float totalPrice)
        {
            string query = "UPDATE HoaDon SET NgayRa = getdate(), statusBill = 1, discount = "+ discount +", totalPrice = "+ totalPrice +" where hDId = " + hDId;
            Dataprovider.Instance.ExecuteNonQuery(query);
        }
        public void InsertBill(int hDId)
        {
            Dataprovider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { hDId });
        }
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return Dataprovider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkout", new object[] { checkIn, checkOut });
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
