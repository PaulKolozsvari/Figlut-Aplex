namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class UserPermissionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPermissionsForm));
            this.pnlMain = new Figlut.Desktop.Controls.GradientPanel();
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.btnUnassignAllPermissions = new Figlut.Desktop.Controls.GradientButton();
            this.btnAssignAllPermissions = new Figlut.Desktop.Controls.GradientButton();
            this.btnUnassignPermission = new Figlut.Desktop.Controls.GradientButton();
            this.btnAssignPermission = new Figlut.Desktop.Controls.GradientButton();
            this.pnlAssignedPermissions = new System.Windows.Forms.Panel();
            this.lstAssignedPermissions = new System.Windows.Forms.ListBox();
            this.lblAssignedPermissions = new System.Windows.Forms.Label();
            this.pnlUnassignedPermissions = new System.Windows.Forms.Panel();
            this.lstUnassignedPermissions = new System.Windows.Forms.ListBox();
            this.lblUnassignedPermissions = new System.Windows.Forms.Label();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFormContent.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlAssign.SuspendLayout();
            this.pnlAssignedPermissions.SuspendLayout();
            this.pnlUnassignedPermissions.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(522, 21);
            this.lblFormTitle.Text = "User Permissions ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserPermissionsForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserPermissionsForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserPermissionsForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 146);
            this.statusMain.Size = new System.Drawing.Size(522, 21);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlMain);
            this.pnlFormContent.Size = new System.Drawing.Size(492, 125);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 125);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(507, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 125);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.pnlAssign);
            this.pnlMain.Controls.Add(this.pnlAssignedPermissions);
            this.pnlMain.Controls.Add(this.pnlUnassignedPermissions);
            this.pnlMain.Controls.Add(this.mnuMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMain.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(492, 125);
            this.pnlMain.TabIndex = 3;
            // 
            // pnlAssign
            // 
            this.pnlAssign.BackColor = System.Drawing.Color.Transparent;
            this.pnlAssign.Controls.Add(this.btnUnassignAllPermissions);
            this.pnlAssign.Controls.Add(this.btnAssignAllPermissions);
            this.pnlAssign.Controls.Add(this.btnUnassignPermission);
            this.pnlAssign.Controls.Add(this.btnAssignPermission);
            this.pnlAssign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssign.Location = new System.Drawing.Point(190, 24);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(112, 101);
            this.pnlAssign.TabIndex = 62;
            // 
            // btnUnassignAllPermissions
            // 
            this.btnUnassignAllPermissions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnassignAllPermissions.BackgroundImage")));
            this.btnUnassignAllPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnassignAllPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnassignAllPermissions.GradientEndColor = System.Drawing.Color.DimGray;
            this.btnUnassignAllPermissions.GradientStartColor = System.Drawing.Color.DarkGray;
            this.btnUnassignAllPermissions.Location = new System.Drawing.Point(0, 69);
            this.btnUnassignAllPermissions.Name = "btnUnassignAllPermissions";
            this.btnUnassignAllPermissions.Size = new System.Drawing.Size(112, 23);
            this.btnUnassignAllPermissions.TabIndex = 3;
            this.btnUnassignAllPermissions.Text = "<<";
            this.btnUnassignAllPermissions.UseVisualStyleBackColor = true;
            this.btnUnassignAllPermissions.Click += new System.EventHandler(this.btnUnassignAllPermissions_Click);
            // 
            // btnAssignAllPermissions
            // 
            this.btnAssignAllPermissions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssignAllPermissions.BackgroundImage")));
            this.btnAssignAllPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssignAllPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignAllPermissions.GradientEndColor = System.Drawing.Color.DimGray;
            this.btnAssignAllPermissions.GradientStartColor = System.Drawing.Color.DarkGray;
            this.btnAssignAllPermissions.Location = new System.Drawing.Point(0, 46);
            this.btnAssignAllPermissions.Name = "btnAssignAllPermissions";
            this.btnAssignAllPermissions.Size = new System.Drawing.Size(112, 23);
            this.btnAssignAllPermissions.TabIndex = 2;
            this.btnAssignAllPermissions.Text = ">>";
            this.btnAssignAllPermissions.UseVisualStyleBackColor = true;
            this.btnAssignAllPermissions.Click += new System.EventHandler(this.btnAssignAllPermissions_Click);
            // 
            // btnUnassignPermission
            // 
            this.btnUnassignPermission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnassignPermission.BackgroundImage")));
            this.btnUnassignPermission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnassignPermission.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnassignPermission.GradientEndColor = System.Drawing.Color.DimGray;
            this.btnUnassignPermission.GradientStartColor = System.Drawing.Color.DarkGray;
            this.btnUnassignPermission.Location = new System.Drawing.Point(0, 23);
            this.btnUnassignPermission.Name = "btnUnassignPermission";
            this.btnUnassignPermission.Size = new System.Drawing.Size(112, 23);
            this.btnUnassignPermission.TabIndex = 1;
            this.btnUnassignPermission.Text = "<";
            this.btnUnassignPermission.UseVisualStyleBackColor = true;
            this.btnUnassignPermission.Click += new System.EventHandler(this.btnUnassignPermission_Click);
            // 
            // btnAssignPermission
            // 
            this.btnAssignPermission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssignPermission.BackgroundImage")));
            this.btnAssignPermission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssignPermission.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignPermission.GradientEndColor = System.Drawing.Color.DimGray;
            this.btnAssignPermission.GradientStartColor = System.Drawing.Color.DarkGray;
            this.btnAssignPermission.Location = new System.Drawing.Point(0, 0);
            this.btnAssignPermission.Name = "btnAssignPermission";
            this.btnAssignPermission.Size = new System.Drawing.Size(112, 23);
            this.btnAssignPermission.TabIndex = 0;
            this.btnAssignPermission.Text = ">";
            this.btnAssignPermission.UseVisualStyleBackColor = true;
            this.btnAssignPermission.Click += new System.EventHandler(this.btnAssignPermission_Click);
            // 
            // pnlAssignedPermissions
            // 
            this.pnlAssignedPermissions.BackColor = System.Drawing.Color.Transparent;
            this.pnlAssignedPermissions.Controls.Add(this.lstAssignedPermissions);
            this.pnlAssignedPermissions.Controls.Add(this.lblAssignedPermissions);
            this.pnlAssignedPermissions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAssignedPermissions.Location = new System.Drawing.Point(302, 24);
            this.pnlAssignedPermissions.Name = "pnlAssignedPermissions";
            this.pnlAssignedPermissions.Size = new System.Drawing.Size(190, 101);
            this.pnlAssignedPermissions.TabIndex = 61;
            // 
            // lstAssignedPermissions
            // 
            this.lstAssignedPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAssignedPermissions.FormattingEnabled = true;
            this.lstAssignedPermissions.Location = new System.Drawing.Point(0, 13);
            this.lstAssignedPermissions.Name = "lstAssignedPermissions";
            this.lstAssignedPermissions.Size = new System.Drawing.Size(190, 82);
            this.lstAssignedPermissions.TabIndex = 64;
            // 
            // lblAssignedPermissions
            // 
            this.lblAssignedPermissions.AutoSize = true;
            this.lblAssignedPermissions.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignedPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssignedPermissions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAssignedPermissions.Location = new System.Drawing.Point(0, 0);
            this.lblAssignedPermissions.Name = "lblAssignedPermissions";
            this.lblAssignedPermissions.Size = new System.Drawing.Size(108, 13);
            this.lblAssignedPermissions.TabIndex = 63;
            this.lblAssignedPermissions.Text = "Assigned Permissions";
            // 
            // pnlUnassignedPermissions
            // 
            this.pnlUnassignedPermissions.BackColor = System.Drawing.Color.Transparent;
            this.pnlUnassignedPermissions.Controls.Add(this.lstUnassignedPermissions);
            this.pnlUnassignedPermissions.Controls.Add(this.lblUnassignedPermissions);
            this.pnlUnassignedPermissions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUnassignedPermissions.Location = new System.Drawing.Point(0, 24);
            this.pnlUnassignedPermissions.Name = "pnlUnassignedPermissions";
            this.pnlUnassignedPermissions.Size = new System.Drawing.Size(190, 101);
            this.pnlUnassignedPermissions.TabIndex = 60;
            // 
            // lstUnassignedPermissions
            // 
            this.lstUnassignedPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUnassignedPermissions.FormattingEnabled = true;
            this.lstUnassignedPermissions.Location = new System.Drawing.Point(0, 13);
            this.lstUnassignedPermissions.Name = "lstUnassignedPermissions";
            this.lstUnassignedPermissions.Size = new System.Drawing.Size(190, 82);
            this.lstUnassignedPermissions.TabIndex = 63;
            // 
            // lblUnassignedPermissions
            // 
            this.lblUnassignedPermissions.AutoSize = true;
            this.lblUnassignedPermissions.BackColor = System.Drawing.Color.Transparent;
            this.lblUnassignedPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUnassignedPermissions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUnassignedPermissions.Location = new System.Drawing.Point(0, 0);
            this.lblUnassignedPermissions.Name = "lblUnassignedPermissions";
            this.lblUnassignedPermissions.Size = new System.Drawing.Size(124, 13);
            this.lblUnassignedPermissions.TabIndex = 62;
            this.lblUnassignedPermissions.Text = "Unassigned Permissions:";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdate,
            this.mnuCancel});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(492, 24);
            this.mnuMain.TabIndex = 57;
            this.mnuMain.Text = "customMainMenu1";
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(79, 20);
            this.mnuUpdate.Text = "UpdateAdd";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdateAdd);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(55, 20);
            this.mnuCancel.Text = "&Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // UserPermissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 167);
            this.FormTitle = "User Permissions";
            this.KeyPreview = true;
            this.Name = "UserPermissionsForm";
            this.ShowInTaskbar = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.UserPermissionsForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserPermissionsForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserPermissionsForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserPermissionsForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserPermissionsForm_MouseMove);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlAssign.ResumeLayout(false);
            this.pnlAssignedPermissions.ResumeLayout(false);
            this.pnlAssignedPermissions.PerformLayout();
            this.pnlUnassignedPermissions.ResumeLayout(false);
            this.pnlUnassignedPermissions.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.GradientPanel pnlMain;
        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.Panel pnlUnassignedPermissions;
        private System.Windows.Forms.Panel pnlAssignedPermissions;
        private System.Windows.Forms.Label lblAssignedPermissions;
        private System.Windows.Forms.Label lblUnassignedPermissions;
        private System.Windows.Forms.ListBox lstUnassignedPermissions;
        private System.Windows.Forms.ListBox lstAssignedPermissions;
        private System.Windows.Forms.Panel pnlAssign;
        private Figlut.Desktop.Controls.GradientButton btnAssignPermission;
        private Figlut.Desktop.Controls.GradientButton btnUnassignAllPermissions;
        private Figlut.Desktop.Controls.GradientButton btnAssignAllPermissions;
        private Figlut.Desktop.Controls.GradientButton btnUnassignPermission;
    }
}