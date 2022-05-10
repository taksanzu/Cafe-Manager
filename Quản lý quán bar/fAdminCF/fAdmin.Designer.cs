namespace Quản_lý_quán_bar.fAdminCF
{
    partial class fAdmin
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
            this.mnsAdmin = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsTTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsTTTK = new System.Windows.Forms.ToolStripMenuItem();
            this.msQLTU = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsTTTU = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsTTLTU = new System.Windows.Forms.ToolStripMenuItem();
            this.msQLNK = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsTTH = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsTTLH = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlAdminCF = new System.Windows.Forms.Panel();
            this.mnsAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAdmin
            // 
            this.mnsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.mnsAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.msQLNV,
            this.msQLTU,
            this.msQLNK});
            this.mnsAdmin.Location = new System.Drawing.Point(0, 0);
            this.mnsAdmin.Name = "mnsAdmin";
            this.mnsAdmin.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.mnsAdmin.Size = new System.Drawing.Size(1102, 28);
            this.mnsAdmin.TabIndex = 0;
            this.mnsAdmin.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // msQLNV
            // 
            this.msQLNV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsTTNV,
            this.mtsTTTK});
            this.msQLNV.Name = "msQLNV";
            this.msQLNV.Size = new System.Drawing.Size(140, 24);
            this.msQLNV.Text = "Quản lý nhân viên";
            // 
            // mtsTTNV
            // 
            this.mtsTTNV.Name = "mtsTTNV";
            this.mtsTTNV.Size = new System.Drawing.Size(222, 26);
            this.mtsTTNV.Text = "Thông tin nhân viên";
            this.mtsTTNV.Click += new System.EventHandler(this.mtsTTNV_Click);
            // 
            // mtsTTTK
            // 
            this.mtsTTTK.Name = "mtsTTTK";
            this.mtsTTTK.Size = new System.Drawing.Size(222, 26);
            this.mtsTTTK.Text = "Thống tin tài khoản";
            this.mtsTTTK.Click += new System.EventHandler(this.mtsTTTK_Click);
            // 
            // msQLTU
            // 
            this.msQLTU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsTTTU,
            this.mtsTTLTU});
            this.msQLTU.Name = "msQLTU";
            this.msQLTU.Size = new System.Drawing.Size(144, 24);
            this.msQLTU.Text = "Quản lý thức uống";
            // 
            // mtsTTTU
            // 
            this.mtsTTTU.Name = "mtsTTTU";
            this.mtsTTTU.Size = new System.Drawing.Size(255, 26);
            this.mtsTTTU.Text = "Thông tin thức uống";
            this.mtsTTTU.Click += new System.EventHandler(this.mtsTTTU_Click);
            // 
            // mtsTTLTU
            // 
            this.mtsTTLTU.Name = "mtsTTLTU";
            this.mtsTTLTU.Size = new System.Drawing.Size(255, 26);
            this.mtsTTLTU.Text = "Thông tin loại thức uống";
            this.mtsTTLTU.Click += new System.EventHandler(this.mtsTTLTU_Click);
            // 
            // msQLNK
            // 
            this.msQLNK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsTTH,
            this.mtsTTLH});
            this.msQLNK.Name = "msQLNK";
            this.msQLNK.Size = new System.Drawing.Size(129, 24);
            this.msQLNK.Text = "Quản lý nhà kho";
            // 
            // mtsTTH
            // 
            this.mtsTTH.Name = "mtsTTH";
            this.mtsTTH.Size = new System.Drawing.Size(224, 26);
            this.mtsTTH.Text = "Thông tin hàng";
            this.mtsTTH.Click += new System.EventHandler(this.mtsTTH_Click);
            // 
            // mtsTTLH
            // 
            this.mtsTTLH.Name = "mtsTTLH";
            this.mtsTTLH.Size = new System.Drawing.Size(224, 26);
            this.mtsTTLH.Text = "Thông tin loại hàng";
            this.mtsTTLH.Click += new System.EventHandler(this.mtsTTLH_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlAdminCF
            // 
            this.pnlAdminCF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminCF.Location = new System.Drawing.Point(0, 28);
            this.pnlAdminCF.Name = "pnlAdminCF";
            this.pnlAdminCF.Size = new System.Drawing.Size(1102, 708);
            this.pnlAdminCF.TabIndex = 1;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 736);
            this.Controls.Add(this.pnlAdminCF);
            this.Controls.Add(this.mnsAdmin);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsAdmin;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.mnsAdmin.ResumeLayout(false);
            this.mnsAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAdmin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msQLNV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mtsTTNV;
        private System.Windows.Forms.ToolStripMenuItem mtsTTTK;
        private System.Windows.Forms.ToolStripMenuItem msQLTU;
        private System.Windows.Forms.ToolStripMenuItem mtsTTTU;
        private System.Windows.Forms.ToolStripMenuItem mtsTTLTU;
        private System.Windows.Forms.ToolStripMenuItem msQLNK;
        private System.Windows.Forms.ToolStripMenuItem mtsTTH;
        private System.Windows.Forms.ToolStripMenuItem mtsTTLH;
        private System.Windows.Forms.Panel pnlAdminCF;
    }
}