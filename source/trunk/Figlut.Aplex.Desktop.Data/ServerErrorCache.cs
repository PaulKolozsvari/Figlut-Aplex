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

    public class ServerErrorCache : EntityCache<ServerError>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfServerError result = GlobalDataCache.Instance.Service.GetAllServerError(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            foreach (ServerError e in result.Contents.OrderBy(p => p.DateCreated))
            {
                e.ServerErrorCacheId = Guid.NewGuid();
                _entities.Add(e.ServerErrorCacheId, e);
            }
            return false;
        }

        public bool RefreshFromServerByFilters(
            DateTime startDate,
            DateTime endDate)
        {
            ServiceFunctionResultOfListOfServerError result = GlobalDataCache.Instance.Service.GetServerErrorByFilters(
                startDate,
                endDate,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            foreach (ServerError e in result.Contents.OrderBy(p => p.DateCreated))
            {
                e.ServerErrorCacheId = Guid.NewGuid();
                _entities.Add(e.ServerErrorCacheId, e);
            }
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveServerError(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteServerError(
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
