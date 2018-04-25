namespace EAB_Business_Solution.Forms
{
    partial class frmPOS
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gpbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCashAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCashAmount = new System.Windows.Forms.Label();
            this.lblCGrandTotal = new System.Windows.Forms.Label();
            this.lblCServiceCharges = new System.Windows.Forms.Label();
            this.lblCTax = new System.Windows.Forms.Label();
            this.lblCMemberPromotion = new System.Windows.Forms.Label();
            this.lblCMemberPomotionPercentage = new System.Windows.Forms.Label();
            this.lblCSubTotal = new System.Windows.Forms.Label();
            this.txtMemberPromotion = new System.Windows.Forms.TextBox();
            this.lblMemberPromotion = new System.Windows.Forms.Label();
            this.txtMemberPromotionPercentage = new System.Windows.Forms.TextBox();
            this.lblServiceCharges = new System.Windows.Forms.Label();
            this.txtServiceCharges = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.gpbSalesInfo = new System.Windows.Forms.GroupBox();
            this.dgvSalesInfo = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotionPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.chkCustomerName = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboProductLineName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            this.cboTableNo = new System.Windows.Forms.ComboBox();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
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
            this.lblMembershipShow = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblCustomerTypeShow = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblNRCShow = new System.Windows.Forms.Label();
            this.lblNRC = new System.Windows.Forms.Label();
            this.dtpSalesDate = new System.Windows.Forms.DateTimePicker();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSalesID = new System.Windows.Forms.Label();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbcPOS = new System.Windows.Forms.TabControl();
            this.tbpPOS = new System.Windows.Forms.TabPage();
            this.clsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpbPaymentInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbSalesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInfo)).BeginInit();
            this.gpbBasicInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbcPOS.SuspendLayout();
            this.tbpPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPaymentInfo
            // 
            this.gpbPaymentInfo.Controls.Add(this.txtAmount);
            this.gpbPaymentInfo.Controls.Add(this.txtCashAmount);
            this.gpbPaymentInfo.Controls.Add(this.label10);
            this.gpbPaymentInfo.Controls.Add(this.label9);
            this.gpbPaymentInfo.Controls.Add(this.txtChange);
            this.gpbPaymentInfo.Controls.Add(this.lblChange);
            this.gpbPaymentInfo.Controls.Add(this.lblCashAmount);
            this.gpbPaymentInfo.Controls.Add(this.lblCGrandTotal);
            this.gpbPaymentInfo.Controls.Add(this.lblCServiceCharges);
            this.gpbPaymentInfo.Controls.Add(this.lblCTax);
            this.gpbPaymentInfo.Controls.Add(this.lblCMemberPromotion);
            this.gpbPaymentInfo.Controls.Add(this.lblCMemberPomotionPercentage);
            this.gpbPaymentInfo.Controls.Add(this.lblCSubTotal);
            this.gpbPaymentInfo.Controls.Add(this.txtMemberPromotion);
            this.gpbPaymentInfo.Controls.Add(this.lblMemberPromotion);
            this.gpbPaymentInfo.Controls.Add(this.txtMemberPromotionPercentage);
            this.gpbPaymentInfo.Controls.Add(this.lblServiceCharges);
            this.gpbPaymentInfo.Controls.Add(this.txtServiceCharges);
            this.gpbPaymentInfo.Controls.Add(this.lblTax);
            this.gpbPaymentInfo.Controls.Add(this.txtTax);
            this.gpbPaymentInfo.Controls.Add(this.lblSubTotal);
            this.gpbPaymentInfo.Controls.Add(this.lblGrandTotal);
            this.gpbPaymentInfo.Controls.Add(this.txtTotal);
            this.gpbPaymentInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPaymentInfo.Location = new System.Drawing.Point(998, 6);
            this.gpbPaymentInfo.Name = "gpbPaymentInfo";
            this.gpbPaymentInfo.Size = new System.Drawing.Size(285, 385);
            this.gpbPaymentInfo.TabIndex = 6;
            this.gpbPaymentInfo.TabStop = false;
            this.gpbPaymentInfo.Text = "Payment Information";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(110, 24);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(122, 33);
            this.txtAmount.TabIndex = 82;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCashAmount
            // 
            this.txtCashAmount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAmount.Location = new System.Drawing.Point(109, 274);
            this.txtCashAmount.Name = "txtCashAmount";
            this.txtCashAmount.Size = new System.Drawing.Size(125, 40);
            this.txtCashAmount.TabIndex = 81;
            this.txtCashAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCashAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashAmount_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "MMK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "MMK";
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(109, 330);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(125, 33);
            this.txtChange.TabIndex = 78;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(8, 338);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(48, 13);
            this.lblChange.TabIndex = 77;
            this.lblChange.Text = "Change:";
            // 
            // lblCashAmount
            // 
            this.lblCashAmount.AutoSize = true;
            this.lblCashAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashAmount.Location = new System.Drawing.Point(8, 288);
            this.lblCashAmount.Name = "lblCashAmount";
            this.lblCashAmount.Size = new System.Drawing.Size(75, 13);
            this.lblCashAmount.TabIndex = 75;
            this.lblCashAmount.Text = "Cash Amount:";
            // 
            // lblCGrandTotal
            // 
            this.lblCGrandTotal.AutoSize = true;
            this.lblCGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGrandTotal.Location = new System.Drawing.Point(240, 232);
            this.lblCGrandTotal.Name = "lblCGrandTotal";
            this.lblCGrandTotal.Size = new System.Drawing.Size(29, 13);
            this.lblCGrandTotal.TabIndex = 47;
            this.lblCGrandTotal.Text = "MMK";
            // 
            // lblCServiceCharges
            // 
            this.lblCServiceCharges.AutoSize = true;
            this.lblCServiceCharges.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCServiceCharges.Location = new System.Drawing.Point(240, 186);
            this.lblCServiceCharges.Name = "lblCServiceCharges";
            this.lblCServiceCharges.Size = new System.Drawing.Size(29, 13);
            this.lblCServiceCharges.TabIndex = 46;
            this.lblCServiceCharges.Text = "MMK";
            // 
            // lblCTax
            // 
            this.lblCTax.AutoSize = true;
            this.lblCTax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTax.Location = new System.Drawing.Point(240, 151);
            this.lblCTax.Name = "lblCTax";
            this.lblCTax.Size = new System.Drawing.Size(29, 13);
            this.lblCTax.TabIndex = 45;
            this.lblCTax.Text = "MMK";
            // 
            // lblCMemberPromotion
            // 
            this.lblCMemberPromotion.AutoSize = true;
            this.lblCMemberPromotion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMemberPromotion.Location = new System.Drawing.Point(240, 111);
            this.lblCMemberPromotion.Name = "lblCMemberPromotion";
            this.lblCMemberPromotion.Size = new System.Drawing.Size(29, 13);
            this.lblCMemberPromotion.TabIndex = 44;
            this.lblCMemberPromotion.Text = "MMK";
            // 
            // lblCMemberPomotionPercentage
            // 
            this.lblCMemberPomotionPercentage.AutoSize = true;
            this.lblCMemberPomotionPercentage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMemberPomotionPercentage.Location = new System.Drawing.Point(240, 79);
            this.lblCMemberPomotionPercentage.Name = "lblCMemberPomotionPercentage";
            this.lblCMemberPomotionPercentage.Size = new System.Drawing.Size(18, 13);
            this.lblCMemberPomotionPercentage.TabIndex = 43;
            this.lblCMemberPomotionPercentage.Text = "%";
            // 
            // lblCSubTotal
            // 
            this.lblCSubTotal.AutoSize = true;
            this.lblCSubTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSubTotal.Location = new System.Drawing.Point(238, 38);
            this.lblCSubTotal.Name = "lblCSubTotal";
            this.lblCSubTotal.Size = new System.Drawing.Size(29, 13);
            this.lblCSubTotal.TabIndex = 42;
            this.lblCSubTotal.Text = "MMK";
            // 
            // txtMemberPromotion
            // 
            this.txtMemberPromotion.Enabled = false;
            this.txtMemberPromotion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPromotion.Location = new System.Drawing.Point(109, 106);
            this.txtMemberPromotion.Name = "txtMemberPromotion";
            this.txtMemberPromotion.Size = new System.Drawing.Size(125, 23);
            this.txtMemberPromotion.TabIndex = 41;
            this.txtMemberPromotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMemberPromotion
            // 
            this.lblMemberPromotion.AutoSize = true;
            this.lblMemberPromotion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberPromotion.Location = new System.Drawing.Point(9, 79);
            this.lblMemberPromotion.Name = "lblMemberPromotion";
            this.lblMemberPromotion.Size = new System.Drawing.Size(96, 13);
            this.lblMemberPromotion.TabIndex = 40;
            this.lblMemberPromotion.Text = "Member Promotion";
            // 
            // txtMemberPromotionPercentage
            // 
            this.txtMemberPromotionPercentage.Enabled = false;
            this.txtMemberPromotionPercentage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPromotionPercentage.Location = new System.Drawing.Point(109, 74);
            this.txtMemberPromotionPercentage.Name = "txtMemberPromotionPercentage";
            this.txtMemberPromotionPercentage.Size = new System.Drawing.Size(125, 23);
            this.txtMemberPromotionPercentage.TabIndex = 39;
            this.txtMemberPromotionPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceCharges
            // 
            this.lblServiceCharges.AutoSize = true;
            this.lblServiceCharges.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharges.Location = new System.Drawing.Point(8, 186);
            this.lblServiceCharges.Name = "lblServiceCharges";
            this.lblServiceCharges.Size = new System.Drawing.Size(85, 13);
            this.lblServiceCharges.TabIndex = 38;
            this.lblServiceCharges.Text = "Service Charges";
            // 
            // txtServiceCharges
            // 
            this.txtServiceCharges.Enabled = false;
            this.txtServiceCharges.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCharges.Location = new System.Drawing.Point(109, 181);
            this.txtServiceCharges.Name = "txtServiceCharges";
            this.txtServiceCharges.Size = new System.Drawing.Size(125, 23);
            this.txtServiceCharges.TabIndex = 37;
            this.txtServiceCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(12, 151);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 36;
            this.lblTax.Text = "Tax";
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(109, 146);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(125, 23);
            this.txtTax.TabIndex = 11;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(9, 38);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(52, 13);
            this.lblSubTotal.TabIndex = 28;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(6, 232);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(63, 13);
            this.lblGrandTotal.TabIndex = 26;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(109, 219);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 40);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Location = new System.Drawing.Point(987, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(85, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 31);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(159, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(233, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(11, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 31);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCash
            // 
            this.btnCash.Enabled = false;
            this.btnCash.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(6, 18);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(68, 31);
            this.btnCash.TabIndex = 6;
            this.btnCash.Text = "Ca&sh";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // gpbSalesInfo
            // 
            this.gpbSalesInfo.Controls.Add(this.dgvSalesInfo);
            this.gpbSalesInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSalesInfo.Location = new System.Drawing.Point(6, 173);
            this.gpbSalesInfo.Name = "gpbSalesInfo";
            this.gpbSalesInfo.Size = new System.Drawing.Size(975, 336);
            this.gpbSalesInfo.TabIndex = 1;
            this.gpbSalesInfo.TabStop = false;
            this.gpbSalesInfo.Text = "Sales Infomation";
            // 
            // dgvSalesInfo
            // 
            this.dgvSalesInfo.AllowUserToAddRows = false;
            this.dgvSalesInfo.AllowUserToDeleteRows = false;
            this.dgvSalesInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSalesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colUnit,
            this.colQuantity,
            this.colPrice,
            this.colCurrency,
            this.colPromotionPercentage,
            this.colPromotion,
            this.colAmount});
            this.dgvSalesInfo.Location = new System.Drawing.Point(6, 20);
            this.dgvSalesInfo.Name = "dgvSalesInfo";
            this.dgvSalesInfo.ReadOnly = true;
            this.dgvSalesInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesInfo.Size = new System.Drawing.Size(953, 298);
            this.dgvSalesInfo.TabIndex = 5;
            this.dgvSalesInfo.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSalesInfo_CellMouseUp);
            this.dgvSalesInfo.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSalesInfo_CurrentCellDirtyStateChanged);
            this.dgvSalesInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSalesInfo_DataError);
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductID.DefaultCellStyle = dataGridViewCellStyle28;
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            this.colProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductID.Width = 77;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle29;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductName.Width = 91;
            // 
            // colUnit
            // 
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle30;
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colQuantity
            // 
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle31;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle32;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colCurrency
            // 
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colCurrency.DefaultCellStyle = dataGridViewCellStyle33;
            this.colCurrency.HeaderText = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            // 
            // colPromotionPercentage
            // 
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colPromotionPercentage.DefaultCellStyle = dataGridViewCellStyle34;
            this.colPromotionPercentage.HeaderText = "Promotion Percentage";
            this.colPromotionPercentage.Name = "colPromotionPercentage";
            this.colPromotionPercentage.ReadOnly = true;
            // 
            // colPromotion
            // 
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colPromotion.DefaultCellStyle = dataGridViewCellStyle35;
            this.colPromotion.HeaderText = "Promotion";
            this.colPromotion.Name = "colPromotion";
            this.colPromotion.ReadOnly = true;
            // 
            // colAmount
            // 
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle36;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.chkCustomerName);
            this.gpbBasicInfo.Controls.Add(this.txtQuantity);
            this.gpbBasicInfo.Controls.Add(this.label8);
            this.gpbBasicInfo.Controls.Add(this.cboProductName);
            this.gpbBasicInfo.Controls.Add(this.label7);
            this.gpbBasicInfo.Controls.Add(this.cboProductLineName);
            this.gpbBasicInfo.Controls.Add(this.label6);
            this.gpbBasicInfo.Controls.Add(this.btnTable);
            this.gpbBasicInfo.Controls.Add(this.cboTableNo);
            this.gpbBasicInfo.Controls.Add(this.lblTableNo);
            this.gpbBasicInfo.Controls.Add(this.txtInvoiceNo);
            this.gpbBasicInfo.Controls.Add(this.lblInvoiceNo);
            this.gpbBasicInfo.Controls.Add(this.groupBox2);
            this.gpbBasicInfo.Controls.Add(this.lblMembershipShow);
            this.gpbBasicInfo.Controls.Add(this.lblMembership);
            this.gpbBasicInfo.Controls.Add(this.lblCustomerTypeShow);
            this.gpbBasicInfo.Controls.Add(this.lblCustomerType);
            this.gpbBasicInfo.Controls.Add(this.lblNRCShow);
            this.gpbBasicInfo.Controls.Add(this.lblNRC);
            this.gpbBasicInfo.Controls.Add(this.dtpSalesDate);
            this.gpbBasicInfo.Controls.Add(this.btnCustomer);
            this.gpbBasicInfo.Controls.Add(this.cboCustomerName);
            this.gpbBasicInfo.Controls.Add(this.lblDate);
            this.gpbBasicInfo.Controls.Add(this.lblSalesID);
            this.gpbBasicInfo.Controls.Add(this.txtSalesID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(6, 6);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(975, 161);
            this.gpbBasicInfo.TabIndex = 0;
            this.gpbBasicInfo.TabStop = false;
            this.gpbBasicInfo.Text = "Basic Infomation";
            // 
            // chkCustomerName
            // 
            this.chkCustomerName.AutoSize = true;
            this.chkCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomerName.Location = new System.Drawing.Point(624, 31);
            this.chkCustomerName.Name = "chkCustomerName";
            this.chkCustomerName.Size = new System.Drawing.Size(102, 17);
            this.chkCustomerName.TabIndex = 76;
            this.chkCustomerName.Text = "Customer Name";
            this.chkCustomerName.UseVisualStyleBackColor = true;
            this.chkCustomerName.CheckedChanged += new System.EventHandler(this.chkCustomerName_CheckedChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(135, 120);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(160, 21);
            this.txtQuantity.TabIndex = 75;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Quantity";
            // 
            // cboProductName
            // 
            this.cboProductName.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(135, 84);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(160, 24);
            this.cboProductName.TabIndex = 73;
            this.cboProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboProductName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Product Name";
            // 
            // cboProductLineName
            // 
            this.cboProductLineName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProductLineName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductLineName.FormattingEnabled = true;
            this.cboProductLineName.Location = new System.Drawing.Point(135, 55);
            this.cboProductLineName.Name = "cboProductLineName";
            this.cboProductLineName.Size = new System.Drawing.Size(160, 21);
            this.cboProductLineName.TabIndex = 71;
            this.cboProductLineName.SelectedIndexChanged += new System.EventHandler(this.cboProductLineName_SelectedIndexChanged);
            this.cboProductLineName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboProductLineName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Product Line Name";
            // 
            // btnTable
            // 
            this.btnTable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Location = new System.Drawing.Point(301, 25);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(29, 22);
            this.btnTable.TabIndex = 68;
            this.btnTable.Text = "...";
            this.btnTable.UseVisualStyleBackColor = true;
            // 
            // cboTableNo
            // 
            this.cboTableNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTableNo.FormattingEnabled = true;
            this.cboTableNo.Location = new System.Drawing.Point(135, 25);
            this.cboTableNo.Name = "cboTableNo";
            this.cboTableNo.Size = new System.Drawing.Size(160, 21);
            this.cboTableNo.TabIndex = 67;
            this.cboTableNo.SelectedIndexChanged += new System.EventHandler(this.cboTableNo_SelectedIndexChanged);
            this.cboTableNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTableNo_KeyPress);
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.Location = new System.Drawing.Point(60, 30);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(49, 13);
            this.lblTableNo.TabIndex = 69;
            this.lblTableNo.Text = "Table No";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(433, 84);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(160, 21);
            this.txtInvoiceNo.TabIndex = 66;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(356, 87);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(58, 13);
            this.lblInvoiceNo.TabIndex = 65;
            this.lblInvoiceNo.Text = "Invoice No";
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
            // lblMembershipShow
            // 
            this.lblMembershipShow.AutoSize = true;
            this.lblMembershipShow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipShow.Location = new System.Drawing.Point(747, 128);
            this.lblMembershipShow.Name = "lblMembershipShow";
            this.lblMembershipShow.Size = new System.Drawing.Size(68, 13);
            this.lblMembershipShow.TabIndex = 64;
            this.lblMembershipShow.Text = "Member Ship";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembership.Location = new System.Drawing.Point(642, 128);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(68, 13);
            this.lblMembership.TabIndex = 63;
            this.lblMembership.Text = "Membership:";
            // 
            // lblCustomerTypeShow
            // 
            this.lblCustomerTypeShow.AutoSize = true;
            this.lblCustomerTypeShow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTypeShow.Location = new System.Drawing.Point(747, 96);
            this.lblCustomerTypeShow.Name = "lblCustomerTypeShow";
            this.lblCustomerTypeShow.Size = new System.Drawing.Size(80, 13);
            this.lblCustomerTypeShow.TabIndex = 62;
            this.lblCustomerTypeShow.Text = "Customer Type";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(642, 96);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(84, 13);
            this.lblCustomerType.TabIndex = 61;
            this.lblCustomerType.Text = "Customer Type:";
            // 
            // lblNRCShow
            // 
            this.lblNRCShow.AutoSize = true;
            this.lblNRCShow.Font = new System.Drawing.Font("Myanmar3", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCShow.Location = new System.Drawing.Point(750, 66);
            this.lblNRCShow.Name = "lblNRCShow";
            this.lblNRCShow.Size = new System.Drawing.Size(36, 17);
            this.lblNRCShow.TabIndex = 60;
            this.lblNRCShow.Text = "NRC";
            // 
            // lblNRC
            // 
            this.lblNRC.AutoSize = true;
            this.lblNRC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRC.Location = new System.Drawing.Point(644, 66);
            this.lblNRC.Name = "lblNRC";
            this.lblNRC.Size = new System.Drawing.Size(32, 13);
            this.lblNRC.TabIndex = 59;
            this.lblNRC.Text = "NRC:";
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalesDate.CustomFormat = "dd MMM yyyy";
            this.dtpSalesDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalesDate.Location = new System.Drawing.Point(433, 24);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Size = new System.Drawing.Size(160, 21);
            this.dtpSalesDate.TabIndex = 2;
            this.dtpSalesDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpSalesDate_KeyPress);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(930, 26);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(29, 25);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "...";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(752, 27);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(172, 24);
            this.cboCustomerName.TabIndex = 3;
            this.cboCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboCustomerName_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(384, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // lblSalesID
            // 
            this.lblSalesID.AutoSize = true;
            this.lblSalesID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesID.Location = new System.Drawing.Point(368, 58);
            this.lblSalesID.Name = "lblSalesID";
            this.lblSalesID.Size = new System.Drawing.Size(46, 13);
            this.lblSalesID.TabIndex = 26;
            this.lblSalesID.Text = "Sales ID";
            // 
            // txtSalesID
            // 
            this.txtSalesID.Enabled = false;
            this.txtSalesID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesID.Location = new System.Drawing.Point(433, 55);
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.Size = new System.Drawing.Size(160, 21);
            this.txtSalesID.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.clsReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EAB_Business_Solution.Report.POSReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(185, 295);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(330, 178);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCash);
            this.groupBox3.Location = new System.Drawing.Point(1108, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(80, 59);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // tbcPOS
            // 
            this.tbcPOS.Controls.Add(this.tbpPOS);
            this.tbcPOS.Location = new System.Drawing.Point(12, 12);
            this.tbcPOS.Name = "tbcPOS";
            this.tbcPOS.SelectedIndex = 0;
            this.tbcPOS.Size = new System.Drawing.Size(1326, 558);
            this.tbcPOS.TabIndex = 7;
            // 
            // tbpPOS
            // 
            this.tbpPOS.Controls.Add(this.groupBox3);
            this.tbpPOS.Controls.Add(this.gpbPaymentInfo);
            this.tbpPOS.Controls.Add(this.gpbBasicInfo);
            this.tbpPOS.Controls.Add(this.groupBox1);
            this.tbpPOS.Controls.Add(this.gpbSalesInfo);
            this.tbpPOS.Location = new System.Drawing.Point(4, 22);
            this.tbpPOS.Name = "tbpPOS";
            this.tbpPOS.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPOS.Size = new System.Drawing.Size(1318, 532);
            this.tbpPOS.TabIndex = 0;
            this.tbpPOS.Text = "POS";
            this.tbpPOS.UseVisualStyleBackColor = true;
            // 
            // clsReportBindingSource
            // 
            this.clsReportBindingSource.DataSource = typeof(EAB_Business_Solution.Class.clsReport);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 582);
            this.Controls.Add(this.tbcPOS);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.gpbPaymentInfo.ResumeLayout(false);
            this.gpbPaymentInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpbSalesInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInfo)).EndInit();
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tbcPOS.ResumeLayout(false);
            this.tbpPOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clsReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gpbSalesInfo;
        private System.Windows.Forms.DataGridView dgvSalesInfo;
        private System.Windows.Forms.GroupBox gpbPaymentInfo;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSalesID;
        private System.Windows.Forms.TextBox txtSalesID;
        private System.Windows.Forms.DateTimePicker dtpSalesDate;
        private System.Windows.Forms.Label lblNRCShow;
        private System.Windows.Forms.Label lblNRC;
        private System.Windows.Forms.Label lblCustomerTypeShow;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblMembershipShow;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.TextBox txtMemberPromotion;
        private System.Windows.Forms.Label lblMemberPromotion;
        private System.Windows.Forms.TextBox txtMemberPromotionPercentage;
        private System.Windows.Forms.Label lblServiceCharges;
        private System.Windows.Forms.TextBox txtServiceCharges;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtTotal;
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
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblCGrandTotal;
        private System.Windows.Forms.Label lblCServiceCharges;
        private System.Windows.Forms.Label lblCTax;
        private System.Windows.Forms.Label lblCMemberPromotion;
        private System.Windows.Forms.Label lblCMemberPomotionPercentage;
        private System.Windows.Forms.Label lblCSubTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.ComboBox cboTableNo;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboProductLineName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblCashAmount;
        private System.Windows.Forms.TextBox txtCashAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.BindingSource clsReportBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotionPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.TabControl tbcPOS;
        private System.Windows.Forms.TabPage tbpPOS;
        private System.Windows.Forms.CheckBox chkCustomerName;
    }
}