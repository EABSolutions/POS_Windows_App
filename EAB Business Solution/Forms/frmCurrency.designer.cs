namespace EAB_Business_Solution.Forms
{
    partial class frmCurrency
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
            this.pnlCurrency = new System.Windows.Forms.Panel();
            this.gpbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblCurrencyCode = new System.Windows.Forms.Label();
            this.txtCurrencyCode = new System.Windows.Forms.TextBox();
            this.lblCurrencyName = new System.Windows.Forms.Label();
            this.txtCurrencyName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlCurrency.SuspendLayout();
            this.gpbBasicInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCurrency
            // 
            this.pnlCurrency.Controls.Add(this.groupBox1);
            this.pnlCurrency.Controls.Add(this.gpbBasicInfo);
            this.pnlCurrency.Location = new System.Drawing.Point(2, 1);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(630, 215);
            this.pnlCurrency.TabIndex = 0;
            // 
            // gpbBasicInfo
            // 
            this.gpbBasicInfo.Controls.Add(this.lblCurrencyCode);
            this.gpbBasicInfo.Controls.Add(this.txtCurrencyCode);
            this.gpbBasicInfo.Controls.Add(this.lblCurrencyName);
            this.gpbBasicInfo.Controls.Add(this.txtCurrencyName);
            this.gpbBasicInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBasicInfo.Location = new System.Drawing.Point(128, 11);
            this.gpbBasicInfo.Name = "gpbBasicInfo";
            this.gpbBasicInfo.Size = new System.Drawing.Size(373, 114);
            this.gpbBasicInfo.TabIndex = 5;
            this.gpbBasicInfo.TabStop = false;
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.AutoSize = true;
            this.lblCurrencyCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyCode.Location = new System.Drawing.Point(21, 30);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(96, 14);
            this.lblCurrencyCode.TabIndex = 28;
            this.lblCurrencyCode.Text = "Currency Code";
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyCode.Location = new System.Drawing.Point(145, 26);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Size = new System.Drawing.Size(74, 23);
            this.txtCurrencyCode.TabIndex = 2;
            // 
            // lblCurrencyName
            // 
            this.lblCurrencyName.AutoSize = true;
            this.lblCurrencyName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName.Location = new System.Drawing.Point(21, 79);
            this.lblCurrencyName.Name = "lblCurrencyName";
            this.lblCurrencyName.Size = new System.Drawing.Size(98, 14);
            this.lblCurrencyName.TabIndex = 26;
            this.lblCurrencyName.Text = "Currency Name";
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyName.Location = new System.Drawing.Point(145, 75);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(198, 23);
            this.txtCurrencyName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(10, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 57);
            this.groupBox1.TabIndex = 8;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.tsslUser,
            this.toolStripStatusLabel1,
            this.tsslCompID,
            this.tsslEID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 220);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslabelUser
            // 
            this.tsslabelUser.Name = "tsslabelUser";
            this.tsslabelUser.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslCompany
            // 
            this.tsslCompany.Name = "tsslCompany";
            this.tsslCompany.Size = new System.Drawing.Size(59, 17);
            this.tsslCompany.Text = "Company";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(30, 17);
            this.tsslUser.Text = "User";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslCompID
            // 
            this.tsslCompID.Name = "tsslCompID";
            this.tsslCompID.Size = new System.Drawing.Size(51, 17);
            this.tsslCompID.Text = "CompID";
            // 
            // tsslEID
            // 
            this.tsslEID.Name = "tsslEID";
            this.tsslEID.Size = new System.Drawing.Size(24, 17);
            this.tsslEID.Text = "EID";
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 242);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlCurrency);
            this.MaximizeBox = false;
            this.Name = "frmCurrency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency";
            this.Load += new System.EventHandler(this.frmCurrency_Load);
            this.pnlCurrency.ResumeLayout(false);
            this.gpbBasicInfo.ResumeLayout(false);
            this.gpbBasicInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCurrency;
        private System.Windows.Forms.GroupBox gpbBasicInfo;
        private System.Windows.Forms.Label lblCurrencyCode;
        private System.Windows.Forms.TextBox txtCurrencyCode;
        private System.Windows.Forms.Label lblCurrencyName;
        private System.Windows.Forms.TextBox txtCurrencyName;
        private System.Windows.Forms.GroupBox groupBox1;
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


    }
}