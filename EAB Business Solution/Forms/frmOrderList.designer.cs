namespace EAB_Business_Solution.Forms
{
    partial class frmOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlOrderList = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpbSalesInfo = new System.Windows.Forms.GroupBox();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnlOrderList.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpbSalesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderList
            // 
            this.pnlOrderList.Controls.Add(this.tabControl1);
            this.pnlOrderList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlOrderList.Location = new System.Drawing.Point(2, -2);
            this.pnlOrderList.Name = "pnlOrderList";
            this.pnlOrderList.Size = new System.Drawing.Size(1358, 715);
            this.pnlOrderList.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFinish);
            this.groupBox2.Location = new System.Drawing.Point(1154, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 86);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(6, 21);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(123, 51);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "&Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(1154, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(7, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 51);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(6, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 51);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(6, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 51);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gpbSalesInfo);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1320, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gpbSalesInfo
            // 
            this.gpbSalesInfo.Controls.Add(this.dgvOrderList);
            this.gpbSalesInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSalesInfo.Location = new System.Drawing.Point(6, 6);
            this.gpbSalesInfo.Name = "gpbSalesInfo";
            this.gpbSalesInfo.Size = new System.Drawing.Size(1128, 650);
            this.gpbSalesInfo.TabIndex = 1;
            this.gpbSalesInfo.TabStop = false;
            this.gpbSalesInfo.Text = "Sales Infomation";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tablename,
            this.productname,
            this.quantity,
            this.SalesID,
            this.ProductID});
            this.dgvOrderList.Location = new System.Drawing.Point(6, 20);
            this.dgvOrderList.Name = "dgvOrderList";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrderList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderList.RowTemplate.Height = 40;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(1116, 624);
            this.dgvOrderList.TabIndex = 7;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // SalesID
            // 
            this.SalesID.HeaderText = "Sales ID";
            this.SalesID.Name = "SalesID";
            this.SalesID.Visible = false;
            // 
            // quantity
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.Width = 150;
            // 
            // productname
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.DefaultCellStyle = dataGridViewCellStyle3;
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 400;
            // 
            // tablename
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablename.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablename.HeaderText = "Table Name";
            this.tablename.Name = "tablename";
            this.tablename.ReadOnly = true;
            this.tablename.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1328, 689);
            this.tabControl1.TabIndex = 13;
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 713);
            this.Controls.Add(this.pnlOrderList);
            this.MaximizeBox = false;
            this.Name = "frmOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            this.pnlOrderList.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpbSalesInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gpbSalesInfo;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablename;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
    }
}