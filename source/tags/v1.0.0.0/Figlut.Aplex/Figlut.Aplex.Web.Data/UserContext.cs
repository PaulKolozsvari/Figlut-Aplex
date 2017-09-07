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

    public class UserContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<User> Login(string userName, string password, UserRoleId roleId)
        {
            try
            {
                List<User> query = (from u in DB.GetTable<User>()
                                    where u.UserName == userName && u.Password == password
                                    select u).ToList();
                if (query.Count < 1)
                {
                    throw new ServiceException(string.Format(
                        "Invalid username/password for user {0}.",
                        userName),
                        ServiceResultCode.OperationError);
                }
                User user = query[0];
                UserRoleId userRoleId = (UserRoleId)user.RoleId;
                if ((userRoleId & roleId) == UserRoleId.None)
                {
                    throw new ServiceException(string.Format(
                        "User {0} has insufficient rights to login. Contact administrator.",
                        userName),
                        ServiceResultCode.OperationError);
                }
                return new ServiceFunctionResult<User>() { Contents = query[0] };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<User>(HandleException(ex));
            }
        }

        public ServiceProcedureResult SaveUserWithPermissions(
            List<User> usersToSave,
            List<User> usersToDelete,
            List<UserPermission> permissionsToSave,
            List<UserPermission> permissionsToDelete,
            User user)
        {
            try
            {
                ValidateUser(user);
                permissionsToDelete.ForEach(p => base.Delete<UserPermission>(p).ForEach(c => HandleChange(c, user)));
                usersToSave.ForEach(u => base.Save(u, false, true).ForEach(c => HandleChange(c, user)));
                permissionsToSave.ForEach(p => base.Save<UserPermission>(p, false).ForEach(c => HandleChange(c, user)));
                usersToDelete.ForEach(u => base.Delete<User>(u).ForEach(c => HandleChange(c, user)));
                return new ServiceProcedureResult();
            }
            catch (Exception ex)
            {
                return new ServiceProcedureResult(HandleException(ex, user));
            }
        }

        #endregion //Methods
    }
}