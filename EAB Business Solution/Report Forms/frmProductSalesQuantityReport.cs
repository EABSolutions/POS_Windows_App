using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAB_Business_Solution.Class;

namespace EAB_Business_Solution.Report_Forms
{
    public partial class frmProductSalesQuantityReport : Form
    {

        

        public frmProductSalesQuantityReport()
        {
            InitializeComponent();
            ProductLineGridComboBind();
        }

        public clsPOS clsPOS { get; set; }

        private void cboProductLineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductLineName.SelectedIndex != -1)
            {
                cboProductName.Enabled = true;
                string productLineID;
                productLineID = cboProductLineName.SelectedValue.ToString();
                this.ProductGridComboBind(productLineID);
            }  
        }

        private void ProductLineGridComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                this.clsPOS = new clsPOS();
                tbl = this.clsPOS.CallProductLine();
                //DataGridViewComboBoxColumn colProductLine = (DataGridViewComboBoxColumn)(dgvSalesInfo.Columns["PLName"]);
                cboProductLineName.DataSource = tbl;
                cboProductLineName.DisplayMember = "PLName";
                cboProductLineName.ValueMember = "PLID";
                cboProductLineName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void ProductGridComboBind(string PLID)
        {
            try
            {
                DataTable tbl = new DataTable();
                this.clsPOS = new clsPOS();
                tbl = this.clsPOS.CallProduct(PLID);
                //DataGridViewComboBoxCell colProduct = (DataGridViewComboBoxCell)(dgvSalesInfo.Rows[index].Cells["PName"]);
                cboProductName.DataSource = tbl;
                cboProductName.DisplayMember = "PName";
                cboProductName.ValueMember = "PID";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cboProductLineName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Product Line!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProductLineName.Focus();
            }
            else if (cboProductName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProductName.Focus();
            }
            else
            {
                Report_Class.clsProductSalesQuantityReport sr = new EAB_Business_Solution.Report_Class.clsProductSalesQuantityReport(cboProductName.SelectedValue.ToString(), dtpFromDate.Value, dtpToDate.Value);
            } 
        }

        private void frmProductSalesQuantityReport_Load(object sender, EventArgs e)
        {
            cboProductName.Enabled = false;
            dtpFromDate.Enabled = false;
            dtpToDate.Enabled = false;
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductLineName.SelectedIndex != -1)
            {
                dtpFromDate.Enabled = true;
                dtpToDate.Enabled = true;
            }
        }
    }
}
