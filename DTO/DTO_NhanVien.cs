using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public DTO_NhanVien(int nVId, string nVName, string nVChucVu, string nVSDT, string nVEmail, int nVLuong)
        {
            this.NVId = nVId;
            this.NVName = nVName;
            this.NVChucVu = nVChucVu;
            this.NVSDT = nVSDT;
            this.NVEmail = nVEmail;
            this.NVLuong = nVLuong;
        }
        public DTO_NhanVien(DataRow row)
        {
            this.NVId = (int)row["nVId"];
            this.NVName = row["nVName"].ToString();
            this.NVChucVu = row["nVChucVu"].ToString();
            this.NVSDT = row["nVSDT"].ToString();
            this.NVEmail = row["nVEmail"].ToString();
            this.NVLuong = (int)row["nVLuong"];
        }
        private int nVId;
        public int NVId
        {
            get { return nVId; }
            set { nVId = value; }
        }
        private string nVName;
        public string NVName
        {
            get { return nVName; }
            set { nVName = value; }
        }
        private string nVChucVu;
        public string NVChucVu
        {
            get { return nVChucVu; }
            set { nVChucVu = value;}
        }
        private string nVSDT;
        public string NVSDT
        {
            get { return nVSDT; }
            set { nVSDT = value; }
        }
        private string nVEmail;
        public string NVEmail
        {
            get { return nVEmail; }
            set { nVEmail = value; }
        }
        private int nVLuong;
        public int NVLuong
        {
            get { return nVLuong; }
            set { nVLuong = value; }
        }

    }
}
