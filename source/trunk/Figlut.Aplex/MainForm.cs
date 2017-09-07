namespace Figlut.Aplex
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using Figlut.Desktop.BaseForms;
    using Figlut.Aplex.Desktop.Controls;
    using Figlut.Aplex.Desktop.Data;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.AuxilaryUI;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.Data;

    #endregion //Using Directives

    public partial class MainForm : BorderlessForm
    {
        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            using (SplashForm splashForm = new SplashForm())
            {
                splashForm.ShowDialog();
            }
            deviceConfigControl.UpdateModeChanged += new DeviceConfigControl.DeviceConfigControlStateChanged(deviceConfigControl_UpdateModeChanged);
            deviceConfigControl.FiltersEnabledChanged += new DeviceConfigControl.DeviceConfigControlStateChanged(deviceConfigControl_FiltersEnabledChanged);
        }

        #endregion //Constructors

        #region Fields

        private bool _forceClose;

        #endregion //Fields

        #region Properties

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        #endregion //Properties

        #region Methods

        private void SetReadOnlyMode(bool readOnlyMode)
        {
            mnuCurrentDeviceConfigsSave.Enabled = !readOnlyMode;
        }

        #endregion //Methods

        #region Event Handlers

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            base.BorderlessForm_Minimize(sender, e);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            base.BorderlessForm_Maximize(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuEditDeviceConfigsFiltersEnabled_Click(object sender, EventArgs e)
        {
            deviceConfigControl.SetFiltersEnabled(!mnuEditDeviceConfigsFiltersEnabled.Checked);
            SelectDeviceConfigsTabPage();
        }

        private void deviceConfigControl_FiltersEnabledChanged(DeviceConfigControl.DeviceConfigControlStateChangedArgs e)
        {
            mnuEditDeviceConfigsFiltersEnabled.Checked = e.Enabled;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (LoginForm f = new LoginForm())
            {
                if (f.ShowDialog() != DialogResult.OK)
                {
                    _forceClose = true;
                    Close();
                    return;
                }
            }
            ApplyCurrentUserPermissions();
            deviceConfigControl.SetFiltersEnabled(false);
            deviceConfigControl.RefreshDeviceConfigFromServer(true);
            SelectDeviceConfigsTabPage();
        }

        private void ApplyCurrentUserPermissions()
        {
            if (GlobalDataCache.Instance.CurrentUserRoleId == UserRoleId.Administrator)
            {
                mnuManageUsers.Enabled = true;
                mnuManageCustomers.Enabled = true;
                mnuManageDevicesPendingApproval.Enabled = true;
                mnuManageGlobalServerSettings.Enabled = true;
                ApplyCurrentUserPermissionsDeviceConfigurations();
                return;
            }
            mnuManageUsers.Enabled = 
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.UserManagement.ToString()] == null ?
                false :
                true;
            mnuManageCustomers.Enabled =
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.CustomerManagement.ToString()] == null ?
                false :
                true;
            mnuManageDevicesPendingApproval.Enabled =
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.DevicesPendingApprovalManagement.ToString()] == null ?
                false :
                true;
            mnuManageGlobalServerSettings.Enabled =
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.GlobalServerSettingsManagement.ToString()] == null ?
                false :
                true;

            ApplyCurrentUserPermissionsForTools();
            ApplyCurrentUserPermissionsDeviceConfigurations();
        }

        private void ApplyCurrentUserPermissionsForTools()
        {
            mnuDeviceActions.Enabled =
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.ViewDeviceConfigActions.ToString()] == null ?
                false :
                true;
            mnuServerActions.Enabled =
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.ViewServerActions.ToString()] == null ?
                false :
                true;
            mnuServerErrors.Enabled =
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.ViewServerErrors.ToString()] == null ?
                false :
                true;
        }

        private void ApplyCurrentUserPermissionsDeviceConfigurations()
        {
            mnuEditDeviceConfigsAdd.Enabled =
                GlobalDataCache.Instance.CurrentUserRoleId != UserRoleId.Administrator &&
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.AddDeviceConfiguration.ToString()] == null ?
                false :
                true;
            mnuEditDeviceConfigsDelete.Enabled =
                GlobalDataCache.Instance.CurrentUserRoleId != UserRoleId.Administrator &&
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.DeleteDeviceConfiguration.ToString()] == null ?
                false :
                true;
            deviceConfigControl.ApplyCurrentUserPermissions();
        }

        private void mnuCurrentSwitchUser_Click(object sender, EventArgs e)
        {
            if ((deviceConfigControl.UnsavedChanges) &&
                (UIHelper.AskQuestion("There are unsaved changes. Are you sure you want to switch user? All unsaved changes will be lost.") !=
                DialogResult.Yes))
            {
                return;
            }
            using (LoginForm f = new LoginForm())
            {
                if (f.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
            ApplyCurrentUserPermissions();
        }

        private void ShowFiglutTabs(bool showDeviceConfigsPage)
        {
            tabFiglut.TabPages.Remove(tabPageDeviceConfigs);
            if (showDeviceConfigsPage)
            {
                tabFiglut.TabPages.Add(tabPageDeviceConfigs);
            }
        }

        public void SelectDeviceConfigsTabPage()
        {
            if (tabFiglut.TabPages.Contains(tabPageDeviceConfigs))
            {
                tabFiglut.SelectTab(tabPageDeviceConfigs.Name);
            }
        }

        private void mnuCurrentDeviceConfigsSave_Click(object sender, EventArgs e)
        {
            deviceConfigControl.SaveDeviceConfigsToServer();
            SelectDeviceConfigsTabPage();
        }

        private void mnuFileDeviceConfigsExport_Click(object sender, EventArgs e)
        {
            deviceConfigControl.ExportToCsv();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuEditDeviceConfigsAdd_Click(object sender, EventArgs e)
        {
            deviceConfigControl.AddDeviceConfig();
            SelectDeviceConfigsTabPage();
        }

        private void mnuEditDeviceConfigsUpdate_Click(object sender, EventArgs e)
        {
            deviceConfigControl.UpdateDeviceConfig();
            SelectDeviceConfigsTabPage();
        }

        private void deviceConfigControl_UpdateModeChanged(DeviceConfigControl.DeviceConfigControlStateChangedArgs e)
        {
            if (e.Enabled)
            {
                EnableDeviceConfigsEditControlsForUpdateMode();
            }
            else
            {
                EnableDeviceConfigsEditControlsForNonUpdateMode();
            }
        }

        private void EnableDeviceConfigsEditControlsForNonUpdateMode()
        {
            mnuEditDeviceConfigsUpdate.Checked = false;
            mnuEditDeviceConfigsAdd.Enabled = true;
            mnuEditDeviceConfigsDelete.Enabled = true;
            mnuEditDeviceConfigsCancelUpdate.Enabled = false;
        }

        private void EnableDeviceConfigsEditControlsForUpdateMode()
        {
            mnuEditDeviceConfigsUpdate.Checked = true;
            mnuEditDeviceConfigsAdd.Enabled = false;
            mnuEditDeviceConfigsDelete.Enabled = false;
            mnuEditDeviceConfigsCancelUpdate.Enabled = true;
        }

        private void mnuEditDeviceConfigsCancelUpdate_Click(object sender, EventArgs e)
        {
            deviceConfigControl.CancelUpdateMode();
            SelectDeviceConfigsTabPage();
        }

        private void mnuEditDeviceConfigsDelete_Click(object sender, EventArgs e)
        {
            deviceConfigControl.DeleteDeviceConfig();
            SelectDeviceConfigsTabPage();
        }

        private void mnuManageDevicesPendingApproval_Click(object sender, EventArgs e)
        {
            using (ManageDevicesPendingApprovalForm f = new ManageDevicesPendingApprovalForm())
            {
                f.ShowDialog();
            }
        }

        private void mnuManageUsers_Click(object sender, EventArgs e)
        {
            using (ManageUsersForm f = new ManageUsersForm())
            {
                f.ShowDialog();
            }
        }

        private void mnuManageCustomers_Click(object sender, EventArgs e)
        {
            using (ManageCustomersForm f = new ManageCustomersForm())
            {
                f.ShowDialog();
            }
        }

        private void mnuManageGlobalServerSettings_Click(object sender, EventArgs e)
        {
            using (GlobalServerSettingsForm f = new GlobalServerSettingsForm(EntityOperation.Update))
            {
                f.ShowDialog();
            }
        }

        private void mnuLogViewer_Click(object sender, EventArgs e)
        {
            using (LogViewerForm f = new LogViewerForm())
            {
                f.ShowDialog();
            }
        }

        private void mnuDeviceActions_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            using (SelectDateRangeForm f = new SelectDateRangeForm())
            {
                if (f.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                startDate = f.StartDate;
                endDate = f.EndDate;
            }
            using (ViewDeviceConfigActionsForm f = new ViewDeviceConfigActionsForm(startDate, endDate))
            {
                f.ShowDialog();
            }
        }

        private void mnuServerActions_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            using (SelectDateRangeForm f = new SelectDateRangeForm())
            {
                if (f.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                startDate = f.StartDate;
                endDate = f.EndDate;
            }
            using (ViewServerActionsForm f = new ViewServerActionsForm(startDate, endDate))
            {
                f.ShowDialog();
            }
        }

        private void mnuServerErrors_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            using (SelectDateRangeForm f = new SelectDateRangeForm())
            {
                if (f.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                startDate = f.StartDate;
                endDate = f.EndDate;
            }
            using(ViewServerErrorsForm f = new ViewServerErrorsForm(startDate, endDate))
            {
                f.ShowDialog();
            }
        }

        private void mnuEmailActions_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            using (SelectDateRangeForm f = new SelectDateRangeForm())
            {
                if (f.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                startDate = f.StartDate;
                endDate = f.EndDate;
            }
            using (ViewEmailActionsForm f = new ViewEmailActionsForm(startDate, endDate))
            {
                f.ShowDialog();
            }
        }

        private void mnuCurrentDeviceConfigsRefresh_Click(object sender, EventArgs e)
        {
            deviceConfigControl.RefreshDeviceConfigFromServer(true);
            SelectDeviceConfigsTabPage();
        }

        private void mnuCurrentGlobalServerSettings_Click(object sender, EventArgs e)
        {
            using (GlobalServerSettingsForm f = new GlobalServerSettingsForm(EntityOperation.ReadOnly))
            {
                f.ShowDialog();
            }
        }

        private void mnuCurrentUser_Click(object sender, EventArgs e)
        {
            string originalStatus = Status;
            try
            {
                DialogResult result = DialogResult.Cancel;
                User currentUserClone = GlobalDataCache.Instance.CurrentUser.Clone();
                using (UserForm f = new UserForm(currentUserClone, EntityOperation.LimitedUpdate, null))
                {
                    result = f.ShowDialog();
                }
                if (result == DialogResult.OK)
                {
                    using (WaitCursor w = new WaitCursor())
                    {
                        Status = "Saving current user to server ...";
                        ServiceProcedureResult userResult = GlobalDataCache.Instance.Service.SaveUser(new User[] { currentUserClone }, GlobalDataCache.Instance.CurrentUser, false);
                        if (ServiceResultHandler.HandleServiceResult(userResult))
                        {
                            return;
                        }
                    }
                    currentUserClone.CopyTo(GlobalDataCache.Instance.CurrentUser);
                }
            }
            finally
            {
                if (Status != originalStatus)
                {
                    Status = originalStatus;
                }
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            using (AboutBox f = new AboutBox())
            {
                f.ShowDialog();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void picResizeWindow_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderLessFormResize(this, e);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string confirmationMessage =
                deviceConfigControl.UnsavedChanges ?
                "There are unsaved changes to device configurations. Are you sure you want to exit? All unsaved changes will be lost." :
                "Are you sure you want to exit?";
            if (!_forceClose && UIHelper.AskQuestion(confirmationMessage) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                AnimateHideForm();
            }
        }

        #endregion //Event Handlers
    }
}