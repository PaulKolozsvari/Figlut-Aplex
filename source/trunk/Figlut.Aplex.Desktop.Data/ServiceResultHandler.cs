namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;

    #endregion //Using Directives

    public class ServiceResultHandler
    {
        /// <summary>
        /// Checks the code of the service result and displays an appropriate error
        /// message or throws an exception for fatal errors.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>Returns true if the process should abort i.e. the caller of this method should return to its caller.</returns>
        public static bool HandleServiceResult(ServiceResult result)
        {
            bool abort = false;
            switch (result.Code)
            {
                case ServiceResultCode.Success:
                    break;
                case ServiceResultCode.Information:
                    UIHelper.DisplayInformation(result.Message);
                    break;
                case ServiceResultCode.Warning:
                    UIHelper.DisplayWarning(result.Message);
                    break;
                case ServiceResultCode.OperationError:
                    UIHelper.DisplayError(result.Message);
                    abort = true;
                    break;
                case ServiceResultCode.FatalError:
                    throw new Exception(result.Message);
                default:
                    throw new Exception("Invalid service result.");
            }
            return abort;
        }
    }
}