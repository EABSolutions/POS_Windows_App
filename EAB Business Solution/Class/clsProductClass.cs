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
    class clsProductClass
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

        string _PCID;
        public string PCID
        {
            get { return _PCID; }
            set { _PCID = value; }
        }

        string _PCName;
        public string PCName
        {
            get { return _PCName; }
            set { _PCName = value; }
        }

        string _PCDescription;
        public string PCDescription
        {
            get { return _PCDescription; }
            set { _PCDescription = value; }
        }

        string _PFID;
        public string PFID
        {
            get { return _PFID; }
            set { _PFID = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion


        #region "Insert"
        public void Ins_PC()
        {
            try
            {
                cmd = new SqlCommand("INS_Product_Class", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PCID", PCID);
                cmd.Parameters.AddWithValue("@PCName", PCName);
                cmd.Parameters.AddWithValue("@PCDescription", PCDescription);
                cmd.Parameters.AddWithValue("@PFID", PFID);
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
        public void Upd_PC()
        {
            try
            {
                cmd = new SqlCommand("UPD_Product_Class", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PCID", PCID);
                cmd.Parameters.AddWithValue("@PCName", PCName);
                cmd.Parameters.AddWithValue("@PCDescription", PCDescription);
                cmd.Parameters.AddWithValue("@PFID", PFID);
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
        public void Del_PC()
        {
            try
            {
                cmd = new SqlCommand("DEL_Product_Class", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PCID", PCID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion


        #region "AutoID"
        public DataTable AutoID_PC()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Product_Class", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region "Search"
        public DataTable Search_PC()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Product_Class", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PCID", PCID);
            cmd.Parameters.AddWithValue("@PFID", PFID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion


        #region "Call"
        public DataTable Call_PC()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Product_Class", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable CallPCIDbyName()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_ProductClassIDbyName", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PCName", PCName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
