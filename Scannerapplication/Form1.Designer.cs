using System.Windows.Forms;
namespace Scannerapplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showImages = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_capture = new System.Windows.Forms.Panel();
            this.pnlCropPic = new System.Windows.Forms.Panel();
            this.picCrop = new System.Windows.Forms.PictureBox();
            this.pnlNIDPic = new System.Windows.Forms.Panel();
            this.pbNID = new System.Windows.Forms.PictureBox();
            this.pnlRegPic = new System.Windows.Forms.Panel();
            this.pic_scan = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbHorizontalCrop = new System.Windows.Forms.CheckBox();
            this.lblCrop = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.lblVettingNID = new System.Windows.Forms.Label();
            this.btnRegNID = new System.Windows.Forms.Button();
            this.lblReNID = new System.Windows.Forms.Label();
            this.btnNIDScan = new System.Windows.Forms.Button();
            this.lblReReg = new System.Windows.Forms.Label();
            this.btnScanMerge = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.cbQC = new System.Windows.Forms.CheckBox();
            this.lblNIDPath = new System.Windows.Forms.Label();
            this.btnCombineImage = new System.Windows.Forms.Button();
            this.btnNID = new System.Windows.Forms.Button();
            this.lblRegPath = new System.Windows.Forms.Label();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.trbZoomFactor = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.lblZoomFactor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.txtQCImages = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCompleteImages = new System.Windows.Forms.TextBox();
            this.lblMSIDN = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSIDN = new System.Windows.Forms.TextBox();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtBoxNo = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtChallanNo = new System.Windows.Forms.TextBox();
            this.lblChallanNo = new System.Windows.Forms.Label();
            this.lblBoxNo = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl_capture.SuspendLayout();
            this.pnlCropPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCrop)).BeginInit();
            this.pnlNIDPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNID)).BeginInit();
            this.pnlRegPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // showImages
            // 
            this.showImages.Location = new System.Drawing.Point(242, 216);
            this.showImages.Name = "showImages";
            this.showImages.Size = new System.Drawing.Size(85, 23);
            this.showImages.TabIndex = 5;
            this.showImages.Text = "Show Images";
            this.showImages.UseVisualStyleBackColor = true;
            this.showImages.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1162, 3);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // pnl_capture
            // 
            this.pnl_capture.BackColor = System.Drawing.Color.Transparent;
            this.pnl_capture.Controls.Add(this.pnlCropPic);
            this.pnl_capture.Controls.Add(this.pnlNIDPic);
            this.pnl_capture.Controls.Add(this.pnlRegPic);
            this.pnl_capture.Controls.Add(this.panel2);
            this.pnl_capture.Controls.Add(this.pnlControl);
            this.pnl_capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_capture.ForeColor = System.Drawing.Color.Black;
            this.pnl_capture.Location = new System.Drawing.Point(0, 3);
            this.pnl_capture.Name = "pnl_capture";
            this.pnl_capture.Size = new System.Drawing.Size(1162, 712);
            this.pnl_capture.TabIndex = 39;
            // 
            // pnlCropPic
            // 
            this.pnlCropPic.Controls.Add(this.picCrop);
            this.pnlCropPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCropPic.Location = new System.Drawing.Point(973, 0);
            this.pnlCropPic.Name = "pnlCropPic";
            this.pnlCropPic.Size = new System.Drawing.Size(292, 669);
            this.pnlCropPic.TabIndex = 53;
            // 
            // picCrop
            // 
            this.picCrop.Location = new System.Drawing.Point(6, 18);
            this.picCrop.Name = "picCrop";
            this.picCrop.Size = new System.Drawing.Size(100, 50);
            this.picCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCrop.TabIndex = 1;
            this.picCrop.TabStop = false;
            // 
            // pnlNIDPic
            // 
            this.pnlNIDPic.AutoScroll = true;
            this.pnlNIDPic.Controls.Add(this.pbNID);
            this.pnlNIDPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNIDPic.Location = new System.Drawing.Point(603, 0);
            this.pnlNIDPic.Name = "pnlNIDPic";
            this.pnlNIDPic.Size = new System.Drawing.Size(370, 669);
            this.pnlNIDPic.TabIndex = 52;
            // 
            // pbNID
            // 
            this.pbNID.Location = new System.Drawing.Point(26, 10);
            this.pbNID.Name = "pbNID";
            this.pbNID.Size = new System.Drawing.Size(100, 50);
            this.pbNID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNID.TabIndex = 0;
            this.pbNID.TabStop = false;
            this.pbNID.Paint += new System.Windows.Forms.PaintEventHandler(this.pbNID_Paint);
            this.pbNID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbNID_MouseDown);
            this.pbNID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbNID_MouseMove);
            this.pbNID.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbNID_MouseUp);
            // 
            // pnlRegPic
            // 
            this.pnlRegPic.Controls.Add(this.pic_scan);
            this.pnlRegPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRegPic.Location = new System.Drawing.Point(220, 0);
            this.pnlRegPic.Name = "pnlRegPic";
            this.pnlRegPic.Size = new System.Drawing.Size(383, 669);
            this.pnlRegPic.TabIndex = 49;
            // 
            // pic_scan
            // 
            this.pic_scan.BackColor = System.Drawing.Color.White;
            this.pic_scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_scan.Location = new System.Drawing.Point(0, 0);
            this.pic_scan.Name = "pic_scan";
            this.pic_scan.Size = new System.Drawing.Size(183, 86);
            this.pic_scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_scan.TabIndex = 6;
            this.pic_scan.TabStop = false;
            this.pic_scan.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_scan_Paint);
            this.pic_scan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_scan_MouseDown);
            this.pic_scan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_scan_MouseMove);
            this.pic_scan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_scan_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbHorizontalCrop);
            this.panel2.Controls.Add(this.lblCrop);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_scan);
            this.panel2.Controls.Add(this.lblVettingNID);
            this.panel2.Controls.Add(this.btnRegNID);
            this.panel2.Controls.Add(this.lblReNID);
            this.panel2.Controls.Add(this.btnNIDScan);
            this.panel2.Controls.Add(this.lblReReg);
            this.panel2.Controls.Add(this.btnScanMerge);
            this.panel2.Controls.Add(this.btnMerge);
            this.panel2.Controls.Add(this.cbQC);
            this.panel2.Controls.Add(this.lblNIDPath);
            this.panel2.Controls.Add(this.btnCombineImage);
            this.panel2.Controls.Add(this.btnNID);
            this.panel2.Controls.Add(this.lblRegPath);
            this.panel2.Controls.Add(this.lbDevices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(220, 669);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 43);
            this.panel2.TabIndex = 48;
            // 
            // cbHorizontalCrop
            // 
            this.cbHorizontalCrop.AutoSize = true;
            this.cbHorizontalCrop.Location = new System.Drawing.Point(576, 15);
            this.cbHorizontalCrop.Name = "cbHorizontalCrop";
            this.cbHorizontalCrop.Size = new System.Drawing.Size(98, 17);
            this.cbHorizontalCrop.TabIndex = 38;
            this.cbHorizontalCrop.Text = "Horizontal Crop";
            this.cbHorizontalCrop.UseVisualStyleBackColor = true;
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.Location = new System.Drawing.Point(814, 50);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(35, 13);
            this.lblCrop.TabIndex = 36;
            this.lblCrop.Text = "label4";
            this.lblCrop.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_scan.Location = new System.Drawing.Point(15, 37);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(134, 34);
            this.btn_scan.TabIndex = 4;
            this.btn_scan.Text = "Registration Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Visible = false;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // lblVettingNID
            // 
            this.lblVettingNID.AutoSize = true;
            this.lblVettingNID.Location = new System.Drawing.Point(904, 5);
            this.lblVettingNID.Name = "lblVettingNID";
            this.lblVettingNID.Size = new System.Drawing.Size(35, 13);
            this.lblVettingNID.TabIndex = 35;
            this.lblVettingNID.Text = "label1";
            this.lblVettingNID.Visible = false;
            // 
            // btnRegNID
            // 
            this.btnRegNID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegNID.Location = new System.Drawing.Point(87, 6);
            this.btnRegNID.Name = "btnRegNID";
            this.btnRegNID.Size = new System.Drawing.Size(134, 34);
            this.btnRegNID.TabIndex = 11;
            this.btnRegNID.Text = "Both Scan";
            this.btnRegNID.UseVisualStyleBackColor = true;
            this.btnRegNID.Visible = false;
            this.btnRegNID.Click += new System.EventHandler(this.btnRegNID_Click);
            // 
            // lblReNID
            // 
            this.lblReNID.AutoSize = true;
            this.lblReNID.Location = new System.Drawing.Point(750, 52);
            this.lblReNID.Name = "lblReNID";
            this.lblReNID.Size = new System.Drawing.Size(35, 13);
            this.lblReNID.TabIndex = 34;
            this.lblReNID.Text = "label1";
            this.lblReNID.Visible = false;
            // 
            // btnNIDScan
            // 
            this.btnNIDScan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNIDScan.Location = new System.Drawing.Point(159, 46);
            this.btnNIDScan.Name = "btnNIDScan";
            this.btnNIDScan.Size = new System.Drawing.Size(134, 34);
            this.btnNIDScan.TabIndex = 10;
            this.btnNIDScan.Text = "NID Scan";
            this.btnNIDScan.UseVisualStyleBackColor = true;
            this.btnNIDScan.Visible = false;
            this.btnNIDScan.Click += new System.EventHandler(this.btnNIDScan_Click);
            // 
            // lblReReg
            // 
            this.lblReReg.AutoSize = true;
            this.lblReReg.Location = new System.Drawing.Point(684, 52);
            this.lblReReg.Name = "lblReReg";
            this.lblReReg.Size = new System.Drawing.Size(35, 13);
            this.lblReReg.TabIndex = 33;
            this.lblReReg.Text = "label1";
            this.lblReReg.Visible = false;
            // 
            // btnScanMerge
            // 
            this.btnScanMerge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnScanMerge.Location = new System.Drawing.Point(299, 48);
            this.btnScanMerge.Name = "btnScanMerge";
            this.btnScanMerge.Size = new System.Drawing.Size(134, 30);
            this.btnScanMerge.TabIndex = 12;
            this.btnScanMerge.Text = "Both Scan With Merge";
            this.btnScanMerge.UseVisualStyleBackColor = true;
            this.btnScanMerge.Visible = false;
            // 
            // btnMerge
            // 
            this.btnMerge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMerge.Location = new System.Drawing.Point(181, 5);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(134, 30);
            this.btnMerge.TabIndex = 13;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Visible = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // cbQC
            // 
            this.cbQC.AutoSize = true;
            this.cbQC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbQC.Location = new System.Drawing.Point(617, 54);
            this.cbQC.Name = "cbQC";
            this.cbQC.Size = new System.Drawing.Size(41, 17);
            this.cbQC.TabIndex = 23;
            this.cbQC.Text = "QC";
            this.cbQC.UseVisualStyleBackColor = true;
            this.cbQC.Visible = false;
            // 
            // lblNIDPath
            // 
            this.lblNIDPath.AutoSize = true;
            this.lblNIDPath.Location = new System.Drawing.Point(900, 22);
            this.lblNIDPath.Name = "lblNIDPath";
            this.lblNIDPath.Size = new System.Drawing.Size(39, 13);
            this.lblNIDPath.TabIndex = 26;
            this.lblNIDPath.Text = "lbl NID";
            this.lblNIDPath.Visible = false;
            // 
            // btnCombineImage
            // 
            this.btnCombineImage.ForeColor = System.Drawing.Color.Black;
            this.btnCombineImage.Location = new System.Drawing.Point(288, 9);
            this.btnCombineImage.Name = "btnCombineImage";
            this.btnCombineImage.Size = new System.Drawing.Size(95, 23);
            this.btnCombineImage.TabIndex = 9;
            this.btnCombineImage.Text = "Combine Image";
            this.btnCombineImage.UseVisualStyleBackColor = true;
            this.btnCombineImage.Visible = false;
            this.btnCombineImage.Click += new System.EventHandler(this.btnCombineImage_Click);
            // 
            // btnNID
            // 
            this.btnNID.ForeColor = System.Drawing.Color.Black;
            this.btnNID.Location = new System.Drawing.Point(439, 45);
            this.btnNID.Name = "btnNID";
            this.btnNID.Size = new System.Drawing.Size(75, 26);
            this.btnNID.TabIndex = 8;
            this.btnNID.Text = "Upload";
            this.btnNID.UseVisualStyleBackColor = true;
            this.btnNID.Visible = false;
            this.btnNID.Click += new System.EventHandler(this.btnNID_Click);
            // 
            // lblRegPath
            // 
            this.lblRegPath.AutoSize = true;
            this.lblRegPath.Location = new System.Drawing.Point(858, 5);
            this.lblRegPath.Name = "lblRegPath";
            this.lblRegPath.Size = new System.Drawing.Size(40, 13);
            this.lblRegPath.TabIndex = 25;
            this.lblRegPath.Text = "lbl Reg";
            this.lblRegPath.Visible = false;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(759, 5);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(120, 30);
            this.lbDevices.TabIndex = 5;
            this.lbDevices.Visible = false;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.lblUser);
            this.pnlControl.Controls.Add(this.button6);
            this.pnlControl.Controls.Add(this.picZoom);
            this.pnlControl.Controls.Add(this.trbZoomFactor);
            this.pnlControl.Controls.Add(this.button4);
            this.pnlControl.Controls.Add(this.lblZoomFactor);
            this.pnlControl.Controls.Add(this.comboBox1);
            this.pnlControl.Controls.Add(this.lblBatchNo);
            this.pnlControl.Controls.Add(this.txtQCImages);
            this.pnlControl.Controls.Add(this.button1);
            this.pnlControl.Controls.Add(this.txtCompleteImages);
            this.pnlControl.Controls.Add(this.lblMSIDN);
            this.pnlControl.Controls.Add(this.button5);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.txtMSIDN);
            this.pnlControl.Controls.Add(this.btnCloseApplication);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.btnOK);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.btn_Merge);
            this.pnlControl.Controls.Add(this.txtDOB);
            this.pnlControl.Controls.Add(this.txtBoxNo);
            this.pnlControl.Controls.Add(this.lblDOB);
            this.pnlControl.Controls.Add(this.textBox1);
            this.pnlControl.Controls.Add(this.txtName);
            this.pnlControl.Controls.Add(this.txtBatchNo);
            this.pnlControl.Controls.Add(this.lblName);
            this.pnlControl.Controls.Add(this.button2);
            this.pnlControl.Controls.Add(this.txtChallanNo);
            this.pnlControl.Controls.Add(this.lblChallanNo);
            this.pnlControl.Controls.Add(this.lblBoxNo);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(220, 712);
            this.pnlControl.TabIndex = 47;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(136, 566);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 51;
            this.lblUser.Text = "label4";
            this.lblUser.Visible = false;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(10, 493);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 30);
            this.button6.TabIndex = 4;
            this.button6.Text = "Qc Fail";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // picZoom
            // 
            this.picZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picZoom.BackColor = System.Drawing.Color.White;
            this.picZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZoom.Location = new System.Drawing.Point(3, 10);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(214, 50);
            this.picZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picZoom.TabIndex = 50;
            this.picZoom.TabStop = false;
            // 
            // trbZoomFactor
            // 
            this.trbZoomFactor.Location = new System.Drawing.Point(8, 63);
            this.trbZoomFactor.Name = "trbZoomFactor";
            this.trbZoomFactor.Size = new System.Drawing.Size(104, 45);
            this.trbZoomFactor.TabIndex = 47;
            this.trbZoomFactor.Value = 3;
            this.trbZoomFactor.Visible = false;
            this.trbZoomFactor.ValueChanged += new System.EventHandler(this.trbZoomFactor_ValueChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 457);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Crop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblZoomFactor
            // 
            this.lblZoomFactor.AutoSize = true;
            this.lblZoomFactor.Location = new System.Drawing.Point(118, 63);
            this.lblZoomFactor.Name = "lblZoomFactor";
            this.lblZoomFactor.Size = new System.Drawing.Size(18, 13);
            this.lblZoomFactor.TabIndex = 49;
            this.lblZoomFactor.Text = "x3";
            this.lblZoomFactor.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(13, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBatchNo.Location = new System.Drawing.Point(8, 138);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(61, 15);
            this.lblBatchNo.TabIndex = 37;
            this.lblBatchNo.Text = "Batch No";
            this.lblBatchNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQCImages
            // 
            this.txtQCImages.Enabled = false;
            this.txtQCImages.Location = new System.Drawing.Point(104, 249);
            this.txtQCImages.Name = "txtQCImages";
            this.txtQCImages.Size = new System.Drawing.Size(63, 20);
            this.txtQCImages.TabIndex = 46;
            this.txtQCImages.Visible = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(11, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Registration and NID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCompleteImages
            // 
            this.txtCompleteImages.BackColor = System.Drawing.Color.Orange;
            this.txtCompleteImages.Enabled = false;
            this.txtCompleteImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompleteImages.Location = new System.Drawing.Point(104, 220);
            this.txtCompleteImages.Name = "txtCompleteImages";
            this.txtCompleteImages.Size = new System.Drawing.Size(63, 22);
            this.txtCompleteImages.TabIndex = 45;
            // 
            // lblMSIDN
            // 
            this.lblMSIDN.AutoSize = true;
            this.lblMSIDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSIDN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMSIDN.Location = new System.Drawing.Point(14, 364);
            this.lblMSIDN.Name = "lblMSIDN";
            this.lblMSIDN.Size = new System.Drawing.Size(44, 15);
            this.lblMSIDN.TabIndex = 16;
            this.lblMSIDN.Text = "MSIDN";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(139, 678);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(8, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "QC Images";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // txtMSIDN
            // 
            this.txtMSIDN.Location = new System.Drawing.Point(64, 364);
            this.txtMSIDN.MaxLength = 11;
            this.txtMSIDN.Name = "txtMSIDN";
            this.txtMSIDN.Size = new System.Drawing.Size(106, 20);
            this.txtMSIDN.TabIndex = 2;
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.BackColor = System.Drawing.Color.DarkRed;
            this.btnCloseApplication.ForeColor = System.Drawing.Color.White;
            this.btnCloseApplication.Location = new System.Drawing.Point(14, 598);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(158, 30);
            this.btnCloseApplication.TabIndex = 8;
            this.btnCloseApplication.Text = "Close";
            this.btnCloseApplication.UseVisualStyleBackColor = false;
            this.btnCloseApplication.Visible = false;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(8, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Complete Images";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOK.Location = new System.Drawing.Point(10, 394);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(158, 30);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Vetting";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(8, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Images Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Merge
            // 
            this.btn_Merge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Merge.Location = new System.Drawing.Point(10, 529);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(158, 30);
            this.btn_Merge.TabIndex = 3;
            this.btn_Merge.Text = "Merge";
            this.btn_Merge.UseVisualStyleBackColor = true;
            this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
            // 
            // txtDOB
            // 
            this.txtDOB.Enabled = false;
            this.txtDOB.Location = new System.Drawing.Point(58, 669);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(106, 20);
            this.txtDOB.TabIndex = 4;
            this.txtDOB.Visible = false;
            // 
            // txtBoxNo
            // 
            this.txtBoxNo.Location = new System.Drawing.Point(76, 157);
            this.txtBoxNo.Name = "txtBoxNo";
            this.txtBoxNo.Size = new System.Drawing.Size(94, 20);
            this.txtBoxNo.TabIndex = 41;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDOB.Location = new System.Drawing.Point(8, 672);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(32, 15);
            this.lblDOB.TabIndex = 20;
            this.lblDOB.Text = "DOB";
            this.lblDOB.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(11, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(58, 640);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Visible = false;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(76, 135);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(94, 20);
            this.txtBatchNo.TabIndex = 40;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(8, 640);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(112, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 20);
            this.button2.TabIndex = 0;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.Location = new System.Drawing.Point(76, 114);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.Size = new System.Drawing.Size(94, 20);
            this.txtChallanNo.TabIndex = 39;
            // 
            // lblChallanNo
            // 
            this.lblChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChallanNo.Location = new System.Drawing.Point(8, 114);
            this.lblChallanNo.Name = "lblChallanNo";
            this.lblChallanNo.Size = new System.Drawing.Size(61, 15);
            this.lblChallanNo.TabIndex = 36;
            this.lblChallanNo.Text = "Challan No";
            this.lblChallanNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoxNo
            // 
            this.lblBoxNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoxNo.Location = new System.Drawing.Point(8, 162);
            this.lblBoxNo.Name = "lblBoxNo";
            this.lblBoxNo.Size = new System.Drawing.Size(61, 15);
            this.lblBoxNo.TabIndex = 38;
            this.lblBoxNo.Text = "Box No";
            this.lblBoxNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 715);
            this.Controls.Add(this.pnl_capture);
            this.Controls.Add(this.splitter1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Two Images Merge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.pnl_capture.ResumeLayout(false);
            this.pnlCropPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCrop)).EndInit();
            this.pnlNIDPic.ResumeLayout(false);
            this.pnlNIDPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNID)).EndInit();
            this.pnlRegPic.ResumeLayout(false);
            this.pnlRegPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbZoomFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        //camera
        private System.Windows.Forms.Button showImages;
        private Splitter splitter1;
        private Panel pnl_capture;
        private ListBox lbDevices;
        private Button btn_scan;
        private PictureBox pic_scan;
        private Button btnNID;
        private Button btnCombineImage;
        private Button btnNIDScan;
        private Button btnMerge;
        private Button btnScanMerge;
        private Button btnRegNID;
        private Button button1;
        private TextBox txtMSIDN;
        private Label lblMSIDN;
        private TextBox txtDOB;
        private Label lblDOB;
        private TextBox txtName;
        private Label lblName;
        private Button btnOK;
        private CheckBox cbQC;
        private Button btn_Merge;
        private Label lblNIDPath;
        private Label lblRegPath;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private Button button3;
        private Button btnCloseApplication;
        private Button button4;
        private Button button5;
        private Label lblReNID;
        private Label lblReReg;
        private Label lblVettingNID;
        private TextBox txtBoxNo;
        private TextBox txtBatchNo;
        private TextBox txtChallanNo;
        private Label lblBoxNo;
        private Label lblBatchNo;
        private Label lblChallanNo;
        private TextBox txtQCImages;
        private TextBox txtCompleteImages;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnlRegPic;
        private Panel panel2;
        private Panel pnlControl;
        private TrackBar trbZoomFactor;
        private ComboBox comboBox1;
        private Label lblZoomFactor;
        private PictureBox picZoom;
        private Panel pnlCropPic;
        private PictureBox picCrop;
        private Panel pnlNIDPic;
        private PictureBox pbNID;
        private Label lblCrop;
        private Button button6;
        private Label lblUser;
        private CheckBox cbHorizontalCrop;
    }
}

