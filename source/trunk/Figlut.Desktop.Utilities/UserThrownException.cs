namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public class UserThrownException : Exception
    {
        #region Constructors

        public UserThrownException(string message, bool log, bool display, bool closeApplication) : base(message)
        {
            _log = log;
            _display = display;
            _closeApplication = closeApplication;
        }

        #endregion //Constructors

        #region Fields

        private bool _log;
        private bool _display;
        private bool _closeApplication;

        #endregion //Fields

        #region Properties

        public bool Log
        {
            get { return _log; }
        }

        public bool Display
        {
            get { return _display; }
        }

        public bool CloseApplication
        {
            get { return _closeApplication; }
        }

        #endregion //Properties
    }
}