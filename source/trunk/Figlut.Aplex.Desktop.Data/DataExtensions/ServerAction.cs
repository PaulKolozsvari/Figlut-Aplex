namespace Figlut.Aplex.Desktop.Data.WebService
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public partial class ServerAction
    {
        #region Properties

        /// <summary>
        /// Used only to store the entity in an EntityCache
        /// </summary>
        public Guid ServerActionCacheId { get; set; }

        #endregion //Properties
    }
}