using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileManagementSystem.DB;

namespace FileManagementSystem
{
    public partial class FrmUser : Form
    {
        FileManagementDbEntities db = new FileManagementDbEntities();
        public FrmUser()
        {
            InitializeComponent();
            load_userType();
            load_gridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert_user();
            MessageBox.Show("User add successfully!");
        }

        public void insert_user()
        {
            user _user = new user
            {
                user_name=txtUserName.Text,
                user_type_id =(int)cbUserType.SelectedValue,
                login_id=txtLoginId.Text,
                login_password=txtLoginPassword.Text,
                create_date=DateTime.Now

            };
            db.users.AddObject(_user);
            db.SaveChanges();

            load_gridview();
        }

        private void load_gridview()
        {
            var query = "select * from [user]";
            var gvData = db.ExecuteStoreQuery<user>(query).ToList();
            dataGridView1.DataSource = gvData;
        }
        private void load_userType()
        {
            var query = "select * from user_type";
            List<user_type> gvData = db.ExecuteStoreQuery<user_type>(query).ToList();
            cbUserType.DataSource=gvData;
            cbUserType.DisplayMember = "user_type_name";
            cbUserType.ValueMember = "user_type_id";
        }
    }
}
