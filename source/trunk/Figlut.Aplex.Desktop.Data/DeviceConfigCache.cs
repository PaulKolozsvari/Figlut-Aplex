namespace Figlut.Aplex.Desktop.Data
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Figlut.Desktop.Data;
    using System.Data;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;

    #endregion //Using Directives

    public class DeviceConfigCache : EntityCache<DeviceConfig>
    {
        #region Methods

        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfDeviceConfig result = GlobalDataCache.Instance.Service.GetAllDeviceConfig(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.OrderBy(p => p.DeviceId).ToList().ForEach(p => _entities.Add(p.DeviceConfigId, p));
            return false;
        }

        public bool RefreshFromServerWithCustomerInfo()
        {
            ServiceFunctionResultOfListOfDeviceConfig result = GlobalDataCache.Instance.Service.GetAllDeviceConfigWithCustomerInfo(
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.OrderBy(p => p.CustomerCompanyName).ToList().ForEach(p => _entities.Add(p.DeviceConfigId, p));
            return false;
        }

        public DataTable GetDataTable(
            Dictionary<string, object> properties,
            bool exactMatch,
            bool shapeColumnNames,
            bool expired,
            DeviceConfigCache filteredDeviceConfigCache)
        {
            DataTable result = EntityReader<DeviceConfig>.GetDataTable(shapeColumnNames);
            List<DeviceConfig> deviceConfigItems = GetEntitiesByProperties(properties, exactMatch);
            filteredDeviceConfigCache.Clear();
            foreach (DeviceConfig d in deviceConfigItems)
            {
                if ((d.LicenseExpiryDate < DateTime.Now && expired) ||
                    (d.LicenseExpiryDate > DateTime.Now && !expired))
                {
                    DataRow row = EntityReader<DeviceConfig>.PopulateDataRow(d, result.NewRow(), shapeColumnNames);
                    result.Rows.Add(row);
                    filteredDeviceConfigCache.Add(d);
                }
            }
            return result;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveDeviceConfig(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteDeviceConfig(
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