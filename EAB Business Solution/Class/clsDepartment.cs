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
    class clsDepartment
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

        string _DeptID;
        public string DeptID
        {
            get { return _DeptID; }
            set { _DeptID = value; }
        }

        string _DeptName;
        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        string _DeptDescription;
        public string DeptDescription
        {
            get { return _DeptDescription; }
            set { _DeptDescription = value; }
        }
                
        string _CompID;
        public string CompID
        {
            get { return _CompID; }
            set { _CompID = value; }
        }
                
        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion

        #region "Insert"
        public void Ins_Department()
        {
            try
            {
                cmd = new SqlCommand("INS_Department", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptID", DeptID);
                cmd.Parameters.AddWithValue("@DeptName", DeptName);
                cmd.Parameters.AddWithValue("@DeptDescription", DeptDescription);
                cmd.Parameters.AddWithValue("@CompID", CompID);
                cmd.Parameters.AddWithValue("@CreatedID", CreatedEID);
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
        public void Upd_Department()
        {
            try
            {
                cmd = new SqlCommand("UPD_Department", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptID", DeptID);
                cmd.Parameters.AddWithValue("@DeptName", DeptName);
                cmd.Parameters.AddWithValue("@DeptDescription", DeptDescription);
                cmd.Parameters.AddWithValue("@CompID", CompID);
                cmd.Parameters.AddWithValue("@CreatedID", CreatedEID);
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
        public void Del_Department()
        {
            try
            {
                cmd = new SqlCommand("DEL_Department", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptID", DeptID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        private DataTable AutoID_Department()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Department", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable SearchDepartment()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Department", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DeptID", DeptID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "Call"
        public DataTable CallDepartment()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Department", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion
    }
}
