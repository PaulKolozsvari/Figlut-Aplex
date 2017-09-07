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

    public class DeviceConfigActionCache : EntityCache<DeviceConfigAction>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfDeviceConfigAction result = GlobalDataCache.Instance.Service.GetAllDeviceConfigAction(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.OrderBy(p => p.DateCreated).ToList().ForEach(p => _entities.Add(p.DeviceConfigActionId, p));
            return false;
        }

        public bool RefreshFromServerByFilters(
            string deviceId,
            string applicationName,
            DateTime startDate,
            DateTime endDate)
        {
            ServiceFunctionResultOfListOfDeviceConfigAction result = GlobalDataCache.Instance.Service.GetDeviceConfigActionByFilters(
                deviceId,
                applicationName,
                startDate,
                endDate,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.OrderBy(p => p.DateCreated).ToList().ForEach(p => _entities.Add(p.DeviceConfigActionId, p));
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveDeviceConfigAction(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteDeviceConfigAction(
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
