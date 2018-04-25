namespace EAB_Business_Solution.Forms
{
    partial class frmPO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.dtpSToDate = new System.Windows.Forms.DateTimePicker();
            this.lblSTo = new System.Windows.Forms.Label();
            this.dtpSFromDate = new System.Windows.Forms.DateTimePicker();
            this.cboSStatus = new System.Windows.Forms.ComboBox();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSPurchaseOrderID = new System.Windows.Forms.CheckBox();
            this.txtSPOID = new System.Windows.Forms.TextBox();
            this.chkSStatus = new System.Windows.Forms.CheckBox();
            this.cboSSupplier = new System.Windows.Forms.ComboBox();
            this.chkSDate = new System.Windows.Forms.CheckBox();
            this.chkSSupplier = new System.Windows.Forms.CheckBox();
            this.gpbProduct = new System.Windows.Forms.GroupBox();
            this.btnUOM = new System.Windows.Forms.Button();
            this.cboUOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gpbPrint = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.chkReject = new System.Windows.Forms.CheckBox();
            this.chkAccept = new System.Windows.Forms.CheckBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.gpbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.lblCCredit = new System.Windows.Forms.Label();
            this.lblCAmendment = new System.Windows.Forms.Label();
            this.lblC1st = new System.Windows.Forms.Label();
            this.lblCDeposit = new System.Windows.Forms.Label();
            this.lblCTotal = new System.Windows.Forms.Label();
            this.lbl1stPayment = new System.Windows.Forms.Label();
            this.txtAmendmentPayment = new System.Windows.Forms.TextBox();
            this.lblFianlPaymentAmount = new System.Windows.Forms.Label();
            this.txtFirstPayment = new System.Windows.Forms.TextBox();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gpbItemInfo = new System.Windows.Forms.GroupBox();
            this.dgvProductInfo = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWHName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPuchaseOrderID = new System.Windows.Forms.Label();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcPurchaseOrder = new System.Windows.Forms.TabControl();
            this.tbpPurchaseOrder = new System.Windows.Forms.TabPage();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPurchaseOrder)).BeginInit();
            this.gpbSControl.SuspendLayout();
            this.gpbProduct.SuspendLayout();
            this.gpbPrint.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbStatus.SuspendLayout();
            this.gpbPaymentInfo.SuspendLayout();
            this.gpbItemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).BeginInit();
            this.gpbBasicInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tbcPurchaseOrder.SuspendLayout();
            this.tbpPurchaseOrder.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSPurchaseOrder
            // 
            this.dgvSPurchaseOrder.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPurchaseOrder.Location = new System.Drawing.Point(6, 217);
            this.dgvSPurchaseOrder.Name = "dgvSPurchaseOrder";
            this.dgvSPurchaseOrder.ReadOnly = true;
            this.dgvSPurchaseOrder.Size = new System.Drawing.Size(893, 441);
            this.dgvSPurchaseOrder.TabIndex = 14;
            this.dgvSPurchaseOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSPurchaseOrder_CellContentClick);
            this.dgvSPurchaseOrder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSPurchaseOrder_CellDoubleClick);
            this.dgvSPurchaseOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSPurchaseOrder_CellDoubleClick);
            // 
            // dtpSToDate
            // 
            this.dtpSToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.CustomFormat = "dd MMM yyyy";
            this.dtpSToDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSToDate.Location = new System.Drawing.Point(386, 90);
            this.dtpSToDate.Name = "dtpSToDate";
            this.dtpSToDate.Size = new System.Drawing.Size(136, 21);
            this.dtpSToDate.TabIndex = 5;
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(441, 74);
            this.lblSTo.Name = "lblSTo";
            this.lblSTo.Size = new System.Drawing.Size(19, 13);
            this.lblSTo.TabIndex = 59;
            this.lblSTo.Text = "To";
            // 
            // dtpSFromDate
            // 
            this.dtpSFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpSFromDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSFromDate.Location = new System.Drawing.Point(386, 44);
            this.dtpSFromDate.Name = "dtpSFromDate";
            this.dtpSFromDate.Size = new System.Drawing.Size(136, 21);
            this.dtpSFromDate.TabIndex = 4;
            // 
            // cboSStatus
            // 
            this.cboSStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSStatus.FormattingEnabled = true;
            this.cboSStatus.Items.AddRange(new object[] {
            "Approve",
            "Reject",
            "Deposit",
            "1st Payment",
            "Amendment"});
            this.cboSStatus.Location = new System.Drawing.Point(179, 42);
            this.cboSStatus.Name = "cboSStatus";
            this.cboSStatus.Size = new System.Drawing.Size(125, 21);
            this.cboSStatus.TabIndex = 9;
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnSShowAll);
            this.gpbSControl.Controls.Add(this.btnSSearch);
            this.gpbSControl.Location = new System.Drawing.Point(199, 132);
            this.gpbSControl.Name = "gpbSControl";
            this.gpbSControl.Size = new System.Drawing.Size(152, 58);
            this.gpbSControl.TabIndex = 16;
            this.gpbSControl.TabStop = false;
            // 
            // btnSShowAll
            // 
            this.btnSShowAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSShowAll.Location = new System.Drawing.Point(77, 16);
            this.btnSShowAll.Name = "btnSShowAll";
            this.btnSShowAll.Size = new System.Drawing.Size(65, 31);
            this.btnSShowAll.TabIndex = 11;
            this.btnSShowAll.Text = "Show &All";
            this.btnSShowAll.UseVisualStyleBackColor = true;
            this.btnSShowAll.Click += new System.EventHandler(this.btnSShowAll_Click);
            // 
            // btnSSearch
            // 
            this.btnSSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSearch.Location = new System.Drawing.Point(6, 16);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(65, 31);
            this.btnSSearch.TabIndex = 10;
            this.btnSSearch.Text = "Searc&h";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
            // 
            // chkSPurchaseOrderID
            // 
            this.chkSPurchaseOrderID.AutoSize = true;
            this.chkSPurchaseOrderID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSPurchaseOrderID.Location = new System.Drawing.Point(21, 20);
            this.chkSPurchaseOrderID.Name = "chkSPurchaseOrderID";
            this.chkSPurchaseOrderID.Size = new System.Drawing.Size(115, 17);
            this.chkSPurchaseOrderID.TabIndex = 1;
            this.chkSPurchaseOrderID.Text = "Purchase Order ID";
            this.chkSPurchaseOrderID.UseVisualStyleBackColor = true;
            this.chkSPurchaseOrderID.CheckedChanged += new System.EventHandler(this.chkSPurchaseOrderID_CheckedChanged);
            // 
            // txtSPOID
            // 
            this.txtSPOID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPOID.Location = new System.Drawing.Point(21, 42);
            this.txtSPOID.Name = "txtSPOID";
            this.txtSPOID.Size = new System.Drawing.Size(125, 21);
            this.txtSPOID.TabIndex = 2;
            // 
            // chkSStatus
            // 
            this.chkSStatus.AutoSize = true;
            this.chkSStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSStatus.Location = new System.Drawing.Point(179, 20);
            this.chkSStatus.Name = "chkSStatus";
            this.chkSStatus.Size = new System.Drawing.Size(57, 17);
            this.chkSStatus.TabIndex = 8;
            this.chkSStatus.Text = "Status";
            this.chkSStatus.UseVisualStyleBackColor = true;
            this.chkSStatus.CheckedChanged += new System.EventHandler(this.chkSStatus_CheckedChanged);
            // 
            // cboSSupplier
            // 
            this.cboSSupplier.FormattingEnabled = true;
            this.cboSSupplier.Location = new System.Drawing.Point(179, 91);
            this.cboSSupplier.Name = "cboSSupplier";
            this.cboSSupplier.Size = new System.Drawing.Size(172, 21);
            this.cboSSupplier.TabIndex = 7;
            // 
            // chkSDate
            // 
            this.chkSDate.AutoSize = true;
            this.chkSDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSDate.Location = new System.Drawing.Point(386, 20);
            this.chkSDate.Name = "chkSDate";
            this.chkSDate.Size = new System.Drawing.Size(49, 17);
            this.chkSDate.TabIndex = 3;
            this.chkSDate.Text = "Date";
            this.chkSDate.UseVisualStyleBackColor = true;
            this.chkSDate.CheckedChanged += new System.EventHandler(this.chkSDate_CheckedChanged);
            // 
            // chkSSupplier
            // 
            this.chkSSupplier.AutoSize = true;
            this.chkSSupplier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSSupplier.Location = new System.Drawing.Point(179, 71);
            this.chkSSupplier.Name = "chkSSupplier";
            this.chkSSupplier.Size = new System.Drawing.Size(64, 17);
            this.chkSSupplier.TabIndex = 6;
            this.chkSSupplier.Text = "Supplier";
            this.chkSSupplier.UseVisualStyleBackColor = true;
            this.chkSSupplier.CheckedChanged += new System.EventHandler(this.chkSSupplier_CheckedChanged);
            // 
            // gpbProduct
            // 
            this.gpbProduct.Controls.Add(this.btnUOM);
            this.gpbProduct.Controls.Add(this.cboUOM);
            this.gpbProduct.Controls.Add(this.label1);
            this.gpbProduct.Controls.Add(this.btnAdd);
            this.gpbProduct.Controls.Add(this.lblPrice);
            this.gpbProduct.Controls.Add(this.txtPrice);
            this.gpbProduct.Controls.Add(this.lblQuantity);
            this.gpbProduct.Controls.Add(this.btnProduct);
            this.gpbProduct.Controls.Add(this.txtQuantity);
            this.gpbProduct.Controls.Add(this.cboProductName);
            this.gpbProduct.Controls.Add(this.lblProductName);
            this.gpbProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProduct.Location = new System.Drawing.Point(6, 178);
            this.gpbProduct.Name = "gpbProduct";
            this.gpbProduct.Size = new System.Drawing.Size(584, 96);
            this.gpbProduct.TabIndex = 2;
            this.gpbProduct.TabStop = false;
            this.gpbProduct.Text = "Product";
            // 
            // btnUOM
            // 
            this.btnUOM.Location = new System.Drawing.Point(280, 56);
            this.btnUOM.Name = "btnUOM";
            this.btnUOM.Size = new System.Drawing.Size(29, 24);
            this.btnUOM.TabIndex = 9;
            this.btnUOM.Text = "...";
            this.btnUOM.UseVisualStyleBackColor = true;
            this.btnUOM.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboUOM
            // 
            this.cboUOM.DropDownHeight = 150;
            this.cboUOM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUOM.FormattingEnabled = true;
            this.cboUOM.IntegralHeight = false;
            this.cboUOM.Location = new System.Drawing.Point(129, 58);
            this.cboUOM.Name = "cboUOM";
            this.cboUOM.Size = new System.Drawing.Size(144, 21);
            this.cboUOM.TabIndex = 8;
            this.cboUOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUOM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "UOM";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(499, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 31);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(342, 61);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 61;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(401, 58);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(79, 21);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(342, 32);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 59;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(280, 26);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(29, 24);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.Text = "...";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(401, 27);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(79, 21);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // cboProductName
            // 
            this.cboProductName.DropDownHeight = 150;
            this.cboProductName.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.IntegralHeight = false;
            this.cboProductName.ItemHeight = 16;
            this.cboProductName.Location = new System.Drawing.Point(130, 26);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(144, 24);
            this.cboProductName.TabIndex = 6;
            this.cboProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboProductName_KeyPress);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(22, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(74, 13);
            this.lblProductName.TabIndex = 26;
            this.lblProductName.Text = "Product Name";
            // 
            // gpbPrint
            // 
            this.gpbPrint.Controls.Add(this.btnPrint);
            this.gpbPrint.Location = new System.Drawing.Point(705, 594);
            this.gpbPrint.Name = "gpbPrint";
            this.gpbPrint.Size = new System.Drawing.Size(78, 56);
            this.gpbPrint.TabIndex = 6;
            this.gpbPrint.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(6, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 31);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(173, 593);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(308, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 31);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(166, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 31);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(21, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 31);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(95, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 31);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(237, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 31);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.chkReject);
            this.gpbStatus.Controls.Add(this.chkAccept);
            this.gpbStatus.Controls.Add(this.txtRemark);
            this.gpbStatus.Controls.Add(this.lblRemark);
            this.gpbStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStatus.Location = new System.Drawing.Point(596, 178);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(309, 96);
            this.gpbStatus.TabIndex = 4;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Text = "Status";
            // 
            // chkReject
            // 
            this.chkReject.AutoSize = true;
            this.chkReject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReject.Location = new System.Drawing.Point(184, 21);
            this.chkReject.Name = "chkReject";
            this.chkReject.Size = new System.Drawing.Size(57, 17);
            this.chkReject.TabIndex = 19;
            this.chkReject.Text = "Reject";
            this.chkReject.UseVisualStyleBackColor = true;
            // 
            // chkAccept
            // 
            this.chkAccept.AutoSize = true;
            this.chkAccept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccept.Location = new System.Drawing.Point(100, 21);
            this.chkAccept.Name = "chkAccept";
            this.chkAccept.Size = new System.Drawing.Size(59, 17);
            this.chkAccept.TabIndex = 18;
            this.chkAccept.Text = "Accept";
            this.chkAccept.UseVisualStyleBackColor = true;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(70, 49);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(228, 30);
            this.txtRemark.TabIndex = 20;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(11, 49);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(43, 13);
            this.lblRemark.TabIndex = 26;
            this.lblRemark.Text = "Remark";
            // 
            // gpbPaymentInfo
            // 
            this.gpbPaymentInfo.Controls.Add(this.lblCCredit);
            this.gpbPaymentInfo.Controls.Add(this.lblCAmendment);
            this.gpbPaymentInfo.Controls.Add(this.lblC1st);
            this.gpbPaymentInfo.Controls.Add(this.lblCDeposit);
            this.gpbPaymentInfo.Controls.Add(this.lblCTotal);
            this.gpbPaymentInfo.Controls.Add(this.lbl1stPayment);
            this.gpbPaymentInfo.Controls.Add(this.txtAmendmentPayment);
            this.gpbPaymentInfo.Controls.Add(this.lblFianlPaymentAmount);
            this.gpbPaymentInfo.Controls.Add(this.txtFirstPayment);
            this.gpbPaymentInfo.Controls.Add(this.txtCreditAmount);
            this.gpbPaymentInfo.Controls.Add(this.lblCreditAmount);
            this.gpbPaymentInfo.Controls.Add(this.txtDepositAmount);
            this.gpbPaymentInfo.Controls.Add(this.lblDepositAmount);
            this.gpbPaymentInfo.Controls.Add(this.lblTotal);
            this.gpbPaymentInfo.Controls.Add(this.txtTotal);
            this.gpbPaymentInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPaymentInfo.Location = new System.Drawing.Point(595, 7);
            this.gpbPaymentInfo.Name = "gpbPaymentInfo";
            this.gpbPaymentInfo.Size = new System.Drawing.Size(309, 165);
            this.gpbPaymentInfo.TabIndex = 3;
            this.gpbPaymentInfo.TabStop = false;
            this.gpbPaymentInfo.Text = "Payment Information";
            // 
            // lblCCredit
            // 
            this.lblCCredit.AutoSize = true;
            this.lblCCredit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCredit.Location = new System.Drawing.Point(269, 134);
            this.lblCCredit.Name = "lblCCredit";
            this.lblCCredit.Size = new System.Drawing.Size(29, 13);
            this.lblCCredit.TabIndex = 41;
            this.lblCCredit.Text = "MMK";
            // 
            // lblCAmendment
            // 
            this.lblCAmendment.AutoSize = true;
            this.lblCAmendment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAmendment.Location = new System.Drawing.Point(269, 107);
            this.lblCAmendment.Name = "lblCAmendment";
            this.lblCAmendment.Size = new System.Drawing.Size(29, 13);
            this.lblCAmendment.TabIndex = 40;
            this.lblCAmendment.Text = "MMK";
            // 
            // lblC1st
            // 
            this.lblC1st.AutoSize = true;
            this.lblC1st.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC1st.Location = new System.Drawing.Point(269, 80);
            this.lblC1st.Name = "lblC1st";
            this.lblC1st.Size = new System.Drawing.Size(29, 13);
            this.lblC1st.TabIndex = 39;
            this.lblC1st.Text = "MMK";
            // 
            // lblCDeposit
            // 
            this.lblCDeposit.AutoSize = true;
            this.lblCDeposit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDeposit.Location = new System.Drawing.Point(269, 53);
            this.lblCDeposit.Name = "lblCDeposit";
            this.lblCDeposit.Size = new System.Drawing.Size(29, 13);
            this.lblCDeposit.TabIndex = 38;
            this.lblCDeposit.Text = "MMK";
            // 
            // lblCTotal
            // 
            this.lblCTotal.AutoSize = true;
            this.lblCTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTotal.Location = new System.Drawing.Point(269, 27);
            this.lblCTotal.Name = "lblCTotal";
            this.lblCTotal.Size = new System.Drawing.Size(29, 13);
            this.lblCTotal.TabIndex = 37;
            this.lblCTotal.Text = "MMK";
            // 
            // lbl1stPayment
            // 
            this.lbl1stPayment.AutoSize = true;
            this.lbl1stPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stPayment.Location = new System.Drawing.Point(17, 80);
            this.lbl1stPayment.Name = "lbl1stPayment";
            this.lbl1stPayment.Size = new System.Drawing.Size(67, 13);
            this.lbl1stPayment.TabIndex = 36;
            this.lbl1stPayment.Text = "1st Payment";
            // 
            // txtAmendmentPayment
            // 
            this.txtAmendmentPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmendmentPayment.Location = new System.Drawing.Point(138, 104);
            this.txtAmendmentPayment.Name = "txtAmendmentPayment";
            this.txtAmendmentPayment.Size = new System.Drawing.Size(125, 21);
            this.txtAmendmentPayment.TabIndex = 16;
            this.txtAmendmentPayment.Text = "0.00";
            this.txtAmendmentPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmendmentPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmendmentPayment_KeyPress);
            // 
            // lblFianlPaymentAmount
            // 
            this.lblFianlPaymentAmount.AutoSize = true;
            this.lblFianlPaymentAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFianlPaymentAmount.Location = new System.Drawing.Point(15, 107);
            this.lblFianlPaymentAmount.Name = "lblFianlPaymentAmount";
            this.lblFianlPaymentAmount.Size = new System.Drawing.Size(109, 13);
            this.lblFianlPaymentAmount.TabIndex = 34;
            this.lblFianlPaymentAmount.Text = "Amendment Payment";
            // 
            // txtFirstPayment
            // 
            this.txtFirstPayment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPayment.Location = new System.Drawing.Point(138, 77);
            this.txtFirstPayment.Name = "txtFirstPayment";
            this.txtFirstPayment.Size = new System.Drawing.Size(125, 21);
            this.txtFirstPayment.TabIndex = 15;
            this.txtFirstPayment.Text = "0.00";
            this.txtFirstPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFirstPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstPayment_KeyPress);
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Enabled = false;
            this.txtCreditAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditAmount.Location = new System.Drawing.Point(138, 131);
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(125, 21);
            this.txtCreditAmount.TabIndex = 17;
            this.txtCreditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.AutoSize = true;
            this.lblCreditAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmount.Location = new System.Drawing.Point(15, 134);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(76, 13);
            this.lblCreditAmount.TabIndex = 30;
            this.lblCreditAmount.Text = "Credit Amount";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositAmount.Location = new System.Drawing.Point(138, 50);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(125, 21);
            this.txtDepositAmount.TabIndex = 14;
            this.txtDepositAmount.Text = "0.00";
            this.txtDepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDepositAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepositAmount_KeyPress);
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(17, 53);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(83, 13);
            this.lblDepositAmount.TabIndex = 28;
            this.lblDepositAmount.Text = "Deposit Amount";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(17, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(138, 24);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 21);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gpbItemInfo
            // 
            this.gpbItemInfo.Controls.Add(this.dgvProductInfo);
            this.gpbItemInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbItemInfo.Location = new System.Drawing.Point(6, 280);
            this.gpbItemInfo.Name = "gpbItemInfo";
            this.gpbItemInfo.Size = new System.Drawing.Size(899, 307);
            this.gpbItemInfo.TabIndex = 1;
            this.gpbItemInfo.TabStop = false;
            this.gpbItemInfo.Text = "Item Infomation";
            // 
            // dgvProductInfo
            // 
            this.dgvProductInfo.AllowUserToOrderColumns = true;
            this.dgvProductInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colWHName,
            this.colQuantity,
            this.colUnit,
            this.colPrice,
            this.colAmount,
            this.colCurrency,
            this.colStockBalance,
            this.colOrderAvailableQuantity});
            this.dgvProductInfo.Location = new System.Drawing.Point(11, 21);
            this.dgvProductInfo.Name = "dgvProductInfo";
            this.dgvProductInfo.Size = new System.Drawing.Size(877, 269);
            this.dgvProductInfo.TabIndex = 21;
            this.dgvProductInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductInfo_CellContentClick);
            this.dgvProductInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductInfo_CellDoubleClick);
            this.dgvProductInfo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductInfo_CellMouseUp);
            this.dgvProductInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProductInfo_DataError);
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            this.colProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductID.Width = 83;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductName.Width = 99;
            // 
            // colWHName
            // 
            this.colWHName.HeaderText = "Warehouse";
            this.colWHName.Name = "colWHName";
            this.colWHName.ReadOnly = true;
            this.colWHName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWHName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colCurrency
            // 
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            // 
            // colStockBalance
            // 
            this.colStockBalance.HeaderText = "Stock Balance";
            this.colStockBalance.Name = "colStockBalance";
            this.colStockBalance.Visible = false;
            // 
            // colOrderAvailableQuantity
            // 
            this.colOrderAvailableQuantity.HeaderText = "Order Available Quantity";
            this.colOrderAvailableQuantity.Name = "colOrderAvailableQuantity";
            this.colOrderAvailableQuantity.Visible = false;
            // 
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.txtDescription);
            this.gpbBasicInfo.Controls.Add(this.lblDescription);
            this.gpbBasicInfo.Controls.Add(this.btnSupplier);
            this.gpbBasicInfo.Controls.Add(this.cboSupplier);
            this.gpbBasicInfo.Controls.Add(this.lblSupplier);
            this.gpbBasicInfo.Controls.Add(this.dtpDate);
            this.gpbBasicInfo.Controls.Add(this.lblDate);
            this.gpbBasicInfo.Controls.Add(this.lblPuchaseOrderID);
            this.gpbBasicInfo.Controls.Add(this.txtPOID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(6, 7);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(583, 165);
            this.gpbBasicInfo.TabIndex = 1;
            this.gpbBasicInfo.TabStop = false;
            this.gpbBasicInfo.Text = "Basic Infomation";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(129, 83);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(434, 69);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(17, 86);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 51;
            this.lblDescription.Text = "Description";
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(307, 53);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(29, 24);
            this.btnSupplier.TabIndex = 4;
            this.btnSupplier.Text = "...";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // cboSupplier
            // 
            this.cboSupplier.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(129, 53);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(172, 24);
            this.cboSupplier.TabIndex = 3;
            this.cboSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSupplier_KeyPress);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(17, 59);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 57;
            this.lblSupplier.Text = "Supplier";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CustomFormat = "dd MMM yyyy";
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(427, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(136, 21);
            this.dtpDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(389, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // lblPuchaseOrderID
            // 
            this.lblPuchaseOrderID.AutoSize = true;
            this.lblPuchaseOrderID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuchaseOrderID.Location = new System.Drawing.Point(17, 29);
            this.lblPuchaseOrderID.Name = "lblPuchaseOrderID";
            this.lblPuchaseOrderID.Size = new System.Drawing.Size(96, 13);
            this.lblPuchaseOrderID.TabIndex = 26;
            this.lblPuchaseOrderID.Text = "Purchase Order ID";
            // 
            // txtPOID
            // 
            this.txtPOID.Enabled = false;
            this.txtPOID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOID.Location = new System.Drawing.Point(129, 26);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(125, 21);
            this.txtPOID.TabIndex = 1;
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
            // tbcPurchaseOrder
            // 
            this.tbcPurchaseOrder.Controls.Add(this.tbpPurchaseOrder);
            this.tbcPurchaseOrder.Controls.Add(this.tbpSearch);
            this.tbcPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPurchaseOrder.Location = new System.Drawing.Point(12, 12);
            this.tbcPurchaseOrder.Name = "tbcPurchaseOrder";
            this.tbcPurchaseOrder.SelectedIndex = 0;
            this.tbcPurchaseOrder.Size = new System.Drawing.Size(919, 690);
            this.tbcPurchaseOrder.TabIndex = 61;
            // 
            // tbpPurchaseOrder
            // 
            this.tbpPurchaseOrder.Controls.Add(this.gpbBasicInfo);
            this.tbpPurchaseOrder.Controls.Add(this.gpbPaymentInfo);
            this.tbpPurchaseOrder.Controls.Add(this.gpbProduct);
            this.tbpPurchaseOrder.Controls.Add(this.gpbPrint);
            this.tbpPurchaseOrder.Controls.Add(this.gpbItemInfo);
            this.tbpPurchaseOrder.Controls.Add(this.groupBox1);
            this.tbpPurchaseOrder.Controls.Add(this.gpbStatus);
            this.tbpPurchaseOrder.Location = new System.Drawing.Point(4, 22);
            this.tbpPurchaseOrder.Name = "tbpPurchaseOrder";
            this.tbpPurchaseOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPurchaseOrder.Size = new System.Drawing.Size(911, 664);
            this.tbpPurchaseOrder.TabIndex = 0;
            this.tbpPurchaseOrder.Text = "Purchase Order";
            this.tbpPurchaseOrder.UseVisualStyleBackColor = true;
            // 
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.dgvSPurchaseOrder);
            this.tbpSearch.Controls.Add(this.reportViewer1);
            this.tbpSearch.Controls.Add(this.groupBox9);
            this.tbpSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearch.Size = new System.Drawing.Size(911, 664);
            this.tbpSearch.TabIndex = 1;
            this.tbpSearch.Text = "Search";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EAB_Business_Solution.Report.SOReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(262, 243);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 70;
            this.reportViewer1.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.gpbSControl);
            this.groupBox9.Controls.Add(this.cboSStatus);
            this.groupBox9.Controls.Add(this.dtpSToDate);
            this.groupBox9.Controls.Add(this.chkSStatus);
            this.groupBox9.Controls.Add(this.lblSTo);
            this.groupBox9.Controls.Add(this.cboSSupplier);
            this.groupBox9.Controls.Add(this.chkSPurchaseOrderID);
            this.groupBox9.Controls.Add(this.chkSSupplier);
            this.groupBox9.Controls.Add(this.dtpSFromDate);
            this.groupBox9.Controls.Add(this.txtSPOID);
            this.groupBox9.Controls.Add(this.chkSDate);
            this.groupBox9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(198, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(545, 205);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Search Filter";
            // 
            // frmPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 716);
            this.Controls.Add(this.tbcPurchaseOrder);
            this.MaximizeBox = false;
            this.Name = "frmPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.frmPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPurchaseOrder)).EndInit();
            this.gpbSControl.ResumeLayout(false);
            this.gpbProduct.ResumeLayout(false);
            this.gpbProduct.PerformLayout();
            this.gpbPrint.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            this.gpbPaymentInfo.ResumeLayout(false);
            this.gpbPaymentInfo.PerformLayout();
            this.gpbItemInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).EndInit();
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tbcPurchaseOrder.ResumeLayout(false);
            this.tbpPurchaseOrder.ResumeLayout(false);
            this.tbpSearch.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        //private void deleteRowToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        

        #endregion

        private System.Windows.Forms.GroupBox gpbItemInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPuchaseOrderID;
        private System.Windows.Forms.TextBox txtPOID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.GroupBox gpbPaymentInfo;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lbl1stPayment;
        private System.Windows.Forms.TextBox txtAmendmentPayment;
        private System.Windows.Forms.Label lblFianlPaymentAmount;
        private System.Windows.Forms.TextBox txtFirstPayment;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.CheckBox chkReject;
        private System.Windows.Forms.CheckBox chkAccept;
        private System.Windows.Forms.GroupBox gpbPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCCredit;
        private System.Windows.Forms.Label lblCAmendment;
        private System.Windows.Forms.Label lblC1st;
        private System.Windows.Forms.Label lblCDeposit;
        private System.Windows.Forms.Label lblCTotal;
        private System.Windows.Forms.GroupBox gpbProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvSPurchaseOrder;
        private System.Windows.Forms.DateTimePicker dtpSToDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.DateTimePicker dtpSFromDate;
        private System.Windows.Forms.ComboBox cboSStatus;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSPurchaseOrderID;
        private System.Windows.Forms.TextBox txtSPOID;
        private System.Windows.Forms.CheckBox chkSStatus;
        private System.Windows.Forms.ComboBox cboSSupplier;
        private System.Windows.Forms.CheckBox chkSDate;
        private System.Windows.Forms.CheckBox chkSSupplier;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWHName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderAvailableQuantity;
        private System.Windows.Forms.TabControl tbcPurchaseOrder;
        private System.Windows.Forms.TabPage tbpPurchaseOrder;
        private System.Windows.Forms.TabPage tbpSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnUOM;
        private System.Windows.Forms.ComboBox cboUOM;
        private System.Windows.Forms.Label label1;
    }
}