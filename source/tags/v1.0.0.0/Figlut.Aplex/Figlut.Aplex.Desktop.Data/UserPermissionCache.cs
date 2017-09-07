namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Desktop.Data;
    using Figlut.Aplex.Desktop.Data.WebService;

    #endregion //Using Directives

    public class UserPermissionCache : EntityCache<UserPermission>
    {
        #region Indexers

        public UserPermission this[string permissionName]
        {
            get
            {
                List<UserPermission> query = _entities.Values.Where(p => p.PermissionName == permissionName).ToList();
                return query.Count < 1 ? null : query[0];
            }
        }

        #endregion //Indexers

        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfUserPermission result = GlobalDataCache.Instance.Service.GetAllUserPermission(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.OrderBy(p => p.PermissionName).ToList().ForEach(p => _entities.Add(p.UserPermissionId, p));
            return false;
        }

        public bool RefreshFromServerForUser(User targetUser)
        {
            ServiceFunctionResultOfListOfUserPermission result = GlobalDataCache.Instance.Service.GetUserPermissionsForUser(
                targetUser, 
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.OrderBy(p => p.PermissionName).ToList().ForEach(p => _entities.Add(p.UserPermissionId, p));
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveUserPermission(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteUserPermission(
                _deletedEntities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser)))
            {
                return true;
            }
            _deletedEntities.Clear();
            return false;
        }

        #endregion //Methods
    }
}
