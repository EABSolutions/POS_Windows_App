using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace EAB_Business_Solution.Forms


{
    public partial class frmCustomer : Form
    {
        Class.clsCustomer C = new Class.clsCustomer();
        Class.clsCustomerType CT = new Class.clsCustomerType();
        
        Class.clsMethods M = new Class.clsMethods();
        DataTable dt;
        public string EID;
        public string CompID;
       
        public frmCustomer()
        {
            InitializeComponent();
            Loading();
        }

        #region Methods

        #region Loading
        private void Loading()
        {
           
           
            M.Button_Enable(true, btnNew);
            M.Button_Enable(false, btnSave, btnEdit, btnDelete, btnCancel, btnCustomerType);
            M.TextBox_Clear(txtSCustomerName, txtCustomerID, txtCustomerName, txtNRCNo, txtNationality, txtReligion, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);
            M.Combobox_Enable(false, cboSTownship, cboSCity, cboSCountry);
            txtSCustomerName.Enabled = false;
            cboCustomerType.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            cboMaritalStatus.SelectedIndex = -1;
            gpbCustomerInfo.Enabled = false;
            tbcContactIno.Enabled = false;
            
            btnNew.Focus();


        }

        #region AutoID
        private void AutoID()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = C.AutoID_Customer();
                txtCustomerID.Text = tbl.Rows[0][0].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion
        #endregion


        #region GridDataClear
        private void GridDataClear()
        {
            if (this.dgvSCustomer.DataSource != null)
            {
                this.dgvSCustomer.DataSource = null;
            }
            else
            {
                this.dgvSCustomer.Rows.Clear();
            }
        }
        #endregion

        #region SearchPanelLoading
        private void SearchPanelLoading()
        {
            //pnlSCustomer.Visible = true;
            chkSCustomerName.Checked = false;
            //CustomerComboBind();
            SearchCheckboxValidation();
            GridDataClear();
            dgvSCustomer.Enabled = false;
            txtSCustomerName.Enabled = false;
        }
        #endregion

        #region SearchDataassign
        private void searchdataassign()
        {
           
                C.CName = txtSCustomerName.Text.ToString();
                if (cboSCountry.SelectedIndex == -1)
                {
                    C.CMCountry = "";
                    C.CMCity = "";
                    C.CMTownship = "";
                }
                else
                {
                    C.CMCountry = cboSCountry.SelectedValue.ToString();
                    C.CMCity = cboSCity.Text.ToString();
                    C.CMTownship = cboSTownship.Text.ToString();
                }
            
        }
        #endregion

        #region ShowallDataassign
        private void showalldataassign()
        {
            C.CName = "";
            C.CMCountry = "";
            C.CMCity = "";
            C.CMTownship = "";
            


        }
        #endregion

        #region Dataassign
        private void dataassign()
        {
            C.CID = txtCustomerID.Text.Trim();
            C.CTID = cboCustomerType.SelectedValue.ToString();
            C.CName = txtCustomerName.Text.Trim();
            C.NRCNo = txtNRCNo.Text.Trim();
            if (dtpDOB.Enabled == false)
            {
                C.CDOB = DateTime.Parse( "01/01/1900");
            }
            else
            {
                C.CDOB = DateTime.Parse(dtpDOB.Value.ToString());
            }
            if (rdbMale.Checked == true)
            {
                C.CGender = "0";
            }
            else if (rdbFemale.Checked == true)
            {
                C.CGender = "1";
            }
            else if (rdbFemale.Checked == false && rdbMale.Checked == false)
            {
                C.CGender = "";
            }
            if (cboMaritalStatus.SelectedIndex == -1)
            {
                C.CMaritalStatus = "";
            }
            else
            {
                C.CMaritalStatus = cboMaritalStatus.Text.ToString();
            }
            C.Nationality = txtNationality.Text.Trim();
            C.Religion = txtReligion.Text.Trim();
            C.CMOffice1 = txtMOfficePhone1.Text.Trim();
            C.CMOffice2 = txtMOfficePhone2.Text.Trim();
            C.CMMobile = txtMMobilePhone.Text.Trim();
            C.CMEmail = txtMEmail.Text.Trim();
            C.CMFax1 = txtMFax1.Text.Trim();
            C.CMFax2 = txtMFax2.Text.Trim();
            C.CMHomeNo = txtMHomeNo.Text.Trim();
            C.CMStreet = txtMStreet.Text.Trim();
            C.CMTownship = txtMTownship.Text.Trim();
            C.CMCity = txtMCity.Text.Trim();
            if (cboMCountry.SelectedIndex == -1)
            {
                C.CMCountry = "";
            }
            else
            {
                C.CMCountry = cboMCountry.SelectedValue.ToString();            
            }
            
            C.CMZipCode = txtMZipCode.Text.Trim();
            if (chkSame.Checked == true)
            {
                C.CDOffice1 = txtMOfficePhone1.Text.Trim();
                C.CDOffice2 = txtMOfficePhone2.Text.Trim();
                C.CDMobile = txtMMobilePhone.Text.Trim();
                C.CDEmail = txtMEmail.Text.Trim();
                C.CDFax1 = txtMFax1.Text.Trim();
                C.CDFax2 = txtMFax2.Text.Trim();
                C.CDHomeNo = txtMHomeNo.Text.Trim();
                C.CDStreet = txtMStreet.Text.Trim();
                C.CDTownship = txtMTownship.Text.Trim();
                C.CDCity = txtMCity.Text.Trim();
                if (cboMCountry.SelectedIndex == -1)
                {
                    C.CDCountry = "";
                }
                else
                {
                    C.CDCountry =cboMCountry.SelectedValue.ToString();
                }
                C.CDZipCode = txtMZipCode.Text.Trim();
            }
            else if (chkSame.Checked == false)
            {
                C.CDOffice1 = txtDOfficePhone1.Text.Trim();
                C.CDOffice2 = txtDOfficePhone2.Text.Trim();
                C.CDMobile = txtDMobilePhone.Text.Trim();
                C.CDEmail = txtDEmail.Text.Trim();
                C.CDFax1 = txtDFax1.Text.Trim();
                C.CDFax2 = txtDFax2.Text.Trim();
                C.CDHomeNo = txtDHomeNo.Text.Trim();
                C.CDStreet = txtDStreet.Text.Trim();
                C.CDTownship = txtDTownship.Text.Trim();
                C.CDCity = txtDCity.Text.Trim();
                if (cboDCountry.SelectedIndex == -1)
                {
                    C.CDCountry = "";
                }
                else
                {
                    C.CDCountry = cboDCountry.SelectedValue.ToString();
                }
                C.CDZipCode = txtDZipCode.Text.Trim();
            }
            C.CWebsite = txtWebsite.Text.Trim();
            C.CFacebook = txtFacebook.Text.Trim();
            
            if (EID == null)
            {
                C.CreatedEID = "";
            }
            else
            {
                C.CreatedEID = EID;
            }

        }
        #endregion

        #region Savecheck
        private bool savecheck()
        {

            if (txtCustomerID.Text.Trim() == "" && txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Focus();
                return false;
            }
            else if (txtCustomerID.Text.Trim() == "" && txtCustomerName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Customer ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Focus();
                return false;
            }
            else if (txtCustomerID.Text.Trim() != "" && txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Customer Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Save
        private void save()
        {
            if (savecheck())
            {
                dataassign();
                if (C.IsEdit)
                {
                    C.Upd_Customer();
                    C.IsEdit = false;
                }
                else
                {
                    C.Ins_Customer();
                }
                Loading();
            }
        }
        #endregion

        #region ComboBind
        private void SCountryComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = C.CallCountry();
                cboSCountry.DataSource = tbl;
                cboSCountry.DisplayMember = "CountryName";
                cboSCountry.ValueMember = "CountryID";
                cboSCountry.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void MCountryComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = C.CallCountry();
                cboMCountry.DataSource = tbl;
                cboMCountry.DisplayMember = "CountryName";
                cboMCountry.ValueMember = "CountryID";
                cboMCountry.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void DCountryComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = C.CallCountry();
                cboDCountry.DataSource = tbl;
                cboDCountry.DisplayMember = "CountryName";
                cboDCountry.ValueMember = "CountryID";
                cboDCountry.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void CustomerTypeComboeBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = CT.CallCustomerType();
                cboCustomerType.DataSource = tbl;
                cboCustomerType.DisplayMember = "CTName";
                cboCustomerType.ValueMember = "CTID";
                cboCustomerType.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void SCityComboBind()
        {
            try
            {
                C.CMCountry = cboSCountry.SelectedValue.ToString();
                DataTable tbl = new DataTable();
                tbl = C.CallCitybyMCountry();
                cboSCity.DataSource = tbl;
                cboSCity.DisplayMember = "CMCity";
                cboSCity.ValueMember = "ID";
                cboSCity.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void STownshipComboBind()
        {
            try
            {
                C.CMCity = cboSCity.Text.ToString();
                DataTable tbl = new DataTable();
                tbl = C.CallTownshipbyMCity();
                cboSTownship.DataSource = tbl;
                cboSTownship.DisplayMember = "CMTownship";
                cboSTownship.ValueMember = "ID";
                cboSTownship.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion

          

        #endregion

        #region Search
        private void Search()
        {
            
                if (txtSCustomerName.Text == "" && cboSCountry.SelectedIndex == -1)
                {
                    MessageBox.Show("Invalid Paramter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSCountry.Focus();
                }
                else if ((txtSCustomerName.Text == "" && cboSCountry.SelectedIndex != -1) || (txtSCustomerName.Text != "" && cboSCountry.SelectedIndex == -1) || (txtSCustomerName.Text != "" && cboSCountry.SelectedIndex != -1))
                {
                    searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = C.SearchCustomer();
                    dgvSCustomer.DataSource = tbl;
                }
            
            
        }

        private void ShowAll()
        {
            showalldataassign();
            DataTable tbl = new DataTable();
            tbl = C.SearchCustomer();
            dgvSCustomer.DataSource = tbl;
        }

        #endregion

        #region SearchCheckboxValidation
        private void SearchCheckboxValidation()
        {
            if (chkSCustomerName.Checked == true)
            {
                txtSCustomerName.Enabled = true;
               

            }
            else 
            {
                txtSCustomerName.Enabled = false;
            }

            if (chkSCountry.Checked == true)
            {
                M.Combobox_Enable(true, cboSCountry, cboSCity, cboSTownship);
            }
            else
            {
                M.Combobox_Enable(false, cboSCountry, cboSCity, cboSTownship);
            }
        }
        #endregion

        #region GridClick
        private void gridclick()
        {
            Loading();
            M.Button_Enable(true, btnNew, btnEdit, btnDelete, btnCancel);
            CustomerTypeComboeBind();
            MCountryComboBind();
            DCountryComboBind();
            
        }
        #endregion

       
        private void lblCompanyID_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblTownship_Click(object sender, EventArgs e)
        {

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboSCountry.Enabled = false;
            cboSCity.Enabled = false;
            cboSCountry.Enabled = false;
            cboSTownship.Enabled = false;
            chkSCountry.Enabled = false;
            //pnlSCustomer.Visible = true;
            SearchPanelLoading();
            SearchCheckboxValidation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
            
            
        }

        private void btnSShowAll_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvSCustomer_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCustomerName.Focus();

            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboCustomerType.Focus();

            }
        }

        private void cboCustomerType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNRCNo.Focus();

            }
        }

        private void txtNRCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNRCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMOfficePhone1.Focus();

            }
        }

        private void txtPrimaryPhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMEmail.Focus();

            }
        }

        private void txtMEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMOfficePhone2.Focus();

            }
        }

        private void txtSecondaryPhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMFax1.Focus();

            }
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMHomeNo.Focus();

            }
        }

        private void txtMHomeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMTownship.Focus();

            }
        }

        private void txtMTownship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMStreet.Focus();

            }
        }

        private void txtMStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMCity.Focus();

            }
        }

        private void txtMCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
