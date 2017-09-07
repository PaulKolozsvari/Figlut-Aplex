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

    public class DeviceConfigContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<List<DeviceConfig>> GetAllDeviceConfigWithCustomerInfo(User user)
        {
            try
            {
                ValidateUser(user);
                List<DeviceConfig> result = new List<DeviceConfig>();
                using (TransactionScope t = new TransactionScope())
                {
                    var query = (from d in DB.GetTable<DeviceConfig>()
                                 join c in DB.GetTable<Customer>() on d.CustomerId equals c.CustomerId
                                 select new
                                 {
                                     c.CompanyName,
                                     d.DeviceConfigId,
                                     d.DeviceId,
                                     d.ApplicationName,
                                     d.ApplicationWebServiceURL,
                                     d.ApplicationReplicationWebServiceURL,
                                     d.ClientConfigWebServiceURL,
                                     d.LicenseExpiryDate,
                                     d.LastConnectionDate,
                                     d.ActionCount,
                                     d.NotifyOnInactivity,
                                     d.DateCreated,
                                     d.CustomerId,
                                 });
                    query.ToList().ForEach(p => result.Add(new DeviceConfig()
                    {
                        CustomerCompanyName = p.CompanyName,
                        DeviceConfigId = p.DeviceConfigId,
                        DeviceId = p.DeviceId,
                        ApplicationName = p.ApplicationName,
                        ApplicationWebServiceURL = p.ApplicationWebServiceURL,
                        ApplicationReplicationWebServiceURL = p.ApplicationReplicationWebServiceURL,
                        ClientConfigWebServiceURL = p.ClientConfigWebServiceURL,
                        LicenseExpiryDate = p.LicenseExpiryDate,
                        LastConnectionDate = p.LastConnectionDate,
                        ActionCount = p.ActionCount,
                        NotifyOnInactivity = p.NotifyOnInactivity,
                        DateCreated = p.DateCreated,
                        CustomerId = p.CustomerId,
                    }));
                    t.Complete();
                }
                return new ServiceFunctionResult<List<DeviceConfig>>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<DeviceConfig>>(HandleException(ex));
            }
        }

        public ServiceFunctionResult<DeviceConfig> GetDeviceConfig(string deviceId, string applicationName)
        {
            try
            {
                DeviceConfig result = null;
                /*We need a separate to get the entity in order to be able to update its LastConnectionDate, otherwise the underlying LINQConext
                will not update the database because the "original entity" will be the same object as the "new entity we're getting here.*/
                DeviceConfigContext ctx = new DeviceConfigContext();
                List<DeviceConfig> deviceConfigQuery = (from d in ctx.DB.GetTable<DeviceConfig>()
                                                        where d.DeviceId == deviceId && d.ApplicationName == applicationName
                                                        select d).ToList();
                result = deviceConfigQuery.Count < 1 ? null : deviceConfigQuery[0];
                if (result == null)
                {
                    SaveDevicePendingApproval(deviceId, applicationName);
                    throw new ServiceException(
                        string.Format("Could not retrieve settings for application on device {0}. Device not registered.", deviceId),
                        ServiceResultCode.FatalError);
                }
                if (result.LicenseExpiryDate.HasValue && result.LicenseExpiryDate.Value < DateTime.Now)
                {
                    throw new ServiceException(
                        string.Format("License for device ID {0} has expired.", deviceId), ServiceResultCode.FatalError);
                }
                using (TransactionScope t = new TransactionScope())
                {
                    User systemUser = GetSystemUser();
                    result.LastConnectionDate = DateTime.Now;
                    if (result.ActionCount.HasValue)
                    {
                        result.ActionCount++;
                    }
                    else
                    {
                        result.ActionCount = 1;
                    }
                    Save<DeviceConfig>(result, false).ForEach(c => HandleChange(c, systemUser));
                    GlobalVariable g = GetGlobalVariable(GlobalVariableName.LogActionGetDeviceConfig);
                    if (bool.Parse(g.VariableValue))
                    {
                        SaveDeviceConfigAction(result, "GetDeviceConfig", null, systemUser);
                    }
                    t.Complete();
                }
                return new ServiceFunctionResult<DeviceConfig>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<DeviceConfig>(HandleException(ex));
            }
        }

        public ServiceFunctionResult<DeviceConfigAction> LogDeviceConfigAction(
            string function,
            string deviceId,
            string applicationName,
            string tag)
        {
            try
            {
                DeviceConfigAction result = null;
                using (TransactionScope t = new TransactionScope())
                {
                    /*We need a separate to get the entity in order to be able to update its LastConnectionDate, otherwise the underlying LINQConext
                    will not update the database because the "original entity" will be the same object as the "new entity we're getting here.*/
                    DeviceConfigContext ctx = new DeviceConfigContext();
                    List<DeviceConfig> deviceConfigQuery = (from d in ctx.DB.GetTable<DeviceConfig>()
                                                            where d.DeviceId == deviceId && d.ApplicationName == applicationName
                                                            select d).ToList();
                    DeviceConfig deviceConfig = deviceConfigQuery.Count < 1 ? null : deviceConfigQuery[0];
                    if (deviceConfig == null)
                    {
                        throw new ServiceException(
                            string.Format(
                            "Could not retrieve settings for application on device {0}. Device not registered. Attempt to get device configuration for device to be added as a device pending approval.",
                            deviceId),
                            ServiceResultCode.FatalError);
                    }
                    User systemUser = GetSystemUser();
                    deviceConfig.LastConnectionDate = DateTime.Now;
                    if (deviceConfig.ActionCount.HasValue)
                    {
                        deviceConfig.ActionCount++;
                    }
                    else
                    {
                        deviceConfig.ActionCount = 1;
                    }
                    Save<DeviceConfig>(deviceConfig, false).ForEach(c => HandleChange(c, systemUser));
                    SaveDeviceConfigAction(deviceConfig, function, tag, systemUser);
                    t.Complete();
                }
                return new ServiceFunctionResult<DeviceConfigAction>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<DeviceConfigAction>(HandleException(ex));
            }
        }

        private DeviceConfigAction SaveDeviceConfigAction(DeviceConfig deviceConfig, string function, string tag, User user)
        {
            List<Customer> customerQuery = (from c in DB.GetTable<Customer>()
                                            where c.CustomerId == deviceConfig.CustomerId
                                            select c).ToList();
            Customer customer = customerQuery.Count < 1 ? null : customerQuery[0];
            if (customer == null)
            {
                throw new ServiceException(
                    string.Format("Could not find customer with ID {0} for device with device id {1}.",
                    deviceConfig.CustomerId,
                    deviceConfig.DeviceId),
                    ServiceResultCode.FatalError);
            }
            DeviceConfigAction result = new DeviceConfigAction()
            {
                DeviceConfigActionId = Guid.NewGuid(),
                Function = function,
                DeviceId = deviceConfig.DeviceId,
                ApplicationName = deviceConfig.ApplicationName,
                CustomerCompanyName = customer.CompanyName,
                Tag = tag,
                DeviceConfigId = deviceConfig.DeviceConfigId,
                DateCreated = DateTime.Now
            };
            Save<DeviceConfigAction>(result, false).ForEach(c => HandleChange(c, user));
            return result;
        }

        private void SaveDevicePendingApproval(string deviceId, string applicationName)
        {
            User systemUser = GetSystemUser();
            List<DevicePendingApproval> query = (from d in DB.GetTable<DevicePendingApproval>()
                                                 where (d.DeviceId == deviceId) && (d.ApplicationName == applicationName)
                                                 select d).ToList();
            DevicePendingApproval devicePendingApproval = query.Count < 1 ? null : query[0];
            if (devicePendingApproval == null)
            {
                devicePendingApproval = new DevicePendingApproval()
                {
                    DevicePendingApprovalId = Guid.NewGuid(),
                    DeviceId = deviceId,
                    ApplicationName = applicationName,
                    DateCreated = DateTime.Now
                };
            }
            devicePendingApproval.LatestAttemptDate = DateTime.Now;
            using (TransactionScope t = new TransactionScope())
            {
                Save<DevicePendingApproval>(devicePendingApproval, false).ForEach(c => HandleChange(c, systemUser));
                t.Complete();
            }
            SendDevicePendingApprovalEmailNotification(devicePendingApproval, systemUser);
        }

        private void SendDevicePendingApprovalEmailNotification(DevicePendingApproval devicePendingApproval, User user)
        {
            GlobalVariable g = GetGlobalVariable(GlobalVariableName.EmailDevicePendingApproval);
            if (!bool.Parse(g.VariableValue))
            {
                return;
            }
            using (TransactionScope t = new TransactionScope())
            {
                List<User> usersOptedIn = GetUsersOptedIn();
                if (usersOptedIn == null || usersOptedIn.Count < 1)
                {
                    return;
                }
                StringBuilder body = new StringBuilder();
                body.AppendLine(string.Format("Device Id : {0}", devicePendingApproval.DeviceId));
                body.AppendLine(string.Format("Application Name : {0}", devicePendingApproval.ApplicationName));
                body.AppendLine(string.Format("Latest Attempt Date : {0}", devicePendingApproval.LatestAttemptDate.ToString()));
                body.AppendLine(string.Format("Date Created : {0}", devicePendingApproval.DateCreated.ToString()));
                List<string> emailRecipients = new List<string>();
                StringBuilder toEmailAddresses = new StringBuilder();
                foreach (User u in usersOptedIn)
                {
                    emailRecipients.Add(u.Email);
                    toEmailAddresses.AppendFormat("{0};", u.Email);
                }
                EmailSender.SendMail(
                    Options.Instance.Settings.DevicePendingApprovalNotificationSubject,
                    body.ToString(),
                    null,
                    emailRecipients);
                EmailAction emailAction = new EmailAction()
                {
                    EmailActionId = Guid.NewGuid(),
                    ToEmailAddress = toEmailAddresses.ToString(),
                    FromEmailAddress = Options.Instance.Settings.FromEmailAddress,
                    Subject = Options.Instance.Settings.DevicePendingApprovalNotificationSubject,
                    Body = body.ToString(),
                    UserId = user.UserId,
                    DateCreated = DateTime.Now
                };
                Save<EmailAction>(emailAction, false).ForEach(c => HandleChange(c, user));
                t.Complete();
            }
        }

        public ServiceProcedureResult ApproveDevicePendingApproval(
            string deviceId,
            string applicationName,
            string applicationWebServiceURL,
            string applicationReplicationWebServiceURL,
            string clientConfigWebServiceURL,
            int daysToActivate,
            Customer customer,
            User user)
        {
            try
            {
                ValidateUser(user);
                List<DevicePendingApproval> devicePendingApprovalQuery = (from d in DB.GetTable<DevicePendingApproval>()
                                                                          where (d.DeviceId == deviceId) && (d.ApplicationName == applicationName)
                                                                          select d).ToList();
                DevicePendingApproval devicePendingApproval = devicePendingApprovalQuery.Count < 1 ? null : devicePendingApprovalQuery[0];
                if (devicePendingApproval == null)
                {
                    throw new ServiceException(
                        string.Format("No device pending approval with device ID {0} for application {1} could be found.", deviceId, applicationName),
                        ServiceResultCode.FatalError);
                }
                List<DeviceConfig> deviceConfigQuery = (from dc in DB.GetTable<DeviceConfig>()
                                                        where (dc.DeviceId == deviceId) && (dc.ApplicationName == applicationName)
                                                        select dc).ToList();
                DeviceConfig deviceConfig = deviceConfigQuery.Count < 1 ? null : deviceConfigQuery[0];
                if (deviceConfig != null)
                {
                    throw new ServiceException(
                        string.Format("Device with device ID {0} for application {1} already approved.", deviceId, applicationName),
                        ServiceResultCode.FatalError);
                }
                DateTime licenseExpiryDate = DateTime.Now.AddDays(daysToActivate);
                deviceConfig = new DeviceConfig()
                {
                    DeviceConfigId = Guid.NewGuid(),
                    DeviceId = deviceId,
                    ApplicationName = applicationName,
                    ApplicationWebServiceURL = applicationWebServiceURL,
                    ApplicationReplicationWebServiceURL = applicationReplicationWebServiceURL,
                    ClientConfigWebServiceURL = clientConfigWebServiceURL,
                    LicenseExpiryDate = licenseExpiryDate,
                    DateCreated = DateTime.Now,
                    CustomerId = customer.CustomerId
                };
                using (TransactionScope t = new TransactionScope())
                {
                    Delete<DevicePendingApproval>(devicePendingApproval).ForEach(c => HandleChange(c, user));
                    Save<DeviceConfig>(deviceConfig, false).ForEach(c => HandleChange(c, user));
                    t.Complete();
                }
                return new ServiceProcedureResult() { Message = "Device approved successfully." };
            }
            catch (Exception ex)
            {
                return new ServiceProcedureResult(HandleException(ex, user));
            }
        }

        public ServiceProcedureResult UpdateDeviceConfig(
            string deviceId,
            string applicationName,
            string applicationWebServiceURL,
            string applicationReplicationWebServiceURL,
            string clientConfigWebServiceURL,
            DateTime licenseExpiryDate,
            User user)
        {
            try
            {
                ValidateUser(user);
                List<DeviceConfig> deviceConfigQuery = (from dc in DB.GetTable<DeviceConfig>()
                                                        where (dc.DeviceId == deviceId) && (dc.ApplicationName == applicationName)
                                                        select dc).ToList();
                DeviceConfig deviceConfig = deviceConfigQuery.Count < 1 ? null : deviceConfigQuery[0];
                if (deviceConfig == null)
                {
                    throw new ServiceException(
                        string.Format("Device config for device ID {0} for application {1} does not exist.", deviceId, applicationName),
                        ServiceResultCode.FatalError);
                }
                deviceConfig.ApplicationWebServiceURL = applicationReplicationWebServiceURL;
                deviceConfig.ApplicationReplicationWebServiceURL = applicationReplicationWebServiceURL;
                deviceConfig.ClientConfigWebServiceURL = clientConfigWebServiceURL;
                deviceConfig.LicenseExpiryDate = licenseExpiryDate;
                using (TransactionScope t = new TransactionScope())
                {
                    Save<DeviceConfig>(deviceConfig, false).ForEach(c => HandleChange(c, user));
                    t.Complete();
                }
                return new ServiceProcedureResult() { Message = "Updated device config successfully." };
            }
            catch (Exception ex)
            {
                return new ServiceProcedureResult(HandleException(ex));
            }
        }

        #endregion //Methods
    }
}