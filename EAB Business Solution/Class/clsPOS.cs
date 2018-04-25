using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EAB_Business_Solution.Class
{
    public class clsPOS
    {
        public DataTable dt { get; set; }
        public SqlDataAdapter da { get; set; }
        public SqlCommand cmd { get; set; }
        clsSqlDataModules sql = new clsSqlDataModules(Application.StartupPath);

        public string TID { get; set; }
        public int SalesID { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime SalesDate { get; set; }
        public string SalesDesc { get; set; }
        public string CID { get; set; }
        public string CreatedEID { get; set; }
        public int SalesQty { get; set; }
        public int SPID { get; set; }
        public int Status { get; set; }
        public int TaxAmount { get; set; }
        public int ServiceChargeAmount { get; set; }
        public int? IQty { get; set; }
        public int WHID { get; set; }
        public int SubTotal { get; set; }
        public int GrandTotal { get; set; }
        public int CashAmount { get; set; }
        public int ChangeAmount { get; set; }
        public int MemberPromotion { get; set; }
        public int PTotalAmount { get; set; }
        public int ProductAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public DataTable CallProductLine()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("CALL_ProductLine", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable CallProduct()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("CALL_ProductWithoutParameter", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable CallProduct(string ProductLineID)
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("CALL_Product", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddWithValue("@plID", ProductLineID);
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
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

        public void Ins_Sales()
        {
            try
            {
                cmd = new SqlCommand("INS_Sales", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SalesID", SalesID);
                cmd.Parameters.AddWithValue("@SalesDate", SalesDate);
                cmd.Parameters.AddWithValue("@SalesDescription", SalesDesc);
                cmd.Parameters.AddWithValue("@CID", CID);
                cmd.Parameters.AddWithValue("@CreatedEID", CreatedEID);
                cmd.Parameters.AddWithValue("@TID", TID);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Ins_SalesDetail()
        {
            try
            {
                cmd = new SqlCommand("INS_Sales_Detail", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SalesID", SalesID);
                cmd.Parameters.AddWithValue("@SalesQty", SalesQty);
                cmd.Parameters.AddWithValue("@SPID", SPID);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data has been saved successfully!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Data has already existed!", "EABBS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void UPD_Inventory()
        {
            try
            {
                cmd = new SqlCommand("UPD_InventoryPOS", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@WHID", WHID);
                cmd.Parameters.AddWithValue("@PID", SPID);
                cmd.Parameters.AddWithValue("@PQty", IQty);
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
                cmd = new SqlCommand("INS_Invoice", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                cmd.Parameters.AddWithValue("@Date", InvoiceDate);
                cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
                cmd.Parameters.AddWithValue("@MemberPromotion", MemberPromotion);
                cmd.Parameters.AddWithValue("@Tax", TaxAmount);
                cmd.Parameters.AddWithValue("@ServiceCharges", ServiceChargeAmount);
                cmd.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                cmd.Parameters.AddWithValue("@CashAmount", CashAmount);
                cmd.Parameters.AddWithValue("@Change", ChangeAmount);
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
                cmd = new SqlCommand("INS_Invoice_Detail", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                cmd.Parameters.AddWithValue("@SalesID", SalesID);
                cmd.Parameters.AddWithValue("@PID", SPID);
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

        public int AutoID_Sales()
        {
            cmd = new SqlCommand("AutoID_Sales", new SqlConnection(sql.ConnectionString()));
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SalesID", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@SalesID"].Value != null)
            {
                SalesID = int.Parse(cmd.Parameters["@SalesID"].Value.ToString());
            }            
            return SalesID;
        }

        public int AutoID_Invoice()
        {
            cmd = new SqlCommand("AutoID_Invoice", new SqlConnection(sql.ConnectionString()));
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

        public int SEL_Tax()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            cmd = new SqlCommand("SEL_Tax", new SqlConnection(sql.ConnectionString()));
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@TaxAmount", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            //if (cmd.Parameters["@TaxAmount"].Value != null)
            //{
            //    TaxAmount = int.Parse(cmd.Parameters["@TaxAmount"].Value.ToString());
            //}
            
            //return TaxAmount;
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                TaxAmount = int.Parse(dt.Rows[0][0].ToString());
            }
            return TaxAmount;  
        }

        public int SEL_ServiceCharges()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            cmd = new SqlCommand("SEL_ServiceCharges", new SqlConnection(sql.ConnectionString()));
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                ServiceChargeAmount = int.Parse(dt.Rows[0][0].ToString());
            }            
            return ServiceChargeAmount;           
        }

        public int? SEL_PQty()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            cmd = new SqlCommand("SEL_PQty", new SqlConnection(sql.ConnectionString()));
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@WHID", SqlDbType.VarChar).Value = WHID;
            cmd.Parameters.Add("@PID", SqlDbType.VarChar).Value = SPID;
            cmd.ExecuteNonQuery();
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                IQty = int.Parse(dt.Rows[0][0].ToString());
            }
            else IQty = null;
            return IQty;
        }

        public DataTable SEL_SalesInfo()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("SEL_SalesInfo", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddWithValue("@tableID", this.TID);
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable SEL_POSPrint()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("SEL_POSPrint", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddWithValue("@tableID", this.TID);
            this.cmd.Parameters.AddWithValue("@salesID", this.SalesID);
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable SEL_OrderLists()
        {
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("SEL_OrderLists", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }

        public DataTable SEL_GetFQty()
        { 
            this.dt = new DataTable();
            this.da = new SqlDataAdapter();
            this.cmd = new SqlCommand("SEL_GetFQty", new SqlConnection(sql.ConnectionString()));
            this.cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesID", SalesID);
            cmd.Parameters.AddWithValue("@SPID", SPID);
            this.da.SelectCommand = cmd;
            this.da.Fill(dt);
            return dt;
        }
    }
}
