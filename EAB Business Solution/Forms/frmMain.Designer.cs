
namespace EAB_Business_Solution.Forms
{
    partial class frmMain
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
            this.gpbMain = new System.Windows.Forms.Panel();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.ssCompany = new System.Windows.Forms.StatusStrip();
            this.tsslabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCompID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLHID = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnusMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msConnecttoDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbMain.SuspendLayout();
            this.gpbLogin.SuspendLayout();
            this.ssCompany.SuspendLayout();
            this.mnusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMain
            // 
            this.gpbMain.Controls.Add(this.gpbLogin);
            this.gpbMain.Location = new System.Drawing.Point(0, 27);
            this.gpbMain.Name = "gpbMain";
            this.gpbMain.Size = new System.Drawing.Size(1378, 780);
            this.gpbMain.TabIndex = 2;
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.btnLogin);
            this.gpbLogin.Controls.Add(this.txtPassword);
            this.gpbLogin.Controls.Add(this.lblPassword);
            this.gpbLogin.Controls.Add(this.lblUsername);
            this.gpbLogin.Controls.Add(this.txtUsername);
            this.gpbLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLogin.Location = new System.Drawing.Point(527, 256);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(308, 150);
            this.gpbLogin.TabIndex = 0;
            this.gpbLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(20, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(269, 31);
            this.btnLogin.TabIndex = 71;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(89, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 21);
            this.txtPassword.TabIndex = 70;
            this.txtPassword.Text = "Counter123";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(17, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 14);
            this.lblPassword.TabIndex = 69;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(17, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 14);
            this.lblUsername.TabIndex = 68;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(89, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 21);
            this.txtUsername.TabIndex = 67;
            this.txtUsername.Text = "Counter";
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // ssCompany
            // 
            this.ssCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelUser,
            this.tsslCompany,
            this.toolStripStatusLabel1,
            this.tsslUser,
            this.tsslCompID,
            this.tsslEID,
            this.tsslLHID});
            this.ssCompany.Location = new System.Drawing.Point(0, 715);
            this.ssCompany.Name = "ssCompany";
            this.ssCompany.Size = new System.Drawing.Size(1352, 22);
            this.ssCompany.TabIndex = 6;
            this.ssCompany.Text = "statusStrip1";
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(30, 17);
            this.tsslUser.Text = "User";
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
            // tsslLHID
            // 
            this.tsslLHID.Name = "tsslLHID";
            this.tsslLHID.Size = new System.Drawing.Size(33, 17);
            this.tsslLHID.Text = "LHID";
            // 
            // mnusMain
            // 
            this.mnusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnusMain.Location = new System.Drawing.Point(0, 0);
            this.mnusMain.Name = "mnusMain";
            this.mnusMain.Size = new System.Drawing.Size(1352, 24);
            this.mnusMain.TabIndex = 7;
            this.mnusMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msConnecttoDatabase,
            this.msLogOut});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // msConnecttoDatabase
            // 
            this.msConnecttoDatabase.Name = "msConnecttoDatabase";
            this.msConnecttoDatabase.Size = new System.Drawing.Size(184, 22);
            this.msConnecttoDatabase.Text = "Connect to &Database";
            this.msConnecttoDatabase.Click += new System.EventHandler(this.msConnecttoDatabase_Click);
            // 
            // msLogOut
            // 
            this.msLogOut.Name = "msLogOut";
            this.msLogOut.Size = new System.Drawing.Size(184, 22);
            this.msLogOut.Text = "Log &Out";
            this.msLogOut.Click += new System.EventHandler(this.msLogOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 737);
            this.Controls.Add(this.mnusMain);
            this.Controls.Add(this.ssCompany);
            this.Controls.Add(this.gpbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EAB Business Solution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpbMain.ResumeLayout(false);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ssCompany.ResumeLayout(false);
            this.ssCompany.PerformLayout();
            this.mnusMain.ResumeLayout(false);
            this.mnusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gpbMain;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.StatusStrip ssCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompany;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCompID;
        private System.Windows.Forms.ToolStripStatusLabel tsslEID;
        private System.Windows.Forms.ToolStripStatusLabel tsslLHID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip mnusMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msConnecttoDatabase;
        private System.Windows.Forms.ToolStripMenuItem msLogOut;

    }
}