namespace Quản_lý_quán_bar.fAdminCF
{
    partial class fTTNV
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
            this.pnlEmployeeMN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.ibtnWatchEmployee = new FontAwesome.Sharp.IconButton();
            this.ibtnDeleteEmployee = new FontAwesome.Sharp.IconButton();
            this.ibtnFixEmployee = new FontAwesome.Sharp.IconButton();
            this.ibtnAddEmployee = new FontAwesome.Sharp.IconButton();
            this.pnlThemNV = new System.Windows.Forms.Panel();
            this.nmLuong = new System.Windows.Forms.NumericUpDown();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxCV = new System.Windows.Forms.TextBox();
            this.tbxTenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvwEmployee = new System.Windows.Forms.DataGridView();
            this.pnlEmployeeMN.SuspendLayout();
            this.pnlThemNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployeeMN
            // 
            this.pnlEmployeeMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.pnlEmployeeMN.Controls.Add(this.label1);
            this.pnlEmployeeMN.Controls.Add(this.tbxSearch);
            this.pnlEmployeeMN.Controls.Add(this.ibtnWatchEmployee);
            this.pnlEmployeeMN.Controls.Add(this.ibtnDeleteEmployee);
            this.pnlEmployeeMN.Controls.Add(this.ibtnFixEmployee);
            this.pnlEmployeeMN.Controls.Add(this.ibtnAddEmployee);
            this.pnlEmployeeMN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEmployeeMN.Location = new System.Drawing.Point(0, 651);
            this.pnlEmployeeMN.Name = "pnlEmployeeMN";
            this.pnlEmployeeMN.Size = new System.Drawing.Size(1102, 55);
            this.pnlEmployeeMN.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxSearch.Location = new System.Drawing.Point(717, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(290, 30);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // ibtnWatchEmployee
            // 
            this.ibtnWatchEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnWatchEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnWatchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnWatchEmployee.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibtnWatchEmployee.IconColor = System.Drawing.Color.Black;
            this.ibtnWatchEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnWatchEmployee.IconSize = 40;
            this.ibtnWatchEmployee.Location = new System.Drawing.Point(490, 4);
            this.ibtnWatchEmployee.Name = "ibtnWatchEmployee";
            this.ibtnWatchEmployee.Size = new System.Drawing.Size(75, 47);
            this.ibtnWatchEmployee.TabIndex = 0;
            this.ibtnWatchEmployee.UseVisualStyleBackColor = true;
            this.ibtnWatchEmployee.Click += new System.EventHandler(this.ibtnWatchEmployee_Click);
            // 
            // ibtnDeleteEmployee
            // 
            this.ibtnDeleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnDeleteEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDeleteEmployee.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnDeleteEmployee.IconColor = System.Drawing.Color.Black;
            this.ibtnDeleteEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDeleteEmployee.IconSize = 40;
            this.ibtnDeleteEmployee.Location = new System.Drawing.Point(330, 4);
            this.ibtnDeleteEmployee.Name = "ibtnDeleteEmployee";
            this.ibtnDeleteEmployee.Size = new System.Drawing.Size(75, 47);
            this.ibtnDeleteEmployee.TabIndex = 0;
            this.ibtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.ibtnDeleteEmployee.Click += new System.EventHandler(this.ibtnDeleteEmployee_Click);
            // 
            // ibtnFixEmployee
            // 
            this.ibtnFixEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnFixEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnFixEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFixEmployee.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.ibtnFixEmployee.IconColor = System.Drawing.Color.Black;
            this.ibtnFixEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFixEmployee.IconSize = 40;
            this.ibtnFixEmployee.Location = new System.Drawing.Point(170, 4);
            this.ibtnFixEmployee.Name = "ibtnFixEmployee";
            this.ibtnFixEmployee.Size = new System.Drawing.Size(75, 47);
            this.ibtnFixEmployee.TabIndex = 0;
            this.ibtnFixEmployee.UseVisualStyleBackColor = true;
            this.ibtnFixEmployee.Click += new System.EventHandler(this.ibtnFixEmployee_Click);
            // 
            // ibtnAddEmployee
            // 
            this.ibtnAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ibtnAddEmployee.IconColor = System.Drawing.Color.Black;
            this.ibtnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAddEmployee.IconSize = 40;
            this.ibtnAddEmployee.Location = new System.Drawing.Point(10, 4);
            this.ibtnAddEmployee.Name = "ibtnAddEmployee";
            this.ibtnAddEmployee.Size = new System.Drawing.Size(75, 47);
            this.ibtnAddEmployee.TabIndex = 0;
            this.ibtnAddEmployee.UseVisualStyleBackColor = true;
            this.ibtnAddEmployee.Click += new System.EventHandler(this.ibtnAddEmployee_Click);
            // 
            // pnlThemNV
            // 
            this.pnlThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.pnlThemNV.Controls.Add(this.nmLuong);
            this.pnlThemNV.Controls.Add(this.tbxSDT);
            this.pnlThemNV.Controls.Add(this.tbxEmail);
            this.pnlThemNV.Controls.Add(this.tbxCV);
            this.pnlThemNV.Controls.Add(this.tbxTenNV);
            this.pnlThemNV.Controls.Add(this.label6);
            this.pnlThemNV.Controls.Add(this.label4);
            this.pnlThemNV.Controls.Add(this.label5);
            this.pnlThemNV.Controls.Add(this.label7);
            this.pnlThemNV.Controls.Add(this.label2);
            this.pnlThemNV.Controls.Add(this.tbxMaNV);
            this.pnlThemNV.Controls.Add(this.label3);
            this.pnlThemNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlThemNV.Location = new System.Drawing.Point(0, 0);
            this.pnlThemNV.Name = "pnlThemNV";
            this.pnlThemNV.Size = new System.Drawing.Size(297, 651);
            this.pnlThemNV.TabIndex = 9;
            // 
            // nmLuong
            // 
            this.nmLuong.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmLuong.Location = new System.Drawing.Point(15, 498);
            this.nmLuong.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nmLuong.Name = "nmLuong";
            this.nmLuong.Size = new System.Drawing.Size(247, 30);
            this.nmLuong.TabIndex = 8;
            // 
            // tbxSDT
            // 
            this.tbxSDT.Location = new System.Drawing.Point(12, 377);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(250, 30);
            this.tbxSDT.TabIndex = 1;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(13, 437);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(250, 30);
            this.tbxEmail.TabIndex = 1;
            // 
            // tbxCV
            // 
            this.tbxCV.Location = new System.Drawing.Point(12, 305);
            this.tbxCV.Name = "tbxCV";
            this.tbxCV.Size = new System.Drawing.Size(250, 30);
            this.tbxCV.TabIndex = 1;
            // 
            // tbxTenNV
            // 
            this.tbxTenNV.Location = new System.Drawing.Point(12, 242);
            this.tbxTenNV.Name = "tbxTenNV";
            this.tbxTenNV.Size = new System.Drawing.Size(250, 30);
            this.tbxTenNV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên:";
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.Enabled = false;
            this.tbxMaNV.Location = new System.Drawing.Point(12, 173);
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.Size = new System.Drawing.Size(250, 30);
            this.tbxMaNV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên:";
            // 
            // dgvwEmployee
            // 
            this.dgvwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwEmployee.Location = new System.Drawing.Point(297, 0);
            this.dgvwEmployee.Name = "dgvwEmployee";
            this.dgvwEmployee.RowHeadersWidth = 51;
            this.dgvwEmployee.RowTemplate.Height = 24;
            this.dgvwEmployee.Size = new System.Drawing.Size(805, 651);
            this.dgvwEmployee.TabIndex = 10;
            // 
            // fTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 706);
            this.Controls.Add(this.dgvwEmployee);
            this.Controls.Add(this.pnlThemNV);
            this.Controls.Add(this.pnlEmployeeMN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTTNV";
            this.Text = "fTTNV";
            this.pnlEmployeeMN.ResumeLayout(false);
            this.pnlEmployeeMN.PerformLayout();
            this.pnlThemNV.ResumeLayout(false);
            this.pnlThemNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeeMN;
        private FontAwesome.Sharp.IconButton ibtnWatchEmployee;
        private FontAwesome.Sharp.IconButton ibtnDeleteEmployee;
        private FontAwesome.Sharp.IconButton ibtnFixEmployee;
        private FontAwesome.Sharp.IconButton ibtnAddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel pnlThemNV;
        public System.Windows.Forms.NumericUpDown nmLuong;
        public System.Windows.Forms.TextBox tbxSDT;
        public System.Windows.Forms.TextBox tbxEmail;
        public System.Windows.Forms.TextBox tbxCV;
        public System.Windows.Forms.TextBox tbxTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvwEmployee;
    }
}