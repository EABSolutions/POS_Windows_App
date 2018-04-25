using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary; 

namespace EAB_Business_Solution.Class
{
    class clsSqlDataModules
    {
        public string Server, DB, ID, PW;
        private string filepath;
        private string GetDir = "";
        DataSet login = new DataSet();

        public clsSqlDataModules(string path)
        {
            filepath = path + "\\Login.bin";
            refreshCon();
        }
        public clsSqlDataModules()
        {
            ConnectionString();
        }

        public string ConnectionString()
        {
            refreshCon();
            return string.Format("Server={0};Database={1};uid={2};password={3}", Server, DB, ID, PW);
        }

        private void refreshCon()
        {
            using (FileStream fs = new FileStream(filepath + GetDir, FileMode.Open))
            {
                BinaryFormatter fmt = new BinaryFormatter();
                login = (DataSet)fmt.Deserialize(fs);
            }
            foreach (DataRow row in login.Tables[0].Rows)
            {
                Server = row[0].ToString();
                DB = row[1].ToString();
                ID = row[2].ToString();
                PW = row[3].ToString() == "" ? "" : row[3].ToString();

            }
        }

    }
}
