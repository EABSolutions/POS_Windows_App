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
    class clsBrand
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

        string _BID;
        public string BID
        {
            get { return _BID; }
            set { _BID = value; }
        }

        string _BName;
        public string BName
        {
            get { return _BName; }
            set { _BName = value; }
        }

        string _BDescription;
        public string BDescription
        {
            get { return _BDescription; }
            set { _BDescription = value; }
        }

        string _MID;
        public string MID
        {
            get { return _MID; }
            set { _MID = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion


        #region "Insert"
        public void Ins_Brand()
        {
            try
            {
                cmd = new SqlCommand("INS_Brand", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BID", BID);
                cmd.Parameters.AddWithValue("@BName", BName);
                cmd.Parameters.AddWithValue("@BDescription", BDescription);
                cmd.Parameters.AddWithValue("@MID", MID);
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
        public void Upd_Brand()
        {
            try
            {
                cmd = new SqlCommand("UPD_Brand", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BID", BID);
                cmd.Parameters.AddWithValue("@BName", BName);
                cmd.Parameters.AddWithValue("@BDescription", BDescription);
                cmd.Parameters.AddWithValue("@MID", MID);
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
        public void Del_Brand()
        {
            try
            {
                cmd = new SqlCommand("DEL_Brand", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BID", BID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion


        #region "AutoID"
        public DataTable AutoID_Brand()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Brand", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region "Search"
        public DataTable Search_Brand()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Brand", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BID", BID);
            cmd.Parameters.AddWithValue("@MID", MID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region "Call"
        public DataTable Call_Brand()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Brand", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable CallBrandIDbyName()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_BrandIDbyName", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BName", BName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
