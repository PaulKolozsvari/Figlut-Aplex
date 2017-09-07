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
    using Figlut.Aplex.Mobile.UI.Base;
    using Figlut.Aplex.Mobile.DeviceConfig;
    using Figlut.Aplex.Mobile.DeviceConfig.FiglutWebService;
    using System.Reflection;
    using System.IO;

    #endregion //Using Directives

    public partial class LogDeviceConfigActionForm : FiglutBaseForm
    {
        #region Constructors

        public LogDeviceConfigActionForm()
        {
            InitializeComponent();
        }

        #endregion //Constructors

        #region Event Handlers

        private void mnuBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        }

        private void mnuLog_Click(object sender, EventArgs e)
        {
            string originalStatus = statusMain.Text;
            try
            {
                if (string.IsNullOrEmpty(txtFunction.Text))
                {
                    txtFunction.Focus();
                    UIHelper.DisplayError("Function not entered.");
                    return;
                }
                ServiceFunctionResultOfDeviceConfigAction result = null;
                using (WaitCursor w = new WaitCursor())
                {
                    statusMain.Text = "Logging action to server ...";
                    string deviceId = DeviceConfigManager.GetDeviceId();
                    string applicationName = Path.GetFileName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                    result = DeviceConfigOptions.Instance.Service.LogDeviceConfigAction(
                        txtFunction.Text,
                        deviceId,
                        applicationName,
                        string.IsNullOrEmpty(txtTag.Text) ? null : txtTag.Text);
                }
                if (ServiceResultHandler.HandleServiceResult(result))
                {
                    return;
                }
                UIHelper.DisplayInformation("Device Action logged successfully.");
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

        #endregion //Event Handlers
    }
}