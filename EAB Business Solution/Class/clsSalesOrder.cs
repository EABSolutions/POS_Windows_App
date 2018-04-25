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
    class clsSalesOrder
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

        int _SOID;
        public int SOID
        {
            get { return _SOID; }
            set { _SOID = value; }
        }

        DateTime _SODate;
        public DateTime SODate
        {
            get { return _SODate; }
            set { _SODate = value; }
        }

        string _CID;
        public string CID
        {
            get { return _CID; }
            set { _CID = value; }
        }

        string _CName;
        public string CName
        {
            get { return _CName; }
            set { _CName = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }

        string _SODescription;
        public string SODescription
        {
            get { return _SODescription; }
            set { _SODescription = value; }
        }

        int _SODepositAmount;
        public int SODepositAmount
        {
            get { return _SODepositAmount; }
            set { _SODepositAmount = value; }
        }


        int _FirstPayement;
        public int FirstPayement
        {
            get { return _FirstPayement; }
            set { _FirstPayement = value; }
        }

        int _AmendmentPayment;
        public int AmendmentPayment
        {
            get { return _AmendmentPayment; }
            set { _AmendmentPayment = value; }
        }


        int? _SOStatus;
        public int? SOStatus
        {
            get { return _SOStatus; }
            set { _SOStatus = value; }
        }

        string _SORemark;
        public string SORemark
        {
            get { return _SORemark; }
            set { _SORemark = value; }
        }

        string _PID;
        public string PID
        {
            get { return _PID; }
            set { _PID = value; }
        }

        int _SOQty;
        public int SOQty
        {
            get { return _SOQty; }
            set { _SOQty = value; }
        }

        DateTime _SOCancelDate;
        public DateTime SOCancelDate
        {
            get { return _SOCancelDate; }
            set { _SOCancelDate = value; }
        }

        DateTime _SODeliveryDate;
        public DateTime SODeliveryDate
        {
            get { return _SODeliveryDate; }
            set { _SODeliveryDate = value; }
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

        public int InvoiceNo { get; set; }
        public int TaxAmount { get; set; }
        public int ServiceChargeAmount { get; set; }
        public int? IQty { get; set; }
        public int MemberPromotion { get; set; }
        public int SubTotal { get; set; }
        public int GrandTotal { get; set; }
        public int PTotalAmount { get; set; }
        public int ProductAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int SPID { get; set; }
        public int CreditAmount { get; set; }

        #endregion

        #region "Insert"
        public void Ins_Sales_Order()
        {
            try
            {
                cmd = new SqlCommand("Ins_Sales_Order", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SOID", SOID);
                cmd.Parameters.AddWithValue("@SODate", SODate);
                cmd.Parameters.AddWithValue("@CID", CID);
                cmd.Parameters.AddWithValue("@CreatedEID", CreatedEID);
                cmd.Parameters.AddWithValue("@SODescription", SODescription);
                cmd.Parameters.AddWithValue("@SODepositAmount", SODepositAmount);
                cmd.Parameters.AddWithValue("@SOFirstPayment", FirstPayement);
                cmd.Parameters.AddWithValue("@SOAmendmentPayment", AmendmentPayment);
                cmd.Parameters.AddWithValue("@SOStatus", SOStatus);
                cmd.Parameters.AddWithValue("@SORemark", SORemark);
                cmd.Parameters.AddWithValue("@SODeliveryDate", SODeliveryDate);
                cmd.Parameters.AddWithValue("@SOCancelDate", SOCancelDate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd = new SqlCommand("Ins_SO_Detail", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SOID", SOID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@SOQty", SOQty);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Ins_Invoice()
        {
            try
            {
                cmd = new SqlCommand("INS_Invoice_SO", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                cmd.Parameters.AddWithValue("@Date", InvoiceDate);
                cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
                cmd.Parameters.AddWithValue("@MemberPromotion", MemberPromotion);
                cmd.Parameters.AddWithValue("@Tax", TaxAmount);
                cmd.Parameters.AddWithValue("@ServiceCharges", ServiceChargeAmount);
                cmd.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                cmd.Parameters.AddWithValue("@DepositAmount", SODepositAmount);
                cmd.Parameters.AddWithValue("@Firstpayment", FirstPayement);
                cmd.Parameters.AddWithValue("@Amendmentpayment", AmendmentPayment);
                cmd.Parameters.AddWithValue("@Creditamount", CreditAmount);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Ins_InvoiceDetail()
        {
            try
            {
                cmd = new SqlCommand("INS_Invoice_Detail_SO", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                cmd.Parameters.AddWithValue("@SOID", SOID);
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@Price", ProductAmount);
                cmd.Parameters.AddWithValue("@Amount", PTotalAmount);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

       
        #region "Cancel"

        public void Cancel_Sales_Order()
        {
            try
            {
                cmd = new SqlCommand("Cancel_Sales_Order", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SOID", SOID);
                cmd.Parameters.AddWithValue("@SOCancelDate", SOCancelDate);
                cmd.Parameters.AddWithValue("@SOStatus", SOStatus);
                
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "Update"

        public void Update_Order()
        {
            try
            {
                cmd = new SqlCommand("UPD_Sales_Order", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SOID", SOID);
                cmd.Parameters.AddWithValue("@SODepositAmount", SODepositAmount);
                cmd.Parameters.AddWithValue("@SOFirstPayment", FirstPayement);
                cmd.Parameters.AddWithValue("@SOAmendmentPayment", AmendmentPayment);
                cmd.Parameters.AddWithValue("@Remark", SORemark);
                cmd.Parameters.AddWithValue("@SOStatus", SOStatus);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }




        public void Update_Invoice()
        {
            try
            {
                cmd = new SqlCommand("UPD_Invoice_SO", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                cmd.Parameters.AddWithValue("@Date", InvoiceDate);
                //cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
                //cmd.Parameters.AddWithValue("@MemberPromotion", MemberPromotion);
                //cmd.Parameters.AddWithValue("@Tax", TaxAmount);
                //cmd.Parameters.AddWithValue("@ServiceCharges", ServiceChargeAmount);
                //cmd.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                cmd.Parameters.AddWithValue("@DepositAmount", SODepositAmount);
                cmd.Parameters.AddWithValue("@Firstpayment", FirstPayement);
                cmd.Parameters.AddWithValue("@Amendmentpayment", AmendmentPayment);
                cmd.Parameters.AddWithValue("@Creditamount", CreditAmount);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }

        #endregion

        #region "AutoID"
        public DataTable AutoID_Sales_Order()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Sales_Order", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public int AutoID_Invoice()
        {
            cmd = new SqlCommand("AutoID_Invoice_SO", new SqlConnection(sql.ConnectionString()));
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@InvoiceNo", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@InvoiceNo"].Value != null)
            {
                InvoiceNo = int.Parse(cmd.Parameters["@InvoiceNo"].Value.ToString());
            }
            return InvoiceNo;
        }

        #endregion

        #region "Search"
        public DataTable Search_Sales_Order()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Sales_Order", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOID ", SOID);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);
            cmd.Parameters.AddWithValue("@CID", CID);
            cmd.Parameters.AddWithValue("@Status", SOStatus);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "invoiceidbysoid"
        public DataTable Call_SOInvoicebySOID()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_SOInvoicebySOID", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOID ", SOID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion


        #region "CallSO"
        public DataTable Call_SalesOrderbySO()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_ProductbySO", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOID", SOID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }

        public DataTable PolpulateProductInfo(string ProductID)
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("SEL_ProductInfo", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddWithValue("@pID", ProductID);
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable CallProductbySO()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("CALL_ProductbySO", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddWithValue("@SOID", SOID);
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable SEL_SOPrint()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("SEL_SOPrint", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddWithValue("@SOID", this.SOID);
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable Call_PLandPbyPID()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("CALL_ProductLineandProductbyPID", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddWithValue("@PID", this.PID);
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        #endregion
        
    }
}
