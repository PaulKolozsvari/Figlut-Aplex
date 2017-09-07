namespace Figlut.Aplex.Desktop.Controls
{
    partial class DeviceConfigControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceConfigControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.svdExport = new System.Windows.Forms.SaveFileDialog();
            this.opdImport = new System.Windows.Forms.OpenFileDialog();
            this.svdExportItem = new System.Windows.Forms.SaveFileDialog();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnTimesheetAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.splTimesheet = new System.Windows.Forms.SplitContainer();
            this.gradientPanelTimesheetInputs = new Figlut.Desktop.Controls.GradientPanel();
            this.tabDeviceConfigInfo = new Figlut.Desktop.Controls.CustomTab();
            this.tabPageDeviceConfigInputs = new System.Windows.Forms.TabPage();
            this.pnlDeviceConfigInputs = new Figlut.Desktop.Controls.GradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerCompanyName = new System.Windows.Forms.TextBox();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.lblCustomerCompanyName = new System.Windows.Forms.Label();
            this.dtpLicenseExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblLicenseExpiryDate = new System.Windows.Forms.Label();
            this.txtClientConfigWebServiceUrl = new System.Windows.Forms.TextBox();
            this.lblFiglutWebServiceUrl = new System.Windows.Forms.Label();
            this.txtApplicationReplicationWebServiceUrl = new System.Windows.Forms.TextBox();
            this.lblApplicationReplicationWebServiceUrl = new System.Windows.Forms.Label();
            this.txtApplicationWebServiceUrl = new System.Windows.Forms.TextBox();
            this.lblApplicationWebServiceUrl = new System.Windows.Forms.Label();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkClearDeviceConfigInputControls = new System.Windows.Forms.LinkLabel();
            this.tabPageDeviceConfigFilters = new System.Windows.Forms.TabPage();
            this.pnlFilters = new Figlut.Desktop.Controls.GradientPanel();
            this.chkFilterExpired = new System.Windows.Forms.CheckBox();
            this.txtFilterApplicationName = new System.Windows.Forms.TextBox();
            this.lblFilterApplicationName = new System.Windows.Forms.Label();
            this.txtFilterDeviceId = new System.Windows.Forms.TextBox();
            this.lblFilterDeviceId = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lnkClearDeviceConfigFilterControls = new System.Windows.Forms.LinkLabel();
            this.gradientPanelTimesheetItems = new Figlut.Desktop.Controls.GradientPanel();
            this.grdDeviceConfigs = new Figlut.Desktop.Controls.CustomDataGridView();
            this.lblDeviceConfigs = new System.Windows.Forms.Label();
            this.toolStripDeviceConfigs = new Figlut.Desktop.Controls.CustomToolStrip();
            this.tsDeviceConfigAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDeviceConfigUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsDeviceConfigUpdateCommit = new System.Windows.Forms.ToolStripButton();
            this.tsDeviceConfigUpdateCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDeviceConfigDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDeviceConfigFiltersEnable = new System.Windows.Forms.ToolStripButton();
            this.tsDeviceConfigFiltersDisable = new System.Windows.Forms.ToolStripButton();
            this.chkNotifyOnInactivity = new System.Windows.Forms.CheckBox();
            this.splTimesheet.Panel1.SuspendLayout();
            this.splTimesheet.Panel2.SuspendLayout();
            this.splTimesheet.SuspendLayout();
            this.gradientPanelTimesheetInputs.SuspendLayout();
            this.tabDeviceConfigInfo.SuspendLayout();
            this.tabPageDeviceConfigInputs.SuspendLayout();
            this.pnlDeviceConfigInputs.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageDeviceConfigFilters.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.panel7.SuspendLayout();
            this.gradientPanelTimesheetItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeviceConfigs)).BeginInit();
            this.toolStripDeviceConfigs.SuspendLayout();
            this.SuspendLayout();
            // 
            // svdExport
            // 
            this.svdExport.DefaultExt = "csv";
            this.svdExport.Filter = "Csv Files|*.csv";
            // 
            // opdImport
            // 
            this.opdImport.DefaultExt = "csv";
            this.opdImport.Filter = "Csv Files|*.csv";
            // 
            // svdExportItem
            // 
            this.svdExportItem.DefaultExt = "pdf";
            this.svdExportItem.Filter = "PDF Files|*.pdf";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox2.Enabled = false;
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(137, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 27);
            this.checkBox2.TabIndex = 426;
            this.checkBox2.Text = "Paid";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox3.Enabled = false;
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Location = new System.Drawing.Point(62, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 27);
            this.checkBox3.TabIndex = 425;
            this.checkBox3.Text = "Sunk Cost";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(0, 0);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(62, 27);
            this.checkBox4.TabIndex = 424;
            this.checkBox4.Text = "Billable ";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // btnTimesheetAdd
            // 
            this.btnTimesheetAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTimesheetAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnTimesheetAdd.Image")));
            this.btnTimesheetAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimesheetAdd.Name = "btnTimesheetAdd";
            this.btnTimesheetAdd.Size = new System.Drawing.Size(23, 22);
            this.btnTimesheetAdd.Text = "Add";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // splTimesheet
            // 
            this.splTimesheet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splTimesheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splTimesheet.Location = new System.Drawing.Point(0, 25);
            this.splTimesheet.Name = "splTimesheet";
            // 
            // splTimesheet.Panel1
            // 
            this.splTimesheet.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splTimesheet.Panel1.Controls.Add(this.gradientPanelTimesheetInputs);
            this.splTimesheet.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splTimesheet.Panel2
            // 
            this.splTimesheet.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splTimesheet.Panel2.Controls.Add(this.gradientPanelTimesheetItems);
            this.splTimesheet.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splTimesheet.Size = new System.Drawing.Size(851, 595);
            this.splTimesheet.SplitterDistance = 283;
            this.splTimesheet.TabIndex = 2;
            // 
            // gradientPanelTimesheetInputs
            // 
            this.gradientPanelTimesheetInputs.AutoScroll = true;
            this.gradientPanelTimesheetInputs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelTimesheetInputs.BackgroundImage")));
            this.gradientPanelTimesheetInputs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelTimesheetInputs.Controls.Add(this.tabDeviceConfigInfo);
            this.gradientPanelTimesheetInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelTimesheetInputs.GradientEndColor = System.Drawing.Color.LightGray;
            this.gradientPanelTimesheetInputs.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanelTimesheetInputs.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.gradientPanelTimesheetInputs.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelTimesheetInputs.Name = "gradientPanelTimesheetInputs";
            this.gradientPanelTimesheetInputs.Size = new System.Drawing.Size(283, 595);
            this.gradientPanelTimesheetInputs.TabIndex = 267;
            // 
            // tabDeviceConfigInfo
            // 
            this.tabDeviceConfigInfo.Controls.Add(this.tabPageDeviceConfigInputs);
            this.tabDeviceConfigInfo.Controls.Add(this.tabPageDeviceConfigFilters);
            this.tabDeviceConfigInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDeviceConfigInfo.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabDeviceConfigInfo.Location = new System.Drawing.Point(0, 0);
            this.tabDeviceConfigInfo.Name = "tabDeviceConfigInfo";
            this.tabDeviceConfigInfo.SelectedBackEndColor = System.Drawing.Color.LightGray;
            this.tabDeviceConfigInfo.SelectedBackStartColor = System.Drawing.Color.WhiteSmoke;
            this.tabDeviceConfigInfo.SelectedForeBrushColor = System.Drawing.Color.DimGray;
            this.tabDeviceConfigInfo.SelectedIndex = 0;
            this.tabDeviceConfigInfo.Size = new System.Drawing.Size(283, 595);
            this.tabDeviceConfigInfo.TabIndex = 378;
            this.tabDeviceConfigInfo.UnselectedBackEndColor = System.Drawing.Color.LightGray;
            this.tabDeviceConfigInfo.UnselectedBackStartColor = System.Drawing.Color.WhiteSmoke;
            this.tabDeviceConfigInfo.UnselectedForeBrushColor = System.Drawing.Color.DimGray;
            // 
            // tabPageDeviceConfigInputs
            // 
            this.tabPageDeviceConfigInputs.BackColor = System.Drawing.Color.LightGray;
            this.tabPageDeviceConfigInputs.Controls.Add(this.pnlDeviceConfigInputs);
            this.tabPageDeviceConfigInputs.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeviceConfigInputs.Name = "tabPageDeviceConfigInputs";
            this.tabPageDeviceConfigInputs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeviceConfigInputs.Size = new System.Drawing.Size(275, 569);
            this.tabPageDeviceConfigInputs.TabIndex = 0;
            this.tabPageDeviceConfigInputs.Text = "Inputs";
            // 
            // pnlDeviceConfigInputs
            // 
            this.pnlDeviceConfigInputs.AutoScroll = true;
            this.pnlDeviceConfigInputs.BackColor = System.Drawing.Color.LightGray;
            this.pnlDeviceConfigInputs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDeviceConfigInputs.BackgroundImage")));
            this.pnlDeviceConfigInputs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDeviceConfigInputs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDeviceConfigInputs.Controls.Add(this.chkNotifyOnInactivity);
            this.pnlDeviceConfigInputs.Controls.Add(this.panel3);
            this.pnlDeviceConfigInputs.Controls.Add(this.lblCustomerCompanyName);
            this.pnlDeviceConfigInputs.Controls.Add(this.dtpLicenseExpiryDate);
            this.pnlDeviceConfigInputs.Controls.Add(this.lblLicenseExpiryDate);
            this.pnlDeviceConfigInputs.Controls.Add(this.txtClientConfigWebServiceUrl);
            this.pnlDeviceConfigInputs.Controls.Add(this.lblFiglutWebServiceUrl);
            this.pnlDeviceConfigInputs.Controls.Add(this.txtApplicationReplicationWebServiceUrl);
            this.pnlDeviceConfigInputs.Controls.Add(this.lblApplicationReplicationWebServiceUrl);
            this.pnlDeviceConfigInputs.Controls.Add(this.txtApplicationWebServiceUrl);
            this.pnlDeviceConfigInputs.Controls.Add(this.lblApplicationWebServiceUrl);
            this.pnlDeviceConfigInputs.Controls.Add(this.txtApplicationName);
            this.pnlDeviceConfigInputs.Controls.Add(this.lblApplicationName);
            this.pnlDeviceConfigInputs.Controls.Add(this.txtDeviceId);
            this.pnlDeviceConfigInputs.Controls.Add(this.lblDeviceId);
            this.pnlDeviceConfigInputs.Controls.Add(this.panel1);
            this.pnlDeviceConfigInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeviceConfigInputs.GradientEndColor = System.Drawing.Color.LightGray;
            this.pnlDeviceConfigInputs.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pnlDeviceConfigInputs.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDeviceConfigInputs.Location = new System.Drawing.Point(3, 3);
            this.pnlDeviceConfigInputs.Name = "pnlDeviceConfigInputs";
            this.pnlDeviceConfigInputs.Size = new System.Drawing.Size(269, 563);
            this.pnlDeviceConfigInputs.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtCustomerCompanyName);
            this.panel3.Controls.Add(this.btnSelectCustomer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 23);
            this.panel3.TabIndex = 494;
            // 
            // txtCustomerCompanyName
            // 
            this.txtCustomerCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerCompanyName.Location = new System.Drawing.Point(0, 0);
            this.txtCustomerCompanyName.Name = "txtCustomerCompanyName";
            this.txtCustomerCompanyName.ReadOnly = true;
            this.txtCustomerCompanyName.Size = new System.Drawing.Size(236, 20);
            this.txtCustomerCompanyName.TabIndex = 495;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectCustomer.Location = new System.Drawing.Point(236, 0);
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
            this.lblCustomerCompanyName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerCompanyName.Location = new System.Drawing.Point(0, 213);
            this.lblCustomerCompanyName.Name = "lblCustomerCompanyName";
            this.lblCustomerCompanyName.Size = new System.Drawing.Size(132, 13);
            this.lblCustomerCompanyName.TabIndex = 493;
            this.lblCustomerCompanyName.Text = "Customer Company Name:";
            // 
            // dtpLicenseExpiryDate
            // 
            this.dtpLicenseExpiryDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtpLicenseExpiryDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpLicenseExpiryDate.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.dtpLicenseExpiryDate.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpLicenseExpiryDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpLicenseExpiryDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpLicenseExpiryDate.Location = new System.Drawing.Point(0, 193);
            this.dtpLicenseExpiryDate.Name = "dtpLicenseExpiryDate";
            this.dtpLicenseExpiryDate.Size = new System.Drawing.Size(265, 20);
            this.dtpLicenseExpiryDate.TabIndex = 487;
            // 
            // lblLicenseExpiryDate
            // 
            this.lblLicenseExpiryDate.AutoSize = true;
            this.lblLicenseExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseExpiryDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLicenseExpiryDate.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseExpiryDate.Location = new System.Drawing.Point(0, 180);
            this.lblLicenseExpiryDate.Name = "lblLicenseExpiryDate";
            this.lblLicenseExpiryDate.Size = new System.Drawing.Size(112, 13);
            this.lblLicenseExpiryDate.TabIndex = 488;
            this.lblLicenseExpiryDate.Text = "Licensing Expiry Date:";
            // 
            // txtClientConfigWebServiceUrl
            // 
            this.txtClientConfigWebServiceUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtClientConfigWebServiceUrl.ForeColor = System.Drawing.Color.Black;
            this.txtClientConfigWebServiceUrl.Location = new System.Drawing.Point(0, 160);
            this.txtClientConfigWebServiceUrl.Name = "txtClientConfigWebServiceUrl";
            this.txtClientConfigWebServiceUrl.Size = new System.Drawing.Size(265, 20);
            this.txtClientConfigWebServiceUrl.TabIndex = 485;
            // 
            // lblFiglutWebServiceUrl
            // 
            this.lblFiglutWebServiceUrl.AutoSize = true;
            this.lblFiglutWebServiceUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblFiglutWebServiceUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiglutWebServiceUrl.ForeColor = System.Drawing.Color.Black;
            this.lblFiglutWebServiceUrl.Location = new System.Drawing.Point(0, 147);
            this.lblFiglutWebServiceUrl.Name = "lblFiglutWebServiceUrl";
            this.lblFiglutWebServiceUrl.Size = new System.Drawing.Size(159, 13);
            this.lblFiglutWebServiceUrl.TabIndex = 486;
            this.lblFiglutWebServiceUrl.Text = "Client Config Web Service URL:";
            // 
            // txtApplicationReplicationWebServiceUrl
            // 
            this.txtApplicationReplicationWebServiceUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApplicationReplicationWebServiceUrl.ForeColor = System.Drawing.Color.Black;
            this.txtApplicationReplicationWebServiceUrl.Location = new System.Drawing.Point(0, 127);
            this.txtApplicationReplicationWebServiceUrl.Name = "txtApplicationReplicationWebServiceUrl";
            this.txtApplicationReplicationWebServiceUrl.Size = new System.Drawing.Size(265, 20);
            this.txtApplicationReplicationWebServiceUrl.TabIndex = 483;
            // 
            // lblApplicationReplicationWebServiceUrl
            // 
            this.lblApplicationReplicationWebServiceUrl.AutoSize = true;
            this.lblApplicationReplicationWebServiceUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationReplicationWebServiceUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApplicationReplicationWebServiceUrl.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationReplicationWebServiceUrl.Location = new System.Drawing.Point(0, 114);
            this.lblApplicationReplicationWebServiceUrl.Name = "lblApplicationReplicationWebServiceUrl";
            this.lblApplicationReplicationWebServiceUrl.Size = new System.Drawing.Size(208, 13);
            this.lblApplicationReplicationWebServiceUrl.TabIndex = 484;
            this.lblApplicationReplicationWebServiceUrl.Text = "Application Replication Web Service URL:";
            // 
            // txtApplicationWebServiceUrl
            // 
            this.txtApplicationWebServiceUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApplicationWebServiceUrl.ForeColor = System.Drawing.Color.Black;
            this.txtApplicationWebServiceUrl.Location = new System.Drawing.Point(0, 94);
            this.txtApplicationWebServiceUrl.Name = "txtApplicationWebServiceUrl";
            this.txtApplicationWebServiceUrl.Size = new System.Drawing.Size(265, 20);
            this.txtApplicationWebServiceUrl.TabIndex = 481;
            // 
            // lblApplicationWebServiceUrl
            // 
            this.lblApplicationWebServiceUrl.AutoSize = true;
            this.lblApplicationWebServiceUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationWebServiceUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApplicationWebServiceUrl.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationWebServiceUrl.Location = new System.Drawing.Point(0, 81);
            this.lblApplicationWebServiceUrl.Name = "lblApplicationWebServiceUrl";
            this.lblApplicationWebServiceUrl.Size = new System.Drawing.Size(152, 13);
            this.lblApplicationWebServiceUrl.TabIndex = 482;
            this.lblApplicationWebServiceUrl.Text = "Application Web Service URL:";
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApplicationName.ForeColor = System.Drawing.Color.Black;
            this.txtApplicationName.Location = new System.Drawing.Point(0, 61);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(265, 20);
            this.txtApplicationName.TabIndex = 477;
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApplicationName.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationName.Location = new System.Drawing.Point(0, 48);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(93, 13);
            this.lblApplicationName.TabIndex = 478;
            this.lblApplicationName.Text = "Application Name:";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDeviceId.ForeColor = System.Drawing.Color.Black;
            this.txtDeviceId.Location = new System.Drawing.Point(0, 28);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(265, 20);
            this.txtDeviceId.TabIndex = 474;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeviceId.ForeColor = System.Drawing.Color.Black;
            this.lblDeviceId.Location = new System.Drawing.Point(0, 15);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(56, 13);
            this.lblDeviceId.TabIndex = 473;
            this.lblDeviceId.Text = "Device Id:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lnkClearDeviceConfigInputControls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 15);
            this.panel1.TabIndex = 389;
            // 
            // lnkClearDeviceConfigInputControls
            // 
            this.lnkClearDeviceConfigInputControls.AutoSize = true;
            this.lnkClearDeviceConfigInputControls.BackColor = System.Drawing.Color.Transparent;
            this.lnkClearDeviceConfigInputControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnkClearDeviceConfigInputControls.LinkColor = System.Drawing.Color.Black;
            this.lnkClearDeviceConfigInputControls.Location = new System.Drawing.Point(234, 0);
            this.lnkClearDeviceConfigInputControls.Name = "lnkClearDeviceConfigInputControls";
            this.lnkClearDeviceConfigInputControls.Size = new System.Drawing.Size(31, 13);
            this.lnkClearDeviceConfigInputControls.TabIndex = 385;
            this.lnkClearDeviceConfigInputControls.TabStop = true;
            this.lnkClearDeviceConfigInputControls.Text = "Clear";
            this.lnkClearDeviceConfigInputControls.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkClearDeviceConfigInputControls.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearDeviceConfigInputControls_LinkClicked);
            // 
            // tabPageDeviceConfigFilters
            // 
            this.tabPageDeviceConfigFilters.Controls.Add(this.pnlFilters);
            this.tabPageDeviceConfigFilters.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeviceConfigFilters.Name = "tabPageDeviceConfigFilters";
            this.tabPageDeviceConfigFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeviceConfigFilters.Size = new System.Drawing.Size(275, 569);
            this.tabPageDeviceConfigFilters.TabIndex = 3;
            this.tabPageDeviceConfigFilters.Text = "Filters";
            this.tabPageDeviceConfigFilters.UseVisualStyleBackColor = true;
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFilters.BackgroundImage")));
            this.pnlFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFilters.Controls.Add(this.chkFilterExpired);
            this.pnlFilters.Controls.Add(this.txtFilterApplicationName);
            this.pnlFilters.Controls.Add(this.lblFilterApplicationName);
            this.pnlFilters.Controls.Add(this.txtFilterDeviceId);
            this.pnlFilters.Controls.Add(this.lblFilterDeviceId);
            this.pnlFilters.Controls.Add(this.panel7);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.GradientEndColor = System.Drawing.Color.LightGray;
            this.pnlFilters.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pnlFilters.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFilters.Location = new System.Drawing.Point(3, 3);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(269, 563);
            this.pnlFilters.TabIndex = 2;
            // 
            // chkFilterExpired
            // 
            this.chkFilterExpired.AutoSize = true;
            this.chkFilterExpired.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkFilterExpired.Location = new System.Drawing.Point(0, 81);
            this.chkFilterExpired.Name = "chkFilterExpired";
            this.chkFilterExpired.Size = new System.Drawing.Size(265, 17);
            this.chkFilterExpired.TabIndex = 528;
            this.chkFilterExpired.Text = "Expired";
            this.chkFilterExpired.UseVisualStyleBackColor = true;
            this.chkFilterExpired.CheckedChanged += new System.EventHandler(this.chkFilterExpired_CheckedChanged);
            // 
            // txtFilterApplicationName
            // 
            this.txtFilterApplicationName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilterApplicationName.ForeColor = System.Drawing.Color.Black;
            this.txtFilterApplicationName.Location = new System.Drawing.Point(0, 61);
            this.txtFilterApplicationName.Name = "txtFilterApplicationName";
            this.txtFilterApplicationName.Size = new System.Drawing.Size(265, 20);
            this.txtFilterApplicationName.TabIndex = 526;
            this.txtFilterApplicationName.TextChanged += new System.EventHandler(this.txtFilterApplicationName_TextChanged);
            // 
            // lblFilterApplicationName
            // 
            this.lblFilterApplicationName.AutoSize = true;
            this.lblFilterApplicationName.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterApplicationName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterApplicationName.ForeColor = System.Drawing.Color.Black;
            this.lblFilterApplicationName.Location = new System.Drawing.Point(0, 48);
            this.lblFilterApplicationName.Name = "lblFilterApplicationName";
            this.lblFilterApplicationName.Size = new System.Drawing.Size(93, 13);
            this.lblFilterApplicationName.TabIndex = 527;
            this.lblFilterApplicationName.Text = "Application Name:";
            // 
            // txtFilterDeviceId
            // 
            this.txtFilterDeviceId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilterDeviceId.ForeColor = System.Drawing.Color.Black;
            this.txtFilterDeviceId.Location = new System.Drawing.Point(0, 28);
            this.txtFilterDeviceId.Name = "txtFilterDeviceId";
            this.txtFilterDeviceId.Size = new System.Drawing.Size(265, 20);
            this.txtFilterDeviceId.TabIndex = 525;
            this.txtFilterDeviceId.TextChanged += new System.EventHandler(this.txtFilterDeviceId_TextChanged);
            // 
            // lblFilterDeviceId
            // 
            this.lblFilterDeviceId.AutoSize = true;
            this.lblFilterDeviceId.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterDeviceId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterDeviceId.ForeColor = System.Drawing.Color.Black;
            this.lblFilterDeviceId.Location = new System.Drawing.Point(0, 15);
            this.lblFilterDeviceId.Name = "lblFilterDeviceId";
            this.lblFilterDeviceId.Size = new System.Drawing.Size(56, 13);
            this.lblFilterDeviceId.TabIndex = 524;
            this.lblFilterDeviceId.Text = "Device Id:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.lnkClearDeviceConfigFilterControls);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 15);
            this.panel7.TabIndex = 523;
            // 
            // lnkClearDeviceConfigFilterControls
            // 
            this.lnkClearDeviceConfigFilterControls.AutoSize = true;
            this.lnkClearDeviceConfigFilterControls.BackColor = System.Drawing.Color.Transparent;
            this.lnkClearDeviceConfigFilterControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnkClearDeviceConfigFilterControls.LinkColor = System.Drawing.Color.Black;
            this.lnkClearDeviceConfigFilterControls.Location = new System.Drawing.Point(234, 0);
            this.lnkClearDeviceConfigFilterControls.Name = "lnkClearDeviceConfigFilterControls";
            this.lnkClearDeviceConfigFilterControls.Size = new System.Drawing.Size(31, 13);
            this.lnkClearDeviceConfigFilterControls.TabIndex = 386;
            this.lnkClearDeviceConfigFilterControls.TabStop = true;
            this.lnkClearDeviceConfigFilterControls.Text = "Clear";
            this.lnkClearDeviceConfigFilterControls.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkClearDeviceConfigFilterControls.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearDeviceConfigFilterControls_LinkClicked);
            // 
            // gradientPanelTimesheetItems
            // 
            this.gradientPanelTimesheetItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelTimesheetItems.BackgroundImage")));
            this.gradientPanelTimesheetItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelTimesheetItems.Controls.Add(this.grdDeviceConfigs);
            this.gradientPanelTimesheetItems.Controls.Add(this.lblDeviceConfigs);
            this.gradientPanelTimesheetItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelTimesheetItems.GradientEndColor = System.Drawing.Color.WhiteSmoke;
            this.gradientPanelTimesheetItems.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanelTimesheetItems.GradientStartColor = System.Drawing.Color.LightGray;
            this.gradientPanelTimesheetItems.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelTimesheetItems.Name = "gradientPanelTimesheetItems";
            this.gradientPanelTimesheetItems.Size = new System.Drawing.Size(564, 595);
            this.gradientPanelTimesheetItems.TabIndex = 0;
            // 
            // grdDeviceConfigs
            // 
            this.grdDeviceConfigs.AllowUserToAddRows = false;
            this.grdDeviceConfigs.AllowUserToDeleteRows = false;
            this.grdDeviceConfigs.AllowUserToResizeRows = false;
            this.grdDeviceConfigs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdDeviceConfigs.BackgroundEndColor = System.Drawing.Color.LightGray;
            this.grdDeviceConfigs.BackgroundStartColor = System.Drawing.Color.WhiteSmoke;
            this.grdDeviceConfigs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDeviceConfigs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDeviceConfigs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDeviceConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDeviceConfigs.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDeviceConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDeviceConfigs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDeviceConfigs.EnableHeadersVisualStyles = false;
            this.grdDeviceConfigs.GridColor = System.Drawing.Color.DimGray;
            this.grdDeviceConfigs.Location = new System.Drawing.Point(0, 13);
            this.grdDeviceConfigs.MultiSelect = false;
            this.grdDeviceConfigs.Name = "grdDeviceConfigs";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDeviceConfigs.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDeviceConfigs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeviceConfigs.Size = new System.Drawing.Size(564, 582);
            this.grdDeviceConfigs.TabIndex = 265;
            // 
            // lblDeviceConfigs
            // 
            this.lblDeviceConfigs.AutoSize = true;
            this.lblDeviceConfigs.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceConfigs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeviceConfigs.ForeColor = System.Drawing.Color.Black;
            this.lblDeviceConfigs.Location = new System.Drawing.Point(0, 0);
            this.lblDeviceConfigs.Name = "lblDeviceConfigs";
            this.lblDeviceConfigs.Size = new System.Drawing.Size(114, 13);
            this.lblDeviceConfigs.TabIndex = 264;
            this.lblDeviceConfigs.Text = "Device Configurations:";
            // 
            // toolStripDeviceConfigs
            // 
            this.toolStripDeviceConfigs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDeviceConfigAdd,
            this.toolStripSeparator1,
            this.tsDeviceConfigUpdate,
            this.tsDeviceConfigUpdateCommit,
            this.tsDeviceConfigUpdateCancel,
            this.toolStripSeparator2,
            this.tsDeviceConfigDelete,
            this.toolStripSeparator3,
            this.tsDeviceConfigFiltersEnable,
            this.tsDeviceConfigFiltersDisable});
            this.toolStripDeviceConfigs.Location = new System.Drawing.Point(0, 0);
            this.toolStripDeviceConfigs.Name = "toolStripDeviceConfigs";
            this.toolStripDeviceConfigs.Size = new System.Drawing.Size(851, 25);
            this.toolStripDeviceConfigs.TabIndex = 1;
            this.toolStripDeviceConfigs.Text = "customToolStrip1";
            // 
            // tsDeviceConfigAdd
            // 
            this.tsDeviceConfigAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeviceConfigAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsDeviceConfigAdd.Image")));
            this.tsDeviceConfigAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeviceConfigAdd.Name = "tsDeviceConfigAdd";
            this.tsDeviceConfigAdd.Size = new System.Drawing.Size(23, 22);
            this.tsDeviceConfigAdd.Text = "Add";
            this.tsDeviceConfigAdd.Click += new System.EventHandler(this.tsDeviceConfigAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsDeviceConfigUpdate
            // 
            this.tsDeviceConfigUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeviceConfigUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsDeviceConfigUpdate.Image")));
            this.tsDeviceConfigUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeviceConfigUpdate.Name = "tsDeviceConfigUpdate";
            this.tsDeviceConfigUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsDeviceConfigUpdate.Text = "Update";
            this.tsDeviceConfigUpdate.Click += new System.EventHandler(this.tsDeviceConfigUpdate_Click);
            // 
            // tsDeviceConfigUpdateCommit
            // 
            this.tsDeviceConfigUpdateCommit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeviceConfigUpdateCommit.Enabled = false;
            this.tsDeviceConfigUpdateCommit.Image = ((System.Drawing.Image)(resources.GetObject("tsDeviceConfigUpdateCommit.Image")));
            this.tsDeviceConfigUpdateCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeviceConfigUpdateCommit.Name = "tsDeviceConfigUpdateCommit";
            this.tsDeviceConfigUpdateCommit.Size = new System.Drawing.Size(23, 22);
            this.tsDeviceConfigUpdateCommit.Text = "Commit Update";
            this.tsDeviceConfigUpdateCommit.Click += new System.EventHandler(this.tsDeviceConfigUpdate_Click);
            // 
            // tsDeviceConfigUpdateCancel
            // 
            this.tsDeviceConfigUpdateCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeviceConfigUpdateCancel.Enabled = false;
            this.tsDeviceConfigUpdateCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsDeviceConfigUpdateCancel.Image")));
            this.tsDeviceConfigUpdateCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeviceConfigUpdateCancel.Name = "tsDeviceConfigUpdateCancel";
            this.tsDeviceConfigUpdateCancel.Size = new System.Drawing.Size(23, 22);
            this.tsDeviceConfigUpdateCancel.Text = "Cancel Update";
            this.tsDeviceConfigUpdateCancel.Click += new System.EventHandler(this.tsDeviceConfigUpdateCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsDeviceConfigDelete
            // 
            this.tsDeviceConfigDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeviceConfigDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDeviceConfigDelete.Image")));
            this.tsDeviceConfigDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeviceConfigDelete.Name = "tsDeviceConfigDelete";
            this.tsDeviceConfigDelete.Size = new System.Drawing.Size(23, 22);
            this.tsDeviceConfigDelete.Text = "Delete";
            this.tsDeviceConfigDelete.Click += new System.EventHandler(this.tsDeviceConfigDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsDeviceConfigFiltersEnable
            // 
            this.tsDeviceConfigFiltersEnable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeviceConfigFiltersEnable.Image = ((System.Drawing.Image)(resources.GetObject("tsDeviceConfigFiltersEnable.Image")));
            this.tsDeviceConfigFiltersEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeviceConfigFiltersEnable.Name = "tsDeviceConfigFiltersEnable";
            this.tsDeviceConfigFiltersEnable.Size = new System.Drawing.Size(23, 22);
            this.tsDeviceConfigFiltersEnable.Text = "Enable Filters";
            this.tsDeviceConfigFiltersEnable.Click += new System.EventHandler(this.tsDeviceConfigFiltersEnable_Click);
            // 
            // tsDeviceConfigFiltersDisable
            // 
            this.tsDeviceConfigFiltersDisable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeviceConfigFiltersDisable.Enabled = false;
            this.tsDeviceConfigFiltersDisable.Image = ((System.Drawing.Image)(resources.GetObject("tsDeviceConfigFiltersDisable.Image")));
            this.tsDeviceConfigFiltersDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeviceConfigFiltersDisable.Name = "tsDeviceConfigFiltersDisable";
            this.tsDeviceConfigFiltersDisable.Size = new System.Drawing.Size(23, 22);
            this.tsDeviceConfigFiltersDisable.Text = "Disable Filters";
            this.tsDeviceConfigFiltersDisable.Click += new System.EventHandler(this.tsDeviceConfigFiltersEnable_Click);
            // 
            // chkNotifyOnInactivity
            // 
            this.chkNotifyOnInactivity.AutoSize = true;
            this.chkNotifyOnInactivity.BackColor = System.Drawing.Color.Transparent;
            this.chkNotifyOnInactivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkNotifyOnInactivity.Location = new System.Drawing.Point(0, 249);
            this.chkNotifyOnInactivity.Name = "chkNotifyOnInactivity";
            this.chkNotifyOnInactivity.Size = new System.Drawing.Size(265, 17);
            this.chkNotifyOnInactivity.TabIndex = 495;
            this.chkNotifyOnInactivity.Text = "Notify On Inactivity";
            this.chkNotifyOnInactivity.UseVisualStyleBackColor = false;
            // 
            // DeviceConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splTimesheet);
            this.Controls.Add(this.toolStripDeviceConfigs);
            this.Name = "DeviceConfigControl";
            this.Size = new System.Drawing.Size(851, 620);
            this.splTimesheet.Panel1.ResumeLayout(false);
            this.splTimesheet.Panel2.ResumeLayout(false);
            this.splTimesheet.ResumeLayout(false);
            this.gradientPanelTimesheetInputs.ResumeLayout(false);
            this.tabDeviceConfigInfo.ResumeLayout(false);
            this.tabPageDeviceConfigInputs.ResumeLayout(false);
            this.pnlDeviceConfigInputs.ResumeLayout(false);
            this.pnlDeviceConfigInputs.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageDeviceConfigFilters.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.gradientPanelTimesheetItems.ResumeLayout(false);
            this.gradientPanelTimesheetItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeviceConfigs)).EndInit();
            this.toolStripDeviceConfigs.ResumeLayout(false);
            this.toolStripDeviceConfigs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog svdExport;
        private System.Windows.Forms.OpenFileDialog opdImport;
        private System.Windows.Forms.SaveFileDialog svdExportItem;
        protected System.Windows.Forms.CheckBox checkBox2;
        protected System.Windows.Forms.CheckBox checkBox3;
        protected System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ToolStripButton btnTimesheetAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private Figlut.Desktop.Controls.CustomToolStrip toolStripDeviceConfigs;
        private System.Windows.Forms.ToolStripButton tsDeviceConfigAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsDeviceConfigUpdate;
        private System.Windows.Forms.ToolStripButton tsDeviceConfigUpdateCommit;
        private System.Windows.Forms.ToolStripButton tsDeviceConfigUpdateCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsDeviceConfigDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsDeviceConfigFiltersEnable;
        private System.Windows.Forms.ToolStripButton tsDeviceConfigFiltersDisable;
        private System.Windows.Forms.SplitContainer splTimesheet;
        private Figlut.Desktop.Controls.GradientPanel gradientPanelTimesheetInputs;
        private Figlut.Desktop.Controls.GradientPanel gradientPanelTimesheetItems;
        private Figlut.Desktop.Controls.CustomDataGridView grdDeviceConfigs;
        protected System.Windows.Forms.Label lblDeviceConfigs;
        private Figlut.Desktop.Controls.CustomTab tabDeviceConfigInfo;
        private System.Windows.Forms.TabPage tabPageDeviceConfigInputs;
        private Figlut.Desktop.Controls.GradientPanel pnlDeviceConfigInputs;
        protected System.Windows.Forms.TextBox txtApplicationName;
        protected System.Windows.Forms.Label lblApplicationName;
        protected System.Windows.Forms.TextBox txtDeviceId;
        protected System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkClearDeviceConfigInputControls;
        private System.Windows.Forms.TabPage tabPageDeviceConfigFilters;
        private Figlut.Desktop.Controls.GradientPanel pnlFilters;
        protected System.Windows.Forms.TextBox txtClientConfigWebServiceUrl;
        protected System.Windows.Forms.Label lblFiglutWebServiceUrl;
        protected System.Windows.Forms.TextBox txtApplicationReplicationWebServiceUrl;
        protected System.Windows.Forms.Label lblApplicationReplicationWebServiceUrl;
        protected System.Windows.Forms.TextBox txtApplicationWebServiceUrl;
        protected System.Windows.Forms.Label lblApplicationWebServiceUrl;
        protected System.Windows.Forms.DateTimePicker dtpLicenseExpiryDate;
        protected System.Windows.Forms.Label lblLicenseExpiryDate;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.TextBox txtCustomerCompanyName;
        private System.Windows.Forms.Button btnSelectCustomer;
        protected System.Windows.Forms.Label lblCustomerCompanyName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.LinkLabel lnkClearDeviceConfigFilterControls;
        protected System.Windows.Forms.TextBox txtFilterApplicationName;
        protected System.Windows.Forms.Label lblFilterApplicationName;
        protected System.Windows.Forms.TextBox txtFilterDeviceId;
        protected System.Windows.Forms.Label lblFilterDeviceId;
        private System.Windows.Forms.CheckBox chkFilterExpired;
        private System.Windows.Forms.CheckBox chkNotifyOnInactivity;




    }
}
