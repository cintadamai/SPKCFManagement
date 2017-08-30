using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using SPKCFManagement.DB.Permission;

namespace SPKCFManagement.Master
{
    public partial class Master : DevExpress.XtraEditors.XtraForm
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            CekMenu();
        }

        private void CekMenu()
        {
            UserAkses userAkses = new UserAkses();
            if(userAkses.Can("input_user"))
            {
                userpagegroup.Enabled = true;
                input_user.Enabled = true;
            }

            if(userAkses.Can("user_roles"))
            {
                userpagegroup.Enabled = true;
                user_roles.Enabled = true;
            }

            if(userAkses.Can("user_permission"))
            {
                userpagegroup.Enabled = true;
                user_permission.Enabled = true;
            }

            if(userAkses.Can("user_branch"))
            {
                userpagegroup.Enabled = true;
                user_branch.Enabled = true;
            }
        }

        private void Input_user_ItemClick(object sender, ItemClickEventArgs e)
        {
            User.InputUser f = new User.InputUser
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }

        private void User_roles_ItemClick(object sender, ItemClickEventArgs e)
        {
            User.UserRoles f = new User.UserRoles
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }

        private void User_branch_ItemClick(object sender, ItemClickEventArgs e)
        {
            User.UserBranch f = new User.UserBranch
            {
                MdiParent = this
            };
            f.Show();
            f.Focus();
        }
    }
}