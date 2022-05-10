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
            this.dgvwEmployee = new System.Windows.Forms.DataGridView();
            this.pnlEmployeeMN.SuspendLayout();
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
            this.pnlEmployeeMN.Location = new System.Drawing.Point(0, 652);
            this.pnlEmployeeMN.Name = "pnlEmployeeMN";
            this.pnlEmployeeMN.Size = new System.Drawing.Size(1102, 54);
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
            // dgvwEmployee
            // 
            this.dgvwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvwEmployee.Name = "dgvwEmployee";
            this.dgvwEmployee.RowHeadersWidth = 51;
            this.dgvwEmployee.RowTemplate.Height = 24;
            this.dgvwEmployee.Size = new System.Drawing.Size(1102, 706);
            this.dgvwEmployee.TabIndex = 7;
            // 
            // fTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 706);
            this.Controls.Add(this.pnlEmployeeMN);
            this.Controls.Add(this.dgvwEmployee);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTTNV";
            this.Text = "fTTNV";
            this.pnlEmployeeMN.ResumeLayout(false);
            this.pnlEmployeeMN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeeMN;
        private FontAwesome.Sharp.IconButton ibtnWatchEmployee;
        private FontAwesome.Sharp.IconButton ibtnDeleteEmployee;
        private FontAwesome.Sharp.IconButton ibtnFixEmployee;
        private FontAwesome.Sharp.IconButton ibtnAddEmployee;
        private System.Windows.Forms.DataGridView dgvwEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}