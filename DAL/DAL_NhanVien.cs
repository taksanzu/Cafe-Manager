using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        private static DAL_NhanVien instance;
        public static DAL_NhanVien Instance
        {
            get { if (instance == null) instance = new DAL_NhanVien(); return DAL_NhanVien.instance; }
            private set { DAL_NhanVien.instance = value; }
        }
        private DAL_NhanVien(){}
        public List<DTO_NhanVien> GetListNV()
        {
            List<DTO_NhanVien> list = new List<DTO_NhanVien>();

            string query = "select * from NhanVien";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_NhanVien nv = new DTO_NhanVien(item);
                list.Add(nv);
            }

            return list;
        }
        public bool InsertNV(string nVName, string nVChucVu, string nVSDT, string nVEmail, int nVLuong)
        {
            string query = string.Format("INSERT NhanVien ( nVName, nVChucVu, nVSDT, nVEmail, nVLuong)" +
                "VALUES  ( N'{0}', N'{1}',N'{2}',N'{3}', {4} )", nVName, nVChucVu, nVSDT, nVEmail, nVLuong);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateNV(int nVId, string nVName, string nVChucVu, string nVSDT, string nVEmail, int nVLuong)
        {
            string query = string.Format("UPDATE NhanVien " +
                "SET nVName = N'{1}', nVChucVu = N'{2}', nVSDT = N'{3}', nVEmail = N'{4}', nVLuong = {5} " +
                "WHERE nVId = {0}", nVId, nVName, nVChucVu, nVSDT, nVEmail, nVLuong);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteNV(int nVId)
        {
            string query = string.Format("delete from NhanVien  WHERE nVId = {0}", nVId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<DTO_NhanVien> SearchNVByName(string name)
        {

            List<DTO_NhanVien> list = new List<DTO_NhanVien>();

            string query = string.Format("SELECT * FROM NhanVien WHERE dbo.fuConvertToUnsign1(nVName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_NhanVien nv = new DTO_NhanVien(item);
                list.Add(nv);
            }

            return list;
        }

    }
}
