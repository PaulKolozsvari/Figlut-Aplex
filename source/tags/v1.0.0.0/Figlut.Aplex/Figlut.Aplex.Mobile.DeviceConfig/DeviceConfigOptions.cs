namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Reflection;
    using Figlut.Aplex.Mobile.DeviceConfig.FiglutWebService;

    #endregion //Using Directives

    public class DeviceConfigOptions
    {
        #region Singleton Setup

        private static DeviceConfigOptions _instance;

        public static DeviceConfigOptions Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeviceConfigOptions();
                }
                return _instance;
            }
        }

        #endregion //Singleton Setup

        #region Constructors

        private DeviceConfigOptions()
        {
            _settings = DeviceConfigSettings.GetSettings();
            _service = new Service(_settings.FiglutWebServiceUrl);
        }

        #endregion //Constructors

        #region Constants

        public static string DEFAULT_SETTING_PROFILE_NAME = "default";

        #endregion //Constants

        #region Fields

        private DeviceConfigSettings _settings;
        private Service _service;

        #endregion //Fields

        #region Properties

        public static string ExecutingDirectory
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase); }
        }

        public static string ApplicationName { get; set; }

        public DeviceConfigSettings Settings
        {
            get { return _settings; }
        }

        public Service Service
        {
            get { return _service; }
        }

        public User CurrentUser { get; set; }

        #endregion //Properties

        #region Methods

        public void RecreateServices()
        {
            _service = new Service(_settings.FiglutWebServiceUrl);
        }

        #endregion //Methods
    }
}
