namespace SPKCFManagement.Master.User
{
    partial class UserBranch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBranch));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.UserGridControl = new DevExpress.XtraGrid.GridControl();
            this.UserView = new DevExpress.Xpo.XPView(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.removeBranch = new DevExpress.XtraEditors.SimpleButton();
            this.addBranch = new DevExpress.XtraEditors.SimpleButton();
            this.BranchComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BranchGridControl = new DevExpress.XtraGrid.GridControl();
            this.BranchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalamat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_telepon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpan = new DevExpress.XtraEditors.SimpleButton();
            this.hapus = new DevExpress.XtraEditors.SimpleButton();
            this.edit = new DevExpress.XtraEditors.SimpleButton();
            this.tambah = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.no_telepon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.ButtonEdit();
            this.alamat = new DevExpress.XtraEditors.MemoEdit();
            this.InputValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.UserBranchValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBranchValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.UserGridControl);
            this.panelControl1.Location = new System.Drawing.Point(13, 195);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(234, 329);
            this.panelControl1.TabIndex = 16;
            // 
            // UserGridControl
            // 
            this.UserGridControl.DataSource = this.UserView;
            this.UserGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridControl.Location = new System.Drawing.Point(2, 2);
            this.UserGridControl.MainView = this.UserGridView;
            this.UserGridControl.Name = "UserGridControl";
            this.UserGridControl.Size = new System.Drawing.Size(230, 325);
            this.UserGridControl.TabIndex = 0;
            this.UserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserGridView});
            // 
            // UserView
            // 
            this.UserView.ObjectType = typeof(SPKCFManagement.DB.MySQL.spkcms.UserModel);
            this.UserView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("id", DevExpress.Xpo.SortDirection.None, "[id]", false, true),
            new DevExpress.Xpo.ViewProperty("name", DevExpress.Xpo.SortDirection.None, "[name]", false, true),
            new DevExpress.Xpo.ViewProperty("email", DevExpress.Xpo.SortDirection.None, "[email]", false, true),
            new DevExpress.Xpo.ViewProperty("password", DevExpress.Xpo.SortDirection.None, "[password]", false, true),
            new DevExpress.Xpo.ViewProperty("branchid", DevExpress.Xpo.SortDirection.None, "[branchid]", false, true),
            new DevExpress.Xpo.ViewProperty("isactive", DevExpress.Xpo.SortDirection.None, "[isactive]", false, true)});
            this.UserView.Session = this.unitOfWork1;
            this.UserView.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[id]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // UserGridView
            // 
            this.UserGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.UserGridView.GridControl = this.UserGridControl;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserGridView.OptionsBehavior.Editable = false;
            this.UserGridView.OptionsBehavior.ReadOnly = true;
            this.UserGridView.OptionsFind.AlwaysVisible = true;
            // 
            // colname
            // 
            this.colname.Caption = "Username";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.removeBranch);
            this.panelControl2.Controls.Add(this.addBranch);
            this.panelControl2.Controls.Add(this.BranchComboBoxEdit);
            this.panelControl2.Controls.Add(this.BranchGridControl);
            this.panelControl2.Location = new System.Drawing.Point(253, 195);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(543, 329);
            this.panelControl2.TabIndex = 17;
            // 
            // removeBranch
            // 
            this.removeBranch.Location = new System.Drawing.Point(382, 6);
            this.removeBranch.Name = "removeBranch";
            this.removeBranch.Size = new System.Drawing.Size(75, 23);
            this.removeBranch.TabIndex = 4;
            this.removeBranch.Text = "Hapus";
            this.removeBranch.Click += new System.EventHandler(this.RemoveBranch_Click);
            // 
            // addBranch
            // 
            this.addBranch.Location = new System.Drawing.Point(301, 6);
            this.addBranch.Name = "addBranch";
            this.addBranch.Size = new System.Drawing.Size(75, 23);
            this.addBranch.TabIndex = 3;
            this.addBranch.Text = "Tambahkan";
            this.addBranch.Click += new System.EventHandler(this.AddBranch_Click);
            // 
            // BranchComboBoxEdit
            // 
            this.BranchComboBoxEdit.Location = new System.Drawing.Point(5, 8);
            this.BranchComboBoxEdit.Name = "BranchComboBoxEdit";
            this.BranchComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BranchComboBoxEdit.Size = new System.Drawing.Size(290, 20);
            this.BranchComboBoxEdit.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.UserBranchValidator.SetValidationRule(this.BranchComboBoxEdit, conditionValidationRule1);
            // 
            // BranchGridControl
            // 
            this.BranchGridControl.Location = new System.Drawing.Point(5, 34);
            this.BranchGridControl.MainView = this.BranchGridView;
            this.BranchGridControl.Name = "BranchGridControl";
            this.BranchGridControl.Size = new System.Drawing.Size(533, 288);
            this.BranchGridControl.TabIndex = 1;
            this.BranchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BranchGridView});
            // 
            // BranchGridView
            // 
            this.BranchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnama,
            this.colalamat,
            this.colno_telepon});
            this.BranchGridView.GridControl = this.BranchGridControl;
            this.BranchGridView.Name = "BranchGridView";
            this.BranchGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.BranchGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.BranchGridView.OptionsBehavior.Editable = false;
            this.BranchGridView.OptionsBehavior.ReadOnly = true;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 81;
            // 
            // colnama
            // 
            this.colnama.Caption = "Nama Branch";
            this.colnama.FieldName = "nama";
            this.colnama.Name = "colnama";
            this.colnama.Visible = true;
            this.colnama.VisibleIndex = 1;
            this.colnama.Width = 143;
            // 
            // colalamat
            // 
            this.colalamat.Caption = "Alamat";
            this.colalamat.FieldName = "alamat";
            this.colalamat.Name = "colalamat";
            this.colalamat.Visible = true;
            this.colalamat.VisibleIndex = 2;
            this.colalamat.Width = 148;
            // 
            // colno_telepon
            // 
            this.colno_telepon.Caption = "No Telepon";
            this.colno_telepon.FieldName = "no_telepon";
            this.colno_telepon.Name = "colno_telepon";
            this.colno_telepon.Visible = true;
            this.colno_telepon.VisibleIndex = 3;
            this.colno_telepon.Width = 143;
            // 
            // simpan
            // 
            this.simpan.ImageOptions.Image = global::SPKCFManagement.Properties.Resources.apply_32x32;
            this.simpan.Location = new System.Drawing.Point(117, 12);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(100, 40);
            this.simpan.TabIndex = 21;
            this.simpan.Text = "Simpan";
            this.simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // hapus
            // 
            this.hapus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hapus.ImageOptions.Image")));
            this.hapus.Location = new System.Drawing.Point(329, 12);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(100, 40);
            this.hapus.TabIndex = 20;
            this.hapus.Text = "Hapus";
            this.hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // edit
            // 
            this.edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("edit.ImageOptions.Image")));
            this.edit.Location = new System.Drawing.Point(223, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 40);
            this.edit.TabIndex = 19;
            this.edit.Text = "Edit";
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // tambah
            // 
            this.tambah.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tambah.ImageOptions.Image")));
            this.tambah.Location = new System.Drawing.Point(11, 12);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(100, 40);
            this.tambah.TabIndex = 18;
            this.tambah.Text = "Tambah";
            this.tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.no_telepon);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.nama);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.id);
            this.panelControl3.Controls.Add(this.alamat);
            this.panelControl3.Location = new System.Drawing.Point(13, 58);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(781, 131);
            this.panelControl3.TabIndex = 22;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(240, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "No Telepon";
            // 
            // no_telepon
            // 
            this.no_telepon.Enabled = false;
            this.no_telepon.Location = new System.Drawing.Point(326, 90);
            this.no_telepon.Name = "no_telepon";
            this.no_telepon.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.no_telepon.Properties.Appearance.Options.UseBackColor = true;
            this.no_telepon.Size = new System.Drawing.Size(152, 20);
            this.no_telepon.TabIndex = 6;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Harus di isi.";
            this.InputValidator.SetValidationRule(this.no_telepon, conditionValidationRule2);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(240, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Alamat";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(240, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nama Branch";
            // 
            // nama
            // 
            this.nama.Enabled = false;
            this.nama.Location = new System.Drawing.Point(326, 12);
            this.nama.Name = "nama";
            this.nama.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama.Properties.Appearance.Options.UseBackColor = true;
            this.nama.Size = new System.Drawing.Size(209, 20);
            this.nama.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Harus di isi.";
            this.InputValidator.SetValidationRule(this.nama, conditionValidationRule3);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(68, 12);
            this.id.Name = "id";
            this.id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.id.Size = new System.Drawing.Size(87, 20);
            this.id.TabIndex = 0;
            // 
            // alamat
            // 
            this.alamat.Enabled = false;
            this.alamat.Location = new System.Drawing.Point(326, 38);
            this.alamat.Name = "alamat";
            this.alamat.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.alamat.Properties.Appearance.Options.UseBackColor = true;
            this.alamat.Size = new System.Drawing.Size(240, 46);
            this.alamat.TabIndex = 4;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Harus di isi.";
            this.InputValidator.SetValidationRule(this.alamat, conditionValidationRule4);
            // 
            // UserBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 533);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "UserBranch";
            this.Text = " User Branch";
            this.Load += new System.EventHandler(this.UserBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_telepon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alamat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBranchValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl UserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private DevExpress.XtraGrid.GridControl BranchGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BranchGridView;
        private DevExpress.Xpo.XPView UserView;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.SimpleButton simpan;
        private DevExpress.XtraEditors.SimpleButton hapus;
        private DevExpress.XtraEditors.SimpleButton edit;
        private DevExpress.XtraEditors.SimpleButton tambah;
        private DevExpress.XtraEditors.ComboBoxEdit BranchComboBoxEdit;
        private DevExpress.XtraEditors.SimpleButton removeBranch;
        private DevExpress.XtraEditors.SimpleButton addBranch;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit no_telepon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit nama;
        private DevExpress.XtraEditors.ButtonEdit id;
        private DevExpress.XtraEditors.MemoEdit alamat;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider InputValidator;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnama;
        private DevExpress.XtraGrid.Columns.GridColumn colalamat;
        private DevExpress.XtraGrid.Columns.GridColumn colno_telepon;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider UserBranchValidator;
    }
}