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
using SPKCFManagement.DB.MySQL.spkcms;
using DevExpress.Xpo;

namespace SPKCFManagement.Master.User
{
    public partial class UserLookupDialog : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        

        public UserModel User;
        public UserLookupDialog()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            var selectedID = gridView1.GetFocusedRowCellValue(colid);
            User = user_coll.FirstOrDefault(u => u.id == Convert.ToInt64(selectedID));
            DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void UserLookupDialog_Load(object sender, EventArgs e)
        {

        }
    }
}