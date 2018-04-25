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
    public partial class frmProductHirachy : Form
    {
        Class.clsProductLine PL = new Class.clsProductLine();
        Class.clsCoreProductFamily CPF = new Class.clsCoreProductFamily();
        Class.clsProductFamily PF = new Class.clsProductFamily();
        Class.clsProductClass PC = new Class.clsProductClass();
        Class.clsProduct P = new Class.clsProduct();
        Class.clsManufacturer Manu = new Class.clsManufacturer();
        Class.clsCustomer cus = new Class.clsCustomer();
        Class.clsBrand B = new Class.clsBrand();
        Class.clsMethods M = new Class.clsMethods();
        
        DataTable dt;
        public string EID;
        public string CompID;
       

        public frmProductHirachy()
        {
            InitializeComponent();
            Loading();
        }

        #region Methods

        #region Loading
        private void Loading()
        {
            M.Combobox_Enable(false, cboProductClassName, cboCPFName, cboPFName, cboManuCountry, cboManuName, cboPBName, cboPPLName);
            M.TextBox_Enable(false, txtProductLineID, txtProductLineName, txtDescription, txtCPFIDr, txtCPFNamer, txtCPFDescriptionr, txtPFID, txtPFName, txtPFDescription, txtPCID, txtPCName, txtPCDescription, txtManuID, txtManuName, txtManuCity, txtBID, txtBName, txtBDescription, txtPID, txtPName, txtPDescription);
            M.Button_Enable(true, btnNew, btnCPFNewr, btnPFNew, btnPCNew, btnManuNew, btnBNew, btnPNew);
            M.Button_Enable(false, btnSave, btnEdit, btnDelete, btnCancel, btnCPFSaver, btnCPFEditr, btnCPFDeleter, btnCPFCancelr, btnPFSave, btnPFEdit, btnPFDelete, btnPFCancel, btnPCSave, btnPCEdit, btnPCDelete, btnPCCancel, btnManuSave, btnManuEdit, btnManuDelete, btnManuCancel, btnBSave,btnBEdit, btnBDelete, btnBCancel, btnPSave, btnPEdit, btnPDelete, btnPCancel);
            M.TextBox_Clear(txtProductLineID, txtProductLineName, txtDescription, txtCPFIDr, txtCPFNamer, txtCPFDescriptionr, txtPFID, txtPFName, txtPFDescription, txtPCID, txtPCName, txtPCDescription, txtManuID, txtManuName, txtManuCity, txtBID, txtBName, txtBDescription, txtPID, txtPName, txtPDescription);
            cboCPFName.SelectedIndex = -1;
            cboPFName.SelectedIndex = -1;
            cboProductClassName.SelectedIndex = -1;
            cboManuCountry.SelectedIndex = -1;
            cboManuName.SelectedIndex = -1;
            cboPBName.SelectedIndex = -1;
            cboPPLName.SelectedIndex = -1;
            SearchCheckboxValidation();
            CPF_SearchCheckboxValidation();
            PF_SearchCheckboxValidation();
            PC_SearchCheckboxValidation();
            Manu_SearchCheckboxValidation();
            B_SearchCheckboxValidation();
            P_SearchCheckboxValidation();
            btnCPFNewr.Focus();
            

        }
        #endregion

        #region AutoID
        private void AutoID_ProductLine()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PL.AutoID_Product_Line();
                txtProductLineID.Text = tbl.Rows[0][0].ToString();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void AutoID_CPF()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = CPF.AutoID_CPF();
                txtCPFIDr.Text = tbl.Rows[0][0].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void AutoID_PF()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PF.AutoID_PF();
                txtPFID.Text = tbl.Rows[0][0].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void AutoID_PC()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PC.AutoID_PC();
                txtPCID.Text = tbl.Rows[0][0].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void AutoID_Manu()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = Manu.AutoID_Manufacturer();
                txtManuID.Text = tbl.Rows[0][0].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void AutoID_Brand()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = B.AutoID_Brand();
                txtBID.Text = tbl.Rows[0][0].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void AutoID_Product()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = P.AutoID_Product();
                txtPID.Text = tbl.Rows[0][0].ToString();

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
            if (this.dgvSProductLine1.DataSource != null)
            {
                this.dgvSProductLine1.DataSource = null;
            }
            else
            {
                this.dgvSProductLine1.Rows.Clear();
            }

        }

        private void CPF_GridDataClear()
        {
            if (this.dgvCoreProductFamily.DataSource != null)
            {
                this.dgvCoreProductFamily.DataSource = null;
            }
            else
            {
                this.dgvCoreProductFamily.Rows.Clear();
            }

        }

        private void PF_GridDataClear()
        {
            if (this.dgvProductFamily.DataSource != null)
            {
                this.dgvProductFamily.DataSource = null;
            }
            else
            {
                this.dgvProductFamily.Rows.Clear();
            }

        }

        private void PC_GridDataClear()
        {
            if (this.dgvProductClass.DataSource != null)
            {
                this.dgvProductClass.DataSource = null;
            }
            else
            {
                this.dgvProductClass.Rows.Clear();
            }

        }

        private void Manu_GridDataClear()
        {
            if (this.dgvManufacturer.DataSource != null)
            {
                this.dgvManufacturer.DataSource = null;
            }
            else
            {
                this.dgvManufacturer.Rows.Clear();
            }

        }


        private void B_GridDataClear()
        {
            if (this.dgvBrand.DataSource != null)
            {
                this.dgvBrand.DataSource = null;
            }
            else
            {
                this.dgvBrand.Rows.Clear();
            }

        }


        private void P_GridDataClear()
        {
            if (this.dgvProduct.DataSource != null)
            {
                this.dgvProduct.DataSource = null;
            }
            else
            {
                this.dgvProduct.Rows.Clear();
            }

        }
        #endregion

       

        #region SearchDataassign
        private void PL_searchdataassign()
        {
           
            if (chkProductClassName1.Checked == true && chkProductLineName1.Checked == false)
            {
                PL.PCID = cboSProductClassName1.SelectedValue.ToString();
                PL.PLID = "";
            }
            else if (chkProductClassName1.Checked == false && chkProductLineName1.Checked == true)
            {
                PL.PCID = "";
                PL.PLID = cboProductLineName1.SelectedValue.ToString();
            }
            else if (chkProductClassName1.Checked == false && chkProductLineName1.Checked == false)
            {
                PL.PCID = "";
                PL.PLID = "";
            }
            else
            {
                PL.PCID = cboSProductClassName1.SelectedValue.ToString();
                PL.PLID = cboProductLineName1.SelectedValue.ToString();
            }
        }


        private void CPF_searchdataassign()
        {
            CPF.CPFID = cboSCPFNamer.SelectedValue.ToString();
        }


        private void PF_searchdataassign()
        {
            if (chkSPFCPFName.Checked == true && chkSPFName.Checked == false)
            {
                PF.CPFID = cboSPFCPFName.SelectedValue.ToString();
                PF.PFID = "";
            }
            else if (chkSPFCPFName.Checked == false && chkSPFName.Checked == true)
            {
                PF.CPFID = "";
                PF.PFID = cboSPFName.SelectedValue.ToString();
            }
            else if (chkSPFCPFName.Checked == false && chkSPFName.Checked == false)
            {
                PF.CPFID = "";
                PF.PFID = "";
            }
            else
            {
                PF.CPFID = cboSPFCPFName.SelectedValue.ToString();
                PF.PFID = cboSPFName.SelectedValue.ToString();
            }
        }


        private void PC_searchdataassign()
        {
            if (chkSPCPFName.Checked == true && chkSPCName.Checked == false)
            {
                PC.PFID = cboSPCPFName.SelectedValue.ToString();
                PC.PCID = "";
            }
            else if (chkSPCPFName.Checked == false && chkSPCName.Checked == true)
            {
                PC.PFID = "";
                PC.PCID = cboSPCName.SelectedValue.ToString();
            }
            else if (chkSPCPFName.Checked == false && chkSPCName.Checked == false)
            {
                PC.PFID = "";
                PC.PCID = "";
            }
            else
            {
                PC.PFID = cboSPCPFName.SelectedValue.ToString();
                PC.PCID = cboSPCName.SelectedValue.ToString();
            }
        }


        private void Manu_searchdataassign()
        {
            Manu.MID = cboSManuName.SelectedValue.ToString();
        }


        private void B_searchdataassign()
        {
            if (chkSBManuName.Checked == true && chkSBName.Checked == false)
            {
                B.MID = cboSBManuName.SelectedValue.ToString();
                B.BID = "";
            }
            else if (chkSBManuName.Checked == false && chkSBName.Checked == true)
            {
                B.MID = "";
                B.BID = cboSBName.SelectedValue.ToString();
            }
            else if (chkSBManuName.Checked == false && chkSBName.Checked == false)
            {
                B.MID = "";
                B.BID = "";
            }
            else
            {
                B.MID = cboSBManuName.SelectedValue.ToString();
                B.BID = cboSBName.SelectedValue.ToString();
            }
        }


        private void P_searchdataassign()
        {
            if (chkSPBName.Checked == true && chkSPPLName.Checked == false && chkSPPName.Checked ==false)
            {
                P.BID = cboSPBName.SelectedValue.ToString();
                P.PLID = "";
                P.PID = "";
            }
            else if (chkSPBName.Checked == false && chkSPPLName.Checked == true && chkSPPName.Checked == false)
            {
                P.BID = "";
                P.PLID = cboSPPLName.SelectedValue.ToString();
                P.PID = "";
            }
            else if (chkSPBName.Checked == false && chkSPPLName.Checked == false && chkSPPName.Checked == true)
            {
                P.BID = "";
                P.PLID = "";
                P.PID = cboSPPName.SelectedValue.ToString();
            }
            else if (chkSPBName.Checked == true && chkSPPLName.Checked == true && chkSPPName.Checked == false)
            {
                P.BID = cboSPBName.SelectedValue.ToString();
                P.PLID = cboSPPLName.SelectedValue.ToString();
                P.PID = "";
            }
            else if (chkSPBName.Checked == true && chkSPPLName.Checked == false && chkSPPName.Checked == true)
            {
                P.BID = cboSPBName.SelectedValue.ToString();
                P.PLID = "";
                P.PID = cboSPPName.SelectedValue.ToString();
            }
            else if (chkSPBName.Checked == false && chkSPPLName.Checked == true && chkSPPName.Checked == true)
            {
                P.BID = "";
                P.PLID = cboSPPLName.SelectedValue.ToString();
                P.PID = cboSPPName.SelectedValue.ToString();
            }
            else
            {
                P.BID = cboSPBName.SelectedValue.ToString();
                P.PLID = cboSPPLName.SelectedValue.ToString();
                P.PID = cboSPPName.SelectedValue.ToString();
            }
        }
        #endregion


        #region ShowallDataassign
        private void PL_showalldataassign()
        {
            PL.PLID = "";
            PL.PCID = "";
        }

        private void CPF_showalldataassign()
        {
            CPF.CPFID = "";   
        }


        private void PF_showalldataassign()
        {
            PF.CPFID = "";
            PF.PFID = "";
        }

        private void PC_showalldataassign()
        {
            PC.PFID = "";
            PC.PCID = "";
        }

        private void Manu_showalldataassign()
        {
            Manu.MID = "";
        }

        private void B_showalldataassign()
        {
            B.MID = "";
            B.BID = "";
        }

        private void P_showalldataassign()
        {
            P.PID = "";
            P.BID = "";
            P.PLID = "";
        }
        #endregion

        #region Dataassign
        private void dataassign()
        {
            PL.PLID = txtProductLineID.Text.Trim();
            PL.PLName = txtProductLineName.Text.Trim();
            if (cboProductClassName.SelectedIndex == -1)
            {
                PL.PCID = "";
                
            }
            else
            {
                PL.PCID = cboProductClassName.SelectedValue.ToString();
            }
            
          
            PL.PLDescription = txtDescription.Text.Trim();
            
            if (EID == null)
            {
                PL.CreatedEID = "";
            }
            else
            {
                PL.CreatedEID = EID;
            }
        }

        private void CPF_dataassign()
        {
            CPF.CPFID = txtCPFIDr.Text.Trim();
            CPF.CPFName = txtCPFNamer.Text.Trim();
            CPF.CPFDescription = txtCPFDescriptionr.Text.Trim();

            if (EID == null)
            {
                CPF.CreatedEID = "";
            }
            else
            {
                CPF.CreatedEID = EID;
            }
        }

        private void PF_dataassign()
        {
            PF.PFID = txtPFID.Text.Trim();
            PF.PFName = txtPFName.Text.Trim();
            PF.PFDescription = txtPFDescription.Text.Trim();

            if (cboCPFName.SelectedIndex == -1)
            {
                PF.CPFID = "";

            }
            else
            {
                PF.CPFID = cboCPFName.SelectedValue.ToString();
            }

            if (EID == null)
            {
                PF.CreatedEID = "";
            }
            else
            {
                PF.CreatedEID = EID;
            }
        }


        private void PC_dataassign()
        {
            PC.PCID = txtPCID.Text.Trim();
            PC.PCName = txtPCName.Text.Trim();
            PC.PCDescription = txtPCDescription.Text.Trim();

            if (cboPFName.SelectedIndex == -1)
            {
                PC.PFID = "";

            }
            else
            {
                PC.PFID = cboPFName.SelectedValue.ToString();
            }

            if (EID == null)
            {
                PC.CreatedEID = "";
            }
            else
            {
                PC.CreatedEID = EID;
            }
        }


        private void Manu_dataassign()
        {
            Manu.MID = txtManuID.Text.Trim();
            Manu.MName = txtManuName.Text.Trim();
            Manu.MCity = txtManuCity.Text.Trim();

            if (cboManuCountry.SelectedIndex == -1)
            {
                Manu.CountryID = "";

            }
            else
            {
                Manu.CountryID = cboManuCountry.SelectedValue.ToString();
            }

            if (EID == null)
            {
                Manu.CreatedEID = "";
            }
            else
            {
                Manu.CreatedEID = EID;
            }
        }


        private void B_dataassign()
        {
            B.BID = txtBID.Text.Trim();
            B.BName = txtBName.Text.Trim();
            B.BDescription = txtBDescription.Text.Trim();

            if (cboManuName.SelectedIndex == -1)
            {
                B.MID = "";

            }
            else
            {
                B.MID = cboManuName.SelectedValue.ToString();
            }

            if (EID == null)
            {
                B.CreatedEID = "";
            }
            else
            {
                B.CreatedEID = EID;
            }
        }


        private void P_dataassign()
        {
            P.PID = txtPID.Text.Trim();
            P.PName = txtPName.Text.Trim();
            P.PDescription = txtPDescription.Text.Trim();

            if (cboPPLName.SelectedIndex == -1)
            {
                P.PLID = "";

            }
            else
            {
                P.PLID = cboPPLName.SelectedValue.ToString();
            }

            if (cboPBName.SelectedIndex == -1)
            {
                P.BID = "";

            }
            else
            {
                P.BID = cboPBName.SelectedValue.ToString();
            }


            if (EID == null)
            {
                P.CreatedEID = "";
            }
            else
            {
                P.CreatedEID = EID;
            }
        }

        #endregion

        #region Savecheck
        private bool PL_savecheck()
        {

            if (txtProductLineID.Text.Trim() == "" && txtProductLineName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductLineID.Focus();
                return false;
            }
            else if (txtProductLineID.Text.Trim() == "" && txtProductLineName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Product Line ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductLineID.Focus();
                return false;
            }
            else if (txtProductLineID.Text.Trim() != "" && txtProductLineName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Product Line Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductLineName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        private bool CPF_savecheck()
        {

            if (txtCPFIDr.Text.Trim() == "" && txtCPFNamer.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPFIDr.Focus();
                return false;
            }
            else if (txtCPFIDr.Text.Trim() == "" && txtCPFNamer.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Core Product Family ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPFIDr.Focus();
                return false;
            }
            else if (txtCPFIDr.Text.Trim() != "" && txtCPFNamer.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Core Product Family Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPFNamer.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool PF_savecheck()
        {

            if (txtPFID.Text.Trim() == "" && txtPFName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPFID.Focus();
                return false;
            }
            else if (txtPFID.Text.Trim() == "" && txtPFName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Product Family ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPFID.Focus();
                return false;
            }
            else if (txtPFID.Text.Trim() != "" && txtPFName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Product Family Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPFName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        private bool PC_savecheck()
        {

            if (txtPCID.Text.Trim() == "" && txtPCName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPCID.Focus();
                return false;
            }
            else if (txtPCID.Text.Trim() == "" && txtPCName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Product Class ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPCID.Focus();
                return false;
            }
            else if (txtPCID.Text.Trim() != "" && txtPCName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Product Class Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPCName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        private bool Manu_savecheck()
        {

            if (txtManuID.Text.Trim() == "" && txtManuName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManuID.Focus();
                return false;
            }
            else if (txtManuID.Text.Trim() == "" && txtManuName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Manufacturer ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManuID.Focus();
                return false;
            }
            else if (txtManuID.Text.Trim() != "" && txtManuName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Manufacturer Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManuName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        private bool B_savecheck()
        {

            if (txtBID.Text.Trim() == "" && txtBName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBID.Focus();
                return false;
            }
            else if (txtBID.Text.Trim() == "" && txtBName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Brand ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBID.Focus();
                return false;
            }
            else if (txtBID.Text.Trim() != "" && txtBName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Brand Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        private bool P_savecheck()
        {

            if (txtPID.Text.Trim() == "" && txtPName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPID.Focus();
                return false;
            }
            else if (txtPID.Text.Trim() == "" && txtPName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Product ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPID.Focus();
                return false;
            }
            else if (txtPID.Text.Trim() != "" && txtPName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Product Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPName.Focus();
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
            if (PL_savecheck())
            {
                dataassign();
                if (PL.IsEdit)
                {
                    PL.Upd_Product_Line();
                    PL.IsEdit = false;
                }
                else
                {
                    PL.Ins_Product_Line();
                }
                Loading();
                
            }
        }

        private void CPF_Save()
        {
            if (CPF_savecheck())
            {
                CPF_dataassign();
                if (CPF.IsEdit)
                {
                    CPF.Upd_CPF();
                    CPF.IsEdit = false;
                }
                else
                {
                    CPF.Ins_CPF();
                }
                Loading();

            }
        }

        private void PF_Save()
        {
            if (PF_savecheck())
            {
                PF_dataassign();
                if (PF.IsEdit)
                {
                    PF.Upd_PF();
                    PF.IsEdit = false;
                }
                else
                {
                    PF.Ins_PF();
                }
                Loading();

            }
        }


        private void PC_Save()
        {
            if (PC_savecheck())
            {
                PC_dataassign();
                if (PC.IsEdit)
                {
                    PC.Upd_PC();
                    PC.IsEdit = false;
                }
                else
                {
                    PC.Ins_PC();
                }
                Loading();

            }
        }

        private void Manu_Save()
        {
            if (Manu_savecheck())
            {
                Manu_dataassign();
                if (Manu.IsEdit)
                {
                    Manu.Upd_Manufacturer();
                    Manu.IsEdit = false;
                }
                else
                {
                    Manu.Ins_Manufacturer();
                }
                Loading();

            }
        }

        private void B_Save()
        {
            if (B_savecheck())
            {
                B_dataassign();
                if (B.IsEdit)
                {
                    B.Upd_Brand();
                    B.IsEdit = false;
                }
                else
                {
                    B.Ins_Brand();
                }
                Loading();

            }
        }


        private void P_Save()
        {
            if (P_savecheck())
            {
                P_dataassign();
                if (P.IsEdit)
                {
                    P.Upd_Product();
                    P.IsEdit = false;
                }
                else
                {
                    P.Ins_Product();
                }
                Loading();

            }
        }
        #endregion

        #region ComboBind
        private void ProductLineNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PL.CallProduct_Line();
                cboProductLineName1.DataSource = tbl;
                cboProductLineName1.DisplayMember = "PLName";
                cboProductLineName1.ValueMember = "PLID";
                cboProductLineName1.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void CPFNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = CPF.Call_CPF();
                cboSCPFNamer.DataSource = tbl;
                cboSCPFNamer.DisplayMember = "CPFName";
                cboSCPFNamer.ValueMember = "CPFID";
                cboSCPFNamer.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void CPFNameComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = CPF.Call_CPF();
                cboCPFName.DataSource = tbl;
                cboCPFName.DisplayMember = "CPFName";
                cboCPFName.ValueMember = "CPFID";
                cboCPFName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void CPFNamePFSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = CPF.Call_CPF();
                cboSPFCPFName.DataSource = tbl;
                cboSPFCPFName.DisplayMember = "CPFName";
                cboSPFCPFName.ValueMember = "CPFID";
                cboSPFCPFName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void PFNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PF.Call_PF();
                cboSPFName.DataSource = tbl;
                cboSPFName.DisplayMember = "PFName";
                cboSPFName.ValueMember = "PFID";
                cboSPFName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void PFNameComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PF.Call_PF();
                cboPFName.DataSource = tbl;
                cboPFName.DisplayMember = "PFName";
                cboPFName.ValueMember = "PFID";
                cboPFName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void PFNamePCSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PF.Call_PF();
                cboSPCPFName.DataSource = tbl;
                cboSPCPFName.DisplayMember = "PFName";
                cboSPCPFName.ValueMember = "PFID";
                cboSPCPFName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void PCNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PC.Call_PC();
                cboSPCName.DataSource = tbl;
                cboSPCName.DisplayMember = "PCName";
                cboSPCName.ValueMember = "PCID";
                cboSPCName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void PCNameComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PC.Call_PC();
                cboProductClassName.DataSource = tbl;
                cboProductClassName.DisplayMember = "PCName";
                cboProductClassName.ValueMember = "PCID";
                cboProductClassName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void PCNamePLSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PC.Call_PC();
                cboSProductClassName1.DataSource = tbl;
                cboSProductClassName1.DisplayMember = "PCName";
                cboSProductClassName1.ValueMember = "PCID";
                cboSProductClassName1.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void ManuNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = Manu.Call_Manufacturer();
                cboSManuName.DataSource = tbl;
                cboSManuName.DisplayMember = "MName";
                cboSManuName.ValueMember = "MID";
                cboSManuName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void ManuCountryComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = cus.CallCountry();
                cboManuCountry.DataSource = tbl;
                cboManuCountry.DisplayMember = "CountryName";
                cboManuCountry.ValueMember = "CountryID";
                cboManuCountry.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void ManuNameComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = Manu.Call_Manufacturer();
                cboManuName.DataSource = tbl;
                cboManuName.DisplayMember = "MName";
                cboManuName.ValueMember = "MID";
                cboManuName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void ManuNameBSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = Manu.Call_Manufacturer();
                cboSBManuName.DataSource = tbl;
                cboSBManuName.DisplayMember = "MName";
                cboSBManuName.ValueMember = "MID";
                cboSBManuName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void BNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = B.Call_Brand();
                cboSBName.DataSource = tbl;
                cboSBName.DisplayMember = "BName";
                cboSBName.ValueMember = "BID";
                cboSBName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void PPLNameComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PL.CallProduct_Line();
                cboPPLName.DataSource = tbl;
                cboPPLName.DisplayMember = "PLName";
                cboPPLName.ValueMember = "PLID";
                cboPPLName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void PPLNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = PL.CallProduct_Line();
                cboSPPLName.DataSource = tbl;
                cboSPPLName.DisplayMember = "PLName";
                cboSPPLName.ValueMember = "PLID";
                cboSPPLName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void PBNameComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = B.Call_Brand();
                cboPBName.DataSource = tbl;
                cboPBName.DisplayMember = "BName";
                cboPBName.ValueMember = "BID";
                cboPBName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void PBNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = B.Call_Brand();
                cboSPBName.DataSource = tbl;
                cboSPBName.DisplayMember = "BName";
                cboSPBName.ValueMember = "BID";
                cboSPBName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void PPNameSComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = P.CallProduct();
                cboSPPName.DataSource = tbl;
                cboSPPName.DisplayMember = "PName";
                cboSPPName.ValueMember = "PID";
                cboSPPName.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion


        #region Search
        private void PL_Search()
        {
            if (chkProductClassName1.Checked == false)
            {
                if (chkProductLineName1.Checked == true && cboProductLineName1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Product Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboProductLineName1.Focus();
                }
                else if (chkProductLineName1.Checked == true && cboProductLineName1.SelectedIndex != -1)
                {
                    PL_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PL.SearchProduct_Line();
                    dgvSProductLine1.DataSource = tbl;
                }
            }
            else
            {
                if (cboSProductClassName1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Product Class Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSProductClassName1.Focus();
                }
                else if (cboSProductClassName1.SelectedIndex != -1)
                {
                    PL_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PL.SearchProduct_Line();
                    dgvSProductLine1.DataSource = tbl;
                }
            }
        }

        private void CPF_Search()
        {
           
                if (chkSCPFNamer.Checked == true && cboSCPFNamer.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Core Product Family Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSCPFNamer.Focus();
                }
                else if (chkSCPFNamer.Checked == true && cboSCPFNamer.SelectedIndex != -1)
                {
                    CPF_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = CPF.Search_CPF();
                    dgvCPF.DataSource = tbl;
                }
          
        }

        private void PF_Search()
        {
            if (chkSPFCPFName.Checked == false)
            {
                if (chkSPFName.Checked == true && cboSPFName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Product Family Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSCPFName.Focus();
                }
                else if (chkSCPFName.Checked == true && cboSCPFName.SelectedIndex != -1)
                {
                    PF_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PF.Search_PF();
                    dgvProductFamily.DataSource = tbl;
                }
            }
            else
            {
                if (cboSPFCPFName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Core Product Family Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSPFCPFName.Focus();
                }
                else if (cboSPFCPFName.SelectedIndex != -1)
                {
                    PF_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PF.Search_PF();
                    dgvProductFamily.DataSource = tbl;
                }
            }

        }



        private void PC_Search()
        {
            if (chkSPCPFName.Checked == false)
            {
                if (chkSPCName.Checked == true && cboSPCName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Product Class Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSPCName.Focus();
                }
                else if (chkSPCName.Checked == true && cboSPCName.SelectedIndex != -1)
                {
                    PC_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PC.Search_PC();
                    dgvProductClass.DataSource = tbl;
                }
            }
            else
            {
                if (cboSPCPFName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Product Family Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSPCPFName.Focus();
                }
                else if (cboSPCPFName.SelectedIndex != -1)
                {
                    PC_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = PC.Search_PC();
                    dgvProductClass.DataSource = tbl;
                }
            }

        }


        private void Manu_Search()
        {

            if (chkSManuName.Checked == true && cboSManuName.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose Core Product Family Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSManuName.Focus();
            }
            else if (chkSManuName.Checked == true && cboSManuName.SelectedIndex != -1)
            {
                Manu_searchdataassign();
                DataTable tbl = new DataTable();
                tbl = Manu.Search_Manufacturer();
                dgvManufacturer.DataSource = tbl;
            }

        }


        private void B_Search()
        {
            if (chkSBManuName.Checked == false)
            {
                if (chkSBName.Checked == true && cboSBName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Brand Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSBName.Focus();
                }
                else if (chkSBName.Checked == true && cboSBName.SelectedIndex != -1)
                {
                    B_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = B.Search_Brand();
                    dgvBrand.DataSource = tbl;
                }
            }
            else
            {
                if (cboSBManuName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Manufacturer Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSBManuName.Focus();
                }
                else if (cboSBManuName.SelectedIndex != -1)
                {
                    B_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = B.Search_Brand();
                    dgvBrand.DataSource = tbl;
                }
            }

        }


        private void P_Search()
        {
            if (chkSPBName.Checked == false)
            {
                if (chkSPPLName.Checked == false)
                {
                    if (chkSPPName.Checked == true && cboSPPName.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please choose Product Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboSPPName.Focus();
                    }
                    else if (chkSPPName.Checked == true && cboSPPName.SelectedIndex != -1)
                    {
                        P_searchdataassign();
                        DataTable tbl = new DataTable();
                        tbl = P.SearchProduct();
                        dgvProduct.DataSource = tbl;
                    }
                }
                else
                {
                    if (cboSPPLName.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please choose Product Line Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboSPPLName.Focus();
                    }
                    else if (cboSPPLName.SelectedIndex != -1)
                    {
                        P_searchdataassign();
                        DataTable tbl = new DataTable();
                        tbl = P.SearchProduct();
                        dgvProduct.DataSource = tbl;
                    }
                }

            }

            else
            {
                if (cboSPBName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose Brand Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSPBName.Focus();
                }
                else if (cboSPBName.SelectedIndex != -1)
                {
                    P_searchdataassign();
                    DataTable tbl = new DataTable();
                    tbl = P.SearchProduct();
                    dgvProduct.DataSource = tbl;
                }
            }
        }
        #endregion


        #region ShowAll
        private void PL_ShowAll()
        {
            PL_showalldataassign();
            DataTable tbl = new DataTable();
            tbl = PL.SearchProduct_Line();
            dgvSProductLine1.DataSource = tbl;
        }


        private void CPF_ShowAll()
        {
            CPF_showalldataassign();
            DataTable tbl = new DataTable();
            tbl = CPF.Search_CPF();
            dgvCPF.DataSource = tbl;
        }

        private void PF_ShowAll()
        {
            PF_showalldataassign();
            DataTable tbl = new DataTable();
            tbl = PF.Search_PF();
            dgvProductFamily.DataSource = tbl;
        }

        private void PC_ShowAll()
        {
            PC_showalldataassign();
            DataTable tbl = new DataTable();
            tbl = PC.Search_PC();
            dgvProductClass.DataSource = tbl;
        }


        private void Manu_ShowAll()
        {
            Manu_showalldataassign();
            DataTable tbl = new DataTable();
            tbl = Manu.Search_Manufacturer();
            dgvManufacturer.DataSource = tbl;
        }


        private void B_ShowAll()
        {
            B_showalldataassign();
            DataTable tbl = new DataTable();
            tbl = B.Search_Brand();
            dgvBrand.DataSource = tbl;
        }

        private void P_ShowAll()
        {
            P_showalldataassign();
            DataTable tbl = new DataTable();
            tbl = P.SearchProduct();
            dgvProduct.DataSource = tbl;
        }
        #endregion

        #region SearchCheckboxValidation
        private void SearchCheckboxValidation()
        {
            if (cboSProductClassName1.SelectedIndex == -1)
            {
                
                if (chkProductClassName1.Checked == true)
                {
                    cboSProductClassName1.Enabled = true;
                    PCNamePLSComboBind();

                }
                else
                {
                    cboSProductClassName1.Enabled = false;
                }

                if (chkProductLineName1.Checked == true)
                {
                    cboProductLineName1.Enabled = true;
                    ProductLineNameSComboBind();

                }
                else
                {
                    cboProductLineName1.Enabled = false;
                }
            }
            else
            {
                if (chkProductLineName1.Checked == true)
                {
                    cboProductLineName1.Enabled = true;
                    ProductLineNameSComboBind();

                }
                else
                {
                    cboProductLineName1.Enabled = false;
                }
            }
        }


        private void CPF_SearchCheckboxValidation()
        {
            if (chkSCPFNamer.Checked == true)
            {
                cboSCPFNamer.Enabled = true;
                CPFNameSComboBind();

            }
            else
            {
                cboSCPFNamer.Enabled = false;
            }
        }


        private void PF_SearchCheckboxValidation()
        {
            if (cboSPFCPFName.SelectedIndex == -1)
            {
                if (chkSPFCPFName.Checked == true)
                {
                    cboSPFCPFName.Enabled = true;
                    CPFNamePFSComboBind();

                }
                else
                {
                    cboSPFCPFName.Enabled = false;
                }

                if (chkSPFName.Checked == true)
                {
                    cboSPFName.Enabled = true;
                    PFNameSComboBind();

                }
                else
                {
                    cboSPFName.Enabled = false;
                }
            }
            else
            {
                if (chkSPFName.Checked == true)
                {
                    cboSPFName.Enabled = true;
                    PFNameSComboBind();

                }
                else
                {
                    cboSPFName.Enabled = false;
                }
            }

        }


        private void PC_SearchCheckboxValidation()
        {
            if (cboSPCPFName.SelectedIndex == -1)
            {
                if (chkSPCPFName.Checked == true)
                {
                    cboSPCPFName.Enabled = true;
                    PFNamePCSComboBind();

                }
                else
                {
                    cboSPCPFName.Enabled = false;
                }

                if (chkSPCName.Checked == true)
                {
                    cboSPCName.Enabled = true;
                    PCNameSComboBind();

                }
                else
                {
                    cboSPCName.Enabled = false;
                }
            }
            else
            {
                if (chkSPCName.Checked == true)
                {
                    cboSPCName.Enabled = true;
                    PCNameSComboBind();

                }
                else
                {
                    cboSPCName.Enabled = false;
                }
            }

        }


        private void Manu_SearchCheckboxValidation()
        {
            if (chkSManuName.Checked == true)
            {
                cboSManuName.Enabled = true;
                ManuNameSComboBind();

            }
            else
            {
                cboSManuName.Enabled = false;
            }
        }


        private void B_SearchCheckboxValidation()
        {
            if (cboSBManuName.SelectedIndex == -1)
            {
                if (chkSBManuName.Checked == true)
                {
                    cboSBManuName.Enabled = true;
                    ManuNameBSComboBind();

                }
                else
                {
                    cboSBManuName.Enabled = false;
                }

                if (chkSBName.Checked == true)
                {
                    cboSBName.Enabled = true;
                    BNameSComboBind();

                }
                else
                {
                    cboSBName.Enabled = false;
                }
            }
            else
            {
                if (chkSBName.Checked == true)
                {
                    cboSBName.Enabled = true;
                    BNameSComboBind();

                }
                else
                {
                    cboSBName.Enabled = false;
                }
            }
        }


        private void P_SearchCheckboxValidation()
        {
            
                if (cboSPBName.SelectedIndex == -1 || cboSPPLName.SelectedIndex == -1)
                {
                    if (chkSPBName.Checked == true)
                    {
                        cboSPBName.Enabled = true;
                        PBNameSComboBind();

                    }
                    else
                    {
                        cboSPBName.Enabled = false;
                    }

                    if (chkSPPLName.Checked == true)
                    {
                        cboSPPLName.Enabled = true;
                        PPLNameSComboBind();

                    }
                    else
                    {
                        cboSPPLName.Enabled = false;
                    }

                    if (chkSPPName.Checked == true)
                    {
                        cboSPPName.Enabled = true;
                        PPNameSComboBind();

                    }
                    else
                    {
                        cboSPPName.Enabled = false;
                    }
                }
                else
                {
                    if (chkSPPName.Checked == true)
                    {
                        cboSPPName.Enabled = true;
                        PPNameSComboBind();

                    }
                    else
                    {
                        cboSPPName.Enabled = false;
                    }
                }
            
        }
        #endregion

        #region GridClick
        private void PL_gridclick()
        {
            Loading();
            M.Button_Enable(true, btnNew, btnEdit, btnDelete, btnCancel);
        }

        private void CPF_gridclick()
        {
            Loading();
            M.Button_Enable(true, btnCPFNewr, btnCPFEditr, btnCPFDeleter, btnCPFCancelr);
        }

        private void PF_gridclick()
        {
            Loading();
            M.Button_Enable(true, btnPFNew, btnPFEdit, btnPFDelete, btnPFCancel);
        }

        private void PC_gridclick()
        {
            Loading();
            M.Button_Enable(true, btnPCNew, btnPCEdit, btnPCDelete, btnPCCancel);
        }

        private void Manu_gridclick()
        {
            Loading();
            M.Button_Enable(true, btnManuNew, btnManuEdit, btnManuDelete, btnManuCancel);
        }

        private void B_gridclick()
        {
            Loading();
            M.Button_Enable(true, btnBNew, btnBEdit, btnBDelete, btnBCancel);
        }


        private void P_gridclick()
        {
            Loading();
            M.Button_Enable(true, btnPNew, btnPEdit, btnPDelete, btnPCancel);
        }
        #endregion

        #endregion
        private void FrmProductLine_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
                M.TextBox_Enable(true, txtProductLineName, txtDescription);
                M.Button_Enable(true, btnSave, btnCancel);
                M.Button_Enable(false, btnNew, btnEdit, btnDelete);
                AutoID_ProductLine();
                cboProductClassName.Enabled = true;
                PCNameComboBind();
                cboProductClassName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtProductLineName, txtDescription);
            M.Button_Enable(true, btnSave, btnCancel, btnDelete);
            M.Button_Enable(false, btnNew);
            cboProductClassName.Enabled = true;
            cboProductClassName.Focus();
            PL.IsEdit = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataassign();
                PL.Del_Product_Line();
                Loading();
            }
        }

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSProductLineName_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
        }

        private void btnSShowAll_Click(object sender, EventArgs e)
        {
            PL_ShowAll();
            dgvSProductLine1.Enabled = true;
            SearchCheckboxValidation();
            M.Checkbox_Checked(false, chkProductClassName1, chkProductLineName1);
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
            if (chkProductLineName1.Checked == false && chkProductClassName1.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkProductLineName1.Focus();
            }
            else if (chkProductLineName1.Checked == true && chkProductClassName1.Checked == false)
            {
                PL_Search();
                dgvSProductLine1.Enabled = true;
            }
            else if (chkProductLineName1.Checked == false && chkProductClassName1.Checked == true)
            {
                PL_Search();
                dgvSProductLine1.Enabled = true;
            }
            
            else
            {
                PL_Search();
                dgvSProductLine1.Enabled = true;
            }
        }

        private void dgvSProductLine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                PL_gridclick();
                txtProductLineID.Text = dgvSProductLine1.Rows[e.RowIndex].Cells["Product Line ID"].Value.ToString();
                txtProductLineName.Text = dgvSProductLine1.Rows[e.RowIndex].Cells["Product Line Name"].Value.ToString();
                txtDescription.Text = dgvSProductLine1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                
                PCNameComboBind();
                PC.PCName = dgvSProductLine1.Rows[e.RowIndex].Cells["Product Class Name"].Value.ToString();
                DataTable tblPL = new DataTable();
                tblPL = PC.CallPCIDbyName();
                int r;
                r = tblPL.Rows.Count;
                if (r == 0)
                {
                    cboProductClassName.SelectedIndex = -1;
                }
                else
                {
                    cboProductClassName.SelectedValue = tblPL.Rows[0][0].ToString();
                }

                tbcPL.SelectedTab = tbpPLEntry;
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvSProductLine1.Rows.Count - 1; i++)
            {
                drow = dgvSProductLine1.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                PL.PLID = s;
                PL.Del_Product_Line();

            }

            PL_ShowAll(); 

        }

        private void txtProductLineID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtProductLineName.Focus();

            }
        }

        private void txtProductLineName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDescription.Focus();

            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                save();

            }
        }

        private void btnNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtProductLineName.Focus();
                M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            }
        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void btnCPFNew_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCPFEdit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCPFSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCPFDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCPFCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkProductClassName1_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
        }

        private void chkCPFName_CheckedChanged(object sender, EventArgs e)
        {
            CPF_GridDataClear();
            CPF_SearchCheckboxValidation();
        }

        private void btnCPFSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCPFShowAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCPFSDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvCoreProductFamily_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtCPFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCPFDescription.Focus();

            }
        }

        private void txtCPFDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CPF_Save();

            }
        }

        private void btnCPFNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCPFName.Focus();
                M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            }
        }

        private void tbpProductFamily_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPFNew_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtPFName, txtPFDescription);
            M.Button_Enable(true, btnPFSave, btnPFCancel);
            M.Button_Enable(false, btnPFNew, btnPFEdit, btnPFDelete);
            cboCPFName.Enabled = true;
            AutoID_PF();
            CPFNameComboBind();
            cboCPFName.Focus();
        }

        private void btnPFEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtPFName, txtPFDescription);
            M.Button_Enable(true, btnPFSave, btnPFCancel, btnPFDelete);
            M.Button_Enable(false, btnPFNew);
            cboCPFName.Enabled = true;
            cboCPFName.Focus();
            PF.IsEdit = true;
        }

        private void btnPFSave_Click(object sender, EventArgs e)
        {
            PF_Save();
        }

        private void btnPFDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PF_dataassign();
                PF.Del_PF();
                Loading();
            }
        }

        private void btnPFCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSPFCPFName_CheckedChanged(object sender, EventArgs e)
        {
            PF_GridDataClear();
            PF_SearchCheckboxValidation();
        }

        private void btnPFSearch_Click(object sender, EventArgs e)
        {
            if (chkSPFCPFName.Checked == false && chkSPFName.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSPFCPFName.Focus();
            }
            else if (chkSPFCPFName.Checked == true && chkSPFName.Checked == false)
            {
                PF_Search();
                dgvProductFamily.Enabled = true;
            }
            else if (chkSPFCPFName.Checked == false && chkSPFName.Checked == true)
            {
                PF_Search();
                dgvProductFamily.Enabled = true;
            }

            else
            {
                PF_Search();
                dgvProductFamily.Enabled = true;
            }
        }

        private void btnPFShowAll_Click(object sender, EventArgs e)
        {
            PF_ShowAll();
            dgvProductFamily.Enabled = true;
            PF_SearchCheckboxValidation();
            M.Checkbox_Checked(false, chkSPFCPFName, chkSPFName);
        }

        private void btnSPFDelete_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvProductFamily.Rows.Count - 1; i++)
            {
                drow = dgvProductFamily.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                PF.PFID = s;
                PF.Del_PF();

            }

            PF_ShowAll(); 
        }

        private void dgvProductFamily_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                PF_gridclick();
                txtPFID.Text = dgvProductFamily.Rows[e.RowIndex].Cells["Product Family ID"].Value.ToString();
                txtPFName.Text = dgvProductFamily.Rows[e.RowIndex].Cells["Product Family Name"].Value.ToString();
                txtPFDescription.Text = dgvProductFamily.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                
                CPFNameComboBind();
                CPF.CPFName = dgvProductFamily.Rows[e.RowIndex].Cells["Core Product Family Name"].Value.ToString();
                DataTable tblCPF = new DataTable();
                tblCPF = CPF.CallCPFIDbyName();
                int r;
                r = tblCPF.Rows.Count;
                if (r == 0)
                {
                    cboCPFName.SelectedIndex = -1;
                }
                else
                {
                    cboCPFName.SelectedValue = tblCPF.Rows[0][0].ToString();
                }
                
               
                tbcProductFamily.SelectedTab = tbpPFEntry;
            }
        }

        private void cboCPFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPFName.Focus();
            }
        }

        private void txtPFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPFDescription.Focus();

            }
        }

        private void txtPFDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PF_Save();
            }
        }

        private void chkSPFName_CheckedChanged(object sender, EventArgs e)
        {
            PF_GridDataClear();
            PF_SearchCheckboxValidation();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnPCNew_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtPCName, txtPCDescription);
            M.Button_Enable(true, btnPCSave, btnPCCancel);
            M.Button_Enable(false, btnPCNew, btnPCEdit, btnPCDelete);
            cboPFName.Enabled = true;
            AutoID_PC();
            PFNameComboBind();
            cboPFName.Focus();
        }

        private void btnPCEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtPCName, txtPCDescription);
            M.Button_Enable(true, btnPCSave, btnPCCancel, btnPCDelete);
            M.Button_Enable(false, btnPCNew);
            cboPFName.Enabled = true;
            cboPFName.Focus();
            PC.IsEdit = true;
        }

        private void btnPCSave_Click(object sender, EventArgs e)
        {
            PC_Save();
        }

        private void btnPCDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PC_dataassign();
                PC.Del_PC();
                Loading();
            }
        }

        private void btnPCCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSPCPFName_CheckedChanged(object sender, EventArgs e)
        {
            PC_GridDataClear();
            PC_SearchCheckboxValidation();
        }

        private void chkSPCName_CheckedChanged(object sender, EventArgs e)
        {
            PC_GridDataClear();
            PC_SearchCheckboxValidation();
        }

        private void btnPCSearch_Click(object sender, EventArgs e)
        {
            if (chkSPCPFName.Checked == false && chkSPCName.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSPCPFName.Focus();
            }
            else if (chkSPCPFName.Checked == true && chkSPCName.Checked == false)
            {
                PC_Search();
                dgvProductClass.Enabled = true;
            }
            else if (chkSPCPFName.Checked == false && chkSPCName.Checked == true)
            {
                PC_Search();
                dgvProductClass.Enabled = true;
            }

            else
            {
                PC_Search();
                dgvProductClass.Enabled = true;
            }
        }

        private void btnPCShowAll_Click(object sender, EventArgs e)
        {
            PC_ShowAll();
            dgvProductClass.Enabled = true;
            PC_SearchCheckboxValidation();
            M.Checkbox_Checked(false, chkSPCPFName, chkSPCName);
        }

        private void btnPCSDelete_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvProductClass.Rows.Count - 1; i++)
            {
                drow = dgvProductClass.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                PC.PCID = s;
                PC.Del_PC();

            }

            PC_ShowAll(); 
        }

        private void dgvProductClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                PC_gridclick();
                txtPCID.Text = dgvProductClass.Rows[e.RowIndex].Cells["Product Class ID"].Value.ToString();
                txtPCName.Text = dgvProductClass.Rows[e.RowIndex].Cells["Product Class Name"].Value.ToString();
                txtPCDescription.Text = dgvProductClass.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                PFNameComboBind();
                PF.PFName = dgvProductClass.Rows[e.RowIndex].Cells["Product Family Name"].Value.ToString();
                DataTable tblPF = new DataTable();
                tblPF = PF.CallPFIDbyName();
                int r;
                r = tblPF.Rows.Count;
                if (r == 0)
                {
                    cboPFName.SelectedIndex = -1;
                }
                else
                {
                    cboPFName.SelectedValue = tblPF.Rows[0][0].ToString();
                }


                tbcProductClass.SelectedTab = tbpPCEntry;
            }
        }

        private void cboPFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPCName.Focus();
            }
        }

        private void txtPCName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPCDescription.Focus();
            }
        }

        private void txtPCDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PC_Save();
            }
        }

        private void cboProductClassName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtProductLineName.Focus();

            }
        }

        private void btnCPFNewr_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtCPFNamer, txtCPFDescriptionr);
            M.Button_Enable(true, btnCPFSaver, btnCPFCancelr);
            M.Button_Enable(false, btnCPFNewr, btnCPFEditr, btnCPFDeleter);
            AutoID_CPF();
            txtCPFNamer.Focus();
        }

        private void btnCPFEditr_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtCPFNamer, txtCPFDescriptionr);
            M.Button_Enable(true, btnCPFSaver, btnCPFCancelr, btnCPFDeleter);
            M.Button_Enable(false, btnCPFNewr);
            txtCPFNamer.Focus();
            CPF.IsEdit = true;   
        }

        private void btnCPFSaver_Click(object sender, EventArgs e)
        {
            CPF_Save();
        }

        private void btnCPFDeleter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CPF_dataassign();
                CPF.Del_CPF();
                Loading();
            }
        }

        private void btnCPFCancelr_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSCPFNamer_CheckedChanged(object sender, EventArgs e)
        {
            CPF_GridDataClear();
            CPF_SearchCheckboxValidation();
        }

        private void btnCPFSearchr_Click(object sender, EventArgs e)
        {
            if (chkSCPFNamer.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSCPFNamer.Focus();
            }
            else
            {
                CPF_Search();
                dgvCPF.Enabled = true;
            }
        }

        private void btnCPFShowAllr_Click(object sender, EventArgs e)
        {
            CPF_ShowAll();
            dgvCPF.Enabled = true;
            CPF_SearchCheckboxValidation();
            chkSCPFNamer.Checked = false;
        }

        private void btnSCPFDeleter_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvCPF.Rows.Count - 1; i++)
            {
                drow = dgvCPF.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                CPF.CPFID = s;
                CPF.Del_CPF();

            }

            CPF_ShowAll(); 
        }

        private void dgvCPF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CPF_gridclick();
            txtCPFIDr.Text = dgvCPF.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtCPFNamer.Text = dgvCPF.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtCPFDescriptionr.Text = dgvCPF.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            tbcCoreProductFamily.SelectedTab = tbpCPFEntryr;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtManuName, txtManuCity);
            M.Button_Enable(true, btnManuSave, btnManuCancel);
            M.Button_Enable(false, btnManuNew, btnManuEdit, btnManuDelete);
            cboManuCountry.Enabled = true;
            ManuCountryComboBind();
            AutoID_Manu();
            txtManuName.Focus();
        }

        private void btnManuEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtManuName, txtManuCity);
            M.Button_Enable(true, btnManuSave, btnManuCancel, btnManuDelete);
            M.Button_Enable(false, btnManuNew);
            cboManuCountry.Enabled = true;
            txtManuName.Focus();
            Manu.IsEdit = true;   
        }

        private void btnManuSave_Click(object sender, EventArgs e)
        {
            Manu_Save();
        }

        private void btnManuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Manu_dataassign();
                Manu.Del_Manufacturer();
                Loading();
            }
        }

        private void btnManuCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSManuName_CheckedChanged(object sender, EventArgs e)
        {
            Manu_GridDataClear();
            Manu_SearchCheckboxValidation();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (chkSManuName.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSManuName.Focus();
            }
            else
            {
                Manu_Search();
                dgvManufacturer.Enabled = true;
            }
        }

        private void btnManuShowAll_Click(object sender, EventArgs e)
        {
            Manu_ShowAll();
            dgvManufacturer.Enabled = true;
            Manu_SearchCheckboxValidation();
            chkSManuName.Checked = false;
        }

        private void btnSManuDelete_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvManufacturer.Rows.Count - 1; i++)
            {
                drow = dgvManufacturer.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                Manu.MID = s;
                Manu.Del_Manufacturer();

            }

            Manu_ShowAll(); 
        }

        private void dgvManufacturer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Manu_gridclick();
            txtManuID.Text = dgvManufacturer.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtManuName.Text = dgvManufacturer.Rows[e.RowIndex].Cells["Manufacturer Name"].Value.ToString();
            txtManuCity.Text = dgvManufacturer.Rows[e.RowIndex].Cells["City"].Value.ToString();

            ManuCountryComboBind();
            cus.CDCountry = dgvManufacturer.Rows[e.RowIndex].Cells["Country"].Value.ToString();
            DataTable tblManu = new DataTable();
            tblManu = cus.CallCountryIDbyName();
            int r;
            r = tblManu.Rows.Count;
            if (r == 0)
            {
                cboManuCountry.SelectedIndex = -1;
            }
            else
            {
                cboManuCountry.SelectedValue = tblManu.Rows[0][0].ToString();
            }


            tbcManu.SelectedTab = tbpManuEntry;
        }

        private void txtCPFNamer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCPFDescriptionr.Focus();
            }
        }

        private void txtCPFDescriptionr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CPF_Save();
            }
        }

        private void txtManuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtManuCity.Focus();
            }
        }

        private void txtManuCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboManuCountry.Focus();
            }
        }

        private void cboManuCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Manu_Save();
            }
        }

        private void btnBNew_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtBName, txtBDescription);
            M.Button_Enable(true, btnBSave, btnBCancel);
            M.Button_Enable(false, btnBNew, btnBEdit, btnBDelete);
            cboManuName.Enabled = true;
            AutoID_Brand();
            ManuNameComboBind();
            txtBName.Focus();
        }

        private void btnBEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtBName, txtBDescription);
            M.Button_Enable(true, btnBSave, btnBCancel, btnBDelete);
            M.Button_Enable(false, btnBNew);
            cboManuName.Enabled = true;
            txtBName.Focus();
            B.IsEdit = true;
        }

        private void btnBSave_Click(object sender, EventArgs e)
        {
            B_Save();
        }

        private void btnBDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                B_dataassign();
                B.Del_Brand();
                Loading();
            }
        }

        private void btnBCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSBManuName_CheckedChanged(object sender, EventArgs e)
        {
            B_GridDataClear();
            B_SearchCheckboxValidation();
        }

        private void chkSBName_CheckedChanged(object sender, EventArgs e)
        {
            B_GridDataClear();
            B_SearchCheckboxValidation();
        }

        private void btnBSearch_Click(object sender, EventArgs e)
        {
            if (chkSBManuName.Checked == false && chkSBName.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSBManuName.Focus();
            }
            else if (chkSBManuName.Checked == true && chkSBName.Checked == false)
            {
                B_Search();
                dgvBrand.Enabled = true;
            }
            else if (chkSBManuName.Checked == false && chkSBName.Checked == true)
            {
                B_Search();
                dgvBrand.Enabled = true;
            }

            else
            {
                B_Search();
                dgvBrand.Enabled = true;
            }
        }

        private void btnBShowAll_Click(object sender, EventArgs e)
        {
            B_ShowAll();
            dgvBrand.Enabled = true;
            B_SearchCheckboxValidation();
            M.Checkbox_Checked(false, chkSBManuName, chkSBName);
        }

        private void btnSBDelete_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvBrand.Rows.Count - 1; i++)
            {
                drow = dgvBrand.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                B.BID = s;
                B.Del_Brand();

            }

            B_ShowAll(); 
        }

        private void txtBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboManuName.Focus();
            }
        }

        private void cboManuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtBDescription.Focus();
            }
        }

        private void txtBDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                B_Save();
            }
        }

        private void dgvBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            B_gridclick();
            txtBID.Text = dgvBrand.Rows[e.RowIndex].Cells["Brand ID"].Value.ToString();
            txtBName.Text = dgvBrand.Rows[e.RowIndex].Cells["Brand Name"].Value.ToString();
            txtBDescription.Text = dgvBrand.Rows[e.RowIndex].Cells["Description"].Value.ToString();

            ManuNameComboBind();
            Manu.MName = dgvBrand.Rows[e.RowIndex].Cells["Manufacturer Name"].Value.ToString();
            DataTable tblManu = new DataTable();
            tblManu = Manu.CallManuIDbyName();
            int r;
            r = tblManu.Rows.Count;
            if (r == 0)
            {
                cboManuName.SelectedIndex = -1;
            }
            else
            {
                cboManuName.SelectedValue = tblManu.Rows[0][0].ToString();
            }


            tbcBrand.SelectedTab = tbpBEntry;
        }

        private void btnPNew_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtPName, txtPDescription);
            M.Button_Enable(true, btnPSave, btnPCancel);
            M.Button_Enable(false, btnPNew, btnPEdit, btnPDelete);
            AutoID_Product();
            cboPPLName.Enabled = true;
            cboPBName.Enabled = true;
            PPLNameComboBind();
            PBNameComboBind();
            cboPPLName.Focus();
        }

        private void btnPEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtPName, txtPDescription);
            M.Button_Enable(true, btnPSave, btnPCancel, btnPDelete);
            M.Button_Enable(false, btnPNew);
            cboPPLName.Enabled = true;
            cboPBName.Enabled = true;
            cboPPLName.Focus();
            P.IsEdit = true;
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            P_Save();
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                P_dataassign();
                P.Del_Product();
                Loading();
            }
        }

        private void btnPCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void chkSPBName_CheckedChanged(object sender, EventArgs e)
        {
            P_GridDataClear();
            P_SearchCheckboxValidation();
        }

        private void gpbSearch_Enter(object sender, EventArgs e)
        {

        }

        private void chkSPPLName_CheckedChanged(object sender, EventArgs e)
        {
            P_GridDataClear();
            P_SearchCheckboxValidation();
        }

        private void chkSPPName_CheckedChanged(object sender, EventArgs e)
        {
            P_GridDataClear();
            P_SearchCheckboxValidation();
        }

        private void btnPSearch_Click(object sender, EventArgs e)
        {
            if (chkSPBName.Checked == false && chkSPPLName.Checked == false && chkSPPName.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSPCPFName.Focus();
            }
            else if (chkSPBName.Checked == true && chkSPPLName.Checked == false && chkSPPName.Checked == false)
            {
                P_Search();
                dgvProduct.Enabled = true;
            }
            else if (chkSPBName.Checked == false && chkSPPLName.Checked == true && chkSPPName.Checked == false)
            {
                P_Search();
                dgvProduct.Enabled = true;
            }
            else if (chkSPBName.Checked == false && chkSPPLName.Checked == false && chkSPPName.Checked == true)
            {
                P_Search();
                dgvProduct.Enabled = true;
            }
            else if (chkSPBName.Checked == true && chkSPPLName.Checked == true && chkSPPName.Checked == false)
            {
                P_Search();
                dgvProduct.Enabled = true;
            }
            else if (chkSPBName.Checked == true && chkSPPLName.Checked == false && chkSPPName.Checked == true)
            {
                P_Search();
                dgvProduct.Enabled = true;
            }
            else if (chkSPBName.Checked == false && chkSPPLName.Checked == true && chkSPPName.Checked == true)
            {
                P_Search();
                dgvProduct.Enabled = true;
            }
            else
            {
                P_Search();
                dgvProduct.Enabled = true;
            }
        }

        private void btnPShowAll_Click(object sender, EventArgs e)
        {
            P_ShowAll();
            dgvProduct.Enabled = true;
            P_SearchCheckboxValidation();
            M.Checkbox_Checked(false, chkSPBName, chkSPPLName, chkSPPName);
        }

        private void btnSPDelete_Click(object sender, EventArgs e)
        {
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvProduct.Rows.Count - 1; i++)
            {
                drow = dgvProduct.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
            ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                P.PID = s;
                P.Del_Product();

            }

            P_ShowAll(); 
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                P_gridclick();
                txtPID.Text = dgvProduct.Rows[e.RowIndex].Cells["Product ID"].Value.ToString();
                txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells["Product Name"].Value.ToString();
                txtPDescription.Text = dgvProduct.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                PBNameComboBind();
                B.BName = dgvProduct.Rows[e.RowIndex].Cells["Brand Name"].Value.ToString();
                DataTable tblBrand = new DataTable();
                tblBrand = B.CallBrandIDbyName();
                int r;
                r = tblBrand.Rows.Count;
                if (r == 0)
                {
                    cboPBName.SelectedIndex = -1;
                }
                else
                {
                    cboPBName.SelectedValue = tblBrand.Rows[0][0].ToString();
                }


                PPLNameComboBind();
                PL.PLName = dgvProduct.Rows[e.RowIndex].Cells["Product Line Name"].Value.ToString();
                DataTable tblProductLine = new DataTable();
                tblProductLine = PL.CallProductLineIDbyName();
                int rs;
                rs = tblProductLine.Rows.Count;
                if (rs == 0)
                {
                    cboPPLName.SelectedIndex = -1;
                }
                else
                {
                    cboPPLName.SelectedValue = tblProductLine.Rows[0][0].ToString();
                }


                tbcProduct.SelectedTab = tbpPEntry;
            }
        }

        private void cboPPLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPName.Focus();
            }
        }

        private void txtPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cboPBName.Focus();
            }
        }

        private void cboPBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPDescription.Focus();
            }
        }

        private void txtPDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                P_Save();
            }
        }


    }

}
