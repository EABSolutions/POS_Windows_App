namespace EAB_Business_Solution.Forms
{
    partial class frmPOReceive
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
            this.pnlPOReceive = new System.Windows.Forms.Panel();
            this.gpbProduct = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblPOID = new System.Windows.Forms.Label();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.lblPOReceiveID = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.pnlPOReceive.SuspendLayout();
            this.gpbProduct.SuspendLayout();
            this.gpbBasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPOReceive
            // 
            this.pnlPOReceive.Controls.Add(this.gpbProduct);
            this.pnlPOReceive.Controls.Add(this.gpbBasicInfo);
            this.pnlPOReceive.Location = new System.Drawing.Point(0, 0);
            this.pnlPOReceive.Name = "pnlPOReceive";
            this.pnlPOReceive.Size = new System.Drawing.Size(1020, 457);
            this.pnlPOReceive.TabIndex = 0;
            // 
            // gpbProduct
            // 
            this.gpbProduct.Controls.Add(this.lblPrice);
            this.gpbProduct.Controls.Add(this.txtPrice);
            this.gpbProduct.Controls.Add(this.lblQuantity);
            this.gpbProduct.Controls.Add(this.btnProduct);
            this.gpbProduct.Controls.Add(this.btnSupplier);
            this.gpbProduct.Controls.Add(this.txtQuantity);
            this.gpbProduct.Controls.Add(this.cboSupplier);
            this.gpbProduct.Controls.Add(this.lblSupplier);
            this.gpbProduct.Controls.Add(this.cboProductName);
            this.gpbProduct.Controls.Add(this.lblProductName);
            this.gpbProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProduct.Location = new System.Drawing.Point(12, 134);
            this.gpbProduct.Name = "gpbProduct";
            this.gpbProduct.Size = new System.Drawing.Size(389, 197);
            this.gpbProduct.TabIndex = 59;
            this.gpbProduct.TabStop = false;
            this.gpbProduct.Text = "Product";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(22, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 14);
            this.lblPrice.TabIndex = 61;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(157, 108);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(79, 23);
            this.txtPrice.TabIndex = 60;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(22, 68);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 14);
            this.lblQuantity.TabIndex = 59;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(335, 27);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(29, 22);
            this.btnProduct.TabIndex = 58;
            this.btnProduct.Text = "...";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(334, 149);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(29, 22);
            this.btnSupplier.TabIndex = 4;
            this.btnSupplier.Text = "...";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(157, 64);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(79, 23);
            this.txtQuantity.TabIndex = 58;
            // 
            // cboSupplier
            // 
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(157, 149);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(171, 22);
            this.cboSupplier.TabIndex = 3;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(22, 152);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(57, 14);
            this.lblSupplier.TabIndex = 57;
            this.lblSupplier.Text = "Supplier";
            // 
            // cboProductName
            // 
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(157, 27);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(172, 22);
            this.cboProductName.TabIndex = 58;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(22, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 14);
            this.lblProductName.TabIndex = 26;
            this.lblProductName.Text = "Product Name";
            // 
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.lblPOID);
            this.gpbBasicInfo.Controls.Add(this.txtPOID);
            this.gpbBasicInfo.Controls.Add(this.txtDescription);
            this.gpbBasicInfo.Controls.Add(this.lblDescription);
            this.gpbBasicInfo.Controls.Add(this.dtpReceiveDate);
            this.gpbBasicInfo.Controls.Add(this.lblReceiveDate);
            this.gpbBasicInfo.Controls.Add(this.lblPOReceiveID);
            this.gpbBasicInfo.Controls.Add(this.txtCompanyID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(12, 12);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(704, 116);
            this.gpbBasicInfo.TabIndex = 1;
            this.gpbBasicInfo.TabStop = false;
            this.gpbBasicInfo.Text = "Basic Infomation";
            // 
            // lblPOID
            // 
            this.lblPOID.AutoSize = true;
            this.lblPOID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOID.Location = new System.Drawing.Point(22, 72);
            this.lblPOID.Name = "lblPOID";
            this.lblPOID.Size = new System.Drawing.Size(38, 14);
            this.lblPOID.TabIndex = 59;
            this.lblPOID.Text = "POID";
            // 
            // txtPOID
            // 
            this.txtPOID.Enabled = false;
            this.txtPOID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOID.Location = new System.Drawing.Point(157, 68);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(108, 23);
            this.txtPOID.TabIndex = 58;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(157, 117);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(507, 89);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(22, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 14);
            this.lblDescription.TabIndex = 51;
            this.lblDescription.Text = "Description";
            // 
            // dtpReceiveDate
            // 
            this.dtpReceiveDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceiveDate.CustomFormat = "dd MMM yyyy";
            this.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiveDate.Location = new System.Drawing.Point(502, 27);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Size = new System.Drawing.Size(185, 22);
            this.dtpReceiveDate.TabIndex = 2;
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.AutoSize = true;
            this.lblReceiveDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveDate.Location = new System.Drawing.Point(391, 30);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(86, 14);
            this.lblReceiveDate.TabIndex = 28;
            this.lblReceiveDate.Text = "Receive Date";
            // 
            // lblPOReceiveID
            // 
            this.lblPOReceiveID.AutoSize = true;
            this.lblPOReceiveID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOReceiveID.Location = new System.Drawing.Point(22, 30);
            this.lblPOReceiveID.Name = "lblPOReceiveID";
            this.lblPOReceiveID.Size = new System.Drawing.Size(92, 14);
            this.lblPOReceiveID.TabIndex = 26;
            this.lblPOReceiveID.Text = "PO Receive ID";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Enabled = false;
            this.txtCompanyID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyID.Location = new System.Drawing.Point(157, 26);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(108, 23);
            this.txtCompanyID.TabIndex = 1;
            // 
            // frmPOReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 457);
            this.Controls.Add(this.pnlPOReceive);
            this.Name = "frmPOReceive";
            this.Text = "Purchase Order Receive";
            this.pnlPOReceive.ResumeLayout(false);
            this.gpbProduct.ResumeLayout(false);
            this.gpbProduct.PerformLayout();
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPOReceive;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.DateTimePicker dtpReceiveDate;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.Label lblPOReceiveID;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.GroupBox gpbProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPOID;
        private System.Windows.Forms.TextBox txtPOID;

    }
}