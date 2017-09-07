namespace Figlut.Aplex.Web.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    /// <summary>
    /// User permission names that can be assigned to users.
    /// </summary>
    public enum UserPermissionName
    {
        UserManagement,
        CustomerManagement,
        DeleteCustomer,
        GlobalServerSettingsManagement,
        DevicesPendingApprovalManagement,
        DeviceConfigurationManagement,
        ApproveProductionLicense,
        DeleteDeviceConfiguration,
        AddDeviceConfiguration,
        UpdateDeviceConfigurationExpiryDate,
        ViewDeviceConfigActions,
        ViewServerActions,
        ViewServerErrors,
    }
}