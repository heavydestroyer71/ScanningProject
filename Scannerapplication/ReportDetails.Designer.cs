namespace Scannerapplication
{
    partial class ReportDetails
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
            this.btnSum = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(27, 24);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(135, 40);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Summary Report";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(168, 24);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(135, 40);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details Report";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.Location = new System.Drawing.Point(309, 24);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(135, 40);
            this.btnEXCEL.TabIndex = 3;
            this.btnEXCEL.Text = "Export EXCEL";
            this.btnEXCEL.UseVisualStyleBackColor = true;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(450, 24);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(135, 40);
            this.btnCSV.TabIndex = 4;
            this.btnCSV.Text = "Export CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // ReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 563);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSum);
            this.Name = "ReportDetails";
            this.Text = "ReportDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.Button btnCSV;
    }
}