using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Table
    {
        public DTO_Table(int tableID, string tableName, string status)
        {
            this.TableID = tableID;
            this.TableName = tableName;
            this.Status = status;
        }
        public DTO_Table(DataRow row)
        {
            this.TableID = (int)row["tableID"];
            this.TableName = row["tableName"].ToString();
            this.Status = row["statusTB"].ToString();
        }    
        private int tableID;
        private int TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }

        private string tableName;
        private string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        private string status;
        private string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
