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

    public class ServerActionCache : EntityCache<ServerAction>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfServerAction result = GlobalDataCache.Instance.Service.GetAllServerAction(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            foreach (ServerAction a in result.Contents.OrderBy(p => p.DateCreated))
            {
                a.ServerActionCacheId = Guid.NewGuid();
                _entities.Add(a.ServerActionCacheId, a);
            }
            return false;
        }

        public bool RefreshFromServerByFilters(DateTime startDate, DateTime endDate)
        {
            ServiceFunctionResultOfListOfServerAction result = GlobalDataCache.Instance.Service.GetServerActionByFilters(
                startDate,
                endDate,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            foreach (ServerAction a in result.Contents.OrderBy(p => p.DateCreated))
            {
                a.ServerActionCacheId = Guid.NewGuid();
                _entities.Add(a.ServerActionCacheId, a);
            }
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveServerAction(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteServerAction(
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