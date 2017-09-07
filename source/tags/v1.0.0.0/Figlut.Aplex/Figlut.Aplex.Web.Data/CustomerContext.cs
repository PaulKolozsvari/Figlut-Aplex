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

    public class CustomerContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<List<Customer>> GetAllCustomerWithStats(User user)
        {
            try
            {
                ValidateUser(user);
                List<Customer> result = null;
                using(TransactionScope t = new TransactionScope())
                {
                    result = (from c in DB.GetTable<Customer>()
                              select c).ToList();
                    foreach (Customer c in result)
                    {
                        c.ActionCount = 0;
                        List<DeviceConfig> deviceConfigQuery = (from d in DB.GetTable<DeviceConfig>()
                                                                where d.CustomerId == c.CustomerId
                                                                select d).ToList();
                        foreach (DeviceConfig d in deviceConfigQuery)
                        {
                            if (d.ActionCount.HasValue)
                            {
                                c.ActionCount += d.ActionCount.Value;
                            }
                        }
                    }
                    t.Complete();
                }
                return new ServiceFunctionResult<List<Customer>>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<Customer>>(HandleException(ex, user));
            }
        }

        #endregion //Methods
    }
}