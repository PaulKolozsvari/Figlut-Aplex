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

    public class EmailActionCache : EntityCache<EmailAction>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfEmailAction result = GlobalDataCache.Instance.Service.GetAllEmailAction(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            foreach (EmailAction e in result.Contents.OrderBy(p => p.DateCreated))
            {
                _entities.Add(e.EmailActionId, e);
            }
            return false;
        }

        public bool RefreshFromServerByFilters(
            DateTime startDate,
            DateTime endDate)
        {
            ServiceFunctionResultOfListOfEmailAction result = GlobalDataCache.Instance.Service.GetEmailActionByFilters(
                startDate,
                endDate,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            foreach (EmailAction e in result.Contents.OrderBy(p => p.DateCreated))
            {
                _entities.Add(e.EmailActionId, e);
            }
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveEmailAction(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteEmailAction(
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
