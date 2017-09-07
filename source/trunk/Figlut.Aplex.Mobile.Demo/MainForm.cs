namespace Figlut.Aplex.Mobile.Demo
{
    #region Using Directives

    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Figlut.Aplex.Mobile.DeviceConfig;
    using Figlut.Aplex.Mobile.UI.Base;
    using System.IO;
    using System.Reflection;

    #endregion //Using Directives

    public partial class MainForm : FiglutBaseForm
    {
        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion //Constructors

        #region Event Handlers

        private void mnuDeviceInfo_Click(object sender, EventArgs e)
        {
            try
            {
                txtInfo.Text = string.Empty;
                txtInfo.Text = string.Format("Device ID: {0}", DeviceConfigManager.GetDeviceId());
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        }

        private void mnuConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                using (DeviceSettingsForm f = new DeviceSettingsForm())
                {
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        }

        private void mnuGetDeviceConfig_Click(object sender, EventArgs e)
        {
            string originalStatus = statusMain.Text;
            try
            {
                using (WaitCursor w = new WaitCursor())
                {
                    statusMain.Text = "Getting device configuration ...";
                    Application.DoEvents();
                    string applicationName = Path.GetFileName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                    DeviceConfigManager.GetDeviceConfig(applicationName);
                    UIHelper.DisplayInformation("Configuration downloaded successfully!");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
            finally
            {
                statusMain.Text = originalStatus;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        }

        private void mnuLogDeviceAction_Click(object sender, EventArgs e)
        {
            try
            {
                using (LogDeviceConfigActionForm f = new LogDeviceConfigActionForm())
                {
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        }

        #endregion //Event Handlers
    }
}