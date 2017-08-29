namespace SPKCFManagement.Master.User
{
    partial class UserRoles
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Input User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User Roles");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("User Permission");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("User", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Master", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("SPK");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Pelunasan");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Utility");
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoles));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.MenuTreeView = new System.Windows.Forms.TreeView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.removeUser = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.UserGridControl = new DevExpress.XtraGrid.GridControl();
            this.UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addUser = new DevExpress.XtraEditors.SimpleButton();
            this.RolesCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.hapus = new DevExpress.XtraEditors.SimpleButton();
            this.simpan = new DevExpress.XtraEditors.SimpleButton();
            this.edit = new DevExpress.XtraEditors.SimpleButton();
            this.tambah = new DevExpress.XtraEditors.SimpleButton();
            this.AddUserValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUserValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.MenuTreeView);
            this.panelControl2.Location = new System.Drawing.Point(309, 58);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(600, 452);
            this.panelControl2.TabIndex = 5;
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(5, 5);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(590, 27);
            this.panelControl4.TabIndex = 12;
            // 
            // MenuTreeView
            // 
            this.MenuTreeView.CheckBoxes = true;
            this.MenuTreeView.Location = new System.Drawing.Point(5, 38);
            this.MenuTreeView.Name = "MenuTreeView";
            treeNode1.Name = "input_user";
            treeNode1.Text = "Input User";
            treeNode2.Name = "user_roles";
            treeNode2.Text = "User Roles";
            treeNode3.Name = "user_permission";
            treeNode3.Text = "User Permission";
            treeNode4.Name = "userpage";
            treeNode4.Text = "User";
            treeNode5.Name = "master";
            treeNode5.Text = "Master";
            treeNode6.Name = "spk";
            treeNode6.Text = "SPK";
            treeNode7.Name = "pelunasan";
            treeNode7.Text = "Pelunasan";
            treeNode8.Name = "utility";
            treeNode8.Text = "Utility";
            this.MenuTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.MenuTreeView.Size = new System.Drawing.Size(590, 405);
            this.MenuTreeView.TabIndex = 11;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.removeUser);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.addUser);
            this.panelControl1.Controls.Add(this.RolesCombo);
            this.panelControl1.Location = new System.Drawing.Point(12, 60);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(293, 448);
            this.panelControl1.TabIndex = 6;
            // 
            // removeUser
            // 
            this.removeUser.Location = new System.Drawing.Point(138, 31);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(148, 23);
            this.removeUser.TabIndex = 3;
            this.removeUser.Text = "Hapus User";
            this.removeUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.UserGridControl);
            this.panelControl3.Location = new System.Drawing.Point(5, 58);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(283, 383);
            this.panelControl3.TabIndex = 1;
            // 
            // UserGridControl
            // 
            this.UserGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridControl.Location = new System.Drawing.Point(2, 2);
            this.UserGridControl.MainView = this.UserGridView;
            this.UserGridControl.Name = "UserGridControl";
            this.UserGridControl.Size = new System.Drawing.Size(279, 379);
            this.UserGridControl.TabIndex = 0;
            this.UserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserGridView});
            // 
            // UserGridView
            // 
            this.UserGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserNameColumn});
            this.UserGridView.GridControl = this.UserGridControl;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.UserGridView.OptionsBehavior.Editable = false;
            this.UserGridView.OptionsBehavior.ReadOnly = true;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.Caption = "Username";
            this.UserNameColumn.FieldName = "name";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.Visible = true;
            this.UserNameColumn.VisibleIndex = 0;
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(5, 31);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(127, 23);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "Tambah User";
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // RolesCombo
            // 
            this.RolesCombo.Location = new System.Drawing.Point(5, 5);
            this.RolesCombo.Name = "RolesCombo";
            this.RolesCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RolesCombo.Properties.Sorted = true;
            this.RolesCombo.Size = new System.Drawing.Size(281, 20);
            this.RolesCombo.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pilih Roles Terlebih Dahulu.";
            this.AddUserValidator.SetValidationRule(this.RolesCombo, conditionValidationRule1);
            // 
            // hapus
            // 
            this.hapus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hapus.ImageOptions.Image")));
            this.hapus.Location = new System.Drawing.Point(330, 12);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(100, 40);
            this.hapus.TabIndex = 10;
            this.hapus.Text = "Hapus";
            this.hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // simpan
            // 
            this.simpan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpan.ImageOptions.Image")));
            this.simpan.Location = new System.Drawing.Point(118, 12);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(100, 40);
            this.simpan.TabIndex = 9;
            this.simpan.Text = "Simpan";
            // 
            // edit
            // 
            this.edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("edit.ImageOptions.Image")));
            this.edit.Location = new System.Drawing.Point(224, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 40);
            this.edit.TabIndex = 8;
            this.edit.Text = "Edit";
            // 
            // tambah
            // 
            this.tambah.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tambah.ImageOptions.Image")));
            this.tambah.Location = new System.Drawing.Point(12, 12);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(100, 40);
            this.tambah.TabIndex = 7;
            this.tambah.Text = "Tambah";
            this.tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // UserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 522);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "UserRoles";
            this.Text = "User Roles";
            this.Load += new System.EventHandler(this.UserRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUserValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit RolesCombo;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton hapus;
        private DevExpress.XtraEditors.SimpleButton simpan;
        private DevExpress.XtraEditors.SimpleButton edit;
        private DevExpress.XtraEditors.SimpleButton tambah;
        private DevExpress.XtraGrid.GridControl UserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private DevExpress.XtraGrid.Columns.GridColumn UserNameColumn;
        private System.Windows.Forms.TreeView MenuTreeView;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton addUser;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider AddUserValidator;
        private DevExpress.XtraEditors.SimpleButton removeUser;
    }
}