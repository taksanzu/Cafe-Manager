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

namespace Quản_lý_quán_bar
{
    public partial class fPubMaster : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        
        public fPubMaster()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RBGColor
        {
            public static Color color1 = Color.FromArgb(6, 214, 160);

        }
        private void ActiveBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255,107,107);
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
                currentBtn.BackColor = Color.FromArgb(255,107,110);
                currentBtn.ForeColor = Color.FromArgb(248, 249, 250);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(248, 249, 250);
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
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void ibtnQLMA_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RBGColor.color1);
            OpenChildForm(new cfFoodControl());
        }

        private void ibtnQLNV_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RBGColor.color1);
        }

        private void ibtnQLLL_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RBGColor.color1);
        }

        private void ibtnQLTK_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RBGColor.color1);
        }

        private void ibtnXBC_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RBGColor.color1);
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
        private void pnChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void fPubMaster_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
