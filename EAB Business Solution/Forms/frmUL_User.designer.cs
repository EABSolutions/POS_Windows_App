namespace EAB_Business_Solution.Forms
{
    partial class frmUL_User
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
            this.pnlULUser = new System.Windows.Forms.Panel();
            this.pnlSUserLevelMatching = new System.Windows.Forms.Panel();
            this.dgvSULUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.cboSUserLevel = new System.Windows.Forms.ComboBox();
            this.gpbSCont = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkSUserLevel = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNRCNoShow = new System.Windows.Forms.Label();
            this.lblNRCNo = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.chkDepartment = new System.Windows.Forms.CheckBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.chkPosition = new System.Windows.Forms.CheckBox();
            this.chkEmployeeName = new System.Windows.Forms.CheckBox();
            this.cboUserLevel = new System.Windows.Forms.ComboBox();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlULUser.SuspendLayout();
            this.pnlSUserLevelMatching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSULUser)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSCont.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlULUser
            // 
            this.pnlULUser.Controls.Add(this.pnlSUserLevelMatching);
            this.pnlULUser.Controls.Add(this.groupBox2);
            this.pnlULUser.Controls.Add(this.groupBox1);
            this.pnlULUser.Location = new System.Drawing.Point(1, 2);
            this.pnlULUser.Name = "pnlULUser";
            this.pnlULUser.Size = new System.Drawing.Size(627, 355);
            this.pnlULUser.TabIndex = 0;
            // 
            // pnlSUserLevelMatching
            // 
            this.pnlSUserLevelMatching.Controls.Add(this.dgvSULUser);
            this.pnlSUserLevelMatching.Controls.Add(this.gpbSearch);
            this.pnlSUserLevelMatching.Location = new System.Drawing.Point(0, 0);
            this.pnlSUserLevelMatching.Name = "pnlSUserLevelMatching";
            this.pnlSUserLevelMatching.Size = new System.Drawing.Size(631, 355);
            this.pnlSUserLevelMatching.TabIndex = 31;
            // 
            // dgvSULUser
            // 
            this.dgvSULUser.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSULUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSULUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSULUser.Location = new System.Drawing.Point(278, 8);
            this.dgvSULUser.Name = "dgvSULUser";
            this.dgvSULUser.Size = new System.Drawing.Size(349, 328);
            this.dgvSULUser.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.cboSUserLevel);
            this.gpbSearch.Controls.Add(this.gpbSCont);
            this.gpbSearch.Controls.Add(this.chkSUserLevel);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(11, 53);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 243);
            this.gpbSearch.TabIndex = 9;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
            // 
            // cboSUserLevel
            // 
            this.cboSUserLevel.FormattingEnabled = true;
            this.cboSUserLevel.Location = new System.Drawing.Point(13, 60);
            this.cboSUserLevel.Name = "cboSUserLevel";
            this.cboSUserLevel.Size = new System.Drawing.Size(231, 22);
            this.cboSUserLevel.TabIndex = 64;
            // 
            // gpbSCont
            // 
            this.gpbSCont.Controls.Add(this.button1);
            this.gpbSCont.Controls.Add(this.button2);
            this.gpbSCont.Controls.Add(this.button3);
            this.gpbSCont.Controls.Add(this.button4);
            this.gpbSCont.Location = new System.Drawing.Point(13, 113);
            this.gpbSCont.Name = "gpbSCont";
            this.gpbSCont.Size = new System.Drawing.Size(232, 105);
            this.gpbSCont.TabIndex = 59;
            this.gpbSCont.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(27, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Show &All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(125, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "&Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(27, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Searc&h";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // chkSUserLevel
            // 
            this.chkSUserLevel.AutoSize = true;
            this.chkSUserLevel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSUserLevel.Location = new System.Drawing.Point(13, 35);
            this.chkSUserLevel.Name = "chkSUserLevel";
            this.chkSUserLevel.Size = new System.Drawing.Size(87, 18);
            this.chkSUserLevel.TabIndex = 48;
            this.chkSUserLevel.Text = "User Level";
            this.chkSUserLevel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(11, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
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
            this.btnNew.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnNew_KeyUp);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNRCNoShow);
            this.groupBox1.Controls.Add(this.lblNRCNo);
            this.groupBox1.Controls.Add(this.cboDepartment);
            this.groupBox1.Controls.Add(this.chkDepartment);
            this.groupBox1.Controls.Add(this.cboPosition);
            this.groupBox1.Controls.Add(this.chkPosition);
            this.groupBox1.Controls.Add(this.chkEmployeeName);
            this.groupBox1.Controls.Add(this.cboUserLevel);
            this.groupBox1.Controls.Add(this.lblUserLevel);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Location = new System.Drawing.Point(161, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblNRCNoShow
            // 
            this.lblNRCNoShow.AutoSize = true;
            this.lblNRCNoShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNoShow.Location = new System.Drawing.Point(140, 186);
            this.lblNRCNoShow.Name = "lblNRCNoShow";
            this.lblNRCNoShow.Size = new System.Drawing.Size(52, 14);
            this.lblNRCNoShow.TabIndex = 71;
            this.lblNRCNoShow.Text = "NRC No";
            // 
            // lblNRCNo
            // 
            this.lblNRCNo.AutoSize = true;
            this.lblNRCNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNo.Location = new System.Drawing.Point(15, 186);
            this.lblNRCNo.Name = "lblNRCNo";
            this.lblNRCNo.Size = new System.Drawing.Size(56, 14);
            this.lblNRCNo.TabIndex = 70;
            this.lblNRCNo.Text = "NRC No:";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(143, 61);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(193, 21);
            this.cboDepartment.TabIndex = 69;
            // 
            // chkDepartment
            // 
            this.chkDepartment.AutoSize = true;
            this.chkDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDepartment.Location = new System.Drawing.Point(18, 64);
            this.chkDepartment.Name = "chkDepartment";
            this.chkDepartment.Size = new System.Drawing.Size(100, 18);
            this.chkDepartment.TabIndex = 68;
            this.chkDepartment.Text = "Department";
            this.chkDepartment.UseVisualStyleBackColor = true;
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(143, 105);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(193, 21);
            this.cboPosition.TabIndex = 67;
            // 
            // chkPosition
            // 
            this.chkPosition.AutoSize = true;
            this.chkPosition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPosition.Location = new System.Drawing.Point(18, 106);
            this.chkPosition.Name = "chkPosition";
            this.chkPosition.Size = new System.Drawing.Size(76, 18);
            this.chkPosition.TabIndex = 66;
            this.chkPosition.Text = "Position";
            this.chkPosition.UseVisualStyleBackColor = true;
            // 
            // chkEmployeeName
            // 
            this.chkEmployeeName.AutoSize = true;
            this.chkEmployeeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmployeeName.Location = new System.Drawing.Point(18, 149);
            this.chkEmployeeName.Name = "chkEmployeeName";
            this.chkEmployeeName.Size = new System.Drawing.Size(121, 18);
            this.chkEmployeeName.TabIndex = 64;
            this.chkEmployeeName.Text = "Employee Name";
            this.chkEmployeeName.UseVisualStyleBackColor = true;
            // 
            // cboUserLevel
            // 
            this.cboUserLevel.FormattingEnabled = true;
            this.cboUserLevel.Location = new System.Drawing.Point(143, 19);
            this.cboUserLevel.Name = "cboUserLevel";
            this.cboUserLevel.Size = new System.Drawing.Size(193, 21);
            this.cboUserLevel.TabIndex = 63;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLevel.Location = new System.Drawing.Point(15, 21);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(68, 14);
            this.lblUserLevel.TabIndex = 29;
            this.lblUserLevel.Text = "User Level";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(143, 146);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(191, 23);
            this.txtEmployeeName.TabIndex = 27;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 23);
            this.statusStrip1.TabIndex = 10;
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
            // frmUL_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 383);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlULUser);
            this.MaximizeBox = false;
            this.Name = "frmUL_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Level - User Matching";
            this.pnlULUser.ResumeLayout(false);
            this.pnlSUserLevelMatching.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSULUser)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSCont.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlULUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.Panel pnlSUserLevelMatching;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox gpbSCont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkSUserLevel;
        private System.Windows.Forms.DataGridView dgvSULUser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.ComboBox cboUserLevel;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.CheckBox chkDepartment;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.CheckBox chkPosition;
        private System.Windows.Forms.CheckBox chkEmployeeName;
        private System.Windows.Forms.Label lblNRCNoShow;
        private System.Windows.Forms.Label lblNRCNo;
        private System.Windows.Forms.ComboBox cboSUserLevel;
    }
}