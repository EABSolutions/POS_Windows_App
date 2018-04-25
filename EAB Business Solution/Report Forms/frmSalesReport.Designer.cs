namespace EAB_Business_Solution.Report_Forms
{
    partial class frmSalesReport
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
            this.gpbSControl = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblSTo = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.gpbSControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSControl
            // 
            this.gpbSControl.Controls.Add(this.btnGenerate);
            this.gpbSControl.Location = new System.Drawing.Point(176, 103);
            this.gpbSControl.Name = "gpbSControl";
            this.gpbSControl.Size = new System.Drawing.Size(108, 57);
            this.gpbSControl.TabIndex = 64;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.lblSTo);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 85);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(20, 37);
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
            this.dtpToDate.Location = new System.Drawing.Point(248, 31);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(149, 21);
            this.dtpToDate.TabIndex = 65;
            this.dtpToDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpToDate_KeyPress);
            // 
            // lblSTo
            // 
            this.lblSTo.AutoSize = true;
            this.lblSTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTo.Location = new System.Drawing.Point(221, 37);
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
            this.dtpFromDate.Location = new System.Drawing.Point(66, 31);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(149, 21);
            this.dtpFromDate.TabIndex = 64;
            this.dtpFromDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFromDate_KeyPress);
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 175);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbSControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.gpbSControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSControl;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblSTo;
        private System.Windows.Forms.DateTimePicker dtpFromDate;

    }
}