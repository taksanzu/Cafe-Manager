using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        public DTO_HoaDon(int hDId, DateTime? ngayVao, DateTime? ngayRa, int statusBill, int discount = 0)
        {
            this.HDId = hDId;
            this.NgayVao = ngayVao;
            this.NgayRa = ngayRa;
            this.StatusBill = statusBill;
            this.Discount = discount;
        }
        public DTO_HoaDon(DataRow row)
        {
            this.HDId = (int)row["hDId"];
            this.NgayVao = (DateTime?)row["NgayVao"];
            var dateCheckOutTemp = row["NgayRa"];
            if (dateCheckOutTemp.ToString() != "")
                this.NgayRa = (DateTime?)dateCheckOutTemp;

            this.StatusBill = (int)row["statusBill"];

            if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }
        private int hDId;
        public int HDId
        {
            get { return hDId; }
            set { hDId = value; }
        }
        private DateTime? ngayVao;
        public DateTime? NgayVao
        {
            get { return ngayVao; }
            set { ngayVao = value; }
        }
        private DateTime? ngayRa;
        public DateTime? NgayRa
        {
            get { return ngayRa; }
            set { ngayRa = value; }
        }
        private int statusBill;
        public int StatusBill
        {
            get { return statusBill; }
            set { statusBill = value; }
        }
        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
    }
}
