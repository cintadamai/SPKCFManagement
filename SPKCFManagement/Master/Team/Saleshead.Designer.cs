namespace SPKCFManagement.Master.Team
{
    partial class Saleshead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saleshead));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.SHGridControl = new DevExpress.XtraGrid.GridControl();
            this.SHGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkode_sh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_sh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SHUnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nama_sh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.kode_sh = new DevExpress.XtraEditors.TextEdit();
            this.simpan = new DevExpress.XtraEditors.SimpleButton();
            this.hapus = new DevExpress.XtraEditors.SimpleButton();
            this.edit = new DevExpress.XtraEditors.SimpleButton();
            this.tambah = new DevExpress.XtraEditors.SimpleButton();
            this.InputValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHUnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nama_sh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_sh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.SHGridControl);
            this.panelControl2.Location = new System.Drawing.Point(12, 117);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(670, 260);
            this.panelControl2.TabIndex = 23;
            // 
            // SHGridControl
            // 
            this.SHGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SHGridControl.Location = new System.Drawing.Point(2, 2);
            this.SHGridControl.MainView = this.SHGridView;
            this.SHGridControl.Name = "SHGridControl";
            this.SHGridControl.Size = new System.Drawing.Size(666, 256);
            this.SHGridControl.TabIndex = 0;
            this.SHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SHGridView});
            this.SHGridControl.Click += new System.EventHandler(this.SHGridControl_Click);
            // 
            // SHGridView
            // 
            this.SHGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkode_sh,
            this.colnama_sh});
            this.SHGridView.GridControl = this.SHGridControl;
            this.SHGridView.Name = "SHGridView";
            this.SHGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.SHGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.SHGridView.OptionsBehavior.Editable = false;
            this.SHGridView.OptionsBehavior.ReadOnly = true;
            // 
            // colkode_sh
            // 
            this.colkode_sh.Caption = "Kode SH";
            this.colkode_sh.FieldName = "kode_sh";
            this.colkode_sh.Name = "colkode_sh";
            this.colkode_sh.Visible = true;
            this.colkode_sh.VisibleIndex = 0;
            // 
            // colnama_sh
            // 
            this.colnama_sh.Caption = "Nama SH";
            this.colnama_sh.FieldName = "nama_sh";
            this.colnama_sh.Name = "colnama_sh";
            this.colnama_sh.Visible = true;
            this.colnama_sh.VisibleIndex = 1;
            // 
            // SHUnitOfWork
            // 
            this.SHUnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SHUnitOfWork.TrackPropertiesModifications = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nama_sh);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.kode_sh);
            this.panelControl1.Location = new System.Drawing.Point(12, 58);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(670, 53);
            this.panelControl1.TabIndex = 22;
            // 
            // nama_sh
            // 
            this.nama_sh.Location = new System.Drawing.Point(374, 14);
            this.nama_sh.Name = "nama_sh";
            this.nama_sh.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama_sh.Properties.Appearance.Options.UseBackColor = true;
            this.nama_sh.Size = new System.Drawing.Size(154, 20);
            this.nama_sh.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.InputValidator.SetValidationRule(this.nama_sh, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(286, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nama SH";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kode SH";
            // 
            // kode_sh
            // 
            this.kode_sh.Location = new System.Drawing.Point(106, 14);
            this.kode_sh.Name = "kode_sh";
            this.kode_sh.Properties.ReadOnly = true;
            this.kode_sh.Size = new System.Drawing.Size(100, 20);
            this.kode_sh.TabIndex = 6;
            // 
            // simpan
            // 
            this.simpan.ImageOptions.Image = global::SPKCFManagement.Properties.Resources.apply_32x32;
            this.simpan.Location = new System.Drawing.Point(118, 12);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(100, 40);
            this.simpan.TabIndex = 21;
            this.simpan.Text = "Simpan";
            this.simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // hapus
            // 
            this.hapus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hapus.ImageOptions.Image")));
            this.hapus.Location = new System.Drawing.Point(330, 12);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(100, 40);
            this.hapus.TabIndex = 20;
            this.hapus.Text = "Hapus";
            this.hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // edit
            // 
            this.edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("edit.ImageOptions.Image")));
            this.edit.Location = new System.Drawing.Point(224, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 40);
            this.edit.TabIndex = 19;
            this.edit.Text = "Edit";
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // tambah
            // 
            this.tambah.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tambah.ImageOptions.Image")));
            this.tambah.Location = new System.Drawing.Point(12, 12);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(100, 40);
            this.tambah.TabIndex = 18;
            this.tambah.Text = "Tambah";
            this.tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // Saleshead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 395);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.tambah);
            this.Name = "Saleshead";
            this.Text = "Sales Head";
            this.Load += new System.EventHandler(this.Saleshead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHUnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nama_sh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_sh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl SHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SHGridView;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit nama_sh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpan;
        private DevExpress.XtraEditors.SimpleButton hapus;
        private DevExpress.XtraEditors.SimpleButton edit;
        private DevExpress.XtraEditors.SimpleButton tambah;
        private DevExpress.XtraGrid.Columns.GridColumn colkode_sh;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_sh;
        private DevExpress.XtraEditors.TextEdit kode_sh;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider InputValidator;
        private DevExpress.Xpo.UnitOfWork SHUnitOfWork;
    }
}