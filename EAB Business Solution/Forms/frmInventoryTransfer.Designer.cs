namespace EAB_Business_Solution.Forms
{
    partial class frmInventoryTransfer
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
            this.pnlPurchaseOrder = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbProductTransferInfo = new System.Windows.Forms.GroupBox();
            this.dgvInventoryTransfer = new System.Windows.Forms.DataGridView();
            this.gpbInventoryTransferInfo = new System.Windows.Forms.GroupBox();
            this.cboTransferFrom = new System.Windows.Forms.ComboBox();
            this.lblTransferFrom = new System.Windows.Forms.Label();
            this.dtpTransferDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransferDate = new System.Windows.Forms.Label();
            this.lblInventoryTransferID = new System.Windows.Forms.Label();
            this.txtStockRequestID = new System.Windows.Forms.TextBox();
            this.ssCompany = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.cboTransferTo = new System.Windows.Forms.ComboBox();
            this.lblTransferTo = new System.Windows.Forms.Label();
            this.lblStockRequetID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransferableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientStockBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMyStockBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransferQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlSInventoryTransfer = new System.Windows.Forms.Panel();
            this.dgvSInventoryTransfer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.chkSInventoryTransferID = new System.Windows.Forms.CheckBox();
            this.txtSInventoryTransferID = new System.Windows.Forms.TextBox();
            this.cboSFromWarehouse = new System.Windows.Forms.ComboBox();
            this.chkSFromWarehouse = new System.Windows.Forms.CheckBox();
            this.dtpSToDate = new System.Windows.Forms.DateTimePicker();
            this.lblSTo = new System.Windows.Forms.Label();
            this.dtpSFromDate = new System.Windows.Forms.DateTimePicker();
            this.chkSTransferDate = new System.Windows.Forms.CheckBox();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.cboSToWarehouse = new System.Windows.Forms.ComboBox();
            this.chkSToWarehouse = new System.Windows.Forms.CheckBox();
            this.cboSProductName = new System.Windows.Forms.ComboBox();
            this.chkSProductName = new System.Windows.Forms.CheckBox();
            this.pnlPurchaseOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbProductTransferInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTransfer)).BeginInit();
            this.gpbInventoryTransferInfo.SuspendLayout();
            this.ssCompany.SuspendLayout();
            this.gpbDescription.SuspendLayout();
            this.pnlSInventoryTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSInventoryTransfer)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPurchaseOrder
            // 
            this.pnlPurchaseOrder.Controls.Add(this.gpbDescription);
            this.pnlPurchaseOrder.Controls.Add(this.groupBox1);
            this.pnlPurchaseOrder.Controls.Add(this.gpbProductTransferInfo);
            this.pnlPurchaseOrder.Controls.Add(this.gpbInventoryTransferInfo);
            this.pnlPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPurchaseOrder.Location = new System.Drawing.Point(3, 0);
            this.pnlPurchaseOrder.Name = "pnlPurchaseOrder";
            this.pnlPurchaseOrder.Size = new System.Drawing.Size(957, 541);
            this.pnlPurchaseOrder.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(170, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(510, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 31);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Searc&h";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(219, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(21, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 31);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(118, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 31);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(318, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gpbProductTransferInfo
            // 
            this.gpbProductTransferInfo.Controls.Add(this.dgvInventoryTransfer);
            this.gpbProductTransferInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductTransferInfo.Location = new System.Drawing.Point(12, 193);
            this.gpbProductTransferInfo.Name = "gpbProductTransferInfo";
            this.gpbProductTransferInfo.Size = new System.Drawing.Size(927, 263);
            this.gpbProductTransferInfo.TabIndex = 1;
            this.gpbProductTransferInfo.TabStop = false;
            this.gpbProductTransferInfo.Text = "Product Transfer Information";
            // 
            // dgvInventoryTransfer
            // 
            this.dgvInventoryTransfer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInventoryTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colUnit,
            this.colTransferableQuantity,
            this.colClientStockBalance,
            this.colRequestedQuantity,
            this.colMyStockBalance,
            this.colTransferQuantity});
            this.dgvInventoryTransfer.Location = new System.Drawing.Point(16, 21);
            this.dgvInventoryTransfer.Name = "dgvInventoryTransfer";
            this.dgvInventoryTransfer.Size = new System.Drawing.Size(896, 224);
            this.dgvInventoryTransfer.TabIndex = 6;
            // 
            // gpbInventoryTransferInfo
            // 
            this.gpbInventoryTransferInfo.Controls.Add(this.comboBox1);
            this.gpbInventoryTransferInfo.Controls.Add(this.lblStockRequetID);
            this.gpbInventoryTransferInfo.Controls.Add(this.cboTransferTo);
            this.gpbInventoryTransferInfo.Controls.Add(this.lblTransferTo);
            this.gpbInventoryTransferInfo.Controls.Add(this.cboTransferFrom);
            this.gpbInventoryTransferInfo.Controls.Add(this.lblTransferFrom);
            this.gpbInventoryTransferInfo.Controls.Add(this.dtpTransferDate);
            this.gpbInventoryTransferInfo.Controls.Add(this.lblTransferDate);
            this.gpbInventoryTransferInfo.Controls.Add(this.lblInventoryTransferID);
            this.gpbInventoryTransferInfo.Controls.Add(this.txtStockRequestID);
            this.gpbInventoryTransferInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInventoryTransferInfo.Location = new System.Drawing.Point(12, 10);
            this.gpbInventoryTransferInfo.Name = "gpbInventoryTransferInfo";
            this.gpbInventoryTransferInfo.Size = new System.Drawing.Size(676, 177);
            this.gpbInventoryTransferInfo.TabIndex = 0;
            this.gpbInventoryTransferInfo.TabStop = false;
            this.gpbInventoryTransferInfo.Text = "Inventory Transfer Information";
            // 
            // cboTransferFrom
            // 
            this.cboTransferFrom.FormattingEnabled = true;
            this.cboTransferFrom.Location = new System.Drawing.Point(158, 121);
            this.cboTransferFrom.Name = "cboTransferFrom";
            this.cboTransferFrom.Size = new System.Drawing.Size(184, 22);
            this.cboTransferFrom.TabIndex = 78;
            // 
            // lblTransferFrom
            // 
            this.lblTransferFrom.AutoSize = true;
            this.lblTransferFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferFrom.Location = new System.Drawing.Point(12, 124);
            this.lblTransferFrom.Name = "lblTransferFrom";
            this.lblTransferFrom.Size = new System.Drawing.Size(91, 14);
            this.lblTransferFrom.TabIndex = 77;
            this.lblTransferFrom.Text = "Transfer From";
            // 
            // dtpTransferDate
            // 
            this.dtpTransferDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransferDate.CustomFormat = "dd MMM yyyy hh:mm tt";
            this.dtpTransferDate.Enabled = false;
            this.dtpTransferDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransferDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransferDate.Location = new System.Drawing.Point(465, 29);
            this.dtpTransferDate.Name = "dtpTransferDate";
            this.dtpTransferDate.Size = new System.Drawing.Size(192, 23);
            this.dtpTransferDate.TabIndex = 58;
            // 
            // lblTransferDate
            // 
            this.lblTransferDate.AutoSize = true;
            this.lblTransferDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferDate.Location = new System.Drawing.Point(368, 33);
            this.lblTransferDate.Name = "lblTransferDate";
            this.lblTransferDate.Size = new System.Drawing.Size(90, 14);
            this.lblTransferDate.TabIndex = 28;
            this.lblTransferDate.Text = "Transfer Date";
            // 
            // lblInventoryTransferID
            // 
            this.lblInventoryTransferID.AutoSize = true;
            this.lblInventoryTransferID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTransferID.Location = new System.Drawing.Point(12, 33);
            this.lblInventoryTransferID.Name = "lblInventoryTransferID";
            this.lblInventoryTransferID.Size = new System.Drawing.Size(140, 14);
            this.lblInventoryTransferID.TabIndex = 26;
            this.lblInventoryTransferID.Text = "Inventory Transfer ID";
            // 
            // txtStockRequestID
            // 
            this.txtStockRequestID.Enabled = false;
            this.txtStockRequestID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockRequestID.Location = new System.Drawing.Point(158, 29);
            this.txtStockRequestID.Name = "txtStockRequestID";
            this.txtStockRequestID.Size = new System.Drawing.Size(125, 23);
            this.txtStockRequestID.TabIndex = 1;
            // 
            // ssCompany
            // 
            this.ssCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.tsslUser,
            this.tsslCompID,
            this.tsslEID});
            this.ssCompany.Location = new System.Drawing.Point(0, 543);
            this.ssCompany.Name = "ssCompany";
            this.ssCompany.Size = new System.Drawing.Size(958, 23);
            this.ssCompany.TabIndex = 54;
            this.ssCompany.Text = "statusStrip1";
            // 
            // tsslabelUser
            // 
            this.tsslabelUser.Name = "tsslabelUser";
            this.tsslabelUser.Size = new System.Drawing.Size(0, 18);
            // 
            // tsslCompany
            // 
            this.tsslCompany.Name = "tsslCompany";
            this.tsslCompany.Size = new System.Drawing.Size(53, 18);
            this.tsslCompany.Text = "Company";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(30, 18);
            this.tsslUser.Text = "User";
            // 
            // tsslCompID
            // 
            this.tsslCompID.Name = "tsslCompID";
            this.tsslCompID.Size = new System.Drawing.Size(46, 18);
            this.tsslCompID.Text = "CompID";
            // 
            // tsslEID
            // 
            this.tsslEID.Name = "tsslEID";
            this.tsslEID.Size = new System.Drawing.Size(25, 18);
            this.tsslEID.Text = "EID";
            // 
            // cboTransferTo
            // 
            this.cboTransferTo.FormattingEnabled = true;
            this.cboTransferTo.Location = new System.Drawing.Point(465, 121);
            this.cboTransferTo.Name = "cboTransferTo";
            this.cboTransferTo.Size = new System.Drawing.Size(192, 22);
            this.cboTransferTo.TabIndex = 80;
            // 
            // lblTransferTo
            // 
            this.lblTransferTo.AutoSize = true;
            this.lblTransferTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferTo.Location = new System.Drawing.Point(368, 124);
            this.lblTransferTo.Name = "lblTransferTo";
            this.lblTransferTo.Size = new System.Drawing.Size(76, 14);
            this.lblTransferTo.TabIndex = 79;
            this.lblTransferTo.Text = "Transfer To";
            // 
            // lblStockRequetID
            // 
            this.lblStockRequetID.AutoSize = true;
            this.lblStockRequetID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockRequetID.Location = new System.Drawing.Point(12, 76);
            this.lblStockRequetID.Name = "lblStockRequetID";
            this.lblStockRequetID.Size = new System.Drawing.Size(115, 14);
            this.lblStockRequetID.TabIndex = 82;
            this.lblStockRequetID.Text = "Stock Request ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 22);
            this.comboBox1.TabIndex = 83;
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductID.Width = 91;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.Width = 101;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colTransferableQuantity
            // 
            this.colTransferableQuantity.HeaderText = "Transferable Quantity";
            this.colTransferableQuantity.Name = "colTransferableQuantity";
            this.colTransferableQuantity.ReadOnly = true;
            // 
            // colClientStockBalance
            // 
            this.colClientStockBalance.HeaderText = "Client Stock Balance";
            this.colClientStockBalance.Name = "colClientStockBalance";
            this.colClientStockBalance.ReadOnly = true;
            // 
            // colRequestedQuantity
            // 
            this.colRequestedQuantity.HeaderText = "Requested Quantity";
            this.colRequestedQuantity.Name = "colRequestedQuantity";
            this.colRequestedQuantity.ReadOnly = true;
            // 
            // colMyStockBalance
            // 
            this.colMyStockBalance.HeaderText = "My Stock Balance";
            this.colMyStockBalance.Name = "colMyStockBalance";
            this.colMyStockBalance.ReadOnly = true;
            // 
            // colTransferQuantity
            // 
            this.colTransferQuantity.HeaderText = "Transfer Quantity";
            this.colTransferQuantity.Name = "colTransferQuantity";
            // 
            // gpbDescription
            // 
            this.gpbDescription.Controls.Add(this.txtDescription);
            this.gpbDescription.Controls.Add(this.lblDescription);
            this.gpbDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDescription.Location = new System.Drawing.Point(696, 12);
            this.gpbDescription.Name = "gpbDescription";
            this.gpbDescription.Size = new System.Drawing.Size(243, 175);
            this.gpbDescription.TabIndex = 84;
            this.gpbDescription.TabStop = false;
            this.gpbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(11, 48);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 112);
            this.txtDescription.TabIndex = 52;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(9, 26);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 14);
            this.lblDescription.TabIndex = 53;
            this.lblDescription.Text = "Description";
            // 
            // pnlSInventoryTransfer
            // 
            this.pnlSInventoryTransfer.Controls.Add(this.dgvSInventoryTransfer);
            this.pnlSInventoryTransfer.Controls.Add(this.gpbSearch);
            this.pnlSInventoryTransfer.Location = new System.Drawing.Point(0, 0);
            this.pnlSInventoryTransfer.Name = "pnlSInventoryTransfer";
            this.pnlSInventoryTransfer.Size = new System.Drawing.Size(957, 541);
            this.pnlSInventoryTransfer.TabIndex = 55;
            // 
            // dgvSInventoryTransfer
            // 
            this.dgvSInventoryTransfer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSInventoryTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSInventoryTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSInventoryTransfer.Location = new System.Drawing.Point(288, 7);
            this.dgvSInventoryTransfer.Name = "dgvSInventoryTransfer";
            this.dgvSInventoryTransfer.Size = new System.Drawing.Size(658, 523);
            this.dgvSInventoryTransfer.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.cboSProductName);
            this.gpbSearch.Controls.Add(this.chkSProductName);
            this.gpbSearch.Controls.Add(this.chkSInventoryTransferID);
            this.gpbSearch.Controls.Add(this.txtSInventoryTransferID);
            this.gpbSearch.Controls.Add(this.cboSFromWarehouse);
            this.gpbSearch.Controls.Add(this.chkSFromWarehouse);
            this.gpbSearch.Controls.Add(this.dtpSToDate);
            this.gpbSearch.Controls.Add(this.lblSTo);
            this.gpbSearch.Controls.Add(this.dtpSFromDate);
            this.gpbSearch.Controls.Add(this.chkSTransferDate);
            this.gpbSearch.Controls.Add(this.gpbSControl);
            this.gpbSearch.Controls.Add(this.cboSToWarehouse);
            this.gpbSearch.Controls.Add(this.chkSToWarehouse);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(18, 7);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 523);
            this.gpbSearch.TabIndex = 4;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // chkSInventoryTransferID
            // 
            this.chkSInventoryTransferID.AutoSize = true;
            this.chkSInventoryTransferID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSInventoryTransferID.Location = new System.Drawing.Point(16, 31);
            this.chkSInventoryTransferID.Name = "chkSInventoryTransferID";
            this.chkSInventoryTransferID.Size = new System.Drawing.Size(159, 18);
            this.chkSInventoryTransferID.TabIndex = 71;
            this.chkSInventoryTransferID.Text = "Inventory Transfer ID";
            this.chkSInventoryTransferID.UseVisualStyleBackColor = true;
            // 
            // txtSInventoryTransferID
            // 
            this.txtSInventoryTransferID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSInventoryTransferID.Location = new System.Drawing.Point(16, 53);
            this.txtSInventoryTransferID.Name = "txtSInventoryTransferID";
            this.txtSInventoryTransferID.Size = new System.Drawing.Size(232, 23);
            this.txtSInventoryTransferID.TabIndex = 70;
            // 
            // cboSFromWarehouse
            // 
            this.cboSFromWarehouse.FormattingEnabled = true;
            this.cboSFromWarehouse.Location = new System.Drawing.Point(16, 110);
            this.cboSFromWarehouse.Name = "cboSFromWarehouse";
            this.cboSFromWarehouse.Size = new System.Drawing.Size(232, 22);
            this.cboSFromWarehouse.TabIndex = 69;
            // 
            // chkSFromWarehouse
            // 
            this.chkSFromWarehouse.AutoSize = true;
            this.chkSFromWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSFromWarehouse.Location = new System.Drawing.Point(16, 88);
            this.chkSFromWarehouse.Name = "chkSFromWarehouse";
            this.chkSFromWarehouse.Size = new System.Drawing.Size(128, 18);
            this.chkSFromWarehouse.TabIndex = 68;
            this.chkSFromWarehouse.Text = "From Warehouse";
            this.chkSFromWarehouse.UseVisualStyleBackColor = true;
            // 
            // dtpSToDate
            // 
            this.dtpSToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.CustomFormat = "dd MMM yyyy";
            this.dtpSToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSToDate.Location = new System.Drawing.Point(15, 347);
            this.dtpSToDate.Name = "dtpSToDate";
            this.dtpSToDate.Size = new System.Drawing.Size(230, 23);
            this.dtpSToDate.TabIndex = 66;
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(120, 328);
            this.lblSTo.Name = "lblSTo";
            this.lblSTo.Size = new System.Drawing.Size(22, 14);
            this.lblSTo.TabIndex = 67;
            this.lblSTo.Text = "To";
            // 
            // dtpSFromDate
            // 
            this.dtpSFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpSFromDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSFromDate.Location = new System.Drawing.Point(15, 301);
            this.dtpSFromDate.Name = "dtpSFromDate";
            this.dtpSFromDate.Size = new System.Drawing.Size(230, 23);
            this.dtpSFromDate.TabIndex = 65;
            // 
            // chkSTransferDate
            // 
            this.chkSTransferDate.AutoSize = true;
            this.chkSTransferDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSTransferDate.Location = new System.Drawing.Point(15, 277);
            this.chkSTransferDate.Name = "chkSTransferDate";
            this.chkSTransferDate.Size = new System.Drawing.Size(109, 18);
            this.chkSTransferDate.TabIndex = 64;
            this.chkSTransferDate.Text = "Transfer Date";
            this.chkSTransferDate.UseVisualStyleBackColor = true;
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnSDelete);
            this.gpbSControl.Controls.Add(this.btnSShowAll);
            this.gpbSControl.Controls.Add(this.btnSCancel);
            this.gpbSControl.Controls.Add(this.btnSSearch);
            this.gpbSControl.Location = new System.Drawing.Point(15, 401);
            this.gpbSControl.Name = "gpbSControl";
            this.gpbSControl.Size = new System.Drawing.Size(232, 105);
            this.gpbSControl.TabIndex = 3;
            this.gpbSControl.TabStop = false;
            // 
            // btnSDelete
            // 
            this.btnSDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDelete.Location = new System.Drawing.Point(125, 18);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(81, 31);
            this.btnSDelete.TabIndex = 19;
            this.btnSDelete.Text = "&Delete";
            this.btnSDelete.UseVisualStyleBackColor = true;
            // 
            // btnSShowAll
            // 
            this.btnSShowAll.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSShowAll.Location = new System.Drawing.Point(27, 60);
            this.btnSShowAll.Name = "btnSShowAll";
            this.btnSShowAll.Size = new System.Drawing.Size(81, 31);
            this.btnSShowAll.TabIndex = 18;
            this.btnSShowAll.Text = "Show &All";
            this.btnSShowAll.UseVisualStyleBackColor = true;
            // 
            // btnSCancel
            // 
            this.btnSCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCancel.Location = new System.Drawing.Point(125, 60);
            this.btnSCancel.Name = "btnSCancel";
            this.btnSCancel.Size = new System.Drawing.Size(81, 31);
            this.btnSCancel.TabIndex = 17;
            this.btnSCancel.Text = "&Cancel";
            this.btnSCancel.UseVisualStyleBackColor = true;
            // 
            // btnSSearch
            // 
            this.btnSSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSearch.Location = new System.Drawing.Point(27, 18);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(81, 31);
            this.btnSSearch.TabIndex = 13;
            this.btnSSearch.Text = "Searc&h";
            this.btnSSearch.UseVisualStyleBackColor = true;
            // 
            // cboSToWarehouse
            // 
            this.cboSToWarehouse.FormattingEnabled = true;
            this.cboSToWarehouse.Location = new System.Drawing.Point(15, 169);
            this.cboSToWarehouse.Name = "cboSToWarehouse";
            this.cboSToWarehouse.Size = new System.Drawing.Size(232, 22);
            this.cboSToWarehouse.TabIndex = 55;
            // 
            // chkSToWarehouse
            // 
            this.chkSToWarehouse.AutoSize = true;
            this.chkSToWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSToWarehouse.Location = new System.Drawing.Point(15, 147);
            this.chkSToWarehouse.Name = "chkSToWarehouse";
            this.chkSToWarehouse.Size = new System.Drawing.Size(113, 18);
            this.chkSToWarehouse.TabIndex = 50;
            this.chkSToWarehouse.Text = "To Warehouse";
            this.chkSToWarehouse.UseVisualStyleBackColor = true;
            // 
            // cboSProductName
            // 
            this.cboSProductName.FormattingEnabled = true;
            this.cboSProductName.Location = new System.Drawing.Point(15, 234);
            this.cboSProductName.Name = "cboSProductName";
            this.cboSProductName.Size = new System.Drawing.Size(232, 22);
            this.cboSProductName.TabIndex = 73;
            // 
            // chkSProductName
            // 
            this.chkSProductName.AutoSize = true;
            this.chkSProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSProductName.Location = new System.Drawing.Point(15, 212);
            this.chkSProductName.Name = "chkSProductName";
            this.chkSProductName.Size = new System.Drawing.Size(112, 18);
            this.chkSProductName.TabIndex = 72;
            this.chkSProductName.Text = "Product Name";
            this.chkSProductName.UseVisualStyleBackColor = true;
            // 
            // frmInventoryTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 566);
            this.Controls.Add(this.pnlSInventoryTransfer);
            this.Controls.Add(this.ssCompany);
            this.Controls.Add(this.pnlPurchaseOrder);
            this.MaximizeBox = false;
            this.Name = "frmInventoryTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Transfer";
            this.pnlPurchaseOrder.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbProductTransferInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTransfer)).EndInit();
            this.gpbInventoryTransferInfo.ResumeLayout(false);
            this.gpbInventoryTransferInfo.PerformLayout();
            this.ssCompany.ResumeLayout(false);
            this.ssCompany.PerformLayout();
            this.gpbDescription.ResumeLayout(false);
            this.gpbDescription.PerformLayout();
            this.pnlSInventoryTransfer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSInventoryTransfer)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPurchaseOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbProductTransferInfo;
        private System.Windows.Forms.DataGridView dgvInventoryTransfer;
        private System.Windows.Forms.GroupBox gpbInventoryTransferInfo;
        private System.Windows.Forms.ComboBox cboTransferFrom;
        private System.Windows.Forms.Label lblTransferFrom;
        private System.Windows.Forms.DateTimePicker dtpTransferDate;
        private System.Windows.Forms.Label lblTransferDate;
        private System.Windows.Forms.Label lblInventoryTransferID;
        private System.Windows.Forms.TextBox txtStockRequestID;
        private System.Windows.Forms.StatusStrip ssCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.ComboBox cboTransferTo;
        private System.Windows.Forms.Label lblTransferTo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblStockRequetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientStockBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMyStockBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferQuantity;
        private System.Windows.Forms.GroupBox gpbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlSInventoryTransfer;
        private System.Windows.Forms.DataGridView dgvSInventoryTransfer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.ComboBox cboSProductName;
        private System.Windows.Forms.CheckBox chkSProductName;
        private System.Windows.Forms.CheckBox chkSInventoryTransferID;
        private System.Windows.Forms.TextBox txtSInventoryTransferID;
        private System.Windows.Forms.ComboBox cboSFromWarehouse;
        private System.Windows.Forms.CheckBox chkSFromWarehouse;
        private System.Windows.Forms.DateTimePicker dtpSToDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.DateTimePicker dtpSFromDate;
        private System.Windows.Forms.CheckBox chkSTransferDate;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.ComboBox cboSToWarehouse;
        private System.Windows.Forms.CheckBox chkSToWarehouse;
    }
}