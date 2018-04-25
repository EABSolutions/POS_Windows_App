namespace EAB_Business_Solution.Forms
{
    partial class frmCar
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.pnlSCar = new System.Windows.Forms.Panel();
            this.dgvSCar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSCarName = new System.Windows.Forms.CheckBox();
            this.cboSCarType = new System.Windows.Forms.ComboBox();
            this.chkSCarType = new System.Windows.Forms.CheckBox();
            this.gpbDetailInfo = new System.Windows.Forms.GroupBox();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCarSize = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCarDescription = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCarID = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.cboSCarName = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.pnlCompany.SuspendLayout();
            this.pnlSCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCar)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpbDetailInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbBasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.tsslUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 23);
            this.statusStrip1.TabIndex = 4;
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
            // pnlCompany
            // 
            this.pnlCompany.Controls.Add(this.pnlSCar);
            this.pnlCompany.Controls.Add(this.gpbDetailInfo);
            this.pnlCompany.Controls.Add(this.groupBox1);
            this.pnlCompany.Controls.Add(this.gpbBasicInfo);
            this.pnlCompany.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCompany.Location = new System.Drawing.Point(0, -2);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(670, 381);
            this.pnlCompany.TabIndex = 5;
            // 
            // pnlSCar
            // 
            this.pnlSCar.Controls.Add(this.dgvSCar);
            this.pnlSCar.Controls.Add(this.gpbSearch);
            this.pnlSCar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSCar.Location = new System.Drawing.Point(0, 3);
            this.pnlSCar.Name = "pnlSCar";
            this.pnlSCar.Size = new System.Drawing.Size(667, 375);
            this.pnlSCar.TabIndex = 6;
            // 
            // dgvSCar
            // 
            this.dgvSCar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSCar.Location = new System.Drawing.Point(283, 10);
            this.dgvSCar.Name = "dgvSCar";
            this.dgvSCar.Size = new System.Drawing.Size(377, 364);
            this.dgvSCar.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.cboSCarName);
            this.gpbSearch.Controls.Add(this.groupBox4);
            this.gpbSearch.Controls.Add(this.chkSCarName);
            this.gpbSearch.Controls.Add(this.cboSCarType);
            this.gpbSearch.Controls.Add(this.chkSCarType);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(13, 42);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 286);
            this.gpbSearch.TabIndex = 1;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSDelete);
            this.groupBox4.Controls.Add(this.btnSShowAll);
            this.groupBox4.Controls.Add(this.btnSCancel);
            this.groupBox4.Controls.Add(this.btnSSearch);
            this.groupBox4.Location = new System.Drawing.Point(13, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 105);
            this.groupBox4.TabIndex = 3;
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
            // chkSCarName
            // 
            this.chkSCarName.AutoSize = true;
            this.chkSCarName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCarName.Location = new System.Drawing.Point(13, 35);
            this.chkSCarName.Name = "chkSCarName";
            this.chkSCarName.Size = new System.Drawing.Size(83, 18);
            this.chkSCarName.TabIndex = 48;
            this.chkSCarName.Text = "Car Name";
            this.chkSCarName.UseVisualStyleBackColor = true;
            // 
            // cboSCarType
            // 
            this.cboSCarType.FormattingEnabled = true;
            this.cboSCarType.Location = new System.Drawing.Point(13, 123);
            this.cboSCarType.Name = "cboSCarType";
            this.cboSCarType.Size = new System.Drawing.Size(232, 22);
            this.cboSCarType.TabIndex = 55;
            // 
            // chkSCarType
            // 
            this.chkSCarType.AutoSize = true;
            this.chkSCarType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSCarType.Location = new System.Drawing.Point(13, 101);
            this.chkSCarType.Name = "chkSCarType";
            this.chkSCarType.Size = new System.Drawing.Size(79, 18);
            this.chkSCarType.TabIndex = 50;
            this.chkSCarType.Text = "Car Type";
            this.chkSCarType.UseVisualStyleBackColor = true;
            // 
            // gpbDetailInfo
            // 
            this.gpbDetailInfo.Controls.Add(this.cboCarType);
            this.gpbDetailInfo.Controls.Add(this.textBox2);
            this.gpbDetailInfo.Controls.Add(this.lblCarSize);
            this.gpbDetailInfo.Controls.Add(this.lblCarType);
            this.gpbDetailInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDetailInfo.Location = new System.Drawing.Point(15, 227);
            this.gpbDetailInfo.Name = "gpbDetailInfo";
            this.gpbDetailInfo.Size = new System.Drawing.Size(644, 73);
            this.gpbDetailInfo.TabIndex = 1;
            this.gpbDetailInfo.TabStop = false;
            this.gpbDetailInfo.Text = "Detail Infomation";
            this.gpbDetailInfo.Enter += new System.EventHandler(this.gpbContactInfo_Enter);
            // 
            // cboCarType
            // 
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(426, 26);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(99, 22);
            this.cboCarType.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(101, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 4;
            // 
            // lblCarSize
            // 
            this.lblCarSize.AutoSize = true;
            this.lblCarSize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarSize.Location = new System.Drawing.Point(12, 30);
            this.lblCarSize.Name = "lblCarSize";
            this.lblCarSize.Size = new System.Drawing.Size(55, 14);
            this.lblCarSize.TabIndex = 29;
            this.lblCarSize.Text = "Car Size";
            this.lblCarSize.Click += new System.EventHandler(this.lblCarSize_Click);
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarType.Location = new System.Drawing.Point(351, 30);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(60, 14);
            this.lblCarType.TabIndex = 33;
            this.lblCarType.Text = "Car Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(30, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 57);
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
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.txtDescription);
            this.gpbBasicInfo.Controls.Add(this.lblCarDescription);
            this.gpbBasicInfo.Controls.Add(this.lblCarName);
            this.gpbBasicInfo.Controls.Add(this.txtCompanyName);
            this.gpbBasicInfo.Controls.Add(this.lblCarID);
            this.gpbBasicInfo.Controls.Add(this.txtCarID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(12, 10);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(647, 211);
            this.gpbBasicInfo.TabIndex = 0;
            this.gpbBasicInfo.TabStop = false;
            this.gpbBasicInfo.Text = "Basic Infomation";
            this.gpbBasicInfo.Enter += new System.EventHandler(this.gpbBasicInfo_Enter);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(104, 83);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 107);
            this.txtDescription.TabIndex = 48;
            // 
            // lblCarDescription
            // 
            this.lblCarDescription.AutoSize = true;
            this.lblCarDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDescription.Location = new System.Drawing.Point(15, 83);
            this.lblCarDescription.Name = "lblCarDescription";
            this.lblCarDescription.Size = new System.Drawing.Size(76, 14);
            this.lblCarDescription.TabIndex = 47;
            this.lblCarDescription.Text = "Description";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.Location = new System.Drawing.Point(354, 33);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(64, 14);
            this.lblCarName.TabIndex = 28;
            this.lblCarName.Text = "Car Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(429, 29);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(200, 23);
            this.txtCompanyName.TabIndex = 2;
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(18, 33);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCarID.Size = new System.Drawing.Size(45, 14);
            this.lblCarID.TabIndex = 26;
            this.lblCarID.Text = "Car ID";
            // 
            // txtCarID
            // 
            this.txtCarID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarID.Location = new System.Drawing.Point(104, 29);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(125, 23);
            this.txtCarID.TabIndex = 1;
            // 
            // cboSCarName
            // 
            this.cboSCarName.FormattingEnabled = true;
            this.cboSCarName.Location = new System.Drawing.Point(13, 59);
            this.cboSCarName.Name = "cboSCarName";
            this.cboSCarName.Size = new System.Drawing.Size(232, 22);
            this.cboSCarName.TabIndex = 56;
            // 
            // frmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 404);
            this.Controls.Add(this.pnlCompany);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "frmCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            this.Load += new System.EventHandler(this.frmCar_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlCompany.ResumeLayout(false);
            this.pnlSCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCar)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gpbDetailInfo.ResumeLayout(false);
            this.gpbDetailInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.GroupBox gpbDetailInfo;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCarSize;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.Label lblCarDescription;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlSCar;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSCarName;
        private System.Windows.Forms.ComboBox cboSCarType;
        private System.Windows.Forms.CheckBox chkSCarType;
        private System.Windows.Forms.DataGridView dgvSCar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.ComboBox cboSCarName;
    }
}