namespace Figlut.LINQ.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Reflection;

    #endregion //Using Directives

    public class LINQOptions
    {
        #region Singleton Setup

        private static LINQOptions _instance;

        public static LINQOptions Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LINQOptions();
                }
                return _instance;
            }
        }

        #endregion //Singleton Setup

        #region Constructors

        private LINQOptions()
        {
            _settings = LINQSettings.GetSettings();
        }

        #endregion //Constructors

        #region Fields

        private LINQSettings _settings;

        #endregion //Fields

        #region Properties

        public static string ExecutingDirectory
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6); }
        }

        public LINQSettings Settings
        {
            get { return _settings; }
        }

        #endregion //Properties
    }
}
