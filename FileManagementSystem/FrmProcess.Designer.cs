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
            this.grpResetChallanBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboResetChallanBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAutoBoxBatch = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChallan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlProcess.SuspendLayout();
            this.grpResetChallanBox.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProcess
            // 
            this.pnlProcess.Controls.Add(this.grpResetChallanBox);
            this.pnlProcess.Controls.Add(this.btnAutoBoxBatch);
            this.pnlProcess.Controls.Add(this.pnlControl);
            this.pnlProcess.Controls.Add(this.label2);
            this.pnlProcess.Controls.Add(this.cbRegion);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProcess.Location = new System.Drawing.Point(0, 0);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(758, 306);
            this.pnlProcess.TabIndex = 0;
            // 
            // grpResetChallanBox
            // 
            this.grpResetChallanBox.Controls.Add(this.cbBox);
            this.grpResetChallanBox.Controls.Add(this.label6);
            this.grpResetChallanBox.Controls.Add(this.button1);
            this.grpResetChallanBox.Controls.Add(this.cboResetChallanBox);
            this.grpResetChallanBox.Controls.Add(this.label3);
            this.grpResetChallanBox.Location = new System.Drawing.Point(27, 110);
            this.grpResetChallanBox.Name = "grpResetChallanBox";
            this.grpResetChallanBox.Size = new System.Drawing.Size(710, 100);
            this.grpResetChallanBox.TabIndex = 16;
            this.grpResetChallanBox.TabStop = false;
            this.grpResetChallanBox.Text = "Reset Challan Box";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(540, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Reset Challan Box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboResetChallanBox
            // 
            this.cboResetChallanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboResetChallanBox.FormattingEnabled = true;
            this.cboResetChallanBox.Location = new System.Drawing.Point(193, 28);
            this.cboResetChallanBox.Name = "cboResetChallanBox";
            this.cboResetChallanBox.Size = new System.Drawing.Size(341, 24);
            this.cboResetChallanBox.TabIndex = 12;
            this.cboResetChallanBox.SelectedValueChanged += new System.EventHandler(this.cboResetChallanBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Challan and Region";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutoBoxBatch
            // 
            this.btnAutoBoxBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoBoxBatch.Location = new System.Drawing.Point(27, 231);
            this.btnAutoBoxBatch.Name = "btnAutoBoxBatch";
            this.btnAutoBoxBatch.Size = new System.Drawing.Size(161, 24);
            this.btnAutoBoxBatch.TabIndex = 15;
            this.btnAutoBoxBatch.Text = "Auto batch Box create";
            this.btnAutoBoxBatch.UseVisualStyleBackColor = true;
            this.btnAutoBoxBatch.Visible = false;
            this.btnAutoBoxBatch.Click += new System.EventHandler(this.btnAutoBoxBatch_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnProcess);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.cbChallan);
            this.pnlControl.Location = new System.Drawing.Point(27, 38);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(710, 66);
            this.pnlControl.TabIndex = 14;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(540, 9);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(161, 24);
            this.btnProcess.TabIndex = 12;
            this.btnProcess.Text = "&Create Box and Batch";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Challan and Region";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbChallan
            // 
            this.cbChallan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChallan.FormattingEnabled = true;
            this.cbChallan.Location = new System.Drawing.Point(193, 9);
            this.cbChallan.Name = "cbChallan";
            this.cbChallan.Size = new System.Drawing.Size(341, 24);
            this.cbChallan.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(435, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Region";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(589, 11);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(148, 21);
            this.cbRegion.TabIndex = 3;
            this.cbRegion.Visible = false;
            // 
            // cbBox
            // 
            this.cbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Location = new System.Drawing.Point(193, 58);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(341, 24);
            this.cbBox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Select Box";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 306);
            this.Controls.Add(this.pnlProcess);
            this.Name = "FrmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmProcess_Load);
            this.pnlProcess.ResumeLayout(false);
            this.grpResetChallanBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAutoBoxBatch;
        private System.Windows.Forms.GroupBox grpResetChallanBox;
        private System.Windows.Forms.ComboBox cboResetChallanBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.Label label6;
    }
}