namespace FileManagementSystem
{
    partial class frmStartByRegan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChallan = new System.Windows.Forms.ComboBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlBoxBatch = new System.Windows.Forms.Panel();
            this.lblFileQty = new System.Windows.Forms.Label();
            this.lblBatchId = new System.Windows.Forms.Label();
            this.lblChallanName = new System.Windows.Forms.Label();
            this.lblBoxId = new System.Windows.Forms.Label();
            this.lblScannedCnt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.grdBatchList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grdPacketList = new System.Windows.Forms.DataGridView();
            this.btnForceComplete = new System.Windows.Forms.Button();
            this.lblChallanId = new System.Windows.Forms.Label();
            this.pnlBoxBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPacketList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Wellcome";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(652, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(73, 25);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(546, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(100, 25);
            this.lblGreeting.TabIndex = 15;
            this.lblGreeting.Text = "label1";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select Challan and Region";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbChallan
            // 
            this.cbChallan.FormattingEnabled = true;
            this.cbChallan.Location = new System.Drawing.Point(170, 67);
            this.cbChallan.Name = "cbChallan";
            this.cbChallan.Size = new System.Drawing.Size(246, 21);
            this.cbChallan.TabIndex = 18;
            this.cbChallan.SelectedValueChanged += new System.EventHandler(this.cbChallan_SelectedValueChanged);
            // 
            // lblNotice
            // 
            this.lblNotice.BackColor = System.Drawing.Color.Brown;
            this.lblNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNotice.Location = new System.Drawing.Point(438, 94);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(228, 25);
            this.lblNotice.TabIndex = 22;
            this.lblNotice.Text = "Service Stopped...";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(235, 94);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(197, 25);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Scanning";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start Scanning";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlBoxBatch
            // 
            this.pnlBoxBatch.Controls.Add(this.lblFileQty);
            this.pnlBoxBatch.Controls.Add(this.lblBatchId);
            this.pnlBoxBatch.Controls.Add(this.lblChallanName);
            this.pnlBoxBatch.Controls.Add(this.lblBoxId);
            this.pnlBoxBatch.Controls.Add(this.lblScannedCnt);
            this.pnlBoxBatch.Controls.Add(this.label2);
            this.pnlBoxBatch.Controls.Add(this.lblBatch);
            this.pnlBoxBatch.Controls.Add(this.label4);
            this.pnlBoxBatch.Controls.Add(this.lblBox);
            this.pnlBoxBatch.Controls.Add(this.label3);
            this.pnlBoxBatch.Location = new System.Drawing.Point(35, 122);
            this.pnlBoxBatch.Name = "pnlBoxBatch";
            this.pnlBoxBatch.Size = new System.Drawing.Size(710, 74);
            this.pnlBoxBatch.TabIndex = 23;
            this.pnlBoxBatch.Visible = false;
            // 
            // lblFileQty
            // 
            this.lblFileQty.AutoSize = true;
            this.lblFileQty.Location = new System.Drawing.Point(608, 58);
            this.lblFileQty.Name = "lblFileQty";
            this.lblFileQty.Size = new System.Drawing.Size(0, 13);
            this.lblFileQty.TabIndex = 7;
            this.lblFileQty.Visible = false;
            // 
            // lblBatchId
            // 
            this.lblBatchId.AutoSize = true;
            this.lblBatchId.Location = new System.Drawing.Point(305, 58);
            this.lblBatchId.Name = "lblBatchId";
            this.lblBatchId.Size = new System.Drawing.Size(0, 13);
            this.lblBatchId.TabIndex = 6;
            this.lblBatchId.Visible = false;
            // 
            // lblChallanName
            // 
            this.lblChallanName.AutoSize = true;
            this.lblChallanName.Location = new System.Drawing.Point(6, 58);
            this.lblChallanName.Name = "lblChallanName";
            this.lblChallanName.Size = new System.Drawing.Size(35, 13);
            this.lblChallanName.TabIndex = 24;
            this.lblChallanName.Text = "label6";
            this.lblChallanName.Visible = false;
            // 
            // lblBoxId
            // 
            this.lblBoxId.AutoSize = true;
            this.lblBoxId.Location = new System.Drawing.Point(58, 58);
            this.lblBoxId.Name = "lblBoxId";
            this.lblBoxId.Size = new System.Drawing.Size(0, 13);
            this.lblBoxId.TabIndex = 6;
            this.lblBoxId.Visible = false;
            // 
            // lblScannedCnt
            // 
            this.lblScannedCnt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblScannedCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScannedCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScannedCnt.Location = new System.Drawing.Point(614, 10);
            this.lblScannedCnt.Name = "lblScannedCnt";
            this.lblScannedCnt.Size = new System.Drawing.Size(85, 44);
            this.lblScannedCnt.TabIndex = 5;
            this.lblScannedCnt.Text = "0";
            this.lblScannedCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCANNED";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBatch
            // 
            this.lblBatch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(311, 10);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(204, 44);
            this.lblBatch.TabIndex = 3;
            this.lblBatch.Text = "BATCH";
            this.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 44);
            this.label4.TabIndex = 2;
            this.label4.Text = "BATCH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBox
            // 
            this.lblBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox.Location = new System.Drawing.Point(61, 10);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(177, 44);
            this.lblBox.TabIndex = 0;
            this.lblBox.Text = "BOX";
            this.lblBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(423, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Select Box";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBox
            // 
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Location = new System.Drawing.Point(546, 67);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(222, 21);
            this.cbBox.TabIndex = 26;
            // 
            // grdBatchList
            // 
            this.grdBatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBatchList.Location = new System.Drawing.Point(372, 226);
            this.grdBatchList.Name = "grdBatchList";
            this.grdBatchList.Size = new System.Drawing.Size(403, 314);
            this.grdBatchList.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "Batch List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 31);
            this.label8.TabIndex = 29;
            this.label8.Text = "Packet List";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdPacketList
            // 
            this.grdPacketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPacketList.Location = new System.Drawing.Point(16, 226);
            this.grdPacketList.Name = "grdPacketList";
            this.grdPacketList.Size = new System.Drawing.Size(350, 314);
            this.grdPacketList.TabIndex = 30;
            // 
            // btnForceComplete
            // 
            this.btnForceComplete.Location = new System.Drawing.Point(672, 94);
            this.btnForceComplete.Name = "btnForceComplete";
            this.btnForceComplete.Size = new System.Drawing.Size(96, 25);
            this.btnForceComplete.TabIndex = 31;
            this.btnForceComplete.Text = "Complete Box";
            this.btnForceComplete.UseVisualStyleBackColor = true;
            this.btnForceComplete.Visible = false;
            this.btnForceComplete.Click += new System.EventHandler(this.btnForceComplete_Click);
            // 
            // lblChallanId
            // 
            this.lblChallanId.AutoSize = true;
            this.lblChallanId.Location = new System.Drawing.Point(44, 203);
            this.lblChallanId.Name = "lblChallanId";
            this.lblChallanId.Size = new System.Drawing.Size(35, 13);
            this.lblChallanId.TabIndex = 32;
            this.lblChallanId.Text = "label9";
            this.lblChallanId.Visible = false;
            // 
            // frmStartByRegan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 572);
            this.ControlBox = false;
            this.Controls.Add(this.lblChallanId);
            this.Controls.Add(this.btnForceComplete);
            this.Controls.Add(this.grdPacketList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdBatchList);
            this.Controls.Add(this.cbBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlBoxBatch);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChallan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmStartByRegan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanning Operator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStartByRegan_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStartByRegan_FormClosed);
            this.Load += new System.EventHandler(this.frmStartByRegan_Load);
            this.pnlBoxBatch.ResumeLayout(false);
            this.pnlBoxBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPacketList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChallan;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlBoxBatch;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScannedCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBatchId;
        private System.Windows.Forms.Label lblBoxId;
        private System.Windows.Forms.Label lblFileQty;
        private System.Windows.Forms.Label lblChallanName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.DataGridView grdBatchList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grdPacketList;
        private System.Windows.Forms.Button btnForceComplete;
        private System.Windows.Forms.Label lblChallanId;
    }
}