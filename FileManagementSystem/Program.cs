using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FileCopyManagementSystem;
using System.Diagnostics;

namespace FileManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //prevent creating instance of a new exe
            Process[] result = Process.GetProcessesByName("FileManagementSystem");
            if (result.Length > 1)
            {
                MessageBox.Show("There is already a instance running.", "Information");
                System.Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
