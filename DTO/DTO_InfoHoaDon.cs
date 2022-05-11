using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_InfoHoaDon
    {
        public DTO_InfoHoaDon(int id, int hDId, int tUID, int count)
        {
            this.ID = id;
            this.HDId = hDId;
            this.tUID = tUID;
            this.count = count;
        }
        public DTO_InfoHoaDon(DataRow row)
        {
            this.ID = (int)row["id"];
            this.HDId = (int)row["hDId"];
            this.TUID = (int)row["tUID"];
            this.Count =(int)row["count"];
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int hDId;
        public int HDId
        {
            get { return hDId; }
            set { hDId = value; }
        }
        private int tUID;
        public int TUID
        {
            get { return tUID; }
            set { tUID = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
