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
using System.Data.OleDb;
using System.Configuration;

namespace FileManagementSystem
{
    public partial class FrmPacket : Form
    {
        private FileManagementDbEntities db = new FileManagementDbEntities();

        public FrmPacket()
        {
            InitializeComponent();
            cbRegion.DataSource = Enum.GetValues(typeof(region));
            load_gridview();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            insert_packet();
            MessageBox.Show("Packet inserted successfully!");
        }
        public void insert_packet()
        {
            packet_info _packet_info = new packet_info
            {
                Challan_name = txtChallan.Text,
                challan_box_no = txtChallanBoxNo.Text,
                packet_name = txtPacketName.Text,
                dealer_name = txtDealerName.Text,
                packet_date = Convert.ToDateTime(dpPacketDate.Text),
                packet_qty = Convert.ToInt32(txtPacketQuantity.Text),
                region = cbRegion.SelectedValue.ToString(),
                packet_receive_date = Convert.ToDateTime(dpPacketReceiveDate.Text)

            };
            db.packet_info.AddObject(_packet_info);
            db.SaveChanges();

            load_gridview();
        }

        private void load_gridview()
        {
            var gvData = from p in db.packet_info
                         orderby p.packect_info_id descending
                         select new { p.Challan_name, p.challan_box_no, p.dealer_name, p.packet_name, p.packet_qty, p.region, p.packet_date, p.packet_receive_date };

            gvPacketInfo.DataSource = gvData;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var process = "exec prcDistributePackage 12,'','" + cbRegion.SelectedValue + "'," + FrmLogin._user_id + "";
            db.ExecuteStoreCommand(process);
            MessageBox.Show("Box & Batch created successfully!");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog res = new OpenFileDialog();
            //res.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            //DialogResult result = selectExcelDialog.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    txtExcelPath.Text = selectExcelDialog.FileName;
            //}
            DataSet ds = new DataSet();
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel files (*.xls or .xlsx)|.xls;*.xlsx";
            file.ShowDialog();
            txtExcelPath.Text = file.FileName;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string filePath = txtExcelPath.Text;
            if (filePath != null)
            {
                try
                {
                    string fileExtension = System.IO.Path.GetExtension(filePath);
                    if (fileExtension == ".xls" || fileExtension == ".xlsx")
                    //if (fileExtension == ".xls")
                    {
                        string excelConnectionString = string.Empty;
                        excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                                filePath + ";Extended Properties=\"Excel 12.0;HDR=No;IMEX=1\"";
                        //connection String for xls file format.
                        if (fileExtension == ".xls")
                        {
                            excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                                                    filePath + ";Extended Properties=\"Excel 8.0;HDR=No;IMEX=1\"";
                        }
                        //connection String for xlsx file format.
                        else if (fileExtension == ".xlsx")
                        {
                            excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                                    filePath + ";Extended Properties=\"Excel 12.0;HDR=No;IMEX=1\"";
                        }

                        OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                        excelConnection.Open();
                        DataTable dt = new DataTable();

                        dt = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        if (dt == null)
                        {
                            //return null;
                        }

                        String[] excelSheets = new String[dt.Rows.Count];
                        int t = 0;

                        //excel data saves in temp file here.
                        foreach (DataRow row in dt.Rows)
                        {
                            excelSheets[t] = row["TABLE_NAME"].ToString();
                            t++;
                        }
                        OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);


                        string query = string.Format("Select * from [{0}]", excelSheets[0]);
                        using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, excelConnection1))
                        {
                            dataAdapter.Fill(ds);
                        }

                        excelConnection.Close();
                    }

                    using (FileManagementDbEntities db = new FileManagementDbEntities())
                    {
                        for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i].ItemArray[0].ToString() != "")    //  Need to check null or empty value 
                            {
                                string excelRow1 = FileManagementSystem.utility.convertStringtoDate(ds.Tables[0].Rows[i][0].ToString());
                                string excelRow2 = FileManagementSystem.utility.convertStringtoDate(ds.Tables[0].Rows[i][1].ToString());
                                string excelRow3 = ds.Tables[0].Rows[i][2].ToString();
                                string excelRow4 = ds.Tables[0].Rows[i][3].ToString();
                                string excelRow5 = ds.Tables[0].Rows[i][4].ToString();
                                string excelRow6 = ds.Tables[0].Rows[i][5].ToString();
                                string excelRow7 = ds.Tables[0].Rows[i][6].ToString();
                                string excelRow8 = ds.Tables[0].Rows[i][7].ToString();

                                //inserting into database

                                string query = "INSERT INTO packet_info (Challan_name,challan_box_no,dealer_name,"
                                + "packet_name,packet_qty,region,packet_receive_date,packet_date,is_complete)"
                                + "VALUES ('" + excelRow3 + "','" + excelRow6 + "','" + excelRow5 + "','" + excelRow7 + "'," + excelRow8 + ",'"
                                + excelRow4 + "','" + excelRow2 + "','" + excelRow1 + "',0)";

                                db.ExecuteStoreCommand(query);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                using (FileManagementDbEntities db = new FileManagementDbEntities())
                {
                    string querystr = "Select Challan_Name,Region,challan_box_no from packet_info"
                                                        + " where is_complete = 0"
                                                        + " Group by Challan_Name,Region,challan_box_no ";
                    List<challan_info_vm> challan_list = db.ExecuteStoreQuery<challan_info_vm>(querystr).ToList();

                    if (challan_list.Count > 0)
                    {
                        foreach (var list in challan_list)
                        {
                            querystr = "INSERT INTO challan_info (challan_name,challan_create_date,is_completed,region,challan_box_no)"
                            + "values ('" + list.challan_name + "',GETDATE(),0,'" + list.region + "','"+list.challan_box_no+"')";
                            db.ExecuteStoreCommand(querystr);
                        }
                    }


                    List<challan_info> challan = db.challan_info.Where(s=>s.is_working == 0).ToList();

                    foreach (var data in challan)
                    {
                        //querystr = "update packet_info set is_complete = 1 where challan_name = '" + list.challan_name + "' and region = '" + list.region + "'";
                        db.prcDistributePackage(data.challan_id, data.challan_name, data.region, 0, data.challan_box_no);
                    }

                    //foreach (var list in challan_list)
                    //{
                    //    querystr = "update packet_info set is_complete = 1 where challan_name = '" + list.challan_name + "' and region = '" + list.region + "'";
                    //    db.ExecuteStoreCommand(querystr);
                    //}

                    MessageBox.Show("Uploaded!");
                    load_gridview(); 
                }
            }
            else
            {
                MessageBox.Show("Please select a file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPacket_Load(object sender, EventArgs e)
        {

        }



    }
}
