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
    public partial class UserBranch : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<BranchModel> branch_coll = Session.DefaultSession.Query<BranchModel>();
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        XPQuery<UserHasBranchModel> user_has_branch_coll = Session.DefaultSession.Query<UserHasBranchModel>();

        UserAkses Akses;
        public UserBranch()
        {
            InitializeComponent();
            id.ButtonClick += Id_ButtonClick;
            UserGridView.FocusedRowChanged += UserGridView_FocusedRowChanged;
            UserGridView.RowClick += UserGridView_RowClick;
            Akses = new UserAkses();
        }

        private void UserGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadBranchGrid();
        }

        private void UserGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadBranchGrid();
        }

        private void LoadBranchGrid()
        {
            var selectedUser = UserGridView.GetFocusedRowCellValue(colname);
            UserModel User = user_coll.FirstOrDefault(u => u.name == selectedUser.ToString());
            var UserBranchList = user_has_branch_coll.Where(uhb => uhb.userid == User.id).Select(uhb => uhb.branchid);
            var UserBranches = branch_coll.Where(b => UserBranchList.Contains(b.id));
            var NotUserBranches = branch_coll.Where(b => !UserBranchList.Contains(b.id));

            BranchGridControl.DataSource = UserBranches;

            BranchComboBoxEdit.Properties.Items.Clear();
            if(UserGridView.RowCount > 0)
            {
                foreach (BranchModel branch in NotUserBranches)
                {
                    BranchComboBoxEdit.Properties.Items.Add(branch.nama);
                }
            }
        }

        private void Id_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BranchLookupDialog branchLookup = new BranchLookupDialog();
            DialogResult dialog = branchLookup.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                id.Text = branchLookup.branch.id.ToString();
                nama.Text = branchLookup.branch.nama;
                alamat.Text = branchLookup.branch.alamat;
                no_telepon.Text = branchLookup.branch.no_telepon;

                edit.Enabled = true;
                hapus.Enabled = true;
            }
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            nama.Enabled = true;
            alamat.Enabled = true;
            no_telepon.Enabled = true;

            nama.Focus();

            edit.Enabled = false;
            hapus.Enabled = false;

            id.ResetText();
            nama.ResetText();
            alamat.ResetText();
            no_telepon.ResetText();
        }

        private void UserBranch_Load(object sender, EventArgs e)
        {
            edit.Enabled = false;
            hapus.Enabled = false;

            nama.Enabled = false;
            alamat.Enabled = false;
            no_telepon.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!InputValidator.Validate())
            {
                return;
            }

            BranchModel branch;
            if(id.Text == "")
            {
                branch = new BranchModel(Session.DefaultSession);
            }
            else
            {
                branch = branch_coll.FirstOrDefault(b => b.id == Convert.ToInt64(id.Text));
            }

            branch.nama = nama.Text;
            branch.alamat = alamat.Text;
            branch.no_telepon = no_telepon.Text;
            branch.Save();
            id.Text = branch.id.ToString();

            MessageBox.Show("Berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            nama.Enabled = false;
            alamat.Enabled = false;
            no_telepon.Enabled = false;

            edit.Enabled = true;
            hapus.Enabled = true;

            LoadBranchGrid();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            nama.Enabled = true;
            alamat.Enabled = true;
            no_telepon.Enabled = true;
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin hapus Branch ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                BranchModel branch = branch_coll.FirstOrDefault(b => b.id == Convert.ToInt64(id.Text));
                branch.Delete();
                tambah.PerformClick();
            }
        }

        private void AddBranch_Click(object sender, EventArgs e)
        {
            if(!UserBranchValidator.Validate() || UserGridView.RowCount < 1)
            {
                return;
            }

            var SelectedUser = UserGridView.GetFocusedRowCellValue(colname);
            BranchModel branch = branch_coll.FirstOrDefault(b => b.nama == BranchComboBoxEdit.Text);
            UserModel user = user_coll.FirstOrDefault(u => u.name == SelectedUser.ToString());

            Akses.AddBranchForUser(user, branch);
            LoadBranchGrid();

            BranchComboBoxEdit.ResetText();
        }

        private void RemoveBranch_Click(object sender, EventArgs e)
        {
            if(UserGridView.RowCount < 1 || BranchGridView.RowCount < 1)
            {
                return;
            }

            var SelectedUser = UserGridView.GetFocusedRowCellValue(colname);
            var SelectedBranch = BranchGridView.GetFocusedRowCellValue(colid);
            BranchModel branch = branch_coll.FirstOrDefault(b => b.id == Convert.ToInt64(SelectedBranch));
            UserModel user = user_coll.FirstOrDefault(u => u.name == SelectedUser.ToString());

            Akses.RemoveBranchFromUser(user, branch);
            LoadBranchGrid();
        }
    }
}