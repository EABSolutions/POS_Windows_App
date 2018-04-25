using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace EAB_Business_Solution.Forms
{
    public partial class frmDatabaseConnection : Form
    {
        private DataSet login = new DataSet();

        Class.clsSqlDataModules sql = new Class.clsSqlDataModules(string.Concat(Application.StartupPath));
        Class.clsMethods M = new Class.clsMethods();
        public string server, db;

        public frmDatabaseConnection()
        {
            InitializeComponent();
            txtServer.Text = sql.Server;
            txtDatabase.Text = sql.DB;
            txtUsername.Text = sql.ID;
        }

        private bool Validation()
        {
            if (txtServer.Text == "")
            {
                MessageBox.Show("You need to enter Server name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServer.Focus();
                return false;
            }
            else if (txtDatabase.Text == "")
            {
                MessageBox.Show("You need to enter Database name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDatabase.Focus();
                return false;
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("You need to enter User ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("You need to enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Connect()
        {
            using (FileStream read = new FileStream(Application.StartupPath + "\\Login.bin", FileMode.Open))
            {
                BinaryFormatter rfmt = new BinaryFormatter();
                login = (DataSet)rfmt.Deserialize(read);
                login.Tables[0].Clear();
                login.Tables[0].Rows.Add(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);


            }
            login.RemotingFormat = SerializationFormat.Binary;
            File.Delete(Application.StartupPath + "\\Login.bin");
            using (FileStream write = new FileStream(Application.StartupPath + "\\Login.bin", FileMode.Create))
            {
                BinaryFormatter wfmt = new BinaryFormatter();
                wfmt.Serialize(write, login);

            }


        }


        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (Validation() == true)
            {
                try
                {
                    SqlConnection cn = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUsername.Text + " ;Password=" + txtPassword.Text);

                    cn.Open();
                    cn.Close();

                    MessageBox.Show("Test Connection Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Connection!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                server = txtServer.Text;
                db = txtDatabase.Text;
                Connect();
                if (MessageBox.Show("Connect Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            M.TextBox_Clear(txtDatabase, txtPassword, txtServer, txtUsername);
        }


    }
}
