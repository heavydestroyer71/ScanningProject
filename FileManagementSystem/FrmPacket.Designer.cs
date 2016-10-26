namespace FileManagementSystem
{
    partial class FrmPacket
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
            this.pnlPacket = new System.Windows.Forms.Panel();
            this.gvPacketInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dpPacketDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChallanBoxNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChallan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.dpPacketReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.btnEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtPacketQuantity = new System.Windows.Forms.TextBox();
            this.lblPacketQuantity = new System.Windows.Forms.Label();
            this.txtPacketName = new System.Windows.Forms.TextBox();
            this.lblPacketName = new System.Windows.Forms.Label();
            this.selectExcelDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlPacket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPacketInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPacket
            // 
            this.pnlPacket.Controls.Add(this.gvPacketInfo);
            this.pnlPacket.Controls.Add(this.groupBox1);
            this.pnlPacket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPacket.Location = new System.Drawing.Point(0, 0);
            this.pnlPacket.Name = "pnlPacket";
            this.pnlPacket.Size = new System.Drawing.Size(810, 329);
            this.pnlPacket.TabIndex = 0;
            // 
            // gvPacketInfo
            // 
            this.gvPacketInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPacketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPacketInfo.Location = new System.Drawing.Point(0, 167);
            this.gvPacketInfo.Name = "gvPacketInfo";
            this.gvPacketInfo.Size = new System.Drawing.Size(810, 162);
            this.gvPacketInfo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtExcelPath);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.dpPacketDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDealerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtChallanBoxNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtChallan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRegion);
            this.groupBox1.Controls.Add(this.dpPacketReceiveDate);
            this.groupBox1.Controls.Add(this.btnEntry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRegion);
            this.groupBox1.Controls.Add(this.txtPacketQuantity);
            this.groupBox1.Controls.Add(this.lblPacketQuantity);
            this.groupBox1.Controls.Add(this.txtPacketName);
            this.groupBox1.Controls.Add(this.lblPacketName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Packet Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(619, 111);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(156, 25);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(700, 73);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(619, 76);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(83, 20);
            this.txtExcelPath.TabIndex = 17;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(700, 42);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 25);
            this.btnProcess.TabIndex = 16;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // dpPacketDate
            // 
            this.dpPacketDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpPacketDate.Location = new System.Drawing.Point(473, 111);
            this.dpPacketDate.Name = "dpPacketDate";
            this.dpPacketDate.Size = new System.Drawing.Size(140, 20);
            this.dpPacketDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Packet Date :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(473, 77);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(140, 20);
            this.txtDealerName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dealer Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChallanBoxNo
            // 
            this.txtChallanBoxNo.Location = new System.Drawing.Point(162, 78);
            this.txtChallanBoxNo.Name = "txtChallanBoxNo";
            this.txtChallanBoxNo.Size = new System.Drawing.Size(140, 20);
            this.txtChallanBoxNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Challan Box No :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChallan
            // 
            this.txtChallan.Location = new System.Drawing.Point(162, 44);
            this.txtChallan.Name = "txtChallan";
            this.txtChallan.Size = new System.Drawing.Size(140, 20);
            this.txtChallan.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Challan Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(474, 43);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(139, 21);
            this.cbRegion.TabIndex = 1;
            // 
            // dpPacketReceiveDate
            // 
            this.dpPacketReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpPacketReceiveDate.Location = new System.Drawing.Point(473, 141);
            this.dpPacketReceiveDate.Name = "dpPacketReceiveDate";
            this.dpPacketReceiveDate.Size = new System.Drawing.Size(140, 20);
            this.dpPacketReceiveDate.TabIndex = 7;
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(619, 42);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(75, 25);
            this.btnEntry.TabIndex = 8;
            this.btnEntry.Text = "&Entry";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Packet Receive Date :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegion
            // 
            this.lblRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(317, 43);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(150, 20);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Region :";
            this.lblRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPacketQuantity
            // 
            this.txtPacketQuantity.Location = new System.Drawing.Point(162, 142);
            this.txtPacketQuantity.Name = "txtPacketQuantity";
            this.txtPacketQuantity.Size = new System.Drawing.Size(140, 20);
            this.txtPacketQuantity.TabIndex = 6;
            // 
            // lblPacketQuantity
            // 
            this.lblPacketQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPacketQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacketQuantity.Location = new System.Drawing.Point(6, 142);
            this.lblPacketQuantity.Name = "lblPacketQuantity";
            this.lblPacketQuantity.Size = new System.Drawing.Size(150, 20);
            this.lblPacketQuantity.TabIndex = 2;
            this.lblPacketQuantity.Text = "Packet Quantity :";
            this.lblPacketQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPacketName
            // 
            this.txtPacketName.Location = new System.Drawing.Point(162, 108);
            this.txtPacketName.Name = "txtPacketName";
            this.txtPacketName.Size = new System.Drawing.Size(140, 20);
            this.txtPacketName.TabIndex = 4;
            // 
            // lblPacketName
            // 
            this.lblPacketName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPacketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacketName.Location = new System.Drawing.Point(6, 108);
            this.lblPacketName.Name = "lblPacketName";
            this.lblPacketName.Size = new System.Drawing.Size(150, 20);
            this.lblPacketName.TabIndex = 0;
            this.lblPacketName.Text = "Packet Name :";
            this.lblPacketName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmPacket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 329);
            this.Controls.Add(this.pnlPacket);
            this.Name = "FrmPacket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPacket_Load);
            this.pnlPacket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPacketInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPacket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPacketQuantity;
        private System.Windows.Forms.Label lblPacketQuantity;
        private System.Windows.Forms.TextBox txtPacketName;
        private System.Windows.Forms.Label lblPacketName;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpPacketReceiveDate;
        private System.Windows.Forms.DataGridView gvPacketInfo;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.TextBox txtChallanBoxNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChallan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpPacketDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog selectExcelDialog;
        private System.Windows.Forms.Button button1;
    }
}