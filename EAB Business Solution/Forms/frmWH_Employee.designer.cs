namespace EAB_Business_Solution.Forms
{
    partial class frmWH_Employee
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
            this.pnlWH_Employee = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbWarehouseInfo = new System.Windows.Forms.GroupBox();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.cboWarehouseName = new System.Windows.Forms.ComboBox();
            this.lblAddressShow = new System.Windows.Forms.Label();
            this.lblWarehouseIDShow = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblWarehouseID = new System.Windows.Forms.Label();
            this.gpbEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.lblDepartmentShow = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPositionShow = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblNRCNoShow = new System.Windows.Forms.Label();
            this.lblEmployeeIDShow = new System.Windows.Forms.Label();
            this.lblNRCNo = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.cboEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.gpbAssignPeriod = new System.Windows.Forms.GroupBox();
            this.dtpLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.chkLeaveDate = new System.Windows.Forms.CheckBox();
            this.pnlSWH_Employee = new System.Windows.Forms.Panel();
            this.dgvSWH_Employee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.dtpSLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSJoinDate = new System.Windows.Forms.DateTimePicker();
            this.lblSTo = new System.Windows.Forms.Label();
            this.gpbSCont = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkSWarehouseName = new System.Windows.Forms.CheckBox();
            this.cboSEmployeeName = new System.Windows.Forms.ComboBox();
            this.chkSEmployeeName = new System.Windows.Forms.CheckBox();
            this.cboSWarehouseName = new System.Windows.Forms.ComboBox();
            this.chkSJoinDate = new System.Windows.Forms.CheckBox();
            this.chkSLeaveDate = new System.Windows.Forms.CheckBox();
            this.pnlWH_Employee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbWarehouseInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gpbEmployeeInfo.SuspendLayout();
            this.gpbAssignPeriod.SuspendLayout();
            this.pnlSWH_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSWH_Employee)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWH_Employee
            // 
            this.pnlWH_Employee.Controls.Add(this.pnlSWH_Employee);
            this.pnlWH_Employee.Controls.Add(this.gpbAssignPeriod);
            this.pnlWH_Employee.Controls.Add(this.gpbEmployeeInfo);
            this.pnlWH_Employee.Controls.Add(this.groupBox1);
            this.pnlWH_Employee.Controls.Add(this.gpbWarehouseInfo);
            this.pnlWH_Employee.Location = new System.Drawing.Point(0, 1);
            this.pnlWH_Employee.Name = "pnlWH_Employee";
            this.pnlWH_Employee.Size = new System.Drawing.Size(752, 374);
            this.pnlWH_Employee.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(71, 300);
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
            // gpbWarehouseInfo
            // 
            this.gpbWarehouseInfo.Controls.Add(this.lblAddressShow);
            this.gpbWarehouseInfo.Controls.Add(this.lblWarehouseIDShow);
            this.gpbWarehouseInfo.Controls.Add(this.lblAddress);
            this.gpbWarehouseInfo.Controls.Add(this.lblWarehouseID);
            this.gpbWarehouseInfo.Controls.Add(this.cboWarehouseName);
            this.gpbWarehouseInfo.Controls.Add(this.lblWarehouseName);
            this.gpbWarehouseInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbWarehouseInfo.Location = new System.Drawing.Point(12, 12);
            this.gpbWarehouseInfo.Name = "gpbWarehouseInfo";
            this.gpbWarehouseInfo.Size = new System.Drawing.Size(359, 212);
            this.gpbWarehouseInfo.TabIndex = 5;
            this.gpbWarehouseInfo.TabStop = false;
            this.gpbWarehouseInfo.Text = "Warehouse Information";
            this.gpbWarehouseInfo.Enter += new System.EventHandler(this.gpbBasicInfo_Enter);
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseName.Location = new System.Drawing.Point(13, 37);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(113, 14);
            this.lblWarehouseName.TabIndex = 28;
            this.lblWarehouseName.Text = "WareHouse Name";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 23);
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
            // cboWarehouseName
            // 
            this.cboWarehouseName.FormattingEnabled = true;
            this.cboWarehouseName.Location = new System.Drawing.Point(153, 35);
            this.cboWarehouseName.Name = "cboWarehouseName";
            this.cboWarehouseName.Size = new System.Drawing.Size(191, 22);
            this.cboWarehouseName.TabIndex = 73;
            // 
            // lblAddressShow
            // 
            this.lblAddressShow.AutoSize = true;
            this.lblAddressShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressShow.Location = new System.Drawing.Point(150, 98);
            this.lblAddressShow.Name = "lblAddressShow";
            this.lblAddressShow.Size = new System.Drawing.Size(56, 14);
            this.lblAddressShow.TabIndex = 77;
            this.lblAddressShow.Text = "Address";
            // 
            // lblWarehouseIDShow
            // 
            this.lblWarehouseIDShow.AutoSize = true;
            this.lblWarehouseIDShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseIDShow.Location = new System.Drawing.Point(150, 67);
            this.lblWarehouseIDShow.Name = "lblWarehouseIDShow";
            this.lblWarehouseIDShow.Size = new System.Drawing.Size(93, 14);
            this.lblWarehouseIDShow.TabIndex = 76;
            this.lblWarehouseIDShow.Text = "Warehouse ID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 98);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 14);
            this.lblAddress.TabIndex = 75;
            this.lblAddress.Text = "Address:";
            // 
            // lblWarehouseID
            // 
            this.lblWarehouseID.AutoSize = true;
            this.lblWarehouseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseID.Location = new System.Drawing.Point(13, 67);
            this.lblWarehouseID.Name = "lblWarehouseID";
            this.lblWarehouseID.Size = new System.Drawing.Size(97, 14);
            this.lblWarehouseID.TabIndex = 74;
            this.lblWarehouseID.Text = "Warehouse ID:";
            // 
            // gpbEmployeeInfo
            // 
            this.gpbEmployeeInfo.Controls.Add(this.lblDepartmentShow);
            this.gpbEmployeeInfo.Controls.Add(this.lblDepartment);
            this.gpbEmployeeInfo.Controls.Add(this.lblPositionShow);
            this.gpbEmployeeInfo.Controls.Add(this.lblPosition);
            this.gpbEmployeeInfo.Controls.Add(this.lblNRCNoShow);
            this.gpbEmployeeInfo.Controls.Add(this.lblEmployeeIDShow);
            this.gpbEmployeeInfo.Controls.Add(this.lblNRCNo);
            this.gpbEmployeeInfo.Controls.Add(this.lblEmployeeID);
            this.gpbEmployeeInfo.Controls.Add(this.cboEmployeeName);
            this.gpbEmployeeInfo.Controls.Add(this.lblEmployeeName);
            this.gpbEmployeeInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEmployeeInfo.Location = new System.Drawing.Point(377, 13);
            this.gpbEmployeeInfo.Name = "gpbEmployeeInfo";
            this.gpbEmployeeInfo.Size = new System.Drawing.Size(359, 212);
            this.gpbEmployeeInfo.TabIndex = 78;
            this.gpbEmployeeInfo.TabStop = false;
            this.gpbEmployeeInfo.Text = "Employee Infomation";
            // 
            // lblDepartmentShow
            // 
            this.lblDepartmentShow.AutoSize = true;
            this.lblDepartmentShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentShow.Location = new System.Drawing.Point(161, 160);
            this.lblDepartmentShow.Name = "lblDepartmentShow";
            this.lblDepartmentShow.Size = new System.Drawing.Size(81, 14);
            this.lblDepartmentShow.TabIndex = 92;
            this.lblDepartmentShow.Text = "Department";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(25, 160);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(85, 14);
            this.lblDepartment.TabIndex = 91;
            this.lblDepartment.Text = "Department:";
            // 
            // lblPositionShow
            // 
            this.lblPositionShow.AutoSize = true;
            this.lblPositionShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionShow.Location = new System.Drawing.Point(162, 127);
            this.lblPositionShow.Name = "lblPositionShow";
            this.lblPositionShow.Size = new System.Drawing.Size(57, 14);
            this.lblPositionShow.TabIndex = 90;
            this.lblPositionShow.Text = "Position";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(25, 127);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 14);
            this.lblPosition.TabIndex = 89;
            this.lblPosition.Text = "Position:";
            // 
            // lblNRCNoShow
            // 
            this.lblNRCNoShow.AutoSize = true;
            this.lblNRCNoShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNoShow.Location = new System.Drawing.Point(162, 97);
            this.lblNRCNoShow.Name = "lblNRCNoShow";
            this.lblNRCNoShow.Size = new System.Drawing.Size(52, 14);
            this.lblNRCNoShow.TabIndex = 88;
            this.lblNRCNoShow.Text = "NRC No";
            // 
            // lblEmployeeIDShow
            // 
            this.lblEmployeeIDShow.AutoSize = true;
            this.lblEmployeeIDShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIDShow.Location = new System.Drawing.Point(162, 66);
            this.lblEmployeeIDShow.Name = "lblEmployeeIDShow";
            this.lblEmployeeIDShow.Size = new System.Drawing.Size(83, 14);
            this.lblEmployeeIDShow.TabIndex = 87;
            this.lblEmployeeIDShow.Text = "Employee ID";
            // 
            // lblNRCNo
            // 
            this.lblNRCNo.AutoSize = true;
            this.lblNRCNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNo.Location = new System.Drawing.Point(25, 97);
            this.lblNRCNo.Name = "lblNRCNo";
            this.lblNRCNo.Size = new System.Drawing.Size(56, 14);
            this.lblNRCNo.TabIndex = 86;
            this.lblNRCNo.Text = "NRC No:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(25, 66);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(87, 14);
            this.lblEmployeeID.TabIndex = 85;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // cboEmployeeName
            // 
            this.cboEmployeeName.FormattingEnabled = true;
            this.cboEmployeeName.Location = new System.Drawing.Point(149, 33);
            this.cboEmployeeName.Name = "cboEmployeeName";
            this.cboEmployeeName.Size = new System.Drawing.Size(191, 22);
            this.cboEmployeeName.TabIndex = 84;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(25, 36);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(102, 14);
            this.lblEmployeeName.TabIndex = 83;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // gpbAssignPeriod
            // 
            this.gpbAssignPeriod.Controls.Add(this.chkLeaveDate);
            this.gpbAssignPeriod.Controls.Add(this.dtpLeaveDate);
            this.gpbAssignPeriod.Controls.Add(this.lblJoinDate);
            this.gpbAssignPeriod.Controls.Add(this.lblLeaveDate);
            this.gpbAssignPeriod.Controls.Add(this.dtpJoinDate);
            this.gpbAssignPeriod.Location = new System.Drawing.Point(12, 230);
            this.gpbAssignPeriod.Name = "gpbAssignPeriod";
            this.gpbAssignPeriod.Size = new System.Drawing.Size(724, 64);
            this.gpbAssignPeriod.TabIndex = 79;
            this.gpbAssignPeriod.TabStop = false;
            this.gpbAssignPeriod.Text = "Assign Period";
            // 
            // dtpLeaveDate
            // 
            this.dtpLeaveDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLeaveDate.CustomFormat = "dd MMM yyyy";
            this.dtpLeaveDate.Enabled = false;
            this.dtpLeaveDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLeaveDate.Location = new System.Drawing.Point(514, 23);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.Size = new System.Drawing.Size(191, 23);
            this.dtpLeaveDate.TabIndex = 61;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.Location = new System.Drawing.Point(20, 29);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(65, 14);
            this.lblJoinDate.TabIndex = 58;
            this.lblJoinDate.Text = "Join Date";
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveDate.Location = new System.Drawing.Point(390, 29);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(75, 14);
            this.lblLeaveDate.TabIndex = 59;
            this.lblLeaveDate.Text = "Leave Date";
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoinDate.CustomFormat = "dd MMM yyyy";
            this.dtpJoinDate.Enabled = false;
            this.dtpJoinDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoinDate.Location = new System.Drawing.Point(131, 23);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(191, 23);
            this.dtpJoinDate.TabIndex = 60;
            // 
            // chkLeaveDate
            // 
            this.chkLeaveDate.AutoSize = true;
            this.chkLeaveDate.Location = new System.Drawing.Point(369, 29);
            this.chkLeaveDate.Name = "chkLeaveDate";
            this.chkLeaveDate.Size = new System.Drawing.Size(15, 14);
            this.chkLeaveDate.TabIndex = 62;
            this.chkLeaveDate.UseVisualStyleBackColor = true;
            // 
            // pnlSWH_Employee
            // 
            this.pnlSWH_Employee.Controls.Add(this.dgvSWH_Employee);
            this.pnlSWH_Employee.Controls.Add(this.gpbSearch);
            this.pnlSWH_Employee.Location = new System.Drawing.Point(0, 0);
            this.pnlSWH_Employee.Name = "pnlSWH_Employee";
            this.pnlSWH_Employee.Size = new System.Drawing.Size(752, 371);
            this.pnlSWH_Employee.TabIndex = 57;
            // 
            // dgvSWH_Employee
            // 
            this.dgvSWH_Employee.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSWH_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSWH_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSWH_Employee.Location = new System.Drawing.Point(276, 11);
            this.dgvSWH_Employee.Name = "dgvSWH_Employee";
            this.dgvSWH_Employee.Size = new System.Drawing.Size(467, 357);
            this.dgvSWH_Employee.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.chkSLeaveDate);
            this.gpbSearch.Controls.Add(this.chkSJoinDate);
            this.gpbSearch.Controls.Add(this.chkSWarehouseName);
            this.gpbSearch.Controls.Add(this.cboSEmployeeName);
            this.gpbSearch.Controls.Add(this.chkSEmployeeName);
            this.gpbSearch.Controls.Add(this.cboSWarehouseName);
            this.gpbSearch.Controls.Add(this.dtpSLeaveDate);
            this.gpbSearch.Controls.Add(this.dtpSJoinDate);
            this.gpbSearch.Controls.Add(this.lblSTo);
            this.gpbSearch.Controls.Add(this.gpbSCont);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(12, 3);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(258, 368);
            this.gpbSearch.TabIndex = 11;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // dtpSLeaveDate
            // 
            this.dtpSLeaveDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSLeaveDate.CustomFormat = "dd MMM yyyy";
            this.dtpSLeaveDate.Enabled = false;
            this.dtpSLeaveDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSLeaveDate.Location = new System.Drawing.Point(16, 221);
            this.dtpSLeaveDate.Name = "dtpSLeaveDate";
            this.dtpSLeaveDate.Size = new System.Drawing.Size(227, 23);
            this.dtpSLeaveDate.TabIndex = 68;
            // 
            // dtpSJoinDate
            // 
            this.dtpSJoinDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSJoinDate.CustomFormat = "dd MMM yyyy";
            this.dtpSJoinDate.Enabled = false;
            this.dtpSJoinDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSJoinDate.Location = new System.Drawing.Point(16, 172);
            this.dtpSJoinDate.Name = "dtpSJoinDate";
            this.dtpSJoinDate.Size = new System.Drawing.Size(227, 23);
            this.dtpSJoinDate.TabIndex = 67;
            this.dtpSJoinDate.ValueChanged += new System.EventHandler(this.dtpSJoinDate_ValueChanged);
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(104, 204);
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
            this.gpbSCont.Location = new System.Drawing.Point(11, 250);
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
            // chkSWarehouseName
            // 
            this.chkSWarehouseName.AutoSize = true;
            this.chkSWarehouseName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSWarehouseName.Location = new System.Drawing.Point(16, 25);
            this.chkSWarehouseName.Name = "chkSWarehouseName";
            this.chkSWarehouseName.Size = new System.Drawing.Size(131, 18);
            this.chkSWarehouseName.TabIndex = 87;
            this.chkSWarehouseName.Text = "Warehouse Name";
            this.chkSWarehouseName.UseVisualStyleBackColor = true;
            // 
            // cboSEmployeeName
            // 
            this.cboSEmployeeName.FormattingEnabled = true;
            this.cboSEmployeeName.Location = new System.Drawing.Point(16, 103);
            this.cboSEmployeeName.Name = "cboSEmployeeName";
            this.cboSEmployeeName.Size = new System.Drawing.Size(227, 22);
            this.cboSEmployeeName.TabIndex = 86;
            // 
            // chkSEmployeeName
            // 
            this.chkSEmployeeName.AutoSize = true;
            this.chkSEmployeeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSEmployeeName.Location = new System.Drawing.Point(16, 81);
            this.chkSEmployeeName.Name = "chkSEmployeeName";
            this.chkSEmployeeName.Size = new System.Drawing.Size(121, 18);
            this.chkSEmployeeName.TabIndex = 85;
            this.chkSEmployeeName.Text = "Employee Name";
            this.chkSEmployeeName.UseVisualStyleBackColor = true;
            // 
            // cboSWarehouseName
            // 
            this.cboSWarehouseName.FormattingEnabled = true;
            this.cboSWarehouseName.Location = new System.Drawing.Point(16, 45);
            this.cboSWarehouseName.Name = "cboSWarehouseName";
            this.cboSWarehouseName.Size = new System.Drawing.Size(227, 22);
            this.cboSWarehouseName.TabIndex = 84;
            // 
            // chkSJoinDate
            // 
            this.chkSJoinDate.AutoSize = true;
            this.chkSJoinDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSJoinDate.Location = new System.Drawing.Point(16, 142);
            this.chkSJoinDate.Name = "chkSJoinDate";
            this.chkSJoinDate.Size = new System.Drawing.Size(84, 18);
            this.chkSJoinDate.TabIndex = 88;
            this.chkSJoinDate.Text = "Join Date";
            this.chkSJoinDate.UseVisualStyleBackColor = true;
            // 
            // chkSLeaveDate
            // 
            this.chkSLeaveDate.AutoSize = true;
            this.chkSLeaveDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSLeaveDate.Location = new System.Drawing.Point(153, 142);
            this.chkSLeaveDate.Name = "chkSLeaveDate";
            this.chkSLeaveDate.Size = new System.Drawing.Size(90, 18);
            this.chkSLeaveDate.TabIndex = 89;
            this.chkSLeaveDate.Text = "LeaveDate";
            this.chkSLeaveDate.UseVisualStyleBackColor = true;
            // 
            // frmWH_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 401);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlWH_Employee);
            this.MaximizeBox = false;
            this.Name = "frmWH_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareHouse Employee";
            this.pnlWH_Employee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbWarehouseInfo.ResumeLayout(false);
            this.gpbWarehouseInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gpbEmployeeInfo.ResumeLayout(false);
            this.gpbEmployeeInfo.PerformLayout();
            this.gpbAssignPeriod.ResumeLayout(false);
            this.gpbAssignPeriod.PerformLayout();
            this.pnlSWH_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSWH_Employee)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSCont.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWH_Employee;
        private System.Windows.Forms.GroupBox gpbWarehouseInfo;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboWarehouseName;
        private System.Windows.Forms.GroupBox gpbAssignPeriod;
        private System.Windows.Forms.DateTimePicker dtpLeaveDate;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.GroupBox gpbEmployeeInfo;
        private System.Windows.Forms.Label lblDepartmentShow;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPositionShow;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblNRCNoShow;
        private System.Windows.Forms.Label lblEmployeeIDShow;
        private System.Windows.Forms.Label lblNRCNo;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.ComboBox cboEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblAddressShow;
        private System.Windows.Forms.Label lblWarehouseIDShow;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblWarehouseID;
        private System.Windows.Forms.Panel pnlSWH_Employee;
        private System.Windows.Forms.DataGridView dgvSWH_Employee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.DateTimePicker dtpSLeaveDate;
        private System.Windows.Forms.DateTimePicker dtpSJoinDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.GroupBox gpbSCont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkLeaveDate;
        private System.Windows.Forms.CheckBox chkSLeaveDate;
        private System.Windows.Forms.CheckBox chkSJoinDate;
        private System.Windows.Forms.CheckBox chkSWarehouseName;
        private System.Windows.Forms.ComboBox cboSEmployeeName;
        private System.Windows.Forms.CheckBox chkSEmployeeName;
        private System.Windows.Forms.ComboBox cboSWarehouseName;
    }
}