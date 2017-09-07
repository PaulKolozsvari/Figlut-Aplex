namespace Figlut.Aplex.Web.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    /// <summary>
    /// Variable names matching the names of the variables on the server database.
    /// </summary>
    public enum GlobalVariableName
    {
        CompanyName,
        CompanyVatRegistrationNumber,
        CompanyAddressLine1,
        CompanyAddressLine2,
        CompanyAddressLine3,
        CompanyAddressLine4,
        CompanyAddressLine5,
        CompanyAddressLine6,
        MonetarySymbol,
        MaximumTrialDays,
        LogActionGetDeviceConfig,
        EmailDevicePendingApproval
    }
}
