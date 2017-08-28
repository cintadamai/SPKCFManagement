namespace SPKCFManagement
{
    partial class Login
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
            this.username = new DevExpress.XtraEditors.TextEdit();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.masuk = new DevExpress.XtraEditors.SimpleButton();
            this.keluar = new DevExpress.XtraEditors.SimpleButton();
            this.menuControl = new DevExpress.XtraEditors.GroupControl();
            this.utility = new DevExpress.XtraEditors.SimpleButton();
            this.pelunasan = new DevExpress.XtraEditors.SimpleButton();
            this.spk = new DevExpress.XtraEditors.SimpleButton();
            this.master = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuControl)).BeginInit();
            this.menuControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(291, 149);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(156, 20);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(291, 193);
            this.password.Name = "password";
            this.password.Properties.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(156, 20);
            this.password.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(220, 152);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(222, 196);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Password";
            // 
            // masuk
            // 
            this.masuk.Location = new System.Drawing.Point(246, 248);
            this.masuk.Name = "masuk";
            this.masuk.Size = new System.Drawing.Size(93, 34);
            this.masuk.TabIndex = 4;
            this.masuk.Text = "Masuk";
            this.masuk.Click += new System.EventHandler(this.masuk_Click);
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(345, 248);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(93, 34);
            this.keluar.TabIndex = 5;
            this.keluar.Text = "Keluar";
            this.keluar.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // menuControl
            // 
            this.menuControl.Controls.Add(this.utility);
            this.menuControl.Controls.Add(this.pelunasan);
            this.menuControl.Controls.Add(this.spk);
            this.menuControl.Controls.Add(this.master);
            this.menuControl.Enabled = false;
            this.menuControl.Location = new System.Drawing.Point(12, 307);
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(626, 97);
            this.menuControl.TabIndex = 6;
            this.menuControl.Text = "Menu";
            // 
            // utility
            // 
            this.utility.Enabled = false;
            this.utility.ImageOptions.Image = global::SPKCFManagement.Properties.Resources.walking_32x32;
            this.utility.Location = new System.Drawing.Point(451, 41);
            this.utility.Name = "utility";
            this.utility.Size = new System.Drawing.Size(122, 36);
            this.utility.TabIndex = 3;
            this.utility.Text = "Utility";
            // 
            // pelunasan
            // 
            this.pelunasan.Enabled = false;
            this.pelunasan.ImageOptions.Image = global::SPKCFManagement.Properties.Resources.sales_32x32;
            this.pelunasan.Location = new System.Drawing.Point(323, 41);
            this.pelunasan.Name = "pelunasan";
            this.pelunasan.Size = new System.Drawing.Size(122, 36);
            this.pelunasan.TabIndex = 2;
            this.pelunasan.Text = "Pelunasan";
            // 
            // spk
            // 
            this.spk.Enabled = false;
            this.spk.ImageOptions.Image = global::SPKCFManagement.Properties.Resources.printincludeevaluations_32x32;
            this.spk.Location = new System.Drawing.Point(195, 41);
            this.spk.Name = "spk";
            this.spk.Size = new System.Drawing.Size(122, 36);
            this.spk.TabIndex = 1;
            this.spk.Text = "SPK";
            // 
            // master
            // 
            this.master.Enabled = false;
            this.master.ImageOptions.Image = global::SPKCFManagement.Properties.Resources.showproduct_32x32;
            this.master.Location = new System.Drawing.Point(66, 41);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(122, 36);
            this.master.TabIndex = 0;
            this.master.Text = "Master";
            this.master.Click += new System.EventHandler(this.master_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(187, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(326, 23);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "SPK CONTROL MANAGEMENT SYSTEM";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::SPKCFManagement.Properties.Resources.newitem_32x32;
            this.pictureEdit1.Location = new System.Drawing.Point(313, 26);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(61, 46);
            this.pictureEdit1.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 446);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.menuControl);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.masuk);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuControl)).EndInit();
            this.menuControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit username;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton masuk;
        private DevExpress.XtraEditors.SimpleButton keluar;
        private DevExpress.XtraEditors.GroupControl menuControl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton master;
        private DevExpress.XtraEditors.SimpleButton pelunasan;
        private DevExpress.XtraEditors.SimpleButton spk;
        private DevExpress.XtraEditors.SimpleButton utility;
    }
}
