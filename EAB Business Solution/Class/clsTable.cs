using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EAB_Business_Solution.Class
{
    public class clsTable
    {
        public DataTable dt { get; set; }
        public SqlDataAdapter da { get; set; }
        public SqlCommand cmd { get; set; }
        clsSqlDataModules sql = new clsSqlDataModules(Application.StartupPath);

        #region "Property"

        bool _IsEdit;
        public bool IsEdit
        {
            get { return _IsEdit; }
            set { _IsEdit = value; }
        }

        string _TID;
        public string TID
        {
            get { return _TID; }
            set { _TID = value; }
        }

        string _TName;
        public string TName
        {
            get { return _TName; }
            set { _TName = value; }
        }

        string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        #endregion

        #region "Insert"
        public void Ins_Table()
        {
            try
            {
                cmd = new SqlCommand("INS_Table", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TID", TID);
                cmd.Parameters.AddWithValue("@TName", TName);
                cmd.Parameters.AddWithValue("@Description", Description);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region "Update"
        public void Upd_Table()
        {
            try
            {
                cmd = new SqlCommand("UPD_Table", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TID", TID);
                cmd.Parameters.AddWithValue("@TName", TName);
                cmd.Parameters.AddWithValue("Description", Description);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region "Delete"
        public void Del_Table()
        {
            try
            {
                cmd = new SqlCommand("DEL_Table", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TID", TID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        public DataTable AutoID_Table()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Table", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable SearchTable()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Table", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TID", TID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        public DataTable CallTable()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("CALL_Table", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable CallTableEdit()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("CALL_Table_POSEdit", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }
    }
}
