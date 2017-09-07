namespace Figlut.Aplex.Desktop.Data.WebService
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public partial class Aplex
    {
        #region Constructors

        public Aplex()
        {
            _aplexScreenCache = new AplexScreenCache();
        }

        #endregion //Constructors

        #region Fields

        private AplexScreenCache _aplexScreenCache;

        #endregion //Fields

        #region Properties

        public AplexScreenCache AplexScreenCache
        {
            get { return _aplexScreenCache; }
        }

        #endregion //Properties
    }
}