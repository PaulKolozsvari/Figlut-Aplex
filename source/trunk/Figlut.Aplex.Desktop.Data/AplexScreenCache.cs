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

    public class AplexScreenCache : EntityCache<AplexScreen>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfAplexScreen result = GlobalDataCache.Instance.Service.GetAllAplexScreen(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.ToList().ForEach(p => _entities.Add(p.AplexScreenId, p));
            return false;
        }

        public bool RefreshFromServer(Guid aplexId, bool refreshScreenFields)
        {
            ServiceFunctionResultOfListOfAplexScreen result = GlobalDataCache.Instance.Service.GetAplexScreenByField(
                EntityReader<AplexScreen>.GetPropertyName(p => p.AplexId, false),
                aplexId,
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.ToList().ForEach(p => _entities.Add(p.AplexScreenId, p));
            if (refreshScreenFields)
            {
                foreach (AplexScreen s in this)
                {
                    s.AplexScreenFieldCache.RefreshFromServer(s.AplexScreenId);
                }
            }
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveAplexScreen(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteAplexScreen(
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
