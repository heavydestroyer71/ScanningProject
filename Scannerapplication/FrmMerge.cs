using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;
using Scannerapplication.DB;
using System.Drawing.Drawing2D;

namespace Scannerapplication
{
    public partial class FrmMerge : Form
    {
        public string RegPath;
        public string NIDPath;
        string regReSizePath;
        string nidReSizePath;
        public string RegName;
        public string NIDName;
        string cropPath;
        string isDuplicate;
        string mergePath;
        private int _ZoomFactor;
        private Color _BackColor;
        int cropX, cropY, cropWidth, cropHeight;
        int cropRegX, cropRegY, cropRegWidth, cropRegHeight;
        Pen borderpen = new Pen(Color.Red, 2);
        SolidBrush rectbrush = new SolidBrush(Color.FromArgb(100, Color.White));
        private Point _StartPoint;
        private Point _StartPointReg;

        public string ResizePath = @"C:\Scanning\Resize\";
        public string _img_extentions = ConfigurationManager.AppSettings["img_extentions"];
        HashSet<string> _allowedExtensions;

        ImageDbEntities db = new ImageDbEntities();
        imageMergesInfo info = new imageMergesInfo();
        public FrmMerge()
        {
            InitializeComponent();
            LoadDefault();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBrowse.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        public void createFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        private void LoadDefault()
        {
            string[] img_ext_list = this._img_extentions.Split(',').ToArray();
            this._allowedExtensions = new HashSet<string>(img_ext_list, StringComparer.OrdinalIgnoreCase);
        }
        public void showImages(string RegPath, string NIDPath)
        {
            try
            {
                pic_scan.Image = Image.FromFile(RegPath);
                pic_scan.SizeMode = PictureBoxSizeMode.StretchImage;
                pbNID.Image = Image.FromFile(NIDPath);
                pbNID.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void LoadImage()
        {
            try
            {
                if (txtBrowse.Text != "" || txtBrowse.Text == null)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(txtBrowse.Text);
                    List<FileInfo> files = Array.FindAll(dirInfo.GetFiles(), f => this._allowedExtensions.Contains(f.Extension)).OrderBy(a => a.Name).ToList();
                    if (files.Count != 0)
                    {
                        RegPath = files[0].FullName;
                        NIDPath = files[1].FullName;
                        RegName = files[0].Name;
                        NIDName = files[1].Name;
                        regReSizePath = ResizePath + RegName;
                        nidReSizePath = ResizePath + NIDName;
                        ReSize(RegPath, regReSizePath);
                        ReSize(NIDPath, nidReSizePath);
                        showImages(RegPath, NIDPath);
                    }
                    else
                    {
                        //pic_scan.Image.Dispose();
                        //pbNID.Image.Dispose();
                        //pic_scan.Image = null;
                        //pbNID.Image = null;
                        MessageBox.Show("Folder is empty!");
                    }
                }
                else
                {
                    MessageBox.Show("Please browse the file destination!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ReSize(string imgPath, string resavePath)
        {
            try
            {
                createFolder(ResizePath);
                using (var image = Image.FromFile(imgPath))
                using (var newImage = ScaleImage(image, 870, 1120))
                {
                    newImage.Save(resavePath, ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
        public void QcFail()
        {
            try
            {
                string qcpath = txtBrowse.Text.Remove(0, 3);
                string qcFullPath = Path.Combine(@"C:\Scanning\QcFail", qcpath);
                createFolder(qcFullPath);
                pic_scan.Image.Dispose();
                pic_scan.Image = null;
                pbNID.Image.Dispose();
                pbNID.Image = null;
                string comReg = System.IO.Path.Combine(qcFullPath, RegName);
                string comNid = System.IO.Path.Combine(qcFullPath, NIDName);
                System.IO.File.Move(RegPath, comReg);
                System.IO.File.Move(NIDPath, comNid);
                LoadImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public imageMergesInfo CheckMSISDN(imageMergesInfo info)
        {
            imageMergesInfo p = new imageMergesInfo();
            try
            {
                string batch = System.IO.Path.GetFileName(txtBrowse.Text);
                string msisdn = txtMSIDN.Text.Remove(0, 1);
                string query = "select * from imageMergesInfo where msisdn=" + msisdn + " and batch='" + batch + "'";
                p = db.ExecuteStoreQuery<imageMergesInfo>(query).FirstOrDefault();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return p;
            
        }
        public void MergeTwoImages(string path1, string path2)
        {
            try
            {
                string msisdn = txtMSIDN.Text.Remove(0, 1);
                var ch = info.challan;
                var bx = info.Box;
                var bt = info.Batch;
                var com = Path.Combine(ch, bx, bt);
                string mergePath = @"C:\Scanning\Merge\" + com + "";
                createFolder(mergePath);
                string path3 = System.IO.Path.Combine(Application.ExecutablePath, mergePath, txtMSIDN.Text + ".jpg");

                String jpg1 = path1;
                String jpg2 = path2;
                String jpg3 = path3;
                Image img1 = Image.FromFile(jpg1);
                Image img2 = Image.FromFile(jpg2);

                int width = Math.Max(img1.Width, img2.Width);
                int height = img1.Height + img2.Height;
                Bitmap img3 = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(img3);
                g.Clear(Color.White);
                int offset = 0;
                g.DrawImage(img1, new System.Drawing.Rectangle(offset, 0, img1.Width, img1.Height));
                g.DrawImage(img2, new System.Drawing.Rectangle(0, img1.Height, img1.Width, img2.Height));
                g.Dispose();
                img1.Dispose();
                img2.Dispose();
                img3.SetResolution(300, 300);

                using (ImageDbEntities db = new ImageDbEntities())
                {
                    db.ExecuteStoreCommand("update imageMergesInfo set IsComplete=1 where MSISDN=" + msisdn + "");
                    string source_file_name = txtMSIDN.Text + ".jpg";
                    var find = db.SEC_USERS.Where(m => m.LOGIN_ID == frmLogin.SetValueForUserId).Select(m => m.USER_NO).SingleOrDefault();
                    var insert = "insert into mergeImageDetails values(" + find + ",'" + info.Box + "','" + info.Batch + "','" + txtMSIDN.Text.Remove(0, 1) + "','" + source_file_name + "','" + path3 + "','" + null + "','"+DateTime.Now+"')";
                    db.ExecuteStoreCommand(insert);
                    img3.Save(jpg3, System.Drawing.Imaging.ImageFormat.Jpeg);
                    img3.Dispose();
                    pic_scan.Image.Dispose();
                    pic_scan.Image = null;
                    pbNID.Image.Dispose();
                    pbNID.Image = null;
                    System.IO.File.Delete(RegPath);
                    System.IO.File.Delete(NIDPath);
                }
                MessageBox.Show("Images merge successfully!");
                txtMSIDN.Text = "";
                txtMSIDN.Focus();
                LoadImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void MergeTwoImagesNotFound(string path1, string path2)
        {
            try
            {
                string qcpath = txtBrowse.Text.Remove(0, 3);
                if (isDuplicate == "1")
                {
                    mergePath = Path.Combine(@"C:\Scanning\Merge\Duplicate", qcpath);
                }
                else
                {
                    mergePath = Path.Combine(@"C:\Scanning\Merge\QC", qcpath);
                }
                string msisdn = txtMSIDN.Text.Remove(0, 1);
                createFolder(mergePath);
                string path3 = System.IO.Path.Combine(Application.ExecutablePath, mergePath, txtMSIDN.Text + ".jpg");

                String jpg1 = path1;
                String jpg2 = path2;
                String jpg3 = path3;
                Image img1 = Image.FromFile(jpg1);
                Image img2 = Image.FromFile(jpg2);

                int width = Math.Max(img1.Width, img2.Width);
                int height = img1.Height + img2.Height;
                Bitmap img3 = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(img3);
                g.Clear(Color.White);
                int offset = 0;
                g.DrawImage(img1, new System.Drawing.Rectangle(offset, 0, img1.Width, img1.Height));
                g.DrawImage(img2, new System.Drawing.Rectangle(0, img1.Height, img1.Width, img2.Height));
                g.Dispose();
                img1.Dispose();
                img2.Dispose();
                img3.SetResolution(300, 300);
                img3.Save(jpg3, System.Drawing.Imaging.ImageFormat.Jpeg);
                img3.Dispose();
                pic_scan.Image.Dispose();
                pic_scan.Image = null;
                pbNID.Image.Dispose();
                pbNID.Image = null;
                System.IO.File.Delete(RegPath);
                System.IO.File.Delete(NIDPath);
                MessageBox.Show("Images merge successfully!");
                txtMSIDN.Text = "";
                txtMSIDN.Focus();
                LoadImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FrmMerge_Load(object sender, EventArgs e)
        {
            pnlControl.Width = Form1.ActiveForm.Width * 16 / 100;
            pnlRegPic.Width = Form1.ActiveForm.Width * 30 / 100;
            pnlNIDPic.Width = Form1.ActiveForm.Width * 54 / 100;
            //pnlCropPic.Width = Form1.ActiveForm.Width * 23 / 100;
            pic_scan.Width = pnlRegPic.Width;
            pic_scan.Height = pnlRegPic.Height;
            pbNID.Width = pnlNIDPic.Width;
            pbNID.Height = pnlNIDPic.Height;
            //picCrop.Width = pnlCropPic.Width;
            //picCrop.Height = pnlCropPic.Height;
            pnlControl.BorderStyle = BorderStyle.FixedSingle;
            pnlRegPic.BorderStyle = BorderStyle.FixedSingle;
            pnlNIDPic.BorderStyle = BorderStyle.FixedSingle;
            //pnlCropPic.BorderStyle = BorderStyle.FixedSingle;

            this.pic_scan.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbNID.SizeMode = PictureBoxSizeMode.AutoSize;


            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QcFail();
            MessageBox.Show("QC fail images seperate!");
            txtMSIDN.Text = "";
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            info = CheckMSISDN(info);
            if (info != null)
            {
                if (txtMSIDN.Text.Length < 11)
                {
                    MessageBox.Show("Please provide MSIDN no less than 11 digit!");
                    txtMSIDN.Focus();
                }
                else
                {
                    if (info.IsComplete == true)
                    {
                        if (lblCrop.Text == "1")
                        {
                            nidReSizePath = cropPath;
                        }
                        isDuplicate = "1";
                        MessageBox.Show("This MSISDN no already merges!");
                        MergeTwoImagesNotFound(regReSizePath, nidReSizePath);
                    }
                    else
                    {
                        if (lblCrop.Text == "1")
                        {
                            nidReSizePath = cropPath;
                        }
                        MergeTwoImages(regReSizePath, nidReSizePath);
                    }
                }
            }
            else
            {
                DialogResult msg = MessageBox.Show("MSISDN Not Found.Click Yes to try again.Click No for merge QC", "Merges Info", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (msg == DialogResult.No)
                {
                    if (txtMSIDN.Text.Length < 11)
                    {
                        MessageBox.Show("Please provide MSIDN no less than 11 digit!");
                        txtMSIDN.Focus();
                    }
                    else
                    {
                        if (lblCrop.Text == "1")
                        {
                            nidReSizePath = cropPath;
                        }
                        MergeTwoImagesNotFound(regReSizePath, nidReSizePath);
                    }
                }
                else
                {
                    txtMSIDN.Text = "";
                    txtMSIDN.Focus();
                }
            }
        }

        private void pic_scan_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (pic_scan.Image == null)
                    return;

                if (e.Button == MouseButtons.Left)
                {
                    pic_scan.Refresh();
                    cropRegWidth = e.X - cropRegX;
                    cropRegHeight = e.Y - cropRegY;
                }
                pic_scan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_scan_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)//here i have use mouse click left button only
                {
                    pic_scan.Refresh();
                    cropRegX = e.X;
                    cropRegY = e.Y;
                    Cursor = Cursors.Cross;
                    //New
                    _StartPointReg = e.Location;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_scan_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                if (cropRegWidth < 1)
                {
                    return;
                }
                Rectangle rect = new Rectangle(cropRegX, cropRegY, cropRegWidth, cropRegHeight);
                Bitmap bit = new Bitmap(pic_scan.Image, pic_scan.Width, pic_scan.Height);
                Bitmap crop = new Bitmap(cropRegWidth, cropRegHeight);
                Graphics gfx = Graphics.FromImage(crop);
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;//here add  System.Drawing.Drawing2D namespace;
                gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;//here add  System.Drawing.Drawing2D namespace;
                gfx.CompositingQuality = CompositingQuality.HighQuality;//here add  System.Drawing.Drawing2D namespace;
                gfx.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel);
                picZoom.Image = crop;
                pic_scan.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_scan_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Rectangle rect = new Rectangle(cropRegX, cropRegY, cropRegWidth, cropRegHeight);
                Graphics gfx = e.Graphics;
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;//here add  System.Drawing.Drawing2D namespace;
                gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;//here add  System.Drawing.Drawing2D namespace;
                gfx.CompositingQuality = CompositingQuality.HighQuality;//here add  System.Drawing.Drawing2D namespace;
                gfx.DrawRectangle(borderpen, rect);
                gfx.FillRectangle(rectbrush, rect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbNID_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)//here i have use mouse click left button only
                {
                    pbNID.Refresh();
                    cropX = e.X;
                    cropY = e.Y;
                    Cursor = Cursors.Cross;
                    //New
                    _StartPoint = e.Location;
                }
                pbNID.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbNID_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (pbNID.Image == null)
                    return;

                if (e.Button == MouseButtons.Left && cropX!=0 && cropY!=0)
                {
                    pbNID.Refresh();
                    cropWidth = e.X - cropX;
                    cropHeight = e.Y - cropY;
                    //New
                    Point changePoint = new Point(e.Location.X - _StartPoint.X,
                                                  e.Location.Y - _StartPoint.Y);
                    if (cbHorizontalCrop.Checked == true)
                    {
                        pnlNIDPic.AutoScrollPosition = new Point(-pnlNIDPic.AutoScrollPosition.X + 12, -pnlNIDPic.AutoScrollPosition.Y);
                    }
                    else
                    {
                        pnlNIDPic.AutoScrollPosition = new Point(-pnlNIDPic.AutoScrollPosition.X + 12, -pnlNIDPic.AutoScrollPosition.Y + 12);
                    }
                }
                pbNID.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbNID_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                if (cropWidth < 1)
                {
                    return;
                }
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                Bitmap bit = new Bitmap(pbNID.Image, pbNID.Width, pbNID.Height);
                Bitmap crop = new Bitmap(cropWidth, cropHeight);
                Graphics gfx = Graphics.FromImage(crop);
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;//here add  System.Drawing.Drawing2D namespace;
                gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;//here add  System.Drawing.Drawing2D namespace;
                gfx.CompositingQuality = CompositingQuality.HighQuality;//here add  System.Drawing.Drawing2D namespace;
                gfx.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel);
                picCrop.Image = crop;
                pbNID.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbNID_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                Graphics gfx = e.Graphics;
                gfx.DrawRectangle(borderpen, rect);
                gfx.FillRectangle(rectbrush, rect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveCropImage();
            MessageBox.Show("NID crop successfully!");
        }
        public void saveCropImage()
        {
            try
            {
                createFolder(@"C:\Scanning\CropImage");
                Bitmap bm = new Bitmap(picCrop.Image);
                bm.SetResolution(300, 300);
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.DrawImage(picCrop.Image, new Rectangle(0, 0, bm.Width, bm.Height));
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.CompositingQuality = CompositingQuality.HighQuality;
                    cropPath = @"C:\Scanning\CropImage\CropImage.jpg";
                    bm.Save(cropPath);
                    lblCrop.Text = "1";
                    //saveResizedImage(bm, outputTo);
                }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
            }
        }
    }
}
