namespace SPKCFManagement.Master
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.input_user = new DevExpress.XtraBars.BarButtonItem();
            this.user_roles = new DevExpress.XtraBars.BarButtonItem();
            this.user_permission = new DevExpress.XtraBars.BarButtonItem();
            this.userpage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.userpagegroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.input_user,
            this.user_roles,
            this.user_permission});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.userpage});
            this.ribbonControl1.Size = new System.Drawing.Size(667, 141);
            // 
            // input_user
            // 
            this.input_user.Caption = "Input User";
            this.input_user.Enabled = false;
            this.input_user.Id = 1;
            this.input_user.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("input_user.ImageOptions.Image")));
            this.input_user.Name = "input_user";
            this.input_user.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.input_user.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Input_user_ItemClick);
            // 
            // user_roles
            // 
            this.user_roles.Caption = "User Roles";
            this.user_roles.Enabled = false;
            this.user_roles.Id = 2;
            this.user_roles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_roles.ImageOptions.Image")));
            this.user_roles.Name = "user_roles";
            this.user_roles.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // user_permission
            // 
            this.user_permission.Caption = "User Permission";
            this.user_permission.Enabled = false;
            this.user_permission.Id = 3;
            this.user_permission.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_permission.ImageOptions.Image")));
            this.user_permission.Name = "user_permission";
            this.user_permission.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // userpage
            // 
            this.userpage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.userpagegroup});
            this.userpage.Name = "userpage";
            this.userpage.Text = "User";
            // 
            // userpagegroup
            // 
            this.userpagegroup.Enabled = false;
            this.userpagegroup.ItemLinks.Add(this.input_user);
            this.userpagegroup.ItemLinks.Add(this.user_roles);
            this.userpagegroup.ItemLinks.Add(this.user_permission);
            this.userpagegroup.Name = "userpagegroup";
            this.userpagegroup.Text = "User";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 480);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage userpage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup userpagegroup;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem input_user;
        private DevExpress.XtraBars.BarButtonItem user_roles;
        private DevExpress.XtraBars.BarButtonItem user_permission;
    }
}