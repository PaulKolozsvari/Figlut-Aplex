namespace Figlut.Desktop.Utilities
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

        public static void Log(LogEntry logEntry, string logFilePath)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true) { AutoFlush = true })
            {
                if (writer.BaseStream.Length == 0)
                {
                    writer.WriteLine((new LogEntryCache()).GetHeader());
                }
                writer.WriteLine(logEntry);
            }
        }

        #endregion //Methods
    }
}