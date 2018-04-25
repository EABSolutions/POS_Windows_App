namespace EAB_Business_Solution.Forms
{
    partial class frmMembership
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
            this.pnlMembership = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtMaximumAmount = new System.Windows.Forms.TextBox();
            this.lblMaximumAmount = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtMinimumAmount = new System.Windows.Forms.TextBox();
            this.lblMinimumAmount = new System.Windows.Forms.Label();
            this.txtMembershipFees = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblMembershipFees = new System.Windows.Forms.Label();
            this.lblMembershipName = new System.Windows.Forms.Label();
            this.txtMembershipName = new System.Windows.Forms.TextBox();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.txtMembershipID = new System.Windows.Forms.TextBox();
            this.pnlSMembership = new System.Windows.Forms.Panel();
            this.dgvSMembership = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.chkSMaximumAmount = new System.Windows.Forms.CheckBox();
            this.chkSMinimumAmount = new System.Windows.Forms.CheckBox();
            this.gpbSCont = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkSMembershipName = new System.Windows.Forms.CheckBox();
            this.txtSMembershipName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSMinimumAmount = new System.Windows.Forms.TextBox();
            this.txtSMaximumAmount = new System.Windows.Forms.TextBox();
            this.pnlMembership.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbBasicInfo.SuspendLayout();
            this.pnlSMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSMembership)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSCont.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMembership
            // 
            this.pnlMembership.Controls.Add(this.groupBox1);
            this.pnlMembership.Controls.Add(this.gpbBasicInfo);
            this.pnlMembership.Location = new System.Drawing.Point(1, 3);
            this.pnlMembership.Name = "pnlMembership";
            this.pnlMembership.Size = new System.Drawing.Size(784, 365);
            this.pnlMembership.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(88, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 6;
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
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.txtStatus);
            this.gpbBasicInfo.Controls.Add(this.lblStatus);
            this.gpbBasicInfo.Controls.Add(this.txtMaximumAmount);
            this.gpbBasicInfo.Controls.Add(this.lblMaximumAmount);
            this.gpbBasicInfo.Controls.Add(this.txtDescription);
            this.gpbBasicInfo.Controls.Add(this.lblDescription);
            this.gpbBasicInfo.Controls.Add(this.txtMinimumAmount);
            this.gpbBasicInfo.Controls.Add(this.lblMinimumAmount);
            this.gpbBasicInfo.Controls.Add(this.txtMembershipFees);
            this.gpbBasicInfo.Controls.Add(this.txtDiscount);
            this.gpbBasicInfo.Controls.Add(this.lblDiscount);
            this.gpbBasicInfo.Controls.Add(this.lblMembershipFees);
            this.gpbBasicInfo.Controls.Add(this.lblMembershipName);
            this.gpbBasicInfo.Controls.Add(this.txtMembershipName);
            this.gpbBasicInfo.Controls.Add(this.lblMembershipID);
            this.gpbBasicInfo.Controls.Add(this.txtMembershipID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(11, 9);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(766, 281);
            this.gpbBasicInfo.TabIndex = 3;
            this.gpbBasicInfo.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(527, 161);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(232, 103);
            this.txtStatus.TabIndex = 59;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(403, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 14);
            this.lblStatus.TabIndex = 58;
            this.lblStatus.Text = "Status";
            // 
            // txtMaximumAmount
            // 
            this.txtMaximumAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximumAmount.Location = new System.Drawing.Point(527, 115);
            this.txtMaximumAmount.Name = "txtMaximumAmount";
            this.txtMaximumAmount.Size = new System.Drawing.Size(191, 23);
            this.txtMaximumAmount.TabIndex = 57;
            // 
            // lblMaximumAmount
            // 
            this.lblMaximumAmount.AutoSize = true;
            this.lblMaximumAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumAmount.Location = new System.Drawing.Point(403, 119);
            this.lblMaximumAmount.Name = "lblMaximumAmount";
            this.lblMaximumAmount.Size = new System.Drawing.Size(119, 14);
            this.lblMaximumAmount.TabIndex = 56;
            this.lblMaximumAmount.Text = "Maximum Amount";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(153, 161);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 103);
            this.txtDescription.TabIndex = 55;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(13, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 14);
            this.lblDescription.TabIndex = 54;
            this.lblDescription.Text = "Description";
            // 
            // txtMinimumAmount
            // 
            this.txtMinimumAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimumAmount.Location = new System.Drawing.Point(153, 115);
            this.txtMinimumAmount.Name = "txtMinimumAmount";
            this.txtMinimumAmount.Size = new System.Drawing.Size(191, 23);
            this.txtMinimumAmount.TabIndex = 53;
            // 
            // lblMinimumAmount
            // 
            this.lblMinimumAmount.AutoSize = true;
            this.lblMinimumAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumAmount.Location = new System.Drawing.Point(13, 119);
            this.lblMinimumAmount.Name = "lblMinimumAmount";
            this.lblMinimumAmount.Size = new System.Drawing.Size(116, 14);
            this.lblMinimumAmount.TabIndex = 52;
            this.lblMinimumAmount.Text = "Minimum Amount";
            // 
            // txtMembershipFees
            // 
            this.txtMembershipFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembershipFees.Location = new System.Drawing.Point(153, 73);
            this.txtMembershipFees.Name = "txtMembershipFees";
            this.txtMembershipFees.Size = new System.Drawing.Size(191, 23);
            this.txtMembershipFees.TabIndex = 51;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(527, 73);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(191, 23);
            this.txtDiscount.TabIndex = 50;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(403, 76);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(61, 14);
            this.lblDiscount.TabIndex = 49;
            this.lblDiscount.Text = "Discount";
            // 
            // lblMembershipFees
            // 
            this.lblMembershipFees.AutoSize = true;
            this.lblMembershipFees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipFees.Location = new System.Drawing.Point(13, 77);
            this.lblMembershipFees.Name = "lblMembershipFees";
            this.lblMembershipFees.Size = new System.Drawing.Size(111, 14);
            this.lblMembershipFees.TabIndex = 47;
            this.lblMembershipFees.Text = "Membership Fees";
            // 
            // lblMembershipName
            // 
            this.lblMembershipName.AutoSize = true;
            this.lblMembershipName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipName.Location = new System.Drawing.Point(403, 34);
            this.lblMembershipName.Name = "lblMembershipName";
            this.lblMembershipName.Size = new System.Drawing.Size(118, 14);
            this.lblMembershipName.TabIndex = 28;
            this.lblMembershipName.Text = "Membership Name";
            // 
            // txtMembershipName
            // 
            this.txtMembershipName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembershipName.Location = new System.Drawing.Point(527, 30);
            this.txtMembershipName.Name = "txtMembershipName";
            this.txtMembershipName.Size = new System.Drawing.Size(191, 23);
            this.txtMembershipName.TabIndex = 2;
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipID.Location = new System.Drawing.Point(13, 35);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(99, 14);
            this.lblMembershipID.TabIndex = 26;
            this.lblMembershipID.Text = "Membership ID";
            // 
            // txtMembershipID
            // 
            this.txtMembershipID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembershipID.Location = new System.Drawing.Point(153, 31);
            this.txtMembershipID.Name = "txtMembershipID";
            this.txtMembershipID.Size = new System.Drawing.Size(191, 23);
            this.txtMembershipID.TabIndex = 1;
            // 
            // pnlSMembership
            // 
            this.pnlSMembership.Controls.Add(this.dgvSMembership);
            this.pnlSMembership.Controls.Add(this.gpbSearch);
            this.pnlSMembership.Location = new System.Drawing.Point(0, 2);
            this.pnlSMembership.Name = "pnlSMembership";
            this.pnlSMembership.Size = new System.Drawing.Size(786, 367);
            this.pnlSMembership.TabIndex = 60;
            // 
            // dgvSMembership
            // 
            this.dgvSMembership.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSMembership.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSMembership.Location = new System.Drawing.Point(290, 3);
            this.dgvSMembership.Name = "dgvSMembership";
            this.dgvSMembership.Size = new System.Drawing.Size(488, 356);
            this.dgvSMembership.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.txtSMaximumAmount);
            this.gpbSearch.Controls.Add(this.txtSMinimumAmount);
            this.gpbSearch.Controls.Add(this.chkSMaximumAmount);
            this.gpbSearch.Controls.Add(this.chkSMinimumAmount);
            this.gpbSearch.Controls.Add(this.gpbSCont);
            this.gpbSearch.Controls.Add(this.chkSMembershipName);
            this.gpbSearch.Controls.Add(this.txtSMembershipName);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(8, 11);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 339);
            this.gpbSearch.TabIndex = 8;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // chkSMaximumAmount
            // 
            this.chkSMaximumAmount.AutoSize = true;
            this.chkSMaximumAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMaximumAmount.Location = new System.Drawing.Point(10, 157);
            this.chkSMaximumAmount.Name = "chkSMaximumAmount";
            this.chkSMaximumAmount.Size = new System.Drawing.Size(138, 18);
            this.chkSMaximumAmount.TabIndex = 63;
            this.chkSMaximumAmount.Text = "Maximum Amount";
            this.chkSMaximumAmount.UseVisualStyleBackColor = true;
            // 
            // chkSMinimumAmount
            // 
            this.chkSMinimumAmount.AutoSize = true;
            this.chkSMinimumAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMinimumAmount.Location = new System.Drawing.Point(10, 95);
            this.chkSMinimumAmount.Name = "chkSMinimumAmount";
            this.chkSMinimumAmount.Size = new System.Drawing.Size(135, 18);
            this.chkSMinimumAmount.TabIndex = 62;
            this.chkSMinimumAmount.Text = "Minimum Amount";
            this.chkSMinimumAmount.UseVisualStyleBackColor = true;
            // 
            // gpbSCont
            // 
            this.gpbSCont.Controls.Add(this.button1);
            this.gpbSCont.Controls.Add(this.button2);
            this.gpbSCont.Controls.Add(this.button3);
            this.gpbSCont.Controls.Add(this.button4);
            this.gpbSCont.Location = new System.Drawing.Point(10, 224);
            this.gpbSCont.Name = "gpbSCont";
            this.gpbSCont.Size = new System.Drawing.Size(232, 105);
            this.gpbSCont.TabIndex = 59;
            this.gpbSCont.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(27, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Show &All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(125, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "&Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(27, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Searc&h";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // chkSMembershipName
            // 
            this.chkSMembershipName.AutoSize = true;
            this.chkSMembershipName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMembershipName.Location = new System.Drawing.Point(10, 35);
            this.chkSMembershipName.Name = "chkSMembershipName";
            this.chkSMembershipName.Size = new System.Drawing.Size(137, 18);
            this.chkSMembershipName.TabIndex = 48;
            this.chkSMembershipName.Text = "Membership Name";
            this.chkSMembershipName.UseVisualStyleBackColor = true;
            // 
            // txtSMembershipName
            // 
            this.txtSMembershipName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMembershipName.Location = new System.Drawing.Point(10, 60);
            this.txtSMembershipName.Name = "txtSMembershipName";
            this.txtSMembershipName.Size = new System.Drawing.Size(232, 23);
            this.txtSMembershipName.TabIndex = 2;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 23);
            this.statusStrip1.TabIndex = 11;
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
            // txtSMinimumAmount
            // 
            this.txtSMinimumAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMinimumAmount.Location = new System.Drawing.Point(10, 119);
            this.txtSMinimumAmount.Name = "txtSMinimumAmount";
            this.txtSMinimumAmount.Size = new System.Drawing.Size(232, 23);
            this.txtSMinimumAmount.TabIndex = 65;
            // 
            // txtSMaximumAmount
            // 
            this.txtSMaximumAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMaximumAmount.Location = new System.Drawing.Point(10, 181);
            this.txtSMaximumAmount.Name = "txtSMaximumAmount";
            this.txtSMaximumAmount.Size = new System.Drawing.Size(232, 23);
            this.txtSMaximumAmount.TabIndex = 66;
            // 
            // frmMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 395);
            this.Controls.Add(this.pnlSMembership);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMembership);
            this.MaximizeBox = false;
            this.Name = "frmMembership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership";
            this.pnlMembership.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.pnlSMembership.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSMembership)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSCont.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMembership;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtMinimumAmount;
        private System.Windows.Forms.Label lblMinimumAmount;
        private System.Windows.Forms.TextBox txtMembershipFees;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblMembershipFees;
        private System.Windows.Forms.Label lblMembershipName;
        private System.Windows.Forms.TextBox txtMembershipName;
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.TextBox txtMembershipID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtMaximumAmount;
        private System.Windows.Forms.Label lblMaximumAmount;
        private System.Windows.Forms.Panel pnlSMembership;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox gpbSCont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkSMembershipName;
        private System.Windows.Forms.TextBox txtSMembershipName;
        private System.Windows.Forms.CheckBox chkSMaximumAmount;
        private System.Windows.Forms.CheckBox chkSMinimumAmount;
        private System.Windows.Forms.DataGridView dgvSMembership;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.TextBox txtSMinimumAmount;
        private System.Windows.Forms.TextBox txtSMaximumAmount;
    }
}