using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FileCopyManagementSystem;
using System.Diagnostics;
using FileManagementSystem.DB;
using System.Reflection;

namespace FileManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    //prevent creating instance of a new exe
        //    Process[] result = Process.GetProcessesByName("FileManagementSystem");
        //    if (result.Length > 1)
        //    {
        //        MessageBox.Show("There is already a instance running.", "Information");
        //        System.Environment.Exit(0);
        //    }
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new FrmLogin());
        //}

        static void Main()
        {
            FileManagementDbEntities db = new FileManagementDbEntities();

            //New version released

            string version = db.tblSoftwareVers.OrderByDescending(o => o.ReleaseDate).Select(s => s.Version).FirstOrDefault();
            Assembly a = Assembly.GetExecutingAssembly();
            string currVersion = a.GetName().Version.ToString();
            if (version != currVersion)
            {
                if (MessageBox.Show("Updated version is released. Do you want to download?",
    "Important",
    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://192.168.2.5:2020/");
                }

                Application.Exit();
            }
            else
            {
                //Date expired
                DateTime expireDate = new DateTime(2017, 01, 01);
                DateTime date = DateTime.Now;
                if (expireDate <= date)
                {
                    MessageBox.Show("Contact to your system administrator!");
                    Application.Exit();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FrmLogin());
                }
            }
        }
    }
}
