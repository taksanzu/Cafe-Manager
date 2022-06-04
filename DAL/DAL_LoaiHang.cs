using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiHang
    {
        private static DAL_LoaiHang instance;

        public static DAL_LoaiHang Instance
        {
            get { if (instance == null) instance = new DAL_LoaiHang(); return DAL_LoaiHang.instance; }
            private set { DAL_LoaiHang.instance = value; }
        }

        private DAL_LoaiHang() { }
        public List<DTO_LoaiHang> GetListLH()
        {
            List<DTO_LoaiHang> list = new List<DTO_LoaiHang>();

            string query = "select * from LoaiHang";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_LoaiHang lH = new DTO_LoaiHang(item);
                list.Add(lH);
            }

            return list;
        }
        public DTO_LoaiHang GetLHByID(int lHId)
        {
            DTO_LoaiHang loaiHang = null;

            string query = "select * from LoaiHang where lHId = " + lHId;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                loaiHang = new DTO_LoaiHang(item);
                return loaiHang;
            }

            return loaiHang;
        }
        public bool InsertLH(string lHName)
        {
            string query = string.Format("INSERT LoaiHang ( lHName)" +
                "VALUES  ( N'{0}')", lHName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateLH(int lHId, string lHName)
        {
            string query = string.Format("UPDATE LoaiHang " +
                "SET lHName = N'{1}' WHERE lHId = {0}", lHId, lHName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteLH(int lHId)
        {
            string query = string.Format("delete from LoaiHang  WHERE lHId = {0}", lHId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<DTO_LoaiHang> SearchLHByName(string name)
        {

            List<DTO_LoaiHang> list = new List<DTO_LoaiHang>();

            string query = string.Format("SELECT * FROM LoaiHang WHERE dbo.fuConvertToUnsign1(lHName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_LoaiHang lh = new DTO_LoaiHang(item);
                list.Add(lh);
            }

            return list;
        }
    }
}
