using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileManagementSystem.DB;
using System.Configuration;
using System.Threading;
using System.IO;
using FileCopyManagementSystem;
using System.Net;
using Newtonsoft.Json;

namespace FileManagementSystem
{
    public partial class FrmStart : Form
    {
        public FileManagementDbEntities db = new FileManagementDbEntities();
        private bool _is_started = false;
        private bool _can_start = false;
        private static BackgroundWorker _backWorker = new BackgroundWorker();
        private string _scan_path = ConfigurationManager.AppSettings["scan_path"];
        private string _transfer_path = ConfigurationManager.AppSettings["transfer_path"];
        private string _url_path = ConfigurationManager.AppSettings["url_path"];
        //private string _url_path = @"http://27.147.149.195:1010/api/values/AddApp";
        //private string _url_path = @"http://192.168.2.5:1010/api/values/AddApp";
        private string _img_extentions = ConfigurationManager.AppSettings["img_extentions"];
        private int thread_sleep = int.Parse(ConfigurationManager.AppSettings["thread_sleep"]);
        HashSet<string> _allowedExtensions;
        private string _root_path = @"C:\Scanning";
        private int counter;
        private int _batch_info_id;
        private string _final_path;
        string _challan_name;
        string _box_name;
        string _batch_name;
        public FrmStart()
        {
            InitializeComponent();
            LoadDefault();
            load_challan();
            //RunThreadBackgroud();

        }
        private void LoadDefault()
        {
            lblGreeting.Text = FrmLogin._login_name;
            string[] img_ext_list = this._img_extentions.Split(',').ToArray();
            this._allowedExtensions = new HashSet<string>(img_ext_list, StringComparer.OrdinalIgnoreCase);
            //string val = cbRegion.SelectedItem.ToString();
        }

        private void load_challan()
        {
            var _challan = "select * from challan_info where is_completed=0";
            var challan = db.ExecuteStoreQuery<challan_info>(_challan).ToList();
            cbChallan.DataSource = challan;
            cbChallan.DisplayMember = "challan_name";
            cbChallan.ValueMember = "challan_name";
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            lblNotice.Visible = true;
            lblNotice.Text = "Service is running...";
            btnStart.Enabled = false;
            //Get Box & Batch


            //previos code need for use

            //get_file_info();
            //this._can_start = true;
            //SendImageToRemote();

            //this._can_start = true;
            //if (this._is_started == false)
            //{
            //    this._is_started = true;
            //    _backWorker.RunWorkerAsync();
            //}
        }
        private void check_info()
        {
            try
            {
                //var uquery = "select ";
                var query1 = "select * from box_info bx inner join challan_info ch on ch.challan_id=bx.challan_id where region='" + cbRegion.SelectedValue + "' and challan_name='" + cbChallan.SelectedValue + "' and is_complete=0";
                box_info result1 = db.ExecuteStoreQuery<box_info>(query1).FirstOrDefault();
                _challan_name = cbChallan.SelectedValue.ToString();
                _box_name = result1.box_name;
                if (result1 != null)
                {
                    var query2 = "select * from batch_info where box_info_id=" + result1.box_info_id + " and is_complete=0";
                    batch_info result2 = db.ExecuteStoreQuery<batch_info>(query2).FirstOrDefault();
                    _batch_name = result2.batch_name;
                    //update box_info
                    if (result2 == null)
                    {
                        var uquery = "update box_info set is_complete=1 where box_info_id=" + result1.box_info_id + "";
                        var update = db.ExecuteStoreCommand(uquery);
                        MessageBox.Show("" + result1.box_name + " is completing.Go to next Box!");
                        return;
                    }
                    pnlBoxBatch.Visible = true;
                    lblBox.Text = result1.box_name;
                    lblBatch.Text = result2.batch_name;
                    counter = ((int)result2.file_qty * 2) - 1;
                    _batch_info_id = result2.batch_info_id;
                    string _dynamicPath = Path.Combine(cbChallan.SelectedValue.ToString(), FrmLogin._login_name, lblBox.Text, lblBatch.Text);
                    _final_path = Path.Combine(_root_path, _dynamicPath + "\\");
                    createFolder(_final_path);
                    SendImageToRemote();


                    //find the box matching with challan & region 
                    //var query2 = "select * from box_info where assign_user_id=" + FrmLogin._user_id + " and is_complete=0";
                    //box_info result2 = db.ExecuteStoreQuery<box_info>(query2).FirstOrDefault();
                    //if (result2!=null)
                    //{
                    //    //user wise box and batch
                    //    pnlBoxBatch.Visible = true;
                    //    lblBox.Text = result2.box_name;
                    //    lblBatch.Text = result2.box_name;
                    //}
                    //else
                    //{
                    //    //not found box
                    //    MessageBox.Show("you Not found");
                    //}
                }
                else
                {
                    //box not created
                    this.timer1.Enabled = false;
                    MessageBox.Show("No Boxes is available here!");
                }
            }
            catch (Exception ex)
            {
                this.timer1.Enabled = false;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                MessageBox.Show(ex.ToString());
            }
        }

