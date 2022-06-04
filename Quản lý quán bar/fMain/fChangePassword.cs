using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar.fMain
{
    public partial class fChangePassword : Form
    {
        private DTO_TaiKhoan loginAccount;

        public DTO_TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fChangePassword(DTO_TaiKhoan acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(DTO_TaiKhoan acc)
        {
            tbxUserName.Text = LoginAccount.UserName;
            tbxDisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccount()
        {
            string userName = tbxUserName.Text;
            string displayName = tbxDisplayName.Text;
            string OldPassword = tbxOldPassword.Text;
            string NewPassword = tbxNewPassword.Text;
            string ReNewPassword = tbxRepeatNewPassword.Text;
            if(NewPassword != ReNewPassword)
            {
                MessageBox.Show("Vui lòng nhập lại đúng với mật khẩu mới!", "Thông báo", MessageBoxButtons.OK);
            }    
            else 
            {
                if (DAL_TaiKhoan.Instance.UpdateAccount(userName, displayName, OldPassword, NewPassword))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu");
                }
            }    
        }

        
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void cbxHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHienThiMatKhau.Checked)
            {
                tbxOldPassword.UseSystemPasswordChar = false;
                tbxNewPassword.UseSystemPasswordChar = false;
                tbxRepeatNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxOldPassword.UseSystemPasswordChar = true;
                tbxNewPassword.UseSystemPasswordChar = true;
                tbxRepeatNewPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
