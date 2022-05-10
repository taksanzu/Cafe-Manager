using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DAL;

namespace Quản_lý_quán_bar
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbxLogin.Text;
            string passwordTK = tbxPassword.Text;
            if (Login(userName, passwordTK))
            {
                DTO_TaiKhoan loginAccount = DAL_TaiKhoan.Instance.GetAccountByUserName(userName);
                fCafeMaster f = new fCafeMaster(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        bool Login(string userName, string passwordTK)
        {
            return DAL_TaiKhoan.Instance.Login(userName, passwordTK);
        }
        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result
                = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void ibtExit_Click(object sender, EventArgs e)
        {
            DialogResult result
                = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbxLogin_TextChanged(object sender, EventArgs e)
        {
            if(tbxLogin.Text != "" && tbxPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbxPassword.Text != "" && tbxLogin.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
            tbxPassword.MaxLength = 14;
        }


        private void tbxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;

            }
            
        }

        private void ibtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
