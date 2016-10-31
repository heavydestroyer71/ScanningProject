using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scannerapplication.DB;

namespace Scannerapplication
{
    public partial class frmLogin : Form
    {
        ImageDbEntities db = new ImageDbEntities();
        public static string SetValueForUserId = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetValueForUserId = txtUserId.Text;
            if (txtUserId.Text != "" && txtPassword.Text != "")
            {
                var login = db.get_sec_users(txtUserId.Text, txtPassword.Text).FirstOrDefault();
                if (login.LOGIN_ID == txtUserId.Text && login.LOGIN_PASSWORD == txtPassword.Text)
                {
                    //MessageBox.Show("Login Successful!");
                    this.Hide();
                    TestingForm fm = new TestingForm();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Please provide user id and password correctly");
                }
            }
            else
            {
                MessageBox.Show("Please provide user id and password correctly");
            }
        }
    }
}
