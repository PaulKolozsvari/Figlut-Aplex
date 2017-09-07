namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    #endregion //Using Directives

    public class DeviceConfigSettings
    {
        #region Constants

        private const string FILE_NAME = "FiglutSettings.xml";

        #endregion //Constants

        #region Properties

        public string LogFileName { get; set; }

        public string ApplicationWebServiceUrl { get; set; }

        public string ApplicationReplicationWebServiceUrl { get; set; }

        public string FiglutWebServiceUrl { get; set; }

        #endregion //Properties

        #region Methods

        public static DeviceConfigSettings GetSettings()
        {
            string filePath = Path.Combine(DeviceConfigOptions.ExecutingDirectory, FILE_NAME);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(string.Format("Could not find {0}.", filePath));
            }
            return (DeviceConfigSettings)Serializer.DeserializeFromFile(typeof(DeviceConfigSettings), filePath);
        }

        public void Save()
        {
            string filePath = Path.Combine(DeviceConfigOptions.ExecutingDirectory, FILE_NAME);
            Serializer.SerializeToFile(this, filePath);
        }

        #endregion //Methods
    }
}