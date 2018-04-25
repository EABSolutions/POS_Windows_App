namespace EAB_Business_Solution.Forms
{
    partial class frmPromotion
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
            this.pnlSalesPlan = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbProductInfo = new System.Windows.Forms.GroupBox();
            this.dgvPromotion = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinimumQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaximumQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotionPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbPromotionInfo = new System.Windows.Forms.GroupBox();
            this.cboSalesPlanID = new System.Windows.Forms.ComboBox();
            this.lblSalesPlanID = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chkNoEndDate = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblPromotionID = new System.Windows.Forms.Label();
            this.txtPromotionID = new System.Windows.Forms.TextBox();
            this.ssCompany = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSPromotion = new System.Windows.Forms.Panel();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.chkSInactivePromotion = new System.Windows.Forms.CheckBox();
            this.chkSActivePromotion = new System.Windows.Forms.CheckBox();
            this.ddpSToDate = new System.Windows.Forms.DateTimePicker();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.lblSTo = new System.Windows.Forms.Label();
            this.chkSPromotionID = new System.Windows.Forms.CheckBox();
            this.dtpSFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtSPromotionID = new System.Windows.Forms.TextBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.cboSProductName = new System.Windows.Forms.ComboBox();
            this.chkSProductName = new System.Windows.Forms.CheckBox();
            this.dgvSPromotion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlSalesPlan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotion)).BeginInit();
            this.gpbPromotionInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ssCompany.SuspendLayout();
            this.pnlSPromotion.SuspendLayout();
            this.gpbSearch.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPromotion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSalesPlan
            // 
            this.pnlSalesPlan.Controls.Add(this.groupBox1);
            this.pnlSalesPlan.Controls.Add(this.gpbProductInfo);
            this.pnlSalesPlan.Controls.Add(this.gpbPromotionInfo);
            this.pnlSalesPlan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSalesPlan.Location = new System.Drawing.Point(0, -1);
            this.pnlSalesPlan.Name = "pnlSalesPlan";
            this.pnlSalesPlan.Size = new System.Drawing.Size(906, 637);
            this.pnlSalesPlan.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(126, 552);
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
            // gpbProductInfo
            // 
            this.gpbProductInfo.Controls.Add(this.dgvPromotion);
            this.gpbProductInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductInfo.Location = new System.Drawing.Point(12, 210);
            this.gpbProductInfo.Name = "gpbProductInfo";
            this.gpbProductInfo.Size = new System.Drawing.Size(871, 336);
            this.gpbProductInfo.TabIndex = 1;
            this.gpbProductInfo.TabStop = false;
            this.gpbProductInfo.Text = "Product Information";
            // 
            // dgvPromotion
            // 
            this.dgvPromotion.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromotion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colUnit,
            this.colMinimumQuantity,
            this.colMaximumQuantity,
            this.colPromotionPercentage});
            this.dgvPromotion.Location = new System.Drawing.Point(16, 21);
            this.dgvPromotion.Name = "dgvPromotion";
            this.dgvPromotion.Size = new System.Drawing.Size(838, 298);
            this.dgvPromotion.TabIndex = 5;
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            this.colProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductID.Width = 84;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colProductName.Width = 101;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colMinimumQuantity
            // 
            this.colMinimumQuantity.HeaderText = "Minimum Quantity";
            this.colMinimumQuantity.Name = "colMinimumQuantity";
            // 
            // colMaximumQuantity
            // 
            this.colMaximumQuantity.HeaderText = "Maximum Quantity";
            this.colMaximumQuantity.Name = "colMaximumQuantity";
            // 
            // colPromotionPercentage
            // 
            this.colPromotionPercentage.HeaderText = "Promotion Percentage";
            this.colPromotionPercentage.Name = "colPromotionPercentage";
            // 
            // gpbPromotionInfo
            // 
            this.gpbPromotionInfo.Controls.Add(this.cboSalesPlanID);
            this.gpbPromotionInfo.Controls.Add(this.lblSalesPlanID);
            this.gpbPromotionInfo.Controls.Add(this.txtDescription);
            this.gpbPromotionInfo.Controls.Add(this.lblDescription);
            this.gpbPromotionInfo.Controls.Add(this.chkNoEndDate);
            this.gpbPromotionInfo.Controls.Add(this.dtpEndDate);
            this.gpbPromotionInfo.Controls.Add(this.lblEndDate);
            this.gpbPromotionInfo.Controls.Add(this.groupBox2);
            this.gpbPromotionInfo.Controls.Add(this.dtpStartDate);
            this.gpbPromotionInfo.Controls.Add(this.lblStartDate);
            this.gpbPromotionInfo.Controls.Add(this.lblPromotionID);
            this.gpbPromotionInfo.Controls.Add(this.txtPromotionID);
            this.gpbPromotionInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPromotionInfo.Location = new System.Drawing.Point(12, 10);
            this.gpbPromotionInfo.Name = "gpbPromotionInfo";
            this.gpbPromotionInfo.Size = new System.Drawing.Size(871, 185);
            this.gpbPromotionInfo.TabIndex = 0;
            this.gpbPromotionInfo.TabStop = false;
            this.gpbPromotionInfo.Text = "Promotion Infomation";
            // 
            // cboSalesPlanID
            // 
            this.cboSalesPlanID.FormattingEnabled = true;
            this.cboSalesPlanID.Location = new System.Drawing.Point(114, 70);
            this.cboSalesPlanID.Name = "cboSalesPlanID";
            this.cboSalesPlanID.Size = new System.Drawing.Size(125, 22);
            this.cboSalesPlanID.TabIndex = 74;
            // 
            // lblSalesPlanID
            // 
            this.lblSalesPlanID.AutoSize = true;
            this.lblSalesPlanID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPlanID.Location = new System.Drawing.Point(22, 73);
            this.lblSalesPlanID.Name = "lblSalesPlanID";
            this.lblSalesPlanID.Size = new System.Drawing.Size(86, 14);
            this.lblSalesPlanID.TabIndex = 73;
            this.lblSalesPlanID.Text = "Sales Plan ID";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(354, 70);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(500, 86);
            this.txtDescription.TabIndex = 71;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(276, 74);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 14);
            this.lblDescription.TabIndex = 70;
            this.lblDescription.Text = "Description";
            // 
            // chkNoEndDate
            // 
            this.chkNoEndDate.AutoSize = true;
            this.chkNoEndDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNoEndDate.Location = new System.Drawing.Point(752, 30);
            this.chkNoEndDate.Name = "chkNoEndDate";
            this.chkNoEndDate.Size = new System.Drawing.Size(102, 18);
            this.chkNoEndDate.TabIndex = 69;
            this.chkNoEndDate.Text = "No End Date";
            this.chkNoEndDate.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CustomFormat = "dd MMM yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(595, 26);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(125, 23);
            this.dtpEndDate.TabIndex = 67;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(517, 32);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(63, 14);
            this.lblEndDate.TabIndex = 68;
            this.lblEndDate.Text = "End Date";
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
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CustomFormat = "dd MMM yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(354, 27);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(125, 23);
            this.dtpStartDate.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(276, 31);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 14);
            this.lblStartDate.TabIndex = 28;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblPromotionID
            // 
            this.lblPromotionID.AutoSize = true;
            this.lblPromotionID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromotionID.Location = new System.Drawing.Point(22, 30);
            this.lblPromotionID.Name = "lblPromotionID";
            this.lblPromotionID.Size = new System.Drawing.Size(90, 14);
            this.lblPromotionID.TabIndex = 26;
            this.lblPromotionID.Text = "Promotion ID";
            // 
            // txtPromotionID
            // 
            this.txtPromotionID.Enabled = false;
            this.txtPromotionID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromotionID.Location = new System.Drawing.Point(114, 27);
            this.txtPromotionID.Name = "txtPromotionID";
            this.txtPromotionID.Size = new System.Drawing.Size(125, 23);
            this.txtPromotionID.TabIndex = 1;
            // 
            // ssCompany
            // 
            this.ssCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.tsslUser,
            this.tsslCompID,
            this.tsslEID});
            this.ssCompany.Location = new System.Drawing.Point(0, 639);
            this.ssCompany.Name = "ssCompany";
            this.ssCompany.Size = new System.Drawing.Size(906, 23);
            this.ssCompany.TabIndex = 58;
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
            // pnlSPromotion
            // 
            this.pnlSPromotion.Controls.Add(this.dgvSPromotion);
            this.pnlSPromotion.Controls.Add(this.gpbSearch);
            this.pnlSPromotion.Location = new System.Drawing.Point(0, -1);
            this.pnlSPromotion.Name = "pnlSPromotion";
            this.pnlSPromotion.Size = new System.Drawing.Size(905, 637);
            this.pnlSPromotion.TabIndex = 76;
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.chkSInactivePromotion);
            this.gpbSearch.Controls.Add(this.chkSActivePromotion);
            this.gpbSearch.Controls.Add(this.ddpSToDate);
            this.gpbSearch.Controls.Add(this.gpbSControl);
            this.gpbSearch.Controls.Add(this.lblSTo);
            this.gpbSearch.Controls.Add(this.chkSPromotionID);
            this.gpbSearch.Controls.Add(this.dtpSFromDate);
            this.gpbSearch.Controls.Add(this.txtSPromotionID);
            this.gpbSearch.Controls.Add(this.chkDate);
            this.gpbSearch.Controls.Add(this.cboSProductName);
            this.gpbSearch.Controls.Add(this.chkSProductName);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(18, 83);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 482);
            this.gpbSearch.TabIndex = 3;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // chkSInactivePromotion
            // 
            this.chkSInactivePromotion.AutoSize = true;
            this.chkSInactivePromotion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSInactivePromotion.Location = new System.Drawing.Point(13, 322);
            this.chkSInactivePromotion.Name = "chkSInactivePromotion";
            this.chkSInactivePromotion.Size = new System.Drawing.Size(144, 18);
            this.chkSInactivePromotion.TabIndex = 65;
            this.chkSInactivePromotion.Text = "Inactive Promotion";
            this.chkSInactivePromotion.UseVisualStyleBackColor = true;
            // 
            // chkSActivePromotion
            // 
            this.chkSActivePromotion.AutoSize = true;
            this.chkSActivePromotion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSActivePromotion.Location = new System.Drawing.Point(13, 283);
            this.chkSActivePromotion.Name = "chkSActivePromotion";
            this.chkSActivePromotion.Size = new System.Drawing.Size(133, 18);
            this.chkSActivePromotion.TabIndex = 64;
            this.chkSActivePromotion.Text = "Active Promotion";
            this.chkSActivePromotion.UseVisualStyleBackColor = true;
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
            // chkSPromotionID
            // 
            this.chkSPromotionID.AutoSize = true;
            this.chkSPromotionID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSPromotionID.Location = new System.Drawing.Point(13, 35);
            this.chkSPromotionID.Name = "chkSPromotionID";
            this.chkSPromotionID.Size = new System.Drawing.Size(109, 18);
            this.chkSPromotionID.TabIndex = 48;
            this.chkSPromotionID.Text = "Promotion ID";
            this.chkSPromotionID.UseVisualStyleBackColor = true;
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
            // txtSPromotionID
            // 
            this.txtSPromotionID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPromotionID.Location = new System.Drawing.Point(13, 57);
            this.txtSPromotionID.Name = "txtSPromotionID";
            this.txtSPromotionID.Size = new System.Drawing.Size(232, 23);
            this.txtSPromotionID.TabIndex = 2;
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
            // dgvSPromotion
            // 
            this.dgvSPromotion.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPromotion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSPromotion.Location = new System.Drawing.Point(297, 13);
            this.dgvSPromotion.Name = "dgvSPromotion";
            this.dgvSPromotion.Size = new System.Drawing.Size(597, 613);
            this.dgvSPromotion.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // frmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 662);
            this.Controls.Add(this.pnlSPromotion);
            this.Controls.Add(this.ssCompany);
            this.Controls.Add(this.pnlSalesPlan);
            this.MaximizeBox = false;
            this.Name = "frmPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotion";
            this.pnlSalesPlan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbProductInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotion)).EndInit();
            this.gpbPromotionInfo.ResumeLayout(false);
            this.gpbPromotionInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ssCompany.ResumeLayout(false);
            this.ssCompany.PerformLayout();
            this.pnlSPromotion.ResumeLayout(false);
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPromotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalesPlan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbProductInfo;
        private System.Windows.Forms.DataGridView dgvPromotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinimumQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaximumQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotionPercentage;
        private System.Windows.Forms.GroupBox gpbPromotionInfo;
        private System.Windows.Forms.ComboBox cboSalesPlanID;
        private System.Windows.Forms.Label lblSalesPlanID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chkNoEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
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
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblPromotionID;
        private System.Windows.Forms.TextBox txtPromotionID;
        private System.Windows.Forms.StatusStrip ssCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.Panel pnlSPromotion;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.CheckBox chkSInactivePromotion;
        private System.Windows.Forms.CheckBox chkSActivePromotion;
        private System.Windows.Forms.DateTimePicker ddpSToDate;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.CheckBox chkSPromotionID;
        private System.Windows.Forms.DateTimePicker dtpSFromDate;
        private System.Windows.Forms.TextBox txtSPromotionID;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.ComboBox cboSProductName;
        private System.Windows.Forms.CheckBox chkSProductName;
        private System.Windows.Forms.DataGridView dgvSPromotion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}