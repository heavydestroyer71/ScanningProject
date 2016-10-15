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
            try
            {
                string query = "Select * from challan_info where challan_id = " + cbChallan.SelectedValue + "";
                challan_info_vm data = db.ExecuteStoreQuery<challan_info_vm>(query).FirstOrDefault();
                box_info box = db.box_info.Where(s => s.challan_id == data.challan_id).FirstOrDefault();
                if (box == null)
                {
                    db.prcDistributePackage(data.challan_id, data.challan_name, data.region, FrmLogin._user_id);
                    MessageBox.Show("Box & Batch created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Box already exists!","Box Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void load_challan()
        {
            List<cbo_load_Challan_Result> data = new List<cbo_load_Challan_Result>();
            data = db.cbo_load_Challan().ToList();
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
