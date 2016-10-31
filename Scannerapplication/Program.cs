using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Scannerapplication.DB;
using System.Reflection;
using System.Diagnostics;

namespace Scannerapplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ImageDbEntities db = new ImageDbEntities();

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
                    System.Diagnostics.Process.Start("http://27.147.149.195:2020/");
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
                    Application.Run(new frmLogin());
                }
            }
        }
    }
}
