using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThucUong
    {
        public DTO_ThucUong(int tUId, string tUName, int lTUId, int tUPrice)
        {
            this.TUId = tUId;
            this.TUName = tUName;
            this.LTUId = lTUId;
            this.TUPrice = tUPrice;
        }
        public DTO_ThucUong(DataRow row)
        {
            this.TUId =(int)row["tUId"];
            this.TUName = row["tUName"].ToString();
            this.LTUId = (int)row["lTUId"];
            this.TUPrice = (int)row["tUPrice"];
        }
        private int tUId;
        public int TUId
        {
            get { return tUId; }
            set { tUId = value; }
        }
        private string tUName;
        public string TUName
        {
            get { return tUName; }
            set { tUName = value; }
        }
        private int lTUId;
        public int LTUId
        {
            get { return lTUId; }
            set { lTUId = value; }
        }

        private int tUPrice;
        public int TUPrice
        {
            get { return tUPrice; }
            set { tUPrice = value; }
        }
    }
}
