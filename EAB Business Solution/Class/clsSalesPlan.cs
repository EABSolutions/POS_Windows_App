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
    class clsSalesPlan
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

        int _SPID;
        public int SPID
        {
            get { return _SPID; }
            set { _SPID = value; }
        }

        DateTime _SPCreatedDate;
        public DateTime SPCreatedDate
        {
            get { return _SPCreatedDate; }
            set { _SPCreatedDate = value; }
        }

        DateTime _FromDate;
        public DateTime FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }

        DateTime _ToDate;
        public DateTime ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }

        string _SPDescription;
        public string SPDescription
        {
            get { return _SPDescription; }
            set { _SPDescription = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }

        string _PID;
        public string PID
        {
            get { return _PID; }
            set { _PID = value; }
        }

        int _PRetailPrice;
        public int PRetailPrice
        {
            get { return _PRetailPrice; }
            set { _PRetailPrice = value; }
        }


        int _PWholeSalePrice;
        public int PWholeSalePrice
        {
            get { return _PWholeSalePrice; }
            set { _PWholeSalePrice = value; }
        }

        int _PWholeSaleQty;
        public int PWholeSaleQty
        {
            get { return _PWholeSaleQty; }
            set { _PWholeSaleQty = value; }
        }


        string _CurrencyCode;
        public string CurrencyCode
        {
            get { return _CurrencyCode; }
            set { _CurrencyCode = value; }
        }

        string _Status;
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }


        #endregion

        #region "Insert"
        public void Ins_Sales_Plan()
        {
            try
            {
                cmd = new SqlCommand("Ins_Sales_Plan", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SPID", SPID);
                cmd.Parameters.AddWithValue("@SPCreatedDate", SPCreatedDate);
                cmd.Parameters.AddWithValue("@FromDate", FromDate);
                cmd.Parameters.AddWithValue("@ToDate", ToDate);
                cmd.Parameters.AddWithValue("@SPDescription", SPDescription);
                cmd.Parameters.AddWithValue("@CreatedEID", CreatedEID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Ins_SO_Detail()
        {
            try
            {
                cmd = new SqlCommand("Ins_Sales_Plan_Detail", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SPID", SPID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@PRetailPrice", PRetailPrice);
                cmd.Parameters.AddWithValue("@PWholeSalePrice", PWholeSalePrice);
                cmd.Parameters.AddWithValue("@PWholeSaleQty", PWholeSaleQty);
                cmd.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion


    }
}
