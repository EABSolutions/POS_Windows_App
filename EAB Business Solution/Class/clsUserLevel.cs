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
    class clsUserLevel
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

        string _ULID;
        public string ULID
        {
            get { return _ULID; }
            set { _ULID = value; }
        }

        string _ULName;
        public string ULName
        {
            get { return _ULName; }
            set { _ULName = value; }
        }

        string _ULDescription;
        public string ULDescription
        {
            get { return _ULDescription; }
            set { _ULDescription = value; }
        }


        string _EID;
        public string EID
        {
            get { return _EID; }
            set { _EID = value; }
        }


        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion


        #region "Call"
        public DataTable Call_UserLevel()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Brand", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable CallUserLevelIDbyEID()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_UserLevelIDbyEID", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EID", EID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
