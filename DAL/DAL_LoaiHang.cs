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
    }
}
