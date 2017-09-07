namespace Figlut.Aplex.Desktop.Data.WebService
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public partial class AplexDataTable
    {
        #region Constructors

        public AplexDataTable()
        {
            _aplexDataColumnCache = new AplexDataColumnCache();
        }

        #endregion //Constructors

        #region Fields

        private AplexDataColumnCache _aplexDataColumnCache;

        #endregion //Fields

        #region Properties

        public AplexDataColumnCache AplexDataColumnCache
        {
            get { return _aplexDataColumnCache; }
        }

        #endregion //Properties
    }
}