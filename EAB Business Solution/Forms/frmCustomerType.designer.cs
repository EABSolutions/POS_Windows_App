namespace EAB_Business_Solution.Forms
{
    partial class frmCustomerType
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
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.pnlSCustomerType = new System.Windows.Forms.Panel();
            this.dgvSCustomerType = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSCustomerType = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCustomerTypeName = new System.Windows.Forms.Label();
            this.txtCustomerTypeName = new System.Windows.Forms.TextBox();
            this.lblCustmerTypeID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlDepartment.SuspendLayout();
            this.pnlSCustomerType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCustomerType)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDepartment
            // 
            this.pnlDepartment.Controls.Add(this.pnlSCustomerType);
            this.pnlDepartment.Controls.Add(this.groupBox1);
            this.pnlDepartment.Controls.Add(this.gpbInfo);
            this.pnlDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDepartment.Location = new System.Drawing.Point(1, 1);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(762, 300);
            this.pnlDepartment.TabIndex = 2;
            // 
            // pnlSCustomerType
            // 
            this.pnlSCustomerType.Controls.Add(this.dgvSCustomerType);
            this.pnlSCustomerType.Controls.Add(this.gpbSearch);
            this.pnlSCustomerType.Location = new System.Drawing.Point(0, 0);
            this.pnlSCustomerType.Name = "pnlSCustomerType";
            this.pnlSCustomerType.Size = new System.Drawing.Size(765, 300);
            this.pnlSCustomerType.TabIndex = 32;
            // 
            // dgvSCustomerType
            // 
            this.dgvSCustomerType.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSCustomerType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSCustomerType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSCustomerType.Location = new System.Drawing.Point(284, 9);
            this.dgvSCustomerType.Name = "dgvSCustomerType";
            this.dgvSCustomerType.Size = new System.Drawing.Size(469, 277);
            this.dgvSCustomerType.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.cboCustomerType);
            this.gpbSearch.Controls.Add(this.groupBox4);
            this.gpbSearch.Controls.Add(this.chkSCustomerType);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(12, 39);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 214);
            this.gpbSearch.TabIndex = 1;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // cboCustomerType
            // 
            this.cboCustomerType.FormattingEnabled = true;
            this.cboCustomerType.Location = new System.Drawing.Point(14, 58);
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.Size = new System.Drawing.Size(232, 22);
            this.cboCustomerType.TabIndex = 57;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSDelete);
            this.groupBox4.Controls.Add(this.btnSShowAll);
            this.groupBox4.Controls.Add(this.btnSCancel);
            this.groupBox4.Controls.Add(this.btnSSearch);
            this.groupBox4.Location = new System.Drawing.Point(14, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 105);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
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
            // chkSCustomerType
            // 
            this.chkSCustomerType.AutoSize = true;
            this.chkSCustomerType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCustomerType.Location = new System.Drawing.Point(14, 34);
            this.chkSCustomerType.Name = "chkSCustomerType";
            this.chkSCustomerType.Size = new System.Drawing.Size(118, 18);
            this.chkSCustomerType.TabIndex = 50;
            this.chkSCustomerType.Text = "Customer Type";
            this.chkSCustomerType.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(72, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 3;
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
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.txtDescription);
            this.gpbInfo.Controls.Add(this.lblDescription);
            this.gpbInfo.Controls.Add(this.lblCustomerTypeName);
            this.gpbInfo.Controls.Add(this.txtCustomerTypeName);
            this.gpbInfo.Controls.Add(this.lblCustmerTypeID);
            this.gpbInfo.Controls.Add(this.txtCustomerID);
            this.gpbInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.Location = new System.Drawing.Point(12, 10);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(737, 213);
            this.gpbInfo.TabIndex = 0;
            this.gpbInfo.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(133, 79);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 107);
            this.txtDescription.TabIndex = 30;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(13, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 14);
            this.lblDescription.TabIndex = 29;
            this.lblDescription.Text = "Description";
            // 
            // lblCustomerTypeName
            // 
            this.lblCustomerTypeName.AutoSize = true;
            this.lblCustomerTypeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTypeName.Location = new System.Drawing.Point(413, 35);
            this.lblCustomerTypeName.Name = "lblCustomerTypeName";
            this.lblCustomerTypeName.Size = new System.Drawing.Size(136, 14);
            this.lblCustomerTypeName.TabIndex = 28;
            this.lblCustomerTypeName.Text = "Customer Type Name";
            // 
            // txtCustomerTypeName
            // 
            this.txtCustomerTypeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerTypeName.Location = new System.Drawing.Point(555, 31);
            this.txtCustomerTypeName.Name = "txtCustomerTypeName";
            this.txtCustomerTypeName.Size = new System.Drawing.Size(168, 23);
            this.txtCustomerTypeName.TabIndex = 2;
            // 
            // lblCustmerTypeID
            // 
            this.lblCustmerTypeID.AutoSize = true;
            this.lblCustmerTypeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustmerTypeID.Location = new System.Drawing.Point(13, 33);
            this.lblCustmerTypeID.Name = "lblCustmerTypeID";
            this.lblCustmerTypeID.Size = new System.Drawing.Size(117, 14);
            this.lblCustmerTypeID.TabIndex = 26;
            this.lblCustmerTypeID.Text = "Customer Type ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(133, 29);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(64, 23);
            this.txtCustomerID.TabIndex = 1;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 303);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 23);
            this.statusStrip1.TabIndex = 6;
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
            // frmCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 326);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlDepartment);
            this.MaximizeBox = false;
            this.Name = "frmCustomerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Type";
            this.pnlDepartment.ResumeLayout(false);
            this.pnlSCustomerType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCustomerType)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCustomerTypeName;
        private System.Windows.Forms.TextBox txtCustomerTypeName;
        private System.Windows.Forms.Label lblCustmerTypeID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.Panel pnlSCustomerType;
        private System.Windows.Forms.DataGridView dgvSCustomerType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSCustomerType;
        private System.Windows.Forms.ComboBox cboCustomerType;
    }
}