namespace Figlut.Aplex.Desktop.Data.WebService
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public partial class Customer
    {
        #region Methods

        public override string ToString()
        {
            return this.CompanyName;
        }

        #endregion //Methods
    }
}