namespace Quản_lý_quán_bar
{
    partial class fCafeMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.ibtnExit = new FontAwesome.Sharp.IconButton();
            this.ibtnOrder = new FontAwesome.Sharp.IconButton();
            this.ibtnAdmin = new FontAwesome.Sharp.IconButton();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCafeMN = new System.Windows.Forms.Panel();
            this.ibtnMinimize = new FontAwesome.Sharp.IconButton();
            this.ibtnMaximize = new FontAwesome.Sharp.IconButton();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.ibtnChangePassword = new FontAwesome.Sharp.IconButton();
            this.ibtnProfile = new FontAwesome.Sharp.IconButton();
            this.ibtnXemBaoCao = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlCafeMN.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.panelMenu.Controls.Add(this.pbxLogo);
            this.panelMenu.Controls.Add(this.ibtnExit);
            this.panelMenu.Controls.Add(this.ibtnXemBaoCao);
            this.panelMenu.Controls.Add(this.ibtnOrder);
            this.panelMenu.Controls.Add(this.ibtnAdmin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 684);
            this.panelMenu.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxLogo.Image = global::Quản_lý_quán_bar.Properties.Resources.Pub__1__removebg_preview;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(251, 106);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // ibtnExit
            // 
            this.ibtnExit.FlatAppearance.BorderSize = 0;
            this.ibtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExit.ForeColor = System.Drawing.Color.White;
            this.ibtnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtnExit.IconColor = System.Drawing.Color.White;
            this.ibtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnExit.Location = new System.Drawing.Point(3, 382);
            this.ibtnExit.Name = "ibtnExit";
            this.ibtnExit.Size = new System.Drawing.Size(251, 53);
            this.ibtnExit.TabIndex = 4;
            this.ibtnExit.Text = "Đăng xuất";
            this.ibtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnExit.UseVisualStyleBackColor = true;
            this.ibtnExit.Click += new System.EventHandler(this.ibtnExit_Click);
            // 
            // ibtnOrder
            // 
            this.ibtnOrder.FlatAppearance.BorderSize = 0;
            this.ibtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOrder.ForeColor = System.Drawing.Color.White;
            this.ibtnOrder.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.ibtnOrder.IconColor = System.Drawing.Color.White;
            this.ibtnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrder.Location = new System.Drawing.Point(0, 323);
            this.ibtnOrder.Name = "ibtnOrder";
            this.ibtnOrder.Size = new System.Drawing.Size(251, 53);
            this.ibtnOrder.TabIndex = 1;
            this.ibtnOrder.Text = "Order thức uống";
            this.ibtnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnOrder.UseVisualStyleBackColor = true;
            this.ibtnOrder.Click += new System.EventHandler(this.ibtnOrder_Click);
            // 
            // ibtnAdmin
            // 
            this.ibtnAdmin.FlatAppearance.BorderSize = 0;
            this.ibtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdmin.ForeColor = System.Drawing.Color.White;
            this.ibtnAdmin.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.ibtnAdmin.IconColor = System.Drawing.Color.White;
            this.ibtnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAdmin.Location = new System.Drawing.Point(0, 264);
            this.ibtnAdmin.Name = "ibtnAdmin";
            this.ibtnAdmin.Size = new System.Drawing.Size(251, 53);
            this.ibtnAdmin.TabIndex = 0;
            this.ibtnAdmin.Text = "Chủ nhà hàng";
            this.ibtnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAdmin.UseVisualStyleBackColor = true;
            this.ibtnAdmin.Click += new System.EventHandler(this.ibtnAdmin_Click);
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(860, 583);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(106, 38);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pnlCafeMN
            // 
            this.pnlCafeMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.pnlCafeMN.Controls.Add(this.ibtnMinimize);
            this.pnlCafeMN.Controls.Add(this.ibtnMaximize);
            this.pnlCafeMN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCafeMN.Location = new System.Drawing.Point(251, 0);
            this.pnlCafeMN.Name = "pnlCafeMN";
            this.pnlCafeMN.Size = new System.Drawing.Size(1010, 40);
            this.pnlCafeMN.TabIndex = 3;
            this.pnlCafeMN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCafeMN_MouseDown);
            // 
            // ibtnMinimize
            // 
            this.ibtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnMinimize.FlatAppearance.BorderSize = 0;
            this.ibtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ibtnMinimize.IconColor = System.Drawing.Color.Black;
            this.ibtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMinimize.IconSize = 35;
            this.ibtnMinimize.Location = new System.Drawing.Point(930, 0);
            this.ibtnMinimize.Name = "ibtnMinimize";
            this.ibtnMinimize.Size = new System.Drawing.Size(40, 40);
            this.ibtnMinimize.TabIndex = 1;
            this.ibtnMinimize.UseVisualStyleBackColor = true;
            this.ibtnMinimize.Click += new System.EventHandler(this.ibtnMinimize_Click);
            // 
            // ibtnMaximize
            // 
            this.ibtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnMaximize.FlatAppearance.BorderSize = 0;
            this.ibtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ibtnMaximize.IconColor = System.Drawing.Color.Black;
            this.ibtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMaximize.IconSize = 35;
            this.ibtnMaximize.Location = new System.Drawing.Point(970, 0);
            this.ibtnMaximize.Name = "ibtnMaximize";
            this.ibtnMaximize.Size = new System.Drawing.Size(40, 40);
            this.ibtnMaximize.TabIndex = 0;
            this.ibtnMaximize.UseVisualStyleBackColor = true;
            this.ibtnMaximize.Click += new System.EventHandler(this.ibtnMaximize_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.pnlChildForm.Controls.Add(this.lbName);
            this.pnlChildForm.Controls.Add(this.lbTime);
            this.pnlChildForm.Controls.Add(this.ibtnChangePassword);
            this.pnlChildForm.Controls.Add(this.ibtnProfile);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(251, 40);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1010, 644);
            this.pnlChildForm.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(127, 27);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Xin Chào: ";
            // 
            // ibtnChangePassword
            // 
            this.ibtnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnChangePassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.ibtnChangePassword.IconColor = System.Drawing.Color.White;
            this.ibtnChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnChangePassword.Location = new System.Drawing.Point(424, 378);
            this.ibtnChangePassword.Name = "ibtnChangePassword";
            this.ibtnChangePassword.Size = new System.Drawing.Size(180, 49);
            this.ibtnChangePassword.TabIndex = 3;
            this.ibtnChangePassword.Text = "Đổi mật khẩu";
            this.ibtnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnChangePassword.UseVisualStyleBackColor = true;
            // 
            // ibtnProfile
            // 
            this.ibtnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnProfile.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.ibtnProfile.IconColor = System.Drawing.Color.White;
            this.ibtnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProfile.Location = new System.Drawing.Point(424, 313);
            this.ibtnProfile.Name = "ibtnProfile";
            this.ibtnProfile.Size = new System.Drawing.Size(180, 49);
            this.ibtnProfile.TabIndex = 2;
            this.ibtnProfile.Text = "Thông tin";
            this.ibtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnProfile.UseVisualStyleBackColor = true;
            // 
            // ibtnXemBaoCao
            // 
            this.ibtnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.ibtnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.ibtnXemBaoCao.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.ibtnXemBaoCao.IconColor = System.Drawing.Color.White;
            this.ibtnXemBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXemBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXemBaoCao.Location = new System.Drawing.Point(3, 323);
            this.ibtnXemBaoCao.Name = "ibtnXemBaoCao";
            this.ibtnXemBaoCao.Size = new System.Drawing.Size(251, 53);
            this.ibtnXemBaoCao.TabIndex = 1;
            this.ibtnXemBaoCao.Text = "Xem báo cáo";
            this.ibtnXemBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // fCafeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1261, 684);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlCafeMN);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCafeMaster";
            this.Text = "fBarMaster";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fPubMaster_KeyPress);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlCafeMN.ResumeLayout(false);
            this.pnlChildForm.ResumeLayout(false);
            this.pnlChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtnAdmin;
        private System.Windows.Forms.PictureBox pbxLogo;
        private FontAwesome.Sharp.IconButton ibtnOrder;
        private FontAwesome.Sharp.IconButton ibtnExit;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlCafeMN;
        private FontAwesome.Sharp.IconButton ibtnMinimize;
        private FontAwesome.Sharp.IconButton ibtnMaximize;
        private System.Windows.Forms.Panel pnlChildForm;
        private FontAwesome.Sharp.IconButton ibtnChangePassword;
        private FontAwesome.Sharp.IconButton ibtnProfile;
        private System.Windows.Forms.Label lbName;
        private FontAwesome.Sharp.IconButton ibtnXemBaoCao;
    }
}