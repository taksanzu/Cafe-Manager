using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using DTO;
using Quản_lý_quán_bar.fAdminCF;
using Quản_lý_quán_bar.fMain;

namespace Quản_lý_quán_bar
{
    public partial class fCafeMaster : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private DTO_TaiKhoan loginAccount;

        public DTO_TaiKhoan LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        void ChangeAccount(int type)
        {
            ibtnAdmin.Visible = type == 0;
            ibtnXemBaoCao.Visible = type == 2;
            lbName.Text += " (" + LoginAccount.DisplayName + ")";
        }
        public fCafeMaster(DTO_TaiKhoan acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 53);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RBGColor
        {
            public static Color color1 = Color.FromArgb(229, 56, 59);

        }
        private void ActiveBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 180, 216);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        
        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 180, 216);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ibtnExit_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RBGColor.color1);
            DialogResult result
                = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Close();
            }
            
        }

        private void Reset()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
        }
        private void pbxLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void fPubMaster_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void ibtnMaximize_Click(object sender, EventArgs e)
        {
             if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        
        }

        private void pnlCafeMN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ibtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ibtnAdmin_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RBGColor.color1);
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ibtnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fOrder());
            ActiveBtn(sender, RBGColor.color1);
        }
    }
}
