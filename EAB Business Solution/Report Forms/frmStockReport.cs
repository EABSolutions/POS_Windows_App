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
    public partial class frmStockReport : Form
    {
        public frmStockReport()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Report_Class.clsStockReport sr = new EAB_Business_Solution.Report_Class.clsStockReport();
        }
    }
}
