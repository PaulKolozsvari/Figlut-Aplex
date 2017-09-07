namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;

    #endregion //Using Directives

    public class ExceptionHandler
    {
        #region Methods

        public static void HandleException(Exception exception, bool log, bool display)
        {
            try
            {
                if (exception == null)
                {
                    throw new NullReferenceException("exception to be handled may not be null.");
                }
                if (display)
                {
                    UIHelper.DisplayException(exception);
                }
                if (log)
                {
                    Logger.LogError(new Error() { Date = DateTime.Now, Exception = exception });
                }
            }
            catch (Exception ex)
            {
                UIHelper.DisplayException(ex);
            }
        }

        #endregion //Methods
    }
}