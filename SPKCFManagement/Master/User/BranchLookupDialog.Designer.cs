namespace SPKCFManagement.Master.User
{
    partial class BranchLookupDialog
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cancel = new DevExpress.XtraEditors.SimpleButton();
            this.ok = new DevExpress.XtraEditors.SimpleButton();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.xpView1 = new DevExpress.Xpo.XPView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalamat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_telepon = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(756, 383);
            this.panelControl1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpView1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(752, 379);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnama,
            this.colalamat,
            this.colno_telepon});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(671, 404);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(97, 38);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(568, 404);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(97, 38);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // xpView1
            // 
            this.xpView1.ObjectType = typeof(SPKCFManagement.DB.MySQL.spkcms.BranchModel);
            this.xpView1.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("id", DevExpress.Xpo.SortDirection.None, "[id]", false, true),
            new DevExpress.Xpo.ViewProperty("nama", DevExpress.Xpo.SortDirection.None, "[nama]", false, true),
            new DevExpress.Xpo.ViewProperty("alamat", DevExpress.Xpo.SortDirection.None, "[alamat]", false, true),
            new DevExpress.Xpo.ViewProperty("no_telepon", DevExpress.Xpo.SortDirection.None, "[no_telepon]", false, true),
            new DevExpress.Xpo.ViewProperty("created_at", DevExpress.Xpo.SortDirection.None, "[created_at]", false, true),
            new DevExpress.Xpo.ViewProperty("updated_at", DevExpress.Xpo.SortDirection.None, "[updated_at]", false, true),
            new DevExpress.Xpo.ViewProperty("created_by", DevExpress.Xpo.SortDirection.None, "[created_by]", false, true),
            new DevExpress.Xpo.ViewProperty("updated_by", DevExpress.Xpo.SortDirection.None, "[updated_by]", false, true)});
            this.xpView1.Session = this.unitOfWork1;
            this.xpView1.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[id]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colnama
            // 
            this.colnama.FieldName = "nama";
            this.colnama.Name = "colnama";
            this.colnama.Visible = true;
            this.colnama.VisibleIndex = 1;
            // 
            // colalamat
            // 
            this.colalamat.FieldName = "alamat";
            this.colalamat.Name = "colalamat";
            this.colalamat.Visible = true;
            this.colalamat.VisibleIndex = 2;
            // 
            // colno_telepon
            // 
            this.colno_telepon.FieldName = "no_telepon";
            this.colno_telepon.Name = "colno_telepon";
            this.colno_telepon.Visible = true;
            this.colno_telepon.VisibleIndex = 3;
            // 
            // BranchLookupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 454);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BranchLookupDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BranchLookupDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton cancel;
        private DevExpress.XtraEditors.SimpleButton ok;
        private DevExpress.Xpo.XPView xpView1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnama;
        private DevExpress.XtraGrid.Columns.GridColumn colalamat;
        private DevExpress.XtraGrid.Columns.GridColumn colno_telepon;
    }
}