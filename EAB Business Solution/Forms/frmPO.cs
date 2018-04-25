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

namespace EAB_Business_Solution.Forms
{
    public partial class frmPO : Form
    {

        Class.clsPO PO = new Class.clsPO();
        Class.clsInventory Inv = new Class.clsInventory();
        Class.clsMethods M = new Class.clsMethods();
        Class.clsSupplier Sup = new Class.clsSupplier();
        Class.clsWarehouse W = new Class.clsWarehouse();
        Class.clsProduct P = new Class.clsProduct();
        Class.clsUOM UOM = new Class.clsUOM();
        Class.clsUserLevel UL = new Class.clsUserLevel();
        DataTable dt;
        public string EID;
        public string CompID;
        public long SubTotal { get; set; }
        public long GrandTotal { get; set; }
        public string ULID;        
        public frmPO()
        {
            InitializeComponent();
            Loading();

        }

        #region Methods

        #region Loading
        private void Loading()
        {
            M.TextBox_Enable(false, txtPOID, txtDescription, txtQuantity, txtPrice, txtTotal, txtDepositAmount, txtFirstPayment, txtAmendmentPayment, txtCreditAmount, txtRemark);
            M.Button_Enable(true, btnNew);
            M.Button_Enable(false, btnSave, btnEdit, btnDelete, btnCancel, btnPrint, btnAdd, btnSupplier, btnProduct, btnUOM);
            M.TextBox_Clear(txtPOID, txtDescription, txtQuantity, txtPrice, txtTotal, txtDepositAmount, txtFirstPayment, txtAmendmentPayment, txtCreditAmount, txtRemark);
            M.DateTimePicker_Enable(false, dtpDate);
            M.DataGridView_Enable(false, dgvProductInfo);
            M.Combobox_Enable(false, cboProductName, cboSupplier, cboUOM);
            M.Checkbox_Checked(false, chkAccept, chkReject);
            M.CheckBox_Enable(false, chkAccept, chkReject);
            cboSupplier.SelectedIndex = -1;
            GridDataClear();
            btnNew.Focus();

        }
        #endregion


        #region GridDataClear
        private void GridDataClear()
        {
            if (this.dgvProductInfo.DataSource != null)
            {
                this.dgvProductInfo.DataSource = null;
            }
            else
            {
                this.dgvProductInfo.Rows.Clear();
            }
        }

        private void SearchGridDataClear()
        {
            if (this.dgvSPurchaseOrder.DataSource != null)
            {
                this.dgvSPurchaseOrder.DataSource = null;
            }
            else
            {
                this.dgvSPurchaseOrder.Rows.Clear();
            }
        }
        #endregion

        #region SearchPanelLoading
        private void SearchPanelLoading()
        {
            M.Checkbox_Checked(false, chkSPurchaseOrderID, chkSStatus, chkSSupplier, chkSDate);
            M.CheckBox_Enable(false, chkSPurchaseOrderID, chkSStatus);
            SupplierComboBind();
            SearchCheckboxValidation();
            GridDataClear();
            M.DataGridView_Enable(false, dgvSPurchaseOrder);
        }
        #endregion

        #region SearchDataassign
        private void searchdataassign()
        {
            if (chkSPurchaseOrderID.Checked == false)
            {
                PO.POID = 0;
            }
            else
            {
                PO.POID = Convert.ToInt32(txtSPOID.Text.ToString());
            }
            if (chkSDate.Checked == false)
            {
                PO.FromDate = Convert.ToDateTime("01/01/1900");
                PO.ToDate = Convert.ToDateTime("01/01/1900");
            }
            else
            {
                PO.FromDate = dtpSFromDate.Value;
                PO.ToDate = dtpSToDate.Value;
            }

            if (chkSSupplier.Checked == false)
            {
                PO.SID = "";
            }
            else
            {
                PO.SID = cboSSupplier.SelectedValue.ToString();
            }
            if (chkSStatus.Checked == false)
            {
                PO.Status = -1;
            }
            else
            {
                PO.Status = Convert.ToInt32(cboSStatus.SelectedValue.ToString());
            }
        }
        #endregion

