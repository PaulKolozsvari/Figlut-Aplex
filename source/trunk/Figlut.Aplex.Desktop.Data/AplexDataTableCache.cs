namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.Data;
    using Figlut.Desktop.Utilities;

    #endregion //Using Directives

    public class AplexDataTableCache : EntityCache<AplexDataTable>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfAplexDataTable result = GlobalDataCache.Instance.Service.GetAllAplexDataTable(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.ToList().ForEach(p => _entities.Add(p.AplexDataTableId, p));
            return false;
        }

        public bool RefreshFromServer(Guid aplexDatabaseId, bool refreshColumns)
        {
            ServiceFunctionResultOfListOfAplexDataTable result = GlobalDataCache.Instance.Service.GetAplexDataTableByField(
                EntityReader<AplexDataTable>.GetPropertyName(p => p.AplexDatabaseId, false),
                aplexDatabaseId,
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.ToList().ForEach(p => _entities.Add(p.AplexDataTableId, p));
            if (refreshColumns)
            {
                foreach (AplexDataTable t in this)
                {
                    t.AplexDataColumnCache.RefreshFromServer(t.AplexDataTableId);
                }
            }
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveAplexDataTable(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteAplexDataTable(
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