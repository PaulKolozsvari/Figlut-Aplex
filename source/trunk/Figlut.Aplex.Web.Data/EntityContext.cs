namespace Figlut.Aplex.Web.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Transactions;
    using Figlut.Web.Utilities;
    using Figlut.LINQ.Utilities;
    using Figlut.Aplex.Web.Data;

    #endregion //Using Directives

    public class EntityContext : LINQContext
    {
        #region Constructors

        public EntityContext() : base(new DataModelDataContext(), true)
        {
        }

        #endregion //Constructors

        #region Methods

        public static void ValidateUser(User user)
        {
            UserContext ctx = new UserContext();
            List<User> query = (from u in ctx.DB.GetTable<User>()
                                where u.UserName == user.UserName && u.Password == user.Password
                                select u).ToList();
            if (query.Count < 1)
            {
                throw new ServiceException(string.Format(
                    "User {0} invalid.", user.UserName), 
                    ServiceResultCode.OperationError);
            }
        }

        public User GetSystemUser()
        {
            List<User> query = (from u in DB.GetTable<User>()
                                where u.UserName == Options.Instance.Settings.DeviceConfigSystemUserName
                                select u).ToList();
            if (query.Count > 1)
            {
                throw new ServiceException(
                    string.Format(
                    "More than one System User with user name {0} found.", 
                    Options.Instance.Settings.DeviceConfigSystemUserName),
                    ServiceResultCode.FatalError);
            }
            User result = query.Count < 1 ? null : query[0];
            if (result == null)
            {
                throw new ServiceException(
                    string.Format(
                    "System User {0} could not be found.",
                    Options.Instance.Settings.DeviceConfigSystemUserName),
                    ServiceResultCode.FatalError);
            }
            return result;
        }

        public List<User> GetUsersOptedIn()
        {
            return (from u in DB.GetTable<User>()
                    where u.EmailNotifications && u.Email != null && u.Email != string.Empty
                    select u).ToList();
        }

        public GlobalVariable GetGlobalVariable(GlobalVariableName globalVariableName)
        {
            List<GlobalVariable> globalVariableQuery = (from g in DB.GetTable<GlobalVariable>()
                                                        where g.VariableName == globalVariableName.ToString()
                                                        select g).ToList();
            if (globalVariableQuery.Count > 1)
            {
                throw new ServiceException(
                    string.Format(
                    "More than one Global Variable with the name {0} found. Contact administrator.",
                    globalVariableName.ToString()),
                    ServiceResultCode.FatalError);
            }
            GlobalVariable result = globalVariableQuery.Count < 1 ? null : globalVariableQuery[0];
            if (result == null)
            {
                throw new ServiceException(
                    string.Format(
                    "Could not find Global Variable {0}. Contact administrator.",
                    globalVariableName.ToString()),
                    ServiceResultCode.FatalError);
            }
            return result;
        }

        public ServiceProcedureResult Save<E>(List<E> entities, User user, bool saveChildren) where E : class
        {
            try
            {
                ValidateUser(user);
                using (TransactionScope t = new TransactionScope())
                {
                    foreach (E e in entities)
                    {
                        base.Save<E>(e, saveChildren).ForEach(c => HandleChange(c, user));
                    }
                    t.Complete();
                }
                return new ServiceProcedureResult();
            }
            catch (Exception ex)
            {
                return new ServiceProcedureResult(HandleException(ex, user));
            }
        }

        public ServiceProcedureResult Delete<E>(List<E> entities, User user) where E : class
        {
            try
            {
                ValidateUser(user);
                using (TransactionScope t = new TransactionScope())
                {
                    foreach (E e in entities)
                    {
                        base.Delete<E>(e).ForEach(c => HandleChange(c, user));
                    }
                    t.Complete();
                }
                return new ServiceProcedureResult();
            }
            catch (Exception ex)
            {
                return new ServiceProcedureResult(HandleException(ex, user));
            }
        }

        public ServiceProcedureResult DeleteAll<E>(User user) where E : class
        {
            try
            {
                ValidateUser(user);
                using (TransactionScope t = new TransactionScope())
                {
                    base.DeleteAll<E>().ForEach(c => HandleChange(c, user));
                    t.Complete();
                }
                return new ServiceProcedureResult();
            }
            catch (Exception ex)
            {
                return new ServiceProcedureResult(HandleException(ex, user));
            }
        }

        public new ServiceFunctionResult<E> GetEntityBySurrogateKey<E>(object keyValue, bool loadChildren, User user) where E : class
        {
            try
            {
                ValidateUser(user);
                return new ServiceFunctionResult<E>() { Contents = base.GetEntityBySurrogateKey<E>(keyValue, loadChildren) };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<E>(HandleException(ex));
            }
        }

        public new ServiceFunctionResult<List<E>> GetEntitiesByField<E>(string fieldName, object fieldValue, bool loadChildren, User user) where E : class
        {
            try
            {
                ValidateUser(user);
                return new ServiceFunctionResult<List<E>>(){Contents = base.GetEntitiesByField<E>(fieldName, fieldValue, loadChildren)};
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<E>>(HandleException(ex));
            }
        }

        public new ServiceFunctionResult<List<E>> GetAllEntities<E>(bool loadChildren, User user) where E : class
        {
            try
            {
                ValidateUser(user);
                return new ServiceFunctionResult<List<E>>() { Contents = base.GetAllEntities<E>(loadChildren) };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<E>>(HandleException(ex));
            }
        }

        public new ServiceFunctionResult<int> GetTotalCount<E>(User user) where E : class
        {
            try
            {
                ValidateUser(user);
                return new ServiceFunctionResult<int>() { Contents = base.GetTotalCount<E>() };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<int>(HandleException(ex));
            }
        }

        protected void HandleChange(ChangeResult change, User user)
        {
            ServerAction serverAction = new ServerAction()
            {
                Function = change.Function,
                UserId = user.UserId,
                UserName = user.UserName,
                DateCreated = change.DateChanged,
                EntityChanged = change.EntityChanged,
                FieldChanged = change.FieldChanged
            };
            if (change.OriginalValue != null)
            {
                serverAction.OriginalValue = change.OriginalValue.ToString();
            }
            if (change.NewValue != null)
            {
                serverAction.NewValue = change.NewValue.ToString();
            }
            base.Save<ServerAction>(serverAction, false);
        }

        protected ServiceResult HandleException(Exception ex)
        {
            return HandleException(ex, null);
        }

        protected ServiceResult HandleException(Exception ex, User user)
        {
            ServerError error = new ServerError()
            {
                ErrorMessage = ex.Message,
                DateCreated = DateTime.Now,
            };
            if (user != null)
            {
                error.UserId = user.UserId;
                error.UserName = user.UserName;
            }
            //HACK The saving of errors needs to be refactored. The reason for the below code is because we need to
            //create a new context, as the DB one has thrown an exception, therefore we are not able to use it any longer to save.
            //That's why the error is being saved in the first place i.e. because an exception has been thrown.
            using (System.Data.Linq.DataContext ctx = new System.Data.Linq.DataContext(LINQOptions.Instance.Settings.ConnectionString))
            {
                ctx.GetTable<ServerError>().InsertOnSubmit(error);
                ctx.SubmitChanges();
            }
            ServiceException serviceException = ex as ServiceException;
            if (serviceException == null)
            {
                return new ServiceResult { Code = ServiceResultCode.FatalError, Message = ex.Message }; //Not a user thrown exception.
            }
            else
            {
                return serviceException.Result;
            }
        }

        #endregion //Methods
    }
}