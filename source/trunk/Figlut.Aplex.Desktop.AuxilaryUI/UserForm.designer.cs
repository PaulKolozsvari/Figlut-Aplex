namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.pnlMain = new Figlut.Desktop.Controls.GradientPanel();
            this.btnUserPermissions = new Figlut.Desktop.Controls.GradientButton();
            this.btnAdditionalInfo = new Figlut.Desktop.Controls.GradientButton();
            this.gpbRoles = new System.Windows.Forms.GroupBox();
            this.chkSystem = new System.Windows.Forms.CheckBox();
            this.chkAdministrator = new System.Windows.Forms.CheckBox();
            this.chkDesktop = new System.Windows.Forms.CheckBox();
            this.chkMobile = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuUpdateAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFormContent.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gpbRoles.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(495, 21);
            this.lblFormTitle.Text = " ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 308);
            this.statusMain.Size = new System.Drawing.Size(495, 21);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlMain);
            this.pnlFormContent.Size = new System.Drawing.Size(465, 287);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 287);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(480, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 287);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.btnUserPermissions);
            this.pnlMain.Controls.Add(this.btnAdditionalInfo);
            this.pnlMain.Controls.Add(this.gpbRoles);
            this.pnlMain.Controls.Add(this.txtConfirmPassword);
            this.pnlMain.Controls.Add(this.lblConfirmPassword);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.txtUserName);
            this.pnlMain.Controls.Add(this.lblUserName);
            this.pnlMain.Controls.Add(this.mnuMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMain.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(465, 287);
            this.pnlMain.TabIndex = 2;
            // 
            // btnUserPermissions
            // 
            this.btnUserPermissions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserPermissions.BackgroundImage")));
            this.btnUserPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserPermissions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUserPermissions.GradientEndColor = System.Drawing.Color.DimGray;
            this.btnUserPermissions.GradientStartColor = System.Drawing.Color.DarkGray;
            this.btnUserPermissions.Location = new System.Drawing.Point(0, 258);
            this.btnUserPermissions.Name = "btnUserPermissions";
            this.btnUserPermissions.Size = new System.Drawing.Size(465, 23);
            this.btnUserPermissions.TabIndex = 5;
            this.btnUserPermissions.Text = "Permissions";
            this.btnUserPermissions.UseVisualStyleBackColor = true;
            this.btnUserPermissions.Click += new System.EventHandler(this.btnUserPermissions_Click);
            // 
            // btnAdditionalInfo
            // 
            this.btnAdditionalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdditionalInfo.BackgroundImage")));
            this.btnAdditionalInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdditionalInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdditionalInfo.GradientEndColor = System.Drawing.Color.DimGray;
            this.btnAdditionalInfo.GradientStartColor = System.Drawing.Color.DarkGray;
            this.btnAdditionalInfo.Location = new System.Drawing.Point(0, 235);
            this.btnAdditionalInfo.Name = "btnAdditionalInfo";
            this.btnAdditionalInfo.Size = new System.Drawing.Size(465, 23);
            this.btnAdditionalInfo.TabIndex = 4;
            this.btnAdditionalInfo.Text = "Additonal Info";
            this.btnAdditionalInfo.UseVisualStyleBackColor = true;
            this.btnAdditionalInfo.Click += new System.EventHandler(this.btnAdditionalInfo_Click);
            // 
            // gpbRoles
            // 
            this.gpbRoles.BackColor = System.Drawing.Color.Transparent;
            this.gpbRoles.Controls.Add(this.chkSystem);
            this.gpbRoles.Controls.Add(this.chkAdministrator);
            this.gpbRoles.Controls.Add(this.chkDesktop);
            this.gpbRoles.Controls.Add(this.chkMobile);
            this.gpbRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbRoles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpbRoles.Location = new System.Drawing.Point(0, 123);
            this.gpbRoles.Name = "gpbRoles";
            this.gpbRoles.Size = new System.Drawing.Size(465, 112);
            this.gpbRoles.TabIndex = 3;
            this.gpbRoles.TabStop = false;
            this.gpbRoles.Text = "Roles: ";
            // 
            // chkSystem
            // 
            this.chkSystem.AutoSize = true;
            this.chkSystem.Location = new System.Drawing.Point(9, 65);
            this.chkSystem.Name = "chkSystem";
            this.chkSystem.Size = new System.Drawing.Size(60, 17);
            this.chkSystem.TabIndex = 2;
            this.chkSystem.Text = "System";
            this.chkSystem.UseVisualStyleBackColor = true;
            this.chkSystem.CheckedChanged += new System.EventHandler(this.chkRegularRole_CheckedChanged);
            // 
            // chkAdministrator
            // 
            this.chkAdministrator.AutoSize = true;
            this.chkAdministrator.Location = new System.Drawing.Point(9, 88);
            this.chkAdministrator.Name = "chkAdministrator";
            this.chkAdministrator.Size = new System.Drawing.Size(86, 17);
            this.chkAdministrator.TabIndex = 3;
            this.chkAdministrator.Text = "Administrator";
            this.chkAdministrator.UseVisualStyleBackColor = true;
            this.chkAdministrator.CheckedChanged += new System.EventHandler(this.chkAdministrator_CheckedChanged);
            // 
            // chkDesktop
            // 
            this.chkDesktop.AutoSize = true;
            this.chkDesktop.Location = new System.Drawing.Point(9, 42);
            this.chkDesktop.Name = "chkDesktop";
            this.chkDesktop.Size = new System.Drawing.Size(66, 17);
            this.chkDesktop.TabIndex = 1;
            this.chkDesktop.Text = "Desktop";
            this.chkDesktop.UseVisualStyleBackColor = true;
            this.chkDesktop.CheckedChanged += new System.EventHandler(this.chkRegularRole_CheckedChanged);
            // 
            // chkMobile
            // 
            this.chkMobile.AutoSize = true;
            this.chkMobile.Location = new System.Drawing.Point(9, 19);
            this.chkMobile.Name = "chkMobile";
            this.chkMobile.Size = new System.Drawing.Size(57, 17);
            this.chkMobile.TabIndex = 0;
            this.chkMobile.Text = "Mobile";
            this.chkMobile.UseVisualStyleBackColor = true;
            this.chkMobile.CheckedChanged += new System.EventHandler(this.chkRegularRole_CheckedChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtConfirmPassword.Location = new System.Drawing.Point(0, 103);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(465, 20);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmPassword.Location = new System.Drawing.Point(0, 90);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 63;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Location = new System.Drawing.Point(0, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(465, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPassword.Location = new System.Drawing.Point(0, 57);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 61;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUserName.Location = new System.Drawing.Point(0, 37);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(465, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserName.Location = new System.Drawing.Point(0, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 59;
            this.lblUserName.Text = "Username:";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateAdd,
            this.mnuCancel});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(465, 24);
            this.mnuMain.TabIndex = 57;
            this.mnuMain.Text = "customMainMenu1";
            // 
            // mnuUpdateAdd
            // 
            this.mnuUpdateAdd.Name = "mnuUpdateAdd";
            this.mnuUpdateAdd.Size = new System.Drawing.Size(79, 20);
            this.mnuUpdateAdd.Text = "UpdateAdd";
            this.mnuUpdateAdd.Click += new System.EventHandler(this.mnuUpdateAdd_Click);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(55, 20);
            this.mnuCancel.Text = "&Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 329);
            this.KeyPreview = true;
            this.Name = "UserForm";
            this.ShowInTaskbar = false;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gpbRoles.ResumeLayout(false);
            this.gpbRoles.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.GradientPanel pnlMain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.GroupBox gpbRoles;
        private System.Windows.Forms.CheckBox chkAdministrator;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkMobile;
        private System.Windows.Forms.CheckBox chkSystem;
        private Figlut.Desktop.Controls.GradientButton btnUserPermissions;
        private Figlut.Desktop.Controls.GradientButton btnAdditionalInfo;
    }
}