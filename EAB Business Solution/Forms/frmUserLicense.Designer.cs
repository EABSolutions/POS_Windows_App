namespace EAB_Business_Solution.Forms
{
    partial class frmUserLicense
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlUserLicense = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.gpbUserInfo = new System.Windows.Forms.GroupBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtMembershipID = new System.Windows.Forms.TextBox();
            this.lblEmployeeIDShow = new System.Windows.Forms.Label();
            this.lblNameShow = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNRCNoShow = new System.Windows.Forms.Label();
            this.lblNRCNo = new System.Windows.Forms.Label();
            this.lblDepartmentShow = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPositionShow = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.gpbLicenseNumber = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.pnlUserLicense.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbUserInfo.SuspendLayout();
            this.gpbLicenseNumber.SuspendLayout();
            this.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 23);
            this.statusStrip1.TabIndex = 62;
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
            // pnlUserLicense
            // 
            this.pnlUserLicense.Controls.Add(this.gpbLicenseNumber);
            this.pnlUserLicense.Controls.Add(this.groupBox1);
            this.pnlUserLicense.Controls.Add(this.gpbUserInfo);
            this.pnlUserLicense.Location = new System.Drawing.Point(2, 4);
            this.pnlUserLicense.Name = "pnlUserLicense";
            this.pnlUserLicense.Size = new System.Drawing.Size(462, 468);
            this.pnlUserLicense.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnActivate);
            this.groupBox1.Location = new System.Drawing.Point(108, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(19, 16);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(81, 31);
            this.btnActivate.TabIndex = 15;
            this.btnActivate.Text = "Acti&vate";
            this.btnActivate.UseVisualStyleBackColor = true;
            // 
            // gpbUserInfo
            // 
            this.gpbUserInfo.Controls.Add(this.lblPositionShow);
            this.gpbUserInfo.Controls.Add(this.lblPosition);
            this.gpbUserInfo.Controls.Add(this.lblDepartmentShow);
            this.gpbUserInfo.Controls.Add(this.lblDepartment);
            this.gpbUserInfo.Controls.Add(this.lblNRCNoShow);
            this.gpbUserInfo.Controls.Add(this.lblNRCNo);
            this.gpbUserInfo.Controls.Add(this.lblNameShow);
            this.gpbUserInfo.Controls.Add(this.lblName);
            this.gpbUserInfo.Controls.Add(this.lblEmployeeIDShow);
            this.gpbUserInfo.Controls.Add(this.lblEmployeeID);
            this.gpbUserInfo.Controls.Add(this.lblUsername);
            this.gpbUserInfo.Controls.Add(this.txtMembershipID);
            this.gpbUserInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUserInfo.Location = new System.Drawing.Point(82, 20);
            this.gpbUserInfo.Name = "gpbUserInfo";
            this.gpbUserInfo.Size = new System.Drawing.Size(312, 281);
            this.gpbUserInfo.TabIndex = 3;
            this.gpbUserInfo.TabStop = false;
            this.gpbUserInfo.Text = "User Information";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(13, 79);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(87, 14);
            this.lblEmployeeID.TabIndex = 28;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(13, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 14);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "Username";
            // 
            // txtMembershipID
            // 
            this.txtMembershipID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembershipID.Location = new System.Drawing.Point(98, 30);
            this.txtMembershipID.Name = "txtMembershipID";
            this.txtMembershipID.Size = new System.Drawing.Size(191, 23);
            this.txtMembershipID.TabIndex = 1;
            // 
            // lblEmployeeIDShow
            // 
            this.lblEmployeeIDShow.AutoSize = true;
            this.lblEmployeeIDShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIDShow.Location = new System.Drawing.Point(116, 79);
            this.lblEmployeeIDShow.Name = "lblEmployeeIDShow";
            this.lblEmployeeIDShow.Size = new System.Drawing.Size(83, 14);
            this.lblEmployeeIDShow.TabIndex = 29;
            this.lblEmployeeIDShow.Text = "Employee ID";
            // 
            // lblNameShow
            // 
            this.lblNameShow.AutoSize = true;
            this.lblNameShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameShow.Location = new System.Drawing.Point(116, 114);
            this.lblNameShow.Name = "lblNameShow";
            this.lblNameShow.Size = new System.Drawing.Size(40, 14);
            this.lblNameShow.TabIndex = 31;
            this.lblNameShow.Text = "Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 14);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name:";
            // 
            // lblNRCNoShow
            // 
            this.lblNRCNoShow.AutoSize = true;
            this.lblNRCNoShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNoShow.Location = new System.Drawing.Point(116, 151);
            this.lblNRCNoShow.Name = "lblNRCNoShow";
            this.lblNRCNoShow.Size = new System.Drawing.Size(52, 14);
            this.lblNRCNoShow.TabIndex = 33;
            this.lblNRCNoShow.Text = "NRC No";
            // 
            // lblNRCNo
            // 
            this.lblNRCNo.AutoSize = true;
            this.lblNRCNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNo.Location = new System.Drawing.Point(13, 151);
            this.lblNRCNo.Name = "lblNRCNo";
            this.lblNRCNo.Size = new System.Drawing.Size(56, 14);
            this.lblNRCNo.TabIndex = 32;
            this.lblNRCNo.Text = "NRC No:";
            // 
            // lblDepartmentShow
            // 
            this.lblDepartmentShow.AutoSize = true;
            this.lblDepartmentShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentShow.Location = new System.Drawing.Point(116, 219);
            this.lblDepartmentShow.Name = "lblDepartmentShow";
            this.lblDepartmentShow.Size = new System.Drawing.Size(75, 14);
            this.lblDepartmentShow.TabIndex = 35;
            this.lblDepartmentShow.Text = "Deparment";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(13, 219);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(85, 14);
            this.lblDepartment.TabIndex = 34;
            this.lblDepartment.Text = "Department:";
            // 
            // lblPositionShow
            // 
            this.lblPositionShow.AutoSize = true;
            this.lblPositionShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionShow.Location = new System.Drawing.Point(116, 186);
            this.lblPositionShow.Name = "lblPositionShow";
            this.lblPositionShow.Size = new System.Drawing.Size(57, 14);
            this.lblPositionShow.TabIndex = 37;
            this.lblPositionShow.Text = "Position";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(13, 186);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 14);
            this.lblPosition.TabIndex = 36;
            this.lblPosition.Text = "Position:";
            // 
            // gpbLicenseNumber
            // 
            this.gpbLicenseNumber.Controls.Add(this.textBox5);
            this.gpbLicenseNumber.Controls.Add(this.textBox4);
            this.gpbLicenseNumber.Controls.Add(this.textBox3);
            this.gpbLicenseNumber.Controls.Add(this.textBox2);
            this.gpbLicenseNumber.Controls.Add(this.textBox1);
            this.gpbLicenseNumber.Location = new System.Drawing.Point(39, 318);
            this.gpbLicenseNumber.Name = "gpbLicenseNumber";
            this.gpbLicenseNumber.Size = new System.Drawing.Size(387, 57);
            this.gpbLicenseNumber.TabIndex = 19;
            this.gpbLicenseNumber.TabStop = false;
            this.gpbLicenseNumber.Text = "License Number";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 23);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(95, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 23);
            this.textBox2.TabIndex = 39;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(166, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 23);
            this.textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(235, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 23);
            this.textBox4.TabIndex = 41;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(308, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 23);
            this.textBox5.TabIndex = 42;
            // 
            // frmUserLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 496);
            this.Controls.Add(this.pnlUserLicense);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "frmUserLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User License Administration";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlUserLicense.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpbUserInfo.ResumeLayout(false);
            this.gpbUserInfo.PerformLayout();
            this.gpbLicenseNumber.ResumeLayout(false);
            this.gpbLicenseNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.Panel pnlUserLicense;
        private System.Windows.Forms.GroupBox gpbLicenseNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.GroupBox gpbUserInfo;
        private System.Windows.Forms.Label lblPositionShow;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDepartmentShow;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblNRCNoShow;
        private System.Windows.Forms.Label lblNRCNo;
        private System.Windows.Forms.Label lblNameShow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmployeeIDShow;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtMembershipID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}