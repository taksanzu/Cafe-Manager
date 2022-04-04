using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbxLogin.Text == "taksansy" && tbxPassword.Text == "ankhang123")
            {
                fPubMaster f = new fPubMaster();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }   
            
            else
            {
                if (tbxLogin.Text == "khanglong897979" && tbxPassword.Text == "ankhang123")
                {
                    fEmployee f = new fEmployee();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
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

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
