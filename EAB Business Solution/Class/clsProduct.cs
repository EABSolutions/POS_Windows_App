using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EAB_Business_Solution.Class
{
    class clsProduct
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        clsSqlDataModules sql = new clsSqlDataModules(Application.StartupPath);

        #region "Property"

        bool _IsEdit;
        public bool IsEdit
        {
            get { return _IsEdit; }
            set { _IsEdit = value; }
        }

        string _PID;
        public string PID
        {
            get { return _PID; }
            set { _PID = value; }
        }

        string _PName;
        public string PName
        {
            get { return _PName; }
            set { _PName = value; }
        }

        string _PDescription;
        public string PDescription
        {
            get { return _PDescription; }
            set { _PDescription = value; }
        }

        string _PLID;
        public string PLID
        {
            get { return _PLID; }
            set { _PLID = value; }
        }

        string _BID;
        public string BID
        {
            get { return _BID; }
            set { _BID = value; }
        }
        
        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion

        #region "Insert"
        public void Ins_Product()
        {
            try
            {
                cmd = new SqlCommand("INS_Product", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@PName", PName);
                cmd.Parameters.AddWithValue("@PDescription", PDescription);
                cmd.Parameters.AddWithValue("@PLID", PLID);
                cmd.Parameters.AddWithValue("@BID", BID);
                cmd.Parameters.AddWithValue("@CreatedEID", CreatedEID);
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
        public void Upd_Product()
        {
            try
            {
                cmd = new SqlCommand("UPD_Product", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@PName", PName);
                cmd.Parameters.AddWithValue("@PDescription", PDescription);
                cmd.Parameters.AddWithValue("@PLID", PLID);
                cmd.Parameters.AddWithValue("@BID", BID);
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
        public void Del_Product()
        {
            try
            {
                cmd = new SqlCommand("DEL_Product", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        public DataTable AutoID_Product()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Product", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable SearchProduct()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Product", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PID", PID);
            cmd.Parameters.AddWithValue("@PLID", PLID);
            cmd.Parameters.AddWithValue("@BID", BID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "Call"
        public DataTable CallProduct()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Product", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable CallProductwithNoPara()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Product_Nopara", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable CallProductbyPID()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_ProductbyPID", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PID", PID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable CallProductForPO()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_ProductforPO", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable CallProductForPL()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_ProductbyPLID", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PLID", PLID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
