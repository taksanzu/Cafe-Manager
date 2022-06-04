using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_bar.fMain.fReportCF
{
    public partial class fVenue : Form
    {
        public fVenue()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {

        }

        private void txbPageBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNextBillPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevioursBillPage_Click(object sender, EventArgs e)
        {

        }

        private void btnLastBillPage_Click(object sender, EventArgs e)
        {

        }

        private void btnFristBillPage_Click(object sender, EventArgs e)
        {

        }

        private void btnViewBill_Click_1(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = DAL_HoaDon.Instance.GetBillListByDate(checkIn, checkOut);
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void fVenue_Load(object sender, EventArgs e)
        {

            
        }
    }
}
