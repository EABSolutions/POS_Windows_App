using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EAB_Business_Solution
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpbBasicInfo_Enter(object sender, EventArgs e)
        {

        }

        private void lblTownship_Click(object sender, EventArgs e)
        {

        }

        private void txtTownship_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSCancel_Click(object sender, EventArgs e)
        {
            pnlSCompany.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSCompany.Visible = true;
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            pnlSCompany.Visible = false;
        }
    }
}
