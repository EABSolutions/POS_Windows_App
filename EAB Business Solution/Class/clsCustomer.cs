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
    class clsCustomer
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

        string _NRCNo;
        public string NRCNo
        {
            get { return _NRCNo; }
            set { _NRCNo = value; }
        }

        DateTime? _CDOB;
        public DateTime? CDOB
        {
            get { return _CDOB; }
            set { _CDOB = value; }
        }

        string _CGender;
        public string CGender
        {
            get { return _CGender; }
            set { _CGender = value; }
        }

        string _CMaritalStatus;
        public string CMaritalStatus
        {
            get { return _CMaritalStatus; }
            set { _CMaritalStatus = value; }
        }

        string _Nationality;
        public string Nationality
        {
            get { return _Nationality; }
            set { _Nationality = value; }
        }

        string _Religion;
        public string Religion
        {
            get { return _Religion; }
            set { _Religion = value; }
        }

        string _CMOffice1;
        public string CMOffice1
        {
            get { return _CMOffice1; }
            set { _CMOffice1 = value; }
        }

        string _CMOffice2;
        public string CMOffice2
        {
            get { return _CMOffice2; }
            set { _CMOffice2 = value; }
        }

        string _CMMobile;
        public string CMMobile
        {
            get { return _CMMobile; }
            set { _CMMobile = value; }
        }

        string _CMEmail;
        public string CMEmail
        {
            get { return _CMEmail; }
            set { _CMEmail = value; }
        }

        string _CMFax1;
        public string CMFax1
        {
            get { return _CMFax1; }
            set { _CMFax1 = value; }
        }

        string _CMFax2;
        public string CMFax2
        {
            get { return _CMFax2; }
            set { _CMFax2 = value; }
        }

        string _CMHomeNo;
        public string CMHomeNo
        {
            get { return _CMHomeNo; }
            set { _CMHomeNo = value; }
        }

        string _CMStreet;
        public string CMStreet
        {
            get { return _CMStreet; }
            set { _CMStreet = value; }
        }

        string _CMTownship;
        public string CMTownship
        {
            get { return _CMTownship; }
            set { _CMTownship = value; }
        }

        string _CMCity;
        public string CMCity
        {
            get { return _CMCity; }
            set { _CMCity = value; }
        }

        string _CMCountry;
        public string CMCountry
        {
            get { return _CMCountry; }
            set { _CMCountry = value; }
        }

        string _CMZipCode;
        public string CMZipCode
        {
            get { return _CMZipCode; }
            set { _CMZipCode = value; }
        }

        string _CDOffice1;
        public string CDOffice1
        {
            get { return _CDOffice1; }
            set { _CDOffice1 = value; }
        }

        string _CDOffice2;
        public string CDOffice2
        {
            get { return _CDOffice2; }
            set { _CDOffice2 = value; }
        }

        string _CDMobile;
        public string CDMobile
        {
            get { return _CDMobile; }
            set { _CDMobile = value; }
        }

        string _CDEmail;
        public string CDEmail
        {
            get { return _CDEmail; }
            set { _CDEmail = value; }
        }

        string _CDFax1;
        public string CDFax1
        {
            get { return _CDFax1; }
            set { _CDFax1 = value; }
        }

        string _CDFax2;
        public string CDFax2
        {
            get { return _CDFax2; }
            set { _CDFax2 = value; }
        }

        string _CDHomeNo;
        public string CDHomeNo
        {
            get { return _CDHomeNo; }
            set { _CDHomeNo = value; }
        }

        string _CDStreet;
        public string CDStreet
        {
            get { return _CDStreet; }
            set { _CDStreet = value; }
        }

        string _CDTownship;
        public string CDTownship
        {
            get { return _CDTownship; }
            set { _CDTownship = value; }
        }

        string _CDCity;
        public string CDCity
        {
            get { return _CDCity; }
            set { _CDCity = value; }
        }

        string _CDCountry;
        public string CDCountry
        {
            get { return _CDCountry; }
            set { _CDCountry = value; }
        }

        string _CDZipCode;
        public string CDZipCode
        {
            get { return _CDZipCode; }
            set { _CDZipCode = value; }
        }

        string _CWebsite;
        public string CWebsite
        {
            get { return _CWebsite; }
            set { _CWebsite = value; }
        }

        string _CFacebook;
        public string CFacebook
        {
            get { return _CFacebook; }
            set { _CFacebook = value; }
        }

        string _CTID;
        public string CTID
        {
            get { return _CTID; }
            set { _CTID = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion

        #region "Insert"
        public void Ins_Customer()
        {
            try
            {
                cmd = new SqlCommand("INS_Customer", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CID", CID);
                cmd.Parameters.AddWithValue("@CName", CName);
                cmd.Parameters.AddWithValue("@NRCNo", NRCNo);
                cmd.Parameters.AddWithValue("@CDOB", CDOB);
                cmd.Parameters.AddWithValue("@CGender", CGender);
                cmd.Parameters.AddWithValue("@CMaritalStatus", CMaritalStatus);
                cmd.Parameters.AddWithValue("@CNationality", Nationality);
                cmd.Parameters.AddWithValue("@CReligion", Religion);
                cmd.Parameters.AddWithValue("@CMOffice1", CMOffice1);
                cmd.Parameters.AddWithValue("@CMOffice2", CMOffice2);
                cmd.Parameters.AddWithValue("@CMMobile", CMMobile);
                cmd.Parameters.AddWithValue("@CMEmail", CMEmail);
                cmd.Parameters.AddWithValue("@CMFax1", CMFax1);
                cmd.Parameters.AddWithValue("@CMFax2", CMFax2);
                cmd.Parameters.AddWithValue("@CMHomeNo", CMHomeNo);
                cmd.Parameters.AddWithValue("@CMStreet", CMStreet);
                cmd.Parameters.AddWithValue("@CMTownship", CMTownship);
                cmd.Parameters.AddWithValue("@CMCity", CMCity);
                cmd.Parameters.AddWithValue("@CMCountry", CMCountry);
                cmd.Parameters.AddWithValue("@CMZipCode", CMZipCode);
                cmd.Parameters.AddWithValue("@CDOffice1", CDOffice1);
                cmd.Parameters.AddWithValue("@CDOffice2", CDOffice2);
                cmd.Parameters.AddWithValue("@CDMobile", CDMobile);
                cmd.Parameters.AddWithValue("@CDEmail", CDEmail);
                cmd.Parameters.AddWithValue("@CDFax1", CDFax1);
                cmd.Parameters.AddWithValue("@CDFax2", CDFax2);
                cmd.Parameters.AddWithValue("@CDHomeNo", CDHomeNo);
                cmd.Parameters.AddWithValue("@CDStreet", CDStreet); 
                cmd.Parameters.AddWithValue("@CDTownship", CDTownship);
                cmd.Parameters.AddWithValue("@CDCity", CDCity);
                cmd.Parameters.AddWithValue("@CDCountry", CDCountry);
                cmd.Parameters.AddWithValue("@CDZipCode", CDZipCode);
                cmd.Parameters.AddWithValue("@CWebsite", CWebsite);
                cmd.Parameters.AddWithValue("@CFacebook", CFacebook);
                cmd.Parameters.AddWithValue("@CTID", CTID);
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
        public void Upd_Customer()
        {
            try
            {
                cmd = new SqlCommand("UPD_Customer", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CID", CID);
                cmd.Parameters.AddWithValue("@CName", CName);
                cmd.Parameters.AddWithValue("@NRCNo", NRCNo);
                cmd.Parameters.AddWithValue("@CDOB", CDOB);
                cmd.Parameters.AddWithValue("@CGender", CGender);
                cmd.Parameters.AddWithValue("@CMaritalStatus", CMaritalStatus);
                cmd.Parameters.AddWithValue("@CNationality", Nationality);
                cmd.Parameters.AddWithValue("@CReligion", Religion);
                cmd.Parameters.AddWithValue("@CMOffice1", CMOffice1);
                cmd.Parameters.AddWithValue("@CMOffice2", CMOffice2);
                cmd.Parameters.AddWithValue("@CMMobile", CMMobile);
                cmd.Parameters.AddWithValue("@CMEmail", CMEmail);
                cmd.Parameters.AddWithValue("@CMFax1", CMFax1);
                cmd.Parameters.AddWithValue("@CMFax2", CMFax2);
                cmd.Parameters.AddWithValue("@CMHomeNo", CMHomeNo);
                cmd.Parameters.AddWithValue("@CMStreet", CMStreet);
                cmd.Parameters.AddWithValue("@CMTownship", CMTownship);
                cmd.Parameters.AddWithValue("@CMCity", CMCity);
                cmd.Parameters.AddWithValue("@CMCountry", CMCountry);
                cmd.Parameters.AddWithValue("@CMZipCode", CMZipCode);
                cmd.Parameters.AddWithValue("@CDOffice1", CDOffice1);
                cmd.Parameters.AddWithValue("@CDOffice2", CDOffice2);
                cmd.Parameters.AddWithValue("@CDMobile", CDMobile);
                cmd.Parameters.AddWithValue("@CDEmail", CDEmail);
                cmd.Parameters.AddWithValue("@CDFax1", CDFax1);
                cmd.Parameters.AddWithValue("@CDFax2", CDFax2);
                cmd.Parameters.AddWithValue("@CDHomeNo", CDHomeNo);
                cmd.Parameters.AddWithValue("@CDStreet", CDStreet);
                cmd.Parameters.AddWithValue("@CDTownship", CDTownship);
                cmd.Parameters.AddWithValue("@CDCity", CDCity);
                cmd.Parameters.AddWithValue("@CDCountry", CDCountry);
                cmd.Parameters.AddWithValue("@CDZipCode", CDZipCode);
                cmd.Parameters.AddWithValue("@CWebsite", CWebsite);
                cmd.Parameters.AddWithValue("@CFacebook", CFacebook);
                cmd.Parameters.AddWithValue("@CTID", CTID);
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
        public void Del_Customer()
        {
            try
            {
                cmd = new SqlCommand("DEL_Customer", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CID", CID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        public DataTable AutoID_Customer()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Customer", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable SearchCustomer()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Customer", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CName", CName);
            cmd.Parameters.AddWithValue("@Township", CMTownship);
            cmd.Parameters.AddWithValue("@City", CMCity);
            cmd.Parameters.AddWithValue("@Country", CMCountry);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "Call"
        public DataTable CallCustomer()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Customer", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }


        public DataTable CallCustomerbyID()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_CustomerbyID", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CID", CID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }


        public DataTable CallMembershipbyCID()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_MembershipbyCID", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CID", CID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable CallCustomerIDbyName()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_CustomerIDbyName", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CName", CName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }

        public DataTable CallCitybyMCountry()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_CitybyMCountry", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Country", CMCountry);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable CallTownshipbyMCity()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_TownshipbyMCity", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@City", CMCity);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable CallCountry()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Country", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }


        public DataTable CallCountryIDbyName()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_CountryIDbyName", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CountryName", CDCountry);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        #endregion

        internal DataTable CALL_MembershipbyCID()
        {
            throw new NotImplementedException();
        }
    }
}
