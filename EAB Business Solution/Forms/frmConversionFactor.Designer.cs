namespace EAB_Business_Solution.Forms
{
    partial class frmConversionFactor
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
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssCompany = new System.Windows.Forms.StatusStrip();
            this.pnlConversionFactor = new System.Windows.Forms.Panel();
            this.gpbConversionFactorSetup = new System.Windows.Forms.GroupBox();
            this.txt1stUOMQuantity = new System.Windows.Forms.TextBox();
            this.lbl1stUOMQuantity = new System.Windows.Forms.Label();
            this.lbl1stUOMName = new System.Windows.Forms.Label();
            this.txtConversionFactorID = new System.Windows.Forms.TextBox();
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
            this.lblConversionFactorID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbo1stUOM = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl2ndUOMQuantity = new System.Windows.Forms.Label();
            this.lbl2ndUOMName = new System.Windows.Forms.Label();
            this.pnlSConversionFactor = new System.Windows.Forms.Panel();
            this.dgvSConversionFactor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSConversionFactorID = new System.Windows.Forms.CheckBox();
            this.txtSConversionFactorID = new System.Windows.Forms.TextBox();
            this.cboSUOM = new System.Windows.Forms.ComboBox();
            this.chkSUOM = new System.Windows.Forms.CheckBox();
            this.ssCompany.SuspendLayout();
            this.pnlConversionFactor.SuspendLayout();
            this.gpbConversionFactorSetup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSConversionFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSConversionFactor)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            this.SuspendLayout();
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
            this.ssCompany.TabIndex = 79;
            this.ssCompany.Text = "statusStrip1";
            // 
            // pnlConversionFactor
            // 
            this.pnlConversionFactor.Controls.Add(this.pnlSConversionFactor);
            this.pnlConversionFactor.Controls.Add(this.gpbConversionFactorSetup);
            this.pnlConversionFactor.Controls.Add(this.groupBox1);
            this.pnlConversionFactor.Location = new System.Drawing.Point(0, 0);
            this.pnlConversionFactor.Name = "pnlConversionFactor";
            this.pnlConversionFactor.Size = new System.Drawing.Size(770, 486);
            this.pnlConversionFactor.TabIndex = 80;
            // 
            // gpbConversionFactorSetup
            // 
            this.gpbConversionFactorSetup.Controls.Add(this.comboBox1);
            this.gpbConversionFactorSetup.Controls.Add(this.textBox1);
            this.gpbConversionFactorSetup.Controls.Add(this.lbl2ndUOMQuantity);
            this.gpbConversionFactorSetup.Controls.Add(this.lbl2ndUOMName);
            this.gpbConversionFactorSetup.Controls.Add(this.cbo1stUOM);
            this.gpbConversionFactorSetup.Controls.Add(this.txt1stUOMQuantity);
            this.gpbConversionFactorSetup.Controls.Add(this.lbl1stUOMQuantity);
            this.gpbConversionFactorSetup.Controls.Add(this.lbl1stUOMName);
            this.gpbConversionFactorSetup.Controls.Add(this.txtConversionFactorID);
            this.gpbConversionFactorSetup.Controls.Add(this.groupBox4);
            this.gpbConversionFactorSetup.Controls.Add(this.lblConversionFactorID);
            this.gpbConversionFactorSetup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConversionFactorSetup.Location = new System.Drawing.Point(202, 66);
            this.gpbConversionFactorSetup.Name = "gpbConversionFactorSetup";
            this.gpbConversionFactorSetup.Size = new System.Drawing.Size(375, 283);
            this.gpbConversionFactorSetup.TabIndex = 83;
            this.gpbConversionFactorSetup.TabStop = false;
            this.gpbConversionFactorSetup.Text = "Conversion Factor Setup";
            // 
            // txt1stUOMQuantity
            // 
            this.txt1stUOMQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1stUOMQuantity.Location = new System.Drawing.Point(168, 106);
            this.txt1stUOMQuantity.Name = "txt1stUOMQuantity";
            this.txt1stUOMQuantity.Size = new System.Drawing.Size(90, 23);
            this.txt1stUOMQuantity.TabIndex = 86;
            // 
            // lbl1stUOMQuantity
            // 
            this.lbl1stUOMQuantity.AutoSize = true;
            this.lbl1stUOMQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stUOMQuantity.Location = new System.Drawing.Point(22, 110);
            this.lbl1stUOMQuantity.Name = "lbl1stUOMQuantity";
            this.lbl1stUOMQuantity.Size = new System.Drawing.Size(117, 14);
            this.lbl1stUOMQuantity.TabIndex = 80;
            this.lbl1stUOMQuantity.Text = "1st UOM Quantity";
            // 
            // lbl1stUOMName
            // 
            this.lbl1stUOMName.AutoSize = true;
            this.lbl1stUOMName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stUOMName.Location = new System.Drawing.Point(22, 71);
            this.lbl1stUOMName.Name = "lbl1stUOMName";
            this.lbl1stUOMName.Size = new System.Drawing.Size(96, 14);
            this.lbl1stUOMName.TabIndex = 77;
            this.lbl1stUOMName.Text = "1st UOM Name";
            // 
            // txtConversionFactorID
            // 
            this.txtConversionFactorID.Enabled = false;
            this.txtConversionFactorID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversionFactorID.Location = new System.Drawing.Point(168, 26);
            this.txtConversionFactorID.Name = "txtConversionFactorID";
            this.txtConversionFactorID.Size = new System.Drawing.Size(174, 23);
            this.txtConversionFactorID.TabIndex = 76;
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
            // lblConversionFactorID
            // 
            this.lblConversionFactorID.AutoSize = true;
            this.lblConversionFactorID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversionFactorID.Location = new System.Drawing.Point(22, 30);
            this.lblConversionFactorID.Name = "lblConversionFactorID";
            this.lblConversionFactorID.Size = new System.Drawing.Size(135, 14);
            this.lblConversionFactorID.TabIndex = 26;
            this.lblConversionFactorID.Text = "Conversion Factor ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(80, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 82;
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
            // cbo1stUOM
            // 
            this.cbo1stUOM.FormattingEnabled = true;
            this.cbo1stUOM.Location = new System.Drawing.Point(168, 68);
            this.cbo1stUOM.Name = "cbo1stUOM";
            this.cbo1stUOM.Size = new System.Drawing.Size(174, 22);
            this.cbo1stUOM.TabIndex = 87;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 22);
            this.comboBox1.TabIndex = 91;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(168, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 23);
            this.textBox1.TabIndex = 90;
            // 
            // lbl2ndUOMQuantity
            // 
            this.lbl2ndUOMQuantity.AutoSize = true;
            this.lbl2ndUOMQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ndUOMQuantity.Location = new System.Drawing.Point(22, 191);
            this.lbl2ndUOMQuantity.Name = "lbl2ndUOMQuantity";
            this.lbl2ndUOMQuantity.Size = new System.Drawing.Size(121, 14);
            this.lbl2ndUOMQuantity.TabIndex = 89;
            this.lbl2ndUOMQuantity.Text = "2nd UOM Quantity";
            // 
            // lbl2ndUOMName
            // 
            this.lbl2ndUOMName.AutoSize = true;
            this.lbl2ndUOMName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ndUOMName.Location = new System.Drawing.Point(22, 152);
            this.lbl2ndUOMName.Name = "lbl2ndUOMName";
            this.lbl2ndUOMName.Size = new System.Drawing.Size(100, 14);
            this.lbl2ndUOMName.TabIndex = 88;
            this.lbl2ndUOMName.Text = "2nd UOM Name";
            // 
            // pnlSConversionFactor
            // 
            this.pnlSConversionFactor.Controls.Add(this.dgvSConversionFactor);
            this.pnlSConversionFactor.Controls.Add(this.gpbSearch);
            this.pnlSConversionFactor.Location = new System.Drawing.Point(1, -1);
            this.pnlSConversionFactor.Name = "pnlSConversionFactor";
            this.pnlSConversionFactor.Size = new System.Drawing.Size(768, 489);
            this.pnlSConversionFactor.TabIndex = 84;
            // 
            // dgvSConversionFactor
            // 
            this.dgvSConversionFactor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSConversionFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSConversionFactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSConversionFactor.Location = new System.Drawing.Point(288, 6);
            this.dgvSConversionFactor.Name = "dgvSConversionFactor";
            this.dgvSConversionFactor.Size = new System.Drawing.Size(470, 480);
            this.dgvSConversionFactor.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.cboSUOM);
            this.gpbSearch.Controls.Add(this.chkSUOM);
            this.gpbSearch.Controls.Add(this.txtSConversionFactorID);
            this.gpbSearch.Controls.Add(this.gpbSControl);
            this.gpbSearch.Controls.Add(this.chkSConversionFactorID);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(17, 113);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 284);
            this.gpbSearch.TabIndex = 3;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnSDelete);
            this.gpbSControl.Controls.Add(this.btnSShowAll);
            this.gpbSControl.Controls.Add(this.btnSCancel);
            this.gpbSControl.Controls.Add(this.btnSSearch);
            this.gpbSControl.Location = new System.Drawing.Point(13, 164);
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
            // chkSConversionFactorID
            // 
            this.chkSConversionFactorID.AutoSize = true;
            this.chkSConversionFactorID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSConversionFactorID.Location = new System.Drawing.Point(13, 33);
            this.chkSConversionFactorID.Name = "chkSConversionFactorID";
            this.chkSConversionFactorID.Size = new System.Drawing.Size(154, 18);
            this.chkSConversionFactorID.TabIndex = 50;
            this.chkSConversionFactorID.Text = "Conversion Factor ID";
            this.chkSConversionFactorID.UseVisualStyleBackColor = true;
            // 
            // txtSConversionFactorID
            // 
            this.txtSConversionFactorID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSConversionFactorID.Location = new System.Drawing.Point(12, 57);
            this.txtSConversionFactorID.Name = "txtSConversionFactorID";
            this.txtSConversionFactorID.Size = new System.Drawing.Size(232, 23);
            this.txtSConversionFactorID.TabIndex = 68;
            // 
            // cboSUOM
            // 
            this.cboSUOM.FormattingEnabled = true;
            this.cboSUOM.Location = new System.Drawing.Point(15, 122);
            this.cboSUOM.Name = "cboSUOM";
            this.cboSUOM.Size = new System.Drawing.Size(232, 22);
            this.cboSUOM.TabIndex = 70;
            // 
            // chkSUOM
            // 
            this.chkSUOM.AutoSize = true;
            this.chkSUOM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSUOM.Location = new System.Drawing.Point(15, 100);
            this.chkSUOM.Name = "chkSUOM";
            this.chkSUOM.Size = new System.Drawing.Size(54, 18);
            this.chkSUOM.TabIndex = 69;
            this.chkSUOM.Text = "UOM";
            this.chkSUOM.UseVisualStyleBackColor = true;
            // 
            // frmConversionFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 512);
            this.Controls.Add(this.pnlConversionFactor);
            this.Controls.Add(this.ssCompany);
            this.MaximizeBox = false;
            this.Name = "frmConversionFactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion Factor Setup";
            this.ssCompany.ResumeLayout(false);
            this.ssCompany.PerformLayout();
            this.pnlConversionFactor.ResumeLayout(false);
            this.gpbConversionFactorSetup.ResumeLayout(false);
            this.gpbConversionFactorSetup.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlSConversionFactor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSConversionFactor)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.StatusStrip ssCompany;
        private System.Windows.Forms.Panel pnlConversionFactor;
        private System.Windows.Forms.GroupBox gpbConversionFactorSetup;
        private System.Windows.Forms.TextBox txt1stUOMQuantity;
        private System.Windows.Forms.Label lbl1stUOMQuantity;
        private System.Windows.Forms.Label lbl1stUOMName;
        private System.Windows.Forms.TextBox txtConversionFactorID;
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
        private System.Windows.Forms.Label lblConversionFactorID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbo1stUOM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl2ndUOMQuantity;
        private System.Windows.Forms.Label lbl2ndUOMName;
        private System.Windows.Forms.Panel pnlSConversionFactor;
        private System.Windows.Forms.DataGridView dgvSConversionFactor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSConversionFactorID;
        private System.Windows.Forms.TextBox txtSConversionFactorID;
        private System.Windows.Forms.ComboBox cboSUOM;
        private System.Windows.Forms.CheckBox chkSUOM;
    }
}