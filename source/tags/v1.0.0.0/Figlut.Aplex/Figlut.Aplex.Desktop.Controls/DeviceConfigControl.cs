namespace Figlut.Aplex.Desktop.Controls
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
    using System.Drawing.Imaging;
    using Figlut.Aplex.Desktop.Data;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.BaseForms;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.AuxilaryUI;

    #endregion //Using Directives

    public partial class DeviceConfigControl : UserControl
    {
        #region Inner Types

        public class DeviceConfigControlStateChangedArgs : EventArgs
        {
            public bool Enabled { get; set; }
        }

        #endregion //Inner Types

        #region Constructors

        public DeviceConfigControl()
        {
            InitializeComponent();
            InitHiddenColumns();
            _deviceConfigCache = new DeviceConfigCache();
            _filteredDeviceConfigCache = new DeviceConfigCache();
        }

        #endregion //Constructors

        #region Fields

        private DeviceConfigCache _deviceConfigCache;
        private DeviceConfigCache _filteredDeviceConfigCache;
        private DeviceConfig _deviceConfigUnderUpdate = null;
        private string _currentDeviceConfigCacheFilePath;
        private Nullable<Guid> _deviceConfigCustomerId;

        private bool _filtersEnabled;
        private bool _unsavedChanges = false;
        private bool _readOnlyMode = false;
        private List<string> _hiddenColumns;

        public delegate void DeviceConfigControlStateChanged(DeviceConfigControlStateChangedArgs e);
        public event DeviceConfigControlStateChanged UpdateModeChanged;
        public event DeviceConfigControlStateChanged FiltersEnabledChanged;

        #endregion //Fields

        #region Properties

        private string Status
        {
            get
            {
                if (this.ParentForm == null)
                {
                    return null;
                }
                BorderlessForm f = this.ParentForm as BorderlessForm;
                if (f == null)
                {
                    throw new NullReferenceException("Parent form of TimesheetControl is not of expected type.");
                }
                return f.Status;
            }
            set
            {
                if (this.ParentForm == null)
                {
                    return;
                }
                BorderlessForm f = this.ParentForm as BorderlessForm;
                if (f == null)
                {
                    throw new NullReferenceException("Parent form of TimesheetControl is not of expected type.");
                }
                f.Status = value;
            }
        }

        public string CurrentDeviceConfigCacheFilePath
        {
            get { return _currentDeviceConfigCacheFilePath; }
            set { _currentDeviceConfigCacheFilePath = value; }
        }

        public bool InUpdateMode
        {
            get { return _deviceConfigUnderUpdate != null; }
        }

        public bool UnsavedChanges
        {
            get { return _unsavedChanges; }
        }

        public bool ReadOnlyMode
        {
            get { return _readOnlyMode; }
        }

        #endregion //Properties

        #region Methods

        public void ApplyCurrentUserPermissions()
        {
            tsDeviceConfigAdd.Enabled = 
                GlobalDataCache.Instance.CurrentUserRoleId != UserRoleId.Administrator &&
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.AddDeviceConfiguration.ToString()] == null ?
                false :
                true;
            tsDeviceConfigDelete.Enabled =
                GlobalDataCache.Instance.CurrentUserRoleId != UserRoleId.Administrator &&
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.DeleteDeviceConfiguration.ToString()] == null ?
                false :
                true;
        }

        public void SelectDeviceConfigInputsTabPage()
        {
            if (tabDeviceConfigInfo.TabPages.Contains(tabPageDeviceConfigInputs))
            {
                tabDeviceConfigInfo.SelectTab(tabPageDeviceConfigInputs.Name);
                txtDeviceId.Focus();
            }
        }

        public void SelectDeviceConfigFiltersTabPage()
        {
            if (tabDeviceConfigInfo.TabPages.Contains(tabPageDeviceConfigFilters))
            {
                tabDeviceConfigInfo.SelectTab(tabPageDeviceConfigFilters.Name);
                txtFilterDeviceId.Focus();
            }
        }

        public void ClearDeviceConfigFiltersToDefault()
        {
            txtFilterDeviceId.Clear();
            txtFilterApplicationName.Clear();
            chkFilterExpired.Checked = false;
        }

        public void ValidateMandatoryFields()
        {
            if (string.IsNullOrEmpty(txtDeviceId.Text))
            {
                SelectDeviceConfigInputsTabPage();
                txtDeviceId.Focus();
                throw new UserThrownException("Device Id not entered.", false, true, false);
            }
            if (string.IsNullOrEmpty(txtApplicationName.Text))
            {
                SelectDeviceConfigInputsTabPage();
                txtApplicationName.Focus();
                throw new UserThrownException("Application Name not entered.", false, true, false);
            }
            if (_deviceConfigCustomerId == null)
            {
                SelectDeviceConfigInputsTabPage();
                txtCustomerCompanyName.Focus();
                throw new UserThrownException("Customer not selected.", false, true, false);
            }
        }

        public void AddDeviceConfig()
        {
            Guid newId = Guid.NewGuid();
            ValidateMandatoryFields();
            DeviceConfig d = new DeviceConfig()
            {
                DeviceConfigId = newId,
                DeviceId = string.IsNullOrEmpty(txtDeviceId.Text) ? null : txtDeviceId.Text,
                ApplicationName = string.IsNullOrEmpty(txtApplicationName.Text) ? null : txtApplicationName.Text,
                ApplicationWebServiceURL = string.IsNullOrEmpty(txtApplicationWebServiceUrl.Text) ? null : txtApplicationWebServiceUrl.Text,
                ApplicationReplicationWebServiceURL = string.IsNullOrEmpty(txtApplicationReplicationWebServiceUrl.Text) ? null : txtApplicationReplicationWebServiceUrl.Text,
                ClientConfigWebServiceURL = string.IsNullOrEmpty(txtClientConfigWebServiceUrl.Text) ? null : txtClientConfigWebServiceUrl.Text,
                LicenseExpiryDate = dtpLicenseExpiryDate.Value,
                CustomerId = _deviceConfigCustomerId.Value,
                NotifyOnInactivity = _deviceConfigUnderUpdate.NotifyOnInactivity,
                DateCreated = DateTime.Now
            };
            _deviceConfigCache.Add(d);
            ClearInputControls();
            RefreshGrid(newId);
            _unsavedChanges = true;
        }

        public void DeleteDeviceConfig()
        {
            Nullable<Guid> selectedId = GetSelectedRowId();
            if (!selectedId.HasValue)
            {
                throw new UserThrownException("No timesheet item selected to be deleted.", false, true, false);
            }
            _deviceConfigCache.Delete(selectedId.Value);
            RefreshGrid();
            _unsavedChanges = true;
        }

        public void SaveDeviceConfigsToServer()
        {
            string originalStatus = Status;
            try
            {
                using (WaitCursor w = new WaitCursor())
                {
                    Status = "Saving device configs to server ...";
                    if(_deviceConfigCache.SaveToServer())
                    {
                        return;
                    }
                    _currentDeviceConfigCacheFilePath = null;
                    _unsavedChanges = false;
                    RefreshDeviceConfigFromServer(false);
                    UIHelper.DisplayInformation("Saved to server.");
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

        public void ExportToCsv()
        {
            string originalStatus = Status;
            try
            {
                if (svdExport.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                using (WaitCursor w = new WaitCursor())
                {
                    Status = string.Format("Exporting device configs to {0} ...", svdExport.FileName);
                    _filteredDeviceConfigCache.ExportToCsv(svdExport.FileName, null, false, false);
                }
                _currentDeviceConfigCacheFilePath = svdExport.FileName;
                _unsavedChanges = false;
                Status = string.Format("Current file : {0}", _currentDeviceConfigCacheFilePath);
            }
            catch
            {
                if (Status != originalStatus)
                {
                    Status = originalStatus;
                }
                throw;
            }
        }

        private void InitHiddenColumns()
        {
            _hiddenColumns = new List<string>();
            _hiddenColumns.Add(EntityReader<DeviceConfig>.GetPropertyName(p => p.DeviceConfigId, true));
            _hiddenColumns.Add(EntityReader<DeviceConfig>.GetPropertyName(p => p.CustomerId, true));
        }

        public void RefreshGrid()
        {
            string originalStatus = Status;
            try
            {
                int selectedRowIndex = -1;
                if (grdDeviceConfigs.SelectedRows.Count > 0)
                {
                    selectedRowIndex = grdDeviceConfigs.SelectedRows[0].Index;
                }
                if (_filtersEnabled)
                {
                    Dictionary<string, object> properties = new Dictionary<string, object>();
                    properties.Add(EntityReader<DeviceConfig>.GetPropertyName(p => p.DeviceId, false), txtFilterDeviceId.Text);
                    properties.Add(EntityReader<DeviceConfig>.GetPropertyName(p => p.ApplicationName, false), txtFilterApplicationName.Text);
                    grdDeviceConfigs.DataSource = _deviceConfigCache.GetDataTable(
                        properties,
                        false,
                        true,
                        chkFilterExpired.Checked,
                        _filteredDeviceConfigCache); //After this call the filtered cache will only contain the items included while the filtered was applied.
                }
                else
                {
                    grdDeviceConfigs.DataSource = _deviceConfigCache.GetDataTable(null, false, true);
                    _filteredDeviceConfigCache.Clear();
                    _deviceConfigCache.ToList().ForEach(p => _filteredDeviceConfigCache.Add(p));
                }
                _hiddenColumns.ForEach(c => grdDeviceConfigs.Columns[c].Visible = false);
                if (selectedRowIndex < grdDeviceConfigs.Rows.Count && selectedRowIndex > -1)
                {
                    grdDeviceConfigs.Rows[selectedRowIndex].Selected = true;
                }
                grdDeviceConfigs.Refresh();
            }
            finally
            {
                if (Status != originalStatus)
                {
                    Status = originalStatus;
                }
            }
        }

        public void RefreshGrid(Guid idToSelect)
        {
            RefreshGrid();
            foreach (DataGridViewRow r in grdDeviceConfigs.Rows)
            {
                r.Selected = false;
            }
            foreach (DataGridViewRow r in grdDeviceConfigs.Rows)
            {
                DataRow drv = ((DataRowView)(r.DataBoundItem)).Row;
                Guid currentId = new Guid(drv[EntityReader<DeviceConfig>.GetPropertyName(p => p.DeviceConfigId, true)].ToString());
                if (currentId == idToSelect)
                {
                    r.Selected = true;
                    return;
                }
            }
        }

        public void UpdateDeviceConfig()
        {
            switch (InUpdateMode)
            {
                case true:
                    UpdateCurrentDeviceConfig();
                    EnableControlsForNonUpdateMode();
                    break;
                case false:
                    PrepareForDeviceConfigUpdate();
                    EnableControlsForUpdateMode();
                    break;
            }
        }

        private void EnableControlsForNonUpdateMode()
        {
            tsDeviceConfigAdd.Enabled = true;
            tsDeviceConfigUpdate.Enabled = true;
            tsDeviceConfigUpdateCancel.Enabled = false;
            tsDeviceConfigUpdateCommit.Enabled = false;
            tsDeviceConfigDelete.Enabled = true;
            ApplyCurrentUserPermissions();
            dtpLicenseExpiryDate.Enabled = true;
        }

        private void EnableControlsForUpdateMode()
        {
            tsDeviceConfigAdd.Enabled = false;
            tsDeviceConfigUpdate.Enabled = false;
            tsDeviceConfigUpdateCancel.Enabled = true;
            tsDeviceConfigUpdateCommit.Enabled = true;
            tsDeviceConfigDelete.Enabled = false;
            dtpLicenseExpiryDate.Enabled =
                GlobalDataCache.Instance.CurrentUserRoleId != UserRoleId.Administrator &&
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.UpdateDeviceConfigurationExpiryDate.ToString()] == null ?
                false :
                true;
        }

        private void UpdateCurrentDeviceConfig()
        {
            ValidateMandatoryFields();

            _deviceConfigUnderUpdate.DeviceId = string.IsNullOrEmpty(txtDeviceId.Text) ? null : txtDeviceId.Text;
            _deviceConfigUnderUpdate.ApplicationName = string.IsNullOrEmpty(txtApplicationName.Text) ? null : txtApplicationName.Text;
            _deviceConfigUnderUpdate.ApplicationWebServiceURL = string.IsNullOrEmpty(txtApplicationWebServiceUrl.Text) ? null : txtApplicationWebServiceUrl.Text;
            _deviceConfigUnderUpdate.ApplicationReplicationWebServiceURL = string.IsNullOrEmpty(txtApplicationReplicationWebServiceUrl.Text) ? null : txtApplicationReplicationWebServiceUrl.Text;
            _deviceConfigUnderUpdate.ClientConfigWebServiceURL = string.IsNullOrEmpty(txtClientConfigWebServiceUrl.Text) ? null : txtClientConfigWebServiceUrl.Text;
            _deviceConfigUnderUpdate.LicenseExpiryDate = dtpLicenseExpiryDate.Value;
            _deviceConfigUnderUpdate.CustomerId = _deviceConfigCustomerId.Value;
            _deviceConfigUnderUpdate.CustomerCompanyName = txtCustomerCompanyName.Text;
            _deviceConfigUnderUpdate.NotifyOnInactivity = chkNotifyOnInactivity.Checked;

            ClearInputControls();
            RefreshGrid();
            _deviceConfigUnderUpdate = null;
            EnableControlsForNonUpdateMode();
            _unsavedChanges = true;
            if (UpdateModeChanged != null)
            {
                UpdateModeChanged(new DeviceConfigControlStateChangedArgs() { Enabled = false }); //No longer in update mode.
            }
        }

        private void PrepareForDeviceConfigUpdate()
        {
            Nullable<Guid> selectedId = GetSelectedRowId();
            if (!selectedId.HasValue)
            {
                throw new UserThrownException("No device config selected to be updated.", false, true, false);
            }
            SelectDeviceConfigInputsTabPage();
            _deviceConfigUnderUpdate = _deviceConfigCache[selectedId.Value];

            txtDeviceId.Text = _deviceConfigUnderUpdate.DeviceId;
            txtApplicationName.Text = _deviceConfigUnderUpdate.ApplicationName;
            txtApplicationWebServiceUrl.Text = _deviceConfigUnderUpdate.ApplicationWebServiceURL;
            txtApplicationReplicationWebServiceUrl.Text = _deviceConfigUnderUpdate.ApplicationReplicationWebServiceURL;
            txtClientConfigWebServiceUrl.Text = _deviceConfigUnderUpdate.ClientConfigWebServiceURL;
            dtpLicenseExpiryDate.Value =
                _deviceConfigUnderUpdate.LicenseExpiryDate.HasValue ?
                _deviceConfigUnderUpdate.LicenseExpiryDate.Value :
                DateTime.Now;
            txtCustomerCompanyName.Text = _deviceConfigUnderUpdate.CustomerCompanyName;
            _deviceConfigCustomerId = _deviceConfigUnderUpdate.CustomerId;
            chkNotifyOnInactivity.Checked = _deviceConfigUnderUpdate.NotifyOnInactivity;

            if (UpdateModeChanged != null)
            {
                UpdateModeChanged(new DeviceConfigControlStateChangedArgs() { Enabled = true }); //Entered update mode.
            }
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            using (SelectCustomerForm f = new SelectCustomerForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _deviceConfigCustomerId = f.Customer.CustomerId;
                    txtCustomerCompanyName.Text = f.Customer.CompanyName;
                }
            }
        }

        public void CancelUpdateMode()
        {
            ClearInputControls();
            RefreshGrid();
            _deviceConfigUnderUpdate = null;
            EnableControlsForNonUpdateMode();
            if (UpdateModeChanged != null)
            {
                UpdateModeChanged(new DeviceConfigControlStateChangedArgs() { Enabled = false }); //No longer in update mode.
            }
        }

        public Nullable<Guid> GetSelectedRowId()
        {
            if (grdDeviceConfigs.SelectedRows.Count < 1)
            {
                return null;
            }
            DataRow row = ((DataRowView)(grdDeviceConfigs.SelectedRows[0].DataBoundItem)).Row;
            return new Guid(row[EntityReader<DeviceConfig>.GetPropertyName(p => p.DeviceConfigId, true)].ToString());
        }

        public void ClearInputControls()
        {
            txtDeviceId.Focus();
            txtDeviceId.Clear();
            txtApplicationName.Clear();
            txtApplicationWebServiceUrl.Clear();
            txtApplicationReplicationWebServiceUrl.Clear();
            txtClientConfigWebServiceUrl.Clear();
            dtpLicenseExpiryDate.Value = DateTime.Now;
            txtCustomerCompanyName.Clear();
            _deviceConfigCustomerId = null;
            chkNotifyOnInactivity.Checked = false;
        }

        public void SetFiltersEnabled(bool enable)
        {
            if (enable)
            {
                tsDeviceConfigFiltersDisable.Enabled = true;
                tsDeviceConfigFiltersEnable.Enabled = false;
                ShowTimesheetInfoTabs(true, true);
                _filtersEnabled = true;
                SelectDeviceConfigFiltersTabPage();
                ClearDeviceConfigFiltersToDefault();
                if (FiltersEnabledChanged != null)
                {
                    FiltersEnabledChanged(new DeviceConfigControlStateChangedArgs() { Enabled = true }); //Now enabled
                }
            }
            else
            {
                tsDeviceConfigFiltersDisable.Enabled = false;
                tsDeviceConfigFiltersEnable.Enabled = true;
                ShowTimesheetInfoTabs(true, true);
                _filtersEnabled = false;
                SelectDeviceConfigInputsTabPage();
                if (FiltersEnabledChanged != null)
                {
                    FiltersEnabledChanged(new DeviceConfigControlStateChangedArgs() { Enabled = false });//Now disabled
                }
            }
            RefreshGrid();
        }

        private void ShowTimesheetInfoTabs(
            bool showDeviceConfignputsPage,
            bool showDeviceConfigFiltersPage)
        {
            tabDeviceConfigInfo.TabPages.Remove(tabPageDeviceConfigInputs);
            tabDeviceConfigInfo.TabPages.Remove(tabPageDeviceConfigFilters);
            if (showDeviceConfignputsPage)
            {
                tabDeviceConfigInfo.TabPages.Add(tabPageDeviceConfigInputs);
            }
            if (showDeviceConfigFiltersPage)
            {
                tabDeviceConfigInfo.TabPages.Add(tabPageDeviceConfigFilters);
            }
        }

        public void RefreshDeviceConfigFromServer(bool selectInputsTab)
        {
            if ((_unsavedChanges) &&
                (UIHelper.AskQuestion("There are unsaved changes. Are you sure you want to refresh the device configs from the server? All unsaved changes will be lost.") !=
                DialogResult.Yes))
            {
                return;
            }
            string originalStatus = Status;
            try
            {
                using (WaitCursor w = new WaitCursor())
                {
                    Status = "Refreshing device configs from server ...";
                    if (_deviceConfigCache.RefreshFromServerWithCustomerInfo())
                    {
                        return;
                    }
                }
                ClearInputControls();
                RefreshGrid();
                if (selectInputsTab)
                {
                    SelectDeviceConfigInputsTabPage();
                }
                _currentDeviceConfigCacheFilePath = null;
                _unsavedChanges = false;
            }
            finally
            {
                if (Status != originalStatus)
                {
                    Status = originalStatus;
                }
            }
        }

        #endregion //Methods

        #region Event Handlers

        private void tsDeviceConfigAdd_Click(object sender, EventArgs e)
        {
            AddDeviceConfig();
        }

        private void tsDeviceConfigUpdate_Click(object sender, EventArgs e)
        {
            UpdateDeviceConfig();
        }

        private void tsDeviceConfigUpdateCancel_Click(object sender, EventArgs e)
        {
            CancelUpdateMode();
        }

        private void tsDeviceConfigDelete_Click(object sender, EventArgs e)
        {
            DeleteDeviceConfig();
        }

        private void tsDeviceConfigFiltersEnable_Click(object sender, EventArgs e)
        {
            SetFiltersEnabled(!_filtersEnabled);
        }

        private void lnkClearDeviceConfigFilterControls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDeviceConfigFiltersToDefault();
        }

        private void txtFilterDeviceId_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtFilterApplicationName_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void chkFilterExpired_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dtpFilterLicenseExpiryStartDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dtpFilterLicenseExpiryEndDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void lnkClearDeviceConfigInputControls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearInputControls();
        }

        #endregion //Event Handlers
    }
}