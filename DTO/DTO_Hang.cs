using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Hang
    {
        public DTO_Hang(int hId, int lHId, string hName, int hCount, string hValues, int hPrice, DateTime hDate)
        {
            this.HId = hId;
            this.LHId = lHId;
            this.HName = hName;
            this.HCount = hCount;
            this.HValues = hValues;
            this.HPrice = hPrice;
            this.HDate = hDate;
        }
        public DTO_Hang(DataRow row)
        {
            this.HId = (int)row["hId"];
            this.LHId = (int)row["lHId"];
            this.HName = row["hName"].ToString();
            this.HCount = (int)row["hCount"];
            this.HValues = row["hValues"].ToString();
            this.HPrice = (int)row["hPrice"];
            this.HDate = (DateTime?)row["hDate"];
        }
        private int hId;
        public int HId
        {
            get { return hId; }
            set { hId = value; }
        }
        private int lHId;
        public int LHId
        {
            get { return lHId; }
            set { lHId = value; }
        }
        private string hName;
        public string HName
        {
            get { return hName; }
            set { hName = value; }
        }
        private int hCount;
        public int HCount
        {
            get { return hCount; }
            set { hCount = value; }
        }
        private string hValues;
        public string HValues
        {
            get { return hValues; }
            set { hValues = value; }
        }
        private int hPrice;
        public int HPrice
        {
            get { return hPrice; }
            set { hPrice = value; }
        }
        private DateTime? hDate;
        public DateTime? HDate
        {
            get { return hDate; }
            set { hDate = value; }
        }

    }
}
