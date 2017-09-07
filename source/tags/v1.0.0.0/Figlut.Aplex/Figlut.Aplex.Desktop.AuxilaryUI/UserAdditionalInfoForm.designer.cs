namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class UserAdditionalInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdditionalInfoForm));
            this.pnlMain = new Figlut.Desktop.Controls.GradientPanel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuUpdateAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.chkEmailNotifications = new System.Windows.Forms.CheckBox();
            this.pnlFormContent.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.gpbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(495, 21);
            this.lblFormTitle.Text = " ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserOptionalForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserOptionalForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserOptionalForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 253);
            this.statusMain.Size = new System.Drawing.Size(495, 21);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlMain);
            this.pnlFormContent.Size = new System.Drawing.Size(465, 232);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 232);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(480, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 232);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.gpbOptions);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtSurname);
            this.pnlMain.Controls.Add(this.lblSurname);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.mnuMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMain.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(465, 232);
            this.pnlMain.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhone.Location = new System.Drawing.Point(0, 169);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(465, 20);
            this.txtPhone.TabIndex = 72;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhone.Location = new System.Drawing.Point(0, 156);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 73;
            this.lblPhone.Text = "Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddress.Location = new System.Drawing.Point(0, 136);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(465, 20);
            this.txtAddress.TabIndex = 70;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(0, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 71;
            this.lblAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Location = new System.Drawing.Point(0, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(465, 20);
            this.txtEmail.TabIndex = 68;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(0, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 69;
            this.lblEmail.Text = "Email:";
            // 
            // txtSurname
            // 
            this.txtSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSurname.Location = new System.Drawing.Point(0, 70);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(465, 20);
            this.txtSurname.TabIndex = 62;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSurname.Location = new System.Drawing.Point(0, 57);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 63;
            this.lblSurname.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Location = new System.Drawing.Point(0, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(465, 20);
            this.txtName.TabIndex = 60;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(0, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 61;
            this.lblName.Text = "Name:";
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
            // gpbOptions
            // 
            this.gpbOptions.BackColor = System.Drawing.Color.Transparent;
            this.gpbOptions.Controls.Add(this.chkEmailNotifications);
            this.gpbOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpbOptions.Location = new System.Drawing.Point(0, 189);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(465, 43);
            this.gpbOptions.TabIndex = 91;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Text = "Options:";
            // 
            // chkEmailNotifications
            // 
            this.chkEmailNotifications.AutoSize = true;
            this.chkEmailNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkEmailNotifications.Location = new System.Drawing.Point(3, 16);
            this.chkEmailNotifications.Name = "chkEmailNotifications";
            this.chkEmailNotifications.Size = new System.Drawing.Size(459, 17);
            this.chkEmailNotifications.TabIndex = 0;
            this.chkEmailNotifications.Text = "Email Notifications:";
            this.chkEmailNotifications.UseVisualStyleBackColor = true;
            // 
            // UserAdditionalInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 274);
            this.KeyPreview = true;
            this.Name = "UserAdditionalInfoForm";
            this.ShowInTaskbar = false;
            this.Text = "UserOptionalForm";
            this.Load += new System.EventHandler(this.UserOptionalForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserOptionalForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserOptionalForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserAdditionalInfoForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserOptionalForm_MouseMove);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.gpbOptions.ResumeLayout(false);
            this.gpbOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.GradientPanel pnlMain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox gpbOptions;
        private System.Windows.Forms.CheckBox chkEmailNotifications;

    }
}