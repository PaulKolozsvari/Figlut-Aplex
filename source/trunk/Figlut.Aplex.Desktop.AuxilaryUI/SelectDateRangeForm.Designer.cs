namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class SelectDateRangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDateRangeForm));
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCustomers = new Figlut.Desktop.Controls.GradientPanel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.pnlFormContent.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(353, 21);
            this.lblFormTitle.Text = "Date Range ";
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 123);
            this.statusMain.Size = new System.Drawing.Size(353, 21);
            this.statusMain.Text = "Select date range.";
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlCustomers);
            this.pnlFormContent.Controls.Add(this.mnuMain);
            this.pnlFormContent.Size = new System.Drawing.Size(323, 102);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 102);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(338, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 102);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelect,
            this.mnuCancel});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(323, 24);
            this.mnuMain.TabIndex = 161;
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
            this.pnlCustomers.Controls.Add(this.dtpEndDate);
            this.pnlCustomers.Controls.Add(this.lblEndDate);
            this.pnlCustomers.Controls.Add(this.dtpStartDate);
            this.pnlCustomers.Controls.Add(this.lblStartDate);
            this.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomers.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlCustomers.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlCustomers.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlCustomers.Location = new System.Drawing.Point(0, 24);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(323, 78);
            this.pnlCustomers.TabIndex = 162;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpEndDate.Location = new System.Drawing.Point(0, 46);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(323, 20);
            this.dtpEndDate.TabIndex = 126;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEndDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndDate.Location = new System.Drawing.Point(0, 33);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 125;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpStartDate.Location = new System.Drawing.Point(0, 13);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(323, 20);
            this.dtpStartDate.TabIndex = 124;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStartDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartDate.Location = new System.Drawing.Point(0, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 123;
            this.lblStartDate.Text = "Start Date:";
            // 
            // SelectDateRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 144);
            this.FormTitle = "Date Range";
            this.KeyPreview = true;
            this.Name = "SelectDateRangeForm";
            this.ShowInTaskbar = false;
            this.Status = "Select date range.";
            this.Text = "Date Range";
            this.Load += new System.EventHandler(this.SelectDateRangeForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectDateRangeForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectDateRangeForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectDateRangeForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectDateRangeForm_MouseMove);
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
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
    }
}