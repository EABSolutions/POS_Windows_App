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
    class clsProductFamily
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

        string _PFID;
        public string PFID
        {
            get { return _PFID; }
            set { _PFID = value; }
        }

        string _PFName;
        public string PFName
        {
            get { return _PFName; }
            set { _PFName = value; }
        }

        string _PFDescription;
        public string PFDescription
        {
            get { return _PFDescription; }
            set { _PFDescription = value; }
        }

        string _CPFID;
        public string CPFID
        {
            get { return _CPFID; }
            set { _CPFID = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion


        #region "Insert"
        public void Ins_PF()
        {
            try
            {
                cmd = new SqlCommand("INS_Product_Family", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PFID", PFID);
                cmd.Parameters.AddWithValue("@PFName", PFName);
                cmd.Parameters.AddWithValue("@PFDescription", PFDescription);
                cmd.Parameters.AddWithValue("@CPFID", CPFID);
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
        public void Upd_PF()
        {
            try
            {
                cmd = new SqlCommand("UPD_Product_Family", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PFID", PFID);
                cmd.Parameters.AddWithValue("@PFName", PFName);
                cmd.Parameters.AddWithValue("@PFDescription", PFDescription);
                cmd.Parameters.AddWithValue("@CPFID", CPFID);
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
        public void Del_PF()
        {
            try
            {
                cmd = new SqlCommand("DEL_Product_Family", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PFID", PFID);
                cmd.Parameters.AddWithValue("@CPFID", CPFID);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        public DataTable AutoID_PF()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Product_Family", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable Search_PF()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Product_Family", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PFID", PFID);
            cmd.Parameters.AddWithValue("@CPFID", CPFID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "Call"
        public DataTable Call_PF()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Product_Family", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable CallPFIDbyName()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_ProductFamilyIDbyName", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PFName", PFName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion

    }
}
