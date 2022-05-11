using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiThucUong
    {
        public DTO_LoaiThucUong(int lTUId, string lTUName)
        {
            this.LTUId = lTUId;
            this.LTUName = lTUName;
        }
        public DTO_LoaiThucUong(DataRow row)
        {
            this.LTUId = (int)row["lTUId"];
            this.LTUName = row["lTUName"].ToString();
        }
        private int lTUId;
        public int LTUId
        {
            get { return lTUId; }
            set { lTUId = value; }
        }
        private string lTUName;
        public string LTUName
        {
            get { return lTUName; }
            set { lTUName = value; }
        }
    }
}
