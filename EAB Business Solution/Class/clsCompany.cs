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
    class clsCompany
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
        
        string _CompID;
        public string CompID
        {
            get { return _CompID; }
            set { _CompID = value; }
        }
        
        string _CompName;
        public string CompName
        {
            get { return _CompName; }
            set { _CompName = value; }
        }

        int _CompPhno1;
        public int CompPhno1
        {
            get { return _CompPhno1; }
            set { _CompPhno1 = value; }
        }
        
        int _CompPhno2;
        public int CompPhno2
        {
            get { return _CompPhno2; }
            set { _CompPhno2 = value; }
        }

        string _CompEmail;
        public string CompEmail
        {
            get { return _CompEmail; }
            set { _CompEmail = value; }
        }
        
        int _CompFax;
        public int CompFax
        {
            get { return _CompFax; }
            set { _CompFax = value; }
        }

        string _CompHomeNo;
        public string CompHomeNo
        {
            get { return _CompHomeNo; }
            set { _CompHomeNo = value; }
        }

        string _CompStreet;
        public string CompStreet
        {
            get { return _CompStreet; }
            set { _CompStreet = value; }
        }

        string _CompTownship;
        public string CompTownship
        {
            get { return _CompTownship; }
            set { _CompTownship = value; }
        }

        string _CompCity;
        public string CompCity
        {
            get { return _CompCity; }
            set { _CompCity = value; }
        }

        string _CompCountry;
        public string CompCountry
        {
            get { return _CompCountry; }
            set { _CompCountry = value; }
        }

        string _CompCEOName;
        public string CompCEOName
        {
            get { return _CompCEOName; }
            set { _CompCEOName = value; }
        }
        #endregion
        
        #region "Insert"
        public void Ins_Company()
        {
            try
            {
                cmd = new SqlCommand("INS_Company", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompID", CompID);
                cmd.Parameters.AddWithValue("@CompName", CompName);
                cmd.Parameters.AddWithValue("@CompPhno1", CompPhno1);
                cmd.Parameters.AddWithValue("@CompPhno2", CompPhno2);
                cmd.Parameters.AddWithValue("@CompEmail", CompEmail);
                cmd.Parameters.AddWithValue("@CompFax", CompFax);
                cmd.Parameters.AddWithValue("@CompHomeNo", CompHomeNo);
                cmd.Parameters.AddWithValue("@CompStreet", CompStreet);
                cmd.Parameters.AddWithValue("@CompTownship", CompTownship);
                cmd.Parameters.AddWithValue("@CompCity", CompCity);
                cmd.Parameters.AddWithValue("@CompCountry", CompCountry);
                cmd.Parameters.AddWithValue("@CompCEOName", CompCEOName);
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
        public void Upd_Company()
        {
            try
            {
                cmd = new SqlCommand("UPD_Company", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompID", CompID);
                cmd.Parameters.AddWithValue("@CompName", CompName);
                cmd.Parameters.AddWithValue("@CompPhno1", CompPhno1);
                cmd.Parameters.AddWithValue("@CompPhno2", CompPhno2);
                cmd.Parameters.AddWithValue("@CompEmail", CompEmail);
                cmd.Parameters.AddWithValue("@CompFax", CompFax);
                cmd.Parameters.AddWithValue("@CompHomeNo", CompHomeNo);
                cmd.Parameters.AddWithValue("@CompStreet", CompStreet);
                cmd.Parameters.AddWithValue("@CompTownship", CompTownship);
                cmd.Parameters.AddWithValue("@CompCity", CompCity);
                cmd.Parameters.AddWithValue("@CompCountry", CompCountry);
                cmd.Parameters.AddWithValue("@CompCEOName", CompCEOName);
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
        public void Del_Company()
        {
            try
            {
                cmd = new SqlCommand("DEL_Company", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompID", CompID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        private DataTable AutoID_Company()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Company", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable SearchCompany()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Company", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompName", CompName);
            cmd.Parameters.AddWithValue("@CompCountry", CompCountry);
            cmd.Parameters.AddWithValue("@CompCity", CompCity);
            cmd.Parameters.AddWithValue("@CompTownship", CompTownship);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion
    }
}
