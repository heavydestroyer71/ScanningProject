namespace Scannerapplication
{
    partial class UserForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMidName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMidName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstName.Location = new System.Drawing.Point(35, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMidName
            // 
            this.lblMidName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMidName.Location = new System.Drawing.Point(35, 46);
            this.lblMidName.Name = "lblMidName";
            this.lblMidName.Size = new System.Drawing.Size(100, 23);
            this.lblMidName.TabIndex = 1;
            this.lblMidName.Text = "Mid Name";
            this.lblMidName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastName.Location = new System.Drawing.Point(35, 81);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginId
            // 
            this.lblLoginId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoginId.Location = new System.Drawing.Point(35, 113);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(100, 23);
            this.lblLoginId.TabIndex = 3;
            this.lblLoginId.Text = "Login ID";
            this.lblLoginId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassword.Location = new System.Drawing.Point(35, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtMidName
            // 
            this.txtMidName.Location = new System.Drawing.Point(142, 49);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.Size = new System.Drawing.Size(165, 20);
            this.txtMidName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(142, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(142, 116);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(165, 20);
            this.txtLoginID.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(142, 196);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(165, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 466);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMidName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLoginId);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMidName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMidName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMidName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreate;
    }
}