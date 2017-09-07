namespace Figlut.LINQ.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using Figlut.Web.Utilities;

    #endregion //Using Directives

    public class LINQSettings
    {
        #region Constants

        private const string FILE_NAME = "LINQ.Settings.xml";

        #endregion //Constants

        #region Properties

        public string ConnectionString { get; set; }

        public int LinqToSQLCommandTimeout { get; set; }

        #endregion //Properties

        #region Methods

        public static LINQSettings GetSettings()
        {
            string filePath = Path.Combine(LINQOptions.ExecutingDirectory, FILE_NAME);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(string.Format("Could not find {0}.", filePath));
            }
            return (LINQSettings)Serializer.DeserializeFromFile(typeof(LINQSettings), filePath);
        }

        public void Save()
        {
            string filePath = Path.Combine(LINQOptions.ExecutingDirectory, FILE_NAME);
            Serializer.SerializeToFile(this, filePath);
        }

        #endregion //Methods
    }
}