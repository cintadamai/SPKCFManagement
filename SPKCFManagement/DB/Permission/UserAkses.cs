using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using SPKCFManagement.DB.MySQL.spkcms;

namespace SPKCFManagement.DB.Permission
{
    class UserAkses
    {
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        XPQuery<UserHasRolesModel> user_roles_coll = Session.DefaultSession.Query<UserHasRolesModel>();
        XPQuery<UserHasPermissionModel> user_permission_coll = Session.DefaultSession.Query<UserHasPermissionModel>();
        XPQuery<RolesModel> roles_coll = Session.DefaultSession.Query<RolesModel>();
        XPQuery<PermissionModel> permission_coll = Session.DefaultSession.Query<PermissionModel>();
        XPQuery<RoleHasPermissionModel> role_permission_coll = Session.DefaultSession.Query<RoleHasPermissionModel>();

        UserModel User;
        public bool Can(String permission)
        {
            bool returned = false;
            PermissionModel Permission = permission_coll.FirstOrDefault(p => p.permission_name == permission);

            /**
             * Cek Permission via Role
             **/
            var UserRoles = user_roles_coll.Where(ur => ur.userid == User.id);
            foreach(UserHasRolesModel UserRole in UserRoles)
            {
                RolesModel Role = roles_coll.FirstOrDefault(r => r.id == UserRole.roleid);
                var RoleHasPermission = role_permission_coll.Where(rp => rp.roleid == Role.id && rp.permissionid == Permission.id);
                if(RoleHasPermission.Count() > 0)
                {
                    returned = true;
                    break;
                }
            }

            /**
             * Cek Direct Akses Permission
             */
            var UserPermissions = user_permission_coll.Where(up => up.userid == User.id && up.permissionid == Permission.id);
            if(UserPermissions.Count() > 0)
            {
                returned = true;
            }

            return returned;
        }

        public bool RolesHasPermission(RolesModel roles, PermissionModel permission)
        {
            bool returned = false;

            var RolePermissions = role_permission_coll.Where(rp => rp.roleid == roles.id && rp.permissionid == permission.id);
            if(RolePermissions.Count() > 0)
            {
                returned = true;
            }
            return returned;
        }

        public void AssignRoleToUser(UserModel user, RolesModel role)
        {
            UserHasRolesModel userHasRoles = new UserHasRolesModel(Session.DefaultSession);
            userHasRoles.userid = user.id;
            userHasRoles.roleid = role.id;
            userHasRoles.Save();
        }

        public void RevokeRoleFromUser(UserModel user, RolesModel role)
        {
            UserHasRolesModel userHasRoles = user_roles_coll.FirstOrDefault(ur => ur.userid == user.id && ur.roleid == role.id);
            userHasRoles.Delete();
        }

        public void AddPermissionToUser(UserModel user, PermissionModel permission)
        {
            UserHasPermissionModel userHasPermission = new UserHasPermissionModel(Session.DefaultSession);
            userHasPermission.userid = user.id;
            userHasPermission.permissionid = permission.id;
            userHasPermission.Save();
        }

        public void RemovePermissionFromUser(UserModel user, PermissionModel permission)
        {
            UserHasPermissionModel userHasPermission = user_permission_coll.FirstOrDefault(up => up.userid == user.id && up.permissionid == permission.id);
            userHasPermission.Delete();
        }

        public void AddPermissionToRole(RolesModel role, PermissionModel permission)
        {
            RoleHasPermissionModel roleHasPermission = new RoleHasPermissionModel(Session.DefaultSession);
            roleHasPermission.roleid = role.id;
            roleHasPermission.permissionid = permission.id;
            roleHasPermission.Save();
        }

        public void RemovePermissionFromRole(RolesModel role, PermissionModel permission)
        {
            RoleHasPermissionModel roleHasPermission = role_permission_coll.FirstOrDefault(rp => rp.roleid == role.id && rp.permissionid == permission.id);
            roleHasPermission.Delete();
        }


        public UserAkses() => User = Login.User;

    }
}
