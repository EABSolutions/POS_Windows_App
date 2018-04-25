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
    class clsProductSalesQuantityReport
    {
        Class.clsSqlDataModules sql = new Class.clsSqlDataModules(System.Windows.Forms.Application.StartupPath);
        SqlDataAdapter da;
        SqlCommand cmd;
        System.Data.DataTable dt;
        string PName;

        public clsProductSalesQuantityReport(string PID ,DateTime FromDate, DateTime ToDate)
        {
           
             

        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook book;
            Microsoft.Office.Interop.Excel._Worksheet sheet;
            book = app.Workbooks.Open(Directory.GetCurrentDirectory().ToString() + @"\Report Templates\Rpt_ProductSalesQty_Report.xls", 0, true, 5, "", "", true,
                Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, false, 0, false, true, false);
            sheet = (Microsoft.Office.Interop.Excel._Worksheet)book.Worksheets.get_Item(1);

            int j = 1;
            int i = 10;
            Microsoft.Office.Interop.Excel.Range r1;
            Microsoft.Office.Interop.Excel.Range r2;
            Microsoft.Office.Interop.Excel.Range rgLine;

            dt = Get_Report(PID,FromDate, ToDate);
            if (dt.Rows.Count > 0)
            {
                sheet.Cells[4, "B"] = dt.Rows[0][2].ToString();
                sheet.Cells[5, "B"] = FromDate;
                sheet.Cells[6, "B"] = ToDate;
                sheet.Cells[4, "E"] = System.DateTime.Now;
                        foreach (DataRow dr in dt.Rows)
                        {

                            //rgLine = sheet.get_Range(sheet.Cells[i, "A"], sheet.Cells[i, "C"]);
                            //rgLine.Borders.LineStyle = XlLineStyle.xlContinuous;

                            sheet.Cells[i , "B"] = j;
                            sheet.Cells[i , "C"] = dr.ItemArray[0].ToString();
                            sheet.Cells[i , "D"] = dr.ItemArray[3].ToString();

                            r1 = sheet.Cells[i, "B"];
                            r2 = sheet.Cells[i, "D"];
                            rgLine = sheet.get_Range(r1, r2);
                            rgLine.Borders.LineStyle = XlLineStyle.xlContinuous;

                            i = i + 1;
                            j = j + 1;

                      

                         

                        }


                        sheet.Cells[i, "C"] = "Total";
                        sheet.Cells[i, "C"].Font.Bold = true;
                       
                        sheet.Cells[i, "D"] = string.Concat("=sum(D10:D", Convert.ToString(i - 1), ")");//Grand Totall

                        r1 = sheet.Cells[i, "C"];
                        r2 = sheet.Cells[i, "D"];
                        rgLine = sheet.get_Range(r1, r2);
                        rgLine.Borders.LineStyle = XlLineStyle.xlContinuous;

                        sheet.Protect("Invpwd", true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
                        app.Visible = true;      
            }
            else
            {
                app.Visible = false;
                MessageBox.Show("NO DATA Found", "Sales Qty Report");
            }    
         }
        
        public System.Data.DataTable Get_Report(string pid, DateTime fromdate, DateTime todate)
        {
            dt = new System.Data.DataTable();
            da = new SqlDataAdapter("Rpt_ProudctSalesQty", new SqlConnection(sql.ConnectionString()));
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@PID", pid);
            da.SelectCommand.Parameters.AddWithValue("@FromDate", fromdate);
            da.SelectCommand.Parameters.AddWithValue("@ToDate", todate);
            da.Fill(dt);
            return dt;
        }


    }
}
