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
    class clsUOM

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

        string _UOMID;
        public string UOMID
        {
            get { return _UOMID; }
            set { _UOMID = value; }
        }

        string _UOMName;
        public string UOMName
        {
            get { return _UOMName; }
            set { _UOMName = value; }
        }

        string _UOMDescription;
        public string UOMDescription
        {
            get { return _UOMDescription; }
            set { _UOMDescription = value; }
        }

       
        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion

        #region "Insert"
        public void Ins_UOM()
        {
            try
            {
                cmd = new SqlCommand("INS_UOM", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UOMID", UOMID);
                cmd.Parameters.AddWithValue("@UOMName", UOMName);
                cmd.Parameters.AddWithValue("@UOMDescription", UOMDescription);
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
        public void Upd_UOM()
        {
            try
            {
                cmd = new SqlCommand("UPD_UOM", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UOMID", UOMID);
                cmd.Parameters.AddWithValue("@UOMName", UOMName);
                cmd.Parameters.AddWithValue("@UOMDescription", UOMDescription);
               // cmd.Parameters.AddWithValue("@CreatedID", CreatedEID);
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
        public void Del_UOM()
        {
            try
            {
                cmd = new SqlCommand("DEL_UOM", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UOMID", UOMID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        public DataTable AutoID_UOM()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_UOM", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable SearchUOM()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_UOM", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UOMID", UOMID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "Call"
        public DataTable CallUOM()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_UOM", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }


        public DataTable CallUOMIDbyName()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_UOMIDbyName", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UOMName", UOMName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion
    }

}
