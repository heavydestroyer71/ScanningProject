namespace FileManagementSystem
{
    partial class FrmSupervisor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.processBoxAndBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userEntryToolStripMenuItem,
            this.packetEntryToolStripMenuItem,
            this.processBoxAndBatchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userEntryToolStripMenuItem
            // 
            this.userEntryToolStripMenuItem.Name = "userEntryToolStripMenuItem";
            this.userEntryToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.userEntryToolStripMenuItem.Text = "User Entry";
            this.userEntryToolStripMenuItem.Click += new System.EventHandler(this.userEntryToolStripMenuItem_Click);
            // 
            // packetEntryToolStripMenuItem
            // 
            this.packetEntryToolStripMenuItem.Name = "packetEntryToolStripMenuItem";
            this.packetEntryToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.packetEntryToolStripMenuItem.Text = "Packet Entry";
            this.packetEntryToolStripMenuItem.Click += new System.EventHandler(this.packetEntryToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Wellcome";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(595, -1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 25);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(489, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(100, 25);
            this.lblGreeting.TabIndex = 20;
            this.lblGreeting.Text = "label1";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processBoxAndBatchToolStripMenuItem
            // 
            this.processBoxAndBatchToolStripMenuItem.Name = "processBoxAndBatchToolStripMenuItem";
            this.processBoxAndBatchToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.processBoxAndBatchToolStripMenuItem.Text = "Process Box and Batch";
            this.processBoxAndBatchToolStripMenuItem.Click += new System.EventHandler(this.processBoxAndBatchToolStripMenuItem_Click);
            // 
            // FrmSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 304);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSupervisor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetEntryToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.ToolStripMenuItem processBoxAndBatchToolStripMenuItem;

    }
}