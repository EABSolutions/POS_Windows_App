namespace EAB_Business_Solution
{
    partial class frmDepartment
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
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cboSDepartment = new System.Windows.Forms.ComboBox();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSShowAll = new System.Windows.Forms.Button();
            this.btnSSearch = new System.Windows.Forms.Button();
            this.chkSDepartmentNamme = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.tbcDepartment = new System.Windows.Forms.TabControl();
            this.tbpDepartmentEntry = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbpDepartmentSearch = new System.Windows.Forms.TabPage();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.tbcDepartment.SuspendLayout();
            this.tbpDepartmentEntry.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.tbpDepartmentSearch.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvDepartment.Location = new System.Drawing.Point(9, 164);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.Size = new System.Drawing.Size(479, 214);
            this.dgvDepartment.TabIndex = 5;
            this.dgvDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellContentClick);
            this.dgvDepartment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // cboSDepartment
            // 
            this.cboSDepartment.FormattingEnabled = true;
            this.cboSDepartment.Location = new System.Drawing.Point(9, 44);
            this.cboSDepartment.Name = "cboSDepartment";
            this.cboSDepartment.Size = new System.Drawing.Size(225, 21);
            this.cboSDepartment.TabIndex = 65;
            // 
            // btnSDelete
            // 
            this.btnSDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDelete.Location = new System.Drawing.Point(159, 19);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(68, 31);
            this.btnSDelete.TabIndex = 19;
            this.btnSDelete.Text = "&Delete";
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
            this.btnSShowAll.Text = "Show &All";
            this.btnSShowAll.UseVisualStyleBackColor = true;
            this.btnSShowAll.Click += new System.EventHandler(this.btnSShowAll_Click);
            // 
            // btnSSearch
            // 
            this.btnSSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSearch.Location = new System.Drawing.Point(12, 19);
            this.btnSSearch.Name = "btnSSearch";
            this.btnSSearch.Size = new System.Drawing.Size(68, 31);
            this.btnSSearch.TabIndex = 13;
            this.btnSSearch.Text = "Searc&h";
            this.btnSSearch.UseVisualStyleBackColor = true;
            this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
            // 
            // chkSDepartmentNamme
            // 
            this.chkSDepartmentNamme.AutoSize = true;
            this.chkSDepartmentNamme.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSDepartmentNamme.Location = new System.Drawing.Point(9, 20);
            this.chkSDepartmentNamme.Name = "chkSDepartmentNamme";
            this.chkSDepartmentNamme.Size = new System.Drawing.Size(113, 17);
            this.chkSDepartmentNamme.TabIndex = 48;
            this.chkSDepartmentNamme.Text = "Department Name";
            this.chkSDepartmentNamme.UseVisualStyleBackColor = true;
            this.chkSDepartmentNamme.CheckedChanged += new System.EventHandler(this.chkSDepartmentNamme_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(302, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(154, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(6, 17);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 31);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNew_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(80, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 31);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(228, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(140, 97);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 69);
            this.txtDescription.TabIndex = 30;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(140, 55);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(220, 23);
            this.txtDepartmentName.TabIndex = 2;
            this.txtDepartmentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartmentName_KeyPress);
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentID.Location = new System.Drawing.Point(140, 19);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(125, 23);
            this.txtDepartmentID.TabIndex = 1;
            this.txtDepartmentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartmentID_KeyPress);
            // 
            // tbcDepartment
            // 
            this.tbcDepartment.Controls.Add(this.tbpDepartmentEntry);
            this.tbcDepartment.Controls.Add(this.tbpDepartmentSearch);
            this.tbcDepartment.Location = new System.Drawing.Point(10, 12);
            this.tbcDepartment.Name = "tbcDepartment";
            this.tbcDepartment.SelectedIndex = 0;
            this.tbcDepartment.Size = new System.Drawing.Size(502, 410);
            this.tbcDepartment.TabIndex = 34;
            // 
            // tbpDepartmentEntry
            // 
            this.tbpDepartmentEntry.Controls.Add(this.groupBox2);
            this.tbpDepartmentEntry.Controls.Add(this.groupBox25);
            this.tbpDepartmentEntry.Location = new System.Drawing.Point(4, 22);
            this.tbpDepartmentEntry.Name = "tbpDepartmentEntry";
            this.tbpDepartmentEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDepartmentEntry.Size = new System.Drawing.Size(494, 384);
            this.tbpDepartmentEntry.TabIndex = 0;
            this.tbpDepartmentEntry.Text = "Entry";
            this.tbpDepartmentEntry.UseVisualStyleBackColor = true;
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
            this.groupBox25.Controls.Add(this.txtDepartmentName);
            this.groupBox25.Controls.Add(this.label24);
            this.groupBox25.Controls.Add(this.label25);
            this.groupBox25.Controls.Add(this.label26);
            this.groupBox25.Controls.Add(this.txtDepartmentID);
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
            this.label24.Size = new System.Drawing.Size(78, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "Department ID";
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
            this.label26.Size = new System.Drawing.Size(94, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "Department Name";
            // 
            // tbpDepartmentSearch
            // 
            this.tbpDepartmentSearch.Controls.Add(this.dgvDepartment);
            this.tbpDepartmentSearch.Controls.Add(this.groupBox27);
            this.tbpDepartmentSearch.Controls.Add(this.groupBox28);
            this.tbpDepartmentSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpDepartmentSearch.Name = "tbpDepartmentSearch";
            this.tbpDepartmentSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDepartmentSearch.Size = new System.Drawing.Size(494, 384);
            this.tbpDepartmentSearch.TabIndex = 1;
            this.tbpDepartmentSearch.Text = "Search";
            this.tbpDepartmentSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.cboSDepartment);
            this.groupBox27.Controls.Add(this.chkSDepartmentNamme);
            this.groupBox27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox27.Location = new System.Drawing.Point(118, 6);
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
            this.groupBox28.Location = new System.Drawing.Point(118, 94);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(240, 64);
            this.groupBox28.TabIndex = 2;
            this.groupBox28.TabStop = false;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 429);
            this.Controls.Add(this.tbcDepartment);
            this.MaximizeBox = false;
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.tbcDepartment.ResumeLayout(false);
            this.tbpDepartmentEntry.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.tbpDepartmentSearch.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSShowAll;
        private System.Windows.Forms.Button btnSSearch;
        private System.Windows.Forms.CheckBox chkSDepartmentNamme;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.ComboBox cboSDepartment;
        private System.Windows.Forms.TabControl tbcDepartment;
        private System.Windows.Forms.TabPage tbpDepartmentEntry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tbpDepartmentSearch;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.GroupBox groupBox28;

    }
}