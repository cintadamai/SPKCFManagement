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

namespace SPKCFManagement.Master.Team
{
    public partial class Sales : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<SalesModel> sales_coll = Session.DefaultSession.Query<SalesModel>();
        XPQuery<SalesHeadModel> sales_head_coll = Session.DefaultSession.Query<SalesHeadModel>();
        XPQuery<SalesViewModel> sales_view_coll = Session.DefaultSession.Query<SalesViewModel>();

        public Sales()
        {
            InitializeComponent();
            SalesGridView.DoubleClick += SalesGridView_DoubleClick;
        }

        private void SalesGridView_DoubleClick(object sender, EventArgs e)
        {
            if(SalesGridView.RowCount < 1)
            {
                return;
            }
            var selectedID = SalesGridView.GetFocusedRowCellValue(colkode_sales);
            SalesModel sales = sales_coll.FirstOrDefault(s => s.kode_sales == Convert.ToInt64(selectedID.ToString()));

            kode_sales.Text = sales.kode_sales.ToString();
            nama_sales.Text = sales.nama_sales;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            nama_sales.Enabled = false;
            kode_sh.Enabled = false;

            edit.Enabled = false;
            hapus.Enabled = false;

            SalesGridControl.DataSource = sales_view_coll.Where(svc => svc.salesbranch == Login.User.branchid);

            IQueryable<SalesHeadModel> salesHead = sales_head_coll.Where(sh => sh.branchid == Login.User.branchid);

            foreach(SalesHeadModel SH in salesHead)
            {
                kode_sh.Properties.Items.Add(SH.nama_sh);
            }
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            nama_sales.Enabled = true;
            kode_sh.Enabled = true;

            kode_sales.ResetText();
            nama_sales.ResetText();

            nama_sales.Focus();

            edit.Enabled = false;
            hapus.Enabled = false;
        }

        private void SalesGridControl_Click(object sender, EventArgs e)
        {

        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!InputValidator.Validate())
            {
                return;
            }

            SalesModel sales;
            if(kode_sh.Text == "")
            {
                sales = new SalesModel(Session.DefaultSession);
            }
            else
            {
                sales = sales_coll.FirstOrDefault(s => s.kode_sales == Convert.ToInt64(kode_sales.Text));
            }

            sales.nama_sales = nama_sales.Text;
            sales.kode_sh = sales_head_coll.FirstOrDefault(sh => sh.nama_sh == kode_sh.Text).kode_sh;
            sales.branchid = Login.User.branchid;
            sales.Save();

            nama_sales.Enabled = false;
            kode_sh.Enabled = false;

            edit.Enabled = true;
            hapus.Enabled = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            nama_sales.Enabled = true;
            kode_sh.Enabled = true;

            nama_sales.Focus();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if(kode_sales.Text == "")
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                SalesModel sales = sales_coll.FirstOrDefault(s => s.kode_sales == Convert.ToInt64(kode_sales.Text));
                sales.Delete();
                tambah.PerformClick();
            }
        }
    }
}