﻿using Quản_lý_quán_bar.fAdminCF.fQLNK;
using Quản_lý_quán_bar.fAdminCF.fQLTU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar.fAdminCF
{
    public partial class fAdmin : Form
    {
        private Form currentChildForm;
        public fAdmin()
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
            pnlAdminCF.Controls.Add(childForm);
            pnlAdminCF.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void mtsTTNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTTNV());
        }

        private void mtsTTTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTTK());
        }

        private void mtsTTTU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTTTU());
        }

        private void mtsTTLTU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTTLTU());
        }

        private void mtsTTH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTTH());
        }

        private void mtsTTLH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTTLH());
        }
    }
}
