namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.Utilities;
    using Figlut.Desktop.Data;

    #endregion //Using Directives

    public class AplexDatabaseCache : EntityCache<AplexDatabase>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfAplexDatabase result = GlobalDataCache.Instance.Service.GetAllAplexDatabase(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.ToList().ForEach(p => _entities.Add(p.AplexDatabaseId, p));
            return false;
        }

        public bool RefreshFromServer(bool refreshTables, bool refreshColumns)
        {
            if (RefreshFromServer())
            {
                return true;
            }
            if (refreshTables)
            {
                foreach (AplexDatabase d in this)
                {
                    d.AplexDataTableCache.RefreshFromServer(d.AplexDatabaseId, refreshColumns);
                }
            }
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveAplexDatabase(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteAplexDatabase(
                _entities.Values.ToArray(),
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
