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
    public partial class BranchLookupDialog : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<BranchModel> branch_coll = Session.DefaultSession.Query<BranchModel>();

        public BranchModel branch;
        public BranchLookupDialog()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            var SelectedID = gridView1.GetFocusedRowCellValue(colid);
            branch = branch_coll.FirstOrDefault(b => b.id == Convert.ToInt64(SelectedID));
            DialogResult = DialogResult.OK;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}