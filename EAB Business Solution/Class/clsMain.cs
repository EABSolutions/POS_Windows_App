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
    class clsMain
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        clsSqlDataModules sql = new clsSqlDataModules(Application.StartupPath);

        #region "Property"

        string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        int _LHID;
        public int LHID
        {
            get { return _LHID; }
            set { _LHID = value; }
        }

        DateTime _LoginTime;
        public DateTime LoginTime
        {
            get { return _LoginTime; }
            set { _LoginTime = value; }
        }

        DateTime _LogoutTime;
        public DateTime LogoutTime
        {
            get { return _LogoutTime; }
            set { _LogoutTime = value; }
        }

        int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
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

        #region "Login"
        public DataTable Login()
        {
            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("Login", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "CheckLogin"
        public DataTable Check_Login()
        {
            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("Check_Login", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", Username);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Insert"
        public void Ins_LoginHistory()
        {
            try
            {
                cmd = new SqlCommand("INS_Login_History", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LHID", LHID);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@LoginTime", LoginTime);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {}
        }
        #endregion

        #region "Update"
        public void UPD_LoginHistory()
        {
            try
            {
                cmd = new SqlCommand("UPD_Login_History", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LHID", LHID);
                cmd.Parameters.AddWithValue("@LogoutTime", LogoutTime);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {}
        }
        #endregion

        #region "AutoID"
        public DataTable AutoID_LoginHistory()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_LoginHistory", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

    }

    
}
