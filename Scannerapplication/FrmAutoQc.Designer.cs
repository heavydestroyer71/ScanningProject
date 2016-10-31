namespace Scannerapplication
{
    partial class FrmAutoQc
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
            this.btnAutoQc = new System.Windows.Forms.Button();
            this.lblComplete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComNum = new System.Windows.Forms.Label();
            this.lblIncomNum = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutoQc
            // 
            this.btnAutoQc.Location = new System.Drawing.Point(12, 92);
            this.btnAutoQc.Name = "btnAutoQc";
            this.btnAutoQc.Size = new System.Drawing.Size(137, 34);
            this.btnAutoQc.TabIndex = 0;
            this.btnAutoQc.Text = "Automatic Qc";
            this.btnAutoQc.UseVisualStyleBackColor = true;
            this.btnAutoQc.Click += new System.EventHandler(this.btnAutoQc_Click);
            // 
            // lblComplete
            // 
            this.lblComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComplete.Location = new System.Drawing.Point(155, 92);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(100, 34);
            this.lblComplete.TabIndex = 1;
            this.lblComplete.Text = "Complete";
            this.lblComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(367, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Incomplete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComNum
            // 
            this.lblComNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComNum.Location = new System.Drawing.Point(261, 92);
            this.lblComNum.Name = "lblComNum";
            this.lblComNum.Size = new System.Drawing.Size(100, 34);
            this.lblComNum.TabIndex = 3;
            this.lblComNum.Text = "number";
            this.lblComNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncomNum
            // 
            this.lblIncomNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIncomNum.Location = new System.Drawing.Point(473, 92);
            this.lblIncomNum.Name = "lblIncomNum";
            this.lblIncomNum.Size = new System.Drawing.Size(100, 34);
            this.lblIncomNum.TabIndex = 4;
            this.lblIncomNum.Text = "number";
            this.lblIncomNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFolPath
            // 
            this.txtFolPath.Location = new System.Drawing.Point(12, 41);
            this.txtFolPath.Name = "txtFolPath";
            this.txtFolPath.Size = new System.Drawing.Size(127, 20);
            this.txtFolPath.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(146, 41);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FrmAutoQc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 312);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolPath);
            this.Controls.Add(this.lblIncomNum);
            this.Controls.Add(this.lblComNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.btnAutoQc);
            this.Name = "FrmAutoQc";
            this.Text = "FrmAutoQc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutoQc;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComNum;
        private System.Windows.Forms.Label lblIncomNum;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtFolPath;
        private System.Windows.Forms.Button btnBrowse;
    }
}