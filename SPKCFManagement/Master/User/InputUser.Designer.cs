namespace SPKCFManagement.Master.User
{
    partial class InputUser
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputUser));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.Validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.email = new DevExpress.XtraEditors.TextEdit();
            this.name = new DevExpress.XtraEditors.TextEdit();
            this.tambah = new DevExpress.XtraEditors.SimpleButton();
            this.edit = new DevExpress.XtraEditors.SimpleButton();
            this.simpan = new DevExpress.XtraEditors.SimpleButton();
            this.hapus = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.branchView = new DevExpress.Xpo.XPView(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.id = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.isactive = new DevExpress.XtraEditors.CheckEdit();
            this.branch = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isactive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(106, 73);
            this.email.Name = "email";
            this.email.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.email.Properties.Appearance.Options.UseBackColor = true;
            this.email.Size = new System.Drawing.Size(163, 20);
            this.email.TabIndex = 13;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.email, conditionValidationRule1);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(106, 47);
            this.name.Name = "name";
            this.name.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.name.Properties.Appearance.Options.UseBackColor = true;
            this.name.Size = new System.Drawing.Size(163, 20);
            this.name.TabIndex = 12;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.name, conditionValidationRule2);
            // 
            // tambah
            // 
            this.tambah.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tambah.ImageOptions.Image")));
            this.tambah.Location = new System.Drawing.Point(12, 12);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(100, 40);
            this.tambah.TabIndex = 0;
            this.tambah.Text = "Tambah";
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // edit
            // 
            this.edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("edit.ImageOptions.Image")));
            this.edit.Location = new System.Drawing.Point(224, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 40);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // simpan
            // 
            this.simpan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpan.ImageOptions.Image")));
            this.simpan.Location = new System.Drawing.Point(118, 12);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(100, 40);
            this.simpan.TabIndex = 2;
            this.simpan.Text = "Simpan";
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // hapus
            // 
            this.hapus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hapus.ImageOptions.Image")));
            this.hapus.Location = new System.Drawing.Point(330, 12);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(100, 40);
            this.hapus.TabIndex = 3;
            this.hapus.Text = "Hapus";
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.branch);
            this.panelControl1.Controls.Add(this.id);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.isactive);
            this.panelControl1.Controls.Add(this.email);
            this.panelControl1.Controls.Add(this.name);
            this.panelControl1.Location = new System.Drawing.Point(12, 58);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(547, 344);
            this.panelControl1.TabIndex = 4;
            // 
            // branchView
            // 
            this.branchView.ObjectType = typeof(SPKCFManagement.DB.MySQL.spkcms.BranchModel);
            this.branchView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("id", DevExpress.Xpo.SortDirection.None, "[id]", false, true),
            new DevExpress.Xpo.ViewProperty("nama", DevExpress.Xpo.SortDirection.None, "[nama]", false, true),
            new DevExpress.Xpo.ViewProperty("alamat", DevExpress.Xpo.SortDirection.None, "[alamat]", false, true),
            new DevExpress.Xpo.ViewProperty("no_telepon", DevExpress.Xpo.SortDirection.None, "[no_telepon]", false, true),
            new DevExpress.Xpo.ViewProperty("created_at", DevExpress.Xpo.SortDirection.None, "[created_at]", false, true),
            new DevExpress.Xpo.ViewProperty("updated_at", DevExpress.Xpo.SortDirection.None, "[updated_at]", false, true),
            new DevExpress.Xpo.ViewProperty("created_by", DevExpress.Xpo.SortDirection.None, "[created_by]", false, true),
            new DevExpress.Xpo.ViewProperty("updated_by", DevExpress.Xpo.SortDirection.None, "[updated_by]", false, true)});
            this.branchView.Session = this.unitOfWork1;
            this.branchView.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[id]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(106, 21);
            this.id.Name = "id";
            this.id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.id.Size = new System.Drawing.Size(75, 20);
            this.id.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(37, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Branch";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(37, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Email";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "ID";
            // 
            // isactive
            // 
            this.isactive.Location = new System.Drawing.Point(106, 125);
            this.isactive.Name = "isactive";
            this.isactive.Properties.Caption = "Active";
            this.isactive.Size = new System.Drawing.Size(75, 19);
            this.isactive.TabIndex = 15;
            // 
            // branch
            // 
            this.branch.Location = new System.Drawing.Point(106, 99);
            this.branch.Name = "branch";
            this.branch.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.branch.Properties.Appearance.Options.UseBackColor = true;
            this.branch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.branch.Size = new System.Drawing.Size(177, 20);
            this.branch.TabIndex = 16;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.branch, conditionValidationRule3);
            // 
            // InputUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 499);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.tambah);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "InputUser";
            this.Text = "Input User";
            this.Load += new System.EventHandler(this.InputUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isactive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider Validator;
        private DevExpress.XtraEditors.SimpleButton tambah;
        private DevExpress.XtraEditors.SimpleButton edit;
        private DevExpress.XtraEditors.SimpleButton simpan;
        private DevExpress.XtraEditors.SimpleButton hapus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit email;
        private DevExpress.XtraEditors.TextEdit name;
        private DevExpress.XtraEditors.CheckEdit isactive;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ButtonEdit id;
        private DevExpress.Xpo.XPView branchView;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraEditors.ButtonEdit branch;
    }
}