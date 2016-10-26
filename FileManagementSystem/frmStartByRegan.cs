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
        private string _final_path = ConfigurationManager.AppSettings["_final_path"];
        HashSet<string> _allowedExtensions;
        public frmStartByRegan()
        {
            InitializeComponent();
            LoadDefault();
            load_challan();
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
            if (btnStop.Enabled)
            {
                MessageBox.Show("Please Stop the service first");
            }
            else
            {
                timer1.Enabled = false;
                var update = "update [user] set is_login=0 where [user_id]=" + FrmLogin._user_id + "";
                db.ExecuteStoreCommand(update);
                updateLastWork();
                this.Hide();
                this.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog(); 
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbChallan.SelectedValue.ToString());
            //BoxBatchAssignToUser();
            if (fromTimer == false)
            {
                if (lblBatchId.Text != "" && lblBoxId.Text != "")
                {
                    this.timer1.Enabled = true;
                    lblNotice.Visible = true;
                    lblNotice.Text = "Service is running...";
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    //if (FrmLogin._user_type_id != 1)
                    //{
                    //    grdPacketList.Show();
                    //    label8.Show();
                    //}
                    grdPacketList.Show();
                    label8.Show();
                    grdBatchList.Show();
                    label7.Show();
                }
                else
                {
                    BoxBatchAssignToUser();
                    fromTimer = false; ;
                }
            }
            else
            {
                BoxBatchAssignToUser();
                fromTimer = false; ;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblNotice.Text = "Service is stopped...";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            updateLastWork();
            Existing_Box_Batch_check_Result info = new Existing_Box_Batch_check_Result();
            info = db.Existing_Box_Batch_check(FrmLogin._user_id).FirstOrDefault();
            LoadPacketAndBatchGrid();
        }

        public static bool enable_timer = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (enable_timer == true)
            {

            }
            //lblNotice.Text = "Service is running";
            DirectoryInfo dirInfo = new DirectoryInfo(scan_path);
            List<FileInfo> files = Array.FindAll(dirInfo.GetFiles(), f => this._allowedExtensions.Contains(f.Extension)).OrderBy(a => a.Name).ToList();

            string[] array = Directory.GetFiles(scan_path);
            if (files.Count() == 0)
            {
                //MessageBox.Show("Folder is empty");
                lblNotice.Text = "Waiting for Files";
                if (lblNotice.BackColor == Color.Black) lblNotice.BackColor = Color.Red;
                else lblNotice.BackColor = Color.Black; 
            }
            else
            {
                lblNotice.Text = "Service is running...";
                using (TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        #region update counter
                        //When batch is complete

                        int scannd = int.Parse(lblScannedCnt.Text);
                        int qty = int.Parse(lblFileQty.Text) * 2;
                        if (scannd == qty)
                        {
                            timer1.Enabled = false;
                            string query = "update batch_info set is_complete = 1,batch_complete_date=GETDATE(), file_scanned = " + (int.Parse(lblScannedCnt.Text)) + " where batch_info_id = " + lblBatchId.Text + "";
                            db.ExecuteStoreCommand(query);
                            MessageBox.Show("Batch is complete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPacketAndBatchGrid();
                            int box_id = int.Parse(lblBoxId.Text);
                            //Checking for box complete or not
                            List<batch_info> batch = db.batch_info.Where(s => s.is_complete != 1 && s.box_info_id == box_id).ToList();
                            if (batch.Count == 0)
                            {
                                //When box complete
                                query = "update box_info set is_complete = 1,complete_date = GETDATE() where box_info_id = " + box_id + "";
                                db.ExecuteStoreCommand(query);
                                MessageBox.Show("Box Completed!");
                                //if All box complete update the challan_box info
                                query = "select * from box_info where box_info_id = " + box_id + " and is_complete = 0";
                                //List<box_info> box = db.box_info.Where(s => s.challan_box_no == lblChallanName.Text & s.is_complete == 0).ToList();
                                List<box_info> box = db.ExecuteStoreQuery<box_info>(query).ToList();
                                if (box.Count == 0)
                                {
                                    // process to complete batch after checking  the batch and box completion
                                   // MessageBox.Show("Challan box Completed");
                                }
                                else
                                {
                                    //BoxBatchAssignToUser();
                                }

                                enable_timer = false;
                                btnForceComplete.Enabled = true;
                                btnStart.Enabled = false;
                                //BoxBatchAssignToUser();
                            }
                            else
                            {
                                //BoxBatchAssignToUser();
                            }

                            //New Box batch assing or choose the previous pending batch
                            if (enable_timer == true)
                            {
                                BoxBatchAssignToUser();
                            }
                            scannd = 0;
                        }
                        #endregion

                        #region Transfer file to server
                        //Transfer file to server
                        if (enable_timer == true)
                        {
                            byte[] bImage = System.IO.File.ReadAllBytes(files[0].FullName);
                            string un = FrmLogin._login_name;
                            string cn = lblChallanName.Text;
                            string bn = lblBox.Text;
                            string batn = lblBatch.Text;
                            string file_name = Path.GetFileName(files[0].FullName);
                            //string URL = @"http://27.147.149.195:1010/api/values/AddApp?userName=asde&challan_no=RVF-001&box_no=DHK-RVF-PRE-001&batch_no=DHK-RVF-PRE-001_01&image=bImage";

                            string URL = ConfigurationManager.AppSettings["url_path"];

                            //save to local Start
                            string f_name = Path.GetFileName(files[0].Name);
                            try
                            {
                                files[0].MoveTo(Path.Combine(_final_path, cn, un, bn, batn) + file_name);
                            }

                            catch (Exception)
                            {
                                disableTimer();
                                MessageBox.Show("Image name can not duplicate!");

                            }
                            ////save to local End
                            string result = SendDataToService(bImage, un, cn, bn, batn, URL, file_name);

                            string query = "INSERT INTO file_management_info"
                                + "([user_id],[challan_id],[box_info_id],[batch_info_id],[image_name],[image_create_date])"
                                + "VALUES ("+FrmLogin._user_id+","+int.Parse(lblChallanId.Text)+","+int.Parse(lblBoxId.Text)+","+int.Parse(lblBatchId.Text)+",'"+file_name+"',GETDATE())";
                            db.ExecuteStoreCommand(query);

                            //lblScannedCnt.Text = (scannd + 1).ToString();
                            updateLastWork();
                            File.Delete(files[0].FullName);
                        }
                        #endregion
                        //timer1.Enabled = true;
                        tran.Complete();
                    }

                    catch (TransactionAbortedException ex)
                    {
                        disableTimer();
                        MessageBox.Show(ex.Message);
                    }

                    catch (ApplicationException ex)
                    {
                        disableTimer();
                        MessageBox.Show(ex.Message);
                    }

                    catch (Exception ex)
                    {
                        disableTimer();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (enable_timer)
                        {
                            timer1.Enabled = true;
                        }
                        else
                        {
                            
                            lblBatch.Text = "BATCH";
                            cbBox.Enabled = true;
                            cbChallan.Enabled = true;
                            lblScannedCnt.Text = "0";
                            lblBatchId.Text = "";
                            lblBoxId.Text = "";
                            lblBox.Text = "BOX";
                            lblChallanName.Text = "";
                            lblFileQty.Text = "";
                            disableTimer();
                            //LoadPacketAndBatchGrid();
                            //BoxBatchAssignToUser();
                        }
                    }
                }
            }
        }

        private void enableTimer()
        {
            enable_timer = true;
            timer1.Enabled = true;
            btnStart.Enabled = false;
            fromTimer = false;
            btnStop.Enabled = true;
        }

        private void disableTimer()
        {
            enable_timer = false;
            timer1.Enabled = false;
            btnStart.Enabled = true;
            fromTimer = true;
            btnStop.Enabled = false;
        }
        private static bool fromTimer = false;
        private static string SendDataToService(byte[] bImage, string un, string cn, string bn, string batn, string URL, string file_name)
        {
            var vm = new { userName = un, challan_no = cn, box_no = bn, batch_no = batn, image = bImage, fileName = file_name };
            string response = null;
            using (var client = new WebClient())
            {
                
                var dataString = JsonConvert.SerializeObject(vm);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                response = client.UploadString(new Uri(URL), "POST", dataString);
                
            }
            return response;
        }

        private void load_challan()
        {
            List<cbo_load_Challan_Result> data = new List<cbo_load_Challan_Result>();
            data = db.cbo_load_Challan().ToList();
            cbChallan.DisplayMember = "challan_name";
            cbChallan.ValueMember = "challan_id";
            cbChallan.DataSource = data;
        }

        private void load_box(int challan_no)
        {
            List<cbo_load_Box_Result> data = new List<cbo_load_Box_Result>();
            data = db.cbo_load_Box(challan_no).ToList();
            cbBox.DataSource = data;
            cbBox.DisplayMember = "box_name";
            cbBox.ValueMember = "box_info_id";

        }
        private void frmStartByRegan_Load(object sender, EventArgs e)
        {
            Existing_Box_Batch_check_Result info = new Existing_Box_Batch_check_Result();
            info = db.Existing_Box_Batch_check(FrmLogin._user_id).FirstOrDefault();
            if (info != null)
            {
                MessageBox.Show("You have incomplete batch");
                cbChallan.Enabled = false;
                cbBox.Enabled = false;
                lblBox.Text = info.box_name;
                lblBatch.Text = info.batch_name;
                lblBoxId.Text = info.Box_info_id.ToString();
                lblBatchId.Text = info.batch_info_id.ToString();
                lblScannedCnt.Text = info.file_scanned.ToString();
                lblFileQty.Text = info.file_qty.ToString();
                lblChallanName.Text = info.challan_name.ToString();
                lblChallanId.Text = info.challan_id.ToString();
                LoadPacketAndBatchGrid(info);
            }
            else
            {
                //db.ASSIGN_BATCH_TO_USER(FrmLogin._user_id, int.Parse(cbChallan.SelectedValue.ToString()), int.Parse(cbBox.SelectedValue.ToString())).FirstOrDefault();
                MessageBox.Show("Please select your box from the list");
            }
            //BoxBatchAssignToUser();
            pnlBoxBatch.Show();
            //load_challan();
            btnStop.Enabled = false;
            btnForceComplete.Enabled = false;
            //grdBatchList.Hide();
            //grdPacketList.Hide();
            //label8.Hide();
            //label7.Hide();
        }

        private void LoadPacketAndBatchGrid(Existing_Box_Batch_check_Result info)
        {
            //Existing_Box_Batch_check_Result info = new Existing_Box_Batch_check_Result();
            //info = db.Existing_Box_Batch_check(FrmLogin._user_id, int.Parse(cbChallan.SelectedValue.ToString()), int.Parse(cbBox.SelectedValue.ToString())).FirstOrDefault();

            List<Load_BatchList_By_Box_Result> batch_list = new List<Load_BatchList_By_Box_Result>();
            batch_list = db.Load_BatchList_By_Box(info.Box_info_id).ToList();
            grdBatchList.DataSource = batch_list;
            grdBatchList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdBatchList.Show();
            label7.Show();

            if (FrmLogin._user_type_id != 1)
            {
                var packet = db.packet_info.Where(s => s.Challan_name == info.challan_name).Select(c => new { c.Challan_name, c.challan_box_no, c.packet_qty }).ToList();
                grdPacketList.DataSource = packet;
                grdPacketList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                grdPacketList.Show();
                label8.Show();
            }
        }

        private void LoadPacketAndBatchGrid()
        {
            Existing_Box_Batch_check_Result info = new Existing_Box_Batch_check_Result();
            info = db.Existing_Box_Batch_check(FrmLogin._user_id).FirstOrDefault();
            if (info != null)
            {
                List<Load_BatchList_By_Box_Result> batch_list = new List<Load_BatchList_By_Box_Result>();
                batch_list = db.Load_BatchList_By_Box(info.Box_info_id).ToList();
                grdBatchList.DataSource = batch_list;
                grdBatchList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                if (FrmLogin._user_type_id != 1)
                {
                    var packet = db.packet_info.Where(s => s.Challan_name == info.challan_name).Select(c => new { c.Challan_name, c.challan_box_no, c.packet_qty }).ToList();
                    grdPacketList.DataSource = packet;
                    grdPacketList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            else
            {
                grdBatchList.Hide();
                grdPacketList.Hide();
            }
        }

        private void BoxBatchAssignToUser()
         {
            //check box exist or not
            Existing_Box_Batch_check_Result exist_box_info = new Existing_Box_Batch_check_Result();
            exist_box_info = db.Existing_Box_Batch_check(FrmLogin._user_id).FirstOrDefault();
            
            if (exist_box_info != null)
            {
                MessageBox.Show("You have incomplete batch", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillControlWithData(exist_box_info);

                LoadPacketAndBatchGrid(exist_box_info);

            }

            //if box not exist assign new box
            else
            {
                db.ASSIGN_BATCH_TO_USER(FrmLogin._user_id, int.Parse(cbChallan.SelectedValue.ToString()), int.Parse(cbBox.SelectedValue.ToString()));


                exist_box_info = db.Existing_Box_Batch_check(FrmLogin._user_id).FirstOrDefault();
                FillControlWithData(exist_box_info);
                MessageBox.Show("Box and Batch assigned successfully!");
                LoadPacketAndBatchGrid(exist_box_info);
            }
        }

        private void FillControlWithData(Existing_Box_Batch_check_Result exist_box_info)
        {
            cbChallan.Enabled = false;
            cbBox.Enabled = false;
            lblBox.Text = exist_box_info.box_name;
            lblBatch.Text = exist_box_info.batch_name;
            lblBoxId.Text = exist_box_info.Box_info_id.ToString();
            lblBatchId.Text = exist_box_info.batch_info_id.ToString();
            lblScannedCnt.Text = exist_box_info.file_scanned.ToString();
            lblFileQty.Text = exist_box_info.file_qty.ToString();
            lblChallanName.Text = exist_box_info.challan_name.ToString();
        }

        private void frmStartByRegan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Clossing");
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
            if (int.Parse(lblScannedCnt.Text) > 0 && lblBatchId.Text != "")
            {
                string query = "update batch_info set file_scanned = " + lblScannedCnt.Text + " where batch_info_id = " + lblBatchId.Text + "";
                db.ExecuteStoreCommand(query);
            }
        }

        private void frmStartByRegan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Closed");
        }

        private void cbChallan_SelectedValueChanged(object sender, EventArgs e)
        {
            var val = cbChallan.SelectedValue;
            if (val != null)
            {
                load_box(Convert.ToInt32(cbChallan.SelectedValue));
            }
        }

        private void btnForceComplete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to complete the box by force?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                db.Batch_Box_Challan_ForceComplete(int.Parse(lblBatchId.Text), int.Parse(lblBoxId.Text));
                btnStart.Enabled = true;
            }
        }
    }
}
