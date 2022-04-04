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
        private struct RBGColor
        {
            public static Color color1 = Color.FromArgb(249, 65, 68);
            
        }
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
        private void ActiveBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(52, 58, 64);
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
                currentBtn.BackColor = Color.FromArgb(52, 58, 60);
                currentBtn.ForeColor = Color.FromArgb(248, 249, 250);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(248, 249, 250);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ibtnQLMA_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RBGColor.color1);
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
            Reset();
        }
    }
}
