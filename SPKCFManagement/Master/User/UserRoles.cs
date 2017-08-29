using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using SPKCFManagement.DB.MySQL.spkcms;

namespace SPKCFManagement.Master.User
{
    public partial class UserRoles : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<RolesModel> roles_coll = Session.DefaultSession.Query<RolesModel>();
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        XPQuery<PermissionModel> permission_coll = Session.DefaultSession.Query<PermissionModel>();
        XPQuery<UserHasRolesModel> user_has_roles_coll = Session.DefaultSession.Query<UserHasRolesModel>();
        XPQuery<RoleHasPermissionModel> role_has_permission_coll = Session.DefaultSession.Query<RoleHasPermissionModel>();


        public UserRoles()
        {
            InitializeComponent();
            RolesCombo.EditValueChanged += RolesCombo_EditValueChanged;
        }

        private void RolesCombo_EditValueChanged(object sender, EventArgs e)
        {
            if(RolesCombo.Text == "")
            {
                MenuTreeView.Enabled = false;
                return;
            } else
            {
                MenuTreeView.Enabled = true;
            }

            var Role = roles_coll.FirstOrDefault(r => r.role_name == RolesCombo.Text);

            /**
             * List User that have Roles
             **/
            var UserRolesList = user_has_roles_coll.Where(uhr => uhr.roleid == Role.id).Select(uhr => uhr.userid);
            UserGridControl.DataSource = user_coll.Where(u => UserRolesList.Contains(u.id));

            /**
             * List Permission that assigned to Role
             **/
            var RolePermissionsList = role_has_permission_coll.Where(rhp => rhp.roleid == Role.id).Select(rhp => rhp.permissionid);
            var Permissions = permission_coll.Where(p => RolePermissionsList.Contains(p.id));
            foreach (PermissionModel p in Permissions)
            {
                if(p.permission_type == 1)
                {
                    MenuTreeView.Nodes[p.permission_name].Checked = true;
                }

                if(p.permission_type == 2)
                {
                    var Parent = permission_coll.FirstOrDefault(pr => pr.id == p.parent);
                    MenuTreeView.Nodes[Parent.permission_name].Nodes[p.permission_name].Checked = true;
                }

                if(p.permission_type == 3)
                {
                    var Parent = permission_coll.FirstOrDefault(pr => pr.id == p.parent);
                    var Root = permission_coll.FirstOrDefault(pr => pr.id == Parent.parent);
                    MenuTreeView.Nodes[Root.permission_name].Nodes[Parent.permission_name].Nodes[p.permission_name].Checked = true;
                }
            }
        }

        private void UserRoles_Load(object sender, EventArgs e)
        {
            /**
             * Setup
             **/
            edit.Enabled = false;
            MenuTreeView.Enabled = false;

            /**
             * Add Roles to combobox
             **/
            foreach (RolesModel role in roles_coll)
            {
                RolesCombo.Properties.Items.Add(role.role_name);
            }
        }
    }
}