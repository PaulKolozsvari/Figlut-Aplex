namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using Figlut.Aplex.Mobile.DeviceConfig.FiglutWebService;

    #endregion //Using Directives

    public class DeviceConfigManager
    {
        #region Methods

        /// <summary>
        /// Attempts to get the device configuration based on the application's name set in
        /// DeviceConfigOptions.ApplicationName and the device id.
        /// </summary>
        public static void GetDeviceConfig()
        {
            if (string.IsNullOrEmpty(DeviceConfigOptions.ApplicationName))
            {
                throw new NullReferenceException("Application name not set.");
            }
            GetDeviceConfig(DeviceConfigOptions.ApplicationName);
        }

        /// <summary>
        /// Attempts to get the device configuration based on the applicationName parameter and the device id.
        /// </summary>
        /// <param name="applicationName"></param>
        public static void GetDeviceConfig(string applicationName)
        {
            string deviceId = PsionTeklogix.SystemPTX.SystemInformation.MachineUID;
            if (string.IsNullOrEmpty(deviceId))
            {
                deviceId = "emulator";
            }
            ServiceFunctionResultOfDeviceConfig result =
                DeviceConfigOptions.Instance.Service.GetDeviceConfig(deviceId, applicationName);
            switch (result.Code)
            {
                case ServiceResultCode.Success:
                    break;
                case ServiceResultCode.Information:
                    UIHelper.DisplayInformation(result.Message);
                    break;
                case ServiceResultCode.SpecialInstructions:
                    UIHelper.DisplayInformation(result.Message);
                    break;
                case ServiceResultCode.Warning:
                    UIHelper.DisplayWarning(result.Message);
                    break;
                case ServiceResultCode.OperationError:
                    UIHelper.DisplayError(result.Message);
                    break;
                case ServiceResultCode.FatalError:
                    throw new Exception(result.Message);
                default:
                    throw new Exception(string.Format("Invalid result code {0}.", result.Code.ToString()));
            }
            bool switchToNewClientConfigService = result.Contents.ClientConfigWebServiceURL != DeviceConfigOptions.Instance.Settings.FiglutWebServiceUrl;
            DeviceConfigOptions.Instance.Settings.ApplicationWebServiceUrl = result.Contents.ApplicationWebServiceURL;
            DeviceConfigOptions.Instance.Settings.ApplicationReplicationWebServiceUrl = result.Contents.ApplicationReplicationWebServiceURL;
            DeviceConfigOptions.Instance.Settings.FiglutWebServiceUrl = result.Contents.ClientConfigWebServiceURL;
            DeviceConfigOptions.Instance.Settings.Save();
            DeviceConfigOptions.Instance.RecreateServices();
            if (switchToNewClientConfigService)
            {
                GetDeviceConfig();
            }
        }

        public static string GetDeviceId()
        {
            return PsionTeklogix.SystemPTX.SystemInformation.MachineUID;
        }

        #endregion //Methods
    }
}
