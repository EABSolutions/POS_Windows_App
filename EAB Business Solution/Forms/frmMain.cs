using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Reflection;
using System.Configuration;

namespace EAB_Business_Solution.Forms
{
    public partial class frmMain : Form
    {
        Class.clsMethods M = new Class.clsMethods();
        Class.clsMain Ma = new Class.clsMain();
        DataTable dt = new DataTable();
        SqlConnection con;
        SqlCommand cmd; 
        SqlDataAdapter adp = new SqlDataAdapter();
        Class.clsSqlDataModules strcon = new Class.clsSqlDataModules(Application.StartupPath);

        public string PositionID;
        

        public frmMain()
        {
           
            InitializeComponent();
            Loading();
            this.FormClosing += new FormClosingEventHandler(frmMain_FormClosing);
        }

        #region EIDAccess
        public string EIDAccess
        {
            get { return this.tsslEID.Text; }
            set { this.tsslEID.Text = value; }
        }

        public string CompIDAccess
        {
            get { return this.tsslCompID.Text; }
            set { this.tsslCompID.Text = value; }
        }
        #endregion

        #region Methods

        #region Loading
        private void Loading()
        {
            gpbLogin.Visible = true;
            mnusMain.Visible = false;
            ssCompany.Visible = false;
            txtUsername.Focus();
        }
        #endregion


        #region Dataassign
        private void dataassignInsert()
        {
            DataTable dtLHID = new DataTable();
            dtLHID = Ma.AutoID_LoginHistory();
            Ma.LHID = Convert.ToInt32(dtLHID.Rows[0][0].ToString());
            Ma.Username = txtUsername.Text.ToString();
            Ma.LoginTime = DateTime.Now;
        }

        private void dataassignUpdate()
        {
            Ma.LHID = Convert.ToInt32(tsslLHID.Text.Trim());
            Ma.LogoutTime = DateTime.Now;
        }
        #endregion

   
        #region Login

