namespace EAB_Business_Solution
{
    partial class frmCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.pnlSCompany = new System.Windows.Forms.Panel();
            this.dgvSCompany = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.cboSTownship = new System.Windows.Forms.ComboBox();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSCompanyName = new System.Windows.Forms.CheckBox();
            this.txtSCompanyName = new System.Windows.Forms.TextBox();
            this.chkSTownship = new System.Windows.Forms.CheckBox();
            this.cboSCity = new System.Windows.Forms.ComboBox();
            this.cboSCountry = new System.Windows.Forms.ComboBox();
            this.chkSCountry = new System.Windows.Forms.CheckBox();
            this.chkSCity = new System.Windows.Forms.CheckBox();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblTownship = new System.Windows.Forms.Label();
            this.txtTownship = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblHomeNo = new System.Windows.Forms.Label();
            this.txtHomeNo = new System.Windows.Forms.TextBox();
            this.gpbContactInfo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPrimaryPhoneNo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSecondaryPhoneNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMEmail = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblCEOName = new System.Windows.Forms.Label();
            this.txtCEOName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.ssCompany = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlCompany.SuspendLayout();
            this.pnlSCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCompany)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            this.gpbAddress.SuspendLayout();
            this.gpbContactInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbBasicInfo.SuspendLayout();
            this.ssCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCompany
            // 
            this.pnlCompany.Controls.Add(this.pnlSCompany);
            this.pnlCompany.Controls.Add(this.gpbAddress);
            this.pnlCompany.Controls.Add(this.gpbContactInfo);
            this.pnlCompany.Controls.Add(this.groupBox1);
            this.pnlCompany.Controls.Add(this.gpbBasicInfo);
            this.pnlCompany.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(1149, 443);
            this.pnlCompany.TabIndex = 0;
            // 
            // pnlSCompany
            // 
            this.pnlSCompany.BackColor = System.Drawing.Color.Transparent;
            this.pnlSCompany.Controls.Add(this.dgvSCompany);
            this.pnlSCompany.Controls.Add(this.gpbSearch);
            this.pnlSCompany.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlSCompany.Name = "pnlSCompany";
            this.pnlSCompany.Size = new System.Drawing.Size(1149, 440);
            this.pnlSCompany.TabIndex = 4;
            // 
            // dgvSCompany
            // 
            this.dgvSCompany.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSCompany.Location = new System.Drawing.Point(288, 14);
            this.dgvSCompany.Name = "dgvSCompany";
            this.dgvSCompany.Size = new System.Drawing.Size(849, 416);
            this.dgvSCompany.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.cboSTownship);
            this.gpbSearch.Controls.Add(this.gpbSControl);
            this.gpbSearch.Controls.Add(this.chkSCompanyName);
            this.gpbSearch.Controls.Add(this.txtSCompanyName);
            this.gpbSearch.Controls.Add(this.chkSTownship);
            this.gpbSearch.Controls.Add(this.cboSCity);
            this.gpbSearch.Controls.Add(this.cboSCountry);
            this.gpbSearch.Controls.Add(this.chkSCountry);
            this.gpbSearch.Controls.Add(this.chkSCity);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(12, 9);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 421);
            this.gpbSearch.TabIndex = 0;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // cboSTownship
            // 
            this.cboSTownship.FormattingEnabled = true;
            this.cboSTownship.Location = new System.Drawing.Point(13, 258);
            this.cboSTownship.Name = "cboSTownship";
            this.cboSTownship.Size = new System.Drawing.Size(232, 22);
            this.cboSTownship.TabIndex = 57;
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnSDelete);
            this.gpbSControl.Controls.Add(this.btnSShowAll);
            this.gpbSControl.Controls.Add(this.btnSCancel);
            this.gpbSControl.Controls.Add(this.btnSSearch);
            this.gpbSControl.Location = new System.Drawing.Point(13, 296);
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
            this.btnSCancel.Click += new System.EventHandler(this.btnSCancel_Click);
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
            // chkSCompanyName
            // 
            this.chkSCompanyName.AutoSize = true;
            this.chkSCompanyName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCompanyName.Location = new System.Drawing.Point(13, 35);
            this.chkSCompanyName.Name = "chkSCompanyName";
            this.chkSCompanyName.Size = new System.Drawing.Size(120, 18);
            this.chkSCompanyName.TabIndex = 48;
            this.chkSCompanyName.Text = "Company Name";
            this.chkSCompanyName.UseVisualStyleBackColor = true;
            // 
            // txtSCompanyName
            // 
            this.txtSCompanyName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCompanyName.Location = new System.Drawing.Point(13, 57);
            this.txtSCompanyName.Name = "txtSCompanyName";
            this.txtSCompanyName.Size = new System.Drawing.Size(232, 23);
            this.txtSCompanyName.TabIndex = 2;
            // 
            // chkSTownship
            // 
            this.chkSTownship.AutoSize = true;
            this.chkSTownship.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSTownship.Location = new System.Drawing.Point(13, 236);
            this.chkSTownship.Name = "chkSTownship";
            this.chkSTownship.Size = new System.Drawing.Size(85, 18);
            this.chkSTownship.TabIndex = 54;
            this.chkSTownship.Text = "Township";
            this.chkSTownship.UseVisualStyleBackColor = true;
            // 
            // cboSCity
            // 
            this.cboSCity.FormattingEnabled = true;
            this.cboSCity.Location = new System.Drawing.Point(13, 190);
            this.cboSCity.Name = "cboSCity";
            this.cboSCity.Size = new System.Drawing.Size(232, 22);
            this.cboSCity.TabIndex = 56;
            // 
            // cboSCountry
            // 
            this.cboSCountry.FormattingEnabled = true;
            this.cboSCountry.Location = new System.Drawing.Point(13, 123);
            this.cboSCountry.Name = "cboSCountry";
            this.cboSCountry.Size = new System.Drawing.Size(232, 22);
            this.cboSCountry.TabIndex = 55;
            // 
            // chkSCountry
            // 
            this.chkSCountry.AutoSize = true;
            this.chkSCountry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCountry.Location = new System.Drawing.Point(13, 101);
            this.chkSCountry.Name = "chkSCountry";
            this.chkSCountry.Size = new System.Drawing.Size(76, 18);
            this.chkSCountry.TabIndex = 50;
            this.chkSCountry.Text = "Country";
            this.chkSCountry.UseVisualStyleBackColor = true;
            // 
            // chkSCity
            // 
            this.chkSCity.AutoSize = true;
            this.chkSCity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCity.Location = new System.Drawing.Point(13, 168);
            this.chkSCity.Name = "chkSCity";
            this.chkSCity.Size = new System.Drawing.Size(50, 18);
            this.chkSCity.TabIndex = 52;
            this.chkSCity.Text = "City";
            this.chkSCity.UseVisualStyleBackColor = true;
            // 
            // gpbAddress
            // 
            this.gpbAddress.Controls.Add(this.lblCountry);
            this.gpbAddress.Controls.Add(this.textBox4);
            this.gpbAddress.Controls.Add(this.lblCity);
            this.gpbAddress.Controls.Add(this.txtCity);
            this.gpbAddress.Controls.Add(this.lblTownship);
            this.gpbAddress.Controls.Add(this.txtTownship);
            this.gpbAddress.Controls.Add(this.lblStreet);
            this.gpbAddress.Controls.Add(this.txtStreet);
            this.gpbAddress.Controls.Add(this.lblHomeNo);
            this.gpbAddress.Controls.Add(this.txtHomeNo);
            this.gpbAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAddress.Location = new System.Drawing.Point(12, 230);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(1124, 115);
            this.gpbAddress.TabIndex = 2;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Address";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(781, 34);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 14);
            this.lblCountry.TabIndex = 55;
            this.lblCountry.Text = "Country";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(872, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(232, 23);
            this.textBox4.TabIndex = 12;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(408, 78);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 14);
            this.lblCity.TabIndex = 53;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(521, 72);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(232, 23);
            this.txtCity.TabIndex = 11;
            // 
            // lblTownship
            // 
            this.lblTownship.AutoSize = true;
            this.lblTownship.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownship.Location = new System.Drawing.Point(408, 34);
            this.lblTownship.Name = "lblTownship";
            this.lblTownship.Size = new System.Drawing.Size(66, 14);
            this.lblTownship.TabIndex = 51;
            this.lblTownship.Text = "Township";
            this.lblTownship.Click += new System.EventHandler(this.lblTownship_Click);
            // 
            // txtTownship
            // 
            this.txtTownship.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTownship.Location = new System.Drawing.Point(521, 31);
            this.txtTownship.Name = "txtTownship";
            this.txtTownship.Size = new System.Drawing.Size(232, 23);
            this.txtTownship.TabIndex = 10;
            this.txtTownship.TextChanged += new System.EventHandler(this.txtTownship_TextChanged);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(13, 75);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 14);
            this.lblStreet.TabIndex = 49;
            this.lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(153, 72);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(232, 23);
            this.txtStreet.TabIndex = 9;
            // 
            // lblHomeNo
            // 
            this.lblHomeNo.AutoSize = true;
            this.lblHomeNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeNo.Location = new System.Drawing.Point(13, 34);
            this.lblHomeNo.Name = "lblHomeNo";
            this.lblHomeNo.Size = new System.Drawing.Size(62, 14);
            this.lblHomeNo.TabIndex = 47;
            this.lblHomeNo.Text = "Home No";
            // 
            // txtHomeNo
            // 
            this.txtHomeNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeNo.Location = new System.Drawing.Point(153, 31);
            this.txtHomeNo.Name = "txtHomeNo";
            this.txtHomeNo.Size = new System.Drawing.Size(232, 23);
            this.txtHomeNo.TabIndex = 8;
            // 
            // gpbContactInfo
            // 
            this.gpbContactInfo.Controls.Add(this.textBox2);
            this.gpbContactInfo.Controls.Add(this.lblPrimaryPhoneNo);
            this.gpbContactInfo.Controls.Add(this.textBox1);
            this.gpbContactInfo.Controls.Add(this.lblSecondaryPhoneNo);
            this.gpbContactInfo.Controls.Add(this.lblEmail);
            this.gpbContactInfo.Controls.Add(this.txtMEmail);
            this.gpbContactInfo.Controls.Add(this.lblFax);
            this.gpbContactInfo.Controls.Add(this.txtFax);
            this.gpbContactInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContactInfo.Location = new System.Drawing.Point(12, 96);
            this.gpbContactInfo.Name = "gpbContactInfo";
            this.gpbContactInfo.Size = new System.Drawing.Size(1124, 121);
            this.gpbContactInfo.TabIndex = 1;
            this.gpbContactInfo.TabStop = false;
            this.gpbContactInfo.Text = "Contact Infomation";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(153, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 23);
            this.textBox2.TabIndex = 4;
            // 
            // lblPrimaryPhoneNo
            // 
            this.lblPrimaryPhoneNo.AutoSize = true;
            this.lblPrimaryPhoneNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryPhoneNo.Location = new System.Drawing.Point(12, 38);
            this.lblPrimaryPhoneNo.Name = "lblPrimaryPhoneNo";
            this.lblPrimaryPhoneNo.Size = new System.Drawing.Size(116, 14);
            this.lblPrimaryPhoneNo.TabIndex = 29;
            this.lblPrimaryPhoneNo.Text = "Primary Phone No";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(153, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 5;
            // 
            // lblSecondaryPhoneNo
            // 
            this.lblSecondaryPhoneNo.AutoSize = true;
            this.lblSecondaryPhoneNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryPhoneNo.Location = new System.Drawing.Point(12, 76);
            this.lblSecondaryPhoneNo.Name = "lblSecondaryPhoneNo";
            this.lblSecondaryPhoneNo.Size = new System.Drawing.Size(134, 14);
            this.lblSecondaryPhoneNo.TabIndex = 31;
            this.lblSecondaryPhoneNo.Text = "Secondary Phone No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(415, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 14);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email";
            // 
            // txtMEmail
            // 
            this.txtMEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEmail.Location = new System.Drawing.Point(521, 35);
            this.txtMEmail.Name = "txtMEmail";
            this.txtMEmail.Size = new System.Drawing.Size(232, 23);
            this.txtMEmail.TabIndex = 6;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFax.Location = new System.Drawing.Point(415, 76);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 14);
            this.lblFax.TabIndex = 35;
            this.lblFax.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(521, 73);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(232, 23);
            this.txtFax.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(233, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(510, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 31);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(219, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(21, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 31);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(118, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 31);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(318, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.lblCEOName);
            this.gpbBasicInfo.Controls.Add(this.txtCEOName);
            this.gpbBasicInfo.Controls.Add(this.lblCompanyName);
            this.gpbBasicInfo.Controls.Add(this.txtCompanyName);
            this.gpbBasicInfo.Controls.Add(this.lblCompanyID);
            this.gpbBasicInfo.Controls.Add(this.txtCompanyID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(12, 10);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(1124, 74);
            this.gpbBasicInfo.TabIndex = 0;
            this.gpbBasicInfo.TabStop = false;
            this.gpbBasicInfo.Text = "Basic Infomation";
            this.gpbBasicInfo.Enter += new System.EventHandler(this.gpbBasicInfo_Enter);
            // 
            // lblCEOName
            // 
            this.lblCEOName.AutoSize = true;
            this.lblCEOName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEOName.Location = new System.Drawing.Point(781, 35);
            this.lblCEOName.Name = "lblCEOName";
            this.lblCEOName.Size = new System.Drawing.Size(68, 14);
            this.lblCEOName.TabIndex = 47;
            this.lblCEOName.Text = "CEO Name";
            // 
            // txtCEOName
            // 
            this.txtCEOName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEOName.Location = new System.Drawing.Point(872, 32);
            this.txtCEOName.Name = "txtCEOName";
            this.txtCEOName.Size = new System.Drawing.Size(232, 23);
            this.txtCEOName.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(413, 35);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(101, 14);
            this.lblCompanyName.TabIndex = 28;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(521, 30);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(232, 23);
            this.txtCompanyName.TabIndex = 2;
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyID.Location = new System.Drawing.Point(13, 33);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(82, 14);
            this.lblCompanyID.TabIndex = 26;
            this.lblCompanyID.Text = "Company ID";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyID.Location = new System.Drawing.Point(153, 30);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(232, 23);
            this.txtCompanyID.TabIndex = 1;
            // 
            // ssCompany
            // 
            this.ssCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.tsslUser,
            this.tsslCompID,
            this.tsslEID});
            this.ssCompany.Location = new System.Drawing.Point(0, 443);
            this.ssCompany.Name = "ssCompany";
            this.ssCompany.Size = new System.Drawing.Size(1151, 23);
            this.ssCompany.TabIndex = 3;
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
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 466);
            this.Controls.Add(this.ssCompany);
            this.Controls.Add(this.pnlCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.pnlCompany.ResumeLayout(false);
            this.pnlSCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCompany)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            this.gpbAddress.ResumeLayout(false);
            this.gpbAddress.PerformLayout();
            this.gpbContactInfo.ResumeLayout(false);
            this.gpbContactInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.ssCompany.ResumeLayout(false);
            this.ssCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.Label lblCEOName;
        private System.Windows.Forms.TextBox txtCEOName;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMEmail;
        private System.Windows.Forms.Label lblSecondaryPhoneNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrimaryPhoneNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gpbContactInfo;
        private System.Windows.Forms.GroupBox gpbAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblTownship;
        private System.Windows.Forms.TextBox txtTownship;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblHomeNo;
        private System.Windows.Forms.TextBox txtHomeNo;
        private System.Windows.Forms.Panel pnlSCompany;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.ComboBox cboSTownship;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSCompanyName;
        private System.Windows.Forms.TextBox txtSCompanyName;
        private System.Windows.Forms.CheckBox chkSTownship;
        private System.Windows.Forms.ComboBox cboSCity;
        private System.Windows.Forms.ComboBox cboSCountry;
        private System.Windows.Forms.CheckBox chkSCountry;
        private System.Windows.Forms.CheckBox chkSCity;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.DataGridView dgvSCompany;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.StatusStrip ssCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
    }
}

