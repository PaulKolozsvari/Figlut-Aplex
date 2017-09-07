namespace Figlut.Aplex.Web.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Web.Utilities;
    using Figlut.Aplex.Web.Data;

    #endregion //Using Directives

    public class UserPermissionContext : EntityContext
    {
        #region Methods

        public ServiceFunctionResult<List<UserPermission>> GetUserPermissionsForUser(User targetUser, User user)
        {
            try
            {
                ValidateUser(user);
                List<UserPermission> query = (from up in DB.GetTable<UserPermission>()
                                              where up.UserId == targetUser.UserId
                                              select up).ToList();
                return new ServiceFunctionResult<List<UserPermission>>() { Contents = query };
            }
            catch (Exception ex)
            {
                return new ServiceFunctionResult<List<UserPermission>>(HandleException(ex, targetUser));
            }
        }

        #endregion //Methods
    }
}