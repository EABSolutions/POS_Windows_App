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
    class clsSupplier
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

        string _SID;
        public string SID
        {
            get { return _SID; }
            set { _SID = value; }
        }

        string _SName;
        public string SName
        {
            get { return _SName; }
            set { _SName = value; }
        }

        string _SMOffice1;
        public string SMOffice1
        {
            get { return _SMOffice1; }
            set { _SMOffice1 = value; }
        }

        string _SMOffice2;
        public string SMOffice2
        {
            get { return _SMOffice2; }
            set { _SMOffice2 = value; }
        }

        string _SMMobile;
        public string SMMobile
        {
            get { return _SMMobile; }
            set { _SMMobile = value; }
        }

        string _SMEmail;
        public string SMEmail
        {
            get { return _SMEmail; }
            set { _SMEmail = value; }
        }

        string _SMFax1;
        public string SMFax1
        {
            get { return _SMFax1; }
            set { _SMFax1 = value; }
        }

        string _SMFax2;
        public string SMFax2
        {
            get { return _SMFax2; }
            set { _SMFax2 = value; }
        }

        string _SMHomeNo;
        public string SMHomeNo
        {
            get { return _SMHomeNo; }
            set { _SMHomeNo = value; }
        }

        string _SMStreet;
        public string SMStreet
        {
            get { return _SMStreet; }
            set { _SMStreet = value; }
        }

        string _SMTownship;
        public string SMTownship
        {
            get { return _SMTownship; }
            set { _SMTownship = value; }
        }

        string _SMCity;
        public string SMCity
        {
            get { return _SMCity; }
            set { _SMCity = value; }
        }

        string _SMCountry;
        public string SMCountry
        {
            get { return _SMCountry; }
            set { _SMCountry = value; }
        }

        string _SMZipCode;
        public string SMZipCode
        {
            get { return _SMZipCode; }
            set { _SMZipCode = value; }
        }

        string _SDOffice1;
        public string SDOffice1
        {
            get { return _SDOffice1; }
            set { _SDOffice1 = value; }
        }

        string _SDOffice2;
        public string SDOffice2
        {
            get { return _SDOffice2; }
            set { _SDOffice2 = value; }
        }

        string _SDMobile;
        public string SDMobile
        {
            get { return _SDMobile; }
            set { _SDMobile = value; }
        }

        string _SDEmail;
        public string SDEmail
        {
            get { return _SDEmail; }
            set { _SDEmail = value; }
        }

        string _SDFax1;
        public string SDFax1
        {
            get { return _SDFax1; }
            set { _SDFax1 = value; }
        }

        string _SDFax2;
        public string SDFax2
        {
            get { return _SDFax2; }
            set { _SDFax2 = value; }
        }

        string _SDHomeNo;
        public string SDHomeNo
        {
            get { return _SDHomeNo; }
            set { _SDHomeNo = value; }
        }

        string _SDStreet;
        public string SDStreet
        {
            get { return _SDStreet; }
            set { _SDStreet = value; }
        }

        string _SDTownship;
        public string SDTownship
        {
            get { return _SDTownship; }
            set { _SDTownship = value; }
        }

        string _SDCity;
        public string SDCity
        {
            get { return _SDCity; }
            set { _SDCity = value; }
        }

        string _SDCountry;
        public string SDCountry
        {
            get { return _SDCountry; }
            set { _SDCountry = value; }
        }

        string _SDZipCode;
        public string SDZipCode
        {
            get { return _SDZipCode; }
            set { _SDZipCode = value; }
        }

        string _SWebsite;
        public string SWebsite
        {
            get { return _SWebsite; }
            set { _SWebsite = value; }
        }

        string _SFacebook;
        public string SFacebook
        {
            get { return _SFacebook; }
            set { _SFacebook = value; }
        }

        string _SLeadName;
        public string SLeadName
        {
            get { return _SLeadName; }
            set { _SLeadName = value; }
        }
        string _SLeadContactNo;
        public string SLeadContactNo
        {
            get { return _SLeadContactNo; }
            set { _SLeadContactNo = value; }
        }

        string _SLeadEmail;
        public string SLeadEmail
        {
            get { return _SLeadEmail; }
            set { _SLeadEmail = value; }
        }

        string _CreatedEID;
        public string CreatedEID
        {
            get { return _CreatedEID; }
            set { _CreatedEID = value; }
        }
        #endregion

        #region "Insert"
        public void Ins_Supplier()
        {
            try
            {
                cmd = new SqlCommand("INS_Supplier", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@SName", SName);
                cmd.Parameters.AddWithValue("@SMOffice1", SMOffice1);
                cmd.Parameters.AddWithValue("@SMOffice2", SMOffice2);
                cmd.Parameters.AddWithValue("@SMMobile", SMMobile);
                cmd.Parameters.AddWithValue("@SMEmail", SMEmail);
                cmd.Parameters.AddWithValue("@SMFax1", SMFax1);
                cmd.Parameters.AddWithValue("@SMFax2", SMFax2);
                cmd.Parameters.AddWithValue("@SMHomeNo", SMHomeNo);
                cmd.Parameters.AddWithValue("@SMStreet", SMStreet);
                cmd.Parameters.AddWithValue("@SMTownship", SMTownship);
                cmd.Parameters.AddWithValue("@SMCity", SMCity);
                cmd.Parameters.AddWithValue("@SMCountry", SMCountry);
                cmd.Parameters.AddWithValue("@SMZipCode", SMZipCode);
                cmd.Parameters.AddWithValue("@SDOffice1", SDOffice1);
                cmd.Parameters.AddWithValue("@SDOffice2", SDOffice2);
                cmd.Parameters.AddWithValue("@SDMobile", SDMobile);
                cmd.Parameters.AddWithValue("@SDEmail", SDEmail);
                cmd.Parameters.AddWithValue("@SDFax1", SDFax1);
                cmd.Parameters.AddWithValue("@SDFax2", SDFax2);
                cmd.Parameters.AddWithValue("@SDHomeNo", SDHomeNo);
                cmd.Parameters.AddWithValue("@SDStreet", SDStreet);
                cmd.Parameters.AddWithValue("@SDTownship", SDTownship);
                cmd.Parameters.AddWithValue("@SDCity", SDCity);
                cmd.Parameters.AddWithValue("@SDCountry", SDCountry);
                cmd.Parameters.AddWithValue("@SDZipCode", SDZipCode);
                cmd.Parameters.AddWithValue("@SWebsite", SWebsite);
                cmd.Parameters.AddWithValue("@SFacebook", SFacebook);
                cmd.Parameters.AddWithValue("@SLeadName", SLeadName);
                cmd.Parameters.AddWithValue("@SLeadContactNo", SLeadContactNo);
                cmd.Parameters.AddWithValue("@SLeadEmail", SLeadEmail);
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
        public void Upd_Supplier()
        {
            try
            {
                cmd = new SqlCommand("UPD_Supplier", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@SName", SName);
                cmd.Parameters.AddWithValue("@SMOffice1", SMOffice1);
                cmd.Parameters.AddWithValue("@SMOffice2", SMOffice2);
                cmd.Parameters.AddWithValue("@SMMobile", SMMobile);
                cmd.Parameters.AddWithValue("@SMEmail", SMEmail);
                cmd.Parameters.AddWithValue("@SMFax1", SMFax1);
                cmd.Parameters.AddWithValue("@SMFax2", SMFax2);
                cmd.Parameters.AddWithValue("@SMHomeNo", SMHomeNo);
                cmd.Parameters.AddWithValue("@SMStreet", SMStreet);
                cmd.Parameters.AddWithValue("@SMTownship", SMTownship);
                cmd.Parameters.AddWithValue("@SMCity", SMCity);
                cmd.Parameters.AddWithValue("@SMCountry", SMCountry);
                cmd.Parameters.AddWithValue("@SMZipCode", SMZipCode);
                cmd.Parameters.AddWithValue("@SDOffice1", SDOffice1);
                cmd.Parameters.AddWithValue("@SDOffice2", SDOffice2);
                cmd.Parameters.AddWithValue("@SDMobile", SDMobile);
                cmd.Parameters.AddWithValue("@SDEmail", SDEmail);
                cmd.Parameters.AddWithValue("@SDFax1", SDFax1);
                cmd.Parameters.AddWithValue("@SDFax2", SDFax2);
                cmd.Parameters.AddWithValue("@SDHomeNo", SDHomeNo);
                cmd.Parameters.AddWithValue("@SDStreet", SDStreet);
                cmd.Parameters.AddWithValue("@SDTownship", SDTownship);
                cmd.Parameters.AddWithValue("@SDCity", SDCity);
                cmd.Parameters.AddWithValue("@SDCountry", SDCountry);
                cmd.Parameters.AddWithValue("@SDZipCode", SDZipCode);
                cmd.Parameters.AddWithValue("@SWebsite", SWebsite);
                cmd.Parameters.AddWithValue("@SFacebook", SFacebook);
                cmd.Parameters.AddWithValue("@SLeadName", SLeadName);
                cmd.Parameters.AddWithValue("@SLeadContactNo", SLeadContactNo);
                cmd.Parameters.AddWithValue("@SLeadEmail", SLeadEmail);
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
        public void Del_Supplier()
        {
            try
            {
                cmd = new SqlCommand("DEL_Supplier", new SqlConnection(sql.ConnectionString()));
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());

            }
        }
        #endregion

        #region "AutoID"
        public DataTable AutoID_Supplier()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("AutoID_Supplier", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region "Search"
        public DataTable SearchSupplier()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SEARCH_Supplier", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SName", SName);
            cmd.Parameters.AddWithValue("@Country", SMCountry);
            cmd.Parameters.AddWithValue("@City", SMCity);
            cmd.Parameters.AddWithValue("@Township", SMTownship);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region "Call"
        public DataTable CallSupplier()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_Supplier", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }

        public DataTable CallSupplierIDbyName()
         {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_SupplierIDbyName", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SName", SName);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }


        public DataTable CallCitybyMCountry()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_CitybyMCountrySupplier", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Country", SMCountry);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable  CallTownshipbyMCity()
        {

            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand("CALL_TownshipbyMCitySupplier", new SqlConnection(sql.ConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@City", SMCity);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        #endregion
      


        
    }
}