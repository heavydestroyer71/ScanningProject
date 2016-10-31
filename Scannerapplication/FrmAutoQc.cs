using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scannerapplication
{
    public partial class FrmAutoQc : Form
    {
        public FrmAutoQc()
        {
            InitializeComponent();
        }

        private void btnAutoQc_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFolPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
