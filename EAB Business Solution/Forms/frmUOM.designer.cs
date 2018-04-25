namespace EAB_Business_Solution.Forms
{
    partial class frmUOM
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUnitOfMeasureName = new System.Windows.Forms.TextBox();
            this.txtUOMID = new System.Windows.Forms.TextBox();
            this.dgvSUOM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cboSUOM = new System.Windows.Forms.ComboBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSUnitOfMeasureName = new System.Windows.Forms.CheckBox();
            this.tbcUOM = new System.Windows.Forms.TabControl();
            this.tbpUOMEntry = new System.Windows.Forms.TabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbpUOMSearch = new System.Windows.Forms.TabPage();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUOM)).BeginInit();
            this.tbcUOM.SuspendLayout();
            this.tbpUOMEntry.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.tbpUOMSearch.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(55, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(305, 15);
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
            this.btnSave.Location = new System.Drawing.Point(157, 15);
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
            this.btnNew.Location = new System.Drawing.Point(9, 15);
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
            this.btnEdit.Location = new System.Drawing.Point(83, 15);
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
            this.btnDelete.Location = new System.Drawing.Point(231, 15);
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
            this.txtDescription.Location = new System.Drawing.Point(107, 99);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 68);
            this.txtDescription.TabIndex = 30;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtUnitOfMeasureName
            // 
            this.txtUnitOfMeasureName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitOfMeasureName.Location = new System.Drawing.Point(107, 57);
            this.txtUnitOfMeasureName.Name = "txtUnitOfMeasureName";
            this.txtUnitOfMeasureName.Size = new System.Drawing.Size(232, 21);
            this.txtUnitOfMeasureName.TabIndex = 2;
            this.txtUnitOfMeasureName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitOfMeasureName_KeyPress);
            // 
            // txtUOMID
            // 
            this.txtUOMID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUOMID.Location = new System.Drawing.Point(107, 21);
            this.txtUOMID.Name = "txtUOMID";
            this.txtUOMID.Size = new System.Drawing.Size(111, 21);
            this.txtUOMID.TabIndex = 1;
            this.txtUOMID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUOMID_KeyPress);
            // 
            // dgvSUOM
            // 
            this.dgvSUOM.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSUOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSUOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSUOM.Location = new System.Drawing.Point(12, 164);
            this.dgvSUOM.Name = "dgvSUOM";
            this.dgvSUOM.Size = new System.Drawing.Size(464, 202);
            this.dgvSUOM.TabIndex = 8;
            this.dgvSUOM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSUOM_CellContentClick);
            this.dgvSUOM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSUOM_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // cboSUOM
            // 
            this.cboSUOM.Font = new System.Drawing.Font("Myanmar3", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSUOM.FormattingEnabled = true;
            this.cboSUOM.Location = new System.Drawing.Point(23, 43);
            this.cboSUOM.Name = "cboSUOM";
            this.cboSUOM.Size = new System.Drawing.Size(201, 24);
            this.cboSUOM.TabIndex = 66;
            this.cboSUOM.SelectedIndexChanged += new System.EventHandler(this.cboSUOM_SelectedIndexChanged);
            // 
            // btnSDelete
            // 
            this.btnSDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDelete.Location = new System.Drawing.Point(161, 19);
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
            this.btnSShowAll.Location = new System.Drawing.Point(87, 19);
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
            this.btnSSearch.Location = new System.Drawing.Point(13, 19);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(68, 31);
            this.btnSSearch.TabIndex = 13;
            this.btnSSearch.Text = "Search";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
            // 
            // chkSUnitOfMeasureName
            // 
            this.chkSUnitOfMeasureName.AutoSize = true;
            this.chkSUnitOfMeasureName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSUnitOfMeasureName.Location = new System.Drawing.Point(23, 20);
            this.chkSUnitOfMeasureName.Name = "chkSUnitOfMeasureName";
            this.chkSUnitOfMeasureName.Size = new System.Drawing.Size(79, 17);
            this.chkSUnitOfMeasureName.TabIndex = 48;
            this.chkSUnitOfMeasureName.Text = "UOM Name";
            this.chkSUnitOfMeasureName.UseVisualStyleBackColor = true;
            this.chkSUnitOfMeasureName.CheckedChanged += new System.EventHandler(this.chkSUnitOfMeasureName_CheckedChanged);
            // 
            // tbcUOM
            // 
            this.tbcUOM.Controls.Add(this.tbpUOMEntry);
            this.tbcUOM.Controls.Add(this.tbpUOMSearch);
            this.tbcUOM.Location = new System.Drawing.Point(12, 12);
            this.tbcUOM.Name = "tbcUOM";
            this.tbcUOM.SelectedIndex = 0;
            this.tbcUOM.Size = new System.Drawing.Size(502, 410);
            this.tbcUOM.TabIndex = 32;
            // 
            // tbpUOMEntry
            // 
            this.tbpUOMEntry.Controls.Add(this.groupBox1);
            this.tbpUOMEntry.Controls.Add(this.groupBox25);
            this.tbpUOMEntry.Location = new System.Drawing.Point(4, 22);
            this.tbpUOMEntry.Name = "tbpUOMEntry";
            this.tbpUOMEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUOMEntry.Size = new System.Drawing.Size(494, 384);
            this.tbpUOMEntry.TabIndex = 0;
            this.tbpUOMEntry.Text = "Entry";
            this.tbpUOMEntry.UseVisualStyleBackColor = true;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.txtDescription);
            this.groupBox25.Controls.Add(this.label24);
            this.groupBox25.Controls.Add(this.txtUnitOfMeasureName);
            this.groupBox25.Controls.Add(this.label25);
            this.groupBox25.Controls.Add(this.label26);
            this.groupBox25.Controls.Add(this.txtUOMID);
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
            this.label24.Location = new System.Drawing.Point(32, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "UOM ID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(32, 102);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Description";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(32, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "UOM Name";
            // 
            // tbpUOMSearch
            // 
            this.tbpUOMSearch.Controls.Add(this.dgvSUOM);
            this.tbpUOMSearch.Controls.Add(this.groupBox27);
            this.tbpUOMSearch.Controls.Add(this.groupBox28);
            this.tbpUOMSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpUOMSearch.Name = "tbpUOMSearch";
            this.tbpUOMSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUOMSearch.Size = new System.Drawing.Size(494, 384);
            this.tbpUOMSearch.TabIndex = 1;
            this.tbpUOMSearch.Text = "Search";
            this.tbpUOMSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.cboSUOM);
            this.groupBox27.Controls.Add(this.chkSUnitOfMeasureName);
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
            // frmUOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 437);
            this.Controls.Add(this.tbcUOM);
            this.MaximizeBox = false;
            this.Name = "frmUOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UOM";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUOM)).EndInit();
            this.tbcUOM.ResumeLayout(false);
            this.tbpUOMEntry.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.tbpUOMSearch.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUnitOfMeasureName;
        private System.Windows.Forms.TextBox txtUOMID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSUnitOfMeasureName;
        private System.Windows.Forms.DataGridView dgvSUOM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.ComboBox cboSUOM;
        private System.Windows.Forms.TabControl tbcUOM;
        private System.Windows.Forms.TabPage tbpUOMEntry;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tbpUOMSearch;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.GroupBox groupBox28;
    }
}