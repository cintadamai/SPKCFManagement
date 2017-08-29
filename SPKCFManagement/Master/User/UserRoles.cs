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
using SPKCFManagement.DB.Permission;

namespace SPKCFManagement.Master.User
{
    public partial class UserRoles : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<RolesModel> roles_coll = Session.DefaultSession.Query<RolesModel>();
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        XPQuery<PermissionModel> permission_coll = Session.DefaultSession.Query<PermissionModel>();
        XPQuery<UserHasRolesModel> user_has_roles_coll = Session.DefaultSession.Query<UserHasRolesModel>();
        XPQuery<RoleHasPermissionModel> role_has_permission_coll = Session.DefaultSession.Query<RoleHasPermissionModel>();

        UserAkses Akses;
        public UserRoles()
        {
            InitializeComponent();
            RolesCombo.EditValueChanged += RolesCombo_EditValueChanged;
            Akses = new UserAkses();
            simpan.Click += Simpan_Click;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            
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

        private void AddUser_Click(object sender, EventArgs e)
        {
            if(!AddUserValidator.Validate())
            {
                return;
            }
            RolesModel roles = roles_coll.FirstOrDefault(r => r.role_name == RolesCombo.Text);
            UserLookupDialog userLookup = new UserLookupDialog();
            DialogResult dialog = userLookup.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                Akses.AssignRoleToUser(userLookup.User, roles);
                LoadUserGrid();
            }
        }

        public void LoadUserGrid()
        {
            var Role = roles_coll.FirstOrDefault(r => r.role_name == RolesCombo.Text);
            var UserRolesList = user_has_roles_coll.Where(uhr => uhr.roleid == Role.id).Select(uhr => uhr.userid);
            UserGridControl.DataSource = user_coll.Where(u => UserRolesList.Contains(u.id));
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            if (!AddUserValidator.Validate())
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var selected = UserGridView.GetFocusedRowCellValue(UserNameColumn);
                UserModel userModel = user_coll.FirstOrDefault(u => u.name == selected.ToString());
                RolesModel roles = roles_coll.FirstOrDefault(r => r.role_name == RolesCombo.Text);
                Akses.RevokeRoleFromUser(userModel, roles);
                LoadUserGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if(!AddUserValidator.Validate())
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin untuk menghapus Role ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                RolesModel roles = roles_coll.FirstOrDefault(r => r.role_name == RolesCombo.Text);
                roles.Delete();
                LoadRoleList();
                RolesCombo.ResetText();
            }
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            AddRoleDialog roleDialog = new AddRoleDialog();
            DialogResult dialog = roleDialog.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                RolesModel roles = new RolesModel(Session.DefaultSession);
                roles.role_name = roleDialog.role_name.Text;
                roles.Save();
                LoadRoleList();
            }
        }

        private void LoadRoleList()
        {
            RolesCombo.Properties.Items.Clear();
            foreach (RolesModel role in roles_coll)
            {
                RolesCombo.Properties.Items.Add(role.role_name);
            }
        }
    }
}