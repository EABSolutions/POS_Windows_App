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
    public partial class frmUOM : Form
    {
        Class.clsUOM U = new Class.clsUOM();
        Class.clsMethods M = new Class.clsMethods();
        DataTable dt;
        public string EID;
        public string CompID;
       

        public frmUOM()
        {
            InitializeComponent();
            Loading();

        }

        #region Methods

        #region Loading
        private void Loading()
        {
            M.TextBox_Enable(false, txtUOMID, txtUnitOfMeasureName, txtDescription);
            M.Button_Enable(true, btnNew);
            M.Button_Enable(false, btnSave, btnEdit, btnDelete, btnCancel);
            M.TextBox_Clear(txtUOMID, txtUnitOfMeasureName, txtDescription);
            btnNew.Focus();

        }
        #endregion

         #region AutoID
        private void AutoID()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = U.AutoID_UOM();
                txtUOMID.Text = tbl.Rows[0][0].ToString();
                
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
            if (this.dgvSUOM.DataSource != null)
            {
                this.dgvSUOM.DataSource = null;
            }
            else
            {
                this.dgvSUOM.Rows.Clear();
            }
        }
        #endregion

        #region SearchPanelLoading
        private void SearchPanelLoading()
        {
            chkSUnitOfMeasureName.Checked = false;
            UOMComboBind();
            SearchCheckboxValidation();
            GridDataClear();
            dgvSUOM.Enabled = false;
        }
        #endregion

        #region SearchDataassign
        private void searchdataassign()
        {
            U.UOMID = cboSUOM.SelectedValue.ToString();
        }
        #endregion

        #region ShowallDataassign
        private void showalldataassign()
        {
            U.UOMID = "";
        }
        #endregion

        #region Dataassign
        private void dataassign()
        {
            U.UOMID = txtUOMID.Text.Trim();
            U.UOMName = txtUnitOfMeasureName.Text.Trim();
            U.UOMDescription = txtDescription.Text.Trim();

            if (EID == null)
            {
                U.CreatedEID = "";
            }
            else
            {
                U.CreatedEID = EID;
            }
        }
        #endregion

        #region Savecheck
        private bool savecheck()
        {

            if (txtUOMID.Text.Trim() == "" && txtUnitOfMeasureName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUOMID.Focus();
                return false;
            }
            else if (txtUOMID.Text.Trim() == "" && txtUnitOfMeasureName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter UnitOfMeasure ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUOMID.Focus();
                return false;
            }
            else if (txtUOMID.Text.Trim() != "" && txtUnitOfMeasureName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter UnitofMeasure Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitOfMeasureName.Focus();
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
                if (U.IsEdit)
                {
                    U.Upd_UOM();
                    U.IsEdit = false;
                }
                else
                {
                    U.Ins_UOM();
                }
                Loading();
            }
        }
        #endregion

        #region ComboBind
        private void UOMComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = U.CallUOM();
                cboSUOM.DataSource = tbl;
                cboSUOM.DisplayMember = "UOMName";
                cboSUOM.ValueMember = "UOMID";
                cboSUOM.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        #endregion


        #region Search
        private void Search()
        {
            if (chkSUnitOfMeasureName.Checked == true && cboSUOM.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose UOM Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSUOM.Focus();
            }
            else if (chkSUnitOfMeasureName.Checked == true && cboSUOM.SelectedIndex != -1)
            {
                searchdataassign();
                DataTable tbl = new DataTable();
                tbl = U.SearchUOM();
                dgvSUOM.DataSource = tbl;
            }
        }

        private void ShowAll()
        {
            showalldataassign();
            DataTable tbl = new DataTable();
            tbl = U.SearchUOM();
            dgvSUOM.DataSource = tbl;
        }

        #endregion

        #region SearchCheckboxValidation
        private void SearchCheckboxValidation()
        {
            if (chkSUnitOfMeasureName.Checked == true)
            {
                cboSUOM.Enabled = true;
                UOMComboBind();

            }
            else
            {
                cboSUOM.Enabled = false;
            }
        }
        #endregion

        #region GridClick
        private void gridclick()
        {
            Loading();
            M.Button_Enable(true, btnNew, btnEdit, btnDelete, btnCancel);
        }
        #endregion

        #endregion
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPanelLoading();
            SearchCheckboxValidation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtUOMID, txtUnitOfMeasureName, txtDescription);
            M.Button_Enable(true, btnSave, btnCancel);
            M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            txtUOMID.Focus();
            txtUOMID.Enabled = false;
            AutoID();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtUnitOfMeasureName, txtDescription);
            M.Button_Enable(true, btnSave, btnCancel, btnDelete);
            M.Button_Enable(false, btnNew);
            txtUnitOfMeasureName.Focus();
            U.IsEdit = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataassign();
                U.Del_UOM();
                Loading();
            }

        }

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void cboSUOM_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnSShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
            dgvSUOM.Enabled = true;
            SearchCheckboxValidation();
            chkSUnitOfMeasureName.Checked = false;
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
            if (chkSUnitOfMeasureName.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSUnitOfMeasureName.Focus();
            }
            else
            {
                Search();
                dgvSUOM.Enabled = true;
            }
        }

        private void dgvSUOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSUOM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridclick();
                txtUOMID.Text = dgvSUOM.Rows[e.RowIndex].Cells["UOM ID"].Value.ToString();
                txtUnitOfMeasureName.Text = dgvSUOM.Rows[e.RowIndex].Cells["UOM Name"].Value.ToString();
                txtDescription.Text = dgvSUOM.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                tbcUOM.SelectedTab = tbpUOMEntry;
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            {

                List<string> selectedItem = new List<string>();
                DataGridViewRow drow = new DataGridViewRow();
                for (int i = 0; i <= dgvSUOM.Rows.Count - 1; i++)
                {
                    drow = dgvSUOM.Rows[i];
                    if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                    {
                        string id = drow.Cells[1].Value.ToString();
                        selectedItem.Add(id); //If checked adding it to the list  
                    }
                }
                ;
                foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
                {
                    U.UOMID = s;
                    U.Del_UOM();

                }

                ShowAll();

            }
        }

        private void txtUOMID_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSUnitOfMeasureName_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
        }

        private void txtUOMID_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == 13)
                {
                    txtUnitOfMeasureName.Focus();

                }
            }

        }

        private void txtUnitOfMeasureName_KeyPress(object sender, KeyPressEventArgs e)
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
                txtUOMID.Focus();
                M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            }
        }
    }
}

