namespace FileManagementSystem
{
    partial class FrmStart
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
            this.components = new System.ComponentModel.Container();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChallan = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlBoxBatch = new System.Windows.Forms.Panel();
            this.lblBatch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbChallan_box = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.cbPacketInfo = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlStart.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlBoxBatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlStart.Controls.Add(this.label5);
            this.pnlStart.Controls.Add(this.pnlControl);
            this.pnlStart.Controls.Add(this.pnlBoxBatch);
            this.pnlStart.Controls.Add(this.cbChallan_box);
            this.pnlStart.Controls.Add(this.btnLogout);
            this.pnlStart.Controls.Add(this.lblGreeting);
            this.pnlStart.Controls.Add(this.cbPacketInfo);
            this.pnlStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStart.Location = new System.Drawing.Point(0, 0);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(919, 519);
            this.pnlStart.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Wellcome";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.lblNotice);
            this.pnlControl.Controls.Add(this.btnStop);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.cbRegion);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.cbChallan);
            this.pnlControl.Controls.Add(this.btnStart);
            this.pnlControl.Location = new System.Drawing.Point(106, 113);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(710, 100);
            this.pnlControl.TabIndex = 13;
            // 
            // lblNotice
            // 
            this.lblNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotice.Location = new System.Drawing.Point(356, 62);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(148, 25);
            this.lblNotice.TabIndex = 13;
            this.lblNotice.Text = "label6";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotice.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(202, 62);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(148, 25);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop Scanning";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Challan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(510, 18);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(148, 21);
            this.cbRegion.TabIndex = 3;
            this.cbRegion.DropDown += new System.EventHandler(this.cbRegion_DropDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(356, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Region";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbChallan
            // 
            this.cbChallan.FormattingEnabled = true;
            this.cbChallan.Location = new System.Drawing.Point(202, 16);
            this.cbChallan.Name = "cbChallan";
            this.cbChallan.Size = new System.Drawing.Size(148, 21);
            this.cbChallan.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(48, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 25);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "&Start Scanning";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlBoxBatch
            // 
            this.pnlBoxBatch.Controls.Add(this.lblBatch);
            this.pnlBoxBatch.Controls.Add(this.label4);
            this.pnlBoxBatch.Controls.Add(this.lblBox);
            this.pnlBoxBatch.Controls.Add(this.label3);
            this.pnlBoxBatch.Location = new System.Drawing.Point(106, 240);
            this.pnlBoxBatch.Name = "pnlBoxBatch";
            this.pnlBoxBatch.Size = new System.Drawing.Size(710, 100);
            this.pnlBoxBatch.TabIndex = 12;
            this.pnlBoxBatch.Visible = false;
            // 
            // lblBatch
            // 
            this.lblBatch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(462, 27);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(223, 45);
            this.lblBatch.TabIndex = 3;
            this.lblBatch.Text = "BATCH";
            this.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "BATCH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBox
            // 
            this.lblBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox.Location = new System.Drawing.Point(96, 27);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(245, 45);
            this.lblBox.TabIndex = 1;
            this.lblBox.Text = "BOX";
            this.lblBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbChallan_box
            // 
            this.cbChallan_box.FormattingEnabled = true;
            this.cbChallan_box.Location = new System.Drawing.Point(323, 86);
            this.cbChallan_box.Name = "cbChallan_box";
            this.cbChallan_box.Size = new System.Drawing.Size(148, 21);
            this.cbChallan_box.TabIndex = 9;
            this.cbChallan_box.Visible = false;
            this.cbChallan_box.DropDown += new System.EventHandler(this.cbChallan_box_DropDown);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(795, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 25);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(676, 13);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(100, 25);
            this.lblGreeting.TabIndex = 6;
            this.lblGreeting.Text = "label1";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPacketInfo
            // 
            this.cbPacketInfo.FormattingEnabled = true;
            this.cbPacketInfo.Location = new System.Drawing.Point(477, 86);
            this.cbPacketInfo.Name = "cbPacketInfo";
            this.cbPacketInfo.Size = new System.Drawing.Size(148, 21);
            this.cbPacketInfo.TabIndex = 2;
            this.cbPacketInfo.Visible = false;
            this.cbPacketInfo.DropDown += new System.EventHandler(this.cbPacketInfo_DropDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 519);
            this.ControlBox = false;
            this.Controls.Add(this.pnlStart);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanning";
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.pnlStart.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlBoxBatch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbPacketInfo;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.ComboBox cbChallan;
        private System.Windows.Forms.ComboBox cbChallan_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBoxBatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblNotice;
    }
}