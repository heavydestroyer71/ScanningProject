namespace FileManagementSystem
{
    partial class FrmMain
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
            this.btnScanner = new System.Windows.Forms.Button();
            this.btnSupervisor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScanner
            // 
            this.btnScanner.Location = new System.Drawing.Point(215, 176);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(172, 69);
            this.btnScanner.TabIndex = 1;
            this.btnScanner.Text = "Scanner User";
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // btnSupervisor
            // 
            this.btnSupervisor.Location = new System.Drawing.Point(409, 176);
            this.btnSupervisor.Name = "btnSupervisor";
            this.btnSupervisor.Size = new System.Drawing.Size(172, 69);
            this.btnSupervisor.TabIndex = 2;
            this.btnSupervisor.Text = "Supervisor";
            this.btnSupervisor.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 312);
            this.Controls.Add(this.btnSupervisor);
            this.Controls.Add(this.btnScanner);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button btnSupervisor;
    }
}