namespace EAB_Business_Solution.Forms
{
    partial class frmStockRequest
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
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.chkReject = new System.Windows.Forms.CheckBox();
            this.chkAccept = new System.Windows.Forms.CheckBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.gpbRequestProductInfo = new System.Windows.Forms.GroupBox();
            this.lblCreditAmount = new System.Windows.Forms.DataGridView();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.lblStockRequestID = new System.Windows.Forms.Label();
            this.txtStockRequestID = new System.Windows.Forms.TextBox();
            this.ssCompany = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboWarehouseName = new System.Windows.Forms.ComboBox();
            this.pnlSStockRequest = new System.Windows.Forms.Panel();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.dtpSToDate = new System.Windows.Forms.DateTimePicker();
            this.lblSTo = new System.Windows.Forms.Label();
            this.dtpSFromDate = new System.Windows.Forms.DateTimePicker();
            this.chkSRequestDate = new System.Windows.Forms.CheckBox();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.cboSProductName = new System.Windows.Forms.ComboBox();
            this.chkSProductName = new System.Windows.Forms.CheckBox();
            this.cboSWarehouse = new System.Windows.Forms.ComboBox();
            this.chkSWarehouse = new System.Windows.Forms.CheckBox();
            this.chkSStockRequestID = new System.Windows.Forms.CheckBox();
            this.txtSStockRequestID = new System.Windows.Forms.TextBox();
            this.dgvSStockRequest = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlPurchaseOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbStatus.SuspendLayout();
            this.gpbRequestProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblCreditAmount)).BeginInit();
            this.gpbBasicInfo.SuspendLayout();
            this.ssCompany.SuspendLayout();
            this.pnlSStockRequest.SuspendLayout();
            this.gpbSearch.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSStockRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPurchaseOrder
            // 
            this.pnlPurchaseOrder.Controls.Add(this.pnlSStockRequest);
            this.pnlPurchaseOrder.Controls.Add(this.groupBox1);
            this.pnlPurchaseOrder.Controls.Add(this.gpbStatus);
            this.pnlPurchaseOrder.Controls.Add(this.gpbRequestProductInfo);
            this.pnlPurchaseOrder.Controls.Add(this.gpbBasicInfo);
            this.pnlPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPurchaseOrder.Location = new System.Drawing.Point(0, 2);
            this.pnlPurchaseOrder.Name = "pnlPurchaseOrder";
            this.pnlPurchaseOrder.Size = new System.Drawing.Size(957, 541);
            this.pnlPurchaseOrder.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(170, 473);
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
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.chkReject);
            this.gpbStatus.Controls.Add(this.chkAccept);
            this.gpbStatus.Controls.Add(this.txtRemark);
            this.gpbStatus.Controls.Add(this.lblRemark);
            this.gpbStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStatus.Location = new System.Drawing.Point(699, 10);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(240, 194);
            this.gpbStatus.TabIndex = 2;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Text = "Status";
            // 
            // chkReject
            // 
            this.chkReject.AutoSize = true;
            this.chkReject.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReject.Location = new System.Drawing.Point(115, 36);
            this.chkReject.Name = "chkReject";
            this.chkReject.Size = new System.Drawing.Size(65, 18);
            this.chkReject.TabIndex = 8;
            this.chkReject.Text = "Reject";
            this.chkReject.UseVisualStyleBackColor = true;
            // 
            // chkAccept
            // 
            this.chkAccept.AutoSize = true;
            this.chkAccept.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccept.Location = new System.Drawing.Point(31, 36);
            this.chkAccept.Name = "chkAccept";
            this.chkAccept.Size = new System.Drawing.Size(68, 18);
            this.chkAccept.TabIndex = 7;
            this.chkAccept.Text = "Accept";
            this.chkAccept.UseVisualStyleBackColor = true;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(70, 77);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(155, 85);
            this.txtRemark.TabIndex = 9;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(11, 81);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(53, 14);
            this.lblRemark.TabIndex = 26;
            this.lblRemark.Text = "Remark";
            // 
            // gpbRequestProductInfo
            // 
            this.gpbRequestProductInfo.Controls.Add(this.lblCreditAmount);
            this.gpbRequestProductInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRequestProductInfo.Location = new System.Drawing.Point(12, 210);
            this.gpbRequestProductInfo.Name = "gpbRequestProductInfo";
            this.gpbRequestProductInfo.Size = new System.Drawing.Size(927, 257);
            this.gpbRequestProductInfo.TabIndex = 1;
            this.gpbRequestProductInfo.TabStop = false;
            this.gpbRequestProductInfo.Text = "Request Product Infomation";
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.BackgroundColor = System.Drawing.SystemColors.Window;
            this.lblCreditAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lblCreditAmount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colUnit,
            this.colRequestQuantity,
            this.colStockBalance,
            this.colRequestAvailableQuantity});
            this.lblCreditAmount.Location = new System.Drawing.Point(16, 21);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(896, 224);
            this.lblCreditAmount.TabIndex = 6;
            // 
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.cboWarehouseName);
            this.gpbBasicInfo.Controls.Add(this.lblWarehouseName);
            this.gpbBasicInfo.Controls.Add(this.dtpRequestDate);
            this.gpbBasicInfo.Controls.Add(this.txtDescription);
            this.gpbBasicInfo.Controls.Add(this.lblDescription);
            this.gpbBasicInfo.Controls.Add(this.lblRequestDate);
            this.gpbBasicInfo.Controls.Add(this.lblStockRequestID);
            this.gpbBasicInfo.Controls.Add(this.txtStockRequestID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(12, 10);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(681, 194);
            this.gpbBasicInfo.TabIndex = 0;
            this.gpbBasicInfo.TabStop = false;
            this.gpbBasicInfo.Text = "Basic Infomation";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(157, 107);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(499, 67);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(22, 111);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 14);
            this.lblDescription.TabIndex = 51;
            this.lblDescription.Text = "Description";
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDate.Location = new System.Drawing.Point(367, 30);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(91, 14);
            this.lblRequestDate.TabIndex = 28;
            this.lblRequestDate.Text = "Request Date";
            // 
            // lblStockRequestID
            // 
            this.lblStockRequestID.AutoSize = true;
            this.lblStockRequestID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockRequestID.Location = new System.Drawing.Point(22, 30);
            this.lblStockRequestID.Name = "lblStockRequestID";
            this.lblStockRequestID.Size = new System.Drawing.Size(115, 14);
            this.lblStockRequestID.TabIndex = 26;
            this.lblStockRequestID.Text = "Stock Request ID";
            // 
            // txtStockRequestID
            // 
            this.txtStockRequestID.Enabled = false;
            this.txtStockRequestID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockRequestID.Location = new System.Drawing.Point(157, 26);
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
            this.ssCompany.TabIndex = 53;
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
            // dtpRequestDate
            // 
            this.dtpRequestDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRequestDate.CustomFormat = "dd MMM yyyy hh:mm tt";
            this.dtpRequestDate.Enabled = false;
            this.dtpRequestDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequestDate.Location = new System.Drawing.Point(464, 26);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(192, 23);
            this.dtpRequestDate.TabIndex = 58;
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseName.Location = new System.Drawing.Point(22, 71);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(112, 14);
            this.lblWarehouseName.TabIndex = 77;
            this.lblWarehouseName.Text = "Warehouse Name";
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
            // colRequestQuantity
            // 
            this.colRequestQuantity.HeaderText = "Request Quantity";
            this.colRequestQuantity.Name = "colRequestQuantity";
            // 
            // colStockBalance
            // 
            this.colStockBalance.HeaderText = "Stock Balance";
            this.colStockBalance.Name = "colStockBalance";
            this.colStockBalance.ReadOnly = true;
            // 
            // colRequestAvailableQuantity
            // 
            this.colRequestAvailableQuantity.HeaderText = "Request Available Quantity";
            this.colRequestAvailableQuantity.Name = "colRequestAvailableQuantity";
            this.colRequestAvailableQuantity.ReadOnly = true;
            // 
            // cboWarehouseName
            // 
            this.cboWarehouseName.FormattingEnabled = true;
            this.cboWarehouseName.Location = new System.Drawing.Point(157, 68);
            this.cboWarehouseName.Name = "cboWarehouseName";
            this.cboWarehouseName.Size = new System.Drawing.Size(184, 22);
            this.cboWarehouseName.TabIndex = 78;
            // 
            // pnlSStockRequest
            // 
            this.pnlSStockRequest.Controls.Add(this.dgvSStockRequest);
            this.pnlSStockRequest.Controls.Add(this.gpbSearch);
            this.pnlSStockRequest.Location = new System.Drawing.Point(0, 0);
            this.pnlSStockRequest.Name = "pnlSStockRequest";
            this.pnlSStockRequest.Size = new System.Drawing.Size(957, 541);
            this.pnlSStockRequest.TabIndex = 5;
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.chkSStockRequestID);
            this.gpbSearch.Controls.Add(this.txtSStockRequestID);
            this.gpbSearch.Controls.Add(this.cboSWarehouse);
            this.gpbSearch.Controls.Add(this.chkSWarehouse);
            this.gpbSearch.Controls.Add(this.dtpSToDate);
            this.gpbSearch.Controls.Add(this.lblSTo);
            this.gpbSearch.Controls.Add(this.dtpSFromDate);
            this.gpbSearch.Controls.Add(this.chkSRequestDate);
            this.gpbSearch.Controls.Add(this.gpbSControl);
            this.gpbSearch.Controls.Add(this.cboSProductName);
            this.gpbSearch.Controls.Add(this.chkSProductName);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(18, 32);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 451);
            this.gpbSearch.TabIndex = 4;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // dtpSToDate
            // 
            this.dtpSToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.CustomFormat = "dd MMM yyyy";
            this.dtpSToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSToDate.Location = new System.Drawing.Point(15, 281);
            this.dtpSToDate.Name = "dtpSToDate";
            this.dtpSToDate.Size = new System.Drawing.Size(230, 23);
            this.dtpSToDate.TabIndex = 66;
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(120, 262);
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
            this.dtpSFromDate.Location = new System.Drawing.Point(15, 235);
            this.dtpSFromDate.Name = "dtpSFromDate";
            this.dtpSFromDate.Size = new System.Drawing.Size(230, 23);
            this.dtpSFromDate.TabIndex = 65;
            // 
            // chkSRequestDate
            // 
            this.chkSRequestDate.AutoSize = true;
            this.chkSRequestDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSRequestDate.Location = new System.Drawing.Point(15, 211);
            this.chkSRequestDate.Name = "chkSRequestDate";
            this.chkSRequestDate.Size = new System.Drawing.Size(110, 18);
            this.chkSRequestDate.TabIndex = 64;
            this.chkSRequestDate.Text = "Request Date";
            this.chkSRequestDate.UseVisualStyleBackColor = true;
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnSDelete);
            this.gpbSControl.Controls.Add(this.btnSShowAll);
            this.gpbSControl.Controls.Add(this.btnSCancel);
            this.gpbSControl.Controls.Add(this.btnSSearch);
            this.gpbSControl.Location = new System.Drawing.Point(15, 321);
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
            // cboSProductName
            // 
            this.cboSProductName.FormattingEnabled = true;
            this.cboSProductName.Location = new System.Drawing.Point(15, 169);
            this.cboSProductName.Name = "cboSProductName";
            this.cboSProductName.Size = new System.Drawing.Size(232, 22);
            this.cboSProductName.TabIndex = 55;
            // 
            // chkSProductName
            // 
            this.chkSProductName.AutoSize = true;
            this.chkSProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSProductName.Location = new System.Drawing.Point(15, 147);
            this.chkSProductName.Name = "chkSProductName";
            this.chkSProductName.Size = new System.Drawing.Size(112, 18);
            this.chkSProductName.TabIndex = 50;
            this.chkSProductName.Text = "Product Name";
            this.chkSProductName.UseVisualStyleBackColor = true;
            // 
            // cboSWarehouse
            // 
            this.cboSWarehouse.FormattingEnabled = true;
            this.cboSWarehouse.Location = new System.Drawing.Point(16, 110);
            this.cboSWarehouse.Name = "cboSWarehouse";
            this.cboSWarehouse.Size = new System.Drawing.Size(232, 22);
            this.cboSWarehouse.TabIndex = 69;
            // 
            // chkSWarehouse
            // 
            this.chkSWarehouse.AutoSize = true;
            this.chkSWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSWarehouse.Location = new System.Drawing.Point(16, 88);
            this.chkSWarehouse.Name = "chkSWarehouse";
            this.chkSWarehouse.Size = new System.Drawing.Size(94, 18);
            this.chkSWarehouse.TabIndex = 68;
            this.chkSWarehouse.Text = "Warehouse";
            this.chkSWarehouse.UseVisualStyleBackColor = true;
            // 
            // chkSStockRequestID
            // 
            this.chkSStockRequestID.AutoSize = true;
            this.chkSStockRequestID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSStockRequestID.Location = new System.Drawing.Point(16, 31);
            this.chkSStockRequestID.Name = "chkSStockRequestID";
            this.chkSStockRequestID.Size = new System.Drawing.Size(134, 18);
            this.chkSStockRequestID.TabIndex = 71;
            this.chkSStockRequestID.Text = "Stock Request ID";
            this.chkSStockRequestID.UseVisualStyleBackColor = true;
            // 
            // txtSStockRequestID
            // 
            this.txtSStockRequestID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSStockRequestID.Location = new System.Drawing.Point(16, 53);
            this.txtSStockRequestID.Name = "txtSStockRequestID";
            this.txtSStockRequestID.Size = new System.Drawing.Size(232, 23);
            this.txtSStockRequestID.TabIndex = 70;
            // 
            // dgvSStockRequest
            // 
            this.dgvSStockRequest.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSStockRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSStockRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSStockRequest.Location = new System.Drawing.Point(288, 7);
            this.dgvSStockRequest.Name = "dgvSStockRequest";
            this.dgvSStockRequest.Size = new System.Drawing.Size(658, 523);
            this.dgvSStockRequest.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // frmStockRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 566);
            this.Controls.Add(this.ssCompany);
            this.Controls.Add(this.pnlPurchaseOrder);
            this.MaximizeBox = false;
            this.Name = "frmStockRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Request";
            this.pnlPurchaseOrder.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            this.gpbRequestProductInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblCreditAmount)).EndInit();
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.ssCompany.ResumeLayout(false);
            this.ssCompany.PerformLayout();
            this.pnlSStockRequest.ResumeLayout(false);
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSStockRequest)).EndInit();
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
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.CheckBox chkReject;
        private System.Windows.Forms.CheckBox chkAccept;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.GroupBox gpbRequestProductInfo;
        private System.Windows.Forms.DataGridView lblCreditAmount;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.Label lblStockRequestID;
        private System.Windows.Forms.TextBox txtStockRequestID;
        private System.Windows.Forms.StatusStrip ssCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestAvailableQuantity;
        private System.Windows.Forms.ComboBox cboWarehouseName;
        private System.Windows.Forms.Panel pnlSStockRequest;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.DateTimePicker dtpSToDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.DateTimePicker dtpSFromDate;
        private System.Windows.Forms.CheckBox chkSRequestDate;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.ComboBox cboSProductName;
        private System.Windows.Forms.CheckBox chkSProductName;
        private System.Windows.Forms.ComboBox cboSWarehouse;
        private System.Windows.Forms.CheckBox chkSWarehouse;
        private System.Windows.Forms.CheckBox chkSStockRequestID;
        private System.Windows.Forms.TextBox txtSStockRequestID;
        private System.Windows.Forms.DataGridView dgvSStockRequest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}