namespace Figlut.Aplex.Web.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Web.Utilities;
    using System.Transactions;

    #endregion //Using Directives

    public class EmailActionContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<List<EmailAction>> GetEmailActionByFilters(
            DateTime startDate,
            DateTime endDate,
            User user)
        {
            try
            {
                ValidateUser(user);
                List<EmailAction> result = null;
                using (TransactionScope t = new TransactionScope())
                {
                    var query = (from e in DB.GetTable<EmailAction>()
                                 join u in DB.GetTable<User>() on e.UserId equals u.UserId
                                 where e.DateCreated > startDate &&
                                       e.DateCreated < endDate
                                 select new
                                 {
                                     e.EmailActionId,
                                     e.ToEmailAddress,
                                     e.FromEmailAddress,
                                     e.Subject,
                                     e.Body,
                                     e.UserId,
                                     u.UserName,
                                     e.DateCreated
                                 });
                    result = new List<EmailAction>();
                    query.ToList().ForEach(p => result.Add(new EmailAction()
                    {
                        EmailActionId = p.EmailActionId,
                        ToEmailAddress = p.ToEmailAddress,
                        FromEmailAddress = p.FromEmailAddress,
                        Subject = p.Subject,
                        Body = p.Body,
                        UserId = p.UserId,
                        UserName = p.UserName,
                        DateCreated = p.DateCreated
                    }));
                    t.Complete();
                }
                return new ServiceFunctionResult<List<EmailAction>>() { Contents = result };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<EmailAction>>(HandleException(ex, user));
            }
        }

        #endregion //Methods
    }
}