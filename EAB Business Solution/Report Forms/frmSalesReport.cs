using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EAB_Business_Solution.Report_Forms
{
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Report_Class.clsSalesReport sr = new EAB_Business_Solution.Report_Class.clsSalesReport(dtpFromDate.Value, dtpToDate.Value);
           // sr.fdate = dtpFromDate.Value;
            //sr.tdate = dtpToDate.Value;

        }

        private void dtpFromDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpToDate.Focus();
            }
        }

        private void dtpToDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGenerate.Focus();
            }
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            dtpFromDate.Focus();
        }
    }
}
