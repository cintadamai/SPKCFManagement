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
using SPKCFManagement.DB.MySQL.spkcms;

namespace SPKCFManagement.Master.User
{
    public partial class InputUser : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        XPQuery<BranchModel> branch_coll = Session.DefaultSession.Query<BranchModel>();
        public InputUser()
        {
            InitializeComponent();
            id.ButtonClick += Id_ButtonClick;
        }

        private void Id_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UserLookupDialog f = new UserLookupDialog();
            DialogResult dialog = f.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                id.Text = f.User.id.ToString();
                name.Text = f.User.name;
                branch.Text = branch_coll.FirstOrDefault(b => b.id == f.User.branchid).nama;
                isactive.Checked = f.User.isactive;

                edit.Enabled = true;
                hapus.Enabled = true;
            }
        }

        private void InputUser_Load(object sender, EventArgs e)
        {
            id.Focus();
            edit.Enabled = false;
            hapus.Enabled = false;
        }
    }
}