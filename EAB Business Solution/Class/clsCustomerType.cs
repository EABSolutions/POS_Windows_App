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
    class clsCustomerType
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        clsSqlDataModules sql = new clsSqlDataModules(Application.StartupPath);

        #region "Call"
        public DataTable CallCustomerType()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Customer_Type", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }

        
        #endregion
    }
}
