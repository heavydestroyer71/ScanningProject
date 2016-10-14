using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileCopyManagementSystem;
using FileManagementSystem.DB;

namespace FileManagementSystem
{
    public partial class FrmSupervisor : Form
    {
        FileManagementDbEntities db = new FileManagementDbEntities();
        public FrmSupervisor()
        {
            InitializeComponent();
            lblGreeting.Text = FrmLogin._login_name;
        }

        private void log_out()
        {
            var update = "update [user] set is_login=0 where [user_id]=" + FrmLogin._user_id + "";
            db.ExecuteStoreCommand(update);
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            log_out();
        }

        private void userEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
        }

        private void packetEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacket frmPacket = new FrmPacket();
            frmPacket.Show();
        }

        private void boxBatchProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void processBoxAndBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProcess frmProcess = new FrmProcess();
            frmProcess.Show();
        }
    }
}
