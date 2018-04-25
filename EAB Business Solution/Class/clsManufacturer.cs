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
    class clsManufacturer
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

        string _MID;
        public string MID
        {
            get { return _MID; }
            set { _MID = value; }
        }

        string _MName;
        public string MName
        {
            get { return _MName; }
            set { _MName = value; }
        }

        string _MCity;
        public string MCity
        {
            get { return _MCity; }
            set { _MCity = value; }
        }

        string _CountryID;
        public string CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion


        #region "Insert"
        public void Ins_Manufacturer()
        {
            try
            {
                cmd = new SqlCommand("INS_Manufacturer", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MID", MID);
                cmd.Parameters.AddWithValue("@MName", MName);
                cmd.Parameters.AddWithValue("@MCity", MCity);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);
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
        public void Upd_Manufacturer()
        {
            try
            {
                cmd = new SqlCommand("UPD_Manufacturer", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MID", MID);
                cmd.Parameters.AddWithValue("@MName", MName);
                cmd.Parameters.AddWithValue("@MCity", MCity);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);
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
        public void Del_Manufacturer()
        {
            try
            {
                cmd = new SqlCommand("DEL_Manufacturer", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MID", MID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion


        #region "AutoID"
        public DataTable AutoID_Manufacturer()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Manufacturer", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region "Search"
        public DataTable Search_Manufacturer()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Manufacturer", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MID", MID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region "Call"
        public DataTable Call_Manufacturer()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Manufacturer", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable CallManuIDbyName()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_ManufacturerIDbyName", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MName", MName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion
    }



}
