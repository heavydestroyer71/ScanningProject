using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Scannerapplication
{
    public partial class renameForm : Form
    {
        private string _img_extentions = ConfigurationManager.AppSettings["img_extentions"];
        HashSet<string> _allowedExtensions;
        public renameForm()
        {
            InitializeComponent();
            //LoadDefault();
        }
        private void LoadDefault()
        {
            string[] img_ext_list = this._img_extentions.Split(',').ToArray();
            this._allowedExtensions = new HashSet<string>(img_ext_list, StringComparer.OrdinalIgnoreCase);
        }
        public void renameImage()
        {
            //DirectoryInfo dirInfo = new DirectoryInfo(textBox1.Text);
            //List<FileInfo> files = Array.FindAll(dirInfo.GetFiles(), f => this._allowedExtensions.Contains(f.Extension)).OrderBy(a => a.CreationTime).ToList();
            string[] array = Directory.GetFiles(textBox1.Text, "*.jpg");
            //array = array.Where(m => m != m.Contains('Thumbs')).ToArray();
            int i = 0;
            foreach (string name in array)
            {
                if (name.Contains("Thumbs.db"))
                {
                    MessageBox.Show("Please remove Thumbs.db");
                }
                else
                {
                    string result;
                    result = Path.GetFileName(array[i]);
                    char[] c = new char[] { ' ', '(', ')' };
                    string[] s = result.Split(c);
                    if (s.Length == 4)
                    {
                        string num = s[2];
                        string newName = s[0] + "_" + num.PadLeft(3, '0') + s[3];

                        string FolderName = Path.GetFileName(textBox1.Text);
                        string path = @"C:\Scanning\Rename\" + FolderName;
                        crateFolder(path);
                        string tranFileName = Path.Combine(path, newName);
                        if (File.Exists(tranFileName))
                        {
                            System.IO.File.Delete(tranFileName);
                        }
                        System.IO.File.Copy(array[i], tranFileName);
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Please check the image name formation");
                        return;
                    }
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                renameImage();
                MessageBox.Show(@"Rename Complete.And the rename file locate in C:\Scanning\Rename folder");
                openFolder();
            }
            else
            {
                MessageBox.Show(@"Please browse folder path!");
            }
        }

        public void openFolder()
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = @"C:\Scanning\Rename",
                UseShellExecute = true,
                Verb = "open"
            });
        }
        public void crateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
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

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
