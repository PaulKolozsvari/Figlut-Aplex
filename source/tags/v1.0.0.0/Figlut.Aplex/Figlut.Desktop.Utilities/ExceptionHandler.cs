namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Windows.Forms;

    #endregion //Using Directives

    public class ExceptionHandler
    {
        //Application Thread Exception: http://richnewman.wordpress.com/2007/04/08/top-level-exception-handling-in-windows-forms-applications-part-1/

        #region Constants

        private const string DEFAULT_LOG_FILE_NAME = "Log.csv";

        #endregion //Constants

        #region Methods

        /// <summary>
        /// Returns false if the application should close.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="support"></param>
        /// <param name="logFileName"></param>
        /// <returns></returns>
        public static bool HandleException(Exception exception, string support, string logFileName)
        {
            try
            {
                exception.HelpLink = support;
                bool log = true;
                bool display = true;
                bool closeApplication = false;
                UserThrownException userThrownException = exception as UserThrownException;
                if (userThrownException != null)
                {
                    log = userThrownException.Log;
                    display = userThrownException.Display;
                    closeApplication = userThrownException.CloseApplication;
                }
                if (display)
                {
                    UIHelper.DisplayException(exception);
                }
                if (log)
                {
                    LogEntry entry = new LogEntry()
                    {
                        Id = Guid.NewGuid(),
                        Type = LogEntry.EntryType.Error,
                        CreationDate = DateTime.Now,
                        Message = exception.Message,
                        ExceptionName = exception.GetType().FullName
                    };
                    Logger.Log(
                        entry,
                        Path.Combine(Information.GetExecutingDirectory(), logFileName));
                }
                if (closeApplication)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                UIHelper.DisplayException(ex);
                return true;
            }
        }

        #endregion //Methods
    }
}