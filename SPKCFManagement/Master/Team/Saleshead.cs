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
using DevExpress.Data.Filtering;

namespace SPKCFManagement.Master.Team
{
    public partial class Saleshead : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<SalesHeadModel> sh_coll = Session.DefaultSession.Query<SalesHeadModel>();
        UserModel user;
        public Saleshead()
        {
            InitializeComponent();
            SHGridView.DoubleClick += SHGridView_DoubleClick;
        }

        private void SHGridView_DoubleClick(object sender, EventArgs e)
        {
            if(SHGridView.RowCount < 1)
            {
                return;
            }

            var selectedID = SHGridView.GetFocusedRowCellValue(colkode_sh);
            SalesHeadModel salesHead = sh_coll.FirstOrDefault(sh => sh.kode_sh == Convert.ToInt64(selectedID));
            kode_sh.Text = salesHead.kode_sh.ToString();
            nama_sh.Text = salesHead.nama_sh;

            edit.Enabled = true;
            hapus.Enabled = true;
        }

        private void SHGridControl_Click(object sender, EventArgs e)
        {

        }

        private void Saleshead_Load(object sender, EventArgs e)
        {
            edit.Enabled = false;
            hapus.Enabled = false;

            user = Login.User;
            SHGridControl.DataSource = sh_coll.Where(sh => sh.branchid == user.branchid);
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            nama_sh.Enabled = true;
            nama_sh.Focus();

            nama_sh.Text = "";
            kode_sh.Text = "";

            edit.Enabled = false;
            hapus.Enabled = false;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            nama_sh.Enabled = true;
            nama_sh.Focus();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if(kode_sh.Text == "")
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                XPQuery<SalesHeadModel> sha = SHUnitOfWork.Query<SalesHeadModel>();
                SalesHeadModel salesHead = sha.FirstOrDefault(sh => sh.kode_sh == Convert.ToInt64(kode_sh.Text));
                SHUnitOfWork.Delete(salesHead);
                SHUnitOfWork.CommitChanges();
            }

            kode_sh.Text = "";
            nama_sh.Text = "";
            edit.Enabled = false;
            hapus.Enabled = false;
            RefreshDataGrid();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!InputValidator.Validate())
            {
                return;
            }

            SalesHeadModel salesHead;
            if(kode_sh.Text == "")
            {
                salesHead = new SalesHeadModel(Session.DefaultSession);
            }
            else
            {
                salesHead = sh_coll.FirstOrDefault(sh => sh.kode_sh == Convert.ToInt64(kode_sh.Text));
            }

            salesHead.nama_sh = nama_sh.Text;
            salesHead.branchid = Login.User.branchid;
            salesHead.Save();
            kode_sh.Text = salesHead.kode_sh.ToString();

            nama_sh.Enabled = false;

            edit.Enabled = true;
            hapus.Enabled = true;

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            SHGridControl.DataSource = sh_coll.Where(sh => sh.branchid == user.branchid);
        }
    }
}