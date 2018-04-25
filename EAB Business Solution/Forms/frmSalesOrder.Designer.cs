namespace EAB_Business_Solution.Forms
{
    partial class frmSalesOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dgvSSalesOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.txtSCustomerName = new System.Windows.Forms.TextBox();
            this.chkSCancelOrders = new System.Windows.Forms.CheckBox();
            this.chkSDebitPay = new System.Windows.Forms.CheckBox();
            this.chkSCreditPay = new System.Windows.Forms.CheckBox();
            this.dtpSToDate = new System.Windows.Forms.DateTimePicker();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.lblSTo = new System.Windows.Forms.Label();
            this.chkSSalesOrderID = new System.Windows.Forms.CheckBox();
            this.dtpSFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtSSalesOrderID = new System.Windows.Forms.TextBox();
            this.chkSDate = new System.Windows.Forms.CheckBox();
            this.chkSCustomerName = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblMembershipShow = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblCustomerTypeShow = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblNRCShow = new System.Windows.Forms.Label();
            this.lblNRC = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSalesOrderID = new System.Windows.Forms.Label();
            this.txtSOID = new System.Windows.Forms.TextBox();
            this.gpbSalesOrderInfo = new System.Windows.Forms.GroupBox();
            this.dgvSalesOrder = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotionPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbVoucher = new System.Windows.Forms.GroupBox();
            this.lblCGrandTotal = new System.Windows.Forms.Label();
            this.lblCServiceCharges = new System.Windows.Forms.Label();
            this.lblCTax = new System.Windows.Forms.Label();
            this.lblCMemberPromotion = new System.Windows.Forms.Label();
            this.lblCMemberPomotionPercentage = new System.Windows.Forms.Label();
            this.lblCSubTotal = new System.Windows.Forms.Label();
            this.txtMemberPromotion = new System.Windows.Forms.TextBox();
            this.lblMemberPromotion = new System.Windows.Forms.Label();
            this.txtMemberPromotionPercentage = new System.Windows.Forms.TextBox();
            this.lblServiceCharges = new System.Windows.Forms.Label();
            this.txtServiceCharges = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.gpbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.rdbDebitPay = new System.Windows.Forms.RadioButton();
            this.rdbCreditPay = new System.Windows.Forms.RadioButton();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblCAmendment = new System.Windows.Forms.Label();
            this.lblCCredit = new System.Windows.Forms.Label();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.lblC1st = new System.Windows.Forms.Label();
            this.lblCDeposit = new System.Windows.Forms.Label();
            this.txtFirstPayment = new System.Windows.Forms.TextBox();
            this.lbl1stPayment = new System.Windows.Forms.Label();
            this.lblFianlPaymentAmount = new System.Windows.Forms.Label();
            this.txtAmendmentPayment = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOrderCancel = new System.Windows.Forms.Button();
            this.gpbProduct = new System.Windows.Forms.GroupBox();
            this.btnProductLine = new System.Windows.Forms.Button();
            this.cboProductLine = new System.Windows.Forms.ComboBox();
            this.lblProductLine = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnProductName = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlPOS = new System.Windows.Forms.Panel();
            this.tbcSalesOrder = new System.Windows.Forms.TabControl();
            this.tbpSalesOrder = new System.Windows.Forms.TabPage();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSSalesOrder)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gpbBasicInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbSalesOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).BeginInit();
            this.gpbVoucher.SuspendLayout();
            this.gpbPaymentInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpbProduct.SuspendLayout();
            this.pnlPOS.SuspendLayout();
            this.tbcSalesOrder.SuspendLayout();
            this.tbpSalesOrder.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EAB_Business_Solution.Report.SOReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(357, 272);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 70;
            this.reportViewer1.Visible = false;
            // 
            // dgvSSalesOrder
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSSalesOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvSSalesOrder.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSSalesOrder.Location = new System.Drawing.Point(6, 241);
            this.dgvSSalesOrder.Name = "dgvSSalesOrder";
            this.dgvSSalesOrder.Size = new System.Drawing.Size(1120, 369);
            this.dgvSSalesOrder.TabIndex = 6;
            this.dgvSSalesOrder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSSalesOrder_CellDoubleClick);
            this.dgvSSalesOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSSalesOrder_CellDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Myanmar3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.NullValue = false;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle24;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.txtSCustomerName);
            this.gpbSearch.Controls.Add(this.chkSCancelOrders);
            this.gpbSearch.Controls.Add(this.chkSDebitPay);
            this.gpbSearch.Controls.Add(this.chkSCreditPay);
            this.gpbSearch.Controls.Add(this.dtpSToDate);
            this.gpbSearch.Controls.Add(this.gpbSControl);
            this.gpbSearch.Controls.Add(this.lblSTo);
            this.gpbSearch.Controls.Add(this.chkSSalesOrderID);
            this.gpbSearch.Controls.Add(this.dtpSFromDate);
            this.gpbSearch.Controls.Add(this.txtSSalesOrderID);
            this.gpbSearch.Controls.Add(this.chkSDate);
            this.gpbSearch.Controls.Add(this.chkSCustomerName);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(292, 6);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(492, 225);
            this.gpbSearch.TabIndex = 1;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Filter";
            // 
            // txtSCustomerName
            // 
            this.txtSCustomerName.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCustomerName.Location = new System.Drawing.Point(13, 116);
            this.txtSCustomerName.Name = "txtSCustomerName";
            this.txtSCustomerName.Size = new System.Drawing.Size(136, 24);
            this.txtSCustomerName.TabIndex = 67;
            // 
            // chkSCancelOrders
            // 
            this.chkSCancelOrders.AutoSize = true;
            this.chkSCancelOrders.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCancelOrders.Location = new System.Drawing.Point(385, 119);
            this.chkSCancelOrders.Name = "chkSCancelOrders";
            this.chkSCancelOrders.Size = new System.Drawing.Size(94, 17);
            this.chkSCancelOrders.TabIndex = 66;
            this.chkSCancelOrders.Text = "Cancel Orders";
            this.chkSCancelOrders.UseVisualStyleBackColor = true;
            // 
            // chkSDebitPay
            // 
            this.chkSDebitPay.AutoSize = true;
            this.chkSDebitPay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSDebitPay.Location = new System.Drawing.Point(385, 75);
            this.chkSDebitPay.Name = "chkSDebitPay";
            this.chkSDebitPay.Size = new System.Drawing.Size(72, 17);
            this.chkSDebitPay.TabIndex = 65;
            this.chkSDebitPay.Text = "Debit Pay";
            this.chkSDebitPay.UseVisualStyleBackColor = true;
            // 
            // chkSCreditPay
            // 
            this.chkSCreditPay.AutoSize = true;
            this.chkSCreditPay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCreditPay.Location = new System.Drawing.Point(385, 29);
            this.chkSCreditPay.Name = "chkSCreditPay";
            this.chkSCreditPay.Size = new System.Drawing.Size(76, 17);
            this.chkSCreditPay.TabIndex = 64;
            this.chkSCreditPay.Text = "Credit Pay";
            this.chkSCreditPay.UseVisualStyleBackColor = true;
            // 
            // dtpSToDate
            // 
            this.dtpSToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.CustomFormat = "dd MMM yyyy";
            this.dtpSToDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSToDate.Location = new System.Drawing.Point(200, 95);
            this.dtpSToDate.Name = "dtpSToDate";
            this.dtpSToDate.Size = new System.Drawing.Size(136, 21);
            this.dtpSToDate.TabIndex = 62;
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnSShowAll);
            this.gpbSControl.Controls.Add(this.btnSSearch);
            this.gpbSControl.Location = new System.Drawing.Point(183, 158);
            this.gpbSControl.Name = "gpbSControl";
            this.gpbSControl.Size = new System.Drawing.Size(153, 59);
            this.gpbSControl.TabIndex = 3;
            this.gpbSControl.TabStop = false;
            // 
            // btnSShowAll
            // 
            this.btnSShowAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSShowAll.Location = new System.Drawing.Point(79, 18);
            this.btnSShowAll.Name = "btnSShowAll";
            this.btnSShowAll.Size = new System.Drawing.Size(65, 31);
            this.btnSShowAll.TabIndex = 18;
            this.btnSShowAll.Text = "Show &All";
            this.btnSShowAll.UseVisualStyleBackColor = true;
            this.btnSShowAll.Click += new System.EventHandler(this.btnSShowAll_Click);
            // 
            // btnSSearch
            // 
            this.btnSSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSearch.Location = new System.Drawing.Point(6, 18);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(65, 31);
            this.btnSSearch.TabIndex = 13;
            this.btnSSearch.Text = "Searc&h";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(260, 79);
            this.lblSTo.Name = "lblSTo";
            this.lblSTo.Size = new System.Drawing.Size(19, 13);
            this.lblSTo.TabIndex = 63;
            this.lblSTo.Text = "To";
            // 
            // chkSSalesOrderID
            // 
            this.chkSSalesOrderID.AutoSize = true;
            this.chkSSalesOrderID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSSalesOrderID.Location = new System.Drawing.Point(13, 29);
            this.chkSSalesOrderID.Name = "chkSSalesOrderID";
            this.chkSSalesOrderID.Size = new System.Drawing.Size(96, 17);
            this.chkSSalesOrderID.TabIndex = 48;
            this.chkSSalesOrderID.Text = "Sales Order ID";
            this.chkSSalesOrderID.UseVisualStyleBackColor = true;
            this.chkSSalesOrderID.CheckedChanged += new System.EventHandler(this.chkSSalesOrderID_CheckedChanged);
            // 
            // dtpSFromDate
            // 
            this.dtpSFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpSFromDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSFromDate.Location = new System.Drawing.Point(200, 51);
            this.dtpSFromDate.Name = "dtpSFromDate";
            this.dtpSFromDate.Size = new System.Drawing.Size(136, 21);
            this.dtpSFromDate.TabIndex = 61;
            // 
            // txtSSalesOrderID
            // 
            this.txtSSalesOrderID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSalesOrderID.Location = new System.Drawing.Point(13, 51);
            this.txtSSalesOrderID.Name = "txtSSalesOrderID";
            this.txtSSalesOrderID.Size = new System.Drawing.Size(125, 21);
            this.txtSSalesOrderID.TabIndex = 2;
            // 
            // chkSDate
            // 
            this.chkSDate.AutoSize = true;
            this.chkSDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSDate.Location = new System.Drawing.Point(200, 29);
            this.chkSDate.Name = "chkSDate";
            this.chkSDate.Size = new System.Drawing.Size(49, 17);
            this.chkSDate.TabIndex = 60;
            this.chkSDate.Text = "Date";
            this.chkSDate.UseVisualStyleBackColor = true;
            this.chkSDate.CheckedChanged += new System.EventHandler(this.chkSDate_CheckedChanged);
            // 
            // chkSCustomerName
            // 
            this.chkSCustomerName.AutoSize = true;
            this.chkSCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCustomerName.Location = new System.Drawing.Point(13, 95);
            this.chkSCustomerName.Name = "chkSCustomerName";
            this.chkSCustomerName.Size = new System.Drawing.Size(102, 17);
            this.chkSCustomerName.TabIndex = 50;
            this.chkSCustomerName.Text = "Customer Name";
            this.chkSCustomerName.UseVisualStyleBackColor = true;
            this.chkSCustomerName.CheckedChanged += new System.EventHandler(this.chkSCustomerName_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.dtpDeliveryDate);
            this.gpbBasicInfo.Controls.Add(this.lblDeliveryDate);
            this.gpbBasicInfo.Controls.Add(this.txtDescription);
            this.gpbBasicInfo.Controls.Add(this.lblDescription);
            this.gpbBasicInfo.Controls.Add(this.txtInvoiceNo);
            this.gpbBasicInfo.Controls.Add(this.lblInvoiceNo);
            this.gpbBasicInfo.Controls.Add(this.groupBox2);
            this.gpbBasicInfo.Controls.Add(this.lblMembershipShow);
            this.gpbBasicInfo.Controls.Add(this.lblMembership);
            this.gpbBasicInfo.Controls.Add(this.lblCustomerTypeShow);
            this.gpbBasicInfo.Controls.Add(this.lblCustomerType);
            this.gpbBasicInfo.Controls.Add(this.lblNRCShow);
            this.gpbBasicInfo.Controls.Add(this.lblNRC);
            this.gpbBasicInfo.Controls.Add(this.dtpDate);
            this.gpbBasicInfo.Controls.Add(this.btnCustomer);
            this.gpbBasicInfo.Controls.Add(this.cboCustomerName);
            this.gpbBasicInfo.Controls.Add(this.lblCustomerName);
            this.gpbBasicInfo.Controls.Add(this.lblDate);
            this.gpbBasicInfo.Controls.Add(this.lblSalesOrderID);
            this.gpbBasicInfo.Controls.Add(this.txtSOID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(6, 6);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(798, 171);
            this.gpbBasicInfo.TabIndex = 0;
            this.gpbBasicInfo.TabStop = false;
            this.gpbBasicInfo.Text = "Basic Infomation";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeliveryDate.CustomFormat = "dd MMM yyyy";
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(608, 46);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(136, 21);
            this.dtpDeliveryDate.TabIndex = 69;
            this.dtpDeliveryDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDeliveryDate_KeyPress);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(499, 52);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(72, 13);
            this.lblDeliveryDate.TabIndex = 70;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(105, 82);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 67);
            this.txtDescription.TabIndex = 68;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(22, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 67;
            this.lblDescription.Text = "Description";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(105, 52);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(125, 21);
            this.txtInvoiceNo.TabIndex = 66;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(22, 56);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(58, 13);
            this.lblInvoiceNo.TabIndex = 65;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(975, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 268);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Information";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(166, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 23);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 14);
            this.label1.TabIndex = 40;
            this.label1.Text = "Member Promotion";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(166, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 23);
            this.textBox3.TabIndex = 39;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "Service Charges";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(166, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 23);
            this.textBox4.TabIndex = 37;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tax";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(166, 132);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 23);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(166, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 23);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "Sub Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 14);
            this.label5.TabIndex = 26;
            this.label5.Text = "Grand Total";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(166, 208);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 40);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMembershipShow
            // 
            this.lblMembershipShow.AutoSize = true;
            this.lblMembershipShow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipShow.Location = new System.Drawing.Point(603, 136);
            this.lblMembershipShow.Name = "lblMembershipShow";
            this.lblMembershipShow.Size = new System.Drawing.Size(68, 13);
            this.lblMembershipShow.TabIndex = 64;
            this.lblMembershipShow.Text = "Member Ship";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembership.Location = new System.Drawing.Point(498, 136);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(68, 13);
            this.lblMembership.TabIndex = 63;
            this.lblMembership.Text = "Membership:";
            // 
            // lblCustomerTypeShow
            // 
            this.lblCustomerTypeShow.AutoSize = true;
            this.lblCustomerTypeShow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTypeShow.Location = new System.Drawing.Point(604, 107);
            this.lblCustomerTypeShow.Name = "lblCustomerTypeShow";
            this.lblCustomerTypeShow.Size = new System.Drawing.Size(80, 13);
            this.lblCustomerTypeShow.TabIndex = 62;
            this.lblCustomerTypeShow.Text = "Customer Type";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(499, 107);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(84, 13);
            this.lblCustomerType.TabIndex = 61;
            this.lblCustomerType.Text = "Customer Type:";
            // 
            // lblNRCShow
            // 
            this.lblNRCShow.AutoSize = true;
            this.lblNRCShow.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCShow.Location = new System.Drawing.Point(605, 82);
            this.lblNRCShow.Name = "lblNRCShow";
            this.lblNRCShow.Size = new System.Drawing.Size(33, 16);
            this.lblNRCShow.TabIndex = 60;
            this.lblNRCShow.Text = "NRC";
            // 
            // lblNRC
            // 
            this.lblNRC.AutoSize = true;
            this.lblNRC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRC.Location = new System.Drawing.Point(499, 82);
            this.lblNRC.Name = "lblNRC";
            this.lblNRC.Size = new System.Drawing.Size(32, 13);
            this.lblNRC.TabIndex = 59;
            this.lblNRC.Text = "NRC:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CustomFormat = "dd MMM yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(319, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(136, 21);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDate_KeyPress);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(750, 17);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(29, 26);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "...";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(608, 18);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(136, 24);
            this.cboCustomerName.TabIndex = 3;
            this.cboCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboCustomerName_SelectedIndexChanged);
            this.cboCustomerName.TextChanged += new System.EventHandler(this.cboCustomerName_TextChanged);
            this.cboCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCustomerName_KeyPress);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(498, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(83, 13);
            this.lblCustomerName.TabIndex = 57;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(283, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // lblSalesOrderID
            // 
            this.lblSalesOrderID.AutoSize = true;
            this.lblSalesOrderID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderID.Location = new System.Drawing.Point(22, 30);
            this.lblSalesOrderID.Name = "lblSalesOrderID";
            this.lblSalesOrderID.Size = new System.Drawing.Size(77, 13);
            this.lblSalesOrderID.TabIndex = 26;
            this.lblSalesOrderID.Text = "Sales Order ID";
            // 
            // txtSOID
            // 
            this.txtSOID.Enabled = false;
            this.txtSOID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOID.Location = new System.Drawing.Point(105, 24);
            this.txtSOID.Name = "txtSOID";
            this.txtSOID.Size = new System.Drawing.Size(125, 21);
            this.txtSOID.TabIndex = 1;
            // 
            // gpbSalesOrderInfo
            // 
            this.gpbSalesOrderInfo.Controls.Add(this.dgvSalesOrder);
            this.gpbSalesOrderInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSalesOrderInfo.Location = new System.Drawing.Point(6, 263);
            this.gpbSalesOrderInfo.Name = "gpbSalesOrderInfo";
            this.gpbSalesOrderInfo.Size = new System.Drawing.Size(798, 280);
            this.gpbSalesOrderInfo.TabIndex = 1;
            this.gpbSalesOrderInfo.TabStop = false;
            this.gpbSalesOrderInfo.Text = "Sales Order Infomation";
            // 
            // dgvSalesOrder
            // 
            this.dgvSalesOrder.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colQuantity,
            this.colUnit,
            this.colPrice,
            this.colCurrency,
            this.colAmount,
            this.colPromotionPercentage,
            this.colPromotion});
            this.dgvSalesOrder.Location = new System.Drawing.Point(16, 21);
            this.dgvSalesOrder.Name = "dgvSalesOrder";
            this.dgvSalesOrder.Size = new System.Drawing.Size(770, 245);
            this.dgvSalesOrder.TabIndex = 5;
            this.dgvSalesOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellContentClick);
            this.dgvSalesOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellDoubleClick);
            this.dgvSalesOrder.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSalesOrder_CellMouseUp);
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductID.DefaultCellStyle = dataGridViewCellStyle25;
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductID.Width = 84;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle26;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductName.Width = 101;
            // 
            // colQuantity
            // 
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle27;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colUnit
            // 
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle28;
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle29;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colCurrency
            // 
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colCurrency.DefaultCellStyle = dataGridViewCellStyle30;
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            // 
            // colAmount
            // 
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle31;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colPromotionPercentage
            // 
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colPromotionPercentage.DefaultCellStyle = dataGridViewCellStyle32;
            this.colPromotionPercentage.HeaderText = "Promotion Percentage";
            this.colPromotionPercentage.Name = "colPromotionPercentage";
            this.colPromotionPercentage.ReadOnly = true;
            this.colPromotionPercentage.Visible = false;
            // 
            // colPromotion
            // 
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colPromotion.DefaultCellStyle = dataGridViewCellStyle33;
            this.colPromotion.HeaderText = "Promotion";
            this.colPromotion.Name = "colPromotion";
            this.colPromotion.ReadOnly = true;
            this.colPromotion.Visible = false;
            // 
            // gpbVoucher
            // 
            this.gpbVoucher.Controls.Add(this.lblCGrandTotal);
            this.gpbVoucher.Controls.Add(this.lblCServiceCharges);
            this.gpbVoucher.Controls.Add(this.lblCTax);
            this.gpbVoucher.Controls.Add(this.lblCMemberPromotion);
            this.gpbVoucher.Controls.Add(this.lblCMemberPomotionPercentage);
            this.gpbVoucher.Controls.Add(this.lblCSubTotal);
            this.gpbVoucher.Controls.Add(this.txtMemberPromotion);
            this.gpbVoucher.Controls.Add(this.lblMemberPromotion);
            this.gpbVoucher.Controls.Add(this.txtMemberPromotionPercentage);
            this.gpbVoucher.Controls.Add(this.lblServiceCharges);
            this.gpbVoucher.Controls.Add(this.txtServiceCharges);
            this.gpbVoucher.Controls.Add(this.lblTax);
            this.gpbVoucher.Controls.Add(this.txtTax);
            this.gpbVoucher.Controls.Add(this.txtSubTotal);
            this.gpbVoucher.Controls.Add(this.lblSubTotal);
            this.gpbVoucher.Controls.Add(this.lblGrandTotal);
            this.gpbVoucher.Controls.Add(this.txtGrandTotal);
            this.gpbVoucher.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVoucher.Location = new System.Drawing.Point(813, 6);
            this.gpbVoucher.Name = "gpbVoucher";
            this.gpbVoucher.Size = new System.Drawing.Size(311, 204);
            this.gpbVoucher.TabIndex = 6;
            this.gpbVoucher.TabStop = false;
            this.gpbVoucher.Text = "Voucher";
            // 
            // lblCGrandTotal
            // 
            this.lblCGrandTotal.AutoSize = true;
            this.lblCGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGrandTotal.Location = new System.Drawing.Point(258, 171);
            this.lblCGrandTotal.Name = "lblCGrandTotal";
            this.lblCGrandTotal.Size = new System.Drawing.Size(29, 13);
            this.lblCGrandTotal.TabIndex = 47;
            this.lblCGrandTotal.Text = "MMK";
            // 
            // lblCServiceCharges
            // 
            this.lblCServiceCharges.AutoSize = true;
            this.lblCServiceCharges.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCServiceCharges.Location = new System.Drawing.Point(258, 141);
            this.lblCServiceCharges.Name = "lblCServiceCharges";
            this.lblCServiceCharges.Size = new System.Drawing.Size(29, 13);
            this.lblCServiceCharges.TabIndex = 46;
            this.lblCServiceCharges.Text = "MMK";
            // 
            // lblCTax
            // 
            this.lblCTax.AutoSize = true;
            this.lblCTax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTax.Location = new System.Drawing.Point(258, 108);
            this.lblCTax.Name = "lblCTax";
            this.lblCTax.Size = new System.Drawing.Size(29, 13);
            this.lblCTax.TabIndex = 45;
            this.lblCTax.Text = "MMK";
            // 
            // lblCMemberPromotion
            // 
            this.lblCMemberPromotion.AutoSize = true;
            this.lblCMemberPromotion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMemberPromotion.Location = new System.Drawing.Point(258, 78);
            this.lblCMemberPromotion.Name = "lblCMemberPromotion";
            this.lblCMemberPromotion.Size = new System.Drawing.Size(29, 13);
            this.lblCMemberPromotion.TabIndex = 44;
            this.lblCMemberPromotion.Text = "MMK";
            // 
            // lblCMemberPomotionPercentage
            // 
            this.lblCMemberPomotionPercentage.AutoSize = true;
            this.lblCMemberPomotionPercentage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMemberPomotionPercentage.Location = new System.Drawing.Point(258, 49);
            this.lblCMemberPomotionPercentage.Name = "lblCMemberPomotionPercentage";
            this.lblCMemberPomotionPercentage.Size = new System.Drawing.Size(18, 13);
            this.lblCMemberPomotionPercentage.TabIndex = 43;
            this.lblCMemberPomotionPercentage.Text = "%";
            // 
            // lblCSubTotal
            // 
            this.lblCSubTotal.AutoSize = true;
            this.lblCSubTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSubTotal.Location = new System.Drawing.Point(258, 19);
            this.lblCSubTotal.Name = "lblCSubTotal";
            this.lblCSubTotal.Size = new System.Drawing.Size(29, 13);
            this.lblCSubTotal.TabIndex = 42;
            this.lblCSubTotal.Text = "MMK";
            // 
            // txtMemberPromotion
            // 
            this.txtMemberPromotion.Enabled = false;
            this.txtMemberPromotion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPromotion.Location = new System.Drawing.Point(127, 74);
            this.txtMemberPromotion.Name = "txtMemberPromotion";
            this.txtMemberPromotion.Size = new System.Drawing.Size(125, 21);
            this.txtMemberPromotion.TabIndex = 41;
            this.txtMemberPromotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMemberPromotion
            // 
            this.lblMemberPromotion.AutoSize = true;
            this.lblMemberPromotion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberPromotion.Location = new System.Drawing.Point(15, 50);
            this.lblMemberPromotion.Name = "lblMemberPromotion";
            this.lblMemberPromotion.Size = new System.Drawing.Size(96, 13);
            this.lblMemberPromotion.TabIndex = 40;
            this.lblMemberPromotion.Text = "Member Promotion";
            // 
            // txtMemberPromotionPercentage
            // 
            this.txtMemberPromotionPercentage.Enabled = false;
            this.txtMemberPromotionPercentage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPromotionPercentage.Location = new System.Drawing.Point(127, 45);
            this.txtMemberPromotionPercentage.Name = "txtMemberPromotionPercentage";
            this.txtMemberPromotionPercentage.Size = new System.Drawing.Size(125, 21);
            this.txtMemberPromotionPercentage.TabIndex = 39;
            this.txtMemberPromotionPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceCharges
            // 
            this.lblServiceCharges.AutoSize = true;
            this.lblServiceCharges.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharges.Location = new System.Drawing.Point(15, 143);
            this.lblServiceCharges.Name = "lblServiceCharges";
            this.lblServiceCharges.Size = new System.Drawing.Size(85, 13);
            this.lblServiceCharges.TabIndex = 38;
            this.lblServiceCharges.Text = "Service Charges";
            // 
            // txtServiceCharges
            // 
            this.txtServiceCharges.Enabled = false;
            this.txtServiceCharges.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCharges.Location = new System.Drawing.Point(127, 137);
            this.txtServiceCharges.Name = "txtServiceCharges";
            this.txtServiceCharges.Size = new System.Drawing.Size(125, 21);
            this.txtServiceCharges.TabIndex = 37;
            this.txtServiceCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(15, 109);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 36;
            this.lblTax.Text = "Tax";
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(127, 105);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(125, 21);
            this.txtTax.TabIndex = 11;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(127, 15);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(125, 21);
            this.txtSubTotal.TabIndex = 10;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(15, 20);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(52, 13);
            this.lblSubTotal.TabIndex = 28;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(15, 172);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(63, 13);
            this.lblGrandTotal.TabIndex = 26;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(127, 168);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(125, 21);
            this.txtGrandTotal.TabIndex = 20;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gpbPaymentInfo
            // 
            this.gpbPaymentInfo.Controls.Add(this.rdbDebitPay);
            this.gpbPaymentInfo.Controls.Add(this.rdbCreditPay);
            this.gpbPaymentInfo.Controls.Add(this.txtRemark);
            this.gpbPaymentInfo.Controls.Add(this.lblRemark);
            this.gpbPaymentInfo.Controls.Add(this.txtCreditAmount);
            this.gpbPaymentInfo.Controls.Add(this.txtDeposit);
            this.gpbPaymentInfo.Controls.Add(this.lblCAmendment);
            this.gpbPaymentInfo.Controls.Add(this.lblCCredit);
            this.gpbPaymentInfo.Controls.Add(this.lblDepositAmount);
            this.gpbPaymentInfo.Controls.Add(this.lblCreditAmount);
            this.gpbPaymentInfo.Controls.Add(this.lblC1st);
            this.gpbPaymentInfo.Controls.Add(this.lblCDeposit);
            this.gpbPaymentInfo.Controls.Add(this.txtFirstPayment);
            this.gpbPaymentInfo.Controls.Add(this.lbl1stPayment);
            this.gpbPaymentInfo.Controls.Add(this.lblFianlPaymentAmount);
            this.gpbPaymentInfo.Controls.Add(this.txtAmendmentPayment);
            this.gpbPaymentInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPaymentInfo.Location = new System.Drawing.Point(813, 213);
            this.gpbPaymentInfo.Name = "gpbPaymentInfo";
            this.gpbPaymentInfo.Size = new System.Drawing.Size(311, 330);
            this.gpbPaymentInfo.TabIndex = 48;
            this.gpbPaymentInfo.TabStop = false;
            this.gpbPaymentInfo.Text = "Payment Information";
            // 
            // rdbDebitPay
            // 
            this.rdbDebitPay.AutoSize = true;
            this.rdbDebitPay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDebitPay.Location = new System.Drawing.Point(153, 30);
            this.rdbDebitPay.Name = "rdbDebitPay";
            this.rdbDebitPay.Size = new System.Drawing.Size(71, 17);
            this.rdbDebitPay.TabIndex = 77;
            this.rdbDebitPay.TabStop = true;
            this.rdbDebitPay.Text = "Debit Pay";
            this.rdbDebitPay.UseVisualStyleBackColor = true;
            this.rdbDebitPay.CheckedChanged += new System.EventHandler(this.rdbDebitPay_CheckedChanged);
            // 
            // rdbCreditPay
            // 
            this.rdbCreditPay.AutoSize = true;
            this.rdbCreditPay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCreditPay.Location = new System.Drawing.Point(62, 30);
            this.rdbCreditPay.Name = "rdbCreditPay";
            this.rdbCreditPay.Size = new System.Drawing.Size(75, 17);
            this.rdbCreditPay.TabIndex = 76;
            this.rdbCreditPay.TabStop = true;
            this.rdbCreditPay.Text = "Credit Pay";
            this.rdbCreditPay.UseVisualStyleBackColor = true;
            this.rdbCreditPay.CheckedChanged += new System.EventHandler(this.rdbCreditPay_CheckedChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(127, 211);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(168, 85);
            this.txtRemark.TabIndex = 69;
            this.txtRemark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemark_KeyPress);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(15, 214);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(43, 13);
            this.lblRemark.TabIndex = 75;
            this.lblRemark.Text = "Remark";
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Enabled = false;
            this.txtCreditAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditAmount.Location = new System.Drawing.Point(127, 175);
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(125, 21);
            this.txtCreditAmount.TabIndex = 74;
            this.txtCreditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(127, 80);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(125, 21);
            this.txtDeposit.TabIndex = 60;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // lblCAmendment
            // 
            this.lblCAmendment.AutoSize = true;
            this.lblCAmendment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAmendment.Location = new System.Drawing.Point(258, 146);
            this.lblCAmendment.Name = "lblCAmendment";
            this.lblCAmendment.Size = new System.Drawing.Size(29, 13);
            this.lblCAmendment.TabIndex = 70;
            this.lblCAmendment.Text = "MMK";
            // 
            // lblCCredit
            // 
            this.lblCCredit.AutoSize = true;
            this.lblCCredit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCredit.Location = new System.Drawing.Point(258, 178);
            this.lblCCredit.Name = "lblCCredit";
            this.lblCCredit.Size = new System.Drawing.Size(29, 13);
            this.lblCCredit.TabIndex = 71;
            this.lblCCredit.Text = "MMK";
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(15, 83);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(83, 13);
            this.lblDepositAmount.TabIndex = 64;
            this.lblDepositAmount.Text = "Deposit Amount";
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.AutoSize = true;
            this.lblCreditAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmount.Location = new System.Drawing.Point(15, 178);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(76, 13);
            this.lblCreditAmount.TabIndex = 65;
            this.lblCreditAmount.Text = "Credit Amount";
            // 
            // lblC1st
            // 
            this.lblC1st.AutoSize = true;
            this.lblC1st.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC1st.Location = new System.Drawing.Point(260, 113);
            this.lblC1st.Name = "lblC1st";
            this.lblC1st.Size = new System.Drawing.Size(29, 13);
            this.lblC1st.TabIndex = 69;
            this.lblC1st.Text = "MMK";
            // 
            // lblCDeposit
            // 
            this.lblCDeposit.AutoSize = true;
            this.lblCDeposit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDeposit.Location = new System.Drawing.Point(260, 83);
            this.lblCDeposit.Name = "lblCDeposit";
            this.lblCDeposit.Size = new System.Drawing.Size(29, 13);
            this.lblCDeposit.TabIndex = 68;
            this.lblCDeposit.Text = "MMK";
            // 
            // txtFirstPayment
            // 
            this.txtFirstPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPayment.Location = new System.Drawing.Point(127, 110);
            this.txtFirstPayment.Name = "txtFirstPayment";
            this.txtFirstPayment.Size = new System.Drawing.Size(125, 21);
            this.txtFirstPayment.TabIndex = 61;
            this.txtFirstPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFirstPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstPayment_KeyPress);
            // 
            // lbl1stPayment
            // 
            this.lbl1stPayment.AutoSize = true;
            this.lbl1stPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stPayment.Location = new System.Drawing.Point(15, 113);
            this.lbl1stPayment.Name = "lbl1stPayment";
            this.lbl1stPayment.Size = new System.Drawing.Size(67, 13);
            this.lbl1stPayment.TabIndex = 67;
            this.lbl1stPayment.Text = "1st Payment";
            // 
            // lblFianlPaymentAmount
            // 
            this.lblFianlPaymentAmount.AutoSize = true;
            this.lblFianlPaymentAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFianlPaymentAmount.Location = new System.Drawing.Point(14, 146);
            this.lblFianlPaymentAmount.Name = "lblFianlPaymentAmount";
            this.lblFianlPaymentAmount.Size = new System.Drawing.Size(109, 13);
            this.lblFianlPaymentAmount.TabIndex = 66;
            this.lblFianlPaymentAmount.Text = "Amendment Payment";
            // 
            // txtAmendmentPayment
            // 
            this.txtAmendmentPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmendmentPayment.Location = new System.Drawing.Point(127, 143);
            this.txtAmendmentPayment.Name = "txtAmendmentPayment";
            this.txtAmendmentPayment.Size = new System.Drawing.Size(125, 21);
            this.txtAmendmentPayment.TabIndex = 62;
            this.txtAmendmentPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmendmentPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmendmentPayment_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(147, 544);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 56);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(299, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(157, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(15, 15);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 31);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(86, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 31);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(228, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCash);
            this.groupBox1.Location = new System.Drawing.Point(937, 544);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 56);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(10, 15);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(65, 31);
            this.btnCash.TabIndex = 19;
            this.btnCash.Text = "&Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOrderCancel);
            this.groupBox4.Location = new System.Drawing.Point(605, 544);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(99, 56);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCancel.Location = new System.Drawing.Point(6, 16);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(88, 30);
            this.btnOrderCancel.TabIndex = 19;
            this.btnOrderCancel.Text = "Order Cancel";
            this.btnOrderCancel.UseVisualStyleBackColor = true;
            // 
            // gpbProduct
            // 
            this.gpbProduct.Controls.Add(this.btnProductLine);
            this.gpbProduct.Controls.Add(this.cboProductLine);
            this.gpbProduct.Controls.Add(this.lblProductLine);
            this.gpbProduct.Controls.Add(this.btnAdd);
            this.gpbProduct.Controls.Add(this.lblQuantity);
            this.gpbProduct.Controls.Add(this.btnProductName);
            this.gpbProduct.Controls.Add(this.txtQuantity);
            this.gpbProduct.Controls.Add(this.cboProductName);
            this.gpbProduct.Controls.Add(this.textBox11);
            this.gpbProduct.Controls.Add(this.label6);
            this.gpbProduct.Controls.Add(this.lblProductName);
            this.gpbProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProduct.Location = new System.Drawing.Point(6, 183);
            this.gpbProduct.Name = "gpbProduct";
            this.gpbProduct.Size = new System.Drawing.Size(798, 62);
            this.gpbProduct.TabIndex = 59;
            this.gpbProduct.TabStop = false;
            this.gpbProduct.Text = "Product";
            // 
            // btnProductLine
            // 
            this.btnProductLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductLine.Location = new System.Drawing.Point(255, 26);
            this.btnProductLine.Name = "btnProductLine";
            this.btnProductLine.Size = new System.Drawing.Size(29, 22);
            this.btnProductLine.TabIndex = 65;
            this.btnProductLine.Text = "...";
            this.btnProductLine.UseVisualStyleBackColor = true;
            // 
            // cboProductLine
            // 
            this.cboProductLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductLine.FormattingEnabled = true;
            this.cboProductLine.Location = new System.Drawing.Point(105, 27);
            this.cboProductLine.Name = "cboProductLine";
            this.cboProductLine.Size = new System.Drawing.Size(144, 21);
            this.cboProductLine.TabIndex = 64;
            this.cboProductLine.SelectedIndexChanged += new System.EventHandler(this.cboProductLine_SelectedIndexChanged);
            this.cboProductLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboProductLine_KeyPress);
            // 
            // lblProductLine
            // 
            this.lblProductLine.AutoSize = true;
            this.lblProductLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLine.Location = new System.Drawing.Point(15, 31);
            this.lblProductLine.Name = "lblProductLine";
            this.lblProductLine.Size = new System.Drawing.Size(66, 13);
            this.lblProductLine.TabIndex = 63;
            this.lblProductLine.Text = "Product Line";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(721, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 31);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(581, 31);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 59;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnProductName
            // 
            this.btnProductName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductName.Location = new System.Drawing.Point(524, 27);
            this.btnProductName.Name = "btnProductName";
            this.btnProductName.Size = new System.Drawing.Size(29, 24);
            this.btnProductName.TabIndex = 58;
            this.btnProductName.Text = "...";
            this.btnProductName.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(636, 28);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(79, 21);
            this.txtQuantity.TabIndex = 58;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // cboProductName
            // 
            this.cboProductName.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(390, 27);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(128, 24);
            this.cboProductName.TabIndex = 58;
            this.cboProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboProductName_KeyPress);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(157, 117);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(507, 89);
            this.textBox11.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 51;
            this.label6.Text = "Description";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(310, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(74, 13);
            this.lblProductName.TabIndex = 26;
            this.lblProductName.Text = "Product Name";
            // 
            // pnlPOS
            // 
            this.pnlPOS.Controls.Add(this.tbcSalesOrder);
            this.pnlPOS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPOS.Location = new System.Drawing.Point(3, 1);
            this.pnlPOS.Name = "pnlPOS";
            this.pnlPOS.Size = new System.Drawing.Size(1154, 662);
            this.pnlPOS.TabIndex = 7;
            // 
            // tbcSalesOrder
            // 
            this.tbcSalesOrder.Controls.Add(this.tbpSalesOrder);
            this.tbcSalesOrder.Controls.Add(this.tbpSearch);
            this.tbcSalesOrder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSalesOrder.Location = new System.Drawing.Point(9, 11);
            this.tbcSalesOrder.Name = "tbcSalesOrder";
            this.tbcSalesOrder.SelectedIndex = 0;
            this.tbcSalesOrder.Size = new System.Drawing.Size(1142, 642);
            this.tbcSalesOrder.TabIndex = 60;
            // 
            // tbpSalesOrder
            // 
            this.tbpSalesOrder.Controls.Add(this.gpbBasicInfo);
            this.tbpSalesOrder.Controls.Add(this.groupBox4);
            this.tbpSalesOrder.Controls.Add(this.gpbProduct);
            this.tbpSalesOrder.Controls.Add(this.groupBox1);
            this.tbpSalesOrder.Controls.Add(this.gpbSalesOrderInfo);
            this.tbpSalesOrder.Controls.Add(this.groupBox3);
            this.tbpSalesOrder.Controls.Add(this.gpbVoucher);
            this.tbpSalesOrder.Controls.Add(this.gpbPaymentInfo);
            this.tbpSalesOrder.Location = new System.Drawing.Point(4, 22);
            this.tbpSalesOrder.Name = "tbpSalesOrder";
            this.tbpSalesOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSalesOrder.Size = new System.Drawing.Size(1134, 616);
            this.tbpSalesOrder.TabIndex = 0;
            this.tbpSalesOrder.Text = "Sales Order";
            this.tbpSalesOrder.UseVisualStyleBackColor = true;
            // 
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.reportViewer1);
            this.tbpSearch.Controls.Add(this.gpbSearch);
            this.tbpSearch.Controls.Add(this.dgvSSalesOrder);
            this.tbpSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearch.Size = new System.Drawing.Size(1134, 616);
            this.tbpSearch.TabIndex = 1;
            this.tbpSearch.Text = "Search";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // frmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 661);
            this.Controls.Add(this.pnlPOS);
            this.MaximizeBox = false;
            this.Name = "frmSalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order";
            this.Load += new System.EventHandler(this.frmSalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSSalesOrder)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbSalesOrderInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).EndInit();
            this.gpbVoucher.ResumeLayout(false);
            this.gpbVoucher.PerformLayout();
            this.gpbPaymentInfo.ResumeLayout(false);
            this.gpbPaymentInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gpbProduct.ResumeLayout(false);
            this.gpbProduct.PerformLayout();
            this.pnlPOS.ResumeLayout(false);
            this.tbcSalesOrder.ResumeLayout(false);
            this.tbpSalesOrder.ResumeLayout(false);
            this.tbpSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSSalesOrderID;
        private System.Windows.Forms.TextBox txtSSalesOrderID;
        private System.Windows.Forms.CheckBox chkSCustomerName;
        private System.Windows.Forms.DateTimePicker dtpSToDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.DateTimePicker dtpSFromDate;
        private System.Windows.Forms.CheckBox chkSDate;
        private System.Windows.Forms.DataGridView dgvSSalesOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblMembershipShow;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblCustomerTypeShow;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblNRCShow;
        private System.Windows.Forms.Label lblNRC;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSalesOrderID;
        private System.Windows.Forms.TextBox txtSOID;
        private System.Windows.Forms.GroupBox gpbSalesOrderInfo;
        private System.Windows.Forms.DataGridView dgvSalesOrder;
        private System.Windows.Forms.GroupBox gpbVoucher;
        private System.Windows.Forms.Label lblCGrandTotal;
        private System.Windows.Forms.Label lblCServiceCharges;
        private System.Windows.Forms.Label lblCTax;
        private System.Windows.Forms.Label lblCMemberPromotion;
        private System.Windows.Forms.Label lblCMemberPomotionPercentage;
        private System.Windows.Forms.Label lblCSubTotal;
        private System.Windows.Forms.TextBox txtMemberPromotion;
        private System.Windows.Forms.Label lblMemberPromotion;
        private System.Windows.Forms.TextBox txtMemberPromotionPercentage;
        private System.Windows.Forms.Label lblServiceCharges;
        private System.Windows.Forms.TextBox txtServiceCharges;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.GroupBox gpbPaymentInfo;
        private System.Windows.Forms.RadioButton rdbDebitPay;
        private System.Windows.Forms.RadioButton rdbCreditPay;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblCAmendment;
        private System.Windows.Forms.Label lblCCredit;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.Label lblC1st;
        private System.Windows.Forms.Label lblCDeposit;
        private System.Windows.Forms.TextBox txtFirstPayment;
        private System.Windows.Forms.Label lbl1stPayment;
        private System.Windows.Forms.Label lblFianlPaymentAmount;
        private System.Windows.Forms.TextBox txtAmendmentPayment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOrderCancel;
        private System.Windows.Forms.GroupBox gpbProduct;
        private System.Windows.Forms.Button btnProductLine;
        private System.Windows.Forms.ComboBox cboProductLine;
        private System.Windows.Forms.Label lblProductLine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel pnlPOS;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.CheckBox chkSCancelOrders;
        private System.Windows.Forms.CheckBox chkSDebitPay;
        private System.Windows.Forms.CheckBox chkSCreditPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotionPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotion;
        private System.Windows.Forms.TabControl tbcSalesOrder;
        private System.Windows.Forms.TabPage tbpSalesOrder;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.TextBox txtSCustomerName;
    }
}