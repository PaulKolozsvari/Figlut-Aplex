namespace Figlut.Aplex
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    static class Program
    {
        #region Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        #endregion //Methods

        #region Event Handlers

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ExceptionHandler.HandleException(
                e.Exception,
                GlobalDataCache.Instance.Settings.Support,
                GlobalDataCache.Instance.Settings.LogFileName);
        }

        #endregion //Event Handlers
    }
}
