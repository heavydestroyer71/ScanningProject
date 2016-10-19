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
using System.Configuration;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Transactions;

namespace FileManagementSystem
{
    public partial class frmStartByRegan : Form
    {
        private FileManagementDbEntities db = new FileManagementDbEntities();
        private string _img_extentions = ConfigurationManager.AppSettings["img_extentions"];
        private string scan_path = ConfigurationManager.AppSettings["scan_path"];
        HashSet<string> _allowedExtensions;
        public frmStartByRegan()
        {
            InitializeComponent();
            LoadDefault();
            //load_challan();
        }

        private void LoadDefault()
        {
            lblGreeting.Text = FrmLogin._login_name;
            string[] img_ext_list = this._img_extentions.Split(',').ToArray();
            this._allowedExtensions = new HashSet<string>(img_ext_list, StringComparer.OrdinalIgnoreCase);
            //string val = cbRegion.SelectedItem.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var update = "update [user] set is_login=0 where [user_id]=" + FrmLogin._user_id + "";
            db.ExecuteStoreCommand(update);
            updateLastWork();
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbChallan.SelectedValue.ToString());
            BoxBatchAssignToUser();
            if (lblBatchId.Text != "" && lblBoxId.Text != "")
            {
                this.timer1.Enabled = true;
                lblNotice.Visible = true;
                lblNotice.Text = "Service is running...";
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                MessageBox.Show("Box and batch is empty!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblNotice.Text = "Service is stopped...";
            btnStart.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblNotice.Text = "Service is running";
            string[] array = Directory.GetFiles(scan_path);
            if (array.Count() == 0 || array[0].Contains("Thumbs.db"))
            {
                lblNotice.Text += "Waiting for Files";
            }
            else
            {
                lblNotice.Text = "Service is running...";
                using (TransactionScope tran = new TransactionScope() )
                {
                    try
                    {
                        //When batch is complete
                        int scannd = int.Parse(lblScannedCnt.Text);
                        if (scannd == int.Parse(lblFileQty.Text) * 2)
                        {
                            timer1.Enabled = false;
                            string query = "update batch_info set is_complete = 1, file_scanned = " + lblScannedCnt.Text + " where batch_info_id = " + lblBatchId.Text + "";
                            db.ExecuteStoreCommand(query);
                            MessageBox.Show("Batch is complete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int box_id = int.Parse(lblBoxId.Text);
                            //Checking for box complete or not
                            List<batch_info> batch = db.batch_info.Where(s => s.is_complete != 1 && s.box_info_id == box_id).ToList();
                            if (batch.Count == 0)
                            {
                                //When box complete
                                MessageBox.Show("Sob Complete");
                            }

                            //New Box batch assing or choose the previous pending batch
                            BoxBatchAssignToUser();
                            scannd = 0;
                        }
                        //Transfer file to server
                        byte[] bImage = System.IO.File.ReadAllBytes(array[0]);
                        string un = FrmLogin._login_name;
                        string cn = lblChallanName.Text;
                        string bn = lblBox.Text;
                        string batn = lblBatch.Text;
                        string file_name = Path.GetFileName(array[0]);
                        //string URL = @"http://27.147.149.195:1010/api/values/AddApp?userName=asde&challan_no=RVF-001&box_no=DHK-RVF-PRE-001&batch_no=DHK-RVF-PRE-001_01&image=bImage";

                        string URL = ConfigurationManager.AppSettings["url_path"];

                        SendDataToService(bImage, un, cn, bn, batn, URL, file_name);
                        File.Delete(array[0]);
                        lblScannedCnt.Text = (scannd + 1).ToString();
                        tran.Complete();
                    }

                    catch (TransactionAbortedException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    catch (ApplicationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        timer1.Enabled = true;
                    } 
                }
            }
        }

        private static void SendDataToService(byte[] bImage, string un, string cn, string bn, string batn, string URL, string file_name)
        {
            var vm = new { userName = un, challan_no = cn, box_no = bn, batch_no = batn, image = bImage, fileName = file_name };
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(vm);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                client.UploadString(new Uri(URL), "POST", dataString);
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

        private void frmStartByRegan_Load(object sender, EventArgs e)
        {
            lblChallanName.Text = "";
            //BoxBatchAssignToUser();
            pnlBoxBatch.Show();
            load_challan();
            btnStop.Enabled = false;
        }

        private void BoxBatchAssignToUser()
        {
            ASSIGN_BATCH_TO_USER_Result info = new ASSIGN_BATCH_TO_USER_Result();
            info = db.ASSIGN_BATCH_TO_USER(FrmLogin._user_id,int.Parse(cbChallan.SelectedValue.ToString())).FirstOrDefault();
            if (info == null)
            {
                MessageBox.Show("Something went wrong! Please contact your administrator.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (info.exist == 0)
            {
                string message = "Last batch is not completed yet." + Environment.NewLine;
                message += "Box :" + info.box_name.ToString() + Environment.NewLine;
                message += "Batch :" + info.batch_name.ToString() + Environment.NewLine;
                message += "File Scanned :" + info.file_scanned.ToString() + Environment.NewLine;
                message += "Please complete the batch!";

                MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lblBox.Text = info.box_name;
                lblBatch.Text = info.batch_name;
                lblBoxId.Text = info.Box_info_id.ToString();
                lblBatchId.Text = info.batch_info_id.ToString();
                lblScannedCnt.Text = info.file_scanned.ToString();
                lblFileQty.Text = info.file_qty.ToString();
                lblChallanName.Text = info.challan_name.ToString();

            }
            else if (info.exist == 1)
            {
                ASSIGN_BATCH_TO_USER_Result result = db.ASSIGN_BATCH_TO_USER(FrmLogin._user_id, int.Parse(cbChallan.SelectedValue.ToString())).FirstOrDefault();
                string message = "Box and batch assigned! Please start scanning";
                MessageBox.Show(message);

                lblBox.Text = result.box_name;
                lblBatch.Text = result.batch_name;
                lblBoxId.Text = info.Box_info_id.ToString();
                lblBatchId.Text = info.batch_info_id.ToString();
                lblScannedCnt.Text = result.file_scanned.ToString();
                lblFileQty.Text = info.file_qty.ToString();
                lblChallanName.Text = info.challan_name.ToString();

            }
            else
            {
                MessageBox.Show("Something went wrong! Please contact your administrator.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmStartByRegan_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Clossing");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                updateLastWork();
                //components.Dispose();
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
            }
            base.Dispose(disposing);
        }

        private void updateLastWork()
        {
            if (int.Parse(lblScannedCnt.Text) >0 && lblBatchId.Text != "" )
            {
                string query = "update batch_info set file_scanned = " + lblScannedCnt.Text + " where batch_info_id = " + lblBatchId.Text + "";
                db.ExecuteStoreCommand(query); 
            }
        }

        private void frmStartByRegan_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closed");
        }
    }
}
