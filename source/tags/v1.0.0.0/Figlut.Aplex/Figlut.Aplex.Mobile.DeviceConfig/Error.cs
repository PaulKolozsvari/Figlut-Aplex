namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;

    #endregion //Using Directives

    public class Error
    {
        #region Properties

        public DateTime Date { get; set; }

        public Exception Exception { get; set; }

        #endregion //Properties

        #region Methods

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("Date Time : {0}\r\n", Date.ToString()));
            result.Append(string.Format("Exception : {0}\r\n", Exception.ToString()));

            return result.ToString();
        }

        #endregion //Methods
    }
}