        #region ShowallDataassign
        private void showalldataassign()
        {
            PO.POID = 0;
            PO.FromDate = Convert.ToDateTime("01/01/1900");
            PO.ToDate = Convert.ToDateTime("01/01/1900");
            PO.SID = "";
            PO.Status = -1;
        }
        #endregion

        #region Dataassign
        private void dataassign()
        {



            // PO.POID = Convert.ToInt32( txtPOID.Text.ToString());
            // PO.PODate = dtpDate.Value;
            // PO.PODescription = txtDescription.Text.ToString();
            // PO.RequestedEID = EID.ToString();
            // PO.ApprovedEID = EID.ToString();
            // PO.ApprovedDate = System.DateTime.Now;
            // PO.SID = cboSupplier.SelectedValue.ToString();
            // if (txtDepositAmount.Text == "")
            // {
            //     PO.DepositAmount = 0;
            // }
            // else
            // {
            //     PO.DepositAmount = Convert.ToInt32(txtDepositAmount.Text.ToString());
            // }
            // if (txtFirstPayment.Text == "")
            // {
            //     PO.FirstPayment = 0;
            // }
            // else
            // {
            //     PO.FirstPayment = Convert.ToInt32(txtFirstPayment.Text.ToString());
            // }
            // if (txtAmendmentPayment.Text == "")
            // {
            //     PO.AmendmentPayment = 0;
            // }
            // else
            // {
            //     PO.AmendmentPayment = Convert.ToInt32(txtAmendmentPayment.Text.ToString());
            // }
            // foreach (DataGridViewRow item in dgvProductInfo.Rows)
            // {
            //     { 
            //          PO.PID = item.Cells["colProductID"].Value.ToString();
            //          PO.POQty = Convert.ToInt32( item.Cells["colQuantity"].Value.ToString());
            //          PO.POPrice = Convert.ToInt32(item.Cells["colPrice"].Value.ToString());
            //          W.WHName = item.Cells["colWHName"].Value.ToString();
            //          DataTable tblWH = new DataTable();
            //          tblWH = W.CallWarehouseID();
            //          PO.WHID = tblWH.Rows[0][0].ToString();
            //      }

            //}


        }
        #endregion

