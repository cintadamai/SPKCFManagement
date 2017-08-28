using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;
using SPKCFManagement.DB.MySQL.spkcms;
using System.Linq;
using DevExpress.XtraEditors;
using SPKCFManagement.DB.Permission;

namespace SPKCFManagement
{
    public partial class Login : SplashScreen
    {
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();

        public static UserModel User;
        public Login()
        {
            InitializeComponent();
            password.KeyDown += Password_KeyDown;
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                masuk.PerformClick();
            }
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Masuk Btn Clicked
         * ActionLogin Performed
         **/
        private void masuk_Click(object sender, EventArgs e)
        {
            var c = user_coll.Where(x => x.name == username.Text && x.password == password.Text && x.isactive == true);

            if(c.Count() == 1)
            {
                User = c.First();
                MessageBox.Show(String.Format("Selamat datang {0}.", User.name), "Berhasil", MessageBoxButtons.OK);
                menuControl.Enabled = true;
                username.Enabled = false;
                password.Enabled = false;
                masuk.Enabled = false;
                afterlogin();
            }
            else if(c.Count() > 1)
            {
                MessageBox.Show("Duplicate user, hubungi sistem administrator.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * After Login
         * Read Role and Permission from database
         * then assign it to menu
         **/
        protected void afterlogin()
        {
            UserAkses userAkses = new UserAkses();

            // Master
            if(userAkses.Can("master"))
            {
                master.Enabled = true;
            }

            // SPK
            if(userAkses.Can("spk"))
            {
                spk.Enabled = true;
            }

            // Pelunasan
            if(userAkses.Can("pelunasan"))
            {
                pelunasan.Enabled = true;
            }


            //Utility
            if(userAkses.Can("utility"))
            {
                utility.Enabled = true;
            }
        }

        private void master_Click(object sender, EventArgs e)
        {
            Master.Master f = new Master.Master();
            f.Show();
            f.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            username.Focus();
        }
    }
}