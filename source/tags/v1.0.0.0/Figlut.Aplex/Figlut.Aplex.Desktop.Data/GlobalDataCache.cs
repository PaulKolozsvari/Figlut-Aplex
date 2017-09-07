namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    public class GlobalDataCache
    {
        #region Singleton Setup

        private static GlobalDataCache _instance;

        public static GlobalDataCache Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlobalDataCache();
                }
                return _instance;
            }
        }

        #endregion //Singleton Setup

        #region Constructors

        private GlobalDataCache()
        {
            _settings = LocalSettings.GetSettings();
            _service = new Service(_settings.WebServiceURL);
            _globalServerVariables = new GlobalServerVariables();
            _availableUserPermissionNames = new Dictionary<string, object>();
            RefreshAvailableUserPermissionNames();
        }

        #endregion //Constructors

        #region Fields

        private Service _service;
        private LocalSettings _settings;
        private GlobalServerVariables _globalServerVariables;
        private User _currentUser;
        private UserRoleId _currentUserRoleId;
        private Dictionary<string, object> _availableUserPermissionNames;

        #endregion //Fields

        #region Properties

        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;
                int adminRoleId = (int)UserRoleId.Administrator;
                if (adminRoleId != 7)
                {
                    throw new UserThrownException("Invalid role numbers set. Contact administrator.", true, true, true);
                }
                _currentUserRoleId = (UserRoleId)_currentUser.RoleId;
            }
        }

        public UserRoleId CurrentUserRoleId
        {
            get { return _currentUserRoleId; }
        }

        public Dictionary<string, object> AvailableUserPermissionNames
        {
            get { return _availableUserPermissionNames; }
        }

        public LocalSettings Settings
        {
            get { return _settings; }
        }

        public Service Service
        {
            get { return _service; }
        }

        public GlobalServerVariables GlobalServerVariables
        {
            get { return _globalServerVariables; }
        }

        #endregion //Properties

        #region Methods

        private void RefreshAvailableUserPermissionNames()
        {
            _availableUserPermissionNames.Clear();
            _availableUserPermissionNames.Add(UserPermissionName.UserManagement.ToString(), null);
            _availableUserPermissionNames.Add(UserPermissionName.CustomerManagement.ToString(), null);
            _availableUserPermissionNames.Add(UserPermissionName.GlobalServerSettingsManagement.ToString(), null);
            _availableUserPermissionNames.Add(UserPermissionName.DevicesPendingApprovalManagement.ToString(), null);
            _availableUserPermissionNames.Add(UserPermissionName.ApproveProductionLicense.ToString(), null);
            _availableUserPermissionNames.Add(UserPermissionName.AddDeviceConfiguration.ToString(), null);
            _availableUserPermissionNames.Add(UserPermissionName.UpdateDeviceConfigurationExpiryDate.ToString(), null);

            _availableUserPermissionNames.Add(UserPermissionName.ViewDeviceConfigActions.ToString(), null);
            _availableUserPermissionNames.Add(UserPermissionName.ViewServerActions.ToString(), null);
            _availableUserPermissionNames.Add(UserPermissionName.ViewServerErrors.ToString(), null);
            //_availableUserPermissionNames.Add(UserPermissionName.DeviceConfigurationManagement.ToString(), null);
        }

        #endregion //Methods
    }
}