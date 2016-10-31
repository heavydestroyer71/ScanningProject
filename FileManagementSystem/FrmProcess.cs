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
                    //Change the null value
                    db.prcDistributePackage(data.challan_id, data.challan_name, data.region, 0,data.challan_box_no);
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

        private void load_challan_reset()
        {
            List<cbo_load_Challan_reset_Result> data = new List<cbo_load_Challan_reset_Result>();
            data = db.cbo_load_Challan_reset().ToList();
            cboResetChallanBox.DataSource = data;
            cboResetChallanBox.DisplayMember = "challan_name";
            cboResetChallanBox.ValueMember = "Challan_id";

        }

        private void load_region()
        {
            var query = "select distinct(region) from packet_info";

            var region = db.ExecuteStoreQuery<string>(query).ToList();
            cbRegion.DataSource = region;
            cbRegion.DisplayMember = "region";
        }

        private void load_box(int challan_no)
        {
            List<cbo_load_Box_Reset_Result> data = new List<cbo_load_Box_Reset_Result>();
            data = db.cbo_load_Box_Reset(challan_no).ToList();
            cbBox.DataSource = data;
            cbBox.DisplayMember = "box_name";
            cbBox.ValueMember = "box_info_id";

        }

        private void FrmProcess_Load(object sender, EventArgs e)
        {
            load_challan();
            load_region();
            load_challan_reset();
        }

        private void btnAutoBoxBatch_Click(object sender, EventArgs e)
        {
            List<challan_info> challan = db.challan_info.Where(s => s.is_working != 1).ToList();

            foreach (var data in challan)
            {
                //querystr = "update packet_info set is_complete = 1 where challan_name = '" + list.challan_name + "' and region = '" + list.region + "'";
                db.prcDistributePackage(data.challan_id, data.challan_name, data.region, 0, data.challan_box_no);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset this challan box?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //MessageBox.Show(cboResetChallanBox.SelectedValue.ToString());
                db.ResetChallanBoxBatch(int.Parse(cboResetChallanBox.SelectedValue.ToString()),int.Parse(cbBox.SelectedValue.ToString()));
                load_challan();
                load_challan_reset();
                MessageBox.Show("Challan box reset successfully!");
            }
        }

        private void cboResetChallanBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cboResetChallanBox.SelectedValue.ToString());
            //var val = cboResetChallanBox.SelectedValue;
            int number;
            bool result = Int32.TryParse(cboResetChallanBox.SelectedValue.ToString(), out number);
            if (result)
            {
                load_box(int.Parse(cboResetChallanBox.SelectedValue.ToString()));
            }
        }
    }
}
