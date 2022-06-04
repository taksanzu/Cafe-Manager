namespace Quản_lý_quán_bar.fMain.fReportCF
{
    partial class fMenu
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
            this.dgvwMenu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchMN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvwMenu
            // 
            this.dgvwMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwMenu.Location = new System.Drawing.Point(0, 47);
            this.dgvwMenu.Name = "dgvwMenu";
            this.dgvwMenu.RowHeadersWidth = 51;
            this.dgvwMenu.RowTemplate.Height = 24;
            this.dgvwMenu.Size = new System.Drawing.Size(1010, 569);
            this.dgvwMenu.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxSearchMN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 47);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // tbxSearchMN
            // 
            this.tbxSearchMN.Location = new System.Drawing.Point(134, 9);
            this.tbxSearchMN.Name = "tbxSearchMN";
            this.tbxSearchMN.Size = new System.Drawing.Size(343, 27);
            this.tbxSearchMN.TabIndex = 1;
            this.tbxSearchMN.TextChanged += new System.EventHandler(this.tbxSearchMN_TextChanged);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 616);
            this.Controls.Add(this.dgvwMenu);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fMenu";
            this.Text = "fMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvwMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvwMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxSearchMN;
        private System.Windows.Forms.Label label1;
    }
}