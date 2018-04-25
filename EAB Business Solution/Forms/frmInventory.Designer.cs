namespace EAB_Business_Solution.Forms
{
    partial class frmInventory
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
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pnlSInventory = new System.Windows.Forms.Panel();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.dtpSExpireToDate = new System.Windows.Forms.DateTimePicker();
            this.lblSExpireTo = new System.Windows.Forms.Label();
            this.dtpSExpireFromDate = new System.Windows.Forms.DateTimePicker();
            this.chkSExpireDate = new System.Windows.Forms.CheckBox();
            this.ddpSStockInToDate = new System.Windows.Forms.DateTimePicker();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.lblSStockInTo = new System.Windows.Forms.Label();
            this.dtpSStockInFromDate = new System.Windows.Forms.DateTimePicker();
            this.chkStockInDate = new System.Windows.Forms.CheckBox();
            this.cboSProductName = new System.Windows.Forms.ComboBox();
            this.chkSProductName = new System.Windows.Forms.CheckBox();
            this.gpbProductRegistration = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.dtpManufacturingDate = new System.Windows.Forms.DateTimePicker();
            this.lblManufacturingDate = new System.Windows.Forms.Label();
            this.dtpStockInDate = new System.Windows.Forms.DateTimePicker();
            this.lblStockInDate = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbWarehouseInfo = new System.Windows.Forms.GroupBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
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
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.ssCompany = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlInventory.SuspendLayout();
            this.pnlSInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            this.gpbProductRegistration.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbWarehouseInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ssCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInventory
            // 
            this.pnlInventory.Controls.Add(this.pnlSInventory);
            this.pnlInventory.Controls.Add(this.gpbProductRegistration);
            this.pnlInventory.Controls.Add(this.groupBox1);
            this.pnlInventory.Controls.Add(this.gpbWarehouseInfo);
            this.pnlInventory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInventory.Location = new System.Drawing.Point(0, 0);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(768, 489);
            this.pnlInventory.TabIndex = 58;
            // 
            // pnlSInventory
            // 
            this.pnlSInventory.Controls.Add(this.dgvDepartment);
            this.pnlSInventory.Controls.Add(this.gpbSearch);
            this.pnlSInventory.Location = new System.Drawing.Point(0, 0);
            this.pnlSInventory.Name = "pnlSInventory";
            this.pnlSInventory.Size = new System.Drawing.Size(768, 486);
            this.pnlSInventory.TabIndex = 78;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvDepartment.Location = new System.Drawing.Point(288, 6);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.Size = new System.Drawing.Size(470, 480);
            this.dgvDepartment.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.dtpSExpireToDate);
            this.gpbSearch.Controls.Add(this.lblSExpireTo);
            this.gpbSearch.Controls.Add(this.dtpSExpireFromDate);
            this.gpbSearch.Controls.Add(this.chkSExpireDate);
            this.gpbSearch.Controls.Add(this.ddpSStockInToDate);
            this.gpbSearch.Controls.Add(this.gpbSControl);
            this.gpbSearch.Controls.Add(this.lblSStockInTo);
            this.gpbSearch.Controls.Add(this.dtpSStockInFromDate);
            this.gpbSearch.Controls.Add(this.chkStockInDate);
            this.gpbSearch.Controls.Add(this.cboSProductName);
            this.gpbSearch.Controls.Add(this.chkSProductName);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(21, 18);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 450);
            this.gpbSearch.TabIndex = 3;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // dtpSExpireToDate
            // 
            this.dtpSExpireToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSExpireToDate.CustomFormat = "dd MMM yyyy";
            this.dtpSExpireToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSExpireToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSExpireToDate.Location = new System.Drawing.Point(14, 282);
            this.dtpSExpireToDate.Name = "dtpSExpireToDate";
            this.dtpSExpireToDate.Size = new System.Drawing.Size(230, 23);
            this.dtpSExpireToDate.TabIndex = 66;
            // 
            // lblSExpireTo
            // 
            this.lblSExpireTo.AutoSize = true;
            this.lblSExpireTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSExpireTo.Location = new System.Drawing.Point(119, 263);
            this.lblSExpireTo.Name = "lblSExpireTo";
            this.lblSExpireTo.Size = new System.Drawing.Size(22, 14);
            this.lblSExpireTo.TabIndex = 67;
            this.lblSExpireTo.Text = "To";
            // 
            // dtpSExpireFromDate
            // 
            this.dtpSExpireFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSExpireFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpSExpireFromDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSExpireFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSExpireFromDate.Location = new System.Drawing.Point(14, 236);
            this.dtpSExpireFromDate.Name = "dtpSExpireFromDate";
            this.dtpSExpireFromDate.Size = new System.Drawing.Size(230, 23);
            this.dtpSExpireFromDate.TabIndex = 65;
            // 
            // chkSExpireDate
            // 
            this.chkSExpireDate.AutoSize = true;
            this.chkSExpireDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSExpireDate.Location = new System.Drawing.Point(14, 212);
            this.chkSExpireDate.Name = "chkSExpireDate";
            this.chkSExpireDate.Size = new System.Drawing.Size(96, 18);
            this.chkSExpireDate.TabIndex = 64;
            this.chkSExpireDate.Text = "Expire Date";
            this.chkSExpireDate.UseVisualStyleBackColor = true;
            // 
            // ddpSStockInToDate
            // 
            this.ddpSStockInToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddpSStockInToDate.CustomFormat = "dd MMM yyyy";
            this.ddpSStockInToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddpSStockInToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddpSStockInToDate.Location = new System.Drawing.Point(13, 165);
            this.ddpSStockInToDate.Name = "ddpSStockInToDate";
            this.ddpSStockInToDate.Size = new System.Drawing.Size(230, 23);
            this.ddpSStockInToDate.TabIndex = 62;
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnSDelete);
            this.gpbSControl.Controls.Add(this.btnSShowAll);
            this.gpbSControl.Controls.Add(this.btnSCancel);
            this.gpbSControl.Controls.Add(this.btnSSearch);
            this.gpbSControl.Location = new System.Drawing.Point(15, 326);
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
            // lblSStockInTo
            // 
            this.lblSStockInTo.AutoSize = true;
            this.lblSStockInTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSStockInTo.Location = new System.Drawing.Point(118, 146);
            this.lblSStockInTo.Name = "lblSStockInTo";
            this.lblSStockInTo.Size = new System.Drawing.Size(22, 14);
            this.lblSStockInTo.TabIndex = 63;
            this.lblSStockInTo.Text = "To";
            // 
            // dtpSStockInFromDate
            // 
            this.dtpSStockInFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSStockInFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpSStockInFromDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSStockInFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSStockInFromDate.Location = new System.Drawing.Point(13, 119);
            this.dtpSStockInFromDate.Name = "dtpSStockInFromDate";
            this.dtpSStockInFromDate.Size = new System.Drawing.Size(230, 23);
            this.dtpSStockInFromDate.TabIndex = 61;
            // 
            // chkStockInDate
            // 
            this.chkStockInDate.AutoSize = true;
            this.chkStockInDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStockInDate.Location = new System.Drawing.Point(13, 95);
            this.chkStockInDate.Name = "chkStockInDate";
            this.chkStockInDate.Size = new System.Drawing.Size(111, 18);
            this.chkStockInDate.TabIndex = 60;
            this.chkStockInDate.Text = "Stock In Date";
            this.chkStockInDate.UseVisualStyleBackColor = true;
            // 
            // cboSProductName
            // 
            this.cboSProductName.FormattingEnabled = true;
            this.cboSProductName.Location = new System.Drawing.Point(13, 55);
            this.cboSProductName.Name = "cboSProductName";
            this.cboSProductName.Size = new System.Drawing.Size(232, 22);
            this.cboSProductName.TabIndex = 55;
            // 
            // chkSProductName
            // 
            this.chkSProductName.AutoSize = true;
            this.chkSProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSProductName.Location = new System.Drawing.Point(13, 33);
            this.chkSProductName.Name = "chkSProductName";
            this.chkSProductName.Size = new System.Drawing.Size(112, 18);
            this.chkSProductName.TabIndex = 50;
            this.chkSProductName.Text = "Product Name";
            this.chkSProductName.UseVisualStyleBackColor = true;
            // 
            // gpbProductRegistration
            // 
            this.gpbProductRegistration.Controls.Add(this.txtQuantity);
            this.gpbProductRegistration.Controls.Add(this.lblQuantity);
            this.gpbProductRegistration.Controls.Add(this.dtpExpireDate);
            this.gpbProductRegistration.Controls.Add(this.lblExpireDate);
            this.gpbProductRegistration.Controls.Add(this.dtpManufacturingDate);
            this.gpbProductRegistration.Controls.Add(this.lblManufacturingDate);
            this.gpbProductRegistration.Controls.Add(this.dtpStockInDate);
            this.gpbProductRegistration.Controls.Add(this.lblStockInDate);
            this.gpbProductRegistration.Controls.Add(this.txtProductName);
            this.gpbProductRegistration.Controls.Add(this.lblProductName);
            this.gpbProductRegistration.Controls.Add(this.txtProductID);
            this.gpbProductRegistration.Controls.Add(this.groupBox4);
            this.gpbProductRegistration.Controls.Add(this.lblProductID);
            this.gpbProductRegistration.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductRegistration.Location = new System.Drawing.Point(199, 113);
            this.gpbProductRegistration.Name = "gpbProductRegistration";
            this.gpbProductRegistration.Size = new System.Drawing.Size(375, 283);
            this.gpbProductRegistration.TabIndex = 77;
            this.gpbProductRegistration.TabStop = false;
            this.gpbProductRegistration.Text = "Product Registration";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(168, 229);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(90, 23);
            this.txtQuantity.TabIndex = 86;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(22, 233);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 14);
            this.lblQuantity.TabIndex = 85;
            this.lblQuantity.Text = "Quantity";
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpireDate.CustomFormat = "dd MMM yyyy";
            this.dtpExpireDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpireDate.Location = new System.Drawing.Point(168, 189);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(174, 23);
            this.dtpExpireDate.TabIndex = 83;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.Location = new System.Drawing.Point(22, 194);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(77, 14);
            this.lblExpireDate.TabIndex = 84;
            this.lblExpireDate.Text = "Expire Date";
            // 
            // dtpManufacturingDate
            // 
            this.dtpManufacturingDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpManufacturingDate.CustomFormat = "dd MMM yyyy";
            this.dtpManufacturingDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpManufacturingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpManufacturingDate.Location = new System.Drawing.Point(168, 148);
            this.dtpManufacturingDate.Name = "dtpManufacturingDate";
            this.dtpManufacturingDate.Size = new System.Drawing.Size(174, 23);
            this.dtpManufacturingDate.TabIndex = 81;
            // 
            // lblManufacturingDate
            // 
            this.lblManufacturingDate.AutoSize = true;
            this.lblManufacturingDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturingDate.Location = new System.Drawing.Point(22, 153);
            this.lblManufacturingDate.Name = "lblManufacturingDate";
            this.lblManufacturingDate.Size = new System.Drawing.Size(130, 14);
            this.lblManufacturingDate.TabIndex = 82;
            this.lblManufacturingDate.Text = "Manufacturing Date";
            // 
            // dtpStockInDate
            // 
            this.dtpStockInDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStockInDate.CustomFormat = "dd MMM yyyy";
            this.dtpStockInDate.Enabled = false;
            this.dtpStockInDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStockInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStockInDate.Location = new System.Drawing.Point(168, 105);
            this.dtpStockInDate.Name = "dtpStockInDate";
            this.dtpStockInDate.Size = new System.Drawing.Size(174, 23);
            this.dtpStockInDate.TabIndex = 79;
            // 
            // lblStockInDate
            // 
            this.lblStockInDate.AutoSize = true;
            this.lblStockInDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockInDate.Location = new System.Drawing.Point(22, 110);
            this.lblStockInDate.Name = "lblStockInDate";
            this.lblStockInDate.Size = new System.Drawing.Size(92, 14);
            this.lblStockInDate.TabIndex = 80;
            this.lblStockInDate.Text = "Stock In Date";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(168, 67);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(174, 23);
            this.txtProductName.TabIndex = 78;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(22, 71);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 14);
            this.lblProductName.TabIndex = 77;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(168, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(174, 23);
            this.txtProductID.TabIndex = 76;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(975, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 268);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment Information";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(166, 94);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 23);
            this.textBox8.TabIndex = 41;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 14);
            this.label6.TabIndex = 40;
            this.label6.Text = "Member Promotion";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(166, 65);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 23);
            this.textBox9.TabIndex = 39;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "Service Charges";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(166, 170);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 23);
            this.textBox10.TabIndex = 37;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 14);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tax";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(166, 132);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(125, 23);
            this.textBox11.TabIndex = 11;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(166, 25);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(125, 23);
            this.textBox12.TabIndex = 10;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 14);
            this.label9.TabIndex = 28;
            this.label9.Text = "Sub Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "Grand Total";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(166, 208);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(125, 40);
            this.textBox13.TabIndex = 20;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(22, 30);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(74, 14);
            this.lblProductID.TabIndex = 26;
            this.lblProductID.Text = "Product ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(77, 411);
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
            // gpbWarehouseInfo
            // 
            this.gpbWarehouseInfo.Controls.Add(this.txtWarehouseName);
            this.gpbWarehouseInfo.Controls.Add(this.groupBox2);
            this.gpbWarehouseInfo.Controls.Add(this.lblWarehouseName);
            this.gpbWarehouseInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbWarehouseInfo.Location = new System.Drawing.Point(199, 23);
            this.gpbWarehouseInfo.Name = "gpbWarehouseInfo";
            this.gpbWarehouseInfo.Size = new System.Drawing.Size(375, 75);
            this.gpbWarehouseInfo.TabIndex = 0;
            this.gpbWarehouseInfo.TabStop = false;
            this.gpbWarehouseInfo.Text = "Warehouse Infomation";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Enabled = false;
            this.txtWarehouseName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseName.Location = new System.Drawing.Point(168, 26);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(174, 23);
            this.txtWarehouseName.TabIndex = 76;
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
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseName.Location = new System.Drawing.Point(22, 30);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(112, 14);
            this.lblWarehouseName.TabIndex = 26;
            this.lblWarehouseName.Text = "Warehouse Name";
            // 
            // ssCompany
            // 
            this.ssCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.tsslUser,
            this.tsslCompID,
            this.tsslEID});
            this.ssCompany.Location = new System.Drawing.Point(0, 489);
            this.ssCompany.Name = "ssCompany";
            this.ssCompany.Size = new System.Drawing.Size(770, 23);
            this.ssCompany.TabIndex = 59;
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
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 512);
            this.Controls.Add(this.ssCompany);
            this.Controls.Add(this.pnlInventory);
            this.MaximizeBox = false;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.pnlInventory.ResumeLayout(false);
            this.pnlSInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            this.gpbProductRegistration.ResumeLayout(false);
            this.gpbProductRegistration.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpbWarehouseInfo.ResumeLayout(false);
            this.gpbWarehouseInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ssCompany.ResumeLayout(false);
            this.ssCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbWarehouseInfo;
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
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.StatusStrip ssCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.GroupBox gpbProductRegistration;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.DateTimePicker dtpStockInDate;
        private System.Windows.Forms.Label lblStockInDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.DateTimePicker dtpManufacturingDate;
        private System.Windows.Forms.Label lblManufacturingDate;
        private System.Windows.Forms.Panel pnlSInventory;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.DateTimePicker ddpSStockInToDate;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.Label lblSStockInTo;
        private System.Windows.Forms.DateTimePicker dtpSStockInFromDate;
        private System.Windows.Forms.CheckBox chkStockInDate;
        private System.Windows.Forms.ComboBox cboSProductName;
        private System.Windows.Forms.CheckBox chkSProductName;
        private System.Windows.Forms.DateTimePicker dtpSExpireToDate;
        private System.Windows.Forms.Label lblSExpireTo;
        private System.Windows.Forms.DateTimePicker dtpSExpireFromDate;
        private System.Windows.Forms.CheckBox chkSExpireDate;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}