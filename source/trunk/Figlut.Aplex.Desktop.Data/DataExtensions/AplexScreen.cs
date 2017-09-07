namespace Figlut.Aplex.Desktop.Data.WebService
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public partial class AplexScreen
    {
        #region Constructors

        public AplexScreen()
        {
            _aplexScreenFieldCache = new AplexScreenFieldCache();
        }

        #endregion //Constructors

        #region Fields

        private AplexScreenFieldCache _aplexScreenFieldCache;

        #endregion //Fields

        #region Properties

        public AplexScreenFieldCache AplexScreenFieldCache
        {
            get { return _aplexScreenFieldCache; }
        }

        #endregion //Properties
    }
}