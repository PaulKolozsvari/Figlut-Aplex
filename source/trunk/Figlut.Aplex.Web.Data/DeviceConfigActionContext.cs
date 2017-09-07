namespace Figlut.Aplex.Web.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Web.Utilities;
    using System.Transactions;
    using Figlut.Aplex.Web.Data;

    #endregion //Using Directives

    public class DeviceConfigActionContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<List<DeviceConfigAction>> GetDeviceConfigActionByFilters(
            string deviceId,
            string applicationName,
            DateTime startDate,
            DateTime endDate,
            User user)
        {
            try
            {
                ValidateUser(user);
                List<DeviceConfigAction> result = null;
                using (TransactionScope t = new TransactionScope())
                {
                    string deviceIdLower = deviceId.Trim().ToLower();
                    string applicationNameLower = applicationName.Trim().ToLower();
                    result = (from d in DB.GetTable<DeviceConfigAction>()
                              where d.DeviceId.Trim().ToLower().Contains(deviceIdLower) &&
                                    d.ApplicationName.Trim().ToLower().Contains(applicationNameLower) &&
                                    d.DateCreated > startDate &&
                                    d.DateCreated < endDate
                              select d).ToList();
                    t.Complete();
                }
                return new ServiceFunctionResult<List<DeviceConfigAction>>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<DeviceConfigAction>>(HandleException(ex, user));
            }
        }

        #endregion //Methods
    }
}
