using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAB_Business_Solution.Class;

namespace EAB_Business_Solution.Forms
{
    public partial class frmOrderList : Form
    {
        public frmOrderList()
        {
            InitializeComponent();
            Timer t = new Timer() { Interval = 50000 };
            t.Tick += frmOrderList_Load;
            t.Start();
        }

        public clsPOS clsPOS { get; set; }
        public clsOrderLists clsOrderLists { get; set; }

        private void frmOrderList_Load(object sender, EventArgs e)
        {
            this.PolpulateOrderGrid();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.clsOrderLists = new clsOrderLists();
            foreach (DataGridViewRow item in dgvOrderList.Rows)
            {
                if (item.Cells[0].Value != null)
	            {
                    string salesID = item.Cells[4].Value.ToString();
                    string productID = item.Cells[5].Value.ToString();
                    string fQty = item.Cells[3].Value.ToString();
                    this.clsOrderLists.SPID = int.Parse(productID);
                    this.clsOrderLists.SalesID = int.Parse(salesID);
                    this.clsOrderLists.FQty = int.Parse(fQty);
                    this.clsOrderLists.UPD_Inventory();
                    this.PolpulateOrderGrid();
	            }                           
            }
        }

        private void PolpulateOrderGrid()
        {
            DataTable tbl = new DataTable();
            this.clsPOS = new clsPOS();
            tbl = this.clsPOS.SEL_OrderLists();

            dgvOrderList.AutoGenerateColumns = false;
            dgvOrderList.Columns[1].Name = "tablename";
            dgvOrderList.Columns[1].HeaderText = "Table Name";
            dgvOrderList.Columns[1].DataPropertyName = "TableName";

            dgvOrderList.Columns[2].Name = "productname";
            dgvOrderList.Columns[2].HeaderText = "Product Name";
            dgvOrderList.Columns[2].DataPropertyName = "ProductName";

            dgvOrderList.Columns[3].Name = "quantity";
            dgvOrderList.Columns[3].HeaderText = "Quantity";
            dgvOrderList.Columns[3].DataPropertyName = "Quantity";

            dgvOrderList.Columns[4].Name = "SalesID";
            dgvOrderList.Columns[4].HeaderText = "SalesID";
            dgvOrderList.Columns[4].DataPropertyName = "SalesID";

            dgvOrderList.Columns[5].Name = "ProductID";
            dgvOrderList.Columns[5].HeaderText = "ProductID";
            dgvOrderList.Columns[5].DataPropertyName = "ProductID";

            dgvOrderList.DataSource = tbl;
        }
    }
}
