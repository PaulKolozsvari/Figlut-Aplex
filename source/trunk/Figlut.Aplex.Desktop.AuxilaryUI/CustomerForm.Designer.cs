namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.pnlMain = new Figlut.Desktop.Controls.GradientPanel();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtPostalAddress = new System.Windows.Forms.TextBox();
            this.lblPostalAddress = new System.Windows.Forms.Label();
            this.txtPhysicalAddress = new System.Windows.Forms.TextBox();
            this.lblPhysicalAddress = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuUpdateAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFormContent.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(495, 21);
            this.lblFormTitle.Text = " ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomerForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomerForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomerForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 257);
            this.statusMain.Size = new System.Drawing.Size(495, 21);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlMain);
            this.pnlFormContent.Size = new System.Drawing.Size(465, 236);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 236);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(480, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 236);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.txtContactEmail);
            this.pnlMain.Controls.Add(this.lblContactEmail);
            this.pnlMain.Controls.Add(this.txtContactNumber);
            this.pnlMain.Controls.Add(this.lblContactNumber);
            this.pnlMain.Controls.Add(this.txtContactName);
            this.pnlMain.Controls.Add(this.lblContactName);
            this.pnlMain.Controls.Add(this.txtPostalAddress);
            this.pnlMain.Controls.Add(this.lblPostalAddress);
            this.pnlMain.Controls.Add(this.txtPhysicalAddress);
            this.pnlMain.Controls.Add(this.lblPhysicalAddress);
            this.pnlMain.Controls.Add(this.txtCompanyName);
            this.pnlMain.Controls.Add(this.lblCompanyName);
            this.pnlMain.Controls.Add(this.mnuMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMain.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(465, 236);
            this.pnlMain.TabIndex = 3;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContactEmail.Location = new System.Drawing.Point(0, 202);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(465, 20);
            this.txtContactEmail.TabIndex = 68;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblContactEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContactEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContactEmail.Location = new System.Drawing.Point(0, 189);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(75, 13);
            this.lblContactEmail.TabIndex = 69;
            this.lblContactEmail.Text = "Contact Email:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContactNumber.Location = new System.Drawing.Point(0, 169);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(465, 20);
            this.txtContactNumber.TabIndex = 66;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContactNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContactNumber.Location = new System.Drawing.Point(0, 156);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 67;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtContactName
            // 
            this.txtContactName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContactName.Location = new System.Drawing.Point(0, 136);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(465, 20);
            this.txtContactName.TabIndex = 64;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.BackColor = System.Drawing.Color.Transparent;
            this.lblContactName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContactName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContactName.Location = new System.Drawing.Point(0, 123);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(78, 13);
            this.lblContactName.TabIndex = 65;
            this.lblContactName.Text = "Contact Name:";
            // 
            // txtPostalAddress
            // 
            this.txtPostalAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPostalAddress.Location = new System.Drawing.Point(0, 103);
            this.txtPostalAddress.Name = "txtPostalAddress";
            this.txtPostalAddress.Size = new System.Drawing.Size(465, 20);
            this.txtPostalAddress.TabIndex = 62;
            // 
            // lblPostalAddress
            // 
            this.lblPostalAddress.AutoSize = true;
            this.lblPostalAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblPostalAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPostalAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPostalAddress.Location = new System.Drawing.Point(0, 90);
            this.lblPostalAddress.Name = "lblPostalAddress";
            this.lblPostalAddress.Size = new System.Drawing.Size(80, 13);
            this.lblPostalAddress.TabIndex = 63;
            this.lblPostalAddress.Text = "Postal Address:";
            // 
            // txtPhysicalAddress
            // 
            this.txtPhysicalAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhysicalAddress.Location = new System.Drawing.Point(0, 70);
            this.txtPhysicalAddress.Name = "txtPhysicalAddress";
            this.txtPhysicalAddress.Size = new System.Drawing.Size(465, 20);
            this.txtPhysicalAddress.TabIndex = 60;
            // 
            // lblPhysicalAddress
            // 
            this.lblPhysicalAddress.AutoSize = true;
            this.lblPhysicalAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblPhysicalAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhysicalAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhysicalAddress.Location = new System.Drawing.Point(0, 57);
            this.lblPhysicalAddress.Name = "lblPhysicalAddress";
            this.lblPhysicalAddress.Size = new System.Drawing.Size(90, 13);
            this.lblPhysicalAddress.TabIndex = 61;
            this.lblPhysicalAddress.Text = "Physical Address:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyName.Location = new System.Drawing.Point(0, 37);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(465, 20);
            this.txtCompanyName.TabIndex = 58;
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 278);
            this.KeyPreview = true;
            this.Name = "CustomerForm";
            this.ShowInTaskbar = false;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomerForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomerForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomerForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomerForm_MouseMove);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
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
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtPostalAddress;
        private System.Windows.Forms.Label lblPostalAddress;
        private System.Windows.Forms.TextBox txtPhysicalAddress;
        private System.Windows.Forms.Label lblPhysicalAddress;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label lblContactEmail;


    }
}