using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace EAB_Business_Solution.Report_Class
{
    class clsStockReport
    {
        Class.clsSqlDataModules sql = new Class.clsSqlDataModules(System.Windows.Forms.Application.StartupPath);
        SqlDataAdapter da;
        SqlCommand cmd;
        System.Data.DataTable dt;

        public clsStockReport()
        {
           
        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook book;
            Microsoft.Office.Interop.Excel._Worksheet sheet;
            book = app.Workbooks.Open(Directory.GetCurrentDirectory().ToString() + @"\Report Templates\Rpt_Stock_Report.xls", 0, true, 5, "", "", true,
                Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, false, 0, false, true, false);
            sheet = (Microsoft.Office.Interop.Excel._Worksheet)book.Worksheets.get_Item(1);

            int j = 1;
            int i = 8;
            Microsoft.Office.Interop.Excel.Range r1;
            Microsoft.Office.Interop.Excel.Range r2;
            Microsoft.Office.Interop.Excel.Range rgLine;

            dt = Get_Report();
            if (dt.Rows.Count > 0)
            {
                 sheet.Cells[4, "B"] = System.DateTime.Now;
                        foreach (DataRow dr in dt.Rows)
                        {

                            sheet.Cells[i , "A"] = j;
                            sheet.Cells[i , "B"] = dr.ItemArray[1].ToString();
                            sheet.Cells[i , "C"] = dr.ItemArray[2].ToString();

                            r1 = sheet.Cells[i, "A"];
                            r2 = sheet.Cells[i, "C"];
                            rgLine = sheet.get_Range(r1, r2);
                            rgLine.Borders.LineStyle = XlLineStyle.xlContinuous;

                            i = i + 1;
                            j = j + 1;

                      

                         

                        }

                        sheet.Protect("Invpwd", true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
                        app.Visible = true;      
            }
            else
            {
                app.Visible = false;
                MessageBox.Show("NO DATA Found", "Stock Report");
            }    
         }

        public System.Data.DataTable Get_Report()
        {
            dt = new System.Data.DataTable();
            da = new SqlDataAdapter("Rpt_Stock", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
    }
}
