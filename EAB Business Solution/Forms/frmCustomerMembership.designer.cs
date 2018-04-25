namespace EAB_Business_Solution.Forms
{
    partial class frmCustomerMembership
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
            this.pnlCustomerMembership = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbCustomerMemebrInfo = new System.Windows.Forms.GroupBox();
            this.lblNRCNo = new System.Windows.Forms.Label();
            this.lblMembershipName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.gpbMembershipPeriod = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.lblCustomerIDShow = new System.Windows.Forms.Label();
            this.lblNRCNoShow = new System.Windows.Forms.Label();
            this.lblMinAmountShow = new System.Windows.Forms.Label();
            this.lblMembershipIDShow = new System.Windows.Forms.Label();
            this.lblMinAmount = new System.Windows.Forms.Label();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.cboMembershipName = new System.Windows.Forms.ComboBox();
            this.lblMaxAmountShow = new System.Windows.Forms.Label();
            this.lblMaxAmount = new System.Windows.Forms.Label();
            this.lblDiscountShow = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblMembershipFeesShow = new System.Windows.Forms.Label();
            this.lblMembershipFees = new System.Windows.Forms.Label();
            this.pnlSCustomerMembership = new System.Windows.Forms.Panel();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.dtpSToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblSTo = new System.Windows.Forms.Label();
            this.gpbSCont = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvSCustomerMembership = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblPurchasedAmount = new System.Windows.Forms.Label();
            this.txtPurchasedAmount = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.chkEndDate = new System.Windows.Forms.CheckBox();
            this.cboSCustomerName = new System.Windows.Forms.ComboBox();
            this.chkSMembershipName = new System.Windows.Forms.CheckBox();
            this.chkSCustomerName = new System.Windows.Forms.CheckBox();
            this.cboSMembershpName = new System.Windows.Forms.ComboBox();
            this.chkSExpiredMembership = new System.Windows.Forms.CheckBox();
            this.chkSMembershipPeriod = new System.Windows.Forms.CheckBox();
            this.pnlCustomerMembership.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbCustomerMemebrInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gpbMembershipPeriod.SuspendLayout();
            this.pnlSCustomerMembership.SuspendLayout();
            this.gpbSearch.SuspendLayout();
            this.gpbSCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCustomerMembership)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomerMembership
            // 
            this.pnlCustomerMembership.Controls.Add(this.pnlSCustomerMembership);
            this.pnlCustomerMembership.Controls.Add(this.gpbMembershipPeriod);
            this.pnlCustomerMembership.Controls.Add(this.groupBox1);
            this.pnlCustomerMembership.Controls.Add(this.gpbCustomerMemebrInfo);
            this.pnlCustomerMembership.Location = new System.Drawing.Point(2, 0);
            this.pnlCustomerMembership.Name = "pnlCustomerMembership";
            this.pnlCustomerMembership.Size = new System.Drawing.Size(756, 426);
            this.pnlCustomerMembership.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(68, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 7;
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
            // gpbCustomerMemebrInfo
            // 
            this.gpbCustomerMemebrInfo.Controls.Add(this.txtPoints);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblPoints);
            this.gpbCustomerMemebrInfo.Controls.Add(this.txtPurchasedAmount);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblPurchasedAmount);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMembershipFeesShow);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMembershipFees);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblDiscountShow);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblDiscount);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMaxAmountShow);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMaxAmount);
            this.gpbCustomerMemebrInfo.Controls.Add(this.cboMembershipName);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMinAmountShow);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMembershipIDShow);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMinAmount);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMembershipID);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblNRCNoShow);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblCustomerIDShow);
            this.gpbCustomerMemebrInfo.Controls.Add(this.cboCustomerName);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblNRCNo);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblMembershipName);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblCustomerID);
            this.gpbCustomerMemebrInfo.Controls.Add(this.lblCustomerName);
            this.gpbCustomerMemebrInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCustomerMemebrInfo.Location = new System.Drawing.Point(10, 12);
            this.gpbCustomerMemebrInfo.Name = "gpbCustomerMemebrInfo";
            this.gpbCustomerMemebrInfo.Size = new System.Drawing.Size(733, 270);
            this.gpbCustomerMemebrInfo.TabIndex = 4;
            this.gpbCustomerMemebrInfo.TabStop = false;
            this.gpbCustomerMemebrInfo.Text = "Customer and Membership Information";
            // 
            // lblNRCNo
            // 
            this.lblNRCNo.AutoSize = true;
            this.lblNRCNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNo.Location = new System.Drawing.Point(13, 90);
            this.lblNRCNo.Name = "lblNRCNo";
            this.lblNRCNo.Size = new System.Drawing.Size(56, 14);
            this.lblNRCNo.TabIndex = 52;
            this.lblNRCNo.Text = "NRC No:";
            // 
            // lblMembershipName
            // 
            this.lblMembershipName.AutoSize = true;
            this.lblMembershipName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipName.Location = new System.Drawing.Point(381, 24);
            this.lblMembershipName.Name = "lblMembershipName";
            this.lblMembershipName.Size = new System.Drawing.Size(118, 14);
            this.lblMembershipName.TabIndex = 26;
            this.lblMembershipName.Text = "Membership Name";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(13, 59);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(88, 14);
            this.lblCustomerID.TabIndex = 47;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(13, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 14);
            this.lblCustomerName.TabIndex = 28;
            this.lblCustomerName.Text = "Customer Name";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 23);
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
            // gpbMembershipPeriod
            // 
            this.gpbMembershipPeriod.Controls.Add(this.chkEndDate);
            this.gpbMembershipPeriod.Controls.Add(this.dateTimePicker1);
            this.gpbMembershipPeriod.Controls.Add(this.dateTimePicker2);
            this.gpbMembershipPeriod.Controls.Add(this.label1);
            this.gpbMembershipPeriod.Controls.Add(this.label2);
            this.gpbMembershipPeriod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMembershipPeriod.Location = new System.Drawing.Point(10, 288);
            this.gpbMembershipPeriod.Name = "gpbMembershipPeriod";
            this.gpbMembershipPeriod.Size = new System.Drawing.Size(733, 61);
            this.gpbMembershipPeriod.TabIndex = 70;
            this.gpbMembershipPeriod.TabStop = false;
            this.gpbMembershipPeriod.Text = "Membership Period";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(514, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 23);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(152, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(191, 23);
            this.dateTimePicker2.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 54;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 52;
            this.label2.Text = "Start Date";
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(153, 21);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(191, 22);
            this.cboCustomerName.TabIndex = 62;
            // 
            // lblCustomerIDShow
            // 
            this.lblCustomerIDShow.AutoSize = true;
            this.lblCustomerIDShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerIDShow.Location = new System.Drawing.Point(150, 59);
            this.lblCustomerIDShow.Name = "lblCustomerIDShow";
            this.lblCustomerIDShow.Size = new System.Drawing.Size(84, 14);
            this.lblCustomerIDShow.TabIndex = 63;
            this.lblCustomerIDShow.Text = "Customer ID";
            // 
            // lblNRCNoShow
            // 
            this.lblNRCNoShow.AutoSize = true;
            this.lblNRCNoShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNoShow.Location = new System.Drawing.Point(150, 90);
            this.lblNRCNoShow.Name = "lblNRCNoShow";
            this.lblNRCNoShow.Size = new System.Drawing.Size(52, 14);
            this.lblNRCNoShow.TabIndex = 64;
            this.lblNRCNoShow.Text = "NRC No";
            // 
            // lblMinAmountShow
            // 
            this.lblMinAmountShow.AutoSize = true;
            this.lblMinAmountShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAmountShow.Location = new System.Drawing.Point(518, 119);
            this.lblMinAmountShow.Name = "lblMinAmountShow";
            this.lblMinAmountShow.Size = new System.Drawing.Size(83, 14);
            this.lblMinAmountShow.TabIndex = 68;
            this.lblMinAmountShow.Text = "Min Amount";
            // 
            // lblMembershipIDShow
            // 
            this.lblMembershipIDShow.AutoSize = true;
            this.lblMembershipIDShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipIDShow.Location = new System.Drawing.Point(518, 59);
            this.lblMembershipIDShow.Name = "lblMembershipIDShow";
            this.lblMembershipIDShow.Size = new System.Drawing.Size(99, 14);
            this.lblMembershipIDShow.TabIndex = 67;
            this.lblMembershipIDShow.Text = "Membership ID";
            // 
            // lblMinAmount
            // 
            this.lblMinAmount.AutoSize = true;
            this.lblMinAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAmount.Location = new System.Drawing.Point(381, 119);
            this.lblMinAmount.Name = "lblMinAmount";
            this.lblMinAmount.Size = new System.Drawing.Size(87, 14);
            this.lblMinAmount.TabIndex = 66;
            this.lblMinAmount.Text = "Min Amount:";
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipID.Location = new System.Drawing.Point(381, 59);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(103, 14);
            this.lblMembershipID.TabIndex = 65;
            this.lblMembershipID.Text = "Membership ID:";
            // 
            // cboMembershipName
            // 
            this.cboMembershipName.FormattingEnabled = true;
            this.cboMembershipName.Location = new System.Drawing.Point(514, 21);
            this.cboMembershipName.Name = "cboMembershipName";
            this.cboMembershipName.Size = new System.Drawing.Size(191, 22);
            this.cboMembershipName.TabIndex = 69;
            // 
            // lblMaxAmountShow
            // 
            this.lblMaxAmountShow.AutoSize = true;
            this.lblMaxAmountShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAmountShow.Location = new System.Drawing.Point(518, 148);
            this.lblMaxAmountShow.Name = "lblMaxAmountShow";
            this.lblMaxAmountShow.Size = new System.Drawing.Size(86, 14);
            this.lblMaxAmountShow.TabIndex = 71;
            this.lblMaxAmountShow.Text = "Max Amount";
            // 
            // lblMaxAmount
            // 
            this.lblMaxAmount.AutoSize = true;
            this.lblMaxAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAmount.Location = new System.Drawing.Point(381, 148);
            this.lblMaxAmount.Name = "lblMaxAmount";
            this.lblMaxAmount.Size = new System.Drawing.Size(90, 14);
            this.lblMaxAmount.TabIndex = 70;
            this.lblMaxAmount.Text = "Max Amount:";
            // 
            // lblDiscountShow
            // 
            this.lblDiscountShow.AutoSize = true;
            this.lblDiscountShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountShow.Location = new System.Drawing.Point(518, 178);
            this.lblDiscountShow.Name = "lblDiscountShow";
            this.lblDiscountShow.Size = new System.Drawing.Size(61, 14);
            this.lblDiscountShow.TabIndex = 73;
            this.lblDiscountShow.Text = "Discount";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(381, 178);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(65, 14);
            this.lblDiscount.TabIndex = 72;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblMembershipFeesShow
            // 
            this.lblMembershipFeesShow.AutoSize = true;
            this.lblMembershipFeesShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipFeesShow.Location = new System.Drawing.Point(518, 90);
            this.lblMembershipFeesShow.Name = "lblMembershipFeesShow";
            this.lblMembershipFeesShow.Size = new System.Drawing.Size(111, 14);
            this.lblMembershipFeesShow.TabIndex = 75;
            this.lblMembershipFeesShow.Text = "Membership Fees";
            // 
            // lblMembershipFees
            // 
            this.lblMembershipFees.AutoSize = true;
            this.lblMembershipFees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipFees.Location = new System.Drawing.Point(381, 90);
            this.lblMembershipFees.Name = "lblMembershipFees";
            this.lblMembershipFees.Size = new System.Drawing.Size(112, 14);
            this.lblMembershipFees.TabIndex = 74;
            this.lblMembershipFees.Text = "Membershp Fees:";
            // 
            // pnlSCustomerMembership
            // 
            this.pnlSCustomerMembership.Controls.Add(this.gpbSearch);
            this.pnlSCustomerMembership.Controls.Add(this.dgvSCustomerMembership);
            this.pnlSCustomerMembership.Location = new System.Drawing.Point(-2, 0);
            this.pnlSCustomerMembership.Name = "pnlSCustomerMembership";
            this.pnlSCustomerMembership.Size = new System.Drawing.Size(758, 423);
            this.pnlSCustomerMembership.TabIndex = 58;
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.chkSMembershipPeriod);
            this.gpbSearch.Controls.Add(this.chkSExpiredMembership);
            this.gpbSearch.Controls.Add(this.chkSCustomerName);
            this.gpbSearch.Controls.Add(this.cboSMembershpName);
            this.gpbSearch.Controls.Add(this.chkSMembershipName);
            this.gpbSearch.Controls.Add(this.cboSCustomerName);
            this.gpbSearch.Controls.Add(this.dtpSToDate);
            this.gpbSearch.Controls.Add(this.dtpSFromDate);
            this.gpbSearch.Controls.Add(this.lblSTo);
            this.gpbSearch.Controls.Add(this.gpbSCont);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(10, 7);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(250, 405);
            this.gpbSearch.TabIndex = 12;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // dtpSToDate
            // 
            this.dtpSToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.CustomFormat = "dd MMM yyyy";
            this.dtpSToDate.Enabled = false;
            this.dtpSToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSToDate.Location = new System.Drawing.Point(18, 221);
            this.dtpSToDate.Name = "dtpSToDate";
            this.dtpSToDate.Size = new System.Drawing.Size(211, 23);
            this.dtpSToDate.TabIndex = 68;
            // 
            // dtpSFromDate
            // 
            this.dtpSFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpSFromDate.Enabled = false;
            this.dtpSFromDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSFromDate.Location = new System.Drawing.Point(18, 173);
            this.dtpSFromDate.Name = "dtpSFromDate";
            this.dtpSFromDate.Size = new System.Drawing.Size(211, 23);
            this.dtpSFromDate.TabIndex = 67;
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(96, 204);
            this.lblSTo.Name = "lblSTo";
            this.lblSTo.Size = new System.Drawing.Size(22, 14);
            this.lblSTo.TabIndex = 62;
            this.lblSTo.Text = "To";
            // 
            // gpbSCont
            // 
            this.gpbSCont.Controls.Add(this.button1);
            this.gpbSCont.Controls.Add(this.button2);
            this.gpbSCont.Controls.Add(this.button3);
            this.gpbSCont.Controls.Add(this.button4);
            this.gpbSCont.Location = new System.Drawing.Point(25, 290);
            this.gpbSCont.Name = "gpbSCont";
            this.gpbSCont.Size = new System.Drawing.Size(206, 105);
            this.gpbSCont.TabIndex = 59;
            this.gpbSCont.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Show &All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(109, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "&Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(11, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Searc&h";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvSCustomerMembership
            // 
            this.dgvSCustomerMembership.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSCustomerMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSCustomerMembership.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSCustomerMembership.Location = new System.Drawing.Point(275, 12);
            this.dgvSCustomerMembership.Name = "dgvSCustomerMembership";
            this.dgvSCustomerMembership.Size = new System.Drawing.Size(473, 400);
            this.dgvSCustomerMembership.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // lblPurchasedAmount
            // 
            this.lblPurchasedAmount.AutoSize = true;
            this.lblPurchasedAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedAmount.Location = new System.Drawing.Point(13, 225);
            this.lblPurchasedAmount.Name = "lblPurchasedAmount";
            this.lblPurchasedAmount.Size = new System.Drawing.Size(124, 14);
            this.lblPurchasedAmount.TabIndex = 76;
            this.lblPurchasedAmount.Text = "Purchased Amount";
            // 
            // txtPurchasedAmount
            // 
            this.txtPurchasedAmount.Enabled = false;
            this.txtPurchasedAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasedAmount.Location = new System.Drawing.Point(153, 221);
            this.txtPurchasedAmount.Name = "txtPurchasedAmount";
            this.txtPurchasedAmount.Size = new System.Drawing.Size(191, 23);
            this.txtPurchasedAmount.TabIndex = 77;
            // 
            // txtPoints
            // 
            this.txtPoints.Enabled = false;
            this.txtPoints.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(515, 221);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(191, 23);
            this.txtPoints.TabIndex = 79;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(381, 225);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(46, 14);
            this.lblPoints.TabIndex = 78;
            this.lblPoints.Text = "Points";
            // 
            // chkEndDate
            // 
            this.chkEndDate.AutoSize = true;
            this.chkEndDate.Location = new System.Drawing.Point(384, 27);
            this.chkEndDate.Name = "chkEndDate";
            this.chkEndDate.Size = new System.Drawing.Size(15, 14);
            this.chkEndDate.TabIndex = 70;
            this.chkEndDate.UseVisualStyleBackColor = true;
            // 
            // cboSCustomerName
            // 
            this.cboSCustomerName.FormattingEnabled = true;
            this.cboSCustomerName.Location = new System.Drawing.Point(18, 47);
            this.cboSCustomerName.Name = "cboSCustomerName";
            this.cboSCustomerName.Size = new System.Drawing.Size(213, 22);
            this.cboSCustomerName.TabIndex = 80;
            // 
            // chkSMembershipName
            // 
            this.chkSMembershipName.AutoSize = true;
            this.chkSMembershipName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMembershipName.Location = new System.Drawing.Point(18, 87);
            this.chkSMembershipName.Name = "chkSMembershipName";
            this.chkSMembershipName.Size = new System.Drawing.Size(137, 18);
            this.chkSMembershipName.TabIndex = 81;
            this.chkSMembershipName.Text = "Membership Name";
            this.chkSMembershipName.UseVisualStyleBackColor = true;
            // 
            // chkSCustomerName
            // 
            this.chkSCustomerName.AutoSize = true;
            this.chkSCustomerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCustomerName.Location = new System.Drawing.Point(18, 27);
            this.chkSCustomerName.Name = "chkSCustomerName";
            this.chkSCustomerName.Size = new System.Drawing.Size(122, 18);
            this.chkSCustomerName.TabIndex = 83;
            this.chkSCustomerName.Text = "Customer Name";
            this.chkSCustomerName.UseVisualStyleBackColor = true;
            // 
            // cboSMembershpName
            // 
            this.cboSMembershpName.FormattingEnabled = true;
            this.cboSMembershpName.Location = new System.Drawing.Point(18, 109);
            this.cboSMembershpName.Name = "cboSMembershpName";
            this.cboSMembershpName.Size = new System.Drawing.Size(213, 22);
            this.cboSMembershpName.TabIndex = 82;
            // 
            // chkSExpiredMembership
            // 
            this.chkSExpiredMembership.AutoSize = true;
            this.chkSExpiredMembership.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSExpiredMembership.Location = new System.Drawing.Point(17, 266);
            this.chkSExpiredMembership.Name = "chkSExpiredMembership";
            this.chkSExpiredMembership.Size = new System.Drawing.Size(155, 18);
            this.chkSExpiredMembership.TabIndex = 84;
            this.chkSExpiredMembership.Text = "Expired Memberships";
            this.chkSExpiredMembership.UseVisualStyleBackColor = true;
            // 
            // chkSMembershipPeriod
            // 
            this.chkSMembershipPeriod.AutoSize = true;
            this.chkSMembershipPeriod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMembershipPeriod.Location = new System.Drawing.Point(17, 152);
            this.chkSMembershipPeriod.Name = "chkSMembershipPeriod";
            this.chkSMembershipPeriod.Size = new System.Drawing.Size(143, 18);
            this.chkSMembershipPeriod.TabIndex = 85;
            this.chkSMembershipPeriod.Text = "Membership Period";
            this.chkSMembershipPeriod.UseVisualStyleBackColor = true;
            // 
            // frmCustomerMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 452);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlCustomerMembership);
            this.MaximizeBox = false;
            this.Name = "frmCustomerMembership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Membership";
            this.pnlCustomerMembership.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbCustomerMemebrInfo.ResumeLayout(false);
            this.gpbCustomerMemebrInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gpbMembershipPeriod.ResumeLayout(false);
            this.gpbMembershipPeriod.PerformLayout();
            this.pnlSCustomerMembership.ResumeLayout(false);
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCustomerMembership)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerMembership;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.GroupBox gpbCustomerMemebrInfo;
        private System.Windows.Forms.Label lblMembershipName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblNRCNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbMembershipPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Label lblCustomerIDShow;
        private System.Windows.Forms.Label lblMinAmountShow;
        private System.Windows.Forms.Label lblMembershipIDShow;
        private System.Windows.Forms.Label lblMinAmount;
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.Label lblNRCNoShow;
        private System.Windows.Forms.ComboBox cboMembershipName;
        private System.Windows.Forms.Label lblMembershipFeesShow;
        private System.Windows.Forms.Label lblMembershipFees;
        private System.Windows.Forms.Label lblDiscountShow;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblMaxAmountShow;
        private System.Windows.Forms.Label lblMaxAmount;
        private System.Windows.Forms.Label lblPurchasedAmount;
        private System.Windows.Forms.Panel pnlSCustomerMembership;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.DateTimePicker dtpSToDate;
        private System.Windows.Forms.DateTimePicker dtpSFromDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.GroupBox gpbSCont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvSCustomerMembership;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.ComboBox cboSCustomerName;
        private System.Windows.Forms.CheckBox chkEndDate;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtPurchasedAmount;
        private System.Windows.Forms.CheckBox chkSCustomerName;
        private System.Windows.Forms.ComboBox cboSMembershpName;
        private System.Windows.Forms.CheckBox chkSMembershipName;
        private System.Windows.Forms.CheckBox chkSMembershipPeriod;
        private System.Windows.Forms.CheckBox chkSExpiredMembership;
    }
}