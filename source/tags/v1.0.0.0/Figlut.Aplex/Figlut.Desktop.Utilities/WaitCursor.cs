namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    #endregion //Using Directives

    public class WaitCursor : IDisposable
    {
        #region Constructors

        public WaitCursor()
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        #endregion //Constructors

        #region Methods

        public void Dispose()
        {
            Cursor.Current = Cursors.Default;
        }

        #endregion //Methods
    }
}
