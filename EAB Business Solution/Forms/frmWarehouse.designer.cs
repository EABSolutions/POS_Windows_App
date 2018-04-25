namespace EAB_Business_Solution.Forms
{
    partial class frmWarehouse
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
            this.pnlWarehouse = new System.Windows.Forms.Panel();
            this.pnlSWarehouse = new System.Windows.Forms.Panel();
            this.dgvSCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.cboTownship = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSWarehouseName = new System.Windows.Forms.CheckBox();
            this.txtSWarehouseName = new System.Windows.Forms.TextBox();
            this.chkSCity = new System.Windows.Forms.CheckBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.chkSCountry = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblTownship = new System.Windows.Forms.Label();
            this.txtTownship = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblHomeNo = new System.Windows.Forms.Label();
            this.txtHomeNo = new System.Windows.Forms.TextBox();
            this.gpbContactInfo = new System.Windows.Forms.GroupBox();
            this.txtcontactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMEmail = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.lblWarehouseID = new System.Windows.Forms.Label();
            this.txtWarehouseID = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlWarehouse.SuspendLayout();
            this.pnlSWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCustomer)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbAddress.SuspendLayout();
            this.gpbContactInfo.SuspendLayout();
            this.gpbBasicInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWarehouse
            // 
            this.pnlWarehouse.Controls.Add(this.pnlSWarehouse);
            this.pnlWarehouse.Controls.Add(this.groupBox1);
            this.pnlWarehouse.Controls.Add(this.gpbAddress);
            this.pnlWarehouse.Controls.Add(this.gpbContactInfo);
            this.pnlWarehouse.Controls.Add(this.gpbBasicInfo);
            this.pnlWarehouse.Location = new System.Drawing.Point(1, 1);
            this.pnlWarehouse.Name = "pnlWarehouse";
            this.pnlWarehouse.Size = new System.Drawing.Size(1167, 505);
            this.pnlWarehouse.TabIndex = 0;
            // 
            // pnlSWarehouse
            // 
            this.pnlSWarehouse.Controls.Add(this.dgvSCustomer);
            this.pnlSWarehouse.Controls.Add(this.gpbSearch);
            this.pnlSWarehouse.Location = new System.Drawing.Point(0, 2);
            this.pnlSWarehouse.Name = "pnlSWarehouse";
            this.pnlSWarehouse.Size = new System.Drawing.Size(977, 418);
            this.pnlSWarehouse.TabIndex = 36;
            // 
            // dgvSCustomer
            // 
            this.dgvSCustomer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSCustomer.Location = new System.Drawing.Point(292, 13);
            this.dgvSCustomer.Name = "dgvSCustomer";
            this.dgvSCustomer.Size = new System.Drawing.Size(682, 402);
            this.dgvSCustomer.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.cboTownship);
            this.gpbSearch.Controls.Add(this.checkBox1);
            this.gpbSearch.Controls.Add(this.cboCity);
            this.gpbSearch.Controls.Add(this.groupBox4);
            this.gpbSearch.Controls.Add(this.chkSWarehouseName);
            this.gpbSearch.Controls.Add(this.txtSWarehouseName);
            this.gpbSearch.Controls.Add(this.chkSCity);
            this.gpbSearch.Controls.Add(this.cboCountry);
            this.gpbSearch.Controls.Add(this.chkSCountry);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(11, 26);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(270, 374);
            this.gpbSearch.TabIndex = 2;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // cboTownship
            // 
            this.cboTownship.FormattingEnabled = true;
            this.cboTownship.Location = new System.Drawing.Point(13, 220);
            this.cboTownship.Name = "cboTownship";
            this.cboTownship.Size = new System.Drawing.Size(232, 22);
            this.cboTownship.TabIndex = 58;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(13, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 18);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Township";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(13, 167);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(232, 22);
            this.cboCity.TabIndex = 57;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSDelete);
            this.groupBox4.Controls.Add(this.btnSShowAll);
            this.groupBox4.Controls.Add(this.btnSCancel);
            this.groupBox4.Controls.Add(this.btnSSearch);
            this.groupBox4.Location = new System.Drawing.Point(13, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 105);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
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
            // chkSWarehouseName
            // 
            this.chkSWarehouseName.AutoSize = true;
            this.chkSWarehouseName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSWarehouseName.Location = new System.Drawing.Point(13, 34);
            this.chkSWarehouseName.Name = "chkSWarehouseName";
            this.chkSWarehouseName.Size = new System.Drawing.Size(131, 18);
            this.chkSWarehouseName.TabIndex = 48;
            this.chkSWarehouseName.Text = "Warehouse Name";
            this.chkSWarehouseName.UseVisualStyleBackColor = true;
            // 
            // txtSWarehouseName
            // 
            this.txtSWarehouseName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSWarehouseName.Location = new System.Drawing.Point(13, 60);
            this.txtSWarehouseName.Name = "txtSWarehouseName";
            this.txtSWarehouseName.Size = new System.Drawing.Size(232, 23);
            this.txtSWarehouseName.TabIndex = 2;
            // 
            // chkSCity
            // 
            this.chkSCity.AutoSize = true;
            this.chkSCity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCity.Location = new System.Drawing.Point(13, 145);
            this.chkSCity.Name = "chkSCity";
            this.chkSCity.Size = new System.Drawing.Size(50, 18);
            this.chkSCity.TabIndex = 54;
            this.chkSCity.Text = "City";
            this.chkSCity.UseVisualStyleBackColor = true;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(13, 115);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(232, 22);
            this.cboCountry.TabIndex = 56;
            // 
            // chkSCountry
            // 
            this.chkSCountry.AutoSize = true;
            this.chkSCountry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCountry.Location = new System.Drawing.Point(13, 92);
            this.chkSCountry.Name = "chkSCountry";
            this.chkSCountry.Size = new System.Drawing.Size(76, 18);
            this.chkSCountry.TabIndex = 52;
            this.chkSCountry.Text = "Country";
            this.chkSCountry.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(174, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 5;
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
            // gpbAddress
            // 
            this.gpbAddress.Controls.Add(this.lblCountry);
            this.gpbAddress.Controls.Add(this.txtCountry);
            this.gpbAddress.Controls.Add(this.lblCity);
            this.gpbAddress.Controls.Add(this.txtCity);
            this.gpbAddress.Controls.Add(this.lblTownship);
            this.gpbAddress.Controls.Add(this.txtTownship);
            this.gpbAddress.Controls.Add(this.lblStreet);
            this.gpbAddress.Controls.Add(this.txtStreet);
            this.gpbAddress.Controls.Add(this.lblHomeNo);
            this.gpbAddress.Controls.Add(this.txtHomeNo);
            this.gpbAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAddress.Location = new System.Drawing.Point(11, 236);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(955, 115);
            this.gpbAddress.TabIndex = 4;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Address";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(678, 31);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 14);
            this.lblCountry.TabIndex = 55;
            this.lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(751, 27);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(191, 23);
            this.txtCountry.TabIndex = 12;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(404, 75);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 14);
            this.lblCity.TabIndex = 53;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(450, 71);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(191, 23);
            this.txtCity.TabIndex = 11;
            // 
            // lblTownship
            // 
            this.lblTownship.AutoSize = true;
            this.lblTownship.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownship.Location = new System.Drawing.Point(369, 31);
            this.lblTownship.Name = "lblTownship";
            this.lblTownship.Size = new System.Drawing.Size(66, 14);
            this.lblTownship.TabIndex = 51;
            this.lblTownship.Text = "Township";
            // 
            // txtTownship
            // 
            this.txtTownship.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTownship.Location = new System.Drawing.Point(450, 27);
            this.txtTownship.Name = "txtTownship";
            this.txtTownship.Size = new System.Drawing.Size(191, 23);
            this.txtTownship.TabIndex = 10;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(53, 75);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 14);
            this.lblStreet.TabIndex = 49;
            this.lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(114, 71);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(191, 23);
            this.txtStreet.TabIndex = 9;
            // 
            // lblHomeNo
            // 
            this.lblHomeNo.AutoSize = true;
            this.lblHomeNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeNo.Location = new System.Drawing.Point(37, 34);
            this.lblHomeNo.Name = "lblHomeNo";
            this.lblHomeNo.Size = new System.Drawing.Size(62, 14);
            this.lblHomeNo.TabIndex = 47;
            this.lblHomeNo.Text = "Home No";
            // 
            // txtHomeNo
            // 
            this.txtHomeNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeNo.Location = new System.Drawing.Point(114, 30);
            this.txtHomeNo.Name = "txtHomeNo";
            this.txtHomeNo.Size = new System.Drawing.Size(191, 23);
            this.txtHomeNo.TabIndex = 8;
            // 
            // gpbContactInfo
            // 
            this.gpbContactInfo.Controls.Add(this.txtcontactNo);
            this.gpbContactInfo.Controls.Add(this.lblContactNo);
            this.gpbContactInfo.Controls.Add(this.lblEmail);
            this.gpbContactInfo.Controls.Add(this.txtMEmail);
            this.gpbContactInfo.Controls.Add(this.lblFax);
            this.gpbContactInfo.Controls.Add(this.txtFax);
            this.gpbContactInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContactInfo.Location = new System.Drawing.Point(11, 108);
            this.gpbContactInfo.Name = "gpbContactInfo";
            this.gpbContactInfo.Size = new System.Drawing.Size(955, 121);
            this.gpbContactInfo.TabIndex = 3;
            this.gpbContactInfo.TabStop = false;
            this.gpbContactInfo.Text = "Contact Infomation";
            // 
            // txtcontactNo
            // 
            this.txtcontactNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactNo.Location = new System.Drawing.Point(114, 31);
            this.txtcontactNo.Name = "txtcontactNo";
            this.txtcontactNo.Size = new System.Drawing.Size(191, 23);
            this.txtcontactNo.TabIndex = 4;
            this.txtcontactNo.TextChanged += new System.EventHandler(this.txtcontactNo_TextChanged);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(23, 35);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(76, 14);
            this.lblContactNo.TabIndex = 29;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(397, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 14);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email";
            // 
            // txtMEmail
            // 
            this.txtMEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEmail.Location = new System.Drawing.Point(450, 31);
            this.txtMEmail.Name = "txtMEmail";
            this.txtMEmail.Size = new System.Drawing.Size(191, 23);
            this.txtMEmail.TabIndex = 6;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFax.Location = new System.Drawing.Point(72, 81);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 14);
            this.lblFax.TabIndex = 35;
            this.lblFax.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(114, 77);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(191, 23);
            this.txtFax.TabIndex = 7;
            // 
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.lblWarehouseName);
            this.gpbBasicInfo.Controls.Add(this.txtWarehouseName);
            this.gpbBasicInfo.Controls.Add(this.lblWarehouseID);
            this.gpbBasicInfo.Controls.Add(this.txtWarehouseID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(11, 11);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(955, 91);
            this.gpbBasicInfo.TabIndex = 2;
            this.gpbBasicInfo.TabStop = false;
            this.gpbBasicInfo.Text = "Basic Infomation";
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseName.Location = new System.Drawing.Point(323, 34);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(112, 14);
            this.lblWarehouseName.TabIndex = 28;
            this.lblWarehouseName.Text = "Warehouse Name";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseName.Location = new System.Drawing.Point(450, 30);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(191, 23);
            this.txtWarehouseName.TabIndex = 2;
            // 
            // lblWarehouseID
            // 
            this.lblWarehouseID.AutoSize = true;
            this.lblWarehouseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseID.Location = new System.Drawing.Point(6, 34);
            this.lblWarehouseID.Name = "lblWarehouseID";
            this.lblWarehouseID.Size = new System.Drawing.Size(93, 14);
            this.lblWarehouseID.TabIndex = 26;
            this.lblWarehouseID.Text = "Warehouse ID";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseID.Location = new System.Drawing.Point(114, 30);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(191, 23);
            this.txtWarehouseID.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.tsslUser,
            this.toolStripStatusLabel1,
            this.tsslCompID,
            this.tsslEID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 23);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
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
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 446);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlWarehouse);
            this.MaximizeBox = false;
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            this.pnlWarehouse.ResumeLayout(false);
            this.pnlSWarehouse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCustomer)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbAddress.ResumeLayout(false);
            this.gpbAddress.PerformLayout();
            this.gpbContactInfo.ResumeLayout(false);
            this.gpbContactInfo.PerformLayout();
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWarehouse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label lblWarehouseID;
        private System.Windows.Forms.TextBox txtWarehouseID;
        private System.Windows.Forms.GroupBox gpbContactInfo;
        private System.Windows.Forms.TextBox txtcontactNo;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMEmail;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.GroupBox gpbAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblTownship;
        private System.Windows.Forms.TextBox txtTownship;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblHomeNo;
        private System.Windows.Forms.TextBox txtHomeNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlSWarehouse;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.ComboBox cboTownship;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSWarehouseName;
        private System.Windows.Forms.TextBox txtSWarehouseName;
        private System.Windows.Forms.CheckBox chkSCity;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.CheckBox chkSCountry;
        private System.Windows.Forms.DataGridView dgvSCustomer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}