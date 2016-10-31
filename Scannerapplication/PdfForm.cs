using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace Scannerapplication
{
    public partial class PdfForm : Form
    {
        string dob;
        public PdfForm()
        {
            InitializeComponent();
        }
        public void crateFolder(string path)
        {
            //string path = @"C:\Scanning\Registration"; // or whatever  
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //DirectoryInfo directories = new DirectoryInfo(textBox1.Text);
            //DirectoryInfo[] folderList = directories.GetDirectories();
            //var fol = folderList[0].Parent;
            //var fol1 = folderList[0].Parent.Parent;
            //string root = @"C:\Merge\" + fol1 + "";
            //string subdir = @"C:\Merge\" + fol1 + "\\" + fol + "";

            //if (!Directory.Exists(root))
            //{
            //    Directory.CreateDirectory(root);
            //}

            //if (!Directory.Exists(subdir))
            //{
            //    Directory.CreateDirectory(subdir);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regPath = @"C:\Scanning\Registration";
            crateFolder(regPath);
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
                    //System.IO.File.Move(sourceFile, destinationFileReg);
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

        public void copyRegistration()
        {
            pic_scan.Image.Dispose();
            pbNID.Image.Dispose();
            string destinationFileReg = "";
            destinationFileReg = @"C:\Scanning\Registration\" + txtMSIDN.Text + ".jpg";
            System.IO.File.Move(lblRegPath.Text, destinationFileReg);
        }

        private void btn_Merge_Click(object sender, EventArgs e)
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
        public void pdfToImage()
        {
            string pdfImagePath = @"C:\Scanning\PdfToImage";
            crateFolder(pdfImagePath);
            try
            {
                string abc = @"" + textBox2.Text + "\\" + txtMSIDN.Text + ".pdf";
                using (var document = PdfiumViewer.PdfDocument.Load(abc))
                {
                    Bitmap bitmap = (Bitmap)document.Render(0, 300, 300, true);
                    bitmap.Save(@"C:\Scanning\PdfToImage\" + txtMSIDN.Text + ".jpg", ImageFormat.Jpeg);

                    string sourceFile = "";
                    sourceFile = @"C:\Scanning\PdfToImage\" + txtMSIDN.Text + ".jpg";
                    lblNIDPath.Text = sourceFile;
                    //System.IO.File.Move(sourceFile, destinationFileNid);
                    pbNID.Image = Image.FromFile(sourceFile);
                    pbNID.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        public void clear()
        {
            pic_scan.Image = null;
            pbNID.Image = null;
            txtMSIDN.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string path1 = lblRegPath.Text;
                string path2 = lblNIDPath.Text;
                MergeTwoImages(path1, path2);
                copyRegistration();
                clear();
                MessageBox.Show("Images merge successfully!");

                txtMSIDN.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("Please browse the file destination!");
            }
        }
        public void MergeTwoImages(string path1, string path2)
        {
            //var imageName = db.get_ImageName().FirstOrDefault();
            //var path1 = System.IO.Path.Combine(Application.ExecutablePath, @"D:\Registration\Resize\" + txtMSIDN.Text+ ".jpg");
            //var path2 = System.IO.Path.Combine(Application.ExecutablePath, @"D:\NID\Resize\" + txtMSIDN.Text + ".jpg");
            //var path3 = System.IO.Path.Combine(Application.ExecutablePath, @"D:\Merge\" + txtMSIDN.Text + ".jpg");
            var path3 = System.IO.Path.Combine(Application.ExecutablePath, @"C:\Scanning\Merge\" + txtMSIDN.Text + ".jpg");
            String jpg1 = path1;
            String jpg2 = path2;
            String jpg3 = path3;
            Image img1 = Image.FromFile(jpg1);
            Image img2 = Image.FromFile(jpg2);

            int width = Math.Max(img1.Width, img2.Width);
            int height = img1.Height + img2.Height; 
            //int width = img1.Width + img2.Width;
            //int height = Math.Max(img1.Height, img2.Height);
            Bitmap img3 = new Bitmap(width / 2, height / 2);
            Graphics g = Graphics.FromImage(img3);
            g.Clear(Color.White);
            int offset = 0;
            g.DrawImage(img1, new System.Drawing.Rectangle(offset, 0, img1.Width / 2, img1.Height / 2));
            g.DrawImage(img2, new System.Drawing.Rectangle(0,img1.Height / 2, img2.Width / 2, img2.Height / 2));
            g.Dispose();
            img1.Dispose();
            img2.Dispose();
            img3.SetResolution(18, 18);
            img3.Save(jpg3, System.Drawing.Imaging.ImageFormat.Jpeg);
            img3.Dispose();
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMSIDN_Validated(object sender, EventArgs e)
        {
            if (txtMSIDN.Text.Length < 11)
            {
                MessageBox.Show("Please provide 11 digit MSIDN no!");
                txtMSIDN.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        public Image PictureBoxZoom(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void btnAutoQc_Click(object sender, EventArgs e)
        {
            string[] array = Directory.GetFiles(textBox1.Text);

            DirectoryInfo di = new DirectoryInfo(textBox1.Text);
            FileSystemInfo[] files = di.GetFileSystemInfos();
            var orderedFiles = files.OrderBy(f => f.CreationTime);
            lblNIDPath.Text=array[3];
            extractNID();
        }

        private void extractNID()
        {
            string ImagePath = lblNIDPath.Text;
            string StoreTextFilePath = @"E:\ScanningImage\txtFolder\SampleText.txt";
            ReadTextFromImage(ImagePath, StoreTextFilePath);

            string[] lines = System.IO.File.ReadAllLines(@"E:\ScanningImage\txtFolder\SampleText.txt");

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

        public void ReadTextFromImage(String ImagePath, String StoreTextFilePath)
        {
            try
            {
                MODI.Document ModiObj = new MODI.Document();
                ModiObj.Create(ImagePath);
                ModiObj.OCR(MODI.MiLANGUAGES.miLANG_ENGLISH,true,true);
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

    }
}
