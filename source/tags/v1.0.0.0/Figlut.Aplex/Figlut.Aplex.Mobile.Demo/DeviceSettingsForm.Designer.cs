namespace Figlut.Aplex.Mobile.Demo
{
    partial class DeviceSettingsForm
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
            this.mnuBack = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.lblApplicationWebServiceUrl = new System.Windows.Forms.Label();
            this.txtApplicationWebServiceUrl = new System.Windows.Forms.TextBox();
            this.txtApplicationReplicationWebServiceUrl = new System.Windows.Forms.TextBox();
            this.lblApplicationReplicationWebServiceUrl = new System.Windows.Forms.Label();
            this.txtFiglutWebServiceUrl = new System.Windows.Forms.TextBox();
            this.lblFiglutWebServiceUrl = new System.Windows.Forms.Label();
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
            this.statusMain.Text = "Configure device settings.";
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuBack);
            this.mnuMain.MenuItems.Add(this.mnuSave);
            // 
            // mnuBack
            // 
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // lblApplicationWebServiceUrl
            // 
            this.lblApplicationWebServiceUrl.Location = new System.Drawing.Point(3, 82);
            this.lblApplicationWebServiceUrl.Name = "lblApplicationWebServiceUrl";
            this.lblApplicationWebServiceUrl.Size = new System.Drawing.Size(234, 20);
            this.lblApplicationWebServiceUrl.Text = "Application Web Service URL:";
            // 
            // txtApplicationWebServiceUrl
            // 
            this.txtApplicationWebServiceUrl.Location = new System.Drawing.Point(3, 105);
            this.txtApplicationWebServiceUrl.Name = "txtApplicationWebServiceUrl";
            this.txtApplicationWebServiceUrl.Size = new System.Drawing.Size(234, 21);
            this.txtApplicationWebServiceUrl.TabIndex = 4;
            // 
            // txtApplicationReplicationWebServiceUrl
            // 
            this.txtApplicationReplicationWebServiceUrl.Location = new System.Drawing.Point(3, 152);
            this.txtApplicationReplicationWebServiceUrl.Name = "txtApplicationReplicationWebServiceUrl";
            this.txtApplicationReplicationWebServiceUrl.Size = new System.Drawing.Size(234, 21);
            this.txtApplicationReplicationWebServiceUrl.TabIndex = 6;
            // 
            // lblApplicationReplicationWebServiceUrl
            // 
            this.lblApplicationReplicationWebServiceUrl.Location = new System.Drawing.Point(3, 129);
            this.lblApplicationReplicationWebServiceUrl.Name = "lblApplicationReplicationWebServiceUrl";
            this.lblApplicationReplicationWebServiceUrl.Size = new System.Drawing.Size(234, 20);
            this.lblApplicationReplicationWebServiceUrl.Text = "Application Replication Web Service URL:";
            // 
            // txtFiglutWebServiceUrl
            // 
            this.txtFiglutWebServiceUrl.Location = new System.Drawing.Point(3, 199);
            this.txtFiglutWebServiceUrl.Name = "txtFiglutWebServiceUrl";
            this.txtFiglutWebServiceUrl.Size = new System.Drawing.Size(234, 21);
            this.txtFiglutWebServiceUrl.TabIndex = 9;
            // 
            // lblFiglutWebServiceUrl
            // 
            this.lblFiglutWebServiceUrl.Location = new System.Drawing.Point(3, 176);
            this.lblFiglutWebServiceUrl.Name = "lblFiglutWebServiceUrl";
            this.lblFiglutWebServiceUrl.Size = new System.Drawing.Size(234, 20);
            this.lblFiglutWebServiceUrl.Text = "Figlut Web Service URL:";
            // 
            // DeviceSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtFiglutWebServiceUrl);
            this.Controls.Add(this.lblFiglutWebServiceUrl);
            this.Controls.Add(this.txtApplicationReplicationWebServiceUrl);
            this.Controls.Add(this.lblApplicationReplicationWebServiceUrl);
            this.Controls.Add(this.txtApplicationWebServiceUrl);
            this.Controls.Add(this.lblApplicationWebServiceUrl);
            this.Menu = this.mnuMain;
            this.Name = "DeviceSettingsForm";
            this.Text = "Device Settings";
            this.Load += new System.EventHandler(this.DeviceSettingsForm_Load);
            this.Controls.SetChildIndex(this.statusMain, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.Controls.SetChildIndex(this.lblApplicationWebServiceUrl, 0);
            this.Controls.SetChildIndex(this.txtApplicationWebServiceUrl, 0);
            this.Controls.SetChildIndex(this.lblApplicationReplicationWebServiceUrl, 0);
            this.Controls.SetChildIndex(this.txtApplicationReplicationWebServiceUrl, 0);
            this.Controls.SetChildIndex(this.lblFiglutWebServiceUrl, 0);
            this.Controls.SetChildIndex(this.txtFiglutWebServiceUrl, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem mnuBack;
        private System.Windows.Forms.MenuItem mnuSave;
        private System.Windows.Forms.Label lblApplicationWebServiceUrl;
        private System.Windows.Forms.TextBox txtApplicationWebServiceUrl;
        private System.Windows.Forms.TextBox txtApplicationReplicationWebServiceUrl;
        private System.Windows.Forms.Label lblApplicationReplicationWebServiceUrl;
        private System.Windows.Forms.TextBox txtFiglutWebServiceUrl;
        private System.Windows.Forms.Label lblFiglutWebServiceUrl;
    }
}