namespace EAB_Business_Solution.Forms
{
    partial class frmInventoryTransferReceive
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
            this.ssCompany = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSInventoryTransfer = new System.Windows.Forms.Panel();
            this.gpbNewInventoryTransfers = new System.Windows.Forms.GroupBox();
            this.dgvNewInventoryTransfers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlPurchaseOrder = new System.Windows.Forms.Panel();
            this.gpbDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbProductReceiveInfo = new System.Windows.Forms.GroupBox();
            this.dgvInventoryTransferReceive = new System.Windows.Forms.DataGridView();
            this.gpbTransferReceiveInfo = new System.Windows.Forms.GroupBox();
            this.lblTransferID = new System.Windows.Forms.Label();
            this.lblReceiveWarehouse = new System.Windows.Forms.Label();
            this.lblTransferFrom = new System.Windows.Forms.Label();
            this.dtpReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.lblTransferReceiveID = new System.Windows.Forms.Label();
            this.txtStockRequestID = new System.Windows.Forms.TextBox();
            this.txtTransferID = new System.Windows.Forms.TextBox();
            this.txtTransferFrom = new System.Windows.Forms.TextBox();
            this.txtReceiveWarehouse = new System.Windows.Forms.TextBox();
            this.txtTransferTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransferedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiveQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssCompany.SuspendLayout();
            this.pnlSInventoryTransfer.SuspendLayout();
            this.gpbNewInventoryTransfers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewInventoryTransfers)).BeginInit();
            this.pnlPurchaseOrder.SuspendLayout();
            this.gpbDescription.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbProductReceiveInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTransferReceive)).BeginInit();
            this.gpbTransferReceiveInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssCompany
            // 
            this.ssCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.tsslUser,
            this.tsslCompID,
            this.tsslEID});
            this.ssCompany.Location = new System.Drawing.Point(0, 543);
            this.ssCompany.Name = "ssCompany";
            this.ssCompany.Size = new System.Drawing.Size(958, 23);
            this.ssCompany.TabIndex = 55;
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
            // pnlSInventoryTransfer
            // 
            this.pnlSInventoryTransfer.Controls.Add(this.pnlPurchaseOrder);
            this.pnlSInventoryTransfer.Controls.Add(this.gpbNewInventoryTransfers);
            this.pnlSInventoryTransfer.Location = new System.Drawing.Point(0, -1);
            this.pnlSInventoryTransfer.Name = "pnlSInventoryTransfer";
            this.pnlSInventoryTransfer.Size = new System.Drawing.Size(954, 541);
            this.pnlSInventoryTransfer.TabIndex = 56;
            // 
            // gpbNewInventoryTransfers
            // 
            this.gpbNewInventoryTransfers.Controls.Add(this.dgvNewInventoryTransfers);
            this.gpbNewInventoryTransfers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNewInventoryTransfers.Location = new System.Drawing.Point(12, 13);
            this.gpbNewInventoryTransfers.Name = "gpbNewInventoryTransfers";
            this.gpbNewInventoryTransfers.Size = new System.Drawing.Size(934, 523);
            this.gpbNewInventoryTransfers.TabIndex = 4;
            this.gpbNewInventoryTransfers.TabStop = false;
            this.gpbNewInventoryTransfers.Text = "New Inventory Transfers";
            // 
            // dgvNewInventoryTransfers
            // 
            this.dgvNewInventoryTransfers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNewInventoryTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewInventoryTransfers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvNewInventoryTransfers.Location = new System.Drawing.Point(6, 21);
            this.dgvNewInventoryTransfers.Name = "dgvNewInventoryTransfers";
            this.dgvNewInventoryTransfers.Size = new System.Drawing.Size(922, 502);
            this.dgvNewInventoryTransfers.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // pnlPurchaseOrder
            // 
            this.pnlPurchaseOrder.Controls.Add(this.gpbDescription);
            this.pnlPurchaseOrder.Controls.Add(this.groupBox1);
            this.pnlPurchaseOrder.Controls.Add(this.gpbProductReceiveInfo);
            this.pnlPurchaseOrder.Controls.Add(this.gpbTransferReceiveInfo);
            this.pnlPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPurchaseOrder.Location = new System.Drawing.Point(1, 3);
            this.pnlPurchaseOrder.Name = "pnlPurchaseOrder";
            this.pnlPurchaseOrder.Size = new System.Drawing.Size(957, 541);
            this.pnlPurchaseOrder.TabIndex = 57;
            // 
            // gpbDescription
            // 
            this.gpbDescription.Controls.Add(this.txtDescription);
            this.gpbDescription.Controls.Add(this.lblDescription);
            this.gpbDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDescription.Location = new System.Drawing.Point(696, 12);
            this.gpbDescription.Name = "gpbDescription";
            this.gpbDescription.Size = new System.Drawing.Size(243, 175);
            this.gpbDescription.TabIndex = 84;
            this.gpbDescription.TabStop = false;
            this.gpbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(11, 48);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 112);
            this.txtDescription.TabIndex = 52;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(9, 26);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 14);
            this.lblDescription.TabIndex = 53;
            this.lblDescription.Text = "Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(170, 462);
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
            // gpbProductReceiveInfo
            // 
            this.gpbProductReceiveInfo.Controls.Add(this.dgvInventoryTransferReceive);
            this.gpbProductReceiveInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductReceiveInfo.Location = new System.Drawing.Point(12, 193);
            this.gpbProductReceiveInfo.Name = "gpbProductReceiveInfo";
            this.gpbProductReceiveInfo.Size = new System.Drawing.Size(927, 263);
            this.gpbProductReceiveInfo.TabIndex = 1;
            this.gpbProductReceiveInfo.TabStop = false;
            this.gpbProductReceiveInfo.Text = "Product Receive Information";
            // 
            // dgvInventoryTransferReceive
            // 
            this.dgvInventoryTransferReceive.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInventoryTransferReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryTransferReceive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colUnit,
            this.colRequestedQuantity,
            this.colTransferedQuantity,
            this.colReceiveQuantity});
            this.dgvInventoryTransferReceive.Location = new System.Drawing.Point(16, 21);
            this.dgvInventoryTransferReceive.Name = "dgvInventoryTransferReceive";
            this.dgvInventoryTransferReceive.Size = new System.Drawing.Size(896, 224);
            this.dgvInventoryTransferReceive.TabIndex = 6;
            // 
            // gpbTransferReceiveInfo
            // 
            this.gpbTransferReceiveInfo.Controls.Add(this.txtTransferTo);
            this.gpbTransferReceiveInfo.Controls.Add(this.lblTo);
            this.gpbTransferReceiveInfo.Controls.Add(this.txtReceiveWarehouse);
            this.gpbTransferReceiveInfo.Controls.Add(this.txtTransferFrom);
            this.gpbTransferReceiveInfo.Controls.Add(this.txtTransferID);
            this.gpbTransferReceiveInfo.Controls.Add(this.lblTransferID);
            this.gpbTransferReceiveInfo.Controls.Add(this.lblReceiveWarehouse);
            this.gpbTransferReceiveInfo.Controls.Add(this.lblTransferFrom);
            this.gpbTransferReceiveInfo.Controls.Add(this.dtpReceiveDate);
            this.gpbTransferReceiveInfo.Controls.Add(this.lblReceiveDate);
            this.gpbTransferReceiveInfo.Controls.Add(this.lblTransferReceiveID);
            this.gpbTransferReceiveInfo.Controls.Add(this.txtStockRequestID);
            this.gpbTransferReceiveInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTransferReceiveInfo.Location = new System.Drawing.Point(12, 10);
            this.gpbTransferReceiveInfo.Name = "gpbTransferReceiveInfo";
            this.gpbTransferReceiveInfo.Size = new System.Drawing.Size(676, 177);
            this.gpbTransferReceiveInfo.TabIndex = 0;
            this.gpbTransferReceiveInfo.TabStop = false;
            this.gpbTransferReceiveInfo.Text = "Inventory Receive Information";
            // 
            // lblTransferID
            // 
            this.lblTransferID.AutoSize = true;
            this.lblTransferID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferID.Location = new System.Drawing.Point(12, 76);
            this.lblTransferID.Name = "lblTransferID";
            this.lblTransferID.Size = new System.Drawing.Size(75, 14);
            this.lblTransferID.TabIndex = 82;
            this.lblTransferID.Text = "Transfer ID";
            // 
            // lblReceiveWarehouse
            // 
            this.lblReceiveWarehouse.AutoSize = true;
            this.lblReceiveWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveWarehouse.Location = new System.Drawing.Point(12, 122);
            this.lblReceiveWarehouse.Name = "lblReceiveWarehouse";
            this.lblReceiveWarehouse.Size = new System.Drawing.Size(125, 14);
            this.lblReceiveWarehouse.TabIndex = 79;
            this.lblReceiveWarehouse.Text = "Receive Warehouse";
            // 
            // lblTransferFrom
            // 
            this.lblTransferFrom.AutoSize = true;
            this.lblTransferFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferFrom.Location = new System.Drawing.Point(363, 76);
            this.lblTransferFrom.Name = "lblTransferFrom";
            this.lblTransferFrom.Size = new System.Drawing.Size(91, 14);
            this.lblTransferFrom.TabIndex = 77;
            this.lblTransferFrom.Text = "Transfer From";
            // 
            // dtpReceiveDate
            // 
            this.dtpReceiveDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceiveDate.CustomFormat = "dd MMM yyyy hh:mm tt";
            this.dtpReceiveDate.Enabled = false;
            this.dtpReceiveDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiveDate.Location = new System.Drawing.Point(465, 29);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Size = new System.Drawing.Size(188, 23);
            this.dtpReceiveDate.TabIndex = 58;
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.AutoSize = true;
            this.lblReceiveDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveDate.Location = new System.Drawing.Point(368, 33);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(86, 14);
            this.lblReceiveDate.TabIndex = 28;
            this.lblReceiveDate.Text = "Receive Date";
            // 
            // lblTransferReceiveID
            // 
            this.lblTransferReceiveID.AutoSize = true;
            this.lblTransferReceiveID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferReceiveID.Location = new System.Drawing.Point(12, 33);
            this.lblTransferReceiveID.Name = "lblTransferReceiveID";
            this.lblTransferReceiveID.Size = new System.Drawing.Size(125, 14);
            this.lblTransferReceiveID.TabIndex = 26;
            this.lblTransferReceiveID.Text = "Transfer Receive ID";
            // 
            // txtStockRequestID
            // 
            this.txtStockRequestID.Enabled = false;
            this.txtStockRequestID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockRequestID.Location = new System.Drawing.Point(158, 29);
            this.txtStockRequestID.Name = "txtStockRequestID";
            this.txtStockRequestID.Size = new System.Drawing.Size(125, 23);
            this.txtStockRequestID.TabIndex = 1;
            // 
            // txtTransferID
            // 
            this.txtTransferID.Enabled = false;
            this.txtTransferID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferID.Location = new System.Drawing.Point(158, 72);
            this.txtTransferID.Name = "txtTransferID";
            this.txtTransferID.Size = new System.Drawing.Size(125, 23);
            this.txtTransferID.TabIndex = 83;
            // 
            // txtTransferFrom
            // 
            this.txtTransferFrom.Enabled = false;
            this.txtTransferFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferFrom.Location = new System.Drawing.Point(464, 72);
            this.txtTransferFrom.Name = "txtTransferFrom";
            this.txtTransferFrom.Size = new System.Drawing.Size(189, 23);
            this.txtTransferFrom.TabIndex = 84;
            // 
            // txtReceiveWarehouse
            // 
            this.txtReceiveWarehouse.Enabled = false;
            this.txtReceiveWarehouse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiveWarehouse.Location = new System.Drawing.Point(158, 118);
            this.txtReceiveWarehouse.Name = "txtReceiveWarehouse";
            this.txtReceiveWarehouse.Size = new System.Drawing.Size(189, 23);
            this.txtReceiveWarehouse.TabIndex = 85;
            // 
            // txtTransferTo
            // 
            this.txtTransferTo.Enabled = false;
            this.txtTransferTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferTo.Location = new System.Drawing.Point(464, 118);
            this.txtTransferTo.Name = "txtTransferTo";
            this.txtTransferTo.Size = new System.Drawing.Size(189, 23);
            this.txtTransferTo.TabIndex = 87;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(535, 101);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 14);
            this.lblTo.TabIndex = 86;
            this.lblTo.Text = "To";
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProductID.Width = 91;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.Width = 101;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colRequestedQuantity
            // 
            this.colRequestedQuantity.HeaderText = "Requested Quantity";
            this.colRequestedQuantity.Name = "colRequestedQuantity";
            this.colRequestedQuantity.ReadOnly = true;
            // 
            // colTransferedQuantity
            // 
            this.colTransferedQuantity.HeaderText = "Transfered Quantity";
            this.colTransferedQuantity.Name = "colTransferedQuantity";
            this.colTransferedQuantity.ReadOnly = true;
            // 
            // colReceiveQuantity
            // 
            this.colReceiveQuantity.HeaderText = "Receive Quantity";
            this.colReceiveQuantity.Name = "colReceiveQuantity";
            // 
            // frmInventoryTransferReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 566);
            this.Controls.Add(this.pnlSInventoryTransfer);
            this.Controls.Add(this.ssCompany);
            this.MaximizeBox = false;
            this.Name = "frmInventoryTransferReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Transfer Receive";
            this.ssCompany.ResumeLayout(false);
            this.ssCompany.PerformLayout();
            this.pnlSInventoryTransfer.ResumeLayout(false);
            this.gpbNewInventoryTransfers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewInventoryTransfers)).EndInit();
            this.pnlPurchaseOrder.ResumeLayout(false);
            this.gpbDescription.ResumeLayout(false);
            this.gpbDescription.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpbProductReceiveInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTransferReceive)).EndInit();
            this.gpbTransferReceiveInfo.ResumeLayout(false);
            this.gpbTransferReceiveInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.Panel pnlSInventoryTransfer;
        private System.Windows.Forms.GroupBox gpbNewInventoryTransfers;
        private System.Windows.Forms.DataGridView dgvNewInventoryTransfers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Panel pnlPurchaseOrder;
        private System.Windows.Forms.GroupBox gpbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbProductReceiveInfo;
        private System.Windows.Forms.DataGridView dgvInventoryTransferReceive;
        private System.Windows.Forms.GroupBox gpbTransferReceiveInfo;
        private System.Windows.Forms.Label lblTransferID;
        private System.Windows.Forms.Label lblReceiveWarehouse;
        private System.Windows.Forms.Label lblTransferFrom;
        private System.Windows.Forms.DateTimePicker dtpReceiveDate;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.Label lblTransferReceiveID;
        private System.Windows.Forms.TextBox txtStockRequestID;
        private System.Windows.Forms.TextBox txtReceiveWarehouse;
        private System.Windows.Forms.TextBox txtTransferFrom;
        private System.Windows.Forms.TextBox txtTransferID;
        private System.Windows.Forms.TextBox txtTransferTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiveQuantity;
    }
}