namespace Figlut.Aplex
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picResizeWindow = new System.Windows.Forms.PictureBox();
            this.tabFiglut = new Figlut.Desktop.Controls.CustomTab();
            this.tabPageDeviceConfigs = new System.Windows.Forms.TabPage();
            this.pnlTimesheet = new Figlut.Desktop.Controls.GradientPanel();
            this.deviceConfigControl = new Figlut.Aplex.Desktop.Controls.DeviceConfigControl();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileDeviceConfigs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileDeviceConfigsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuManageDevicesPendingApproval = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageGlobalServerSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentDeviceConfigs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentDeviceConfigsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditDeviceConfigs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDeviceConfigsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDeviceConfigsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDeviceConfigsCancelUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDeviceConfigsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditDeviceConfigsFiltersEnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentDeviceConfigsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCurrentGlobalServerSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCurrentSwitchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeviceActions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerActions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServerErrors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmailActions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new Figlut.Desktop.Controls.GradientPanel();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.lblCompanyTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResizeWindow)).BeginInit();
            this.tabFiglut.SuspendLayout();
            this.tabPageDeviceConfigs.SuspendLayout();
            this.pnlTimesheet.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(750, 21);
            this.lblFormTitle.Text = "Figlut APLEX ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 567);
            this.statusMain.Size = new System.Drawing.Size(750, 21);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.tabFiglut);
            this.pnlFormContent.Controls.Add(this.pnlTitle);
            this.pnlFormContent.Controls.Add(this.mnuMain);
            this.pnlFormContent.Size = new System.Drawing.Size(720, 546);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 546);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(735, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 546);
            // 
            // picResizeWindow
            // 
            this.picResizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picResizeWindow.BackColor = System.Drawing.Color.DimGray;
            this.picResizeWindow.ErrorImage = null;
            this.picResizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("picResizeWindow.Image")));
            this.picResizeWindow.Location = new System.Drawing.Point(734, 573);
            this.picResizeWindow.Name = "picResizeWindow";
            this.picResizeWindow.Size = new System.Drawing.Size(16, 15);
            this.picResizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResizeWindow.TabIndex = 36;
            this.picResizeWindow.TabStop = false;
            this.picResizeWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResizeWindow_MouseMove);
            // 
            // tabFiglut
            // 
            this.tabFiglut.Controls.Add(this.tabPageDeviceConfigs);
            this.tabFiglut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFiglut.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabFiglut.Location = new System.Drawing.Point(0, 163);
            this.tabFiglut.Name = "tabFiglut";
            this.tabFiglut.SelectedBackEndColor = System.Drawing.Color.LightGray;
            this.tabFiglut.SelectedBackStartColor = System.Drawing.Color.WhiteSmoke;
            this.tabFiglut.SelectedForeBrushColor = System.Drawing.Color.DimGray;
            this.tabFiglut.SelectedIndex = 0;
            this.tabFiglut.Size = new System.Drawing.Size(720, 383);
            this.tabFiglut.TabIndex = 379;
            this.tabFiglut.UnselectedBackEndColor = System.Drawing.Color.LightGray;
            this.tabFiglut.UnselectedBackStartColor = System.Drawing.Color.WhiteSmoke;
            this.tabFiglut.UnselectedForeBrushColor = System.Drawing.Color.DimGray;
            // 
            // tabPageDeviceConfigs
            // 
            this.tabPageDeviceConfigs.BackColor = System.Drawing.Color.LightGray;
            this.tabPageDeviceConfigs.Controls.Add(this.pnlTimesheet);
            this.tabPageDeviceConfigs.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeviceConfigs.Name = "tabPageDeviceConfigs";
            this.tabPageDeviceConfigs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeviceConfigs.Size = new System.Drawing.Size(712, 357);
            this.tabPageDeviceConfigs.TabIndex = 0;
            this.tabPageDeviceConfigs.Text = "Device Configurations:";
            // 
            // pnlTimesheet
            // 
            this.pnlTimesheet.AutoScroll = true;
            this.pnlTimesheet.BackColor = System.Drawing.Color.DimGray;
            this.pnlTimesheet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTimesheet.BackgroundImage")));
            this.pnlTimesheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimesheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimesheet.Controls.Add(this.deviceConfigControl);
            this.pnlTimesheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimesheet.GradientEndColor = System.Drawing.Color.LightGray;
            this.pnlTimesheet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pnlTimesheet.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTimesheet.Location = new System.Drawing.Point(3, 3);
            this.pnlTimesheet.Name = "pnlTimesheet";
            this.pnlTimesheet.Size = new System.Drawing.Size(706, 351);
            this.pnlTimesheet.TabIndex = 0;
            // 
            // deviceConfigControl
            // 
            this.deviceConfigControl.BackColor = System.Drawing.Color.White;
            this.deviceConfigControl.CurrentDeviceConfigCacheFilePath = null;
            this.deviceConfigControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceConfigControl.Location = new System.Drawing.Point(0, 0);
            this.deviceConfigControl.Name = "deviceConfigControl";
            this.deviceConfigControl.Size = new System.Drawing.Size(702, 347);
            this.deviceConfigControl.TabIndex = 1;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuManage,
            this.mnuCurrent,
            this.mnuTools,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(720, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "customMainMenu1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuFileDeviceConfigs,
            this.toolStripSeparator2,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuFileDeviceConfigs
            // 
            this.mnuFileDeviceConfigs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileDeviceConfigsExport});
            this.mnuFileDeviceConfigs.Name = "mnuFileDeviceConfigs";
            this.mnuFileDeviceConfigs.Size = new System.Drawing.Size(191, 22);
            this.mnuFileDeviceConfigs.Text = "&Device Configurations";
            // 
            // mnuFileDeviceConfigsExport
            // 
            this.mnuFileDeviceConfigsExport.Name = "mnuFileDeviceConfigsExport";
            this.mnuFileDeviceConfigsExport.Size = new System.Drawing.Size(107, 22);
            this.mnuFileDeviceConfigsExport.Text = "&Export";
            this.mnuFileDeviceConfigsExport.Click += new System.EventHandler(this.mnuFileDeviceConfigsExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(191, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuManage
            // 
            this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.mnuManageDevicesPendingApproval,
            this.mnuManageCustomers,
            this.mnuManageUsers,
            this.mnuManageGlobalServerSettings});
            this.mnuManage.Name = "mnuManage";
            this.mnuManage.Size = new System.Drawing.Size(62, 20);
            this.mnuManage.Text = "&Manage";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuManageDevicesPendingApproval
            // 
            this.mnuManageDevicesPendingApproval.Name = "mnuManageDevicesPendingApproval";
            this.mnuManageDevicesPendingApproval.Size = new System.Drawing.Size(212, 22);
            this.mnuManageDevicesPendingApproval.Text = "Devices Pending Approval";
            this.mnuManageDevicesPendingApproval.Click += new System.EventHandler(this.mnuManageDevicesPendingApproval_Click);
            // 
            // mnuManageCustomers
            // 
            this.mnuManageCustomers.Name = "mnuManageCustomers";
            this.mnuManageCustomers.Size = new System.Drawing.Size(212, 22);
            this.mnuManageCustomers.Text = "Customers";
            this.mnuManageCustomers.Click += new System.EventHandler(this.mnuManageCustomers_Click);
            // 
            // mnuManageUsers
            // 
            this.mnuManageUsers.Name = "mnuManageUsers";
            this.mnuManageUsers.Size = new System.Drawing.Size(212, 22);
            this.mnuManageUsers.Text = "Users";
            this.mnuManageUsers.Click += new System.EventHandler(this.mnuManageUsers_Click);
            // 
            // mnuManageGlobalServerSettings
            // 
            this.mnuManageGlobalServerSettings.Name = "mnuManageGlobalServerSettings";
            this.mnuManageGlobalServerSettings.Size = new System.Drawing.Size(212, 22);
            this.mnuManageGlobalServerSettings.Text = "Global Server Settings";
            this.mnuManageGlobalServerSettings.Click += new System.EventHandler(this.mnuManageGlobalServerSettings_Click);
            // 
            // mnuCurrent
            // 
            this.mnuCurrent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCurrentDeviceConfigs,
            this.toolStripSeparator4,
            this.mnuCurrentUser,
            this.mnuCurrentGlobalServerSettings,
            this.toolStripSeparator11,
            this.mnuCurrentSwitchUser});
            this.mnuCurrent.Name = "mnuCurrent";
            this.mnuCurrent.Size = new System.Drawing.Size(59, 20);
            this.mnuCurrent.Text = "&Current";
            // 
            // mnuCurrentDeviceConfigs
            // 
            this.mnuCurrentDeviceConfigs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCurrentDeviceConfigsRefresh,
            this.toolStripSeparator10,
            this.mnuEditDeviceConfigs,
            this.mnuCurrentDeviceConfigsSave});
            this.mnuCurrentDeviceConfigs.Name = "mnuCurrentDeviceConfigs";
            this.mnuCurrentDeviceConfigs.Size = new System.Drawing.Size(191, 22);
            this.mnuCurrentDeviceConfigs.Text = "&Device Configurations";
            // 
            // mnuCurrentDeviceConfigsRefresh
            // 
            this.mnuCurrentDeviceConfigsRefresh.Name = "mnuCurrentDeviceConfigsRefresh";
            this.mnuCurrentDeviceConfigsRefresh.Size = new System.Drawing.Size(113, 22);
            this.mnuCurrentDeviceConfigsRefresh.Text = "&Refresh";
            this.mnuCurrentDeviceConfigsRefresh.Click += new System.EventHandler(this.mnuCurrentDeviceConfigsRefresh_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(110, 6);
            // 
            // mnuEditDeviceConfigs
            // 
            this.mnuEditDeviceConfigs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditDeviceConfigsAdd,
            this.mnuEditDeviceConfigsUpdate,
            this.mnuEditDeviceConfigsCancelUpdate,
            this.mnuEditDeviceConfigsDelete,
            this.toolStripSeparator3,
            this.mnuEditDeviceConfigsFiltersEnabled});
            this.mnuEditDeviceConfigs.Name = "mnuEditDeviceConfigs";
            this.mnuEditDeviceConfigs.Size = new System.Drawing.Size(113, 22);
            this.mnuEditDeviceConfigs.Text = "&Edit";
            // 
            // mnuEditDeviceConfigsAdd
            // 
            this.mnuEditDeviceConfigsAdd.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEditDeviceConfigsAdd.Name = "mnuEditDeviceConfigsAdd";
            this.mnuEditDeviceConfigsAdd.ShowShortcutKeys = false;
            this.mnuEditDeviceConfigsAdd.Size = new System.Drawing.Size(144, 22);
            this.mnuEditDeviceConfigsAdd.Text = "&Add";
            this.mnuEditDeviceConfigsAdd.Click += new System.EventHandler(this.mnuEditDeviceConfigsAdd_Click);
            // 
            // mnuEditDeviceConfigsUpdate
            // 
            this.mnuEditDeviceConfigsUpdate.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEditDeviceConfigsUpdate.Name = "mnuEditDeviceConfigsUpdate";
            this.mnuEditDeviceConfigsUpdate.ShowShortcutKeys = false;
            this.mnuEditDeviceConfigsUpdate.Size = new System.Drawing.Size(144, 22);
            this.mnuEditDeviceConfigsUpdate.Text = "&Update";
            this.mnuEditDeviceConfigsUpdate.Click += new System.EventHandler(this.mnuEditDeviceConfigsUpdate_Click);
            // 
            // mnuEditDeviceConfigsCancelUpdate
            // 
            this.mnuEditDeviceConfigsCancelUpdate.Enabled = false;
            this.mnuEditDeviceConfigsCancelUpdate.Name = "mnuEditDeviceConfigsCancelUpdate";
            this.mnuEditDeviceConfigsCancelUpdate.ShowShortcutKeys = false;
            this.mnuEditDeviceConfigsCancelUpdate.Size = new System.Drawing.Size(144, 22);
            this.mnuEditDeviceConfigsCancelUpdate.Text = "Cancel Update";
            this.mnuEditDeviceConfigsCancelUpdate.Click += new System.EventHandler(this.mnuEditDeviceConfigsCancelUpdate_Click);
            // 
            // mnuEditDeviceConfigsDelete
            // 
            this.mnuEditDeviceConfigsDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEditDeviceConfigsDelete.Name = "mnuEditDeviceConfigsDelete";
            this.mnuEditDeviceConfigsDelete.ShowShortcutKeys = false;
            this.mnuEditDeviceConfigsDelete.Size = new System.Drawing.Size(144, 22);
            this.mnuEditDeviceConfigsDelete.Text = "&Delete";
            this.mnuEditDeviceConfigsDelete.Click += new System.EventHandler(this.mnuEditDeviceConfigsDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // mnuEditDeviceConfigsFiltersEnabled
            // 
            this.mnuEditDeviceConfigsFiltersEnabled.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEditDeviceConfigsFiltersEnabled.Name = "mnuEditDeviceConfigsFiltersEnabled";
            this.mnuEditDeviceConfigsFiltersEnabled.ShowShortcutKeys = false;
            this.mnuEditDeviceConfigsFiltersEnabled.Size = new System.Drawing.Size(144, 22);
            this.mnuEditDeviceConfigsFiltersEnabled.Text = "&Filters Enabled";
            this.mnuEditDeviceConfigsFiltersEnabled.Click += new System.EventHandler(this.mnuEditDeviceConfigsFiltersEnabled_Click);
            // 
            // mnuCurrentDeviceConfigsSave
            // 
            this.mnuCurrentDeviceConfigsSave.Name = "mnuCurrentDeviceConfigsSave";
            this.mnuCurrentDeviceConfigsSave.Size = new System.Drawing.Size(113, 22);
            this.mnuCurrentDeviceConfigsSave.Text = "&Save";
            this.mnuCurrentDeviceConfigsSave.Click += new System.EventHandler(this.mnuCurrentDeviceConfigsSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuCurrentUser
            // 
            this.mnuCurrentUser.Name = "mnuCurrentUser";
            this.mnuCurrentUser.Size = new System.Drawing.Size(191, 22);
            this.mnuCurrentUser.Text = "&User";
            this.mnuCurrentUser.Click += new System.EventHandler(this.mnuCurrentUser_Click);
            // 
            // mnuCurrentGlobalServerSettings
            // 
            this.mnuCurrentGlobalServerSettings.Name = "mnuCurrentGlobalServerSettings";
            this.mnuCurrentGlobalServerSettings.Size = new System.Drawing.Size(191, 22);
            this.mnuCurrentGlobalServerSettings.Text = "Global Server Settings";
            this.mnuCurrentGlobalServerSettings.Click += new System.EventHandler(this.mnuCurrentGlobalServerSettings_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuCurrentSwitchUser
            // 
            this.mnuCurrentSwitchUser.Name = "mnuCurrentSwitchUser";
            this.mnuCurrentSwitchUser.Size = new System.Drawing.Size(191, 22);
            this.mnuCurrentSwitchUser.Text = "&Switch User";
            this.mnuCurrentSwitchUser.Click += new System.EventHandler(this.mnuCurrentSwitchUser_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogViewer,
            this.mnuDeviceActions,
            this.mnuServerActions,
            this.mnuServerErrors,
            this.mnuEmailActions});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuLogViewer
            // 
            this.mnuLogViewer.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuLogViewer.Name = "mnuLogViewer";
            this.mnuLogViewer.Size = new System.Drawing.Size(152, 22);
            this.mnuLogViewer.Text = "&Log Viewer";
            this.mnuLogViewer.Click += new System.EventHandler(this.mnuLogViewer_Click);
            // 
            // mnuDeviceActions
            // 
            this.mnuDeviceActions.Name = "mnuDeviceActions";
            this.mnuDeviceActions.Size = new System.Drawing.Size(152, 22);
            this.mnuDeviceActions.Text = "&Device Actions";
            this.mnuDeviceActions.Click += new System.EventHandler(this.mnuDeviceActions_Click);
            // 
            // mnuServerActions
            // 
            this.mnuServerActions.Name = "mnuServerActions";
            this.mnuServerActions.Size = new System.Drawing.Size(152, 22);
            this.mnuServerActions.Text = "Server &Actions";
            this.mnuServerActions.Click += new System.EventHandler(this.mnuServerActions_Click);
            // 
            // mnuServerErrors
            // 
            this.mnuServerErrors.Name = "mnuServerErrors";
            this.mnuServerErrors.Size = new System.Drawing.Size(152, 22);
            this.mnuServerErrors.Text = "Server &Errors";
            this.mnuServerErrors.Click += new System.EventHandler(this.mnuServerErrors_Click);
            // 
            // mnuEmailActions
            // 
            this.mnuEmailActions.Name = "mnuEmailActions";
            this.mnuEmailActions.Size = new System.Drawing.Size(152, 22);
            this.mnuEmailActions.Text = "Email Actions";
            this.mnuEmailActions.Click += new System.EventHandler(this.mnuEmailActions_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = ((System.Drawing.Image)(resources.GetObject("mnuAbout.Image")));
            this.mnuAbout.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DimGray;
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitle.Controls.Add(this.lblApplicationTitle);
            this.pnlTitle.Controls.Add(this.picExit);
            this.pnlTitle.Controls.Add(this.picMinimize);
            this.pnlTitle.Controls.Add(this.picMaximize);
            this.pnlTitle.Controls.Add(this.lblCompanyTitle);
            this.pnlTitle.Controls.Add(this.picLogo);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.GradientEndColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlTitle.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlTitle.Location = new System.Drawing.Point(0, 24);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(720, 139);
            this.pnlTitle.TabIndex = 147;
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationTitle.AutoSize = true;
            this.lblApplicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Buxton Sketch", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.Location = new System.Drawing.Point(623, 91);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(91, 45);
            this.lblApplicationTitle.TabIndex = 40;
            this.lblApplicationTitle.Text = "Aplex";
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(681, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(32, 32);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 39;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.ErrorImage = null;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(605, 3);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(32, 32);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimize.TabIndex = 38;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.BackColor = System.Drawing.Color.Transparent;
            this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
            this.picMaximize.Location = new System.Drawing.Point(643, 3);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(32, 32);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaximize.TabIndex = 37;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblCompanyTitle
            // 
            this.lblCompanyTitle.AutoSize = true;
            this.lblCompanyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyTitle.Font = new System.Drawing.Font("Buxton Sketch", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyTitle.Location = new System.Drawing.Point(3, 3);
            this.lblCompanyTitle.Name = "lblCompanyTitle";
            this.lblCompanyTitle.Size = new System.Drawing.Size(99, 45);
            this.lblCompanyTitle.TabIndex = 36;
            this.lblCompanyTitle.Text = "Figlut";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(720, 139);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 34;
            this.picLogo.TabStop = false;
            this.picLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.picLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 588);
            this.Controls.Add(this.picResizeWindow);
            this.FormTitle = "Figlut APLEX";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figlut APLEX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Controls.SetChildIndex(this.statusMain, 0);
            this.Controls.SetChildIndex(this.picResizeWindow, 0);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            this.Controls.SetChildIndex(this.pnlFormLeft, 0);
            this.Controls.SetChildIndex(this.pnlFormRight, 0);
            this.Controls.SetChildIndex(this.pnlFormContent, 0);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResizeWindow)).EndInit();
            this.tabFiglut.ResumeLayout(false);
            this.tabPageDeviceConfigs.ResumeLayout(false);
            this.pnlTimesheet.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuLogViewer;
        private System.Windows.Forms.PictureBox picResizeWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuManageUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrent;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mnuFileDeviceConfigs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileDeviceConfigsExport;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentDeviceConfigs;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentDeviceConfigsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentDeviceConfigsSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentSwitchUser;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDeviceConfigs;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDeviceConfigsAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDeviceConfigsUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDeviceConfigsCancelUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDeviceConfigsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDeviceConfigsFiltersEnabled;
        private System.Windows.Forms.ToolStripMenuItem mnuManageGlobalServerSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentGlobalServerSettings;
        private Figlut.Desktop.Controls.CustomTab tabFiglut;
        private System.Windows.Forms.TabPage tabPageDeviceConfigs;
        private Figlut.Desktop.Controls.GradientPanel pnlTimesheet;
        private Figlut.Aplex.Desktop.Controls.DeviceConfigControl deviceConfigControl;
        private System.Windows.Forms.ToolStripMenuItem mnuManageCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuManageDevicesPendingApproval;
        private Figlut.Desktop.Controls.GradientPanel pnlTitle;
        private System.Windows.Forms.Label lblCompanyTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.ToolStripMenuItem mnuDeviceActions;
        private System.Windows.Forms.ToolStripMenuItem mnuServerActions;
        private System.Windows.Forms.ToolStripMenuItem mnuServerErrors;
        private System.Windows.Forms.Label lblApplicationTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuEmailActions;




    }
}