        #region Savecheck
        private bool savecheck()
        {
            string PIDCheck = dgvProductInfo.Rows[0].Cells["colProductID"].Value.ToString();
            if (cboSupplier.SelectedIndex == -1 && PIDCheck == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSupplier.Focus();
                return false;
            }
            else if (cboSupplier.SelectedIndex != -1 && PIDCheck == "")
            {
                MessageBox.Show("Please fill at least One Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProductName.Focus();
                return false;
            }
            else if (cboSupplier.SelectedIndex == -1 && PIDCheck != "")
            {
                MessageBox.Show("Please choose Supplier!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSupplier.Focus();
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
                dataassign();
                if (PO.IsEdit)
                {
                    PO = new Class.clsPO();
                    int poid = int.Parse(txtPOID.Text.Trim());
                    DateTime date = dtpDate.Value;
                    string description = txtDescription.Text.ToString();
                    string requestedeid = EID.ToString();
                    string approvedeid;
                    int status = new int();
                    DateTime approveddate;
                    if (chkAccept.Checked == true)
                    {
                        approvedeid = EID.ToString();
                        approveddate = System.DateTime.Now;
                    }
                    else 
                    {
                        approvedeid = "";
                        approveddate = Convert.ToDateTime("1/1/1900");
                    }

                    if (chkAccept.Checked == false && chkReject.Checked == false)
                    {
                        status = 0;
                    }
                    else if (chkAccept.Checked == true && chkReject.Checked == false)
                    {
                        status = 1;
                    }
                    else if (chkAccept.Checked == false && chkReject.Checked == true)
                    {
                        status = 2;
                    }
                    string supplier = cboSupplier.SelectedValue.ToString();
                    //string uom = cboUOM.SelectedValue.ToString();
                    int depositamt;
                    int fpayment;
                    int amendmentpayment;
                    if (txtDepositAmount.Text == "")
                    {
                        depositamt = 0;
                    }
                    else
                    {
                        depositamt = Convert.ToInt32(txtDepositAmount.Text.ToString());
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


                    foreach (DataGridViewRow item in dgvProductInfo.Rows)
                    {
                        if (item.Cells[0].Value == null)
                        {
                        }
                        else
                        {
                            string productID = item.Cells[0].Value.ToString();
                            string quantity = item.Cells[3].Value.ToString();
                            string price = item.Cells[5].Value.ToString();
                            string currencycode = item.Cells[7].Value.ToString();

                            UOM.UOMName = item.Cells[4].Value.ToString();
                            DataTable tblUOM = new DataTable();
                            tblUOM = UOM.CallUOMIDbyName();
                            string uomedit = tblUOM.Rows[0][0].ToString();

                            W.WHName = item.Cells[2].Value.ToString();
                            DataTable tblWH = new DataTable();
                            tblWH = W.CallWarehouseID();
                            string warehouse = tblWH.Rows[0][0].ToString();

                            PO = new Class.clsPO()
                            {
                                POID = poid,
                                PODate = date,
                                PODescription = description,
                                RequestedEID = requestedeid,
                                ApprovedEID = approvedeid,
                                ApprovedDate = approveddate,
                                SID = supplier,
                                DepositAmount = depositamt,
                                FirstPayment = fpayment,
                                AmendmentPayment = amendmentpayment,
                                PID = productID,
                                POQty = int.Parse(quantity),
                                UOMID = uomedit,
                                POPrice = int.Parse(price),
                                CurrencyCode = currencycode,
                                WHID = warehouse,
                                Status = status,

                                
                            };

                            Inv = new Class.clsInventory()
                            {
                                WHID = warehouse,
                                PID = productID,
                                StockInDate = date,
                                PQty = int.Parse(quantity),
                                PManuDate = System.DateTime.Now,
                                PExpireDate = System.DateTime.Now,
                                CreatedEID = requestedeid


                            };
                            
                            PO.Upd_PO_Product();
                            PO.IsEdit = false;
                        }
                    }
                    PO.Upd_Purchase_Order();
                }
                else
                {


                    PO = new Class.clsPO();
                    int poid = int.Parse(txtPOID.Text.Trim());
                    DateTime date = dtpDate.Value;
                    string description = txtDescription.Text.ToString();
                    string requestedeid = EID.ToString();
                    string approvedeid;
                    int status = new int();
                    DateTime approveddate;
                    if (chkAccept.Checked == true)
                    {
                        approvedeid = EID.ToString();
                        approveddate = System.DateTime.Now;
                    }
                    else
                    {
                        approvedeid = "";
                        approveddate = Convert.ToDateTime("1/1/1900");
                    }

                    if (chkAccept.Checked == false && chkReject.Checked == false)
                    {
                        status = 0;
                    }
                    else if (chkAccept.Checked == true && chkReject.Checked == false)
                    {
                        status = 1;
                    }
                    else if (chkAccept.Checked == false && chkReject.Checked == true)
                    {
                        status = 2;
                    }
                    string supplier = cboSupplier.SelectedValue.ToString();
                    int depositamt;
                    int fpayment;
                    int amendmentpayment;
                    if (txtDepositAmount.Text == "")
                    {
                        depositamt = 0;
                    }
                    else
                    {
                        depositamt = Convert.ToInt32(txtDepositAmount.Text.ToString());
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


                    foreach (DataGridViewRow item in dgvProductInfo.Rows)
                    {
                        if (item.Cells[0].Value == null)
                        {
                        }
                        else
                        {
                            string productID = item.Cells[0].Value.ToString();
                            string quantity = item.Cells[3].Value.ToString();
                            string price = item.Cells[5].Value.ToString();
                            string currencycode = item.Cells[7].Value.ToString();
                       
                            UOM.UOMName =item.Cells[4].Value.ToString();
                            DataTable tblUOM = new DataTable();
                            tblUOM = UOM.CallUOMIDbyName();
                            string uom = tblUOM.Rows[0][0].ToString();
                       
                            W.WHName = item.Cells[2].Value.ToString();
                            DataTable tblWH = new DataTable();
                            tblWH = W.CallWarehouseID();
                            string warehouse = tblWH.Rows[0][0].ToString();

                            PO = new Class.clsPO()
                            {
                                POID = poid,
                                PODate = date,
                                PODescription = description,
                                RequestedEID = requestedeid,
                                ApprovedEID = approvedeid,
                                ApprovedDate = approveddate,
                                SID = supplier,
                                DepositAmount = depositamt,
                                FirstPayment = fpayment,
                                AmendmentPayment = amendmentpayment,
                                PID = productID,
                                POQty = int.Parse(quantity),
                                UOMID = uom,
                                POPrice = int.Parse(price),
                                CurrencyCode = currencycode,
                                WHID = warehouse,
                                Status = status,
                            };

                            Inv = new Class.clsInventory()
                            {
                                WHID = warehouse,
                                PID = productID,
                                StockInDate = date,
                                PQty = int.Parse(quantity),
                                PManuDate = System.DateTime.Now,
                                PExpireDate = System.DateTime.Now,
                                CreatedEID = requestedeid


                            };
                            PO.Ins_Purchase_Order();
                            PO.Ins_PO_Product();
                            Inv.Ins_Inventory();
                        }
                    }

                }
                Loading();
            }
        }
        #endregion

        #region ComboBind
        private void SupplierComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = Sup.CallSupplier();
                cboSupplier.DataSource = tbl;
                cboSupplier.DisplayMember = "SName";
                cboSupplier.ValueMember = "SID";
                cboSupplier.SelectedIndex = -1;

                cboSSupplier.DataSource = tbl;
                cboSSupplier.DisplayMember = "SName";
                cboSSupplier.ValueMember = "SID";
                cboSSupplier.SelectedIndex = -1;
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
                tbl = P.CallProductForPO();
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


        private void UOMComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = UOM.CallUOM();
                cboUOM.DataSource = tbl;
                cboUOM.DisplayMember = "UOMName";
                cboUOM.ValueMember = "UOMID";
                cboUOM.SelectedIndex = -1;
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
            if (chkSPurchaseOrderID.Checked != true && chkSDate.Checked != true && chkSSupplier.Checked != true && chkSStatus.Checked != true)
            {
                MessageBox.Show("Please choose at least one search Parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSPurchaseOrderID.Focus();
            }
            else if (chkSPurchaseOrderID.Checked == true && chkSDate.Checked != true && chkSSupplier.Checked != true && chkSStatus.Checked != true)
            {
                if (txtSPOID.Text == "")
                {
                    MessageBox.Show("Please fill POID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSPOID.Focus();
                }
                else
                {
                    searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PO.Search_Purchase_Order();
                    dgvSPurchaseOrder.DataSource = tbl;
                }

            }
            else if (chkSPurchaseOrderID.Checked != true && chkSDate.Checked == true && chkSSupplier.Checked != true && chkSStatus.Checked != true)
            {
                searchdataassign();
                DataTable tbl = new DataTable();
                tbl = PO.Search_Purchase_Order();
                dgvSPurchaseOrder.DataSource = tbl;
            }
            else if (chkSPurchaseOrderID.Checked != true && chkSDate.Checked != true && chkSSupplier.Checked == true && chkSStatus.Checked != true)
            {
                if (cboSSupplier.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Supplier!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSPOID.Focus();
                }
                else
                {
                    searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PO.Search_Purchase_Order();
                    dgvSPurchaseOrder.DataSource = tbl;
                }
            }
            else if (chkSPurchaseOrderID.Checked != true && chkSDate.Checked != true && chkSSupplier.Checked != true && chkSStatus.Checked == true)
            {
                if (cboSStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Status!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSPOID.Focus();
                }
                else
                {
                    searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PO.Search_Purchase_Order();
                    dgvSPurchaseOrder.DataSource = tbl;
                }
            }
        }

        private void ShowAll()
        {
            showalldataassign();
            DataTable tbl = new DataTable();
            tbl = PO.Search_Purchase_Order();
            dgvSPurchaseOrder.DataSource = tbl;
        }

        #endregion

        #region SearchCheckboxValidation
        private void SearchCheckboxValidation()
        {
            if (chkSPurchaseOrderID.Checked == true)
            {
                txtSPOID.Enabled = true;
            }
            else
            {
                txtSPOID.Enabled = false;
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

            if (chkSSupplier.Checked == true)
            {
                cboSSupplier.Enabled = true;
                SupplierComboBind();
            }
            else
            {
                cboSSupplier.Enabled = false;
            }

            if (chkSStatus.Checked == true)
            {
                cboSStatus.Enabled = true;
            }
            else
            {
                cboSStatus.Enabled = false;
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

                P.PID = cboProductName.SelectedValue.ToString();
                ptbl = P.CallProductbyPID();
                string currency = ptbl.Rows[0][4].ToString();
                long price = long.Parse(txtPrice.Text.Trim());
                string productID = ptbl.Rows[0][0].ToString();
                int qty = int.Parse(txtQuantity.Text.ToString().Trim());
                
                string wh = ptbl.Rows[0][2].ToString();

                foreach (DataGridViewRow item in dgvProductInfo.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        if (item.Cells[0].Value.ToString().Equals(productID))
                        {

                            dgvProductInfo.Rows.RemoveAt(item.Index);
                            //SubTotal = 0;
                        }
                    }
                    //if (item.Cells[8].Value != null)
                    //{
                    //    SubTotal += long.Parse(item.Cells[8].Value.ToString());
                    //}
                }

                string unit = cboUOM.Text.ToString(); ; //ptbl.Rows[0][3].ToString();
                long total = price * qty;

                
                object[] row = new object[] 
                {
                    productID,
                    cboProductName.Text,
                    wh,
                    qty,
                    unit,
                    price,
                    total,
                    currency,
                    "0",
                    "0"
                };
                dgvProductInfo.Rows.Add(row);

                //if (dgvProductInfo.Rows.Count == 2)
                //{
                //    SubTotal = total;
                //    txtTotal.Text = SubTotal.ToString();
                //}
                //else 
                //{
                    this.PolpulatePaymentInfo();
                //}
               


                M.TextBox_Clear(txtQuantity, txtPrice);
                M.Combobox_Clear(cboProductName, cboUOM);
                ProductComboBind();
                UOMComboBind();
                cboProductName.Focus();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                ProductComboBind();
                cboProductName.Focus();
            }
        }
        #endregion

        #region PolpulatePaymentInfo
        private void PolpulatePaymentInfo()
        {
            this.SubTotal = 0;

            foreach (DataGridViewRow item in dgvProductInfo.Rows)
            {
                if (item.Cells[6].Value != null)
                {
                    
                    SubTotal += long.Parse(item.Cells[6].Value.ToString());
                   
                    
                    
                }
            }
            //SubTotal = SubTotal - subtotalfirst;
            txtTotal.Text = SubTotal.ToString();
        }
        #endregion



        #endregion


        private void btnSCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                Loading();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            UL.EID = EID.ToString();
            DataTable tblEID = new DataTable();
            tblEID = UL.CallUserLevelIDbyEID();
            ULID = tblEID.Rows[0][0].ToString();

            M.TextBox_Enable(true, txtDescription, txtQuantity, txtPrice, txtTotal);// txtDepositAmount, txtFirstPayment, txtAmendmentPayment, txtCreditAmount, txtRemark);
            M.GroupBox_Enabled(true, gpbPaymentInfo, gpbPrint);
            M.Button_Enable(false, btnNew, btnDelete, btnEdit);
            M.Button_Enable(true, btnSave, btnCancel, btnAdd, btnSupplier, btnProduct, btnUOM);
            M.TextBox_Clear(txtPOID, txtDescription, txtQuantity, txtPrice, txtTotal, txtDepositAmount, txtFirstPayment, txtAmendmentPayment, txtCreditAmount, txtRemark);
            M.Combobox_Enable(true, cboProductName, cboSupplier, cboUOM);
            if (ULID == "1" || ULID == "2")
            {
                gpbStatus.Enabled = true;
                chkAccept.Enabled = true;
                chkReject.Enabled = true;
                txtRemark.Enabled = true;
            }
            else
            {
                gpbStatus.Enabled = false;
                chkAccept.Enabled = false;
                chkReject.Enabled = false;
                txtRemark.Enabled = false;
            }
            cboSupplier.SelectedIndex = -1;
            SupplierComboBind();
            ProductComboBind();
            UOMComboBind();
            DataTable tblautoid = new DataTable();
            tblautoid = PO.AutoID_Purchase_Order();
            txtPOID.Text = tblautoid.Rows[0][0].ToString();
            GridDataClear();
            cboSupplier.Focus();
        }

        private void frmPO_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UL.EID = EID.ToString();
            DataTable tblEID = new DataTable();
            tblEID = UL.CallUserLevelIDbyEID();
            ULID = tblEID.Rows[0][0].ToString();

           // txtDepositAmount, txtFirstPayment, txtAmendmentPayment, txtCreditAmount, txtRemark);
            M.GroupBox_Enabled(true, gpbPaymentInfo, gpbPrint);
            M.Button_Enable(true, btnSave, btnCancel,  btnAdd); //btnDelete
            M.Button_Enable(false, btnNew ,btnEdit);
            M.Combobox_Enable(false, cboProductName, cboUOM);

            if (chkAccept.Checked == false && chkReject.Checked == false)
            {
                M.DataGridView_Enable(true, dgvProductInfo);
                M.TextBox_Enable(true, txtDescription, txtQuantity, txtPrice);
                if (ULID == "1" || ULID == "2")
                {
                    gpbStatus.Enabled = true;
                    chkAccept.Enabled = true;
                    chkReject.Enabled = true;
                    txtRemark.Enabled = true;
                }
                else
                {
                    gpbStatus.Enabled = false;
                    chkAccept.Enabled = false;
                    chkReject.Enabled = false;
                    txtRemark.Enabled = false;
                }
            }
            else if (chkAccept.Checked == true && chkReject.Checked == false)
            {
                M.DataGridView_Enable(false, dgvProductInfo);
                M.TextBox_Enable(false, txtDescription, txtQuantity, txtPrice);
            }
            else if (chkAccept.Checked == false && chkReject.Checked == true)
            {
                M.DataGridView_Enable(true, dgvProductInfo);
                M.TextBox_Enable(true, txtDescription, txtQuantity, txtPrice);
            }

            if (txtCreditAmount.Text == "0.00")
            {
                M.DataGridView_Enable(false, dgvProductInfo);
            }
            else
            {
                M.DataGridView_Enable(true, dgvProductInfo);
            }


            ProductComboBind();
            UOMComboBind();
            cboProductName.Focus();
            PO.IsEdit = true;

            int deposit = int.Parse(txtDepositAmount.Text.Trim());
            int fp = int.Parse(txtFirstPayment.Text.Trim());
            int ap = int.Parse(txtAmendmentPayment.Text.Trim());


            if (deposit == 0 && fp == 0 && ap == 0)
            {
                txtDepositAmount.Enabled = true;
                txtFirstPayment.Enabled = true;
                txtAmendmentPayment.Enabled = true;

            }
            else if (deposit > 0 && fp == 0 && ap == 0)
            {
                txtDepositAmount.Enabled = true;
                txtFirstPayment.Enabled = true;
                txtAmendmentPayment.Enabled = true;
                txtFirstPayment.Focus();
            }
            else if (deposit >= 0 && fp > 0 && ap == 0)
            {
                txtDepositAmount.Enabled = false;
                txtFirstPayment.Enabled = false;
                txtAmendmentPayment.Enabled = true;
                txtAmendmentPayment.Focus();
            }
            else if (deposit >= 0 && fp >= 0 && ap > 0)
            {
                txtDepositAmount.Enabled = false;
                txtFirstPayment.Enabled = false;
                txtAmendmentPayment.Enabled = false;
                txtRemark.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPanelLoading();
            SearchCheckboxValidation();

        }

        private void btnSCancel_Click_1(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSSupplier_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
        }

        private void btnSShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
            dgvSPurchaseOrder.Enabled = true;
            SearchCheckboxValidation();
            M.Checkbox_Checked(false, chkSDate, chkSPurchaseOrderID, chkSSupplier, chkSStatus);


        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {

            Search();
            dgvSPurchaseOrder.Enabled = true;

        }

        private void dgvSPurchaseOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSPurchaseOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridclick();
                txtPOID.Text = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["POID"].Value.ToString();
                dtpDate.Text = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                txtTotal.Text = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["Total Amount"].Value.ToString();
                txtDepositAmount.Text = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["Deposit"].Value.ToString();
                txtFirstPayment.Text = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["First Payment"].Value.ToString();
                txtAmendmentPayment.Text = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["Amendment Payment"].Value.ToString();
                txtCreditAmount.Text = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["Credit Amount"].Value.ToString();

                string status = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                if(status == "Pending")
                {
                    chkAccept.Checked = false;
                    chkReject.Checked = false;
                }
                else if (status == "Accept")
                {
                    chkAccept.Checked = true;
                    chkReject.Checked = false;
                }
                else if (status == "Reject")
                {
                    chkAccept.Checked = false;
                    chkReject.Checked = true;
                }

                SupplierComboBind();
                Sup.SName = dgvSPurchaseOrder.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
                DataTable tblSup = new DataTable();
                tblSup = Sup.CallSupplierIDbyName();
                cboSupplier.SelectedValue = tblSup.Rows[0][0].ToString();


                PO.POID = int.Parse(txtPOID.Text.Trim());//int.Parse(dgvSPurchaseOrder.Rows[e.RowIndex].Cells["POID"].Value.ToString());
                DataTable tblPOP = new DataTable();
                tblPOP = PO.Call_ProductbyPO();


                dgvProductInfo.AutoGenerateColumns = false;
                dgvProductInfo.Columns[0].Name = "colProductID";
                dgvProductInfo.Columns[0].HeaderText = "Product ID";
                dgvProductInfo.Columns[0].DataPropertyName = "PID";

                dgvProductInfo.Columns[1].Name = "colProductName";
                dgvProductInfo.Columns[1].HeaderText = "Product Name";
                dgvProductInfo.Columns[1].DataPropertyName = "PName";

                dgvProductInfo.Columns[2].Name = "colWHName";
                dgvProductInfo.Columns[2].HeaderText = "Warehouse";
                dgvProductInfo.Columns[2].DataPropertyName = "WHName";

                dgvProductInfo.Columns[3].Name = "colQuantity";
                dgvProductInfo.Columns[3].HeaderText = "Quantity";
                dgvProductInfo.Columns[3].DataPropertyName = "POQty";

                dgvProductInfo.Columns[4].Name = "colUOM";
                dgvProductInfo.Columns[4].HeaderText = "Unit";
                dgvProductInfo.Columns[4].DataPropertyName = "UOMName";

                dgvProductInfo.Columns[5].Name = "colPrice";
                dgvProductInfo.Columns[5].HeaderText = "Price";
                dgvProductInfo.Columns[5].DataPropertyName = "POPrice";

                dgvProductInfo.Columns[6].Name = "colAmount";
                dgvProductInfo.Columns[6].HeaderText = "Amount";
                dgvProductInfo.Columns[6].DataPropertyName = "Amount";

                dgvProductInfo.Columns[7].Name = "colCurrency";
                dgvProductInfo.Columns[7].HeaderText = "Currency";
                dgvProductInfo.Columns[7].DataPropertyName = "CurrencyCode";

                this.dgvProductInfo.DataSource = tblPOP;

                //this.PolpulatePaymentInfo();

                tbcPurchaseOrder.SelectedTab = tbpPurchaseOrder;


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productID = cboProductName.SelectedValue.ToString();
            this.FillProductInfo(productID);
            cboProductName.SelectedIndex = -1;
            cboUOM.SelectedIndex = -1;
            M.TextBox_Clear(txtPrice, txtQuantity);
            M.TextBox_Enable(true, txtAmendmentPayment, txtFirstPayment, txtDepositAmount);
            dgvProductInfo.Enabled = true;
            cboProductName.Focus();
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {

        }

        private void gpbSearch_Enter(object sender, EventArgs e)
        {

        }

        private void chkSStatus_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
        }

        private void chkSPurchaseOrderID_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
        }

        private void chkSDate_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmsupplier frmsup = new frmsupplier();
            frmsup.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProductHirachy frmph = new frmProductHirachy();
            frmph.ShowDialog();
        }

        private void cboSupplier_KeyPress(object sender, KeyPressEventArgs e)
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
                cboUOM.Focus();

            }
        }


        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    string productID = cboProductName.SelectedValue.ToString();
                    this.FillProductInfo(productID);
                    cboProductName.SelectedIndex = -1;
                    cboUOM.SelectedIndex = -1;
                    M.TextBox_Clear(txtPrice, txtQuantity);
                    M.TextBox_Enable(true, txtAmendmentPayment, txtFirstPayment, txtDepositAmount);
                    dgvProductInfo.Enabled = true;
                    cboProductName.Focus();
                }
                catch (Exception ep)
                {
                    MessageBox.Show(ep.Message.ToString());
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPrice.Focus();

            }
        }

        int rowIndex = 0;
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProductInfo.Rows.RemoveAt(rowIndex);
        }

        private void dgvProductInfo_MouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvProductInfo.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dgvSalesInfo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox c = e.Control as ComboBox;
            if (c != null)
            {
                if (dgvProductInfo.CurrentCell.ColumnIndex == 1)
                {
                    c.SelectedIndexChanged -= new EventHandler(SelectionChanged);
                    c.SelectedIndexChanged += new EventHandler(SelectionChanged);
                }
            }

        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductInfo.CurrentCell.ColumnIndex == 1)
            {
                ComboBox cx = sender as ComboBox;
                string productLineID = cx.SelectedValue.ToString();
                //this.ProductGridComboBind(productLineID);
            }
        }

        private void dgvProductInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvProductInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void dgvProductInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
               
                
                txtQuantity.Text = dgvProductInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text = dgvProductInfo.Rows[e.RowIndex].Cells[5].Value.ToString();

                ProductComboBind();
                UOMComboBind();
                cboProductName.SelectedValue = dgvProductInfo.Rows[e.RowIndex].Cells[0].Value.ToString();

                UOM.UOMName = dgvProductInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
                DataTable tblUOM = new DataTable();
                tblUOM = UOM.CallUOMIDbyName();
                cboUOM.SelectedValue = tblUOM.Rows[0][0].ToString();
                

                //cboProductName.SelectedText = dgvProductInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
                //P.PID = dgvProductInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                //DataTable tblP = new DataTable();
                //tblP = P.CallProductbyPID();
                //cboProductName.DataSource = tblP;
                //cboProductName.DisplayMember = "Product Name";
                //cboProductName.ValueMember = "Product ID";
                
            }


        }

        private void dgvProductInfo_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvProductInfo.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    contextMenuStrip1.Show(Cursor.Position);
                }

            }
            catch
            {
            }
        }

        private void deleteRowToolStripMenuItem_Click_1(object sender, EventArgs e, DataGridViewCellEventArgs ed)
        {

                //PO.POID = int.Parse( txtPOID.Text.Trim());
                //PO.PID = this.dgvProductInfo.Rows[ed.RowIndex].Cells[0].Value.ToString();

                //W.WHName = this.dgvProductInfo.Rows[ed.RowIndex].Cells[2].Value.ToString();
                //DataTable tblWH = new DataTable();
                //tblWH = W.CallWarehouseID();
                //PO.WHID = tblWH.Rows[0][0].ToString();

                //PO.Del_PO_Product();
                dgvProductInfo.Rows.RemoveAt(rowIndex);

                //Loading();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUOM frmuom = new frmUOM();
            frmuom.ShowDialog();
        }

        private void cboUOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtQuantity.Focus();
            }
        }

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtDepositAmount.Text == "")
                {
                    txtDepositAmount.Text = "0";
                }
                else
                {
                    float gt = float.Parse(txtTotal.Text.Trim());
                    float dep = float.Parse(txtDepositAmount.Text.Trim());
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
                    float gt = float.Parse(txtTotal.Text.Trim());
                    float dep = float.Parse(txtDepositAmount.Text.Trim());
                    float fp = float.Parse(txtFirstPayment.Text.Trim());
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
                    float gt = float.Parse(txtTotal.Text.Trim());
                    float dep = float.Parse(txtDepositAmount.Text.Trim());
                    float fp = float.Parse(txtFirstPayment.Text.Trim());
                    float ap = float.Parse(txtAmendmentPayment.Text.Trim());
                    float pc = gt - (dep + fp + ap);
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

        private void dgvProductInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
