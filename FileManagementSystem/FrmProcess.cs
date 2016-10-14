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
    public partial class FrmProcess : Form
    {
        public FileManagementDbEntities db = new FileManagementDbEntities();

        public FrmProcess()
        {
            InitializeComponent();
            load_challan();
            load_region();
            
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var process = "exec prcDistributePackage "+cbChallan.SelectedValue+",'"+cbChallan.Text+"','" + cbRegion.SelectedValue + "'," + FrmLogin._user_id + "";
            db.ExecuteStoreCommand(process);
            MessageBox.Show("Box & Batch created successfully!");
        }

        private void load_challan()
        {
            var query = "select * from challan_info where is_completed=0";
            List<challan_info> data = db.ExecuteStoreQuery<challan_info>(query).ToList();
            cbChallan.DataSource = data;
            cbChallan.DisplayMember = "challan_name";
            cbChallan.ValueMember = "challan_id";

        }
        private void load_region()
        {
            var query = "select distinct(region) from packet_info";

            var region = db.ExecuteStoreQuery<string>(query).ToList();
            cbRegion.DataSource = region;
            cbRegion.DisplayMember = "region";
        }
    }
}
