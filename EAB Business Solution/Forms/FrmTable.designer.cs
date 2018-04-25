namespace EAB_Business_Solution.Forms
{
    partial class FrmTable
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
            this.dgvSTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cboSTableName = new System.Windows.Forms.ComboBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSTableName = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.tbcTable = new System.Windows.Forms.TabControl();
            this.tbpTableEntry = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbpTableSearch = new System.Windows.Forms.TabPage();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTable)).BeginInit();
            this.tbcTable.SuspendLayout();
            this.tbpTableEntry.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.tbpTableSearch.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSTable
            // 
            this.dgvSTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSTable.Location = new System.Drawing.Point(7, 164);
            this.dgvSTable.Name = "dgvSTable";
            this.dgvSTable.Size = new System.Drawing.Size(479, 214);
            this.dgvSTable.TabIndex = 8;
            this.dgvSTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTable_CellContentClick);
            this.dgvSTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTable_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // cboSTableName
            // 
            this.cboSTableName.FormattingEnabled = true;
            this.cboSTableName.Location = new System.Drawing.Point(13, 41);
            this.cboSTableName.Name = "cboSTableName";
            this.cboSTableName.Size = new System.Drawing.Size(211, 21);
            this.cboSTableName.TabIndex = 66;
            this.cboSTableName.SelectedIndexChanged += new System.EventHandler(this.cboSTableName_SelectedIndexChanged);
            // 
            // btnSDelete
            // 
            this.btnSDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDelete.Location = new System.Drawing.Point(159, 19);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(68, 31);
            this.btnSDelete.TabIndex = 19;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.UseVisualStyleBackColor = true;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // btnSShowAll
            // 
            this.btnSShowAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSShowAll.Location = new System.Drawing.Point(85, 19);
            this.btnSShowAll.Name = "btnSShowAll";
            this.btnSShowAll.Size = new System.Drawing.Size(68, 31);
            this.btnSShowAll.TabIndex = 18;
            this.btnSShowAll.Text = "Show All";
            this.btnSShowAll.UseVisualStyleBackColor = true;
            this.btnSShowAll.Click += new System.EventHandler(this.btnSShowAll_Click);
            // 
            // btnSSearch
            // 
            this.btnSSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSearch.Location = new System.Drawing.Point(11, 19);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(68, 31);
            this.btnSSearch.TabIndex = 13;
            this.btnSSearch.Text = "Search";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
            // 
            // chkSTableName
            // 
            this.chkSTableName.AutoSize = true;
            this.chkSTableName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSTableName.Location = new System.Drawing.Point(13, 17);
            this.chkSTableName.Name = "chkSTableName";
            this.chkSTableName.Size = new System.Drawing.Size(82, 17);
            this.chkSTableName.TabIndex = 48;
            this.chkSTableName.Text = "Table Name";
            this.chkSTableName.UseVisualStyleBackColor = true;
            this.chkSTableName.CheckedChanged += new System.EventHandler(this.chkSTableName_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(304, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(156, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(10, 15);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 31);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNew_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(82, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 31);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(230, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(104, 99);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 68);
            this.txtDescription.TabIndex = 30;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(104, 57);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(143, 21);
            this.txtTableName.TabIndex = 2;
            this.txtTableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTableName_KeyPress);
            // 
            // txtTID
            // 
            this.txtTID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTID.Location = new System.Drawing.Point(104, 21);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(111, 21);
            this.txtTID.TabIndex = 1;
            this.txtTID.TextChanged += new System.EventHandler(this.txtTID_TextChanged);
            this.txtTID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTID_KeyPress);
            // 
            // tbcTable
            // 
            this.tbcTable.Controls.Add(this.tbpTableEntry);
            this.tbcTable.Controls.Add(this.tbpTableSearch);
            this.tbcTable.Location = new System.Drawing.Point(16, 12);
            this.tbcTable.Name = "tbcTable";
            this.tbcTable.SelectedIndex = 0;
            this.tbcTable.Size = new System.Drawing.Size(502, 410);
            this.tbcTable.TabIndex = 33;
            // 
            // tbpTableEntry
            // 
            this.tbpTableEntry.Controls.Add(this.groupBox2);
            this.tbpTableEntry.Controls.Add(this.groupBox25);
            this.tbpTableEntry.Location = new System.Drawing.Point(4, 22);
            this.tbpTableEntry.Name = "tbpTableEntry";
            this.tbpTableEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTableEntry.Size = new System.Drawing.Size(494, 384);
            this.tbpTableEntry.TabIndex = 0;
            this.tbpTableEntry.Text = "Entry";
            this.tbpTableEntry.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(55, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.txtDescription);
            this.groupBox25.Controls.Add(this.label24);
            this.groupBox25.Controls.Add(this.txtTableName);
            this.groupBox25.Controls.Add(this.label25);
            this.groupBox25.Controls.Add(this.label26);
            this.groupBox25.Controls.Add(this.txtTID);
            this.groupBox25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox25.Location = new System.Drawing.Point(55, 69);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(378, 177);
            this.groupBox25.TabIndex = 1;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "UOM Info";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(29, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "Table ID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(29, 102);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Description";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(29, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "Table Name";
            // 
            // tbpTableSearch
            // 
            this.tbpTableSearch.Controls.Add(this.dgvSTable);
            this.tbpTableSearch.Controls.Add(this.groupBox27);
            this.tbpTableSearch.Controls.Add(this.groupBox28);
            this.tbpTableSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpTableSearch.Name = "tbpTableSearch";
            this.tbpTableSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTableSearch.Size = new System.Drawing.Size(494, 384);
            this.tbpTableSearch.TabIndex = 1;
            this.tbpTableSearch.Text = "Search";
            this.tbpTableSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.cboSTableName);
            this.groupBox27.Controls.Add(this.chkSTableName);
            this.groupBox27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox27.Location = new System.Drawing.Point(111, 6);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(240, 82);
            this.groupBox27.TabIndex = 1;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Search Filter";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.btnSShowAll);
            this.groupBox28.Controls.Add(this.btnSDelete);
            this.groupBox28.Controls.Add(this.btnSSearch);
            this.groupBox28.Location = new System.Drawing.Point(111, 94);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(240, 64);
            this.groupBox28.TabIndex = 2;
            this.groupBox28.TabStop = false;
            // 
            // FrmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 433);
            this.Controls.Add(this.tbcTable);
            this.MaximizeBox = false;
            this.Name = "FrmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTable)).EndInit();
            this.tbcTable.ResumeLayout(false);
            this.tbpTableEntry.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.tbpTableSearch.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.DataGridView dgvSTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.ComboBox cboSTableName;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSTableName;
        private System.Windows.Forms.TabControl tbcTable;
        private System.Windows.Forms.TabPage tbpTableEntry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tbpTableSearch;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.GroupBox groupBox28;
    }
}