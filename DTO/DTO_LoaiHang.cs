using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiHang
    {
        public DTO_LoaiHang(int lHId, string lHName)
        {
            this.LHId = lHId;
            this.LHName = lHName;
        }
        public DTO_LoaiHang(DataRow row)
        {
            this.LHId = (int)row["lHId"];
            this.LHName = row["lHName"].ToString();
        }
        private int lHId;
        public int LHId
        {
            get { return lHId; }
            set { lHId = value; }
        }
        private string lHName;
        public string LHName
        {
            get { return lHName; }
            set { lHName = value; }
        }
    }
}
