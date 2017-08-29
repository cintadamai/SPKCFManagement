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
            branch.ButtonClick += Branch_ButtonClick;
        }

        private void Branch_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BranchLookupDialog f = new BranchLookupDialog();
            DialogResult dialog = f.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                branch.Text = f.branch.nama;
            }
        }

        private void Id_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UserLookupDialog f = new UserLookupDialog();
            DialogResult dialog = f.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                id.Text = f.User.id.ToString();
                name.Text = f.User.name;
                email.Text = f.User.email;
                branch.Text = branch_coll.FirstOrDefault(b => b.id == f.User.branchid).nama;
                isactive.Checked = f.User.isactive;

                name.Enabled = false;
                email.Enabled = false;
                branch.Enabled = false;
                isactive.Enabled = false;

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

        private void tambah_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
            email.Enabled = true;
            branch.Enabled = true;
            isactive.Enabled = true;

            id.ResetText();
            name.ResetText();
            email.ResetText();
            branch.ResetText();

            isactive.Checked = false;
            simpan.Enabled = true;
            edit.Enabled = false;
            hapus.Enabled = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
            email.Enabled = true;
            branch.Enabled = true;
            isactive.Enabled = true;
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            var yakin = MessageBox.Show("Yakin?", "Hapus Data User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(yakin == DialogResult.Yes)
            {
                UserModel User = user_coll.FirstOrDefault(u => u.id == Convert.ToInt64(id.Text));
                User.Delete();
                tambah.PerformClick();
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if(!Validator.Validate())
            {
                return;
            }

            UserModel User;
            if(id.Text != "")
            {
                User = user_coll.FirstOrDefault(u => u.id == Convert.ToInt64(id.Text));
            } else
            {
                User = new UserModel(Session.DefaultSession);
            }

            User.name = name.Text;
            User.email = email.Text;
            User.isactive = isactive.Checked;
            User.branchid = branch_coll.FirstOrDefault(b => b.nama == branch.Text).id;
            User.Save();
            MessageBox.Show("Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            id.Text = User.id.ToString();

            name.Enabled = false;
            email.Enabled = false;
            branch.Enabled = false;
            isactive.Enabled = false;

            edit.Enabled = true;
            hapus.Enabled = true;
        }
    }
}