﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EAB_Business_Solution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.frmMain());
            //Application.Run(new frmCompany());
        }
    }
}
