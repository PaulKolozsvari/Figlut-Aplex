namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    #endregion //Using Directives

    public class Logger
    {
        #region Methods

        public static void LogError(Error error)
        {
            string logFilePath = Path.Combine(DeviceConfigOptions.ExecutingDirectory, DeviceConfigOptions.Instance.Settings.LogFileName);
            using (StreamWriter writer = new StreamWriter(logFilePath, true) { AutoFlush = true })
            {
                writer.WriteLine(error.ToString());
            }
        }

        #endregion //Methods
    }
}