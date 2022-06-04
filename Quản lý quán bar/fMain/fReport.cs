using Quản_lý_quán_bar.fMain.fReportCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar.fMain
{
    public partial class fReport : Form
    {
        private Form currentChildForm;
        public fReport()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlReportCF.Controls.Add(childForm);
            pnlReportCF.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void msDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fVenue());
        }

        private void msThucDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fMenu());
        }
    }
}
