using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace EAB_Business_Solution.Forms
{
    public partial class frmSalesOrder : Form
    {
        Class.clsSalesOrder SO = new Class.clsSalesOrder();
        Class.clsInventory Inv = new Class.clsInventory();
        Class.clsMethods M = new Class.clsMethods();
        Class.clsCustomer C = new Class.clsCustomer();
        Class.clsWarehouse W = new Class.clsWarehouse();
        Class.clsProduct P = new Class.clsProduct();
        Class.clsPOS pos = new Class.clsPOS();
        Class.clsProductLine pl = new Class.clsProductLine();
        DataTable dt;
        public string EID;
        public string CompID;
        public int SubTotal { get; set; }
        public int GrandTotal { get; set; }
        public int Tax { get; set; }
        public int ServiceCharnge { get; set; }


        public frmSalesOrder()
        {
            InitializeComponent();
            Loading();
            reportViewer1.Visible = false;
        }

        #region Methods

        #region Loading
        private void Loading()
        {
            M.TextBox_Enable(false, txtSOID, txtInvoiceNo, txtDescription, txtQuantity, txtDeposit, txtFirstPayment, txtAmendmentPayment, txtRemark);
            M.Button_Enable(true, btnNew);
            M.Button_Enable(false, btnSave, btnEdit, btnDelete, btnCancel, btnCash, btnAdd, btnCustomer, btnProductName, btnOrderCancel);
            M.TextBox_Clear(txtSOID, txtInvoiceNo, txtDescription, txtQuantity, txtDeposit, txtFirstPayment, txtAmendmentPayment, txtRemark, txtSubTotal, txtMemberPromotion, txtMemberPromotionPercentage, txtTax, txtServiceCharges, txtGrandTotal, txtCreditAmount);
            M.DateTimePicker_Enable(false, dtpDate, dtpDeliveryDate);
            M.DataGridView_Enable(false, dgvSalesOrder);
            M.Combobox_Enable(false, cboProductName, cboCustomerName);
            rdbDebitPay.Enabled = false;
            rdbCreditPay.Enabled = false;
            
            lblCustomerType.Visible = false;
            lblCustomerTypeShow.Visible = false;
            lblMembership.Visible = false;
            lblMembershipShow.Visible = false;
            lblNRC.Visible = false;
            lblNRCShow.Visible = false;
            cboCustomerName.SelectedIndex = -1;
            cboProductName.SelectedIndex = -1;
            GridDataClear();
            btnNew.Focus();

        }
        #endregion


        #region GridDataClear
        private void GridDataClear()
        {
            if (this.dgvSalesOrder.DataSource != null)
            {
                this.dgvSalesOrder.DataSource = null;
            }
            else
            {
                this.dgvSalesOrder.Rows.Clear();
            }
        }

        private void SearchGridDataClear()
        {
            if (this.dgvSSalesOrder.DataSource != null)
            {
                this.dgvSSalesOrder.DataSource = null;
            }
            else
            {
                this.dgvSSalesOrder.Rows.Clear();
            }
        }
        #endregion

        #region SearchPanelLoading
        private void SearchPanelLoading()
        {
           
            M.Checkbox_Checked(false, chkSDebitPay, chkSCreditPay, chkSCancelOrders, chkSDate, chkSCustomerName, chkSSalesOrderID);
            M.CheckBox_Enable(false, chkSDebitPay, chkSCreditPay, chkSCancelOrders, chkSDate, chkSCustomerName);
            CustomerComboBind();
            SearchCheckboxValidation();
            GridDataClear();
            M.DataGridView_Enable(false, dgvSSalesOrder);
        }
        #endregion

        #region SearchDataassign
        private void searchdataassign()
        {
            if (chkSSalesOrderID.Checked == false)
            {
                SO.SOID = 0;
            }
            else
            {
                SO.SOID = Convert.ToInt32(txtSSalesOrderID.Text.ToString());
            }
            if (chkSDate.Checked == false)
            {
                SO.FromDate = Convert.ToDateTime("01/01/1900");
                SO.ToDate = Convert.ToDateTime("01/01/1900");
            }
            else
            {
                SO.FromDate = dtpSFromDate.Value;
                SO.ToDate = dtpSToDate.Value;
            }

            if (chkSCustomerName.Checked == false)
            {
                SO.CID = "";
            }
            else
            {
                SO.CName = txtSCustomerName.Text.Trim();
            }
            if (chkSCreditPay.Checked == false)
            {
                SO.SOStatus = -1;
            }
            else
            {
                SO.SOStatus = 0;
            }
            if (chkSDebitPay.Checked == false)
            {
                SO.SOStatus = -1;
            }
            else
            {
                SO.SOStatus = 1;
            }
            if (chkSCancelOrders.Checked == false)
            {
                SO.SOStatus = -1;
            }
            else
            {
                SO.SOStatus = 2;
            }
        }
        #endregion

        #region ShowallDataassign
        private void showalldataassign()
        {
            SO.SOID = 0;
            SO.FromDate = Convert.ToDateTime("01/01/1900");
            SO.ToDate = Convert.ToDateTime("01/01/1900");
            SO.CID = "";
            SO.SOStatus = -1;
        }
        #endregion

        #region Dataassign
        private void dataassign()
        {



            // SO.SOID = Convert.ToInt32( txtSOID.Text.ToString());
            // SO.PODate = dtpDate.Value;
            // SO.PODescription = txtDescription.Text.ToString();
            // SO.RequestedEID = EID.ToString();
            // SO.ApprovedEID = EID.ToString();
            // SO.ApprovedDate = System.DateTime.Now;
            // SO.SID = cboSupplier.SelectedValue.ToString();
            // if (txtDepositAmount.Text == "")
            // {
            //     SO.DepositAmount = 0;
            // }
            // else
            // {
            //     SO.DepositAmount = Convert.ToInt32(txtDepositAmount.Text.ToString());
            // }
            // if (txtFirstPayment.Text == "")
            // {
            //     SO.FirstPayment = 0;
            // }
            // else
            // {
            //     SO.FirstPayment = Convert.ToInt32(txtFirstPayment.Text.ToString());
            // }
            // if (txtAmendmentPayment.Text == "")
            // {
            //     SO.AmendmentPayment = 0;
            // }
            // else
            // {
            //     SO.AmendmentPayment = Convert.ToInt32(txtAmendmentPayment.Text.ToString());
            // }
            // foreach (DataGridViewRow item in dgvProductInfo.Rows)
            // {
            //     { 
            //          SO.PID = item.Cells["colProductID"].Value.ToString();
            //          SO.POQty = Convert.ToInt32( item.Cells["colQuantity"].Value.ToString());
            //          SO.POPrice = Convert.ToInt32(item.Cells["colPrice"].Value.ToString());
            //          W.WHName = item.Cells["colWHName"].Value.ToString();
            //          DataTable tblWH = new DataTable();
            //          tblWH = W.CallWarehouseID();
            //          SO.WHID = tblWH.Rows[0][0].ToString();
            //      }

            //}


        }
        #endregion

        #region Savecheck
        private bool savecheck()
        {
            string PIDCheck = dgvSalesOrder.Rows[0].Cells["colProductID"].Value.ToString();
            if (cboCustomerName.SelectedIndex == -1 && PIDCheck == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCustomerName.Focus();
                return false;
            }
            else if (cboCustomerName.SelectedIndex != -1 && PIDCheck == "")
            {
                MessageBox.Show("Please fill at least One Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProductName.Focus();
                return false;
            }
            else if (cboCustomerName.SelectedIndex == -1 && PIDCheck != "")
            {
                MessageBox.Show("Please choose Customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCustomerName.Focus();
                return false;
            }
            else
            {

                return true;

            }
        }
        #endregion

        #region Save
        private void save()
        {
            if (savecheck())
            {
                //dataassign();
                if (SO.IsEdit == true)
                {
                    SO.SOID = int.Parse(txtSOID.Text.ToString());
                    SO.SODepositAmount = int.Parse(txtDeposit.Text.Trim());
                    SO.FirstPayement = int.Parse(txtFirstPayment.Text.Trim());
                    SO.AmendmentPayment = int.Parse(txtAmendmentPayment.Text.Trim());
                    SO.SORemark = txtRemark.Text.Trim();
                    SO.Update_Order();

                   //SO.IsEdit = false;
                }
                else
                {
                    SO = new Class.clsSalesOrder();
                    int SOID = int.Parse(txtSOID.Text.Trim());
                    DateTime date = dtpDate.Value;
                    DateTime deliverydate = dtpDeliveryDate.Value;
                    string description = txtDescription.Text.ToString();
                    string createdeid = EID.ToString();
                    string customer = cboCustomerName.SelectedValue.ToString();
                    string remark = txtRemark.Text.ToString();
                    int depositamt;
                    int fpayment;
                    int amendmentpayment;

                    if (txtDeposit.Text == "")
                    {
                        depositamt = 0;
                    }
                    else
                    {
                        depositamt = Convert.ToInt32(txtDeposit.Text.ToString());
                    }
                    if (txtFirstPayment.Text == "")
                    {
                        fpayment = 0;
                    }
                    else
                    {
                        fpayment = Convert.ToInt32(txtFirstPayment.Text.ToString());
                    }
                    if (txtAmendmentPayment.Text == "")
                    {
                        amendmentpayment = 0;
                    }
                    else
                    {
                        amendmentpayment = Convert.ToInt32(txtAmendmentPayment.Text.ToString());
                    }


                    foreach (DataGridViewRow item in dgvSalesOrder.Rows)
                    {
                        if (item.Cells[0].Value == null)
                        {
                        }
                        else
                        {
                            string productID = item.Cells[0].Value.ToString();
                            string quantity = item.Cells[2].Value.ToString();
                            string sellprice = item.Cells[4].Value.ToString();
                            //string currencycode = item.Cells[5].Value.ToString();

                            SO = new Class.clsSalesOrder()
                            {
                                SOID = SOID,
                                SODate = date,
                                CID = customer,
                                CreatedEID = createdeid,
                                SODescription = description,
                                SODepositAmount = depositamt,
                                FirstPayement = fpayment,
                                AmendmentPayment = amendmentpayment,
                                SORemark = remark,
                                SOCancelDate = Convert.ToDateTime("01/01/1900"),
                                SODeliveryDate = deliverydate,
                                PID = productID,
                                SOQty = int.Parse(quantity),
                                SOStatus = 0
                            };

                            Inv = new Class.clsInventory()
                            {
                                WHID = "1",
                                PID = productID,
                                PQty = int.Parse(quantity)
                            };
                            
                            SO.Ins_SO_Detail();
                            Inv.Decre_Inventory();
                            SO.IsEdit = false;
                        }
                    }
                    SO.Ins_Sales_Order();
                }
               // Loading();
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

      

        private void ProductComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                P.PLID = cboProductLine.SelectedValue.ToString();
                tbl = P.CallProductForPL();
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

        private void ProductLineComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = pl.CallProduct_Line();
                cboProductLine.DataSource = tbl;
                cboProductLine.DisplayMember = "PLName";
                cboProductLine.ValueMember = "PLID";
                cboProductLine.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        #endregion


        #region Search
        private void Search()
        {
            if (chkSSalesOrderID.Checked != true && chkSDate.Checked != true && chkSCustomerName.Checked != true && chkSDebitPay.Checked != true && chkSCreditPay.Checked != true && chkSCancelOrders.Checked != true)
            {
                MessageBox.Show("Please choose at least one search Parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSSalesOrderID.Focus();
            }
            else if (chkSSalesOrderID.Checked == true && chkSDate.Checked != true && chkSCustomerName.Checked != true && chkSDebitPay.Checked != true && chkSCreditPay.Checked != true && chkSCancelOrders.Checked != true)
            {
                if (txtSSalesOrderID.Text == "")
                {
                    MessageBox.Show("Please fill SOID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSSalesOrderID.Focus();
                }
                else
                {
                    searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = SO.Search_Sales_Order();
                    dgvSSalesOrder.DataSource = tbl;
                }

            }
            else if (chkSSalesOrderID.Checked != true && chkSDate.Checked == true && chkSCustomerName.Checked != true && chkSDebitPay.Checked != true && chkSCreditPay.Checked != true && chkSCancelOrders.Checked != true)
            {
                searchdataassign();
                DataTable tbl = new DataTable();
                tbl = SO.Search_Sales_Order();
                dgvSSalesOrder.DataSource = tbl;
            }
            else if (chkSSalesOrderID.Checked != true && chkSDate.Checked != true && chkSCustomerName.Checked == true && chkSDebitPay.Checked != true && chkSCreditPay.Checked != true && chkSCancelOrders.Checked != true)
            {
                if (txtSCustomerName.Text == "")
                {
                    MessageBox.Show("Please type Customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSCustomerName.Focus();
                }
                else
                {
                    searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = SO.Search_Sales_Order();
                    dgvSSalesOrder.DataSource = tbl;
                }
            }
            else if (chkSSalesOrderID.Checked != true && chkSDate.Checked != true && chkSCustomerName.Checked != true && chkSDebitPay.Checked == true && chkSCreditPay.Checked != true && chkSCancelOrders.Checked != true)
            {

                searchdataassign();
                DataTable tbl = new DataTable();
                tbl = SO.Search_Sales_Order();
                dgvSSalesOrder.DataSource = tbl;

            }
            else if (chkSSalesOrderID.Checked != true && chkSDate.Checked != true && chkSCustomerName.Checked != true && chkSDebitPay.Checked != true && chkSCreditPay.Checked == true && chkSCancelOrders.Checked != true)
            {

                searchdataassign();
                DataTable tbl = new DataTable();
                tbl = SO.Search_Sales_Order();
                dgvSSalesOrder.DataSource = tbl;

            }
            else if (chkSSalesOrderID.Checked != true && chkSDate.Checked != true && chkSCustomerName.Checked != true && chkSDebitPay.Checked != true && chkSCreditPay.Checked != true && chkSCancelOrders.Checked == true)
            {

                searchdataassign();
                DataTable tbl = new DataTable();
                tbl = SO.Search_Sales_Order();
                dgvSSalesOrder.DataSource = tbl;

            }
        }

        private void ShowAll()
        {
            showalldataassign();
            DataTable tbl = new DataTable();
            tbl = SO.Search_Sales_Order();
            dgvSSalesOrder.DataSource = tbl;
        }

        #endregion

        #region SearchCheckboxValidation
        private void SearchCheckboxValidation()
        {
            if (chkSSalesOrderID.Checked == true)
            {
                txtSSalesOrderID.Enabled = true;
            }
            else
            {
                txtSSalesOrderID.Enabled = false;
            }

            if (chkSDate.Checked == true)
            {
                dtpSFromDate.Enabled = true;
                dtpSToDate.Enabled = true;
            }
            else
            {
                dtpSFromDate.Enabled = false;
                dtpSToDate.Enabled = false;
            }

            if (chkSCustomerName.Checked == true)
            {
                txtSCustomerName.Enabled = true;
                CustomerComboBind();
            }
            else
            {
                txtSCustomerName.Enabled = false;
            }
        }
        #endregion

        #region GridClick
        private void gridclick()
        {

            Loading();
            M.Button_Enable(true, btnNew, btnEdit, btnCancel);
        }
        #endregion

        #region FillProductInfo
        private void FillProductInfo(string PID)
        {

            try
            {
                DataTable ptbl = new DataTable();
                pos = new Class.clsPOS();
                SO.PID = cboProductName.SelectedValue.ToString();
                ptbl = SO.PolpulateProductInfo(PID);
                string currency = ptbl.Rows[0][0].ToString();
                long price = long.Parse(ptbl.Rows[0][1].ToString());
                string productID = ptbl.Rows[0][2].ToString();
                int qty = int.Parse(txtQuantity.Text.ToString().Trim());

                pos.WHID = 1;
                pos.SPID = int.Parse(productID);
                int? invQty = pos.SEL_PQty();

                if (invQty < qty)
                {
                    MessageBox.Show("Plz check Quantity in the Store", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                foreach (DataGridViewRow item in dgvSalesOrder.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        if (item.Cells[0].Value.ToString().Equals(productID))
                        {
                            qty = int.Parse (txtQuantity.Text.Trim());
                            dgvSalesOrder.Rows.RemoveAt(item.Index);
                        }
                    }
                }

                string unit = ptbl.Rows[0][3].ToString();
                long total = price * qty;

                object[] row = new object[] 
                {
                    productID,
                    cboProductName.Text,
                    qty,
                    unit,
                    price,
                    currency,
                    //"0",
                    //"0",
                    total
                };
                dgvSalesOrder.Rows.Add(row);

                this.PolpulatePaymentInfo();

                M = new Class.clsMethods();
                M.TextBox_Clear(txtQuantity);
                M.Combobox_Clear(cboProductLine, cboProductName);
                cboProductLine.Focus();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                ProductComboBind();
                cboProductName.Focus();
            }
        }
        #endregion

        #region PopulatePaymentInfo
        private void PolpulatePaymentInfo()
        {
            this.SubTotal = 0;
            foreach (DataGridViewRow item in dgvSalesOrder.Rows)
            {
                if (item.Cells[6].Value != null)
                {
                    SubTotal += int.Parse(item.Cells[6].Value.ToString());
                }
            }

            txtSubTotal.Text = SubTotal.ToString();
            int taxAmt = this.pos.SEL_Tax();
            int scAmt = this.pos.SEL_ServiceCharges();
            ServiceCharnge = scAmt;

            long tax = (SubTotal / 100) * taxAmt;
            Tax = int.Parse(tax.ToString());
            txtTax.Text = Tax.ToString();

            txtServiceCharges.Text = scAmt.ToString();

            GrandTotal = SubTotal + Tax + ServiceCharnge;

            txtGrandTotal.Text = GrandTotal.ToString();

            
            txtDeposit.Text = "0";
            txtFirstPayment.Text = "0";
            txtAmendmentPayment.Text = "0";
            txtCreditAmount.Text = txtGrandTotal.Text;
        }


        private void PolpulatePaymentInfoEdit()
        {
            this.SubTotal = 0;
            foreach (DataGridViewRow item in dgvSalesOrder.Rows)
            {
                if (item.Cells[6].Value != null)
                {
                    SubTotal += int.Parse(item.Cells[6].Value.ToString());
                }
            }

            txtSubTotal.Text = SubTotal.ToString();
            int taxAmt = this.pos.SEL_Tax();
            int scAmt = this.pos.SEL_ServiceCharges();
            ServiceCharnge = scAmt;

            long tax = (SubTotal / 100) * taxAmt;
            Tax = int.Parse(tax.ToString());
            txtTax.Text = Tax.ToString();

            txtServiceCharges.Text = scAmt.ToString();

            GrandTotal = SubTotal + Tax + ServiceCharnge;

            txtGrandTotal.Text = GrandTotal.ToString();
        }


        #endregion

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

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();

            if (SO.IsEdit)
            {

                SO.SOID = int.Parse(txtSOID.Text.Trim());
                DataTable iso = new DataTable();
                iso = SO.Call_SOInvoicebySOID();
                SO.InvoiceNo = int.Parse(iso.Rows[0][0].ToString());
                DateTime date = System.DateTime.Now;
                //int grandTotal = int.Parse(txtGrandTotal.Text.ToString());
                //int deposit = int.Parse(txtDeposit.Text.ToString());
                //int firstp = int.Parse(txtFirstPayment.Text.Trim());
                //int amendp = int.Parse(txtAmendmentPayment.Text.Trim());
                int credit = int.Parse(txtCreditAmount.Text.Trim());

                SO.InvoiceDate = DateTime.Now;
                //SO.SubTotal = this.SubTotal;
                //SO.MemberPromotion = 0;
                //SO.TaxAmount = this.Tax;
                //SO.ServiceChargeAmount = this.ServiceCharnge;
                //SO.GrandTotal = this.GrandTotal;
                //SO.SODepositAmount = deposit;
                //SO.FirstPayement = firstp;
                //SO.AmendmentPayment = amendp;
                SO.CreditAmount = credit;


                SO.Update_Invoice();
                SO.IsEdit = false;
                btnCash.Enabled = true;
                btnCash.Focus();

            }
            else
            {

                ////int grandTotal = int.Parse(txtGrandTotal.Text.ToString());
                int deposit = int.Parse(txtDeposit.Text.ToString());
                int firstp = int.Parse(txtFirstPayment.Text.Trim());
                int amendp = int.Parse(txtAmendmentPayment.Text.Trim());
                int credit = int.Parse(txtCreditAmount.Text.Trim());

                //long cashAmount = long.Parse(txtCashAmount.Text.ToString());
                //long changeAmount = 0;
                //if (cashAmount < grandTotal)
                //{
                //    MessageBox.Show("Please check Cash Amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.txtCashAmount.Focus();
                //    return;
                //}
                //else changeAmount = cashAmount - grandTotal;

                //txtChange.Text = changeAmount.ToString();
                //btnCash.Enabled = true;

                Class.clsSalesOrder so = new Class.clsSalesOrder();
                so.InvoiceNo = so.AutoID_Invoice();
                // this.ChangeAmount = int.Parse(txtChange.Text.ToString());
                //this.CashAmount = int.Parse(txtCashAmount.Text.ToString());

                so.InvoiceDate = DateTime.Now;
                so.SubTotal = this.SubTotal;
                so.MemberPromotion = 0;
                so.TaxAmount = this.Tax;
                so.ServiceChargeAmount = this.ServiceCharnge;
                so.GrandTotal = this.GrandTotal;
                so.SODepositAmount = deposit;
                so.FirstPayement = firstp;
                so.AmendmentPayment = amendp;
                so.CreditAmount = credit;

                // so.CreditAmount = 
                //so.CashAmount = this.CashAmount;
                // this.clsPOS.ChangeAmount = this.ChangeAmount;
                
                so.Ins_Invoice();

                foreach (DataGridViewRow item in dgvSalesOrder.Rows)
                {
                    if (item.Cells[0].Value == null)
                    {
                    }
                    else
                    {
                        string productID = item.Cells[0].Value.ToString();
                        string quantity = item.Cells[2].Value.ToString();
                        string productAmount = item.Cells[4].Value.ToString();
                        string productTotalAmt = item.Cells[6].Value.ToString();

                        so.SOID = int.Parse(txtSOID.Text.ToString());
                        so.SOQty = int.Parse(quantity);
                        so.PID = productID;
                        so.PTotalAmount = int.Parse(productTotalAmt);
                        so.ProductAmount = int.Parse(productAmount);


                        so.Ins_InvoiceDetail();
                    }
                }
                txtInvoiceNo.Text = so.InvoiceNo.ToString();

                //so.TID = this.cboTableNo.SelectedValue.ToString();
                //so.SOID = int.Parse(txtSOID.Text.Trim());
                DataTable dt = so.SEL_SOPrint();

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
                M.TextBox_Enable(false, txtDeposit, txtRemark, txtFirstPayment, txtAmendmentPayment);
                btnCash.Enabled = true;
                btnCash.Focus();

            }
        }

        private void cboProductLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductLine.SelectedIndex != -1)
            {
                cboProductName.Enabled = true;
                P.PLID = cboProductLine.SelectedValue.ToString();
                ProductComboBind();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            SearchPanelLoading();
            SearchCheckboxValidation();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtDescription, txtQuantity);
            M.Button_Enable(false, btnNew, btnDelete, btnEdit);
            M.Button_Enable(true, btnSave, btnCancel, btnAdd, btnCustomer, btnProductLine, btnProductName);
            M.TextBox_Clear(txtSOID, txtInvoiceNo, txtDescription, txtQuantity, txtDeposit, txtFirstPayment, txtAmendmentPayment, txtRemark, txtSubTotal, txtMemberPromotion, txtMemberPromotionPercentage, txtTax, txtServiceCharges, txtGrandTotal, txtCreditAmount);
            M.Combobox_Enable(true, cboProductLine, cboCustomerName);
            lblNRCShow.Visible = false;
            lblNRC.Visible = false;
            lblMembershipShow.Visible = false;
            lblMembership.Visible = false;
            lblCustomerType.Visible = false;
            lblCustomerTypeShow.Visible = false;
            rdbDebitPay.Enabled = true;
            rdbCreditPay.Enabled = true;
            dtpDate.Enabled = true;
            dtpDeliveryDate.Enabled = true;
            DataTable tblautoid = new DataTable();
            tblautoid = SO.AutoID_Sales_Order();
            txtSOID.Text = tblautoid.Rows[0][0].ToString();
            CustomerComboBind();
            ProductLineComboBind();
            // cboCustomerName.SelectedIndex = -1;
            //cboProductLine.SelectedIndex = -1;

            GridDataClear();
            dgvSalesOrder.Enabled = true;
            dtpDate.Focus();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    string productID = cboProductName.SelectedValue.ToString();
                    this.FillProductInfo(productID);
                    if (txtAmendmentPayment.Text == "" && txtCreditAmount.Text == "" && txtFirstPayment.Text == "" && txtDeposit.Text == "")
                    {
                        txtAmendmentPayment.Text = "0";
                        txtCreditAmount.Text = "0";
                        txtFirstPayment.Text = "0";
                        txtDeposit.Text = "0";
                        
                    }
                    else
                    {
 
                    }
                    
                }
                catch (Exception ep)
                {
                    MessageBox.Show(ep.Message.ToString());
                }
            }
        }
        int rowIndex = 0;

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvSalesOrder.Rows.RemoveAt(rowIndex);
        }

        private void dgvSalesOrder_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvSalesOrder.Rows[e.RowIndex].Selected = true;
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
            
        }

        private void frmSalesOrder_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string productID = cboProductName.SelectedValue.ToString();
                this.FillProductInfo(productID);
                if (txtAmendmentPayment.Text == "" && txtCreditAmount.Text == "" && txtFirstPayment.Text == "" && txtDeposit.Text == "")
                {
                    txtAmendmentPayment.Text = "0";
                    txtCreditAmount.Text = "0";
                    txtFirstPayment.Text = "0";
                    txtDeposit.Text = "0";
                }
                else
                {

                }

            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message.ToString());
            }
        }

        private void cboCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpDeliveryDate.Focus();

            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboProductLine.Focus();

            }
        }

        private void cboProductLine_KeyPress(object sender, KeyPressEventArgs e)
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

        private void chkCreditPay_CheckedChanged(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtDeposit, txtFirstPayment, txtAmendmentPayment, txtRemark);


            txtDeposit.Focus();
        }

        private void chkDebitPay_CheckedChanged(object sender, EventArgs e)
        {

            M.TextBox_Enable(true, txtAmendmentPayment);
            M.TextBox_Enable(false, txtDeposit, txtFirstPayment);
            txtAmendmentPayment.Focus();
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtDeposit.Text == "")
                {
                    txtDeposit.Text = "0";
                }
                else
                {
                    int gt = int.Parse(txtGrandTotal.Text.Trim());
                    int dep = int.Parse(txtDeposit.Text.Trim());
                    txtCreditAmount.Text = (gt - dep).ToString();
                    txtAmendmentPayment.Text = "0";
                    txtFirstPayment.Text = "0";
                    txtFirstPayment.Focus();
                   
                }
            }

        }

        private void txtFirstPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtFirstPayment.Text == "")
                {
                    txtFirstPayment.Text = "0";
                }
                else
                {
                    int gt = int.Parse(txtGrandTotal.Text.Trim());
                    int dep = int.Parse(txtDeposit.Text.Trim());
                    int fp = int.Parse(txtFirstPayment.Text.Trim());
                    txtCreditAmount.Text = (gt - (dep + fp)).ToString();
                    txtAmendmentPayment.Text = "0";
                    txtAmendmentPayment.Focus();
                }
            }
        }

        private void txtAmendmentPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtAmendmentPayment.Text == "")
                {
                    txtAmendmentPayment.Text = "0";
                }
                else
                {
                    int gt = int.Parse(txtGrandTotal.Text.Trim());
                    int dep = int.Parse(txtDeposit.Text.Trim());
                    int fp = int.Parse(txtFirstPayment.Text.Trim());
                    int ap = int.Parse(txtAmendmentPayment.Text.Trim());
                    int pc = gt - (dep + fp + ap);
                    if (pc < 0)
                    {
                        MessageBox.Show("Payment is greater than Grand Total!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtCreditAmount.Text = (gt - (dep + fp + ap)).ToString();
                        txtRemark.Focus();
                    }
                    
                    
                    
                }
            }
        }

        private void txtRemark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                save();

                if (SO.IsEdit)
                {

                    SO.SOID = int.Parse(txtSOID.Text.Trim());
                    DataTable iso = new DataTable();
                    iso = SO.Call_SOInvoicebySOID();
                    SO.InvoiceNo = int.Parse(iso.Rows[0][0].ToString());
                    DateTime date = System.DateTime.Now;
                    //int grandTotal = int.Parse(txtGrandTotal.Text.ToString());
                    //int deposit = int.Parse(txtDeposit.Text.ToString());
                    //int firstp = int.Parse(txtFirstPayment.Text.Trim());
                    //int amendp = int.Parse(txtAmendmentPayment.Text.Trim());
                    int credit = int.Parse(txtCreditAmount.Text.Trim());

                    SO.InvoiceDate = DateTime.Now;
                    //SO.SubTotal = this.SubTotal;
                    //SO.MemberPromotion = 0;
                    //SO.TaxAmount = this.Tax;
                    //SO.ServiceChargeAmount = this.ServiceCharnge;
                    //SO.GrandTotal = this.GrandTotal;
                    //SO.SODepositAmount = deposit;
                    //SO.FirstPayement = firstp;
                    //SO.AmendmentPayment = amendp;
                    SO.CreditAmount = credit;


                    SO.Update_Invoice();
                    SO.IsEdit = false;
                    btnCash.Enabled = true;
                    btnCash.Focus();

                }
                else
                {

                    ////int grandTotal = int.Parse(txtGrandTotal.Text.ToString());
                    int deposit = int.Parse(txtDeposit.Text.ToString());
                    int firstp = int.Parse(txtFirstPayment.Text.Trim());
                    int amendp = int.Parse(txtAmendmentPayment.Text.Trim());
                    int credit = int.Parse(txtCreditAmount.Text.Trim());

                    //long cashAmount = long.Parse(txtCashAmount.Text.ToString());
                    //long changeAmount = 0;
                    //if (cashAmount < grandTotal)
                    //{
                    //    MessageBox.Show("Please check Cash Amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    this.txtCashAmount.Focus();
                    //    return;
                    //}
                    //else changeAmount = cashAmount - grandTotal;

                    //txtChange.Text = changeAmount.ToString();
                    //btnCash.Enabled = true;

                    Class.clsSalesOrder so = new Class.clsSalesOrder();
                    so.InvoiceNo = so.AutoID_Invoice();
                    // this.ChangeAmount = int.Parse(txtChange.Text.ToString());
                    //this.CashAmount = int.Parse(txtCashAmount.Text.ToString());

                    so.InvoiceDate = DateTime.Now;
                    so.SubTotal = this.SubTotal;
                    so.MemberPromotion = 0;
                    so.TaxAmount = this.Tax;
                    so.ServiceChargeAmount = this.ServiceCharnge;
                    so.GrandTotal = this.GrandTotal;
                    so.SODepositAmount = deposit;
                    so.FirstPayement = firstp;
                    so.AmendmentPayment = amendp;
                    so.CreditAmount = credit;

                    // so.CreditAmount = 
                    //so.CashAmount = this.CashAmount;
                    // this.clsPOS.ChangeAmount = this.ChangeAmount;

                    so.Ins_Invoice();

                    foreach (DataGridViewRow item in dgvSalesOrder.Rows)
                    {
                        if (item.Cells[0].Value == null)
                        {
                        }
                        else
                        {
                            string productID = item.Cells[0].Value.ToString();
                            string quantity = item.Cells[2].Value.ToString();
                            string productAmount = item.Cells[4].Value.ToString();
                            string productTotalAmt = item.Cells[6].Value.ToString();

                            so.SOID = int.Parse(txtSOID.Text.ToString());
                            so.SOQty = int.Parse(quantity);
                            so.PID = productID;
                            so.PTotalAmount = int.Parse(productTotalAmt);
                            so.ProductAmount = int.Parse(productAmount);


                            so.Ins_InvoiceDetail();
                        }
                    }
                    txtInvoiceNo.Text = so.InvoiceNo.ToString();

                    //so.TID = this.cboTableNo.SelectedValue.ToString();
                    //so.SOID = int.Parse(txtSOID.Text.Trim());
                    DataTable dt = so.SEL_SOPrint();

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
                    M.TextBox_Enable(false, txtDeposit, txtRemark, txtFirstPayment, txtAmendmentPayment);
                    btnCash.Enabled = true;
                    btnCash.Focus();

                }
            }
        }
        private void rdbCreditPay_CheckedChanged(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtDeposit, txtFirstPayment, txtAmendmentPayment, txtRemark);
            btnCash.Enabled = true;

            txtDeposit.Focus();
        }

        private void rdbDebitPay_CheckedChanged(object sender, EventArgs e)
        {

            M.TextBox_Enable(false, txtDeposit, txtFirstPayment);
            txtAmendmentPayment.Text = txtGrandTotal.Text;
            txtRemark.Focus();
            btnCash.Enabled = true;
        }

        private void dtpDeliveryDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDescription.Focus();

            }
        }

        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            SO.SOCancelDate = System.DateTime.Now;
            SO.SOID = int.Parse(txtSOID.Text.Trim());
            SO.SOStatus = '2';
            SO.Cancel_Sales_Order();
        }

        private void dgvSSalesOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridclick();
                txtSOID.Text = dgvSSalesOrder.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                dtpDate.Text = dgvSSalesOrder.Rows[e.RowIndex].Cells["Order Date"].Value.ToString();
                dtpDeliveryDate.Text =  dgvSSalesOrder.Rows[e.RowIndex].Cells["Delivery Date"].Value.ToString();
                txtGrandTotal.Text = dgvSSalesOrder.Rows[e.RowIndex].Cells["Total Amount"].Value.ToString();

                txtDeposit.Text = dgvSSalesOrder.Rows[e.RowIndex].Cells["Deposit"].Value.ToString();
                txtFirstPayment.Text = dgvSSalesOrder.Rows[e.RowIndex].Cells["First Payment"].Value.ToString();
                txtAmendmentPayment.Text = dgvSSalesOrder.Rows[e.RowIndex].Cells["Amendment Payment"].Value.ToString();
                txtCreditAmount.Text = dgvSSalesOrder.Rows[e.RowIndex].Cells["Credit Amount"].Value.ToString();
                txtRemark.Text = dgvSSalesOrder.Rows[e.RowIndex].Cells["Remark"].Value.ToString();

                CustomerComboBind();
                C.CName = dgvSSalesOrder.Rows[e.RowIndex].Cells["Customer Name"].Value.ToString();
                DataTable tblCus = new DataTable();
                tblCus = C.CallCustomerIDbyName();
                cboCustomerName.SelectedValue = tblCus.Rows[0][0].ToString();

                SO.SOID = int.Parse(dgvSSalesOrder.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                DataTable tblSOP = new DataTable();
                tblSOP = SO.CallProductbySO();


                dgvSalesOrder.AutoGenerateColumns = false;
                dgvSalesOrder.Columns[0].Name = "colProductID";
                dgvSalesOrder.Columns[0].HeaderText = "Product ID";
                dgvSalesOrder.Columns[0].DataPropertyName = "PID";

                dgvSalesOrder.Columns[1].Name = "colProductName";
                dgvSalesOrder.Columns[1].HeaderText = "Product Name";
                dgvSalesOrder.Columns[1].DataPropertyName = "PName";

                dgvSalesOrder.Columns[2].Name = "colQuantity";
                dgvSalesOrder.Columns[2].HeaderText = "Quantity";
                dgvSalesOrder.Columns[2].DataPropertyName = "SOQty";

                dgvSalesOrder.Columns[3].Name = "colUOM";
                dgvSalesOrder.Columns[3].HeaderText = "Unit";
                dgvSalesOrder.Columns[3].DataPropertyName = "UOMName";


                dgvSalesOrder.Columns[4].Name = "colPrice";
                dgvSalesOrder.Columns[4].HeaderText = "Price";
                dgvSalesOrder.Columns[4].DataPropertyName = "Price";


                dgvSalesOrder.Columns[5].Name = "colCurrency";
                dgvSalesOrder.Columns[5].HeaderText = "Currency";
                dgvSalesOrder.Columns[5].DataPropertyName = "Currency";

                dgvSalesOrder.Columns[6].Name = "colAmount";
                dgvSalesOrder.Columns[6].HeaderText = "Amount";
                dgvSalesOrder.Columns[6].DataPropertyName = "Amount";



                this.dgvSalesOrder.DataSource = tblSOP;
                PolpulatePaymentInfoEdit();
                tbcSalesOrder.SelectedTab = tbpSalesOrder;
            }


        }

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnSShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
            dgvSSalesOrder.Enabled = true;
            
            SearchCheckboxValidation();
            M.Checkbox_Checked(false, chkSDate, chkSCreditPay, chkSDebitPay, chkSCancelOrders, chkSCustomerName);
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
            Search();
            dgvSSalesOrder.Enabled = true;
        }

        private void dgvSalesOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtQuantity.Text = dgvSalesOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
            ProductLineComboBind();
            
            SO.PID = dgvSalesOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            DataTable plptbl = new DataTable();
            plptbl = SO.Call_PLandPbyPID();
            
            cboProductLine.SelectedValue = plptbl.Rows[0][0].ToString();
            P.PLID = cboProductLine.SelectedValue.ToString();
            ProductComboBind();
            cboProductName.SelectedValue = dgvSalesOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            cboProductLine.Enabled = false;
            cboProductName.Enabled = false;
            txtQuantity.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SO.IsEdit = true;
            M.Combobox_Enable(false, cboProductLine, cboProductName);
            M.Button_Enable(true, btnSave, btnCancel, btnDelete);
            M.Button_Enable(false, btnNew);
            txtRemark.Enabled = true;
          

            int deposit = int.Parse(txtDeposit.Text.Trim());
            int fp = int.Parse(txtFirstPayment.Text.Trim());
            int ap = int.Parse(txtAmendmentPayment.Text.Trim());

            if (deposit == 0 && fp == 0 && ap == 0)
            {
                rdbCreditPay.Enabled = true;
                rdbDebitPay.Enabled = true;
                rdbDebitPay.Checked = false;
                rdbCreditPay.Checked = false;
                rdbCreditPay.Focus();
               
            }
            else if (deposit >= 0 && fp == 0 && ap == 0)
            {
                rdbCreditPay.Enabled = false;
                rdbDebitPay.Enabled = false;
                rdbDebitPay.Checked = false;
                rdbCreditPay.Checked = true;
                txtDeposit.Enabled = false;
                txtFirstPayment.Enabled = true;
                txtAmendmentPayment.Enabled = true;
                txtFirstPayment.Focus();
            }
            else if (deposit >= 0 && fp >= 0 && ap == 0)
            {
                rdbCreditPay.Enabled = false;
                rdbDebitPay.Enabled = false;
                rdbDebitPay.Checked = false;
                rdbCreditPay.Checked = true;
                txtDeposit.Enabled = false;
                txtFirstPayment.Enabled = false;
                txtAmendmentPayment.Enabled = true;
                txtAmendmentPayment.Focus();
            }
            else if (deposit >= 0 && fp >= 0 && ap >= 0)
            {
                txtDeposit.Enabled = false;
                txtFirstPayment.Enabled = false;
                txtAmendmentPayment.Enabled = false;
                txtRemark.Focus();    
            }

            
            
            
        }

        private void chkSSalesOrderID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSSalesOrderID.Checked == true)
            {
                txtSSalesOrderID.Enabled = true;
            }
            else
            {
                txtSSalesOrderID.Enabled = false;
            }
        }

        private void chkSCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSCustomerName.Checked == true)
            {
                txtSCustomerName.Enabled = true;
            }
            else
            {
                txtSCustomerName.Enabled = false;
            }
        }

        private void chkSDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSDate.Checked == true)
            {
                dtpSFromDate.Enabled = true;
                dtpSToDate.Enabled = true;
            }
            else
            {
                dtpSFromDate.Enabled = false;
                dtpSToDate.Enabled = false; 
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvSalesOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboCustomerName.Focus();
            }
        }
    }
}
