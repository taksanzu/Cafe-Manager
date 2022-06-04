using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        public static DAL_TaiKhoan instance;
        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set { instance = value; }
        }
        private DAL_TaiKhoan() { }
        public DataTable GetListAccount()
        {
            return Dataprovider.Instance.ExecuteQuery("select userName, displayName, TKType from TaiKhoan");
        }
        public bool Login(string userName, string passwordTK)
        {
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(passwordTK);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";

            //foreach (byte item in hasData)
            //{
            //    hasPass += item;
            //}
            //var list = hasData.ToString();
            //list.Reverse();

            string query = "USP_Login @userName , @passWord";

            DataTable result = Dataprovider.Instance.ExecuteQuery(query, new object[] { userName, passwordTK});

            return result.Rows.Count > 0;
        }
        public DTO_TaiKhoan GetAccountByUserName(string userName)
        {
            DataTable data = Dataprovider.Instance.ExecuteQuery("Select * from TaiKhoan where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new DTO_TaiKhoan(item);
            }

            return null;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = Dataprovider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }
        public bool InsertAccount(string userName, string displayName, int TKType)
        {
            string query = string.Format("INSERT TaiKhoan (userName, passwordTK, displayName, TKType)" +
                "VALUES  ( '{0}', '1', '{1}', {2})", userName, displayName, TKType);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccountFromAdmin(string userName, string displayName, int TKType)
        {
            string query = string.Format("UPDATE TaiKhoan " +
                "SET displayName = N'{1}', TKType = {2} " +
                "WHERE userName = '{0}' ", userName, displayName, TKType);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTK(string userName)
        {
            string query = string.Format("delete from taiKhoan  WHERE userName = '{0}' ", userName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string userName)
        {
            string query = string.Format("UPDATE TaiKhoan " +
                "SET passwordTK = '1' " +
                "WHERE userName = '{0}' ", userName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool KtraTrung(string userName)
        {
           
            string sqlqrKtra =String.Format("Select count(*) from TaiKhoan where userName = '{0}'", userName);
            int KTT = (int)Dataprovider.Instance.ExecuteScalar(sqlqrKtra);
            return KTT > 0;

        }
        
    }
}
