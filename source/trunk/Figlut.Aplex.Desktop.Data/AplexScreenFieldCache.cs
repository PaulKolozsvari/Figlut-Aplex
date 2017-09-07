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

    public class AplexScreenFieldCache : EntityCache<AplexScreenField>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfAplexScreenField result = GlobalDataCache.Instance.Service.GetAllAplexScreenField(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.ToList().ForEach(p => _entities.Add(p.AplexScreenFieldId, p));
            return false;
        }

        public bool RefreshFromServer(Guid aplexAcreenId)
        {
            ServiceFunctionResultOfListOfAplexScreenField result = GlobalDataCache.Instance.Service.GetAplexScreenFieldByField(
                EntityReader<AplexScreenField>.GetPropertyName(p => p.AplexScreenId, false),
                aplexAcreenId,
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.ToList().ForEach(p => _entities.Add(p.AplexScreenFieldId, p));
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveAplexScreenField(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteAplexScreenField(
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
