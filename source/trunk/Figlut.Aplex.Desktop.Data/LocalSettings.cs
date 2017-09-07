namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using Figlut.Desktop.Utilities;

    #endregion //Using Directives

    public class LocalSettings
    {
        #region Constants

        private const string FILE_NAME = "Figlut.Desktop.Settings.xml";

        #endregion //Constants

        #region Properties

        public string LogFileName { get; set; }

        public string WebServiceURL { get; set; }

        public string Support { get; set; }

        #endregion //Properties

        #region Methods

        public static LocalSettings GetSettings()
        {
            string filePath = Path.Combine(Information.GetExecutingDirectory(), FILE_NAME);
            if (!File.Exists(filePath))
            {
                throw new UserThrownException(string.Format("Could not find {0}.", filePath), false, true, true);
            }
            return (LocalSettings)Serializer.DeserializeFromFile(typeof(LocalSettings), filePath);
        }

        public void Save()
        {
            string filePath = Path.Combine(Information.GetExecutingDirectory(), FILE_NAME);
            Serializer.SerializeToFile(this, filePath);
        }

        #endregion //Methods
    }
}