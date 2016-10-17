namespace FileManagementSystem
{
    partial class FrmProcess
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
            this.pnlProcess = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChallan = new System.Windows.Forms.ComboBox();
            this.pnlProcess.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProcess
            // 
            this.pnlProcess.Controls.Add(this.pnlControl);
            this.pnlProcess.Controls.Add(this.label2);
            this.pnlProcess.Controls.Add(this.cbRegion);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProcess.Location = new System.Drawing.Point(0, 0);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(758, 306);
            this.pnlProcess.TabIndex = 0;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnProcess);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.cbChallan);
            this.pnlControl.Location = new System.Drawing.Point(24, 103);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(710, 100);
            this.pnlControl.TabIndex = 14;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(419, 14);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(148, 25);
            this.btnProcess.TabIndex = 12;
            this.btnProcess.Text = "&Create Box and Batch";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Challan and Region";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(544, 79);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(148, 21);
            this.cbRegion.TabIndex = 3;
            this.cbRegion.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(390, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Region";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // cbChallan
            // 
            this.cbChallan.FormattingEnabled = true;
            this.cbChallan.Location = new System.Drawing.Point(202, 16);
            this.cbChallan.Name = "cbChallan";
            this.cbChallan.Size = new System.Drawing.Size(198, 21);
            this.cbChallan.TabIndex = 8;
            // 
            // FrmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 306);
            this.Controls.Add(this.pnlProcess);
            this.Name = "FrmProcess";
            this.Load += new System.EventHandler(this.FrmProcess_Load);
            this.pnlProcess.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProcess;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChallan;
        private System.Windows.Forms.Button btnProcess;
    }
}