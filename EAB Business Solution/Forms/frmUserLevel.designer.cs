namespace EAB_Business_Solution.Forms
{
    partial class frmUserLevel
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
            this.pnlUserLevel = new System.Windows.Forms.Panel();
            this.pnlSUserLevel = new System.Windows.Forms.Panel();
            this.dgvSUserLevel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.gpbSCont = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkSUserLevelName = new System.Windows.Forms.CheckBox();
            this.txtSUserLineName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblUserLevelName = new System.Windows.Forms.Label();
            this.txtUserLevelName = new System.Windows.Forms.TextBox();
            this.lblUserLevelID = new System.Windows.Forms.Label();
            this.txtUserLevelID = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlUserLevel.SuspendLayout();
            this.pnlSUserLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUserLevel)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbSCont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbBasicInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserLevel
            // 
            this.pnlUserLevel.Controls.Add(this.pnlSUserLevel);
            this.pnlUserLevel.Controls.Add(this.groupBox1);
            this.pnlUserLevel.Controls.Add(this.gpbBasicInfo);
            this.pnlUserLevel.Location = new System.Drawing.Point(1, 3);
            this.pnlUserLevel.Name = "pnlUserLevel";
            this.pnlUserLevel.Size = new System.Drawing.Size(738, 340);
            this.pnlUserLevel.TabIndex = 0;
            // 
            // pnlSUserLevel
            // 
            this.pnlSUserLevel.Controls.Add(this.dgvSUserLevel);
            this.pnlSUserLevel.Controls.Add(this.gpbSearch);
            this.pnlSUserLevel.Location = new System.Drawing.Point(-1, 0);
            this.pnlSUserLevel.Name = "pnlSUserLevel";
            this.pnlSUserLevel.Size = new System.Drawing.Size(739, 341);
            this.pnlSUserLevel.TabIndex = 56;
            // 
            // dgvSUserLevel
            // 
            this.dgvSUserLevel.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSUserLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSUserLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSUserLevel.Location = new System.Drawing.Point(286, 6);
            this.dgvSUserLevel.Name = "dgvSUserLevel";
            this.dgvSUserLevel.Size = new System.Drawing.Size(443, 332);
            this.dgvSUserLevel.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.gpbSCont);
            this.gpbSearch.Controls.Add(this.chkSUserLevelName);
            this.gpbSearch.Controls.Add(this.txtSUserLineName);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(8, 41);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(261, 247);
            this.gpbSearch.TabIndex = 8;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search Infomation";
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
            // chkSUserLevelName
            // 
            this.chkSUserLevelName.AutoSize = true;
            this.chkSUserLevelName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSUserLevelName.Location = new System.Drawing.Point(13, 35);
            this.chkSUserLevelName.Name = "chkSUserLevelName";
            this.chkSUserLevelName.Size = new System.Drawing.Size(124, 18);
            this.chkSUserLevelName.TabIndex = 48;
            this.chkSUserLevelName.Text = "User Level Name";
            this.chkSUserLevelName.UseVisualStyleBackColor = true;
            // 
            // txtSUserLineName
            // 
            this.txtSUserLineName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUserLineName.Location = new System.Drawing.Point(13, 73);
            this.txtSUserLineName.Name = "txtSUserLineName";
            this.txtSUserLineName.Size = new System.Drawing.Size(232, 23);
            this.txtSUserLineName.TabIndex = 2;
            this.txtSUserLineName.TextChanged += new System.EventHandler(this.txtSUserLineName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(58, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 6;
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
            this.gpbBasicInfo.Controls.Add(this.lblDescription);
            this.gpbBasicInfo.Controls.Add(this.lblUserLevelName);
            this.gpbBasicInfo.Controls.Add(this.txtUserLevelName);
            this.gpbBasicInfo.Controls.Add(this.lblUserLevelID);
            this.gpbBasicInfo.Controls.Add(this.txtUserLevelID);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(11, 9);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(715, 252);
            this.gpbBasicInfo.TabIndex = 3;
            this.gpbBasicInfo.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(153, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(246, 150);
            this.txtDescription.TabIndex = 55;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(17, 77);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 14);
            this.lblDescription.TabIndex = 54;
            this.lblDescription.Text = "Description";
            // 
            // lblUserLevelName
            // 
            this.lblUserLevelName.AutoSize = true;
            this.lblUserLevelName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLevelName.Location = new System.Drawing.Point(403, 34);
            this.lblUserLevelName.Name = "lblUserLevelName";
            this.lblUserLevelName.Size = new System.Drawing.Size(105, 14);
            this.lblUserLevelName.TabIndex = 28;
            this.lblUserLevelName.Text = "User Level Name";
            // 
            // txtUserLevelName
            // 
            this.txtUserLevelName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLevelName.Location = new System.Drawing.Point(512, 30);
            this.txtUserLevelName.Name = "txtUserLevelName";
            this.txtUserLevelName.Size = new System.Drawing.Size(191, 23);
            this.txtUserLevelName.TabIndex = 2;
            // 
            // lblUserLevelID
            // 
            this.lblUserLevelID.AutoSize = true;
            this.lblUserLevelID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLevelID.Location = new System.Drawing.Point(13, 35);
            this.lblUserLevelID.Name = "lblUserLevelID";
            this.lblUserLevelID.Size = new System.Drawing.Size(86, 14);
            this.lblUserLevelID.TabIndex = 26;
            this.lblUserLevelID.Text = "User Level ID";
            // 
            // txtUserLevelID
            // 
            this.txtUserLevelID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLevelID.Location = new System.Drawing.Point(153, 31);
            this.txtUserLevelID.Name = "txtUserLevelID";
            this.txtUserLevelID.Size = new System.Drawing.Size(191, 23);
            this.txtUserLevelID.TabIndex = 1;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 23);
            this.statusStrip1.TabIndex = 9;
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
            // frmUserLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 369);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlUserLevel);
            this.MaximizeBox = false;
            this.Name = "frmUserLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Level";
            this.pnlUserLevel.ResumeLayout(false);
            this.pnlSUserLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUserLevel)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSCont.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserLevel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUserLevelName;
        private System.Windows.Forms.TextBox txtUserLevelName;
        private System.Windows.Forms.Label lblUserLevelID;
        private System.Windows.Forms.TextBox txtUserLevelID;
        private System.Windows.Forms.Panel pnlSUserLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox gpbSCont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkSUserLevelName;
        private System.Windows.Forms.TextBox txtSUserLineName;
        private System.Windows.Forms.DataGridView dgvSUserLevel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}