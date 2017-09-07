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

    public class DevicePendingApprovalCache : EntityCache<DevicePendingApproval>
    {
        public override bool RefreshFromServer()
        {
            ServiceFunctionResultOfListOfDevicePendingApproval result = GlobalDataCache.Instance.Service.GetAllDevicePendingApproval(
                false,
                GlobalDataCache.Instance.CurrentUser);
            if (ServiceResultHandler.HandleServiceResult(result))
            {
                return true;
            }
            Clear();
            result.Contents.OrderBy(p => p.LatestAttemptDate).ToList().ForEach(p => _entities.Add(p.DevicePendingApprovalId, p));
            return false;
        }

        public override bool SaveToServer()
        {
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.SaveDevicePendingApproval(
                _entities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser,
                false)))
            {
                return true;
            }
            _addedEntities.Clear();
            if (ServiceResultHandler.HandleServiceResult(GlobalDataCache.Instance.Service.DeleteDevicePendingApproval(
                _deletedEntities.Values.ToArray(),
                GlobalDataCache.Instance.CurrentUser)))
            {
                return true;
            }
            _deletedEntities.Clear();
            return false;
        }
    }
}
