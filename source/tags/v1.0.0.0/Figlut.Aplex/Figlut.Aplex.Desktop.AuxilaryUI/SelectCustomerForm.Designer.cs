namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class SelectCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCustomerForm));
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCustomers = new Figlut.Desktop.Controls.GradientPanel();
            this.lstCustomers = new Figlut.Desktop.Controls.CustomListBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlFormContent.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(422, 21);
            this.lblFormTitle.Text = "Select Customer ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectCustomerForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectCustomerForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectCustomerForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 219);
            this.statusMain.Size = new System.Drawing.Size(422, 21);
            this.statusMain.Text = "Select customer company name.";
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlCustomers);
            this.pnlFormContent.Controls.Add(this.mnuMain);
            this.pnlFormContent.Size = new System.Drawing.Size(392, 198);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 198);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(407, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 198);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelect,
            this.mnuCancel});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(392, 24);
            this.mnuMain.TabIndex = 160;
            this.mnuMain.Text = "customMainMenu1";
            // 
            // mnuSelect
            // 
            this.mnuSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(50, 20);
            this.mnuSelect.Text = "&Select";
            this.mnuSelect.Click += new System.EventHandler(this.mnuSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(57, 6);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(55, 20);
            this.mnuCancel.Text = "&Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCustomers.BackgroundImage")));
            this.pnlCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCustomers.Controls.Add(this.lstCustomers);
            this.pnlCustomers.Controls.Add(this.txtCompanyName);
            this.pnlCustomers.Controls.Add(this.lblCompanyName);
            this.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomers.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlCustomers.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlCustomers.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlCustomers.Location = new System.Drawing.Point(0, 24);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(392, 174);
            this.pnlCustomers.TabIndex = 161;
            // 
            // lstCustomers
            // 
            this.lstCustomers.BackColor = System.Drawing.Color.White;
            this.lstCustomers.BackEndColor = System.Drawing.Color.LightGray;
            this.lstCustomers.BackStartColor = System.Drawing.Color.WhiteSmoke;
            this.lstCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(0, 33);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.ScrollAlwaysVisible = true;
            this.lstCustomers.Size = new System.Drawing.Size(392, 134);
            this.lstCustomers.TabIndex = 123;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompanyName.Location = new System.Drawing.Point(0, 13);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(392, 20);
            this.txtCompanyName.TabIndex = 121;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyName.Location = new System.Drawing.Point(0, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 122;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // SelectCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 240);
            this.FormTitle = "Select Customer";
            this.KeyPreview = true;
            this.Name = "SelectCustomerForm";
            this.ShowInTaskbar = false;
            this.Status = "Select customer company name.";
            this.Text = "SelectCustomerForm";
            this.Load += new System.EventHandler(this.SelectCustomerForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectCustomerForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectCustomerForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectCustomerForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectCustomerForm_MouseMove);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlFormContent.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlCustomers.ResumeLayout(false);
            this.pnlCustomers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private Figlut.Desktop.Controls.GradientPanel pnlCustomers;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private Figlut.Desktop.Controls.CustomListBox lstCustomers;
    }
}