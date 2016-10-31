using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WIATest;
using System.IO;
using Scannerapplication.DB;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Scannerapplication
{
    public partial class Form1 : Form
    {
        #region Private members
        private int _ZoomFactor;
        private Color _BackColor;
        public DialogResult msg;
        //public DialogResult msg=DialogResult.No;
        #endregion // Private members

        #region variables

        #endregion

        ImageDbEntities db = new ImageDbEntities();

        int cropX, cropY, cropWidth, cropHeight;
        int cropRegX, cropRegY, cropRegWidth, cropRegHeight;
        public Form1()
        {

            QCReason();
            InitializeComponent();
            lblUser.Text = frmLogin.SetValueForUserId;

            _ZoomFactor = trbZoomFactor.Value;
            _BackColor = pic_scan.BackColor;

            pic_scan.SizeMode = PictureBoxSizeMode.CenterImage;
            picZoom.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btn_scan_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> devices = WIAScanner.GetDevices();

                foreach (string device in devices)
                {
                    lbDevices.Items.Add(device);
                }
                if (lbDevices.Items.Count == 0)
                {
                    MessageBox.Show("You do not have any WIA devices.");
                    this.Close();
                }
                else
                {
                    lbDevices.SelectedIndex = 0;
                }
                List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
                foreach (Image image in images)
                {
                    pic_scan.Image = image;
                    pic_scan.Show();
                    pic_scan.SizeMode = PictureBoxSizeMode.StretchImage;

                    var scanReg = db.get_mobileNo_RegScanned().FirstOrDefault();
                    image.Save(@"D:\Registration\" + scanReg.MobileNo + ".jpg", ImageFormat.Jpeg);
                    db.ExecuteStoreCommand("Update Scanning set IsRegScanned=1 Where MobileNo=" + scanReg.MobileNo + "").ToString();
                    string imageName = scanReg.MobileNo;
                    string path = @"D:\Registration\Resize\";
                    ReSize(imageName, path);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Home_SizeChanged(object sender, EventArgs e)
        {
            //int pheight = this.Size.Height - 153;
            //pic_scan.Size = new Size(pheight - 150, pheight);
        }
        private void btnNID_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pbNID.Image = new Bitmap(open.OpenFile());
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }
        private void btnCombineImage_Click(object sender, EventArgs e)
        {
            MergeTwoImages();
            //ReSize();
        }
        public void MergeTwoImages(string path1, string path2)
        {   
            string batch = System.IO.Path.GetFileName(textBox1.Text);
            string msisdn = txtMSIDN.Text.Remove(0,1);
            string query = "select * from imageMergesInfo where msisdn=" + msisdn + " and batch='" + batch + "'";
            var p = db.ExecuteStoreQuery<imageMergesInfo>(query).FirstOrDefault();
            var path3 = "";
            //if (p.IsComplete == true)
            //{
            //    msg= MessageBox.Show("Already exist this image!");
            //    if (msg == DialogResult.OK)
            //    {
            //        QcFailDuplicate();
            //    }
            //    return;
            //}
            if (p != null)
            {
                if (p.IsComplete == true)
                {
                    msg = MessageBox.Show("Already exist this image!");
                    if (msg == DialogResult.OK)
                    {
                        QcFailDuplicate();
                    }
                    return;
                }
                else
                {
                    var ch = p.challan;
                    var bx = p.Box;
                    var bt = p.Batch;
                    var com = Path.Combine(ch, bx, bt);
                    string mergePath = @"C:\Scanning\Merge\" + com + "";
                    crateFolder(mergePath);
                    path3 = System.IO.Path.Combine(Application.ExecutablePath, mergePath, txtMSIDN.Text + ".jpg");

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

                    db.ExecuteStoreCommand("update imageMergesInfo set IsComplete=1 where MSISDN=" + msisdn + "");
                }
            }
            else
            {
                string qcpath = textBox1.Text.Remove(0, 3);
                string qcpathFull = Path.Combine(@"C:\Scanning\Merge\QC",qcpath);
                DialogResult msg=MessageBox.Show("MSISDN Not Found!","Merges Info",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (msg == DialogResult.No)
                {
                    crateFolder(qcpathFull);
                    path3 = System.IO.Path.Combine(Application.ExecutablePath, qcpathFull, txtMSIDN.Text + ".jpg");

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
                    string source_file_name = txtMSIDN.Text + ".jpg";
                    var find = db.SEC_USERS.Where(m => m.LOGIN_ID == lblUser.Text).Select(m => m.USER_NO).SingleOrDefault();
                    var insert = "insert into mergeImageDetails values(" + find + ",'null','null','" + txtMSIDN.Text.Remove(0, 1) + "','" + source_file_name + "','" + path3 + "','" + null + "')";
                    db.ExecuteStoreCommand(insert);

                    img3.Dispose();
                    
                }
                else
                {
                    txtMSIDN.Text = "";
                }
                //db.ExecuteStoreCommand("update mergeImageDetails set IsComplete=0");
            }
            //var path3 = System.IO.Path.Combine(Application.ExecutablePath, @"C:\Scanning\Merge\" + txtMSIDN.Text + ".jpg");
            
        }
        public void MergeTwoImages()
        {
            var imageName = db.get_ImageName().FirstOrDefault();
            var path1 = System.IO.Path.Combine(Application.ExecutablePath, @"D:\Registration\Resize\" + imageName.MobileNo + ".jpg");
            var path2 = System.IO.Path.Combine(Application.ExecutablePath, @"D:\NID\Resize\" + imageName.MobileNo + ".jpg");
            var path3 = System.IO.Path.Combine(Application.ExecutablePath, @"D:\Merge\" + imageName.MobileNo + ".jpg");
            String jpg1 = path1;
            String jpg2 = path2;
            String jpg3 = path3;

            Image img1 = Image.FromFile(jpg1);
            Image img2 = Image.FromFile(jpg2);

            int width = img1.Width + img2.Width;
            int height = Math.Max(img1.Height, img2.Height);

            Bitmap img3 = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(img3);

            g.Clear(Color.Black);
            g.DrawImage(img1, new Point(0, 0));
            g.DrawImage(img2, new Point(img1.Width, 0));

            g.Dispose();
            img1.Dispose();
            img2.Dispose();

            img3.Save(jpg3, System.Drawing.Imaging.ImageFormat.Jpeg);
            img3.Dispose();
        }
        public void ReSizeReg(string imgPath)
        {
            string fol = @"C:\Scanning\Registration\Resize";
            crateFolder(fol);
            using (var image = Image.FromFile(imgPath))
            using (var newImage = ScaleImage(image, 870, 1120))
            {
                newImage.Save(@"C:\Scanning\Registration\Resize\" + lblReReg.Text, ImageFormat.Jpeg);
            }
        }
        public void ReSizeNid(string imgPath)
        {
            string fol = @"C:\Scanning\NID\Resize";
            crateFolder(fol);
            using (var image = Image.FromFile(imgPath))
            using (var newImage = ScaleImage(image, 870, 1120))
            {
                newImage.Save(@"C:\Scanning\NID\Resize\" + lblReNID.Text, ImageFormat.Jpeg);
            }
        }
        public void ReSize(string imageName, string path)
        {
            using (var image = Image.FromFile(@"D:\Registration\" + imageName + ""))
            using (var newImage = ScaleImage(image, 1024, 1224))
            {
                newImage.Save(path + imageName);
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
        private void btnNIDScan_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> devices = WIAScanner.GetDevices();

                foreach (string device in devices)
                {
                    lbDevices.Items.Add(device);
                }
                if (lbDevices.Items.Count == 0)
                {
                    MessageBox.Show("You do not have any WIA devices.");
                    this.Close();
                }
                else
                {
                    lbDevices.SelectedIndex = 0;
                }
                List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
                foreach (Image image in images)
                {
                    pic_scan.Image = image;
                    pic_scan.Show();
                    pic_scan.SizeMode = PictureBoxSizeMode.StretchImage;

                    var scanNID = db.get_mobileNo_NID().FirstOrDefault();
                    image.Save(@"D:\NID\" + scanNID.MobileNo + ".jpg", ImageFormat.Jpeg);
                    db.ExecuteStoreCommand("Update Scanning set IsNIDScanned=1 Where MobileNo=" + scanNID.MobileNo + "").ToString();
                    string imageName = scanNID.MobileNo;
                    string path = @"D:\NID\Resize\";
                    ReSize(imageName, path);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnRegNID_Click(object sender, EventArgs e)
        {
            btn_scan_Click(sender, e);
            btnNIDScan_Click(sender, e);
        }
        private void btnMerge_Click(object sender, EventArgs e)
        {
            MergeTwoImages("", "");
            //ReSize();
        }
        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string[] array = Directory.GetFiles(textBox1.Text);
                string result;
                if (array.Length != 0)
                {
                    result = Path.GetFileName(array[0]);
                    string sourceFile = "";
                    string destinationFileReg = "";
                    sourceFile = array[0];
                    destinationFileReg = @"C:\Scanning\Registration\" + result + "";
                    lblRegPath.Text = sourceFile;
                    pic_scan.Image = Image.FromFile(sourceFile);
                    pic_scan.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Folder is empty!");
                }
            }
            else
            {
                MessageBox.Show("Please browse the file destination!");
            }
        }
        public void pdfToImage()
        {
            try
            {
                using (var document = PdfiumViewer.PdfDocument.Load(@"C:\Scanning\PdfNID\" + txtMSIDN.Text + ".pdf"))
                {
                    Bitmap bitmap = (Bitmap)document.Render(0, 300, 300, true);
                    bitmap.Save(@"C:\Scanning\PdfToImage\" + txtMSIDN.Text + ".jpg", ImageFormat.Jpeg);

                    string sourceFile = "";
                    sourceFile = @"C:\Scanning\PdfToImage\" + txtMSIDN.Text + ".jpg";
                    lblNIDPath.Text = sourceFile;
                    pbNID.Image = Image.FromFile(sourceFile);
                    pbNID.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string regPath = @"C:\Scanning\Registration";
            string nidPath = @"C:\Scanning\NID";
            crateFolder(regPath);
            crateFolder(nidPath);
            if (textBox1.Text != "")
            {
                string[] array = Directory.GetFiles(textBox1.Text, "*.*",SearchOption.AllDirectories);
                string result;
                if (array.Length != 0)
                {
                    result = Path.GetFileName(array[0]);
                    string sourceFile = "";
                    string destinationFileReg = "";
                    string destinationFileNid = "";
                    sourceFile = array[0];
                    destinationFileReg = @"C:\Scanning\Registration\" + result + "";
                    lblReReg.Text = result;
                    ReSizeReg(sourceFile);
                    lblRegPath.Text = sourceFile;
                    pic_scan.Image = Image.FromFile(sourceFile);
                    pic_scan.SizeMode = PictureBoxSizeMode.StretchImage;
                    sourceFile = array[1];
                    result = Path.GetFileName(array[1]);
                    destinationFileNid = @"C:\Scanning\NID\" + result + "";
                    lblReNID.Text = result;
                    ReSizeNid(sourceFile);
                    lblNIDPath.Text = sourceFile;
                    pbNID.Image = Image.FromFile(sourceFile);
                    pbNID.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else
                {
                    MessageBox.Show("Folder is empty!");
                }
            }
            else
            {
                MessageBox.Show("Please browse the file destination!");
            }
        }
        public void ShowImage(int fileIndex1, int fileIndex2)
        {
            string[] array = Directory.GetFiles(textBox1.Text);
            string sourceFile = "";
            sourceFile = array[fileIndex1];
            lblRegPath.Text = array[fileIndex1];
            pic_scan.Image = Image.FromFile(sourceFile);
            pic_scan.SizeMode = PictureBoxSizeMode.StretchImage;
            sourceFile = array[fileIndex2];
            lblNIDPath.Text = array[fileIndex2];
            pbNID.Image = Image.FromFile(sourceFile);
            pbNID.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void copyImage()
        {
            pic_scan.Image.Dispose();
            pbNID.Image.Dispose();
            string destinationFileReg = "";
            string destinationFileNid = "";
            destinationFileReg = @"C:\Scanning\Registration\" + txtMSIDN.Text + ".jpg";
            System.IO.File.Move(lblRegPath.Text, destinationFileReg);
            destinationFileNid = @"C:\Scanning\NID\" + txtMSIDN.Text + ".jpg";
            System.IO.File.Move(lblNIDPath.Text, destinationFileNid);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            extractNID();
            var info =db.get_ClientInfo("2699220320302").ToList();
            
            if (info.Count>0)
            {
                if (info.Count > 1)
                {
                    MessageBox.Show("Multiple NID available.Please select MSISDN from dropdown!!");
                    foreach (var value in info)
                    {
                        comboBox1.Items.Add(value.MSISDN);
                    }
                }
                else
                {
                    MessageBox.Show("QC Pass!");
                }
                comboBox1.Focus();
            }
            else
            {
                MessageBox.Show("QC Fail!");
            }
            comboBox1.Focus();
        }
        private void btn_Merge_Click(object sender, EventArgs e)
        {
            try
            {
                string path1 = @"C:\Scanning\Registration\Resize\" + lblReReg.Text;
                string path2;
                if (txtMSIDN.Text.Length < 11)
                {
                    MessageBox.Show("Please provide MSIDN no less than 11 digit!");
                    txtMSIDN.Focus();
                    return;
                }
                if (lblCrop.Text == "1")
                {
                    path2 = @"C:\Scanning\CropImage\CropImage.jpg";
                }
                else
                {
                    path2 = @"C:\Scanning\NID\Resize\" + lblReNID.Text;
                }
                if (path1 != "lbl Reg" && path2 != "lbl NID")
                {
                    MergeTwoImages(path1, path2);
                    if (txtMSIDN.Text != "" && msg!=DialogResult.OK)
                    {
                        copyImage();
                        pic_scan.Image = null;
                        pbNID.Image = null;
                        MessageBox.Show("Images merge successfully!");
                        button1_Click(sender, e);
                        txtMSIDN.Text = "";

                        string[] count = Directory.GetFiles(@"C:\Scanning\Merge\");
                        txtCompleteImages.Text = count.Length.ToString();
                        txtMSIDN.Focus();
                    }
                    else
                    {
                        txtMSIDN.Text = "";
                        txtMSIDN.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please browse the file destination!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void clear()
        {
            pic_scan.Image = null;
            pbNID.Image = null;
            txtMSIDN.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        public void crateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public void showImagesInPictureBox()
        {
            string ImagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), textBox1.Text);
        }
        private void btnConvertNID_Click(object sender, EventArgs e)
        {
            if (txtMSIDN.Text != "")
            {
                pdfToImage();
            }
            else
            {
                MessageBox.Show("Please provide MSIDN no!");
            }
        }
        public void copyRegistration()
        {
            pic_scan.Image.Dispose();
            pbNID.Image.Dispose();
            string destinationFileReg = "";
            destinationFileReg = @"C:\Scanning\Registration\" + txtMSIDN.Text + ".jpg";
            System.IO.File.Move(lblRegPath.Text, destinationFileReg);
        }
        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnImagePdfMerge_Click(object sender, EventArgs e)
        {
            try
            {
                string path1 = lblRegPath.Text;
                string path2 = lblNIDPath.Text;
                MergeTwoImages(path1, path2);
                copyRegistration();
                clear();
                MessageBox.Show("Images merge successfully!");
            }
            catch (Exception)
            {

                MessageBox.Show("Please browse the file destination!");
            }
        }
        //private void txtMSIDN_Validated(object sender, EventArgs e)
        //{
        //    if (txtMSIDN.Text.Length < 11)
        //    {
        //        MessageBox.Show("Please provide MSIDN no less than 11 digit!");
        //        txtMSIDN.Focus();
        //    }
        //}
        public void renameImage()
        {
            string[] array = Directory.GetFiles(textBox1.Text);
            int i = 0;
            foreach (string name in array)
            {
                string result;
                result = Path.GetFileName(array[i]);
                char[] c = new char[] { ' ', '(', ')' };
                string[] s = result.Split(c);
                string num = s[2];
                string newName = s[0] + "_" + num.PadLeft(3, '0') + s[3];

                string tranFileName = @"C:\Scanning\Rename\" + newName + "";
                if (File.Exists(tranFileName))
                {
                    System.IO.File.Delete(tranFileName);
                }
                System.IO.File.Copy(array[i], tranFileName);
                i++;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            renameImage();
        }
        private string ConvertImage(Bitmap sBit)
        {
            MemoryStream imageStream = new MemoryStream();
            sBit.Save(imageStream, ImageFormat.Jpeg);

            return Convert.ToBase64String(imageStream.ToArray());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            saveCropImage();
            MessageBox.Show("NID crop successfully!");
        }
        public void ReadTextFromImage(String ImagePath, String StoreTextFilePath)
        {
            try
            {
                MODI.Document ModiObj = new MODI.Document();
                ModiObj.Create(ImagePath);
                ModiObj.OCR(MODI.MiLANGUAGES.miLANG_ENGLISH, true, true);
                MODI.Image ModiImageObj = (MODI.Image)ModiObj.Images[0];
                FileStream CreateFileObj = new FileStream(StoreTextFilePath, FileMode.Create);
                StreamWriter WriteFileObj = new StreamWriter(CreateFileObj);
                WriteFileObj.Write(ModiImageObj.Layout.Text);
                WriteFileObj.Close();

                ModiObj.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            extractNID();
        }

        private void extractNID()
        {
            string ImagePath = lblNIDPath.Text;
            string StoreTextFilePath = @"C:\Scanning\PdfToImage\SampleText.txt";
            ReadTextFromImage(ImagePath, StoreTextFilePath);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Scanning\PdfToImage\SampleText.txt");

            foreach (string value in lines)
            {
                string nid = Regex.Match(value, @"\d{17}|\d{13}").Value;
                string dobYear = Regex.Match(value, @"1[9][0-9][0-9]").Value;
                if (nid != "")
                {
                    lblVettingNID.Text = nid;
                }
            }
        }
        public void QCReason()
        {
        }
        public void saveCropImage()
        {
            crateFolder(@"C:\Scanning\CropImage");
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
                string outputTo = @"C:\Scanning\CropImage\CropImage.jpg";
                bm.Save(outputTo);
                lblCrop.Text = "1";
                //saveResizedImage(bm, outputTo);
            }
        }
        #region regan vai code
        private static void resize(string path)
        {
            Image imgOriginal = Bitmap.FromFile(path);
            int width = 1000;
            int height = (imgOriginal.Height * width) / imgOriginal.Width;
            Image imgnew = new Bitmap((int)width, (int)height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(imgnew);
            g.DrawImage(imgOriginal, new Point[] { new Point(0, 0), new Point(width, 0), new Point(0, height) },
                new Rectangle(0, 0, imgOriginal.Width, imgOriginal.Height), GraphicsUnit.Pixel);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            string outputTo = @"C:\Scanning\PdfToImage\test.jpg";
            saveResizedImage(imgnew, outputTo);
        }

        private static void saveResizedImage(Image imgnew, string outputFolderPath)
        {
            using (Bitmap bitmap = (Bitmap)imgnew)
            {
                using (Bitmap newBitmap = new Bitmap(bitmap))
                {
                    newBitmap.SetResolution(300, 300);
                    newBitmap.Save(outputFolderPath, ImageFormat.Jpeg);
                }
            }
        }

        public static System.Drawing.Bitmap CombineBitmap(string[] files)
        {

            //string path = @"E:\Max Pro\Recall\Scanning\2016-09-10\SCAN_0001.jpg";
            //string path2 = @"E:\Max Pro\Recall\Scanning\2016-09-10\SCAN_0002.jpg";
            //string path3 = @"E:\Max Pro\Recall\Scanning\2016-09-10\SCAN_2000005.jpg";

            //files = new string[3]{path,path2,path3};
            //read all images into memory
            List<System.Drawing.Bitmap> images = new List<System.Drawing.Bitmap>();
            System.Drawing.Bitmap finalImage = null;

            try
            {
                int width = 0;
                int height = 0;

                foreach (string image in files)
                {
                    //create a Bitmap from the file and add it to the list
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);

                    //update the size of the final bitmap
                    width = bitmap.Width > width ? bitmap.Width : width;
                    height += bitmap.Height;

                    images.Add(bitmap);
                }

                //create a bitmap to hold the combined image
                finalImage = new System.Drawing.Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage))
                {
                    //go through each image and draw it on the final image
                    int offset = 0;
                    foreach (System.Drawing.Bitmap image in images)
                    {
                        g.DrawImage(image,
                          new System.Drawing.Rectangle(0, offset, image.Width, image.Height));
                        offset += image.Height;
                    }


                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                //clean up memory
                foreach (System.Drawing.Bitmap image in images)
                {
                    image.Dispose();
                }
            }
        }
        public void zoomIn()
        {
            pic_scan.Top = (int)(pic_scan.Top - (pic_scan.Height * 0.025));
            pic_scan.Left = (int)(pic_scan.Left - (pic_scan.Width * 0.025));
            pic_scan.Height = (int)(pic_scan.Height + (pic_scan.Height * 0.05));
            pic_scan.Width = (int)(pic_scan.Width + (pic_scan.Width * 0.05));
        }

        public void zoomOut()
        {
            pic_scan.Top = (int)(pic_scan.Top + (pic_scan.Height * 0.025));
            pic_scan.Left = (int)(pic_scan.Left + (pic_scan.Width * 0.025));
            pic_scan.Height = (int)(pic_scan.Height - (pic_scan.Height * 0.05));
            pic_scan.Width = (int)(pic_scan.Width - (pic_scan.Width * 0.05));
        }
        private Image imgOriginal;
        public Image PictureBoxZoom(Image img, Size size)
        {
            //private Image imgOriginal;
            imgOriginal = Image.FromFile(lblRegPath.Text);
            Bitmap bm = new Bitmap(imgOriginal, Convert.ToInt32(imgOriginal.Width * size.Width), Convert.ToInt32(imgOriginal.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            //grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }
        #endregion

        private static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlControl.Width = Form1.ActiveForm.Width * 17 / 100;
            pnlRegPic.Width = Form1.ActiveForm.Width * 30 / 100;
            pnlNIDPic.Width = Form1.ActiveForm.Width * 30 / 100;
            pnlCropPic.Width = Form1.ActiveForm.Width * 23 / 100;
            pic_scan.Width = pnlRegPic.Width;
            pic_scan.Height = pnlRegPic.Height;
            pbNID.Width = pnlNIDPic.Width;
            pbNID.Height = pnlNIDPic.Height;
            picCrop.Width = pnlCropPic.Width;
            picCrop.Height = pnlCropPic.Height;
            pnlControl.BorderStyle = BorderStyle.FixedSingle;
            pnlRegPic.BorderStyle = BorderStyle.FixedSingle;
            pnlNIDPic.BorderStyle = BorderStyle.FixedSingle;
            pnlCropPic.BorderStyle = BorderStyle.FixedSingle;

            this.pic_scan.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbNID.SizeMode = PictureBoxSizeMode.AutoSize;


            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trbZoomFactor.Value > 0)
            {
                pic_scan.Image = null;
                pic_scan.Image = PictureBoxZoom(imgOriginal, new Size(trbZoomFactor.Value, trbZoomFactor.Value));
            }
        }
        private void ConvertCoordinates(PictureBox pic, out int X0, out int Y0, int x, int y)
        {
            int pic_hgt = pic.ClientSize.Height;
            int pic_wid = pic.ClientSize.Width;
            int img_hgt = pic.Image.Height;
            int img_wid = pic.Image.Width;

            X0 = x;
            Y0 = y;
            switch (pic.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                case PictureBoxSizeMode.Normal:
                    break;
                case PictureBoxSizeMode.CenterImage:
                    X0 = x - (pic_wid - img_wid) / 2;
                    Y0 = y - (pic_hgt - img_hgt) / 2;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    X0 = (int)(img_wid * x / (float)pic_wid);
                    Y0 = (int)(img_hgt * y / (float)pic_hgt);
                    break;
                case PictureBoxSizeMode.Zoom:
                    float pic_aspect = pic_wid / (float)pic_hgt;
                    float img_aspect = img_wid / (float)img_hgt;
                    if (pic_aspect > img_aspect)
                    {
                        Y0 = (int)(img_hgt * y / (float)pic_hgt);
                        float scaled_width = img_wid * pic_hgt / img_hgt;
                        float dx = (pic_wid - scaled_width) / 2;
                        X0 = (int)((x - dx) * img_hgt / (float)pic_hgt);
                    }
                    else
                    {
                        X0 = (int)(img_wid * x / (float)pic_wid);
                        float scaled_height = img_hgt * pic_wid / img_wid;
                        float dy = (pic_hgt - scaled_height) / 2;
                        Y0 = (int)((y - dy) * img_wid / pic_wid);
                    }
                    break;
            }
        }

        //For Cropping
        public class Size
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Size(int p1, int p2)
            {
                this.Width = p1;
                this.Height = p2;
            }
        }

        public static System.Drawing.Image cropResizeImage(System.Drawing.Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            System.Drawing.Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.SmoothingMode = SmoothingMode.AntiAlias;
                graphicsHandle.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        //New Cropping 

        class ImageUtilities
        { 
            public Image SetImageOpacity(Image image, float opacity)
            {
                try
                {
                    //create a Bitmap the size of the image provided  
                    Bitmap bmp = new Bitmap(image.Width, image.Height);

                    //create a graphics object from the image  
                    Graphics gfx = Graphics.FromImage(bmp);

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = opacity;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                    gfx.Dispose();
                    return bmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }

            public static Image Resize(Image imgToResize, Size size)
            {
                int sourceWidth = imgToResize.Width;
                int sourceHeight = imgToResize.Height;

                float nPercent = 0;
                float nPercentW = 0;
                float nPercentH = 0;

                nPercentW = ((float)size.Width / (float)sourceWidth);
                nPercentH = ((float)size.Height / (float)sourceHeight);

                if (nPercentH < nPercentW)
                    nPercent = nPercentH;
                else
                    nPercent = nPercentW;

                int destWidth = (int)(sourceWidth * nPercent);
                int destHeight = (int)(sourceHeight * nPercent);

                Bitmap b = new Bitmap(destWidth, destHeight);
                Graphics g = Graphics.FromImage((Image)b);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
                g.Dispose();

                return (Image)b;
            }
            public static Image Crop(Image img, Rectangle cropArea)
            {
                Bitmap bmpImage = new Bitmap(img);
                Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
                return (Image)(bmpCrop);
            }

            public static Bitmap GrayscaleConvert(Bitmap original)
            {
                //create a blank bitmap the same size as original
                Bitmap newBitmap = new Bitmap(original.Width, original.Height);

                //get a graphics object from the new image
                Graphics g = Graphics.FromImage(newBitmap);

                //create the grayscale ColorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(new float[][] 
            {
             new float[] {.3f, .3f, .3f, 0, 0},
             new float[] {.59f, .59f, .59f, 0, 0},
             new float[] {.11f, .11f, .11f, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
            });

                //create some image attributes
                ImageAttributes attributes = new ImageAttributes();

                //set the color matrix attribute
                attributes.SetColorMatrix(colorMatrix);

                //draw the original image on the new image
                //using the grayscale color matrix
                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

                //dispose the Graphics object
                g.Dispose();
                return newBitmap;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                txtMSIDN.Text = string.Empty;
            }
            else
            {
                txtMSIDN.Text = comboBox1.SelectedItem.ToString();
            }
        }

        //Zooming 

        private void trbZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            _ZoomFactor = trbZoomFactor.Value;
            lblZoomFactor.Text = string.Format("x{0}", _ZoomFactor);
        }

        private void pic_scan_MouseMove(object sender, MouseEventArgs e)
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

        private void UpdateZoomedImage(MouseEventArgs e)
        {
            int zoomWidth = picZoom.Width / _ZoomFactor;
            int zoomHeight = picZoom.Height / _ZoomFactor;
            int halfWidth = zoomWidth / 2;
            int halfHeight = zoomHeight / 2;
            Bitmap tempBitmap = new Bitmap(zoomWidth, zoomHeight, PixelFormat.Format24bppRgb);
            Graphics bmGraphics = Graphics.FromImage(tempBitmap);
            bmGraphics.Clear(_BackColor);
            bmGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            bmGraphics.DrawImage(pic_scan.Image,
                                 new Rectangle(0, 0, zoomWidth, zoomHeight),
                                 new Rectangle(e.X - halfWidth, e.Y - halfHeight, zoomWidth, zoomHeight),
                                 GraphicsUnit.Pixel);

            picZoom.Image = tempBitmap;
            bmGraphics.DrawLine(Pens.Black, halfWidth + 1, halfHeight - 4, halfWidth + 1, halfHeight - 1);
            bmGraphics.DrawLine(Pens.Black, halfWidth + 1, halfHeight + 6, halfWidth + 1, halfHeight + 3);
            bmGraphics.DrawLine(Pens.Black, halfWidth - 4, halfHeight + 1, halfWidth - 1, halfHeight + 1);
            bmGraphics.DrawLine(Pens.Black, halfWidth + 6, halfHeight + 1, halfWidth + 3, halfHeight + 1);
            bmGraphics.Dispose();
            picZoom.Refresh();
        }
        private Point _StartPoint;
        private Point _StartPointReg;
        private void pbNID_MouseDown(object sender, MouseEventArgs e)
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

        private void pbNID_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbNID.Image == null)
                return;

            if (e.Button == MouseButtons.Left)
            {
                pbNID.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                //New
                Point changePoint = new Point(e.Location.X - _StartPoint.X,
                                              e.Location.Y - _StartPoint.Y);
                if (cbHorizontalCrop.Checked == true)
                {
                    pnlNIDPic.AutoScrollPosition = new Point(-pnlNIDPic.AutoScrollPosition.X + 1, -pnlNIDPic.AutoScrollPosition.Y);
                }
                else
                {
                    pnlNIDPic.AutoScrollPosition = new Point(-pnlNIDPic.AutoScrollPosition.X + 1, -pnlNIDPic.AutoScrollPosition.Y+2);
                }
            }
            pbNID.Refresh();
        }

        private void pbNID_MouseUp(object sender, MouseEventArgs e)
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
        Pen borderpen = new Pen(Color.Red, 2);
        SolidBrush rectbrush = new SolidBrush(Color.FromArgb(100, Color.White));
        private void pbNID_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            Graphics gfx = e.Graphics;
            gfx.DrawRectangle(borderpen, rect);
            gfx.FillRectangle(rectbrush, rect);
            //gfx.Save();
        }

        public void QcFail()
        {
            string qcpath = textBox1.Text.Remove(0, 3);
            string qcReg = Path.Combine(@"C:\Scanning\QcFail", qcpath);
            string qcNid = Path.Combine(@"C:\Scanning\QcFail", qcpath);

            crateFolder(qcReg);
            crateFolder(qcNid);
            pic_scan.Image.Dispose();
            pbNID.Image.Dispose();
            string destinationFileReg = "";
            string destinationFileNid = "";
            string RegName= System.IO.Path.GetFileName(lblRegPath.Text);
            string NidName = System.IO.Path.GetFileName(lblNIDPath.Text);
            string comReg = System.IO.Path.Combine(qcReg, RegName);
            string comNid = System.IO.Path.Combine(qcNid, NidName);
            destinationFileReg = comReg;
            System.IO.File.Move(lblRegPath.Text, destinationFileReg);
            destinationFileNid = comNid;
            System.IO.File.Move(lblNIDPath.Text, destinationFileNid);
            pic_scan.Image = null;
            pbNID.Image = null;
        }
        public void QcFailDuplicate()
        {
            string qcpath = textBox1.Text.Remove(0, 3);
            string qcReg = Path.Combine(@"C:\Scanning\QcFail\Duplicate", qcpath);
            string qcNid = Path.Combine(@"C:\Scanning\QcFail\Duplicate", qcpath);

            crateFolder(qcReg);
            crateFolder(qcNid);
            pic_scan.Image.Dispose();
            pbNID.Image.Dispose();
            string destinationFileReg = "";
            string destinationFileNid = "";
            string RegName = System.IO.Path.GetFileName(lblRegPath.Text);
            string NidName = System.IO.Path.GetFileName(lblNIDPath.Text);
            string comReg = System.IO.Path.Combine(qcReg, RegName);
            string comNid = System.IO.Path.Combine(qcNid, NidName);
            destinationFileReg = comReg;
            System.IO.File.Move(lblRegPath.Text, destinationFileReg);
            destinationFileNid = comNid;
            System.IO.File.Move(lblNIDPath.Text, destinationFileNid);
            pic_scan.Image = null;
            pbNID.Image = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QcFail();
            MessageBox.Show("QC fail images seperate!");
        }
        private void pic_scan_MouseDown(object sender, MouseEventArgs e)
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
            pic_scan.Refresh();
        }

        private void pic_scan_MouseUp(object sender, MouseEventArgs e)
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

        private void pic_scan_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(cropRegX, cropRegY, cropRegWidth, cropRegHeight);
            Graphics gfx = e.Graphics;
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;//here add  System.Drawing.Drawing2D namespace;
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;//here add  System.Drawing.Drawing2D namespace;
            gfx.CompositingQuality = CompositingQuality.HighQuality;//here add  System.Drawing.Drawing2D namespace;
            gfx.DrawRectangle(borderpen, rect);
            gfx.FillRectangle(rectbrush, rect);
        }
    }
}
