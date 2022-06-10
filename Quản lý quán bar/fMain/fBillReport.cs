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
    public partial class fBillReport : Form
    {
        List<Menu> listBillInfo;
        string discount, totalPrice;
        public fBillReport(List<Menu> listMenu, string discount, string totalPrice)
        {
            InitializeComponent();
            
            this.listBillInfo = listMenu;
            this.discount = discount;
            this.totalPrice = totalPrice;
        }

        private void fBillReport_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