        #region Login
        private void Login()
        {
            if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill Username and Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() != "")
            {
                MessageBox.Show("Please fill Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if (txtUsername.Text.Trim() == "admin" && txtPassword.Text.Trim() != "Adm1n")
            {
                MessageBox.Show("Inorrect Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if (txtUsername.Text.Trim() == "admin" && txtPassword.Text.Trim() == "Adm1n")
            {
                gpbLogin.Visible = false;
                mnusMain.Visible = true;
                msConnecttoDatabase.Visible = true;
                msLogOut.Visible = true;
                ssCompany.Visible = true;
                tsslCompID.Visible = false;
                tsslEID.Visible = false;
                tsslLHID.Visible = false;
                tsslUser.Text = "Admin";
                tsslCompany.Text = "EAB HQ";
            }
            else if (txtUsername.Text.Trim() != "admin")
            {
                Ma.Username = txtUsername.Text.Trim();
                Ma.Password = txtPassword.Text.Trim();
                dt= new DataTable();
                dt = Ma.Login();
                if ( dt.Rows.Count == 1)
                {
                    DataTable dtLHistory = new DataTable();
                    Ma.Username = txtUsername.Text.Trim();
                    dtLHistory = Ma.Check_Login();
                    if (dtLHistory.Rows.Count >= 1)
                    {
                        MessageBox.Show("User has already login into the system! Please Logout first from other device!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                    }
                    else
                    {
                        dataassignInsert();
                        Ma.Ins_LoginHistory();
                        gpbLogin.Visible = false;
                        mnusMain.Visible = true;
                        msConnecttoDatabase.Visible = false;
                        msLogOut.Visible = true;
                        ssCompany.Visible = true;
                        tsslCompID.Visible = false;
                        tsslEID.Visible = false;
                        tsslLHID.Visible = false;
                        tsslCompany.Text =  dt.Rows[0][6].ToString();
                        tsslUser.Text = dt.Rows[0][4].ToString();
                        tsslCompID.Text = dt.Rows[0][5].ToString();
                        tsslEID.Text = dt.Rows[0][3].ToString();
                        tsslLHID.Text = Ma.LHID.ToString();
                        PositionID = dt.Rows[0][2].ToString();
                        menu();
                    }
                }
                else 
                {
                    MessageBox.Show("Inorrect Username & Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                }
            }
        }

        public void menu()
        {
            this.IsMdiContainer = true;

            //Creating object of MenuStrip class
            //MenuStrip 
            //menuStrip1 = new MenuStrip();

            //Placing the control to the Form
            this.Controls.Add(mnusMain);
            con = new SqlConnection(strcon.ConnectionString());
            String Sequel = "SELECT mp.ParentCode, mp.ParentDescription FROM Menu_Parent mp, User_Menu um WHERE mp.ParentCode = um.MenuID AND um.PositionID = '" + PositionID.ToString() + "' Order by mp.ParentCode ASC";
            SqlDataAdapter da = new SqlDataAdapter(Sequel, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ToolStripMenuItem MnuStripItem = new ToolStripMenuItem(dr["ParentDescription"].ToString());
                SubMenu(MnuStripItem, dr["ParentCode"].ToString());

                mnusMain.Items.Add(MnuStripItem);
            }
            // The Form.MainMenuStrip property determines the merge target.
            this.MainMenuStrip = mnusMain;
        }

        public void SubMenu(ToolStripMenuItem mnu, string submenu)
        {
            String Seqchild = "SELECT smt.MenuCode,smt.MenuDescription FROM Menu_Sub smt, Menu_Parent pm, User_Menu um WHERE smt.ParentCode = pm.ParentCode AND um.MenuID = smt.MenuCode AND um.PositionID = '" + PositionID.ToString() + "' and smt.ParentCode = '" + submenu + "' Order by smt.MenuDescription DESC";
            SqlDataAdapter dachildmnu = new SqlDataAdapter(Seqchild, con);
            DataTable dtchild = new DataTable();
            dachildmnu.Fill(dtchild);

            foreach (DataRow dr in dtchild.Rows)
            {
                ToolStripMenuItem SSMenu = new ToolStripMenuItem(dr["MenuDescription"].ToString(), null, new EventHandler(ChildClick));
                mnu.DropDownItems.Add(SSMenu);
                DetailMenu(SSMenu, dr["MenuCode"].ToString());
            }
        }

        private void ChildClick(object sender, EventArgs e)
        {
            String Seqtx = "SELECT FormName FROM Menu_Sub WHERE MenuDescription='" + sender.ToString() + "'";
            SqlDataAdapter datransaction = new SqlDataAdapter(Seqtx, con);
            DataTable dtransaction = new DataTable();
            datransaction.Fill(dtransaction);

            Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);
            foreach (Type type in frmAssembly.GetTypes())
            {
                
                if (type.BaseType == typeof(Form))
                {
                    if (type.Name == dtransaction.Rows[0][0].ToString())
                    {
                        if (dtransaction.Rows[0][0].ToString() == "frmDepartment")
                        {
                            frmDepartment D = new frmDepartment();
                            D.EID = tsslEID.Text.ToString();
                            D.CompID = tsslCompID.Text.ToString();
                            D.ShowDialog();
                            D.EID = tsslEID.Text.ToString();
                            D.CompID = tsslCompID.Text.ToString();
                          
                        }
                        else if (dtransaction.Rows[0][0].ToString() == "frmProductHirachy")
                        {
                            frmProductHirachy ph = new frmProductHirachy();
                            ph.EID = tsslEID.Text.ToString();
                            ph.CompID = tsslCompID.Text.ToString();
                            ph.ShowDialog();
                            ph.EID = tsslEID.Text.ToString();
                            ph.CompID = tsslCompID.Text.ToString();

                        }
                        
                        else if (dtransaction.Rows[0][0].ToString() == "FrmTable")
                        {
                            FrmTable tab = new FrmTable();
                            tab.EID = tsslEID.Text.ToString();
                            tab.CompID = tsslCompID.Text.ToString();
                            tab.ShowDialog();
                            tab.EID = tsslEID.Text.ToString();
                            tab.CompID = tsslCompID.Text.ToString();

                        }
                        else if (dtransaction.Rows[0][0].ToString() == "frmsupplier")
                        {
                            frmsupplier sup = new frmsupplier();
                            sup.EID = tsslEID.Text.ToString();
                            sup.CompID = tsslCompID.Text.ToString();
                            sup.ShowDialog();
                            sup.EID = tsslEID.Text.ToString();
                            sup.CompID = tsslCompID.Text.ToString();

                        }
                        else if (dtransaction.Rows[0][0].ToString() == "frmCustomer")
                        {
                            frmCustomer c = new frmCustomer();
                            c.EID = tsslEID.Text.ToString();
                            c.CompID = tsslCompID.Text.ToString();
                            c.ShowDialog();
                            c.EID = tsslEID.Text.ToString();
                            c.CompID = tsslCompID.Text.ToString();

                        }
                        else
                        {

                            Form frmShow = (Form)frmAssembly.CreateInstance(type.ToString());

                            // then we  close all of the child Forms with  simple below code

                            foreach (Form form in this.MdiChildren)
                            {
                                form.Close();
                            }

                            frmShow.ShowDialog();
                        }
                    }
                }
            }
        }

        public void DetailMenu(ToolStripMenuItem tsm, string detailmenu)
        {
            String Seqdetail = "SELECT dm.DMenuCode, dm.DMenuDescription, dm.MenuCode FROM Menu_Sub smt, Menu_Detail dm , User_Menu um WHERE smt.MenuCode = dm.MenuCode and um.MenuID = dm.DMenuCode AND um.PositionID = '" + PositionID.ToString() + "' and dm.MenuCode='" + detailmenu + "' Order by dm.DMenuDescription ASC";
            SqlDataAdapter dadetailmnu = new SqlDataAdapter(Seqdetail, con);
            DataTable dtdetail = new DataTable();
            dadetailmnu.Fill(dtdetail);

            foreach (DataRow dr in dtdetail.Rows)
            {
                ToolStripMenuItem DMenu = new ToolStripMenuItem(dr["DMenuDescription"].ToString(), null, new EventHandler(DetailClick));
                tsm.DropDownItems.Add(DMenu);
            }
        }

        private void DetailClick(object sender, EventArgs e)
        {
            String Seqtx = "SELECT DFormName FROM Menu_Detail WHERE DMenuDescription='" + sender.ToString() + "'";
            SqlDataAdapter datransaction = new SqlDataAdapter(Seqtx, con);
            DataTable dtransaction = new DataTable();
            datransaction.Fill(dtransaction);

            Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);
            foreach (Type type in frmAssembly.GetTypes())
            {
               
                if (type.BaseType == typeof(Form))
                {
                    if (type.Name == dtransaction.Rows[0][0].ToString())
                    {
                        if (dtransaction.Rows[0][0].ToString() == "frmPO")
                        {
                            frmPO PO = new frmPO();
                            PO.EID = tsslEID.Text.ToString();
                            PO.CompID = tsslCompID.Text.ToString();
                            PO.ShowDialog();
                            PO.EID = tsslEID.Text.ToString();
                            PO.CompID = tsslCompID.Text.ToString();

                        }
                        else if (dtransaction.Rows[0][0].ToString() == "frmSalesOrder")
                        {
                            frmSalesOrder SO = new frmSalesOrder();
                            SO.EID = tsslEID.Text.ToString();
                            SO.CompID = tsslCompID.Text.ToString();
                            SO.ShowDialog();
                            SO.EID = tsslEID.Text.ToString();
                            SO.CompID = tsslCompID.Text.ToString();

                        }
                        else if (dtransaction.Rows[0][0].ToString() == "frmPOS")
                        {
                            frmPOS pos = new frmPOS();
                            pos.EID = tsslEID.Text.ToString();
                            //pos.CompID = tsslCompID.Text.ToString();
                            pos.ShowDialog();
                            pos.EID = tsslEID.Text.ToString();
                            //pos.CompID = tsslCompID.Text.ToString();

                        }
                        else if (dtransaction.Rows[0][0].ToString() == "frmUOM")
                        {
                            frmUOM uom = new frmUOM();
                            uom.EID = tsslEID.Text.ToString();
                            uom.CompID = tsslCompID.Text.ToString();
                            uom.ShowDialog();
                            uom.EID = tsslEID.Text.ToString();
                            uom.CompID = tsslCompID.Text.ToString();

                        }
                        else
                        {

                            Form frmShow = (Form)frmAssembly.CreateInstance(type.ToString());
                            // then we  close all of the child Forms with  simple below code

                            foreach (Form form in this.MdiChildren)
                            {
                                form.Close();
                            }
                            frmShow.ShowDialog();
                        }
                    }
                }
            }

        }

        #endregion


        #endregion


        #endregion

        private void databaseConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmDatabaseConnection dc = new Forms.frmDatabaseConnection();
            dc.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void msLogOut_Click(object sender, EventArgs e)
        {
            if (tsslUser.Text == "Admin")
            {
                Loading();
                M.TextBox_Clear(txtUsername, txtPassword);
                txtUsername.Focus();
            }
            else
            {
                dataassignUpdate();
                Ma.UPD_LoginHistory();
                var firstitem = mnusMain.Items[0];
                mnusMain.Items.Clear();
                mnusMain.Items.Add(firstitem);
                Loading();
                M.TextBox_Clear(txtUsername, txtPassword);
                txtUsername.Focus();
            }
        }

        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	    {
	    DialogResult dr = MessageBox.Show("Are you sure you want to exit application?","Exit", MessageBoxButtons.YesNo);
        if (dr == DialogResult.Yes)
        {
            if (tsslUser.Text == "Admin" || ssCompany.Visible == false)
            {
                e.Cancel = false;
            }
            else
            {
                dataassignUpdate();
                Ma.UPD_LoginHistory();
                e.Cancel = false;
            }
        }
        else
        {
            e.Cancel = true;
            
        }
            
	}

        private void msConnecttoDatabase_Click(object sender, EventArgs e)
        {
            Forms.frmDatabaseConnection dbc = new Forms.frmDatabaseConnection();
            dbc.ShowDialog();
        }
    }
}
