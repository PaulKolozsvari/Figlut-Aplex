namespace Figlut.Web.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Reflection;

    #endregion //Using Directives

    public class Options
    {
        #region Singleton Setup

        private static Options _instance;

        public static Options Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Options();
                }
                return _instance;
            }
        }

        #endregion //Singleton Setup

        #region Constructors

        private Options()
        {
            _settings = Settings.GetSettings();
        }

        #endregion //Constructors

        #region Fields

        private Settings _settings;

        #endregion //Fields

        #region Properties

        public static string ExecutingDirectory
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6); }
        }

        public Settings Settings
        {
            get { return _settings; }
        }

        #endregion //Properties
    }
}