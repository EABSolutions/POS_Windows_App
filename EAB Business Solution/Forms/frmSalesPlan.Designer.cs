namespace EAB_Business_Solution.Forms
{
    partial class frmSalesPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSalesPlan = new System.Windows.Forms.Panel();
            this.gpbProduct = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblWholesalePrice = new System.Windows.Forms.Label();
            this.txtWholesalePrice = new System.Windows.Forms.TextBox();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMinQuantity = new System.Windows.Forms.Label();
            this.btnProductName = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbProductInfo = new System.Windows.Forms.GroupBox();
            this.dgvSalesPlan = new System.Windows.Forms.DataGridView();
            this.gpbSalesPlanInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblSalesPlanID = new System.Windows.Forms.Label();
            this.txtSalesPlanID = new System.Windows.Forms.TextBox();
            this.pnlSSalesPlan = new System.Windows.Forms.Panel();
            this.dgvSSalesPlan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.chkSInactiveSalesPlan = new System.Windows.Forms.CheckBox();
            this.chkSActiveSalesPlan = new System.Windows.Forms.CheckBox();
            this.ddpSToDate = new System.Windows.Forms.DateTimePicker();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.lblSTo = new System.Windows.Forms.Label();
            this.chkSSalesPlanID = new System.Windows.Forms.CheckBox();
            this.dtpSFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtSSalesPlanID = new System.Windows.Forms.TextBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.cboSProductName = new System.Windows.Forms.ComboBox();
            this.chkSProductName = new System.Windows.Forms.CheckBox();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWholesalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWholesaleQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSalesPlan.SuspendLayout();
            this.gpbProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesPlan)).BeginInit();
            this.gpbSalesPlanInfo.SuspendLayout();
            this.pnlSSalesPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSSalesPlan)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSalesPlan
            // 
            this.pnlSalesPlan.Controls.Add(this.pnlSSalesPlan);
            this.pnlSalesPlan.Controls.Add(this.gpbProduct);
            this.pnlSalesPlan.Controls.Add(this.gpbSalesPlanInfo);
            this.pnlSalesPlan.Controls.Add(this.groupBox1);
            this.pnlSalesPlan.Controls.Add(this.gpbProductInfo);
            this.pnlSalesPlan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSalesPlan.Location = new System.Drawing.Point(0, 0);
            this.pnlSalesPlan.Name = "pnlSalesPlan";
            this.pnlSalesPlan.Size = new System.Drawing.Size(1000, 629);
            this.pnlSalesPlan.TabIndex = 7;
            // 
            // gpbProduct
            // 
            this.gpbProduct.Controls.Add(this.comboBox1);
            this.gpbProduct.Controls.Add(this.lblCurrency);
            this.gpbProduct.Controls.Add(this.lblUnit);
            this.gpbProduct.Controls.Add(this.txtUnit);
            this.gpbProduct.Controls.Add(this.lblWholesalePrice);
            this.gpbProduct.Controls.Add(this.txtWholesalePrice);
            this.gpbProduct.Controls.Add(this.lblRetailPrice);
            this.gpbProduct.Controls.Add(this.txtRetailPrice);
            this.gpbProduct.Controls.Add(this.txtProductID);
            this.gpbProduct.Controls.Add(this.lblProductID);
            this.gpbProduct.Controls.Add(this.btnAdd);
            this.gpbProduct.Controls.Add(this.lblMinQuantity);
            this.gpbProduct.Controls.Add(this.btnProductName);
            this.gpbProduct.Controls.Add(this.txtQuantity);
            this.gpbProduct.Controls.Add(this.cboProductName);
            this.gpbProduct.Controls.Add(this.lblProductName);
            this.gpbProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProduct.Location = new System.Drawing.Point(12, 146);
            this.gpbProduct.Name = "gpbProduct";
            this.gpbProduct.Size = new System.Drawing.Size(972, 109);
            this.gpbProduct.TabIndex = 60;
            this.gpbProduct.TabStop = false;
            this.gpbProduct.Text = "Product";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(857, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 74;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(793, 31);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(58, 13);
            this.lblCurrency.TabIndex = 73;
            this.lblCurrency.Text = "Currency";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(338, 70);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(30, 13);
            this.lblUnit.TabIndex = 72;
            this.lblUnit.Text = "Unit";
            // 
            // txtUnit
            // 
            this.txtUnit.Enabled = false;
            this.txtUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(415, 67);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(110, 21);
            this.txtUnit.TabIndex = 71;
            // 
            // lblWholesalePrice
            // 
            this.lblWholesalePrice.AutoSize = true;
            this.lblWholesalePrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWholesalePrice.Location = new System.Drawing.Point(555, 31);
            this.lblWholesalePrice.Name = "lblWholesalePrice";
            this.lblWholesalePrice.Size = new System.Drawing.Size(96, 13);
            this.lblWholesalePrice.TabIndex = 70;
            this.lblWholesalePrice.Text = "Wholesale Price";
            // 
            // txtWholesalePrice
            // 
            this.txtWholesalePrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWholesalePrice.Location = new System.Drawing.Point(657, 27);
            this.txtWholesalePrice.Name = "txtWholesalePrice";
            this.txtWholesalePrice.Size = new System.Drawing.Size(110, 21);
            this.txtWholesalePrice.TabIndex = 69;
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetailPrice.Location = new System.Drawing.Point(338, 31);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(71, 13);
            this.lblRetailPrice.TabIndex = 68;
            this.lblRetailPrice.Text = "Retail Price";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetailPrice.Location = new System.Drawing.Point(415, 28);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(110, 21);
            this.txtRetailPrice.TabIndex = 67;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(105, 27);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(172, 21);
            this.txtProductID.TabIndex = 66;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(15, 31);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(67, 13);
            this.lblProductID.TabIndex = 63;
            this.lblProductID.Text = "Product ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(857, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 33);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblMinQuantity
            // 
            this.lblMinQuantity.AutoSize = true;
            this.lblMinQuantity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinQuantity.Location = new System.Drawing.Point(555, 70);
            this.lblMinQuantity.Name = "lblMinQuantity";
            this.lblMinQuantity.Size = new System.Drawing.Size(79, 13);
            this.lblMinQuantity.TabIndex = 59;
            this.lblMinQuantity.Text = "Min Quantity";
            // 
            // btnProductName
            // 
            this.btnProductName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductName.Location = new System.Drawing.Point(285, 67);
            this.btnProductName.Name = "btnProductName";
            this.btnProductName.Size = new System.Drawing.Size(29, 26);
            this.btnProductName.TabIndex = 58;
            this.btnProductName.Text = "...";
            this.btnProductName.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(657, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(79, 21);
            this.txtQuantity.TabIndex = 58;
            // 
            // cboProductName
            // 
            this.cboProductName.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(105, 67);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(172, 24);
            this.cboProductName.TabIndex = 58;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(16, 70);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(86, 13);
            this.lblProductName.TabIndex = 26;
            this.lblProductName.Text = "Product Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(225, 563);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(510, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 31);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Searc&h";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(414, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(219, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(21, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 31);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(118, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 31);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(318, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gpbProductInfo
            // 
            this.gpbProductInfo.Controls.Add(this.dgvSalesPlan);
            this.gpbProductInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductInfo.Location = new System.Drawing.Point(12, 255);
            this.gpbProductInfo.Name = "gpbProductInfo";
            this.gpbProductInfo.Size = new System.Drawing.Size(972, 305);
            this.gpbProductInfo.TabIndex = 1;
            this.gpbProductInfo.TabStop = false;
            this.gpbProductInfo.Text = "Product Information";
            // 
            // dgvSalesPlan
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesPlan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSalesPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colUnit,
            this.colRetailPrice,
            this.colWholesalePrice,
            this.colWholesaleQty,
            this.colCurrency});
            this.dgvSalesPlan.Location = new System.Drawing.Point(6, 21);
            this.dgvSalesPlan.Name = "dgvSalesPlan";
            this.dgvSalesPlan.Size = new System.Drawing.Size(949, 278);
            this.dgvSalesPlan.TabIndex = 5;
            // 
            // gpbSalesPlanInfo
            // 
            this.gpbSalesPlanInfo.Controls.Add(this.txtDescription);
            this.gpbSalesPlanInfo.Controls.Add(this.lblDescription);
            this.gpbSalesPlanInfo.Controls.Add(this.chkActive);
            this.gpbSalesPlanInfo.Controls.Add(this.dtpEndDate);
            this.gpbSalesPlanInfo.Controls.Add(this.lblEndDate);
            this.gpbSalesPlanInfo.Controls.Add(this.dtpStartDate);
            this.gpbSalesPlanInfo.Controls.Add(this.lblStartDate);
            this.gpbSalesPlanInfo.Controls.Add(this.lblSalesPlanID);
            this.gpbSalesPlanInfo.Controls.Add(this.txtSalesPlanID);
            this.gpbSalesPlanInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSalesPlanInfo.Location = new System.Drawing.Point(227, 6);
            this.gpbSalesPlanInfo.Name = "gpbSalesPlanInfo";
            this.gpbSalesPlanInfo.Size = new System.Drawing.Size(604, 139);
            this.gpbSalesPlanInfo.TabIndex = 0;
            this.gpbSalesPlanInfo.TabStop = false;
            this.gpbSalesPlanInfo.Text = "Sales Plan Infomation";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(110, 51);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 69);
            this.txtDescription.TabIndex = 71;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(24, 54);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 13);
            this.lblDescription.TabIndex = 70;
            this.lblDescription.Text = "Description";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(427, 79);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 69;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CustomFormat = "dd MMM yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(427, 48);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(125, 21);
            this.dtpEndDate.TabIndex = 67;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(355, 54);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(57, 13);
            this.lblEndDate.TabIndex = 68;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CustomFormat = "dd MMM yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(427, 17);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(125, 21);
            this.dtpStartDate.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(355, 22);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(66, 13);
            this.lblStartDate.TabIndex = 28;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblSalesPlanID
            // 
            this.lblSalesPlanID.AutoSize = true;
            this.lblSalesPlanID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPlanID.Location = new System.Drawing.Point(24, 23);
            this.lblSalesPlanID.Name = "lblSalesPlanID";
            this.lblSalesPlanID.Size = new System.Drawing.Size(80, 13);
            this.lblSalesPlanID.TabIndex = 26;
            this.lblSalesPlanID.Text = "Sales Plan ID";
            // 
            // txtSalesPlanID
            // 
            this.txtSalesPlanID.Enabled = false;
            this.txtSalesPlanID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesPlanID.Location = new System.Drawing.Point(110, 19);
            this.txtSalesPlanID.Name = "txtSalesPlanID";
            this.txtSalesPlanID.Size = new System.Drawing.Size(125, 21);
            this.txtSalesPlanID.TabIndex = 1;
            // 
            // pnlSSalesPlan
            // 
            this.pnlSSalesPlan.Controls.Add(this.dgvSSalesPlan);
            this.pnlSSalesPlan.Controls.Add(this.gpbSearch);
            this.pnlSSalesPlan.Location = new System.Drawing.Point(0, 0);
            this.pnlSSalesPlan.Name = "pnlSSalesPlan";
            this.pnlSSalesPlan.Size = new System.Drawing.Size(1000, 10);
            this.pnlSSalesPlan.TabIndex = 61;
            // 
            // dgvSSalesPlan
            // 
            this.dgvSSalesPlan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSSalesPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSSalesPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSSalesPlan.Location = new System.Drawing.Point(295, 11);
            this.dgvSSalesPlan.Name = "dgvSSalesPlan";
            this.dgvSSalesPlan.Size = new System.Drawing.Size(597, 613);
            this.dgvSSalesPlan.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.chkSInactiveSalesPlan);
            this.gpbSearch.Controls.Add(this.chkSActiveSalesPlan);
            this.gpbSearch.Controls.Add(this.ddpSToDate);
            this.gpbSearch.Controls.Add(this.gpbSControl);
            this.gpbSearch.Controls.Add(this.lblSTo);
            this.gpbSearch.Controls.Add(this.chkSSalesPlanID);
            this.gpbSearch.Controls.Add(this.dtpSFromDate);
            this.gpbSearch.Controls.Add(this.txtSSalesPlanID);
            this.gpbSearch.Controls.Add(this.chkDate);
            this.gpbSearch.Controls.Add(this.cboSProductName);
            this.gpbSearch.Controls.Add(this.chkSProductName);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(18, 66);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 482);
            this.gpbSearch.TabIndex = 2;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // chkSInactiveSalesPlan
            // 
            this.chkSInactiveSalesPlan.AutoSize = true;
            this.chkSInactiveSalesPlan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSInactiveSalesPlan.Location = new System.Drawing.Point(13, 322);
            this.chkSInactiveSalesPlan.Name = "chkSInactiveSalesPlan";
            this.chkSInactiveSalesPlan.Size = new System.Drawing.Size(140, 18);
            this.chkSInactiveSalesPlan.TabIndex = 65;
            this.chkSInactiveSalesPlan.Text = "Inactive Sales Plan";
            this.chkSInactiveSalesPlan.UseVisualStyleBackColor = true;
            // 
            // chkSActiveSalesPlan
            // 
            this.chkSActiveSalesPlan.AutoSize = true;
            this.chkSActiveSalesPlan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSActiveSalesPlan.Location = new System.Drawing.Point(13, 283);
            this.chkSActiveSalesPlan.Name = "chkSActiveSalesPlan";
            this.chkSActiveSalesPlan.Size = new System.Drawing.Size(129, 18);
            this.chkSActiveSalesPlan.TabIndex = 64;
            this.chkSActiveSalesPlan.Text = "Active Sales Plan";
            this.chkSActiveSalesPlan.UseVisualStyleBackColor = true;
            // 
            // ddpSToDate
            // 
            this.ddpSToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddpSToDate.CustomFormat = "dd MMM yyyy";
            this.ddpSToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddpSToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddpSToDate.Location = new System.Drawing.Point(13, 233);
            this.ddpSToDate.Name = "ddpSToDate";
            this.ddpSToDate.Size = new System.Drawing.Size(230, 23);
            this.ddpSToDate.TabIndex = 62;
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnSDelete);
            this.gpbSControl.Controls.Add(this.btnSShowAll);
            this.gpbSControl.Controls.Add(this.btnSCancel);
            this.gpbSControl.Controls.Add(this.btnSSearch);
            this.gpbSControl.Location = new System.Drawing.Point(13, 356);
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
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(118, 214);
            this.lblSTo.Name = "lblSTo";
            this.lblSTo.Size = new System.Drawing.Size(22, 14);
            this.lblSTo.TabIndex = 63;
            this.lblSTo.Text = "To";
            // 
            // chkSSalesPlanID
            // 
            this.chkSSalesPlanID.AutoSize = true;
            this.chkSSalesPlanID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSSalesPlanID.Location = new System.Drawing.Point(13, 35);
            this.chkSSalesPlanID.Name = "chkSSalesPlanID";
            this.chkSSalesPlanID.Size = new System.Drawing.Size(105, 18);
            this.chkSSalesPlanID.TabIndex = 48;
            this.chkSSalesPlanID.Text = "Sales Plan ID";
            this.chkSSalesPlanID.UseVisualStyleBackColor = true;
            // 
            // dtpSFromDate
            // 
            this.dtpSFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpSFromDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSFromDate.Location = new System.Drawing.Point(13, 187);
            this.dtpSFromDate.Name = "dtpSFromDate";
            this.dtpSFromDate.Size = new System.Drawing.Size(230, 23);
            this.dtpSFromDate.TabIndex = 61;
            // 
            // txtSSalesPlanID
            // 
            this.txtSSalesPlanID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSalesPlanID.Location = new System.Drawing.Point(13, 57);
            this.txtSSalesPlanID.Name = "txtSSalesPlanID";
            this.txtSSalesPlanID.Size = new System.Drawing.Size(232, 23);
            this.txtSSalesPlanID.TabIndex = 2;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDate.Location = new System.Drawing.Point(13, 163);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(55, 18);
            this.chkDate.TabIndex = 60;
            this.chkDate.Text = "Date";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // cboSProductName
            // 
            this.cboSProductName.FormattingEnabled = true;
            this.cboSProductName.Location = new System.Drawing.Point(13, 123);
            this.cboSProductName.Name = "cboSProductName";
            this.cboSProductName.Size = new System.Drawing.Size(232, 22);
            this.cboSProductName.TabIndex = 55;
            // 
            // chkSProductName
            // 
            this.chkSProductName.AutoSize = true;
            this.chkSProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSProductName.Location = new System.Drawing.Point(13, 101);
            this.chkSProductName.Name = "chkSProductName";
            this.chkSProductName.Size = new System.Drawing.Size(112, 18);
            this.chkSProductName.TabIndex = 50;
            this.chkSProductName.Text = "Product Name";
            this.chkSProductName.UseVisualStyleBackColor = true;
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductID.DefaultCellStyle = dataGridViewCellStyle2;
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductID.Width = 91;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductName.Width = 101;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colRetailPrice
            // 
            this.colRetailPrice.HeaderText = "Retail Price";
            this.colRetailPrice.Name = "colRetailPrice";
            // 
            // colWholesalePrice
            // 
            this.colWholesalePrice.HeaderText = "Wholesale Price";
            this.colWholesalePrice.Name = "colWholesalePrice";
            // 
            // colWholesaleQty
            // 
            this.colWholesaleQty.HeaderText = "Wholesale Quantity";
            this.colWholesaleQty.Name = "colWholesaleQty";
            // 
            // colCurrency
            // 
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmSalesPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 629);
            this.Controls.Add(this.pnlSalesPlan);
            this.MaximizeBox = false;
            this.Name = "frmSalesPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Plan";
            this.pnlSalesPlan.ResumeLayout(false);
            this.gpbProduct.ResumeLayout(false);
            this.gpbProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpbProductInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesPlan)).EndInit();
            this.gpbSalesPlanInfo.ResumeLayout(false);
            this.gpbSalesPlanInfo.PerformLayout();
            this.pnlSSalesPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSSalesPlan)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalesPlan;
        private System.Windows.Forms.GroupBox gpbProductInfo;
        private System.Windows.Forms.DataGridView dgvSalesPlan;
        private System.Windows.Forms.GroupBox gpbSalesPlanInfo;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblSalesPlanID;
        private System.Windows.Forms.TextBox txtSalesPlanID;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbProduct;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblWholesalePrice;
        private System.Windows.Forms.TextBox txtWholesalePrice;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMinQuantity;
        private System.Windows.Forms.Button btnProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Panel pnlSSalesPlan;
        private System.Windows.Forms.DataGridView dgvSSalesPlan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.CheckBox chkSInactiveSalesPlan;
        private System.Windows.Forms.CheckBox chkSActiveSalesPlan;
        private System.Windows.Forms.DateTimePicker ddpSToDate;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.CheckBox chkSSalesPlanID;
        private System.Windows.Forms.DateTimePicker dtpSFromDate;
        private System.Windows.Forms.TextBox txtSSalesPlanID;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.ComboBox cboSProductName;
        private System.Windows.Forms.CheckBox chkSProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWholesalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWholesaleQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
    }
}