        private void RunThreadBackgroud()
        {
            _backWorker.DoWork += new DoWorkEventHandler(_backWorker_DoWork);
            _backWorker.WorkerReportsProgress = true;
            _backWorker.WorkerSupportsCancellation = true;
            _backWorker.RunWorkerAsync();
        }
        private void _backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_can_start)
            {
                SendImageToRemote();
                Thread.Sleep(thread_sleep);
            }
        }
        private void SendImageToRemote()
        {
            try
            {
                _can_start = true;
                if (_can_start == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(this._scan_path);
                    List<FileInfo> files = Array.FindAll(dirInfo.GetFiles(), f => this._allowedExtensions.Contains(f.Extension)).OrderBy(a => a.CreationTime).ToList();
                    //string[] files = Directory.GetFiles(this._scan_path);
                    foreach (FileInfo fl in files)
                    {
                        byte[] bImage = System.IO.File.ReadAllBytes(fl.FullName);
                        string[] count = Directory.GetFiles(this._final_path);
                        if (count.Length <= counter)
                        {

                            string f_name = Path.GetFileName(fl.Name);
                            fl.MoveTo(_final_path + f_name);
                            SendDataToService(bImage, FrmLogin._login_name, _challan_name, _box_name, _batch_name, _url_path, f_name);
                            insert_filemanagement(f_name);
                            if (count.Length == counter)
                            {
                                var query = "update batch_info set is_complete=1 where batch_info_id=" + _batch_info_id + "";
                                var update = db.ExecuteStoreCommand(query);
                                DialogResult msg= MessageBox.Show("Batch is completed.Go to next Batch");
                                if (msg==DialogResult.OK)
                                {
                                    check_info();
                                }
                            }
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void update()
        {


        }
        private void insert_filemanagement(string image_name)
        {
            file_management_info _file_management = new file_management_info
            {
                user_id = FrmLogin._user_id,
                challan_id = get_file_info().challan_id,
                box_info_id = get_file_info().box_info_id,
                batch_info_id = get_file_info().batch_info_id,
                image_name = image_name,
                image_create_date = DateTime.Now,
                isqc_checked = 0

            };
            db.file_management_info.AddObject(_file_management);

            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                db.SaveChanges();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            log_out();
        }
        private void log_out()
        {
            var update = "update [user] set is_login=0 where [user_id]=" + FrmLogin._user_id + "";
            db.ExecuteStoreCommand(update);
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void cbRegion_DropDown(object sender, EventArgs e)
        {
            var _region = "select distinct(region) from packet_info where challan_name='" + cbChallan.SelectedValue + "'";

            var region = db.ExecuteStoreQuery<string>(_region).ToList();
            cbRegion.DataSource = region;
            cbRegion.DisplayMember = "region";
        }

        private void cbPacketInfo_DropDown(object sender, EventArgs e)
        {
            var _packet = "select packet_name from packet_info where challan_name='" + cbChallan.SelectedValue + "' and region='" + cbRegion.SelectedValue + "' and challan_box_no='" + cbChallan_box.SelectedValue + "'";

            var packet = db.ExecuteStoreQuery<string>(_packet).ToList();
            cbPacketInfo.DataSource = packet;
            cbPacketInfo.DisplayMember = "packet_name";
        }

        private void cbChallan_box_DropDown(object sender, EventArgs e)
        {
            var _challan_box = "select distinct(challan_box_no) from packet_info where challan_name='" + cbChallan.SelectedValue + "' and region='" + cbRegion.SelectedValue + "'";

            var challan_box = db.ExecuteStoreQuery<string>(_challan_box).ToList();
            cbChallan_box.DataSource = challan_box;
            cbChallan_box.DisplayMember = "challan_box_no";
        }
        public file_management get_file_info()
        {
            var query = "exec get_file_management_info 11,'" + cbRegion.SelectedValue + "'";
            file_management file_info = db.ExecuteStoreQuery<file_management>(query).FirstOrDefault();
            return file_info;
        }
        private string FolderPath()
        {
            var challan = "select challan_id,challan_name from challan_info where is_completed=0";
            var result = db.ExecuteStoreQuery<challanPath>(challan).FirstOrDefault();

            var root_path = result.challan_name;
            var user_name = lblGreeting.Text;

            var box_name = "select box_info_id,box_name from box_info where challan_id=" + result.challan_id + " and is_complete=0";
            var result1 = db.ExecuteStoreQuery<boxPath>(box_name).FirstOrDefault();
            var sub_root_path = result1.box_name;
            var batch_name = "select box_name from box_info where challan_id=" + result.challan_id + " and box_info_id=" + result1.box_info_id + " and  is_complete=0";
            var sub_path = db.ExecuteStoreQuery<string>(batch_name).FirstOrDefault();

            string merge_path = Path.Combine(root_path, user_name, sub_root_path, sub_path);
            string final_path = Path.Combine(@"C:\Scanning", merge_path + "\\");
            createFolder(final_path);
            return final_path;

        }

        public void createFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public partial class challanPath
        {
            public int challan_id { get; set; }
            public string challan_name { get; set; }
        }
        public partial class boxPath
        {
            public int box_info_id { get; set; }
            public string box_name { get; set; }
        }
        public partial class file_management
        {
            public int user_id { get; set; }
            public int challan_id { get; set; }
            public int box_info_id { get; set; }
            public int batch_info_id { get; set; }
            public int file_qty { get; set; }
            public string image_name { get; set; }
        }
        public partial class GetBoxBatch
        {
            public string box_name { get; set; }
            public string batch_name { get; set; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this._is_started == false)
            {
                check_info();
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblNotice.Text = "Service is stop...";
            btnStart.Enabled = true;
        }

        //GetBoxBatch _box_batch = db.ExecuteStoreQuery<GetBoxBatch>("exec get_file_name '" + cbChallan.SelectedValue + "', '" + cbRegion.SelectedValue + "'").FirstOrDefault();
    }
}
