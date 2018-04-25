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

namespace EAB_Business_Solution
{
    public partial class frmDepartment : Form
    {
        Class.clsDepartment D = new Class.clsDepartment();
        Class.clsMethods M = new Class.clsMethods();
        DataTable dt;
        public  string EID;
        public  string CompID;

        public frmDepartment()
        {
            InitializeComponent();
            Loading();
           
            //D.CreatedEID = Forms.frmMain.control
        }

        #region Methods

        #region Loading
        private void Loading()
        {
            M.TextBox_Enable(false, txtDepartmentID, txtDepartmentName, txtDescription);
            M.Button_Enable(true, btnNew);
            M.Button_Enable(false, btnSave, btnEdit, btnDelete, btnCancel);
            M.TextBox_Clear(txtDepartmentID, txtDepartmentName, txtDescription);
            btnNew.Focus();

        }
        #endregion


        #region GridDataClear
        private void GridDataClear()
        {
            if (this.dgvDepartment.DataSource != null)
            {
                this.dgvDepartment.DataSource = null;
            }
            else
            {
                this.dgvDepartment.Rows.Clear();
            }
        }
        #endregion

        #region SearchPanelLoading
        private void SearchPanelLoading()
        {
            chkSDepartmentNamme.Checked = false;
            DepartmentComboBind();
            SearchCheckboxValidation();
            GridDataClear();
            dgvDepartment.Enabled = false;
        }
        #endregion

        #region SearchDataassign
        private void searchdataassign()
        {
            D.DeptID = cboSDepartment.SelectedValue.ToString();
        }
        #endregion

        #region ShowallDataassign
        private void showalldataassign()
        {
            D.DeptID = "";
        }
        #endregion

        #region Dataassign
        private void dataassign()
        {
            D.DeptID = txtDepartmentID.Text.ToString();
            D.DeptName = txtDepartmentName.Text.ToString();
            D.DeptDescription = txtDescription.Text.ToString();
            D.CompID = CompID.ToString();
            D.CreatedEID = EID.ToString();
        }
        #endregion

        #region Savecheck
        private bool savecheck()
        {

            if (txtDepartmentID.Text.Trim()=="" && txtDepartmentName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartmentID.Focus();
                return false;
            }
            else if (txtDepartmentID.Text.Trim() == "" && txtDepartmentName.Text.Trim() != "")
            {
                MessageBox.Show("Please enter Department ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartmentID.Focus();
                return false;
            }
            else if (txtDepartmentID.Text.Trim() != "" && txtDepartmentName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Department Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartmentName.Focus();
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
                if (D.IsEdit)
                {
                    D.Upd_Department();
                    D.IsEdit = false;
                }
                else
                {
                    D.Ins_Department();
                }
                Loading();
            }
        }
        #endregion

        #region ComboBind
        private void DepartmentComboBind()
        {
            try
            {
                DataTable tbl = new DataTable();
                tbl = D.CallDepartment();
                cboSDepartment.DataSource = tbl;
                cboSDepartment.DisplayMember = "DeptName";
                cboSDepartment.ValueMember = "DeptID";
                cboSDepartment.SelectedIndex = -1;
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
            if (chkSDepartmentNamme.Checked == true && cboSDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose Department Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSDepartment.Focus();
            }
            else if (chkSDepartmentNamme.Checked == true && cboSDepartment.SelectedIndex != -1)
            {
                searchdataassign();
                DataTable tbl = new DataTable();
                tbl = D.SearchDepartment();
                dgvDepartment.DataSource = tbl;
            }      
        }

        private void ShowAll()
        {
            showalldataassign();
            DataTable tbl = new DataTable();
            tbl = D.SearchDepartment();
            dgvDepartment.DataSource = tbl;
        }

        #endregion

        #region SearchCheckboxValidation
        private void SearchCheckboxValidation()
        {
            if (chkSDepartmentNamme.Checked == true)
            {
                cboSDepartment.Enabled = true;
                DepartmentComboBind();
                
            }
            else
            {
                cboSDepartment.Enabled = false;
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
            M.TextBox_Enable(true, txtDepartmentID, txtDepartmentName, txtDescription);
            M.Button_Enable(true, btnSave, btnCancel);
            M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            txtDepartmentID.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            M.TextBox_Enable(true, txtDepartmentName, txtDescription);
            M.Button_Enable(true, btnSave, btnCancel, btnDelete);
            M.Button_Enable(false, btnNew);
            txtDepartmentName.Focus();
            D.IsEdit = true;
        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataassign();
                D.Del_Department();
                Loading();
            }
        }

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            Loading();
        }

       

        private void chkSDepartmentNamme_CheckedChanged(object sender, EventArgs e)
        {
            GridDataClear();
            SearchCheckboxValidation();
        }

        private void btnSShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
            dgvDepartment.Enabled = true;
            SearchCheckboxValidation();
            chkSDepartmentNamme.Checked = false;
            

        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
            if (chkSDepartmentNamme.Checked == false)
            {
                MessageBox.Show("Please check at least one search parameter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkSDepartmentNamme.Focus();
            }
            else
            {
                Search();
                dgvDepartment.Enabled = true;
            }
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void dgvDepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                gridclick();
                txtDepartmentID.Text = dgvDepartment.Rows[e.RowIndex].Cells["Department ID"].Value.ToString();
                txtDepartmentName.Text = dgvDepartment.Rows[e.RowIndex].Cells["Department Name"].Value.ToString();
                txtDescription.Text = dgvDepartment.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            
            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= dgvDepartment.Rows.Count - 1; i++)
            {
                drow = dgvDepartment.Rows[i];
                if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                {
                    string id = drow.Cells[1].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list  
                }
            }
          ;
            foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
            {
                D.DeptID = s;
                D.Del_Department();
                
            }
  
            ShowAll(); 

        }

       

        private void txtDepartmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDepartmentName.Focus();
               
            }
        }

        private void txtDepartmentName_KeyPress(object sender, KeyPressEventArgs e)
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
                txtDepartmentID.Focus();
                M.Button_Enable(false, btnNew, btnEdit, btnDelete);
            }
        }



       

        
    }
}
