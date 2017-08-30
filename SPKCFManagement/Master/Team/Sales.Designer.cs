namespace SPKCFManagement.Master.Team
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.simpan = new DevExpress.XtraEditors.SimpleButton();
            this.hapus = new DevExpress.XtraEditors.SimpleButton();
            this.edit = new DevExpress.XtraEditors.SimpleButton();
            this.tambah = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nama_sales = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.kode_sales = new DevExpress.XtraEditors.TextEdit();
            this.kode_sh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.SalesGridControl = new DevExpress.XtraGrid.GridControl();
            this.SalesCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.SalesUnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.SalesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkode_sales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_sales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama_sh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InputValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nama_sales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_sales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_sh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesUnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // simpan
            // 
            this.simpan.ImageOptions.Image = global::SPKCFManagement.Properties.Resources.apply_32x32;
            this.simpan.Location = new System.Drawing.Point(118, 12);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(100, 40);
            this.simpan.TabIndex = 15;
            this.simpan.Text = "Simpan";
            this.simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // hapus
            // 
            this.hapus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hapus.ImageOptions.Image")));
            this.hapus.Location = new System.Drawing.Point(330, 12);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(100, 40);
            this.hapus.TabIndex = 14;
            this.hapus.Text = "Hapus";
            this.hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // edit
            // 
            this.edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("edit.ImageOptions.Image")));
            this.edit.Location = new System.Drawing.Point(224, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 40);
            this.edit.TabIndex = 13;
            this.edit.Text = "Edit";
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // tambah
            // 
            this.tambah.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tambah.ImageOptions.Image")));
            this.tambah.Location = new System.Drawing.Point(12, 12);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(100, 40);
            this.tambah.TabIndex = 12;
            this.tambah.Text = "Tambah";
            this.tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nama_sales);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.kode_sales);
            this.panelControl1.Controls.Add(this.kode_sh);
            this.panelControl1.Location = new System.Drawing.Point(12, 58);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(670, 83);
            this.panelControl1.TabIndex = 16;
            // 
            // nama_sales
            // 
            this.nama_sales.Location = new System.Drawing.Point(374, 14);
            this.nama_sales.Name = "nama_sales";
            this.nama_sales.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.nama_sales.Properties.Appearance.Options.UseBackColor = true;
            this.nama_sales.Size = new System.Drawing.Size(154, 20);
            this.nama_sales.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.InputValidator.SetValidationRule(this.nama_sales, conditionValidationRule1);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(286, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nama SH";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(286, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nama Sales";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kode Sales";
            // 
            // kode_sales
            // 
            this.kode_sales.Location = new System.Drawing.Point(106, 14);
            this.kode_sales.Name = "kode_sales";
            this.kode_sales.Properties.ReadOnly = true;
            this.kode_sales.Size = new System.Drawing.Size(88, 20);
            this.kode_sales.TabIndex = 6;
            // 
            // kode_sh
            // 
            this.kode_sh.EditValue = "";
            this.kode_sh.Location = new System.Drawing.Point(374, 40);
            this.kode_sh.Name = "kode_sh";
            this.kode_sh.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.kode_sh.Properties.Appearance.Options.UseBackColor = true;
            this.kode_sh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kode_sh.Properties.NullText = "[EditValue is null]";
            this.kode_sh.Properties.PopupSizeable = true;
            this.kode_sh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.kode_sh.Size = new System.Drawing.Size(154, 20);
            this.kode_sh.TabIndex = 7;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.SalesGridControl);
            this.panelControl2.Location = new System.Drawing.Point(12, 147);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(670, 260);
            this.panelControl2.TabIndex = 17;
            // 
            // SalesGridControl
            // 
            this.SalesGridControl.DataSource = this.SalesCollection;
            this.SalesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesGridControl.Location = new System.Drawing.Point(2, 2);
            this.SalesGridControl.MainView = this.SalesGridView;
            this.SalesGridControl.Name = "SalesGridControl";
            this.SalesGridControl.Size = new System.Drawing.Size(666, 256);
            this.SalesGridControl.TabIndex = 0;
            this.SalesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SalesGridView});
            this.SalesGridControl.Click += new System.EventHandler(this.SalesGridControl_Click);
            // 
            // SalesCollection
            // 
            this.SalesCollection.DisplayableProperties = "kode_sales;nama_sales;nama_sh;shbranch;salesbranch;kode_sh";
            this.SalesCollection.ObjectType = typeof(SPKCFManagement.DB.MySQL.spkcms.SalesViewModel);
            this.SalesCollection.Session = this.SalesUnitOfWork;
            // 
            // SalesUnitOfWork
            // 
            this.SalesUnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.SalesUnitOfWork.TrackPropertiesModifications = false;
            // 
            // SalesGridView
            // 
            this.SalesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkode_sales,
            this.colnama_sales,
            this.colnama_sh});
            this.SalesGridView.GridControl = this.SalesGridControl;
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.SalesGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.SalesGridView.OptionsBehavior.Editable = false;
            this.SalesGridView.OptionsBehavior.ReadOnly = true;
            // 
            // colkode_sales
            // 
            this.colkode_sales.Caption = "Kode Sales";
            this.colkode_sales.FieldName = "kode_sales";
            this.colkode_sales.Name = "colkode_sales";
            this.colkode_sales.Visible = true;
            this.colkode_sales.VisibleIndex = 1;
            // 
            // colnama_sales
            // 
            this.colnama_sales.Caption = "Nama Sales";
            this.colnama_sales.FieldName = "nama_sales";
            this.colnama_sales.Name = "colnama_sales";
            this.colnama_sales.Visible = true;
            this.colnama_sales.VisibleIndex = 2;
            // 
            // colnama_sh
            // 
            this.colnama_sh.Caption = "Nama SH";
            this.colnama_sh.FieldName = "nama_sh";
            this.colnama_sh.Name = "colnama_sh";
            this.colnama_sh.Visible = true;
            this.colnama_sh.VisibleIndex = 0;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 437);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.tambah);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nama_sales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_sales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kode_sh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesUnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpan;
        private DevExpress.XtraEditors.SimpleButton hapus;
        private DevExpress.XtraEditors.SimpleButton edit;
        private DevExpress.XtraEditors.SimpleButton tambah;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl SalesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SalesGridView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit nama_sales;
        private DevExpress.XtraEditors.TextEdit kode_sales;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider InputValidator;
        private DevExpress.XtraEditors.ComboBoxEdit kode_sh;
        private DevExpress.Xpo.XPCollection SalesCollection;
        private DevExpress.Xpo.UnitOfWork SalesUnitOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colkode_sales;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_sales;
        private DevExpress.XtraGrid.Columns.GridColumn colnama_sh;
    }
}