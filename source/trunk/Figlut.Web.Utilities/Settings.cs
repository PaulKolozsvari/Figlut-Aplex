namespace Figlut.Web.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    #endregion //Using Directives

    public class Settings
    {
        #region Inner Types

        public enum SmsServiceProvider
        {
            SmsGenie
        }

        #endregion //Inner Types

        #region Constants

        private const string FILE_NAME = "Server.Settings.xml";

        #endregion //Constants

        #region Properties

        public string DeviceConfigSystemUserName { get; set; }

        public string DeviceConfigSystemUserPassword { get; set; }

        public string GMailSMTPServer { get; set; }

        public int GMailSMTPPort { get; set; }

        public string GMailUserName { get; set; }

        public string GMailPassword { get; set; }

        public string FromName { get; set; }

        public string FromEmailAddress { get; set; }

        public string DevicePendingApprovalNotificationSubject { get; set; }

        #endregion //Properties

        #region Methods

        public static Settings GetSettings()
        {
            string filePath = Path.Combine(Options.ExecutingDirectory, FILE_NAME);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(string.Format("Could not find {0}.", filePath));
            }
            return (Settings)Serializer.DeserializeFromFile(typeof(Settings), filePath);
        }

        public void Save()
        {
            string filePath = Path.Combine(Options.ExecutingDirectory, FILE_NAME);
            Serializer.SerializeToFile(this, filePath);
        }

        #endregion //Methods
    }
}