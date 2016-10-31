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
    public partial class UserForm : Form
    {
        ImageDbEntities db = new ImageDbEntities();
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into SEC_USERS(USER_TYPE_NO,FIRST_NAME,MID_NAME,LAST_NAME,LOGIN_ID,PASS_SALT,LOGIN_PASSWORD,IS_ACTIVE,CREATE_TIME) values(1,'" + txtFirstName.Text + "','" + txtMidName.Text + "','" + txtLastName.Text + "','" + txtLoginID.Text + "','" + txtPassword.Text + "','" + txtPassword.Text + "',1,'" + DateTime.Now + "')";
                db.ExecuteStoreCommand(insert);
            }
            catch (Exception)
            {

                MessageBox.Show("user not created please try again later!");
            }
            MessageBox.Show("User created successfully!");
            clearTextBox();
        }
        public void clearTextBox()
        {
            txtFirstName.Text = "";
            txtMidName.Text = "";
            txtLastName.Text = "";
            txtLoginID.Text = "";
            txtPassword.Text = "";
        }
    }
}
