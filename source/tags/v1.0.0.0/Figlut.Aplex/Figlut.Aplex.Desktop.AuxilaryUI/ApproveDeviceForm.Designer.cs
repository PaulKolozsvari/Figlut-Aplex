namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class ApproveDeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveDeviceForm));
            this.pnlMain = new Figlut.Desktop.Controls.GradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerCompanyName = new System.Windows.Forms.TextBox();
            this.btnSelectCustomer = new Figlut.Desktop.Controls.GradientButton();
            this.lblCustomerCompanyName = new System.Windows.Forms.Label();
            this.nudDaysToActivate = new System.Windows.Forms.NumericUpDown();
            this.lblDaysToActivate = new System.Windows.Forms.Label();
            this.txtFiglutWebServiceURL = new System.Windows.Forms.TextBox();
            this.lblFiglutWebServiceURL = new System.Windows.Forms.Label();
            this.txtApplicationReplicationWebServiceURL = new System.Windows.Forms.TextBox();
            this.lblApplicationReplicationWebServiceURL = new System.Windows.Forms.Label();
            this.txtApplicationWebServiceURL = new System.Windows.Forms.TextBox();
            this.lblApplicationWebserviceURL = new System.Windows.Forms.Label();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFormContent.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToActivate)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(495, 21);
            this.lblFormTitle.Text = "Approve Device ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ApproveDeviceForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ApproveDeviceForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ApproveDeviceForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 294);
            this.statusMain.Size = new System.Drawing.Size(495, 21);
            this.statusMain.Text = "Enter device configuration and approve device.";
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlMain);
            this.pnlFormContent.Size = new System.Drawing.Size(465, 273);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 273);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(480, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 273);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.lblCustomerCompanyName);
            this.pnlMain.Controls.Add(this.nudDaysToActivate);
            this.pnlMain.Controls.Add(this.lblDaysToActivate);
            this.pnlMain.Controls.Add(this.txtFiglutWebServiceURL);
            this.pnlMain.Controls.Add(this.lblFiglutWebServiceURL);
            this.pnlMain.Controls.Add(this.txtApplicationReplicationWebServiceURL);
            this.pnlMain.Controls.Add(this.lblApplicationReplicationWebServiceURL);
            this.pnlMain.Controls.Add(this.txtApplicationWebServiceURL);
            this.pnlMain.Controls.Add(this.lblApplicationWebserviceURL);
            this.pnlMain.Controls.Add(this.txtApplicationName);
            this.pnlMain.Controls.Add(this.lblApplicationName);
            this.pnlMain.Controls.Add(this.txtDeviceId);
            this.pnlMain.Controls.Add(this.lblDeviceId);
            this.pnlMain.Controls.Add(this.mnuMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMain.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(465, 273);
            this.pnlMain.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtCustomerCompanyName);
            this.panel3.Controls.Add(this.btnSelectCustomer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 23);
            this.panel3.TabIndex = 499;
            // 
            // txtCustomerCompanyName
            // 
            this.txtCustomerCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerCompanyName.Location = new System.Drawing.Point(0, 0);
            this.txtCustomerCompanyName.Name = "txtCustomerCompanyName";
            this.txtCustomerCompanyName.ReadOnly = true;
            this.txtCustomerCompanyName.Size = new System.Drawing.Size(436, 20);
            this.txtCustomerCompanyName.TabIndex = 495;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectCustomer.BackgroundImage")));
            this.btnSelectCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectCustomer.GradientEndColor = System.Drawing.Color.DimGray;
            this.btnSelectCustomer.GradientStartColor = System.Drawing.Color.DarkGray;
            this.btnSelectCustomer.Location = new System.Drawing.Point(436, 0);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(29, 23);
            this.btnSelectCustomer.TabIndex = 494;
            this.btnSelectCustomer.Text = "...";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // lblCustomerCompanyName
            // 
            this.lblCustomerCompanyName.AutoSize = true;
            this.lblCustomerCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomerCompanyName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomerCompanyName.Location = new System.Drawing.Point(0, 222);
            this.lblCustomerCompanyName.Name = "lblCustomerCompanyName";
            this.lblCustomerCompanyName.Size = new System.Drawing.Size(132, 13);
            this.lblCustomerCompanyName.TabIndex = 498;
            this.lblCustomerCompanyName.Text = "Customer Company Name:";
            // 
            // nudDaysToActivate
            // 
            this.nudDaysToActivate.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudDaysToActivate.Location = new System.Drawing.Point(0, 202);
            this.nudDaysToActivate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudDaysToActivate.Name = "nudDaysToActivate";
            this.nudDaysToActivate.Size = new System.Drawing.Size(465, 20);
            this.nudDaysToActivate.TabIndex = 497;
            // 
            // lblDaysToActivate
            // 
            this.lblDaysToActivate.AutoSize = true;
            this.lblDaysToActivate.BackColor = System.Drawing.Color.Transparent;
            this.lblDaysToActivate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDaysToActivate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDaysToActivate.Location = new System.Drawing.Point(0, 189);
            this.lblDaysToActivate.Name = "lblDaysToActivate";
            this.lblDaysToActivate.Size = new System.Drawing.Size(92, 13);
            this.lblDaysToActivate.TabIndex = 69;
            this.lblDaysToActivate.Text = "Days To Activate:";
            // 
            // txtFiglutWebServiceURL
            // 
            this.txtFiglutWebServiceURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFiglutWebServiceURL.Location = new System.Drawing.Point(0, 169);
            this.txtFiglutWebServiceURL.Name = "txtFiglutWebServiceURL";
            this.txtFiglutWebServiceURL.Size = new System.Drawing.Size(465, 20);
            this.txtFiglutWebServiceURL.TabIndex = 66;
            // 
            // lblFiglutWebServiceURL
            // 
            this.lblFiglutWebServiceURL.AutoSize = true;
            this.lblFiglutWebServiceURL.BackColor = System.Drawing.Color.Transparent;
            this.lblFiglutWebServiceURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiglutWebServiceURL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiglutWebServiceURL.Location = new System.Drawing.Point(0, 156);
            this.lblFiglutWebServiceURL.Name = "lblFiglutWebServiceURL";
            this.lblFiglutWebServiceURL.Size = new System.Drawing.Size(159, 13);
            this.lblFiglutWebServiceURL.TabIndex = 67;
            this.lblFiglutWebServiceURL.Text = "Client Config Web Service URL:";
            // 
            // txtApplicationReplicationWebServiceURL
            // 
            this.txtApplicationReplicationWebServiceURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApplicationReplicationWebServiceURL.Location = new System.Drawing.Point(0, 136);
            this.txtApplicationReplicationWebServiceURL.Name = "txtApplicationReplicationWebServiceURL";
            this.txtApplicationReplicationWebServiceURL.Size = new System.Drawing.Size(465, 20);
            this.txtApplicationReplicationWebServiceURL.TabIndex = 64;
            // 
            // lblApplicationReplicationWebServiceURL
            // 
            this.lblApplicationReplicationWebServiceURL.AutoSize = true;
            this.lblApplicationReplicationWebServiceURL.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationReplicationWebServiceURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApplicationReplicationWebServiceURL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApplicationReplicationWebServiceURL.Location = new System.Drawing.Point(0, 123);
            this.lblApplicationReplicationWebServiceURL.Name = "lblApplicationReplicationWebServiceURL";
            this.lblApplicationReplicationWebServiceURL.Size = new System.Drawing.Size(208, 13);
            this.lblApplicationReplicationWebServiceURL.TabIndex = 65;
            this.lblApplicationReplicationWebServiceURL.Text = "Application Replication Web Service URL:";
            // 
            // txtApplicationWebServiceURL
            // 
            this.txtApplicationWebServiceURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApplicationWebServiceURL.Location = new System.Drawing.Point(0, 103);
            this.txtApplicationWebServiceURL.Name = "txtApplicationWebServiceURL";
            this.txtApplicationWebServiceURL.Size = new System.Drawing.Size(465, 20);
            this.txtApplicationWebServiceURL.TabIndex = 62;
            // 
            // lblApplicationWebserviceURL
            // 
            this.lblApplicationWebserviceURL.AutoSize = true;
            this.lblApplicationWebserviceURL.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationWebserviceURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApplicationWebserviceURL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApplicationWebserviceURL.Location = new System.Drawing.Point(0, 90);
            this.lblApplicationWebserviceURL.Name = "lblApplicationWebserviceURL";
            this.lblApplicationWebserviceURL.Size = new System.Drawing.Size(152, 13);
            this.lblApplicationWebserviceURL.TabIndex = 63;
            this.lblApplicationWebserviceURL.Text = "Application Web Service URL:";
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApplicationName.Location = new System.Drawing.Point(0, 70);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.ReadOnly = true;
            this.txtApplicationName.Size = new System.Drawing.Size(465, 20);
            this.txtApplicationName.TabIndex = 60;
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApplicationName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApplicationName.Location = new System.Drawing.Point(0, 57);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(93, 13);
            this.lblApplicationName.TabIndex = 61;
            this.lblApplicationName.Text = "Application Name:";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDeviceId.Location = new System.Drawing.Point(0, 37);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.ReadOnly = true;
            this.txtDeviceId.Size = new System.Drawing.Size(465, 20);
            this.txtDeviceId.TabIndex = 58;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeviceId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeviceId.Location = new System.Drawing.Point(0, 24);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(56, 13);
            this.lblDeviceId.TabIndex = 59;
            this.lblDeviceId.Text = "Device Id:";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuApprove,
            this.mnuCancel});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(465, 24);
            this.mnuMain.TabIndex = 57;
            this.mnuMain.Text = "customMainMenu1";
            // 
            // mnuApprove
            // 
            this.mnuApprove.Name = "mnuApprove";
            this.mnuApprove.Size = new System.Drawing.Size(64, 20);
            this.mnuApprove.Text = "Approve";
            this.mnuApprove.Click += new System.EventHandler(this.mnuApprove_Click);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(55, 20);
            this.mnuCancel.Text = "&Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // ApproveDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 315);
            this.FormTitle = "Approve Device";
            this.KeyPreview = true;
            this.Name = "ApproveDeviceForm";
            this.ShowInTaskbar = false;
            this.Status = "Enter device configuration and approve device.";
            this.Text = "Approve Device";
            this.Load += new System.EventHandler(this.ApproveDeviceForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ApproveDeviceForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ApproveDeviceForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ApproveDeviceForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ApproveDeviceForm_MouseMove);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToActivate)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.GradientPanel pnlMain;
        private System.Windows.Forms.Label lblDaysToActivate;
        private System.Windows.Forms.TextBox txtFiglutWebServiceURL;
        private System.Windows.Forms.Label lblFiglutWebServiceURL;
        private System.Windows.Forms.TextBox txtApplicationReplicationWebServiceURL;
        private System.Windows.Forms.Label lblApplicationReplicationWebServiceURL;
        private System.Windows.Forms.TextBox txtApplicationWebServiceURL;
        private System.Windows.Forms.Label lblApplicationWebserviceURL;
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblDeviceId;
        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuApprove;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.NumericUpDown nudDaysToActivate;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.TextBox txtCustomerCompanyName;
        private Figlut.Desktop.Controls.GradientButton btnSelectCustomer;
        protected System.Windows.Forms.Label lblCustomerCompanyName;
    }
}