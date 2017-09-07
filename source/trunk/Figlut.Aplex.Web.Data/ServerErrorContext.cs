namespace Figlut.Aplex.Web.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Web.Utilities;
    using System.Transactions;
    using Figlut.Aplex.Web.Data;

    #endregion //Using Directives

    public class ServerErrorContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<List<ServerError>> GetServerErrorByFilters(
            DateTime startDate,
            DateTime endDate,
            User user)
        {
            try
            {
                ValidateUser(user);
                List<ServerError> result = null;
                using (TransactionScope t = new TransactionScope())
                {
                    result = (from e in DB.GetTable<ServerError>()
                              where e.DateCreated > startDate &&
                                    e.DateCreated < endDate
                              select e).ToList();
                    t.Complete();
                }
                return new ServiceFunctionResult<List<ServerError>>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<ServerError>>(HandleException(ex, user));
            }
        }

        #endregion //Methods
    }
}