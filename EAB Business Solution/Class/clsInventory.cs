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
    class clsInventory
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

        string _PID;
        public string PID
        {
            get { return _PID; }
            set { _PID = value; }
        }

        DateTime? _StockInDate;
        public DateTime? StockInDate
        {
            get { return _StockInDate; }
            set { _StockInDate = value; }
        }

        int _PQty;
        public int PQty
        {
            get { return _PQty; }
            set { _PQty = value; }
        }

        DateTime _PManuDate;
        public DateTime PManuDate
        {
            get { return _PManuDate; }
            set { _PManuDate = value; }
        }

        DateTime _PExpireDate;
        public DateTime PExpireDate
        {
            get { return _PExpireDate; }
            set { _PExpireDate = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }

        #endregion

        #region "Insert"
        public void Ins_Inventory()
        {
            try
            {
                cmd = new SqlCommand("Ins_inventory", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@StockInDate", StockInDate);
                cmd.Parameters.AddWithValue("@PQty", PQty);
                cmd.Parameters.AddWithValue("@PManuDate", PManuDate);
                cmd.Parameters.AddWithValue("@PExpireDate", PExpireDate);
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
        public void Upd_Inventory()
        {
            try
            {
                cmd = new SqlCommand("UPD_Inventory", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@StockInDate", StockInDate);
                cmd.Parameters.AddWithValue("@PQty", PQty);
                cmd.Parameters.AddWithValue("@PManuDate", PManuDate);
                cmd.Parameters.AddWithValue("@PExpireDate", PExpireDate);
                cmd.Parameters.AddWithValue("@CreatedEID", CreatedEID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

     

        
        public void Decre_Inventory()
        {
            try
            {
                cmd = new SqlCommand("UPD_Inventory_Decrement", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@PQty", PQty);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been updated successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
               MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion


    }
}
