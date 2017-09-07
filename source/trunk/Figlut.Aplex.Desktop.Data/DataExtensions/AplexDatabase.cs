namespace Figlut.Aplex.Desktop.Data.WebService
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public partial class AplexDatabase
    {
        #region Constructors

        public AplexDatabase()
        {
            _aplexDataTableCache = new AplexDataTableCache();
        }

        #endregion //Constructors

        #region Fields

        private AplexDataTableCache _aplexDataTableCache;

        #endregion //Fields

        #region Properties

        public AplexDataTableCache AplexDataTableCache
        {
            get { return _aplexDataTableCache; }
        }

        #endregion //Properties
    }
}