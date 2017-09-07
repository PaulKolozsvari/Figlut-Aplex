namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class GlobalServerSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalServerSettingsForm));
            this.pnlMain = new Figlut.Desktop.Controls.GradientPanel();
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.chkEmailDevicePendingApproval = new System.Windows.Forms.CheckBox();
            this.chkLogActionGetDeviceConfig = new System.Windows.Forms.CheckBox();
            this.nudMaximumTrialDays = new System.Windows.Forms.NumericUpDown();
            this.lblMaximumTrialDays = new System.Windows.Forms.Label();
            this.txtMonetarySymbol = new System.Windows.Forms.TextBox();
            this.lblMonetarySymbol = new System.Windows.Forms.Label();
            this.txtCompanyAddressLine6 = new System.Windows.Forms.TextBox();
            this.lblCompanyAddressLine6 = new System.Windows.Forms.Label();
            this.txtCompanyAddressLine5 = new System.Windows.Forms.TextBox();
            this.lblCompanyAddressLine5 = new System.Windows.Forms.Label();
            this.txtCompanyAddressLine4 = new System.Windows.Forms.TextBox();
            this.lblCompanyAddressLine4 = new System.Windows.Forms.Label();
            this.txtCompanyAddressLine3 = new System.Windows.Forms.TextBox();
            this.lblCompanyAddressLine3 = new System.Windows.Forms.Label();
            this.txtCompanyAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblCompanyAddressLine2 = new System.Windows.Forms.Label();
            this.txtCompanyAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblCompanyAddressLine1 = new System.Windows.Forms.Label();
            this.txtCompanyVatRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblCompanyVatRegistrationNumber = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuUpdateAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFormContent.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gpbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumTrialDays)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(484, 21);
            this.lblFormTitle.Text = " ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlobalServerSettingsForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlobalServerSettingsForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlobalServerSettingsForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 438);
            this.statusMain.Size = new System.Drawing.Size(484, 21);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlMain);
            this.pnlFormContent.Size = new System.Drawing.Size(454, 417);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 417);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(469, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 417);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.gpbOptions);
            this.pnlMain.Controls.Add(this.nudMaximumTrialDays);
            this.pnlMain.Controls.Add(this.lblMaximumTrialDays);
            this.pnlMain.Controls.Add(this.txtMonetarySymbol);
            this.pnlMain.Controls.Add(this.lblMonetarySymbol);
            this.pnlMain.Controls.Add(this.txtCompanyAddressLine6);
            this.pnlMain.Controls.Add(this.lblCompanyAddressLine6);
            this.pnlMain.Controls.Add(this.txtCompanyAddressLine5);
            this.pnlMain.Controls.Add(this.lblCompanyAddressLine5);
            this.pnlMain.Controls.Add(this.txtCompanyAddressLine4);
            this.pnlMain.Controls.Add(this.lblCompanyAddressLine4);
            this.pnlMain.Controls.Add(this.txtCompanyAddressLine3);
            this.pnlMain.Controls.Add(this.lblCompanyAddressLine3);
            this.pnlMain.Controls.Add(this.txtCompanyAddressLine2);
            this.pnlMain.Controls.Add(this.lblCompanyAddressLine2);
            this.pnlMain.Controls.Add(this.txtCompanyAddressLine1);
            this.pnlMain.Controls.Add(this.lblCompanyAddressLine1);
            this.pnlMain.Controls.Add(this.txtCompanyVatRegistrationNumber);
            this.pnlMain.Controls.Add(this.lblCompanyVatRegistrationNumber);
            this.pnlMain.Controls.Add(this.txtCompanyName);
            this.pnlMain.Controls.Add(this.lblCompanyName);
            this.pnlMain.Controls.Add(this.mnuMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMain.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(454, 417);
            this.pnlMain.TabIndex = 3;
            // 
            // gpbOptions
            // 
            this.gpbOptions.BackColor = System.Drawing.Color.Transparent;
            this.gpbOptions.Controls.Add(this.chkEmailDevicePendingApproval);
            this.gpbOptions.Controls.Add(this.chkLogActionGetDeviceConfig);
            this.gpbOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpbOptions.Location = new System.Drawing.Point(0, 354);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(454, 63);
            this.gpbOptions.TabIndex = 90;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Text = "Options:";
            // 
            // chkEmailDevicePendingApproval
            // 
            this.chkEmailDevicePendingApproval.AutoSize = true;
            this.chkEmailDevicePendingApproval.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkEmailDevicePendingApproval.Location = new System.Drawing.Point(3, 33);
            this.chkEmailDevicePendingApproval.Name = "chkEmailDevicePendingApproval";
            this.chkEmailDevicePendingApproval.Size = new System.Drawing.Size(448, 17);
            this.chkEmailDevicePendingApproval.TabIndex = 1;
            this.chkEmailDevicePendingApproval.Text = "Email Device Pending Approval";
            this.chkEmailDevicePendingApproval.UseVisualStyleBackColor = true;
            // 
            // chkLogActionGetDeviceConfig
            // 
            this.chkLogActionGetDeviceConfig.AutoSize = true;
            this.chkLogActionGetDeviceConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkLogActionGetDeviceConfig.Location = new System.Drawing.Point(3, 16);
            this.chkLogActionGetDeviceConfig.Name = "chkLogActionGetDeviceConfig";
            this.chkLogActionGetDeviceConfig.Size = new System.Drawing.Size(448, 17);
            this.chkLogActionGetDeviceConfig.TabIndex = 0;
            this.chkLogActionGetDeviceConfig.Text = "Log Action Get Device Configuration";
            this.chkLogActionGetDeviceConfig.UseVisualStyleBackColor = true;
            // 
            // nudMaximumTrialDays
            // 
            this.nudMaximumTrialDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudMaximumTrialDays.Location = new System.Drawing.Point(0, 334);
            this.nudMaximumTrialDays.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMaximumTrialDays.Name = "nudMaximumTrialDays";
            this.nudMaximumTrialDays.Size = new System.Drawing.Size(454, 20);
            this.nudMaximumTrialDays.TabIndex = 89;
            // 
            // lblMaximumTrialDays
            // 
            this.lblMaximumTrialDays.AutoSize = true;
            this.lblMaximumTrialDays.BackColor = System.Drawing.Color.Transparent;
            this.lblMaximumTrialDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaximumTrialDays.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaximumTrialDays.Location = new System.Drawing.Point(0, 321);
            this.lblMaximumTrialDays.Name = "lblMaximumTrialDays";
            this.lblMaximumTrialDays.Size = new System.Drawing.Size(104, 13);
            this.lblMaximumTrialDays.TabIndex = 88;
            this.lblMaximumTrialDays.Text = "Maximum Trial Days:";
            // 
            // txtMonetarySymbol
            // 
            this.txtMonetarySymbol.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMonetarySymbol.Location = new System.Drawing.Point(0, 301);
            this.txtMonetarySymbol.Name = "txtMonetarySymbol";
            this.txtMonetarySymbol.Size = new System.Drawing.Size(454, 20);
            this.txtMonetarySymbol.TabIndex = 86;
            // 
            // lblMonetarySymbol
            // 
            this.lblMonetarySymbol.AutoSize = true;
            this.lblMonetarySymbol.BackColor = System.Drawing.Color.Transparent;
            this.lblMonetarySymbol.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMonetarySymbol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMonetarySymbol.Location = new System.Drawing.Point(0, 288);
            this.lblMonetarySymbol.Name = "lblMonetarySymbol";
            this.lblMonetarySymbol.Size = new System.Drawing.Size(91, 13);
            this.lblMonetarySymbol.TabIndex = 87;
            this.lblMonetarySymbol.Text = "Monetary Symbol:";
            // 
            // txtCompanyAddressLine6
            // 
            this.txtCompanyAddressLine6.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyAddressLine6.Location = new System.Drawing.Point(0, 268);
            this.txtCompanyAddressLine6.Name = "txtCompanyAddressLine6";
            this.txtCompanyAddressLine6.Size = new System.Drawing.Size(454, 20);
            this.txtCompanyAddressLine6.TabIndex = 7;
            // 
            // lblCompanyAddressLine6
            // 
            this.lblCompanyAddressLine6.AutoSize = true;
            this.lblCompanyAddressLine6.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyAddressLine6.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyAddressLine6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyAddressLine6.Location = new System.Drawing.Point(0, 255);
            this.lblCompanyAddressLine6.Name = "lblCompanyAddressLine6";
            this.lblCompanyAddressLine6.Size = new System.Drawing.Size(127, 13);
            this.lblCompanyAddressLine6.TabIndex = 85;
            this.lblCompanyAddressLine6.Text = "Company Address Line 6:";
            // 
            // txtCompanyAddressLine5
            // 
            this.txtCompanyAddressLine5.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyAddressLine5.Location = new System.Drawing.Point(0, 235);
            this.txtCompanyAddressLine5.Name = "txtCompanyAddressLine5";
            this.txtCompanyAddressLine5.Size = new System.Drawing.Size(454, 20);
            this.txtCompanyAddressLine5.TabIndex = 6;
            // 
            // lblCompanyAddressLine5
            // 
            this.lblCompanyAddressLine5.AutoSize = true;
            this.lblCompanyAddressLine5.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyAddressLine5.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyAddressLine5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyAddressLine5.Location = new System.Drawing.Point(0, 222);
            this.lblCompanyAddressLine5.Name = "lblCompanyAddressLine5";
            this.lblCompanyAddressLine5.Size = new System.Drawing.Size(127, 13);
            this.lblCompanyAddressLine5.TabIndex = 83;
            this.lblCompanyAddressLine5.Text = "Company Address Line 5:";
            // 
            // txtCompanyAddressLine4
            // 
            this.txtCompanyAddressLine4.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyAddressLine4.Location = new System.Drawing.Point(0, 202);
            this.txtCompanyAddressLine4.Name = "txtCompanyAddressLine4";
            this.txtCompanyAddressLine4.Size = new System.Drawing.Size(454, 20);
            this.txtCompanyAddressLine4.TabIndex = 5;
            // 
            // lblCompanyAddressLine4
            // 
            this.lblCompanyAddressLine4.AutoSize = true;
            this.lblCompanyAddressLine4.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyAddressLine4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyAddressLine4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyAddressLine4.Location = new System.Drawing.Point(0, 189);
            this.lblCompanyAddressLine4.Name = "lblCompanyAddressLine4";
            this.lblCompanyAddressLine4.Size = new System.Drawing.Size(127, 13);
            this.lblCompanyAddressLine4.TabIndex = 81;
            this.lblCompanyAddressLine4.Text = "Company Address Line 4:";
            // 
            // txtCompanyAddressLine3
            // 
            this.txtCompanyAddressLine3.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyAddressLine3.Location = new System.Drawing.Point(0, 169);
            this.txtCompanyAddressLine3.Name = "txtCompanyAddressLine3";
            this.txtCompanyAddressLine3.Size = new System.Drawing.Size(454, 20);
            this.txtCompanyAddressLine3.TabIndex = 4;
            // 
            // lblCompanyAddressLine3
            // 
            this.lblCompanyAddressLine3.AutoSize = true;
            this.lblCompanyAddressLine3.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyAddressLine3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyAddressLine3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyAddressLine3.Location = new System.Drawing.Point(0, 156);
            this.lblCompanyAddressLine3.Name = "lblCompanyAddressLine3";
            this.lblCompanyAddressLine3.Size = new System.Drawing.Size(127, 13);
            this.lblCompanyAddressLine3.TabIndex = 79;
            this.lblCompanyAddressLine3.Text = "Company Address Line 3:";
            // 
            // txtCompanyAddressLine2
            // 
            this.txtCompanyAddressLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyAddressLine2.Location = new System.Drawing.Point(0, 136);
            this.txtCompanyAddressLine2.Name = "txtCompanyAddressLine2";
            this.txtCompanyAddressLine2.Size = new System.Drawing.Size(454, 20);
            this.txtCompanyAddressLine2.TabIndex = 3;
            // 
            // lblCompanyAddressLine2
            // 
            this.lblCompanyAddressLine2.AutoSize = true;
            this.lblCompanyAddressLine2.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyAddressLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyAddressLine2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyAddressLine2.Location = new System.Drawing.Point(0, 123);
            this.lblCompanyAddressLine2.Name = "lblCompanyAddressLine2";
            this.lblCompanyAddressLine2.Size = new System.Drawing.Size(127, 13);
            this.lblCompanyAddressLine2.TabIndex = 77;
            this.lblCompanyAddressLine2.Text = "Company Address Line 2:";
            // 
            // txtCompanyAddressLine1
            // 
            this.txtCompanyAddressLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyAddressLine1.Location = new System.Drawing.Point(0, 103);
            this.txtCompanyAddressLine1.Name = "txtCompanyAddressLine1";
            this.txtCompanyAddressLine1.Size = new System.Drawing.Size(454, 20);
            this.txtCompanyAddressLine1.TabIndex = 2;
            // 
            // lblCompanyAddressLine1
            // 
            this.lblCompanyAddressLine1.AutoSize = true;
            this.lblCompanyAddressLine1.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyAddressLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyAddressLine1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyAddressLine1.Location = new System.Drawing.Point(0, 90);
            this.lblCompanyAddressLine1.Name = "lblCompanyAddressLine1";
            this.lblCompanyAddressLine1.Size = new System.Drawing.Size(127, 13);
            this.lblCompanyAddressLine1.TabIndex = 75;
            this.lblCompanyAddressLine1.Text = "Company Address Line 1:";
            // 
            // txtCompanyVatRegistrationNumber
            // 
            this.txtCompanyVatRegistrationNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyVatRegistrationNumber.Location = new System.Drawing.Point(0, 70);
            this.txtCompanyVatRegistrationNumber.Name = "txtCompanyVatRegistrationNumber";
            this.txtCompanyVatRegistrationNumber.Size = new System.Drawing.Size(454, 20);
            this.txtCompanyVatRegistrationNumber.TabIndex = 1;
            // 
            // lblCompanyVatRegistrationNumber
            // 
            this.lblCompanyVatRegistrationNumber.AutoSize = true;
            this.lblCompanyVatRegistrationNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyVatRegistrationNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyVatRegistrationNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyVatRegistrationNumber.Location = new System.Drawing.Point(0, 57);
            this.lblCompanyVatRegistrationNumber.Name = "lblCompanyVatRegistrationNumber";
            this.lblCompanyVatRegistrationNumber.Size = new System.Drawing.Size(177, 13);
            this.lblCompanyVatRegistrationNumber.TabIndex = 73;
            this.lblCompanyVatRegistrationNumber.Text = "Company VAT Registration Number:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyName.Location = new System.Drawing.Point(0, 37);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(454, 20);
            this.txtCompanyName.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyName.Location = new System.Drawing.Point(0, 24);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 59;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateAdd,
            this.mnuCancel});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(454, 24);
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
            // GlobalServerSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 459);
            this.KeyPreview = true;
            this.Name = "GlobalServerSettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "ManageGlobalServerSettingsForm";
            this.Load += new System.EventHandler(this.GlobalServerSettingsForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlobalServerSettingsForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlobalServerSettingsForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GlobalServerSettingsForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlobalServerSettingsForm_MouseMove);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gpbOptions.ResumeLayout(false);
            this.gpbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumTrialDays)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.GradientPanel pnlMain;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.TextBox txtCompanyVatRegistrationNumber;
        private System.Windows.Forms.Label lblCompanyVatRegistrationNumber;
        private System.Windows.Forms.TextBox txtCompanyAddressLine6;
        private System.Windows.Forms.Label lblCompanyAddressLine6;
        private System.Windows.Forms.TextBox txtCompanyAddressLine5;
        private System.Windows.Forms.Label lblCompanyAddressLine5;
        private System.Windows.Forms.TextBox txtCompanyAddressLine4;
        private System.Windows.Forms.Label lblCompanyAddressLine4;
        private System.Windows.Forms.TextBox txtCompanyAddressLine3;
        private System.Windows.Forms.Label lblCompanyAddressLine3;
        private System.Windows.Forms.TextBox txtCompanyAddressLine2;
        private System.Windows.Forms.Label lblCompanyAddressLine2;
        private System.Windows.Forms.TextBox txtCompanyAddressLine1;
        private System.Windows.Forms.Label lblCompanyAddressLine1;
        private System.Windows.Forms.TextBox txtMonetarySymbol;
        private System.Windows.Forms.Label lblMonetarySymbol;
        private System.Windows.Forms.Label lblMaximumTrialDays;
        private System.Windows.Forms.NumericUpDown nudMaximumTrialDays;
        private System.Windows.Forms.GroupBox gpbOptions;
        private System.Windows.Forms.CheckBox chkEmailDevicePendingApproval;
        private System.Windows.Forms.CheckBox chkLogActionGetDeviceConfig;

    }
}