//                txtCountry.Focus();

            }
        }

        private void cboSCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpbCustomerInfo_Enter(object sender, EventArgs e)
        {

        }

        private void cboSCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            
            M.Button_Enable(true, btnSave, btnCancel, btnCustomerType);
            M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            M.TextBox_Clear(txtCustomerID, txtCustomerName, txtNRCNo, txtNationality, txtReligion, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);
            M.Combobox_Clear(cboCustomerType, cboDCountry, cboMaritalStatus);
            gpbCustomerInfo.Enabled = true;
            tbcContactIno.Enabled = true;
            M.TextBox_Enable(true, txtCustomerName, txtNRCNo);//, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);
            M.TextBox_Enable(false, txtCustomerID, txtNationality, txtReligion);
            M.DateTimePicker_Enable(false, dtpDOB);
            M.RadioButton_Enable(false, rdbMale, rdbFemale);
            M.RadioButton_Clear(rdbFemale, rdbMale);
            M.Combobox_Enable(false, cboMaritalStatus);
            cboCustomerType.Enabled = true;
            AutoID();
            CustomerTypeComboeBind();
            MCountryComboBind();
            DCountryComboBind();
            txtCustomerName.Focus();
            
        }

        private void btnSShowAll_Click_1(object sender, EventArgs e)
        {
            ShowAll();
            dgvSCustomer.Enabled = true;
            
            SearchCheckboxValidation();
            
        }

        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomerType.SelectedIndex == 0)
            {
                dtpDOB.Enabled = false;
                M.RadioButton_Clear(rdbMale, rdbFemale);
                M.RadioButton_Enable(false, rdbFemale, rdbMale);
                M.TextBox_Clear(txtReligion, txtNationality, txtNRCNo);
                M.TextBox_Enable(false, txtReligion, txtNationality, txtNRCNo);
                cboMaritalStatus.SelectedIndex = -1;
                cboMaritalStatus.Enabled = false;

            }
            else if (cboCustomerType.SelectedIndex == 1)
            {
                dtpDOB.Enabled = true;
                M.RadioButton_Clear(rdbMale, rdbFemale);
                M.RadioButton_Enable(true, rdbFemale, rdbMale);
                M.TextBox_Clear(txtReligion, txtNationality, txtNRCNo);
                M.TextBox_Enable(true, txtReligion, txtNationality, txtNRCNo);
                cboMaritalStatus.Enabled = true;
               
                
            }
        }

        private void tbpSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            save();
        }

        private void chkSame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSame.Checked == true)
            {
                M.TextBox_Clear(txtDOfficePhone1, txtDOfficePhone2, txtDMobilePhone, txtDEmail, txtDFax1, txtDFax2, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode);
                M.TextBox_Enable(false, txtDOfficePhone1, txtDOfficePhone2, txtDMobilePhone, txtDEmail, txtDFax1, txtDFax2, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode);
                cboDCountry.SelectedIndex = -1;
                cboDCountry.Enabled = false;
            }
            else
            {
                txtDOfficePhone1.Focus();
            }
        
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataassign();
                C.Del_Customer();
                Loading();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            M.Button_Enable(true, btnSave, btnCancel, btnDelete, btnCustomerType);
            M.Button_Enable(false, btnNew);
            cboCustomerType.Enabled = true;
            gpbCustomerInfo.Enabled = true;
            tbcContactIno.Enabled = true;
            txtCustomerName.Focus();
            C.IsEdit = true;
           
            
          
         
            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Loading(); 
        }

        private void btnSDelete_Click_1(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvSCustomer.Rows.Count - 1; i++)
            {
                drow = dgvSCustomer.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string c in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                C.CID = c;
                C.Del_Customer();
                ShowAll(); 

            }

            
        }

        private void btnSSearch_Click_1(object sender, EventArgs e)
        {
            if (chkSCustomerName.Checked == false && chkSCountry.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSCustomerName.Focus();
            }
            
            else
            {
                Search();
                dgvSCustomer.Enabled = true;
               
            }
        }

        private void dgvSCustomer_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkSCustomerName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSCustomerName.Checked == true)
            {
                txtSCustomerName.Enabled = true;
                txtSCustomerName.Focus();
            }
            else
            {
                txtSCustomerName.Enabled = false;
                txtSCustomerName.Clear();
            }
        }

        private void chkSCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSCountry.Checked == true)
            {
                SCountryComboBind();
                cboSCountry.Enabled = true;
                cboSCountry.Focus();
            }
            else
            {
                cboSCountry.Enabled = false;
                cboSCountry.SelectedIndex = -1;
                cboSCity.SelectedIndex = -1;
                cboSTownship.SelectedIndex = -1;
            }
        }

        private void cboSCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSCountry.SelectedIndex != -1)
            {
                
                cboSCity.Enabled = true;
                SCityComboBind();
                cboSCity.Focus();
            }
            else
            {
                cboSCity.Enabled = false;
                cboSCity.SelectedIndex = -1;
                cboSTownship.SelectedIndex = -1;
                
            }
        }

        private void cboSCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboSCity.SelectedIndex != -1)
            {
                cboSTownship.Enabled = true;
                STownshipComboBind();
                cboSTownship.Focus();
            }
            else
            {
                cboSTownship.Enabled = false;
                cboSTownship.SelectedIndex = -1;
                
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboCustomerType.Focus();
            }
        }

        private void cboCustomerType_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (cboCustomerType.SelectedIndex == 0)
                {
                    txtMOfficePhone1.Focus();
                }
                else if (cboCustomerType.SelectedIndex == 1)
                {
                    txtNRCNo.Focus();
                }
                
            }
        }

        private void txtNRCNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpDOB.Focus();
            }
        }

        private void dtpDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rdbMale.Focus();
            }
        }

        private void rdbMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboMaritalStatus.Focus();
            }
        }

        private void rdbFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboMaritalStatus.Focus();
            }
        }

        private void cboMaritalStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNationality.Focus();
            }
        }

        private void txtNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtReligion.Focus();
            }
        }

        private void txtReligion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMOfficePhone1.Focus();
            }
        }

        private void txtMOfficePhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMMobilePhone.Focus();
            }
        }

        private void txtMOfficePhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMOfficePhone2.Focus();
            }
        }

        private void txtMMobilePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMEmail.Focus();
            }   
        }

        private void txtMEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMFax1.Focus();
            }
        }

        private void txtMFax1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMFax2.Focus();
            }
        }

        private void txtMFax2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMHomeNo.Focus();
            }
        }

        private void txtMHomeNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMStreet.Focus();
            }
        }

        private void txtMStreet_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMTownship.Focus();
            }
        }

        private void txtMTownship_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMCity.Focus();
            }
        }

        private void txtMCity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboMCountry.Focus();
            }
        }

        private void cboMCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMZipCode.Focus();
            }
        }

        private void txtMZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbcContactIno.SelectedTab = tbpDeliveryInfo;
                chkSame.Focus();
            }
        }

        private void txtDOfficePhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDOfficePhone2.Focus();
            }
        }

        private void txtDOfficePhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDMobilePhone.Focus();
            }
        }

        private void txtDMobilePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDEmail.Focus();
            }
        }

        private void txtDEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDFax1.Focus();
            }
        }

        private void txtDFax1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDFax2.Focus();
            }
        }

        private void txtDFax2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDHomeNo.Focus();
            }
        }

        private void txtDHomeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDStreet.Focus();
            }
        }

        private void txtDStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDTownship.Focus();
            }
        }

        private void txtDTownship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDCity.Focus();
            }
        }

        private void txtDCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboDCountry.Focus();
            }
        }

        private void cboDCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDZipCode.Focus();
            }
        }

        private void txtDZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbcContactIno.SelectedTab = tbpWebInfo;
                txtWebsite.Focus();
            }
        }

        private void txtWebsite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFacebook.Focus();
            }
        }

        private void txtFacebook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                save();
            }
        }

        private void txtMZipCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
