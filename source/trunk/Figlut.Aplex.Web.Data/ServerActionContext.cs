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

    public class ServerActionContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<List<ServerAction>> GetServerActionByFilters(
            DateTime startDate,
            DateTime endDate,
            User user)
        {
            try
            {
                ValidateUser(user);
                List<ServerAction> result = null;
                using (TransactionScope t = new TransactionScope())
                {
                    result = (from a in DB.GetTable<ServerAction>()
                              where a.DateCreated > startDate &&
                                    a.DateCreated < endDate
                              select a).ToList();
                    t.Complete();
                }
                return new ServiceFunctionResult<List<ServerAction>>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<ServerAction>>(HandleException(ex, user));
            }
        }

        #endregion //Methods
    }
}