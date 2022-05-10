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
    }
}
