namespace Quản_lý_quán_bar.fMain
{
    partial class fReport
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
            this.msXemBaoCao = new System.Windows.Forms.MenuStrip();
            this.msDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.msThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlReportCF = new System.Windows.Forms.Panel();
            this.msXemBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // msXemBaoCao
            // 
            this.msXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.msXemBaoCao.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msXemBaoCao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDoanhThu,
            this.msThucDon});
            this.msXemBaoCao.Location = new System.Drawing.Point(0, 0);
            this.msXemBaoCao.Name = "msXemBaoCao";
            this.msXemBaoCao.Size = new System.Drawing.Size(1010, 28);
            this.msXemBaoCao.TabIndex = 0;
            this.msXemBaoCao.Text = "menuStrip1";
            // 
            // msDoanhThu
            // 
            this.msDoanhThu.Name = "msDoanhThu";
            this.msDoanhThu.Size = new System.Drawing.Size(92, 24);
            this.msDoanhThu.Text = "Doanh thu";
            this.msDoanhThu.Click += new System.EventHandler(this.msDoanhThu_Click);
            // 
            // msThucDon
            // 
            this.msThucDon.Name = "msThucDon";
            this.msThucDon.Size = new System.Drawing.Size(85, 24);
            this.msThucDon.Text = "Thực đơn";
            this.msThucDon.Click += new System.EventHandler(this.msThucDon_Click);
            // 
            // pnlReportCF
            // 
            this.pnlReportCF.BackgroundImage = global::Quản_lý_quán_bar.Properties.Resources.image_removebg_preview__1_;
            this.pnlReportCF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlReportCF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportCF.Location = new System.Drawing.Point(0, 28);
            this.pnlReportCF.Name = "pnlReportCF";
            this.pnlReportCF.Size = new System.Drawing.Size(1010, 616);
            this.pnlReportCF.TabIndex = 1;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 644);
            this.Controls.Add(this.pnlReportCF);
            this.Controls.Add(this.msXemBaoCao);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msXemBaoCao;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fReport";
            this.Text = "fReport";
            this.msXemBaoCao.ResumeLayout(false);
            this.msXemBaoCao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msXemBaoCao;
        private System.Windows.Forms.ToolStripMenuItem msDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem msThucDon;
        private System.Windows.Forms.Panel pnlReportCF;
    }
}