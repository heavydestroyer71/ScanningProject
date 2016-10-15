using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileManagementSystem.DB;
using FileManagementSystem;

namespace FileCopyManagementSystem
{
    public partial class FrmLogin : Form
    {
        FileManagementDbEntities db = new FileManagementDbEntities();
        public static string _login_name;
        public static int _user_id;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var login_info = db.users.Where(u => u.login_id == txtUserId.Text && u.login_password == txtPassword.Text).FirstOrDefault();
                if (login_info.is_login != 1 || login_info.is_login != 0)
                {
                    if (login_info.login_id == txtUserId.Text && login_info.login_password == txtPassword.Text)
                    {
                        _login_name = login_info.login_id;
                        _user_id = login_info.user_id;
                        insert_login_info(login_info.user_id);
                        var uquery = "update [user] set is_login=1 where [user_id]=" + _user_id + "";
                        db.ExecuteStoreCommand(uquery);
                        if (login_info.user_type_id==1)
                        {
                            FrmStart frmStart = new FrmStart();
                            frmStart.Show(); 
                        }
                        if (login_info.user_type_id == 3)
                        {
                            FrmSupervisor frmPacket = new FrmSupervisor();
                            frmPacket.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide correct login id & password");
                        FrmLogin frmLogin = new FrmLogin();
                        frmLogin.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Already login this user.Please contact your administrator!");
                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("Please provide correct login id & password");
            }
        }

        private void insert_login_info(int _user_id)
        {
            login _login_info = new login
            {
                user_id = _user_id,
                login_intime=DateTime.Now,
                is_login=1
            };
            db.logins.AddObject(_login_info);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                db.SaveChanges();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
