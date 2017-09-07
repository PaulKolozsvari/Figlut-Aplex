namespace Figlut.Web.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public enum ServiceResultCode
    {
        Success = 0,
        Information = 1,
        SpecialInstructions = 2,
        Warning = 3,
        OperationError = 4,
        FatalError = 5
    }
}