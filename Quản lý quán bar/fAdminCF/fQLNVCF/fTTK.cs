using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar.fAdminCF
{
    public partial class fTTK : Form
    {
        BindingSource TaiKhoanList = new BindingSource();
        private DTO_TaiKhoan loginAccount;
        public DTO_TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fTTK(DTO_TaiKhoan acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadData();
        }
        
        void LoadData()
        {
            dgvwTK.DataSource = TaiKhoanList;
            LoadListAccount();
            AddAccountBinding();
        }
        void LoadListAccount()
        {
            TaiKhoanList.DataSource = DAL_TaiKhoan.Instance.GetListAccount();
        }
        void AddAccountBinding()
        {
            tbxUserName.DataBindings.Add(new Binding("Text", dgvwTK.DataSource, "userName", true, DataSourceUpdateMode.Never));
            tbxTenHT.DataBindings.Add(new Binding("Text", dgvwTK.DataSource, "displayName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dgvwTK.DataSource, "TKType", true, DataSourceUpdateMode.Never));
        }

        private void dgvwTK_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvwTK.SelectedCells.Count > 0)
            {
                tbxUserName.Enabled = false;
            }
            else
            {
                tbxUserName.Enabled = true;
            }
        }

        private void ibtnXemTK_Click(object sender, EventArgs e)
        {
            LoadListAccount();
            dgvwTK.ClearSelection();
        }

        private void ibtnThemTK_Click(object sender, EventArgs e)
        {
            string userName = tbxUserName.Text;
            string displayName = tbxTenHT.Text;
            int Type = (int)numericUpDown1.Value;

            if(DAL_TaiKhoan.Instance.KtraTrung(userName))
            {
                MessageBox.Show("Trùng tài khoản!");
                    
            }    
            else
            {
                if (DAL_TaiKhoan.Instance.InsertAccount(userName, displayName, Type))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    LoadListAccount();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm tài khoản");
                }
            }    
        }

        private void ibtnSuaTK_Click(object sender, EventArgs e)
        {
            string userName = tbxUserName.Text;
            string displayName = tbxTenHT.Text;
            int Type = (int)numericUpDown1.Value;

            if (DAL_TaiKhoan.Instance.UpdateAccountFromAdmin(userName, displayName, Type))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản");
            }
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (DAL_TaiKhoan.Instance.DeleteTK(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadListAccount();
        }
        private void ibtnXoaTK_Click(object sender, EventArgs e)
        {
            string userName = tbxUserName.Text;

            DeleteAccount(userName);
        }

        private void btnRSPass_Click(object sender, EventArgs e)
        {
            string userName = tbxUserName.Text;

            if (DAL_TaiKhoan.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản");
            }
        }
    }
}
