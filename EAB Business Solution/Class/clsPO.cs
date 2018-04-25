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
    class clsPO
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

        int _POID;
        public int POID
        {
            get { return _POID; }
            set { _POID = value; }
        }

        DateTime _PODate;
        public DateTime PODate
        {
            get { return _PODate; }
            set { _PODate = value; }
        }

        string _PODescription;
        public string PODescription
        {
            get { return _PODescription; }
            set { _PODescription = value; }
        }

        string _RequestedEID;
        public string RequestedEID
        {
            get { return _RequestedEID; }
            set { _RequestedEID = value; }
        }

        string _ApprovedEID;
        public string ApprovedEID
        {
            get { return _ApprovedEID; }
            set { _ApprovedEID = value; }
        }

        DateTime _ApprovedDate;
        public DateTime ApprovedDate
        {
            get { return _ApprovedDate; }
            set { _ApprovedDate = value; }
        }

        string _SID;
        public string SID
        {
            get { return _SID; }
            set { _SID = value; }
        }

        int _DepositAmount;
        public int DepositAmount
        {
            get { return _DepositAmount; }
            set { _DepositAmount = value; }
        }

        int _FirstPayment;
        public int FirstPayment
        {
            get { return _FirstPayment; }
            set { _FirstPayment = value; }
        }

        int _AmendmentPayment;
        public int AmendmentPayment
        {
            get { return _AmendmentPayment; }
            set { _AmendmentPayment = value; }
        }

        int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        int _Remark;
        public int Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        string _PID;
        public string PID
        {
            get { return _PID; }
            set { _PID = value; }
        }

        int _POQty;
        public int POQty
        {
            get { return _POQty; }
            set { _POQty = value; }
        }

        int _POPrice;
        public int POPrice
        {
            get { return _POPrice; }
            set { _POPrice = value; }
        }

        string _WHID;
        public string WHID
        {
            get { return _WHID; }
            set { _WHID = value; }
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

        string _CurrencyCode;
        public string CurrencyCode
        {
            get { return _CurrencyCode; }
            set { _CurrencyCode = value; }
        }

        string _UOMID;
        public string UOMID
        {
            get { return _UOMID; }
            set { _UOMID = value; }
        }

        #endregion

        #region "Insert"
        public void Ins_Purchase_Order()
        {
            try
            {
                cmd = new SqlCommand("Ins_Purchase_Order", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@POID", POID);
                cmd.Parameters.AddWithValue("@PODate", PODate);
                cmd.Parameters.AddWithValue("@PODescription", PODescription);
                cmd.Parameters.AddWithValue("@RequestedEID", RequestedEID);
                cmd.Parameters.AddWithValue("@ApprovedEID", ApprovedEID);
                cmd.Parameters.AddWithValue("@ApprovedDate", ApprovedDate);
                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@DepositAmount", DepositAmount);
                cmd.Parameters.AddWithValue("@FirstPayment", FirstPayment);
                cmd.Parameters.AddWithValue("@AmendmentPayment", AmendmentPayment);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Remark", Remark);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Ins_PO_Product()
        {
            try
            {
                cmd = new SqlCommand("Ins_PO_Product", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@POID", POID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@POQty", POQty);
                cmd.Parameters.AddWithValue("@POPrice", POPrice);
                cmd.Parameters.AddWithValue("@CurrencyCode", CurrencyCode );
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@UOMID", UOMID);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region "Update"
        public void Upd_Purchase_Order()
        {
            try
            {
                cmd = new SqlCommand("UPD_Purchase_Order", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@POID", POID);
                cmd.Parameters.AddWithValue("@PODescription", PODescription);
                cmd.Parameters.AddWithValue("@ApprovedEID", ApprovedEID);
                cmd.Parameters.AddWithValue("@ApprovedDate", ApprovedDate);
                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@DepositAmount", DepositAmount);
                cmd.Parameters.AddWithValue("@FirstPayment", FirstPayment);
                cmd.Parameters.AddWithValue("@AmendmentPayment", AmendmentPayment);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Remark", Remark);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Upd_PO_Product()
        {
            try
            {
                cmd = new SqlCommand("UPD_PO_Product", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@POID", POID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@POQty", POQty);
                cmd.Parameters.AddWithValue("@POPrice", POPrice);
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@UOMID", UOMID);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been updated successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

        #region "Delete"

        public void Del_PO_Product()
        {
            try
            {
                cmd = new SqlCommand("DEL_PO_Product", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@POID", POID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@UOMID", UOMID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        public DataTable AutoID_Purchase_Order()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Purchase_Order", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable Search_Purchase_Order()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Purchase_Order", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@POID ", POID);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);
            cmd.Parameters.AddWithValue("@SID", SID);
            cmd.Parameters.AddWithValue("@Status", Status);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "CallPO"
        public DataTable Call_ProductbyPO()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("Call_ProductbyPO", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@POID", POID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }

        #endregion

        
    }
}
