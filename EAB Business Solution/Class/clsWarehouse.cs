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
    class clsWarehouse
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

        string _WHID;
        public string WHID
        {
            get { return _WHID; }
            set { _WHID = value; }
        }

        string _WHName;
        public string WHName
        {
            get { return _WHName; }
            set { _WHName = value; }
        }

        string _WHHomeNo;
        public string WHHomeNo
        {
            get { return _WHHomeNo; }
            set { _WHHomeNo = value; }
        }

        string _WHStreet;
        public string WHStreet
        {
            get { return _WHStreet; }
            set { _WHStreet = value; }
        }

        string _WHTownship;
        public string WHTownship
        {
            get { return _WHTownship; }
            set { _WHTownship = value; }
        }

        string _WHCity;
        public string WHCity
        {
            get { return _WHCity; }
            set { _WHCity = value; }
        }

        string _WHCountry;
        public string WHCountry
        {
            get { return _WHCountry; }
            set { _WHCountry = value; }
        }

        int _WHContactNo;
        public int WHContactNo
        {
            get { return _WHContactNo; }
            set { _WHContactNo = value; }
        }

        int _WHFax;
        public int WHFax
        {
            get { return _WHFax; }
            set { _WHFax = value; }
        }

        string _WHEmail;
        public string WHEmail
        {
            get { return _WHEmail; }
            set { _WHEmail = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion

        #region "Insert"
        public void Ins_Warehouse()
        {
            try
            {
                cmd = new SqlCommand("INS_Warehouse", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@WHName", WHName);
                cmd.Parameters.AddWithValue("@WHHomeNo", WHHomeNo);
                cmd.Parameters.AddWithValue("@WHStreet", WHStreet);
                cmd.Parameters.AddWithValue("@WHTownship", WHTownship);
                cmd.Parameters.AddWithValue("@WHCity", WHCity);
                cmd.Parameters.AddWithValue("@WHCountry", WHCountry);
                cmd.Parameters.AddWithValue("@WHContactNo", WHContactNo);
                cmd.Parameters.AddWithValue("@WHFax", WHFax);
                cmd.Parameters.AddWithValue("@WHEmail", WHEmail);
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
        public void Upd_Warehouse()
        {
            try
            {
                cmd = new SqlCommand("Upd_Warehouse", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@WHName", WHName);
                cmd.Parameters.AddWithValue("@WHHomeNo", WHHomeNo);
                cmd.Parameters.AddWithValue("@WHStreet", WHStreet);
                cmd.Parameters.AddWithValue("@WHTownship", WHTownship);
                cmd.Parameters.AddWithValue("@WHCity", WHCity);
                cmd.Parameters.AddWithValue("@WHCountry", WHCountry);
                cmd.Parameters.AddWithValue("@WHContactNo", WHContactNo);
                cmd.Parameters.AddWithValue("@WHFax", WHFax);
                cmd.Parameters.AddWithValue("@WHEmail", WHEmail);
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
        public void Del_Warehouse()
        {
            try
            {
                cmd = new SqlCommand("Del_Warehouse", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        private DataTable AutoID_Warehouse()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Warehouse", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        //#region "Search"
        //public DataTable SearchWarhouse()
        //{

        //    dt = new DataTable();
        //    da = new SqlDataAdapter();
        //    cmd = new SqlCommand("SEARCH_Warehouse", new SqlConnection(sql.ConnectionString()));
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@DeptID", DeptID);
        //    da.SelectCommand = cmd;
        //    da.Fill(dt);
        //    return dt;


        //}
        //#endregion

        #region "Call"
        public DataTable CallWarehouse()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Warehouse", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "Call"
        public DataTable CallWarehouseID()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Warehouse_ID", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@WHName", WHName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion
    }
}
