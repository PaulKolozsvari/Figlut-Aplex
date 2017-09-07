namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.Data;

    #endregion //Using Directives

    public class AplexCache : EntityCache<Aplex>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfAplex result = GlobalDataCache.Instance.Service.GetAllAplex(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.ToList().ForEach(p => _entities.Add(p.AplexId, p));
            return false;
        }

        public bool RefreshFromServer(bool refreshScreens, bool refeshScreenFields)
        {
            if (RefreshFromServer())
            {
                return true;
            }
            if (refreshScreens)
            {
                foreach (Aplex a in this)
                {
                    a.AplexScreenCache.RefreshFromServer(a.AplexId, refeshScreenFields);
                }
            }
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveAplex(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteAplex(
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
