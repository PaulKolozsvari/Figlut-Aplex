namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Reflection;

    #endregion //Using Directives

    public class Information
    {
        #region Methods

        public static string GetExecutingDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);
        }

        #endregion //Methods
    }
}