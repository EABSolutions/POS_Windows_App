using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAB_Business_Solution.Class;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace EAB_Business_Solution.Forms
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public clsTable clsTable { get; set; }
        public clsPOS clsPOS { get; set; }
        public clsMethods clsMethod { get; set; }
        public int SubTotal { get; set; }
        public int GrandTotal { get; set; }
        public int Tax { get; set; }
        public int ServiceCharnge { get; set; }
        public int CashAmount { get; set; }
        public int ChangeAmount { get; set; }
        public string EID { get; set; }
        private FormMode frmMode { get; set; }
        Class.clsCustomer C = new Class.clsCustomer();

        public enum FormMode 
        {
            New = 1,
            Edit = 2
        }
        
        private void frmPOS_Load(object sender, EventArgs e)
        {
            this.frmMode = FormMode.New;
            this.TableComboBind();
            this.ProductLineGridComboBind();
            chkCustomerName.Checked = false;
            cboCustomerName.Enabled = false;
            lblNRC.Visible = false;
            lblNRCShow.Visible = false;
            lblMembership.Visible = false;
            lblMembershipShow.Visible = false;
            lblCustomerType.Visible = false;
            lblCustomerTypeShow.Visible = false;
            btnNew.Enabled = false;
            this.reportViewer1.RefreshReport();
            
        }

        #region DataRetrieve
        private void CustomerDataRetrievebyCID()
        {
            try
            {

                DataTable tbl = new DataTable();
                tbl = C.CallCustomerbyID();
                if (tbl.Rows.Count == 0)
                {
                }
                else
                {
                    string nrc = tbl.Rows[0][2].ToString();
                    if (nrc == "")
                    {
                        lblNRC.Visible = false;
                        lblNRCShow.Visible = false;
                    }
                    else
                    {
                        lblNRC.Visible = true;
                        lblNRCShow.Visible = true;
                        lblNRCShow.Text = tbl.Rows[0][2].ToString();
                    }

                    lblCustomerType.Visible = true;
                    lblCustomerTypeShow.Visible = true;
                    lblCustomerTypeShow.Text = tbl.Rows[0][36].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void MembershipDataRetrievebyCID()
        {
            try
            {

                DataTable tbl = new DataTable();
                tbl = C.CallMembershipbyCID();

                if (tbl.Rows.Count <= 0)
                {
                    lblMembership.Visible = false;
                    lblMembershipShow.Visible = false;
                }
                else
                {
                    lblMembership.Visible = true;
                    lblMembershipShow.Visible = true;
                    lblMembershipShow.Text = tbl.Rows[0][1].ToString();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        #endregion

        #region ComboBind
        private void CustomerComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = C.CallCustomer();
                cboCustomerName.DataSource = tbl;
                cboCustomerName.ValueMember = "CID";
                cboCustomerName.DisplayMember = "CName";

                cboCustomerName.SelectedIndex = -1;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void TableComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                this.clsTable = new clsTable();
                tbl = this.clsTable.CallTable();
                cboTableNo.DataSource = tbl;
                cboTableNo.DisplayMember = "TName";
                cboTableNo.ValueMember = "TID";
                cboTableNo.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void TableComboBindEdit()
        {
            try
            {
                cboCustomerName.DataSource = null;
                DataTable tbl = new DataTable();
                this.clsTable = new clsTable();
                tbl = this.clsTable.CallTableEdit();
                cboTableNo.DataSource = tbl;
                cboTableNo.DisplayMember = "TName";
                cboTableNo.ValueMember = "TID";
                cboTableNo.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
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

        private void ProductGridComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                this.clsPOS = new clsPOS();
                tbl = this.clsPOS.CallProduct();
                //DataGridViewComboBoxColumn colProduct = (DataGridViewComboBoxColumn)(dgvSalesInfo.Columns["PName"]);
                cboProductName.DataSource = tbl;
                cboProductName.DisplayMember = "PName";
                cboProductName.ValueMember = "PID";
                cboProductName.SelectedIndex = -1;
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
        #endregion

        private void FillProductInfo(string PID)
        {
            try
            {
                DataTable tbl = new DataTable();
                this.clsPOS = new clsPOS();
                string productID = cboProductName.SelectedValue.ToString();
                int qty = int.Parse(txtQuantity.Text.ToString().Trim());
                this.clsPOS.WHID = 1;
                this.clsPOS.SPID = int.Parse(productID);
                int? invQty = clsPOS.SEL_PQty();

                if (invQty < qty)
                {
                    MessageBox.Show("Plz check Quantity in the Store", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                tbl = this.clsPOS.PolpulateProductInfo(PID);
                string currency = tbl.Rows[0][0].ToString();
                long price = long.Parse(tbl.Rows[0][1].ToString());

                
                foreach (DataGridViewRow item in dgvSalesInfo.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        if (item.Cells[0].Value.ToString().Equals(productID))
                        {
                            qty += int.Parse(item.Cells[3].Value.ToString());
                            dgvSalesInfo.Rows.RemoveAt(item.Index);
                        }
                    }
                }

                string unit = tbl.Rows[0][3].ToString();
                long total = price * qty;

                if (this.frmMode == FormMode.Edit)
                {
                    dgvSalesInfo.DataSource = null;
                }

                object[] row = new object[] 
                {
                    productID,
                    cboProductName.Text,
                    unit,
                    qty,
                    price,
                    currency,
                    "0",
                    "0",
                    total
                };
                dgvSalesInfo.Rows.Add(row);

                this.PolpulatePaymentInfo();

                clsMethod = new clsMethods();
                clsMethod.TextBox_Clear(txtQuantity);
                clsMethod.Combobox_Clear(cboProductLineName, cboProductName);
                cboProductLineName.Focus();

                //DataGridViewColumn colPrice = (DataGridViewColumn)(dgvSalesInfo.Rows[index].Cells["Price"]);
                //DataGridViewColumn colCurrency = (DataGridViewColumn)(dgvSalesInfo.Rows[index].Cells["Currency"]);
                //dgvSalesInfo.DataSource = tbl;                
               
                //colPrice.DataSource = tbl;
                //colPrice.DisplayMember = "PRetailPrice";
                //colPrice.ValueMember = "PRetailPrice";

                //colCurrency.DataSource = tbl;
                //colCurrency.DisplayMember = "CurrencyCode";
                //colCurrency.ValueMember = "CurrencyCode";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void PolpulatePaymentInfo()
        {
            this.SubTotal = 0;
            foreach (DataGridViewRow item in dgvSalesInfo.Rows)
            {                
                if (item.Cells[8].Value != null)
                {
                    SubTotal += int.Parse(item.Cells[8].Value.ToString());
                }
            }         

            txtAmount.Text = SubTotal.ToString();
            int taxAmt = this.clsPOS.SEL_Tax();
            int scAmt = this.clsPOS.SEL_ServiceCharges();
            ServiceCharnge = scAmt;

            long tax = (SubTotal / 100) * taxAmt;
            Tax = int.Parse(tax.ToString());
            txtTax.Text = Tax.ToString();
            
            txtServiceCharges.Text = scAmt.ToString();

            GrandTotal = SubTotal + Tax + ServiceCharnge;

            txtTotal.Text = GrandTotal.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tableID = cboTableNo.SelectedValue.ToString();

            clsPOS = new clsPOS();
            int salesID;
            if (this.frmMode == FormMode.New)
            {
                salesID = clsPOS.AutoID_Sales();
            }
            else
            {
                salesID = int.Parse(this.txtSalesID.Text.ToString());
            }
            clsPOS.SalesID = salesID;
            clsPOS.TID = tableID;
            clsPOS.SalesDate = DateTime.Now;
            clsPOS.SalesDesc = "-";
            clsPOS.CID = "-";
            clsPOS.CreatedEID = this.EID;

            if (this.frmMode == FormMode.New)
            {
                clsPOS.Ins_Sales();
            }            

            foreach (DataGridViewRow item in dgvSalesInfo.Rows)
            {
                string productID = item.Cells["colProductID"].Value.ToString();
                string quantity = item.Cells["colQuantity"].Value.ToString();

                clsPOS = new clsPOS() 
                { 
                    SalesID = salesID,
                    TID = tableID,
                    SalesQty = int.Parse(quantity),
                    SPID = int.Parse(productID),
                    SalesDate = DateTime.Now,
                    SalesDesc = "-",
                    CID = "-",
                    CreatedEID = this.EID,
                    Status = 0
                };                

                clsPOS.Ins_SalesDetail();

                clsPOS.WHID = 1;
                clsPOS.SPID = int.Parse(productID);
                int? invQty = clsPOS.SEL_PQty();

                if (this.frmMode == FormMode.Edit)
                {
                    DataTable tbl = new DataTable();
                    tbl = this.clsPOS.SEL_GetFQty();
                    if (tbl.Rows.Count > 0)
                    {
                        int fQty = int.Parse(tbl.Rows[0][0].ToString());
                        clsPOS.SalesQty = fQty;
                    }
                }

                if (invQty >= clsPOS.SalesQty)
                {
                    clsPOS.IQty = invQty - clsPOS.SalesQty;
                    clsPOS.UPD_Inventory();
                }
            }
            MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.newFormMode();
            //Showing Order List Process
          

        }

        private void cboTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.frmMode == FormMode.Edit)
            {               
                this.clsPOS = new clsPOS();

                if (cboTableNo.SelectedIndex == -1)
                { }
                else
                {

                this.clsPOS.TID = cboTableNo.SelectedValue.ToString();
                
                DataTable tbl = new DataTable();
                tbl = this.clsPOS.SEL_SalesInfo();                                
                
                dgvSalesInfo.AutoGenerateColumns = false;
                dgvSalesInfo.Columns[0].Name = "colProductID";
                dgvSalesInfo.Columns[0].HeaderText = "Product ID";
                dgvSalesInfo.Columns[0].DataPropertyName = "PID";

                dgvSalesInfo.Columns[1].Name = "colProductName";
                dgvSalesInfo.Columns[1].HeaderText = "Product Name";
                dgvSalesInfo.Columns[1].DataPropertyName = "PName";

                dgvSalesInfo.Columns[2].Name = "colUnit";
                dgvSalesInfo.Columns[2].HeaderText = "Unit";
                dgvSalesInfo.Columns[2].DataPropertyName = "UOMName";

                dgvSalesInfo.Columns[3].Name = "colQuantity";
                dgvSalesInfo.Columns[3].HeaderText = "Quantity";
                dgvSalesInfo.Columns[3].DataPropertyName = "SalesQty";

                dgvSalesInfo.Columns[4].Name = "colPrice";
                dgvSalesInfo.Columns[4].HeaderText = "Price";
                dgvSalesInfo.Columns[4].DataPropertyName = "PRetailPrice";

                dgvSalesInfo.Columns[5].Name = "colCurrency";
                dgvSalesInfo.Columns[5].HeaderText = "Currency";
                dgvSalesInfo.Columns[5].DataPropertyName = "CurrencyCode";

                dgvSalesInfo.Columns[6].Name = "colPromotionPercentage";
                dgvSalesInfo.Columns[6].HeaderText = "Promotion Percentage";
                dgvSalesInfo.Columns[6].DataPropertyName = "PromotionPercentage";

                dgvSalesInfo.Columns[7].Name = "colPromotion";
                dgvSalesInfo.Columns[7].HeaderText = "Promotion";
                dgvSalesInfo.Columns[7].DataPropertyName = "Promotion";

                dgvSalesInfo.Columns[8].Name = "colAmount";
                dgvSalesInfo.Columns[8].HeaderText = "Amount";
                dgvSalesInfo.Columns[8].DataPropertyName = "Amount";

                this.dgvSalesInfo.DataSource = tbl;

                if (tbl.Rows.Count > 0)
                {
                    this.txtSalesID.Text = tbl.Rows[0][0].ToString();
                    this.PolpulatePaymentInfo();
                }
                else
                {
                    this.frmMode = FormMode.Edit;
                    this.editFormMode();
                    //this.clsMethod.Combobox_Enable(true, this.cboProductLineName, this.cboProductName);
                    ////this.clsMethod.Combobox_Clear(cboProductLineName, cboProductName);
                    this.clsMethod.TextBox_Enable(false, this.txtCashAmount);
                    //this.clsMethod.Grid_Enable(true, this.dgvSalesInfo);
                    //this.clsMethod.Button_Enable(true, this.btnSave);
                }
            }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.frmMode = FormMode.Edit;
            this.editFormMode();
            
            this.clsMethod.Combobox_Enable(true, this.cboProductLineName, this.cboProductName);
            //this.clsMethod.Combobox_Clear(cboProductLineName, cboProductName);
            this.clsMethod.TextBox_Enable(true, this.txtQuantity);
            this.clsMethod.Grid_Enable(true, this.dgvSalesInfo);
            this.clsMethod.Button_Enable(true, this.btnSave);
            btnNew.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.frmMode = FormMode.New;
            this.newFormMode();
            TableComboBind();
            btnEdit.Enabled = false;
        }

        #region testRegion
        private void dgvSalesInfo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox c = e.Control as ComboBox;
            if (c != null)
            {
                if (dgvSalesInfo.CurrentCell.ColumnIndex == 1)
                {
                    c.SelectedIndexChanged -= new EventHandler(SelectionChanged);
                    c.SelectedIndexChanged += new EventHandler(SelectionChanged);
                }
            }
            
        }

        private void SelectionChanged(object sender, EventArgs e) 
        {
            if (dgvSalesInfo.CurrentCell.ColumnIndex == 1)
            {
                ComboBox cx = sender as ComboBox;
                string productLineID = cx.SelectedValue.ToString();
                //this.ProductGridComboBind(productLineID);
            }
        }

        private void dgvSalesInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSalesInfo_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (dgvSalesInfo.IsCurrentCellDirty)
            //{
            //    if (dgvSalesInfo.CurrentCell.ColumnIndex == 1)
            //    {
            //        string productLineID = dgvSalesInfo.CurrentCell.EditedFormattedValue.ToString();
            //        int rowIndex = dgvSalesInfo.CurrentRow.Index;
            //        this.ProductGridComboBind(productLineID, rowIndex);

            //    }
            //    else if (dgvSalesInfo.CurrentCell.ColumnIndex == 2)
            //    {
            //        string productID = dgvSalesInfo.CurrentCell.EditedFormattedValue.ToString();
            //        int rowIndex = dgvSalesInfo.CurrentRow.Index;
            //        this.FillProductInfo(productID, rowIndex);
            //    }
            //}
        }

        private void dgvSalesInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvSalesInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        #endregion

        private void cboProductLineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductLineName.SelectedIndex != -1)
            {
                string productLineID;
                productLineID = cboProductLineName.SelectedValue.ToString();
                this.ProductGridComboBind(productLineID);
            }           
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string productID = cboProductName.SelectedValue.ToString();
                this.FillProductInfo(productID);
                cboProductLineName.Focus();
            }
        }
        int rowIndex = 0;
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvSalesInfo.Rows.RemoveAt(rowIndex);
        }

        private void dgvSalesInfo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvSalesInfo.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {          
            DoPrint();
        }

        private void DoPrint()
        {
            try
            {
                this.reportViewer1.PrintDialog();
            }
            catch (InvalidOperationException)
            {
                if (MessageBox.Show("Error when printing. Please retry.", "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    this.DoPrint();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmMode = FormMode.New;
            this.newFormMode();
        }

        private void newFormMode()
        {
            this.clsMethod = new clsMethods();
            this.Tax = 0;
            this.ServiceCharnge = 0;
            this.SubTotal = 0;
            this.clsMethod.Button_Enable(true, btnNew, btnEdit, btnSave);
            this.clsMethod.TextBox_Clear(txtAmount, txtCashAmount, txtChange, txtInvoiceNo, txtMemberPromotion, txtMemberPromotionPercentage, txtQuantity, txtSalesID, txtServiceCharges, txtTax, txtTotal);
            this.clsMethod.Combobox_Clear(cboProductLineName, cboTableNo, cboProductName);
            this.clsMethod.TextBox_Enable(true, txtQuantity, txtCashAmount);
            this.clsMethod.Combobox_Enable(true, cboProductLineName, cboProductName);
            this.clsMethod.Grid_Enable(true, dgvSalesInfo);
            this.clsMethod.Grid_Clear(dgvSalesInfo);
            this.cboTableNo.Focus();
            this.clsMethod.Button_Enable(false, btnCash, btnNew);
            chkCustomerName.Checked = false;
            lblNRC.Visible = false;
            lblNRCShow.Visible = false;
            lblMembership.Visible = false;
            lblMembershipShow.Visible = false;
            lblCustomerType.Visible = false;
            lblCustomerTypeShow.Visible = false;
            cboCustomerName.Enabled = false;
            TableComboBind();
        }

        private void editFormMode()
        {
            this.clsMethod = new clsMethods();
            this.TableComboBindEdit();
            this.clsMethod.Button_Enable(false, btnEdit, btnSave, this.btnNew);
            this.clsMethod.Combobox_Enable(false, this.cboProductLineName, this.cboProductName);
            this.clsMethod.Combobox_Clear(cboProductLineName, cboProductName);
            this.clsMethod.TextBox_Enable(false, this.txtQuantity);
            this.clsMethod.Grid_Enable(false, this.dgvSalesInfo);
            this.clsMethod.Grid_Clear(dgvSalesInfo);
            this.clsMethod.TextBox_Clear(txtAmount, txtCashAmount, txtChange, txtInvoiceNo, txtMemberPromotion, txtMemberPromotionPercentage, txtQuantity, txtSalesID, txtServiceCharges, txtTax, txtTotal);
            chkCustomerName.Checked = false;
            cboCustomerName.Enabled = false;
        }

        private void txtCashAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                long grandTotal = long.Parse(txtTotal.Text.ToString());
                long cashAmount = long.Parse(txtCashAmount.Text.ToString());
                long changeAmount = 0;
                if (cashAmount < grandTotal)
                {
                    MessageBox.Show("Please check Cash Amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCashAmount.Focus();
                    return;
                }
                else changeAmount = cashAmount - grandTotal;

                txtChange.Text = changeAmount.ToString();
                btnCash.Enabled = true;

                this.clsPOS = new clsPOS();
                this.clsPOS.InvoiceNo = clsPOS.AutoID_Invoice();
                this.ChangeAmount = int.Parse(txtChange.Text.ToString());
                this.CashAmount = int.Parse(txtCashAmount.Text.ToString());

                this.clsPOS.InvoiceDate = DateTime.Now;
                this.clsPOS.SubTotal = this.SubTotal;
                this.clsPOS.TaxAmount = this.Tax;
                this.clsPOS.ServiceChargeAmount = this.ServiceCharnge;
                this.clsPOS.GrandTotal = this.GrandTotal;
                this.clsPOS.CashAmount = this.CashAmount;
                this.clsPOS.ChangeAmount = this.ChangeAmount;
                this.clsPOS.MemberPromotion = 0;
                this.clsPOS.Ins_Invoice();

                foreach (DataGridViewRow item in dgvSalesInfo.Rows)
                {
                    string productID = item.Cells["colProductID"].Value.ToString();
                    string quantity = item.Cells["colQuantity"].Value.ToString();
                    string productAmount = item.Cells["colPrice"].Value.ToString();
                    string productTotalAmt = item.Cells["colAmount"].Value.ToString();

                    this.clsPOS.SalesID = int.Parse(txtSalesID.Text.ToString());
                    this.clsPOS.SalesQty = int.Parse(quantity);
                    this.clsPOS.SPID = int.Parse(productID);
                    this.clsPOS.PTotalAmount = int.Parse(productTotalAmt);
                    this.clsPOS.ProductAmount = int.Parse(productAmount);

                    clsPOS.Ins_InvoiceDetail();
                }

                clsMethod.Button_Enable(false, btnNew, btnCancel, btnEdit, btnSave, btnCustomer);
                clsMethod.Combobox_Enable(false, cboTableNo, cboProductLineName, cboProductName, cboCustomerName);
                clsMethod.TextBox_Enable(false, txtQuantity, txtSalesID, txtInvoiceNo, txtCashAmount);
                dtpSalesDate.Enabled=false;
                dgvSalesInfo.Enabled=false;

                txtInvoiceNo.Text = this.clsPOS.InvoiceNo.ToString();

                this.clsPOS.TID = this.cboTableNo.SelectedValue.ToString();
                this.clsPOS.SalesID = int.Parse(this.txtSalesID.Text.ToString());
                DataTable dt = this.clsPOS.SEL_POSPrint();

                ReportDataSource ss = new ReportDataSource();
                ss.Name = "DataSet1";
                ss.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ss);

                PageSettings pg = new PageSettings();
                pg.Margins.Top = 0;
                pg.Margins.Bottom = 0;
                pg.Margins.Left = 0;
                pg.Margins.Right = 0;
                reportViewer1.SetPageSettings(pg);
                reportViewer1.RefreshReport();
                btnCash.Focus();
            }
        }

        private void chkCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomerName.Checked == true)
            {
                cboCustomerName.Enabled = true;
                CustomerComboBind();
            }
            else
            {
                cboCustomerName.Enabled = false;
            }
        }

        private void cboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomerName.SelectedIndex == -1)
            {
                lblNRC.Visible = false;
                lblNRCShow.Visible = false;
                lblMembership.Visible = false;
                lblMembershipShow.Visible = false;
                lblCustomerType.Visible = false;
                lblCustomerTypeShow.Visible = false;
            }
            else
            {
                C.CID = cboCustomerName.SelectedValue.ToString();
                CustomerDataRetrievebyCID();
                MembershipDataRetrievebyCID();
            }
        }

        private void cboTableNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboProductLineName.Focus();
            }
        }

        private void cboProductLineName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboProductName.Focus();
            }
        }

        private void cboProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtQuantity.Focus();
            }
        }

        private void dtpSalesDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtQuantity.Focus();
            }
        }
    }
}
