using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Scannerapplication
{
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            //lblUser.Text = user;
            InitializeComponent();
            lblUser.Text = frmLogin.SetValueForUserId;
        }

        private void mergeTwoImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMerge fm = new FrmMerge();
            fm.TopLevel = false;
            fm.MdiParent = this;
            fm.WindowState = FormWindowState.Maximized;
            fm.Show();
        }

        private void mergeImageAndPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfForm fmPdf = new PdfForm();
            fmPdf.TopLevel = false;
            fmPdf.MdiParent = this;
            fmPdf.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            renameForm reFrm = new renameForm();
            reFrm.TopLevel = false;
            reFrm.MdiParent = this;
            reFrm.Show();
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {
            Assembly a = Assembly.GetExecutingAssembly();

            label2.Text =a.GetName().Version.ToString();
            if(lblUser.Text!="admin")
            {
                toolStripMenuItem2.Visible = false;
                toolStripMenuItem4.Visible = false;
            }
            else
            {
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem4.Visible = true;
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UserForm userFrm = new UserForm();
            userFrm.TopLevel = false;
            userFrm.MdiParent = this;
            userFrm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmReport reportFrm = new frmReport();
            reportFrm.TopLevel = false;
            reportFrm.MdiParent = this;
            reportFrm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ReportDetails reportFrm = new ReportDetails();
            reportFrm.TopLevel = false;
            reportFrm.MdiParent = this;
            reportFrm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmMerge frmMerge = new FrmMerge();
            frmMerge.Show();
        }

    }
}
