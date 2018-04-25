namespace EAB_Business_Solution.Forms
{
    partial class frmServiceCharges
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkEndDate = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.txtServiceChargesID = new System.Windows.Forms.TextBox();
            this.dgvSServiceCharges = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkSDuration = new System.Windows.Forms.CheckBox();
            this.dtpSToDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtpSFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblSTo = new System.Windows.Forms.Label();
            this.tbcProductClass = new System.Windows.Forms.TabControl();
            this.tbpPCEntry = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbpPCSearch = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSServiceCharges)).BeginInit();
            this.tbcProductClass.SuspendLayout();
            this.tbpPCEntry.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbpPCSearch.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(99, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 57);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(9, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 31);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(80, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 31);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(221, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkEndDate
            // 
            this.chkEndDate.AutoSize = true;
            this.chkEndDate.Location = new System.Drawing.Point(15, 122);
            this.chkEndDate.Name = "chkEndDate";
            this.chkEndDate.Size = new System.Drawing.Size(15, 14);
            this.chkEndDate.TabIndex = 70;
            this.chkEndDate.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CustomFormat = "dd MMM yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(114, 117);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(136, 21);
            this.dtpEndDate.TabIndex = 69;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CustomFormat = "dd MMM yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(114, 85);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(136, 21);
            this.dtpStartDate.TabIndex = 68;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxAmount.Location = new System.Drawing.Point(114, 53);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(136, 21);
            this.txtTaxAmount.TabIndex = 39;
            // 
            // txtServiceChargesID
            // 
            this.txtServiceChargesID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceChargesID.Location = new System.Drawing.Point(114, 21);
            this.txtServiceChargesID.Name = "txtServiceChargesID";
            this.txtServiceChargesID.Size = new System.Drawing.Size(99, 21);
            this.txtServiceChargesID.TabIndex = 37;
            // 
            // dgvSServiceCharges
            // 
            this.dgvSServiceCharges.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSServiceCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSServiceCharges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSServiceCharges.Location = new System.Drawing.Point(6, 157);
            this.dgvSServiceCharges.Name = "dgvSServiceCharges";
            this.dgvSServiceCharges.Size = new System.Drawing.Size(590, 217);
            this.dgvSServiceCharges.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // chkSDuration
            // 
            this.chkSDuration.AutoSize = true;
            this.chkSDuration.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSDuration.Location = new System.Drawing.Point(6, 20);
            this.chkSDuration.Name = "chkSDuration";
            this.chkSDuration.Size = new System.Drawing.Size(67, 17);
            this.chkSDuration.TabIndex = 77;
            this.chkSDuration.Text = "Duration";
            this.chkSDuration.UseVisualStyleBackColor = true;
            // 
            // dtpSToDate
            // 
            this.dtpSToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.CustomFormat = "dd MMM yyyy";
            this.dtpSToDate.Enabled = false;
            this.dtpSToDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSToDate.Location = new System.Drawing.Point(173, 44);
            this.dtpSToDate.Name = "dtpSToDate";
            this.dtpSToDate.Size = new System.Drawing.Size(136, 21);
            this.dtpSToDate.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(78, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Show &All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(7, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Searc&h";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dtpSFromDate
            // 
            this.dtpSFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpSFromDate.Enabled = false;
            this.dtpSFromDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSFromDate.Location = new System.Drawing.Point(6, 44);
            this.dtpSFromDate.Name = "dtpSFromDate";
            this.dtpSFromDate.Size = new System.Drawing.Size(136, 21);
            this.dtpSFromDate.TabIndex = 75;
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(148, 50);
            this.lblSTo.Name = "lblSTo";
            this.lblSTo.Size = new System.Drawing.Size(19, 13);
            this.lblSTo.TabIndex = 74;
            this.lblSTo.Text = "To";
            // 
            // tbcProductClass
            // 
            this.tbcProductClass.Controls.Add(this.tbpPCEntry);
            this.tbcProductClass.Controls.Add(this.tbpPCSearch);
            this.tbcProductClass.Location = new System.Drawing.Point(11, 12);
            this.tbcProductClass.Name = "tbcProductClass";
            this.tbcProductClass.SelectedIndex = 0;
            this.tbcProductClass.Size = new System.Drawing.Size(610, 407);
            this.tbcProductClass.TabIndex = 45;
            // 
            // tbpPCEntry
            // 
            this.tbpPCEntry.Controls.Add(this.groupBox2);
            this.tbpPCEntry.Controls.Add(this.groupBox3);
            this.tbpPCEntry.Location = new System.Drawing.Point(4, 22);
            this.tbpPCEntry.Name = "tbpPCEntry";
            this.tbpPCEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPCEntry.Size = new System.Drawing.Size(602, 381);
            this.tbpPCEntry.TabIndex = 0;
            this.tbpPCEntry.Text = "Entry";
            this.tbpPCEntry.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.chkEndDate);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtTaxAmount);
            this.groupBox3.Controls.Add(this.txtServiceChargesID);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(150, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 151);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service Charges Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "End Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(32, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Start Date";
            // 
            // tbpPCSearch
            // 
            this.tbpPCSearch.Controls.Add(this.dgvSServiceCharges);
            this.tbpPCSearch.Controls.Add(this.groupBox17);
            this.tbpPCSearch.Controls.Add(this.groupBox19);
            this.tbpPCSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpPCSearch.Name = "tbpPCSearch";
            this.tbpPCSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPCSearch.Size = new System.Drawing.Size(602, 381);
            this.tbpPCSearch.TabIndex = 1;
            this.tbpPCSearch.Text = "Search";
            this.tbpPCSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.button2);
            this.groupBox19.Controls.Add(this.button1);
            this.groupBox19.Controls.Add(this.button4);
            this.groupBox19.Location = new System.Drawing.Point(185, 94);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(222, 57);
            this.groupBox19.TabIndex = 2;
            this.groupBox19.TabStop = false;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.dtpSToDate);
            this.groupBox17.Controls.Add(this.chkSDuration);
            this.groupBox17.Controls.Add(this.dtpSFromDate);
            this.groupBox17.Controls.Add(this.lblSTo);
            this.groupBox17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.Location = new System.Drawing.Point(141, 10);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(321, 82);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Search Filter";
            // 
            // frmServiceCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 428);
            this.Controls.Add(this.tbcProductClass);
            this.MaximizeBox = false;
            this.Name = "frmServiceCharges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Charges";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSServiceCharges)).EndInit();
            this.tbcProductClass.ResumeLayout(false);
            this.tbpPCEntry.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tbpPCSearch.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.TextBox txtServiceChargesID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvSServiceCharges;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.CheckBox chkEndDate;
        private System.Windows.Forms.CheckBox chkSDuration;
        private System.Windows.Forms.DateTimePicker dtpSToDate;
        private System.Windows.Forms.DateTimePicker dtpSFromDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.TabControl tbcProductClass;
        private System.Windows.Forms.TabPage tbpPCEntry;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tbpPCSearch;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox17;
    }
}