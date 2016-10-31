namespace Scannerapplication
{
    partial class PdfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNIDPath = new System.Windows.Forms.Label();
            this.lblRegPath = new System.Windows.Forms.Label();
            this.cbQC = new System.Windows.Forms.CheckBox();
            this.showImages = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMSIDN = new System.Windows.Forms.TextBox();
            this.pnl_capture = new System.Windows.Forms.Panel();
            this.btnAutoQc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.lblMSIDN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnScanMerge = new System.Windows.Forms.Button();
            this.btnRegNID = new System.Windows.Forms.Button();
            this.btnNIDScan = new System.Windows.Forms.Button();
            this.btnCombineImage = new System.Windows.Forms.Button();
            this.btnNID = new System.Windows.Forms.Button();
            this.pbNID = new System.Windows.Forms.PictureBox();
            this.pic_scan = new System.Windows.Forms.PictureBox();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblVettingNID = new System.Windows.Forms.Label();
            this.pnl_capture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.BackColor = System.Drawing.Color.DarkRed;
            this.btnCloseApplication.ForeColor = System.Drawing.Color.White;
            this.btnCloseApplication.Location = new System.Drawing.Point(11, 579);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(158, 30);
            this.btnCloseApplication.TabIndex = 9;
            this.btnCloseApplication.Text = "Close";
            this.btnCloseApplication.UseVisualStyleBackColor = false;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(729, 679);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(112, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(11, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblNIDPath
            // 
            this.lblNIDPath.AutoSize = true;
            this.lblNIDPath.Location = new System.Drawing.Point(12, 679);
            this.lblNIDPath.Name = "lblNIDPath";
            this.lblNIDPath.Size = new System.Drawing.Size(39, 13);
            this.lblNIDPath.TabIndex = 26;
            this.lblNIDPath.Text = "lbl NID";
            this.lblNIDPath.Visible = false;
            // 
            // lblRegPath
            // 
            this.lblRegPath.AutoSize = true;
            this.lblRegPath.Location = new System.Drawing.Point(81, 676);
            this.lblRegPath.Name = "lblRegPath";
            this.lblRegPath.Size = new System.Drawing.Size(40, 13);
            this.lblRegPath.TabIndex = 25;
            this.lblRegPath.Text = "lbl Reg";
            this.lblRegPath.Visible = false;
            // 
            // cbQC
            // 
            this.cbQC.AutoSize = true;
            this.cbQC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbQC.Location = new System.Drawing.Point(810, 685);
            this.cbQC.Name = "cbQC";
            this.cbQC.Size = new System.Drawing.Size(41, 17);
            this.cbQC.TabIndex = 23;
            this.cbQC.Text = "QC";
            this.cbQC.UseVisualStyleBackColor = true;
            this.cbQC.Visible = false;
            // 
            // showImages
            // 
            this.showImages.Location = new System.Drawing.Point(176, 615);
            this.showImages.Name = "showImages";
            this.showImages.Size = new System.Drawing.Size(85, 23);
            this.showImages.TabIndex = 40;
            this.showImages.Text = "Show Images";
            this.showImages.UseVisualStyleBackColor = true;
            this.showImages.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOK.Location = new System.Drawing.Point(12, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(158, 30);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtDOB
            // 
            this.txtDOB.Enabled = false;
            this.txtDOB.Location = new System.Drawing.Point(64, 128);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(106, 20);
            this.txtDOB.TabIndex = 4;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDOB.Location = new System.Drawing.Point(14, 131);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(32, 15);
            this.lblDOB.TabIndex = 20;
            this.lblDOB.Text = "DOB";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(64, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(14, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // txtMSIDN
            // 
            this.txtMSIDN.Location = new System.Drawing.Point(64, 71);
            this.txtMSIDN.Name = "txtMSIDN";
            this.txtMSIDN.Size = new System.Drawing.Size(106, 20);
            this.txtMSIDN.TabIndex = 2;
            // 
            // pnl_capture
            // 
            this.pnl_capture.BackColor = System.Drawing.Color.Transparent;
            this.pnl_capture.Controls.Add(this.lblVettingNID);
            this.pnl_capture.Controls.Add(this.btnAutoQc);
            this.pnl_capture.Controls.Add(this.button5);
            this.pnl_capture.Controls.Add(this.textBox2);
            this.pnl_capture.Controls.Add(this.button4);
            this.pnl_capture.Controls.Add(this.showImages);
            this.pnl_capture.Controls.Add(this.btnCloseApplication);
            this.pnl_capture.Controls.Add(this.button3);
            this.pnl_capture.Controls.Add(this.button2);
            this.pnl_capture.Controls.Add(this.textBox1);
            this.pnl_capture.Controls.Add(this.lblNIDPath);
            this.pnl_capture.Controls.Add(this.lblRegPath);
            this.pnl_capture.Controls.Add(this.btn_Merge);
            this.pnl_capture.Controls.Add(this.cbQC);
            this.pnl_capture.Controls.Add(this.btnOK);
            this.pnl_capture.Controls.Add(this.txtDOB);
            this.pnl_capture.Controls.Add(this.lblDOB);
            this.pnl_capture.Controls.Add(this.txtName);
            this.pnl_capture.Controls.Add(this.lblName);
            this.pnl_capture.Controls.Add(this.txtMSIDN);
            this.pnl_capture.Controls.Add(this.lblMSIDN);
            this.pnl_capture.Controls.Add(this.button1);
            this.pnl_capture.Controls.Add(this.btnMerge);
            this.pnl_capture.Controls.Add(this.btnScanMerge);
            this.pnl_capture.Controls.Add(this.btnRegNID);
            this.pnl_capture.Controls.Add(this.btnNIDScan);
            this.pnl_capture.Controls.Add(this.btnCombineImage);
            this.pnl_capture.Controls.Add(this.btnNID);
            this.pnl_capture.Controls.Add(this.pbNID);
            this.pnl_capture.Controls.Add(this.pic_scan);
            this.pnl_capture.Controls.Add(this.lbDevices);
            this.pnl_capture.Controls.Add(this.btn_scan);
            this.pnl_capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_capture.Location = new System.Drawing.Point(0, 3);
            this.pnl_capture.Name = "pnl_capture";
            this.pnl_capture.Size = new System.Drawing.Size(1162, 712);
            this.pnl_capture.TabIndex = 42;
            // 
            // btnAutoQc
            // 
            this.btnAutoQc.Location = new System.Drawing.Point(15, 305);
            this.btnAutoQc.Name = "btnAutoQc";
            this.btnAutoQc.Size = new System.Drawing.Size(141, 23);
            this.btnAutoQc.TabIndex = 43;
            this.btnAutoQc.Text = "Automatic QC";
            this.btnAutoQc.UseVisualStyleBackColor = true;
            this.btnAutoQc.Click += new System.EventHandler(this.btnAutoQc_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(114, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 20);
            this.button5.TabIndex = 42;
            this.button5.Text = "Browse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(13, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(12, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Merge";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Merge
            // 
            this.btn_Merge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Merge.Location = new System.Drawing.Point(11, 222);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(158, 30);
            this.btn_Merge.TabIndex = 7;
            this.btn_Merge.Text = "Convert Pdf To Image";
            this.btn_Merge.UseVisualStyleBackColor = true;
            this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
            // 
            // lblMSIDN
            // 
            this.lblMSIDN.AutoSize = true;
            this.lblMSIDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSIDN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMSIDN.Location = new System.Drawing.Point(14, 71);
            this.lblMSIDN.Name = "lblMSIDN";
            this.lblMSIDN.Size = new System.Drawing.Size(44, 15);
            this.lblMSIDN.TabIndex = 16;
            this.lblMSIDN.Text = "MSIDN";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(11, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Registration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMerge.Location = new System.Drawing.Point(488, 643);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(134, 30);
            this.btnMerge.TabIndex = 13;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Visible = false;
            // 
            // btnScanMerge
            // 
            this.btnScanMerge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnScanMerge.Location = new System.Drawing.Point(492, 674);
            this.btnScanMerge.Name = "btnScanMerge";
            this.btnScanMerge.Size = new System.Drawing.Size(134, 30);
            this.btnScanMerge.TabIndex = 12;
            this.btnScanMerge.Text = "Both Scan With Merge";
            this.btnScanMerge.UseVisualStyleBackColor = true;
            this.btnScanMerge.Visible = false;
            // 
            // btnRegNID
            // 
            this.btnRegNID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegNID.Location = new System.Drawing.Point(348, 632);
            this.btnRegNID.Name = "btnRegNID";
            this.btnRegNID.Size = new System.Drawing.Size(134, 34);
            this.btnRegNID.TabIndex = 11;
            this.btnRegNID.Text = "Both Scan";
            this.btnRegNID.UseVisualStyleBackColor = true;
            this.btnRegNID.Visible = false;
            // 
            // btnNIDScan
            // 
            this.btnNIDScan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNIDScan.Location = new System.Drawing.Point(352, 672);
            this.btnNIDScan.Name = "btnNIDScan";
            this.btnNIDScan.Size = new System.Drawing.Size(134, 34);
            this.btnNIDScan.TabIndex = 10;
            this.btnNIDScan.Text = "NID Scan";
            this.btnNIDScan.UseVisualStyleBackColor = true;
            this.btnNIDScan.Visible = false;
            // 
            // btnCombineImage
            // 
            this.btnCombineImage.ForeColor = System.Drawing.Color.Black;
            this.btnCombineImage.Location = new System.Drawing.Point(628, 643);
            this.btnCombineImage.Name = "btnCombineImage";
            this.btnCombineImage.Size = new System.Drawing.Size(95, 23);
            this.btnCombineImage.TabIndex = 9;
            this.btnCombineImage.Text = "Combine Image";
            this.btnCombineImage.UseVisualStyleBackColor = true;
            this.btnCombineImage.Visible = false;
            // 
            // btnNID
            // 
            this.btnNID.ForeColor = System.Drawing.Color.Black;
            this.btnNID.Location = new System.Drawing.Point(632, 676);
            this.btnNID.Name = "btnNID";
            this.btnNID.Size = new System.Drawing.Size(75, 26);
            this.btnNID.TabIndex = 8;
            this.btnNID.Text = "Upload";
            this.btnNID.UseVisualStyleBackColor = true;
            this.btnNID.Visible = false;
            // 
            // pbNID
            // 
            this.pbNID.BackColor = System.Drawing.Color.White;
            this.pbNID.Location = new System.Drawing.Point(632, 9);
            this.pbNID.Name = "pbNID";
            this.pbNID.Size = new System.Drawing.Size(450, 600);
            this.pbNID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNID.TabIndex = 7;
            this.pbNID.TabStop = false;
            // 
            // pic_scan
            // 
            this.pic_scan.BackColor = System.Drawing.Color.White;
            this.pic_scan.Location = new System.Drawing.Point(176, 9);
            this.pic_scan.Name = "pic_scan";
            this.pic_scan.Size = new System.Drawing.Size(450, 600);
            this.pic_scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_scan.TabIndex = 6;
            this.pic_scan.TabStop = false;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(729, 643);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(120, 30);
            this.lbDevices.TabIndex = 5;
            this.lbDevices.Visible = false;
            // 
            // btn_scan
            // 
            this.btn_scan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_scan.Location = new System.Drawing.Point(212, 668);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(134, 34);
            this.btn_scan.TabIndex = 4;
            this.btn_scan.Text = "Registration Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1162, 3);
            this.splitter1.TabIndex = 41;
            this.splitter1.TabStop = false;
            // 
            // lblVettingNID
            // 
            this.lblVettingNID.AutoSize = true;
            this.lblVettingNID.Location = new System.Drawing.Point(64, 463);
            this.lblVettingNID.Name = "lblVettingNID";
            this.lblVettingNID.Size = new System.Drawing.Size(35, 13);
            this.lblVettingNID.TabIndex = 44;
            this.lblVettingNID.Text = "label1";
            // 
            // PdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 715);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_capture);
            this.Controls.Add(this.splitter1);
            this.Name = "PdfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Image and One Pdf";
            this.pnl_capture.ResumeLayout(false);
            this.pnl_capture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseApplication;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNIDPath;
        private System.Windows.Forms.Label lblRegPath;
        private System.Windows.Forms.CheckBox cbQC;
        private System.Windows.Forms.Button showImages;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMSIDN;
        private System.Windows.Forms.Panel pnl_capture;
        private System.Windows.Forms.Label lblMSIDN;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnScanMerge;
        private System.Windows.Forms.Button btnRegNID;
        private System.Windows.Forms.Button btnNIDScan;
        private System.Windows.Forms.Button btnCombineImage;
        private System.Windows.Forms.Button btnNID;
        private System.Windows.Forms.PictureBox pbNID;
        private System.Windows.Forms.PictureBox pic_scan;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_Merge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAutoQc;
        private System.Windows.Forms.Label lblVettingNID;
    }
}