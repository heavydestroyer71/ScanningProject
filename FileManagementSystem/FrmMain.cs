using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileManagementSystem.DB;
using FileCopyManagementSystem;

namespace FileManagementSystem
{
    public partial class FrmMain : Form
    {
        public FileManagementDbEntities db = new FileManagementDbEntities();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            log_out();
        }
        private void log_out()
        {
            var update = "update [user] set is_login=0 where [user_id]=" + FrmLogin._user_id + "";
            db.ExecuteStoreCommand(update);
            Application.Exit();
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            FrmStart frmStart = new FrmStart();
            frmStart.TopLevel = false;
            frmStart.MdiParent = this;
            frmStart.Show();
        }
    }
}
