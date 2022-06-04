namespace Quản_lý_quán_bar.fMain
{
    partial class fChangePassword
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
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxOldPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDisplayName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.cbxHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Enabled = false;
            this.tbxUserName.Location = new System.Drawing.Point(71, 92);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(274, 27);
            this.tbxUserName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // tbxOldPassword
            // 
            this.tbxOldPassword.Location = new System.Drawing.Point(71, 219);
            this.tbxOldPassword.Name = "tbxOldPassword";
            this.tbxOldPassword.Size = new System.Drawing.Size(274, 27);
            this.tbxOldPassword.TabIndex = 2;
            this.tbxOldPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(71, 284);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(274, 27);
            this.tbxNewPassword.TabIndex = 3;
            this.tbxNewPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(234, 371);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(111, 55);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Đặt lại mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên hiển thị:";
            // 
            // tbxDisplayName
            // 
            this.tbxDisplayName.Location = new System.Drawing.Point(71, 154);
            this.tbxDisplayName.Name = "tbxDisplayName";
            this.tbxDisplayName.Size = new System.Drawing.Size(274, 27);
            this.tbxDisplayName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập lại mật khẩu mới:";
            // 
            // tbxRepeatNewPassword
            // 
            this.tbxRepeatNewPassword.Location = new System.Drawing.Point(71, 338);
            this.tbxRepeatNewPassword.Name = "tbxRepeatNewPassword";
            this.tbxRepeatNewPassword.Size = new System.Drawing.Size(274, 27);
            this.tbxRepeatNewPassword.TabIndex = 4;
            this.tbxRepeatNewPassword.UseSystemPasswordChar = true;
            // 
            // cbxHienThiMatKhau
            // 
            this.cbxHienThiMatKhau.AutoSize = true;
            this.cbxHienThiMatKhau.Location = new System.Drawing.Point(71, 371);
            this.cbxHienThiMatKhau.Name = "cbxHienThiMatKhau";
            this.cbxHienThiMatKhau.Size = new System.Drawing.Size(66, 23);
            this.cbxHienThiMatKhau.TabIndex = 6;
            this.cbxHienThiMatKhau.Text = "Hiện";
            this.cbxHienThiMatKhau.UseVisualStyleBackColor = true;
            this.cbxHienThiMatKhau.CheckedChanged += new System.EventHandler(this.cbxHienThiMatKhau_CheckedChanged);
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 461);
            this.Controls.Add(this.cbxHienThiMatKhau);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbxRepeatNewPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxOldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDisplayName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxOldPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDisplayName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRepeatNewPassword;
        private System.Windows.Forms.CheckBox cbxHienThiMatKhau;
    }
}