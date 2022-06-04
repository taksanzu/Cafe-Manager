namespace Quản_lý_quán_bar.fAdminCF
{
    partial class fBan
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
            this.pnlBanMN = new System.Windows.Forms.Panel();
            this.ibtnXemBan = new FontAwesome.Sharp.IconButton();
            this.ibtnXoaBan = new FontAwesome.Sharp.IconButton();
            this.ibtnThemBan = new FontAwesome.Sharp.IconButton();
            this.dgvwBan = new System.Windows.Forms.DataGridView();
            this.pnlBan = new System.Windows.Forms.Panel();
            this.tbxSearchBan = new System.Windows.Forms.TextBox();
            this.tbxTenBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTinhTrang = new System.Windows.Forms.TextBox();
            this.nmUDSoBan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lTUId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBanMN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBan)).BeginInit();
            this.pnlBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDSoBan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanMN
            // 
            this.pnlBanMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.pnlBanMN.Controls.Add(this.ibtnXemBan);
            this.pnlBanMN.Controls.Add(this.ibtnXoaBan);
            this.pnlBanMN.Controls.Add(this.ibtnThemBan);
            this.pnlBanMN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBanMN.Location = new System.Drawing.Point(340, 653);
            this.pnlBanMN.Name = "pnlBanMN";
            this.pnlBanMN.Size = new System.Drawing.Size(762, 54);
            this.pnlBanMN.TabIndex = 20;
            // 
            // ibtnXemBan
            // 
            this.ibtnXemBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnXemBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnXemBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXemBan.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibtnXemBan.IconColor = System.Drawing.Color.Black;
            this.ibtnXemBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXemBan.IconSize = 40;
            this.ibtnXemBan.Location = new System.Drawing.Point(480, 4);
            this.ibtnXemBan.Name = "ibtnXemBan";
            this.ibtnXemBan.Size = new System.Drawing.Size(75, 47);
            this.ibtnXemBan.TabIndex = 0;
            this.ibtnXemBan.UseVisualStyleBackColor = true;
            this.ibtnXemBan.Click += new System.EventHandler(this.ibtnXemBan_Click);
            // 
            // ibtnXoaBan
            // 
            this.ibtnXoaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnXoaBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnXoaBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXoaBan.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnXoaBan.IconColor = System.Drawing.Color.Black;
            this.ibtnXoaBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoaBan.IconSize = 40;
            this.ibtnXoaBan.Location = new System.Drawing.Point(313, 4);
            this.ibtnXoaBan.Name = "ibtnXoaBan";
            this.ibtnXoaBan.Size = new System.Drawing.Size(75, 47);
            this.ibtnXoaBan.TabIndex = 0;
            this.ibtnXoaBan.UseVisualStyleBackColor = true;
            this.ibtnXoaBan.Click += new System.EventHandler(this.ibtnXoaBan_Click);
            // 
            // ibtnThemBan
            // 
            this.ibtnThemBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnThemBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnThemBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThemBan.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ibtnThemBan.IconColor = System.Drawing.Color.Black;
            this.ibtnThemBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThemBan.IconSize = 40;
            this.ibtnThemBan.Location = new System.Drawing.Point(165, 3);
            this.ibtnThemBan.Name = "ibtnThemBan";
            this.ibtnThemBan.Size = new System.Drawing.Size(75, 47);
            this.ibtnThemBan.TabIndex = 0;
            this.ibtnThemBan.UseVisualStyleBackColor = true;
            this.ibtnThemBan.Click += new System.EventHandler(this.ibtnThemBan_Click);
            // 
            // dgvwBan
            // 
            this.dgvwBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lTUId,
            this.lTUName,
            this.TinhTrang});
            this.dgvwBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwBan.Location = new System.Drawing.Point(340, 0);
            this.dgvwBan.Name = "dgvwBan";
            this.dgvwBan.RowHeadersWidth = 51;
            this.dgvwBan.RowTemplate.Height = 24;
            this.dgvwBan.Size = new System.Drawing.Size(762, 707);
            this.dgvwBan.TabIndex = 19;
            // 
            // pnlBan
            // 
            this.pnlBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.pnlBan.Controls.Add(this.nmUDSoBan);
            this.pnlBan.Controls.Add(this.tbxSearchBan);
            this.pnlBan.Controls.Add(this.tbxTinhTrang);
            this.pnlBan.Controls.Add(this.label5);
            this.pnlBan.Controls.Add(this.label3);
            this.pnlBan.Controls.Add(this.tbxTenBan);
            this.pnlBan.Controls.Add(this.label2);
            this.pnlBan.Controls.Add(this.tbxMaBan);
            this.pnlBan.Controls.Add(this.label4);
            this.pnlBan.Controls.Add(this.label1);
            this.pnlBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBan.Location = new System.Drawing.Point(0, 0);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(340, 707);
            this.pnlBan.TabIndex = 18;
            // 
            // tbxSearchBan
            // 
            this.tbxSearchBan.Location = new System.Drawing.Point(23, 39);
            this.tbxSearchBan.Name = "tbxSearchBan";
            this.tbxSearchBan.Size = new System.Drawing.Size(250, 27);
            this.tbxSearchBan.TabIndex = 3;
            // 
            // tbxTenBan
            // 
            this.tbxTenBan.Enabled = false;
            this.tbxTenBan.Location = new System.Drawing.Point(23, 311);
            this.tbxTenBan.Name = "tbxTenBan";
            this.tbxTenBan.Size = new System.Drawing.Size(250, 27);
            this.tbxTenBan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Bàn:";
            // 
            // tbxMaBan
            // 
            this.tbxMaBan.Enabled = false;
            this.tbxMaBan.Location = new System.Drawing.Point(24, 247);
            this.tbxMaBan.Name = "tbxMaBan";
            this.tbxMaBan.Size = new System.Drawing.Size(250, 27);
            this.tbxMaBan.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bàn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình trạng:";
            // 
            // tbxTinhTrang
            // 
            this.tbxTinhTrang.Enabled = false;
            this.tbxTinhTrang.Location = new System.Drawing.Point(24, 378);
            this.tbxTinhTrang.Name = "tbxTinhTrang";
            this.tbxTinhTrang.Size = new System.Drawing.Size(250, 27);
            this.tbxTinhTrang.TabIndex = 1;
            // 
            // nmUDSoBan
            // 
            this.nmUDSoBan.Location = new System.Drawing.Point(25, 444);
            this.nmUDSoBan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmUDSoBan.Name = "nmUDSoBan";
            this.nmUDSoBan.Size = new System.Drawing.Size(249, 27);
            this.nmUDSoBan.TabIndex = 21;
            this.nmUDSoBan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số bàn:";
            // 
            // lTUId
            // 
            this.lTUId.DataPropertyName = "tableID";
            this.lTUId.HeaderText = "Mã bàn";
            this.lTUId.MinimumWidth = 6;
            this.lTUId.Name = "lTUId";
            this.lTUId.Width = 125;
            // 
            // lTUName
            // 
            this.lTUName.DataPropertyName = "tableName";
            this.lTUName.HeaderText = "Tên Bàn";
            this.lTUName.MinimumWidth = 6;
            this.lTUName.Name = "lTUName";
            this.lTUName.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "Status";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // fBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 707);
            this.Controls.Add(this.pnlBanMN);
            this.Controls.Add(this.dgvwBan);
            this.Controls.Add(this.pnlBan);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fBan";
            this.Text = "fBan";
            this.pnlBanMN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBan)).EndInit();
            this.pnlBan.ResumeLayout(false);
            this.pnlBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDSoBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanMN;
        private FontAwesome.Sharp.IconButton ibtnXemBan;
        private FontAwesome.Sharp.IconButton ibtnXoaBan;
        private FontAwesome.Sharp.IconButton ibtnThemBan;
        private System.Windows.Forms.DataGridView dgvwBan;
        private System.Windows.Forms.Panel pnlBan;
        private System.Windows.Forms.NumericUpDown nmUDSoBan;
        private System.Windows.Forms.TextBox tbxSearchBan;
        private System.Windows.Forms.TextBox tbxTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lTUId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lTUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}