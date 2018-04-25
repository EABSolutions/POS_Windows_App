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
    public partial class frmsupplier : Form
    {
        Class.clsSupplier S = new Class.clsSupplier();
        Class.clsMethods M = new Class.clsMethods();
        Class.clsCustomer C = new Class.clsCustomer();
        DataTable dt;
        public string EID;
        public string CompID;
       
       
        public frmsupplier()
        {
            InitializeComponent();
            Loading();
         }
        #region Methods

        #region Loading
        private void Loading()
        {
            M.Button_Enable(true, btnNew);
            M.Button_Enable(false, btnSave, btnEdit, btnDelete, btnCancel);
            M.TextBox_Clear(txtSSupplierName, txtSupplierID, txtSupplierName, txtLeadName, txtLeadContactNo, txtLeadEmail, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);
            M.Combobox_Enable(false, cboSTownship, cboSCity, cboSCountry);
            txtSSupplierName.Enabled = false;
            gpbSupplierInfo.Enabled = false;
            tbcContactIno.Enabled = false;
            cboMCountry.SelectedIndex = -1;
            cboDCountry.SelectedIndex = -1;
            btnNew.Focus();
        }
        #endregion

        #region AutoID
        private void AutoID()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = S.AutoID_Supplier();
                txtSupplierID.Text = tbl.Rows[0][0].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion


        #region GridDataClear
        private void GridDataClear()
        {
            if (this.dgvSSupplier.DataSource != null)
            {
                this.dgvSSupplier.DataSource = null;
            }
            else
            {
                this.dgvSSupplier.Rows.Clear();
            }
        }
        #endregion

        #region SearchPanelLoading
        private void SearchPanelLoading()
        {
            //pnlSCustomer.Visible = true;
            chkSSupplierName.Checked = false;
            //CustomerComboBind();
            SearchCheckboxValidation();
            GridDataClear();
            dgvSSupplier.Enabled = false;
            txtSSupplierName.Enabled = false;
        }
        #endregion

        #region SearchDataassign
        private void searchdataassign()
        {
            S.SName = txtSSupplierName.Text.Trim();
            if (cboSCountry.SelectedIndex == -1)
            {
                S.SMCountry = "";
                S.SMCity = "";
                S.SMTownship = "";
            }
            else
            {
                S.SMCountry = cboSCountry.SelectedValue.ToString();
                S.SMCity = cboSCity.Text.ToString();
                S.SMTownship = cboSTownship.Text.ToString();
            }
        }
        #endregion

        #region ShowallDataassign
        private void showalldataassign()
        {
            S.SName = "";
            S.SMCountry = "";
            S.SMCity = "";
            S.SMTownship = "";
          
        }
        #endregion

        #region Dataassign
        private void dataassign()
        {
            S.SID = txtSupplierID.Text.Trim();
            S.SName = txtSupplierName.Text.Trim();
            S.SLeadName = txtLeadName.Text.Trim();
            S.SLeadContactNo = txtLeadContactNo.Text.Trim();
            S.SLeadEmail = txtLeadEmail.Text.Trim();
            S.SMOffice1 = txtMOfficePhone1.Text.Trim();
            S.SMOffice2 = txtMOfficePhone2.Text.Trim();
            S.SMMobile = txtMMobilePhone.Text.Trim();
            S.SMEmail = txtMEmail.Text.Trim();
            S.SMFax1 = txtMFax1.Text.Trim();
            S.SMFax2 = txtMFax2.Text.Trim();
            S.SMHomeNo = txtMHomeNo.Text.Trim();
            S.SMTownship = txtMTownship.Text.Trim();
            S.SMStreet = txtMStreet.Text.Trim();
            S.SMCity = txtMCity.Text.Trim();
            if (cboMCountry.SelectedIndex == -1)
            {
                S.SMCountry = "";
            }
            else
            {
                S.SMCountry = cboMCountry.SelectedValue.ToString();
            }
            S.SMZipCode = txtMZipCode.Text.Trim();
            if (chkSame.Checked == true)
            {
                S.SDOffice1 = txtMOfficePhone1.Text.Trim();
                S.SDOffice2 = txtMOfficePhone2.Text.Trim();
                S.SDMobile = txtMMobilePhone.Text.Trim();
                S.SDEmail = txtMEmail.Text.Trim();
                S.SDFax1 = txtMFax1.Text.Trim();
                S.SDFax2 = txtMFax2.Text.Trim();
                S.SDHomeNo = txtMHomeNo.Text.Trim();
                S.SDStreet = txtMStreet.Text.Trim();
                S.SDTownship = txtMTownship.Text.Trim();
                S.SDCity = txtMCity.Text.Trim();
                if (cboMCountry.SelectedIndex == -1)
                {
                    S.SDCountry = "";
                }
                else
                {
                    S.SDCountry = cboMCountry.SelectedValue.ToString();
                }
                S.SDZipCode = txtMZipCode.Text.Trim();
            }
            else if (chkSame.Checked == false)
            {
                S.SDOffice1 = txtDOfficePhone1.Text.Trim();
                S.SDOffice2 = txtDOfficePhone2.Text.Trim();
                S.SDMobile = txtDMobilePhone.Text.Trim();
                S.SDEmail = txtDEmail.Text.Trim();
                S.SDFax1 = txtDFax1.Text.Trim();
                S.SDFax2 = txtDFax2.Text.Trim();
                S.SDHomeNo = txtDHomeNo.Text.Trim();
                S.SDStreet = txtDStreet.Text.Trim();
                S.SDTownship = txtDTownship.Text.Trim();
                S.SDCity = txtDCity.Text.Trim();
                if (cboDCountry.SelectedIndex == -1)
                {
                    S.SDCountry = "";
                }
                else
                {
                    S.SDCountry = cboDCountry.SelectedValue.ToString();
                }
                S.SDZipCode = txtDZipCode.Text.Trim();
            }
            S.SWebsite = txtWebsite.Text.Trim();
            S.SFacebook = txtFacebook.Text.Trim();
            if (EID == null)
            {
                S.CreatedEID = "";
            }
            else
            {
                S.CreatedEID = EID;
            }
        }
        #endregion

        #region Savecheck
        private bool savecheck()
        {

            if (txtSupplierID.Text.Trim() == "" && txtSupplierName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierID.Focus();
                return false;
            }
            else if (txtSupplierID.Text.Trim() == "" && txtSupplierName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Supplier ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierID.Focus();
                return false;
            }
            else if (txtSupplierID.Text.Trim() != "" && txtSupplierName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Supplier Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierName.Focus();
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
                if (S.IsEdit)
                {
                    S.Upd_Supplier();
                    S.IsEdit = false;
                }
                else
                {
                    S.Ins_Supplier();
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


        private void SCityComboBind()
        {
            try
            {
                S.SMCountry = cboSCountry.SelectedValue.ToString();
                DataTable tbl = new DataTable();
                tbl = S.CallCitybyMCountry();
                cboSCity.DataSource = tbl;
                cboSCity.DisplayMember = "SMCity";
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
                S.SMCity = cboSCity.Text.ToString();
                DataTable tbl = new DataTable();
                tbl = S.CallTownshipbyMCity();
                cboSTownship.DataSource = tbl;
                cboSTownship.DisplayMember = "SMTownship";
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

            if (txtSSupplierName.Text == "" && cboSCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid Paramter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSCountry.Focus();
            }
            else if ((txtSSupplierName.Text == "" && cboSCountry.SelectedIndex != -1) || (txtSSupplierName.Text != "" && cboSCountry.SelectedIndex == -1) || (txtSSupplierName.Text != "" && cboSCountry.SelectedIndex != -1))
            {
                searchdataassign();
                DataTable tbl = new DataTable();
                tbl = S.SearchSupplier();
                dgvSSupplier.DataSource = tbl;
            }
        }

        private void ShowAll()
        {
            showalldataassign();
            DataTable tbl = new DataTable();
            tbl = S.SearchSupplier();
            dgvSSupplier.DataSource = tbl;
        }

        #endregion

        #region SearchCheckboxValidation
        private void SearchCheckboxValidation()
        {
            if (chkSSupplierName.Checked == true)
            {
                txtSSupplierName.Enabled = true;


            }
            else
            {
                txtSSupplierName.Enabled = false;
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

        private void txtLeadName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLeadContactNo_Click(object sender, EventArgs e)
        {

        }

        private void txtSLeadEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStreet_Click(object sender, EventArgs e)
        {

        }

        private void txtTownship_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFax_TextChanged(object sender, EventArgs e)
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
            Loading(); 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            M.Button_Enable(true, btnSave, btnCancel);
            M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            M.TextBox_Clear(txtSupplierID, txtSupplierName, txtLeadName, txtLeadContactNo, txtLeadEmail, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);
            M.Combobox_Clear(cboDCountry, cboMCountry);
            M.Combobox_Enable(true, cboDCountry, cboMCountry);
            gpbSupplierInfo.Enabled = true;
            tbcContactIno.Enabled = true;
            M.TextBox_Enable(true, txtSupplierName, txtLeadName, txtLeadContactNo, txtLeadEmail, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);//, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);
            M.TextBox_Enable(false, txtSupplierID);
            AutoID();
            MCountryComboBind();
            DCountryComboBind();
            txtSupplierName.Focus();
            

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtSupplierName, txtLeadName, txtLeadContactNo, txtLeadEmail, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);//, txtMOfficePhone1, txtMOfficePhone2, txtMMobilePhone, txtMEmail, txtMFax1, txtMFax2, txtMHomeNo, txtMStreet, txtMTownship, txtMCity, txtMZipCode, txtDOfficePhone1, txtDOfficePhone1, txtDMobilePhone, txtDFax1, txtDFax2, txtDEmail, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode, txtWebsite, txtFacebook);
            M.Combobox_Enable(true, cboDCountry, cboMCountry);
            M.Button_Enable(true, btnSave, btnCancel, btnDelete);
            M.Button_Enable(false, btnNew);
            txtSupplierName.Focus();
            S.IsEdit = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataassign();
                S.Del_Supplier();
                Loading();
            }
        }

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSSupplierName_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSShowAll_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
           
            }
        

        private void dgvSSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridclick();
                txtSupplierID.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Supplier ID"].Value.ToString();
                txtSupplierName.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Supplier Name"].Value.ToString();
                txtLeadName.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Lead Name"].Value.ToString();
                txtLeadContactNo.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Lead ContactNo"].Value.ToString();
                txtLeadEmail.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Lead Email"].Value.ToString();
                //txtPrimaryPhoneNo.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Primary PhNo"].Value.ToString();
                //txtSecondaryPhoneNo.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Secondary PhNo"].Value.ToString();
                txtMEmail.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                //txtFax.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Fax"].Value.ToString();
                //txtHomeNo.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Home No"].Value.ToString();
                //txtTownship.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Township"].Value.ToString();
                //txtStreet.Text = dgvSSupplier.Rows[e.RowIndex].Cells["Street"].Value.ToString();
                //txtCity.Text = dgvSSupplier.Rows[e.RowIndex].Cells["City"].Value.ToString();
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvSSupplier.Rows.Count - 1; i++)
            {
                drow = dgvSSupplier.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                S.SID = s;
                S.Del_Supplier();

            }

            ShowAll(); 
        }

        private void txtSupplierID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSupplierName.Focus();

            }
        }

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtLeadName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtLeadContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLeadContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtLeadEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               // txtPrimaryPhoneNo.Focus();

            }
        }

        private void txtPrimaryPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimaryPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
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
              //  txtSecondaryPhoneNo.Focus();

            }
        }

        private void txtSecondaryPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //txtFax.Focus();

            }
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               // txtHomeNo.Focus();

            }
        }

        private void txtHomeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //txtTownship.Focus();

            }
        }

        private void txtTownship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //txtStreet.Focus();

            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //txtCity.Focus();

            }
        }

        private void btnNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSupplierID.Focus();
                M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //txtCountry.Focus();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkSame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSame.Checked == true)
            {
                M.TextBox_Clear(txtDOfficePhone1, txtDOfficePhone2, txtDMobilePhone, txtDEmail, txtDFax1, txtDFax2, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode);
                M.TextBox_Enable(false, txtDOfficePhone1, txtDOfficePhone2, txtDMobilePhone, txtDEmail, txtDFax1, txtDFax2, txtDHomeNo, txtDStreet, txtDTownship, txtDCity, txtDZipCode);
                cboDCountry.SelectedIndex = -1;
                cboDCountry.Enabled = false;
                tbcContactIno.SelectedTab = tbpWebInfo;
                txtWebsite.Focus();
            }
            else
            {
                txtDOfficePhone1.Focus();
            }
            
        }

        private void txtSupplierName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtLeadName.Focus();

            }
        }

        private void txtLeadName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtLeadContactNo.Focus();

            }
        }

        private void txtLeadContactNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtLeadEmail.Focus();

            }
        }

        private void txtLeadEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbcContactIno.SelectedTab = tpbMailingInfo;
                txtMOfficePhone1.Focus();

            }
        }

        private void txtMOfficePhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMOfficePhone2.Focus();

            }
        }

        private void txtMOfficePhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMMobilePhone.Focus();

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

        private void txtMHomeNo_KeyPress(object sender, KeyPressEventArgs e)
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
                txtMTownship.Focus();

            }
        }

        private void txtMTownship_KeyPress(object sender, KeyPressEventArgs e)
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
                chkSame.Focus();
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

        private void chkSSupplierName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSSupplierName.Checked == true)
            {
                txtSSupplierName.Enabled = true;
                txtSSupplierName.Focus();
            }
            else
            {
                txtSSupplierName.Enabled = false;
                txtSSupplierName.Clear();
            }
        }

        private void txtSSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (chkSSupplierName.Checked == false && chkSSupplierName.Checked == false)
                {
                    MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkSSupplierName.Focus();
                }
                else if (chkSSupplierName.Checked == true && chkSSupplierName.Checked == false)
                {
                    Search();
                    dgvSSupplier.Enabled = true;
                }
                else if (chkSSupplierName.Checked == false && chkSSupplierName.Checked == true)
                {
                    Search();
                    dgvSSupplier.Enabled = true;
                }

                else
                {
                    Search();
                    dgvSSupplier.Enabled = true;
                }
            }
        }

        private void btnSSearch_Click_1(object sender, EventArgs e)
        {
            if (chkSSupplierName.Checked == false && chkSCountry.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSSupplierName.Focus();
            }

            else
            {
                Search();
                dgvSSupplier.Enabled = true;

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

        private void cboSCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboSCity.Focus();
            }
        }

        private void cboSCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboSTownship.Focus();
            }
        }

        private void cboSTownship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (chkSSupplierName.Checked == false && chkSSupplierName.Checked == false)
                {
                    MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkSSupplierName.Focus();
                }
                else if (chkSSupplierName.Checked == true && chkSSupplierName.Checked == false)
                {
                    Search();
                    dgvSSupplier.Enabled = true;
                }
                else if (chkSSupplierName.Checked == false && chkSSupplierName.Checked == true)
                {
                    Search();
                    dgvSSupplier.Enabled = true;
                }

                else
                {
                    Search();
                    dgvSSupplier.Enabled = true;
                }
            }
        }

        private void btnSShowAll_Click_1(object sender, EventArgs e)
        {
            ShowAll();
            dgvSSupplier.Enabled = true;

            SearchCheckboxValidation();
        }

        private void frmsupplier_Load(object sender, EventArgs e)
        {
            btnNew.Focus();
        }

        private void dgvSSupplier_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

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

        private void cboSCity_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnSDelete_Click_1(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvSSupplier.Rows.Count - 1; i++)
            {
                drow = dgvSSupplier.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string c in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                S.SID = c;
                S.Del_Supplier();
                ShowAll();

            }
        }
    }
}
