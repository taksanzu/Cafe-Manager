﻿namespace Quản_lý_quán_bar
{
    partial class fLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnMinimize = new FontAwesome.Sharp.IconButton();
            this.ibtExit = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập: ";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(135, 299);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(254, 27);
            this.tbxLogin.TabIndex = 1;
            this.tbxLogin.TextChanged += new System.EventHandler(this.tbxLogin_TextChanged);
            this.tbxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLogin_KeyPress);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(135, 343);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(254, 27);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(176, 416);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 33);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.AutoSize = true;
            this.cbxShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbxShowPassword.Location = new System.Drawing.Point(135, 377);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.Size = new System.Drawing.Size(66, 23);
            this.cbxShowPassword.TabIndex = 7;
            this.cbxShowPassword.Text = "Hiện";
            this.cbxShowPassword.UseVisualStyleBackColor = true;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ibtnMinimize);
            this.panel1.Controls.Add(this.ibtExit);
            this.panel1.Location = new System.Drawing.Point(321, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 45);
            this.panel1.TabIndex = 8;
            // 
            // ibtnMinimize
            // 
            this.ibtnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ibtnMinimize.FlatAppearance.BorderSize = 0;
            this.ibtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ibtnMinimize.IconColor = System.Drawing.Color.White;
            this.ibtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMinimize.IconSize = 40;
            this.ibtnMinimize.Location = new System.Drawing.Point(3, 3);
            this.ibtnMinimize.Name = "ibtnMinimize";
            this.ibtnMinimize.Size = new System.Drawing.Size(33, 45);
            this.ibtnMinimize.TabIndex = 10;
            this.ibtnMinimize.UseVisualStyleBackColor = true;
            this.ibtnMinimize.Click += new System.EventHandler(this.ibtnMinimize_Click);
            // 
            // ibtExit
            // 
            this.ibtExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ibtExit.FlatAppearance.BorderSize = 0;
            this.ibtExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtExit.IconColor = System.Drawing.Color.White;
            this.ibtExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtExit.IconSize = 40;
            this.ibtExit.Location = new System.Drawing.Point(46, 0);
            this.ibtExit.Name = "ibtExit";
            this.ibtExit.Size = new System.Drawing.Size(33, 45);
            this.ibtExit.TabIndex = 9;
            this.ibtExit.UseVisualStyleBackColor = true;
            this.ibtExit.Click += new System.EventHandler(this.ibtExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quản_lý_quán_bar.Properties.Resources.Pub__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.CancelButton = this.ibtExit;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbxShowPassword;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtExit;
        private FontAwesome.Sharp.IconButton ibtnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

