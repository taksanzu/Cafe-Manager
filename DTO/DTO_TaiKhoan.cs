using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        public DTO_TaiKhoan(string userName, string displayName, int type, string passwordTK = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.PasswordTK = passwordTK;
        }

        public DTO_TaiKhoan(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["TKType"];
            this.PasswordTK = row["passwordTK"].ToString();
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        private string passwordTK;
        public string PasswordTK
        {
            get { return passwordTK; }
            set { passwordTK = value; }
        }

        
    }
}
