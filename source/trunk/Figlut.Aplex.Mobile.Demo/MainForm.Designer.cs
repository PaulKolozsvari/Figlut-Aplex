namespace Figlut.Aplex.Mobile.Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mnuMain;

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
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuMenu = new System.Windows.Forms.MenuItem();
            this.mnuDeviceInfo = new System.Windows.Forms.MenuItem();
            this.mnuConfigure = new System.Windows.Forms.MenuItem();
            this.mnuGetDeviceConfig = new System.Windows.Forms.MenuItem();
            this.mnuLogDeviceAction = new System.Windows.Forms.MenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // statusMain
            // 
            this.statusMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.statusMain.Location = new System.Drawing.Point(0, 246);
            this.statusMain.Size = new System.Drawing.Size(240, 22);
            this.statusMain.Text = "Select menu option.";
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuExit);
            this.mnuMain.MenuItems.Add(this.mnuMenu);
            // 
            // mnuExit
            // 
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.MenuItems.Add(this.mnuDeviceInfo);
            this.mnuMenu.MenuItems.Add(this.mnuConfigure);
            this.mnuMenu.MenuItems.Add(this.mnuGetDeviceConfig);
            this.mnuMenu.MenuItems.Add(this.mnuLogDeviceAction);
            this.mnuMenu.Text = "Menu";
            // 
            // mnuDeviceInfo
            // 
            this.mnuDeviceInfo.Text = "Device Info";
            this.mnuDeviceInfo.Click += new System.EventHandler(this.mnuDeviceInfo_Click);
            // 
            // mnuConfigure
            // 
            this.mnuConfigure.Text = "Configure";
            this.mnuConfigure.Click += new System.EventHandler(this.mnuConfigure_Click);
            // 
            // mnuGetDeviceConfig
            // 
            this.mnuGetDeviceConfig.Text = "Get Device Config";
            this.mnuGetDeviceConfig.Click += new System.EventHandler(this.mnuGetDeviceConfig_Click);
            // 
            // mnuLogDeviceAction
            // 
            this.mnuLogDeviceAction.Text = "Log Device Action";
            this.mnuLogDeviceAction.Click += new System.EventHandler(this.mnuLogDeviceAction_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(3, 82);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 20);
            this.lblInfo.Text = "Info:";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(3, 105);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(234, 135);
            this.txtInfo.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtInfo);
            this.Menu = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "Figlut Figlut Mobile Demo";
            this.Controls.SetChildIndex(this.txtInfo, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.statusMain, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuMenu;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.MenuItem mnuDeviceInfo;
        private System.Windows.Forms.MenuItem mnuGetDeviceConfig;
        private System.Windows.Forms.MenuItem mnuConfigure;
        private System.Windows.Forms.MenuItem mnuLogDeviceAction;
    }
}

