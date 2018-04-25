using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EAB_Business_Solution.Class
{
    public class clsOrderLists
    {
        public DataTable dt { get; set; }
        public SqlDataAdapter da { get; set; }
        public SqlCommand cmd { get; set; }
        clsSqlDataModules sql = new clsSqlDataModules(Application.StartupPath);

        public int SPID { get; set; }
        public int SalesID { get; set; }
        public int FQty { get; set; }

        public void UPD_Inventory()
        {
            try
            {
                cmd = new SqlCommand("UPD_Sales_Detail_From_OrderList", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", SalesID);
                cmd.Parameters.AddWithValue("@pID", SPID);
                cmd.Parameters.Add("@fQty", FQty);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
