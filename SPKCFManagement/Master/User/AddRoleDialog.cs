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

namespace SPKCFManagement.Master.User
{
    public partial class AddRoleDialog : DevExpress.XtraEditors.XtraForm
    {
        public AddRoleDialog()
        {
            InitializeComponent();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if(!Validator.Validate())
            {
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}