using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace EAB_Business_Solution.Class
{
    public class clsMethods
    {
        public void TextBox_Enable(bool Enable, params TextBox[] txt)
        {
            foreach (TextBox mytxt in txt)
            {
                mytxt.Enabled = Enable;
            }

        }

        public void Combobox_Enable(bool Enable, params ComboBox[] cbo)
        {
            foreach (ComboBox mycbo in cbo)
            {
                mycbo.Enabled = Enable;
            }

        }

        public void RadioToolStripButton_Enable(bool Enable, params RadioButton[] rbt)
        {
            foreach (RadioButton myrbt in rbt)
            {
                myrbt.Enabled = Enable;
            }

        }

        public void RadioButton_Clear(params RadioButton[] rbt)
        {
            foreach (RadioButton myrbt in rbt)
            {
                myrbt.Checked = false;
            }

        }

        public void RadioButton_Enable(bool Enable, params RadioButton[] rbt)
        {
            foreach (RadioButton myrbt in rbt)
            {
                myrbt.Enabled = Enable;
            }

        }

        public void CheckBox_Enable(bool Enable, params CheckBox[] chk)
        {
            foreach (CheckBox mychk in chk)
            {
                mychk.Enabled = Enable;
            }

        }

        public void CheckListBox_Enable(bool Enable, params CheckedListBox[] chk)
        {
            foreach (CheckedListBox mychk in chk)
            {
                mychk.Enabled = Enable;
            }

        }

        public void DateTimePicker_Enable(bool Enable, params DateTimePicker[] dtp)
        {
            foreach (DateTimePicker mydtp in dtp)
            {
                mydtp.Enabled = Enable;
            }

        }

        public void Label_Enable(bool Enable, params Label[] lbl)
        {
            foreach (Label mylbl in lbl)
            {
                mylbl.Enabled = Enable;
            }

        }

        public void Button_Enable(bool Enable, params Button[] btn)
        {
            foreach (Button mybtn in btn)
            {
                mybtn.Enabled = Enable;
            }

        }

        public void DataGridView_Enable(bool Enable, params DataGridView[] dgv)
        {
            foreach (DataGridView mydgv in dgv)
            {
                mydgv.Enabled = Enable;
            }

        }

        public void Checkbox_Checked(bool Checked, params CheckBox[] chk)
        {
            foreach (CheckBox mychk in chk)
            {
                mychk.Checked = Checked;
            }

        }

        public void GroupBox_Enabled(bool Enabled, params GroupBox[] gpb)
        {
            foreach (GroupBox mygpb in gpb)
            {
                mygpb.Enabled = Enabled;
            }

        }

                
        public void TextBox_Clear(params TextBox[] txt)
        {
            foreach (TextBox mytxt in txt)
            {
                mytxt.ResetText();
            }

        }

        public void DataGridView_Clear(params DataGridView[] dgv)
        {
            foreach (DataGridView mydgv in dgv)
            {
                if (mydgv.DataSource != null)
                {
                    mydgv.DataSource = null;
                }
                else
                {
                    mydgv.Rows.Clear();
                }
            }

        }

        public void Combobox_Clear(params ComboBox[] cbo)
        {
            foreach (ComboBox mycbo in cbo)
            {
                mycbo.ResetText();
            }

        }

        public void CheckBox_Clear(params CheckBox[] chk)
        {
            foreach (CheckBox mychk in chk)
            {
                mychk.Checked = false;
            }

        }

        public void DateTimePicker_Clear(params DateTimePicker[] dtp)
        {
            foreach (DateTimePicker mydtp in dtp)
            {
                mydtp.Value = System.DateTime.Today;
            }

        }


        internal void Button_Enable(bool p, DataGridView btnNew, Button btnSearch)
        {
            throw new NotImplementedException();
        }

        public void Grid_Enable(bool Enable, params DataGridView[] dgv)
        {
            foreach (DataGridView mydgv in dgv)
            {
                mydgv.Enabled = Enable;
            }

        }

        public void Grid_Clear(params DataGridView[] dgv)
        {
            foreach (DataGridView mydgv in dgv)
            {
                if (mydgv.DataSource != null)
                {
                    mydgv.DataSource = null;
                }
                else mydgv.Rows.Clear();
            }

        }
    }
}
