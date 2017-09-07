namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Desktop.Data;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;

    #endregion //Using Directives

    public class UserCache : EntityCache<User>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfUser result = GlobalDataCache.Instance.Service.GetAllUser(false, GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.OrderBy(p => p.UserName).ToList().ForEach(p => _entities.Add(p.UserId, p));
            return false;
        }

        public bool RefreshFromServerWithPermissions()
        {
            if (RefreshFromServer())
            {
                return true;
            }
            foreach (User u in _entities.Values)
            {
                if (u.UserPermissionCache.RefreshFromServerForUser(u))
                {
                    return true;
                }
            }
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveUser(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteUser(
                _deletedEntities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser)))
            {
                return true;
            }
            _deletedEntities.Clear();
            return false;
        }

        public bool SaveToServerWithPermissions()
        {
            List<UserPermission> permissionsToSave = new List<UserPermission>();
            List<UserPermission> permissionsToDelete = new List<UserPermission>();
            foreach (User u in _entities.Values)
            {
                u.UserPermissionCache.ToList().ForEach(p => permissionsToSave.Add(p));
                u.UserPermissionCache.DeletedEntities.ForEach(p => permissionsToDelete.Add(p));
            }
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveUserWithPermissions(
                _entities.Values.ToArray(),
                _deletedEntities.Values.ToArray(),
                permissionsToSave.ToArray(),
                permissionsToDelete.ToArray(),
                GlobalDataCache.Instance.CurrentUser)))
            {
                return true;
            }
            foreach (User u in _entities.Values)
            {
                u.UserPermissionCache.ClearAddedEntities();
                u.UserPermissionCache.ClearDeletedEntities();
            }
            _addedEntities.Clear();
            _deletedEntities.Clear();
            return false;
        }

        #endregion //Methods
    }
}
