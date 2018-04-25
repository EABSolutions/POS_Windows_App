namespace EAB_Business_Solution.Report_Forms
{
    partial class frmProductSalesQuantityReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboProductLineName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblSTo = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpbSControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboProductName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboProductLineName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.lblSTo);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 162);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // cboProductName
            // 
            this.cboProductName.Font = new System.Drawing.Font("Myanmar3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(183, 60);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(160, 25);
            this.cboProductName.TabIndex = 77;
            this.cboProductName.SelectedIndexChanged += new System.EventHandler(this.cboProductName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Product Name";
            // 
            // cboProductLineName
            // 
            this.cboProductLineName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProductLineName.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductLineName.FormattingEnabled = true;
            this.cboProductLineName.Location = new System.Drawing.Point(183, 23);
            this.cboProductLineName.Name = "cboProductLineName";
            this.cboProductLineName.Size = new System.Drawing.Size(160, 24);
            this.cboProductLineName.TabIndex = 75;
            this.cboProductLineName.SelectedIndexChanged += new System.EventHandler(this.cboProductLineName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Product Line Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 121);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 67;
            this.lblDate.Text = "Date :";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.CustomFormat = "dd MMM yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(254, 115);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(149, 21);
            this.dtpToDate.TabIndex = 65;
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(222, 121);
            this.lblSTo.Name = "lblSTo";
            this.lblSTo.Size = new System.Drawing.Size(21, 13);
            this.lblSTo.TabIndex = 66;
            this.lblSTo.Text = "To";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.CustomFormat = "dd MMM yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(63, 115);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(149, 21);
            this.dtpFromDate.TabIndex = 64;
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnGenerate);
            this.gpbSControl.Location = new System.Drawing.Point(173, 180);
            this.gpbSControl.Name = "gpbSControl";
            this.gpbSControl.Size = new System.Drawing.Size(108, 57);
            this.gpbSControl.TabIndex = 66;
            this.gpbSControl.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 15);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(81, 31);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmProductSalesQuantityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbSControl);
            this.MaximizeBox = false;
            this.Name = "frmProductSalesQuantityReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Sales Quantity Report";
            this.Load += new System.EventHandler(this.frmProductSalesQuantityReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbSControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboProductLineName;
        private System.Windows.Forms.Label label6;
    }
}