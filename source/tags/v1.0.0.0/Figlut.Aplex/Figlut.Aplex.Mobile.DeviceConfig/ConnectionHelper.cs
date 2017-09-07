namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using OpenNETCF.Net;
    using System.Threading;

    #endregion //Using Directives

    public class ConnectionHelper
    {
        #region Methods

        public static void EnsureCellularConnection()
        {
            ConnectionManager connectionManager = new ConnectionManager();
            ConnectionDetailCollection connections = connectionManager.GetConnectionDetailItems();
            ConnectionDetail connection = null;
            foreach (ConnectionDetail c in connections)
            {
                if (c.ConnectionType == ConnectionType.Cellular)
                {
                    connection = c;
                    break;
                }
            }
            if (connection == null)
            {
                UIHelper.DisplayWarning("No cellular network configured");
                return;
            }
            if (connection.ConnectionStatus != ConnectionStatus.Connected)
            {
                try
                {
                    connectionManager.Connect(connection.DestinatonNetwork, true, ConnectionMode.Synchronous);
                    Thread.Sleep(3000);
                }
                catch (Exception ex)
                {
                    UIHelper.DisplayWarning(ex.Message);
                }
            }
        }

        #endregion //Methods
    }
}