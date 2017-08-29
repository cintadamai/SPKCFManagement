namespace SPKCFManagement.Master.User
{
    partial class AddRoleDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoleDialog));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.role_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpan = new DevExpress.XtraEditors.SimpleButton();
            this.Validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.role_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.role_name);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(415, 238);
            this.panelControl1.TabIndex = 0;
            // 
            // role_name
            // 
            this.role_name.Location = new System.Drawing.Point(94, 20);
            this.role_name.Name = "role_name";
            this.role_name.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.role_name.Properties.Appearance.Options.UseBackColor = true;
            this.role_name.Size = new System.Drawing.Size(158, 20);
            this.role_name.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Harus di isi.";
            this.Validator.SetValidationRule(this.role_name, conditionValidationRule1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Role Name";
            // 
            // simpan
            // 
            this.simpan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpan.ImageOptions.Image")));
            this.simpan.Location = new System.Drawing.Point(327, 256);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(100, 40);
            this.simpan.TabIndex = 3;
            this.simpan.Text = "Simpan";
            this.simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // AddRoleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 307);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.panelControl1);
            this.Name = "AddRoleDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoleDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.role_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit role_name;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider Validator;
    }
}