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

    #endregion //Using Directives

    public partial class DeviceSettingsForm : FiglutBaseForm
    {
        #region Constructors

        public DeviceSettingsForm()
        {
            InitializeComponent();
        }

        #endregion //Constructors

        #region Event Handlers

        private void DeviceSettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtApplicationWebServiceUrl.Text = DeviceConfigOptions.Instance.Settings.ApplicationWebServiceUrl;
                txtApplicationReplicationWebServiceUrl.Text = DeviceConfigOptions.Instance.Settings.ApplicationReplicationWebServiceUrl;
                txtFiglutWebServiceUrl.Text = DeviceConfigOptions.Instance.Settings.FiglutWebServiceUrl;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        }

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

        private void mnuSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFiglutWebServiceUrl.Text))
                {
                    UIHelper.DisplayError("Figlut Web Service URL may not be left empty.");
                }
                DeviceConfigOptions.Instance.Settings.ApplicationWebServiceUrl = 
                    string.IsNullOrEmpty(txtApplicationWebServiceUrl.Text) ? 
                    null : 
                    txtApplicationWebServiceUrl.Text;
                DeviceConfigOptions.Instance.Settings.ApplicationReplicationWebServiceUrl =
                    string.IsNullOrEmpty(txtApplicationReplicationWebServiceUrl.Text) ?
                    null :
                    txtApplicationReplicationWebServiceUrl.Text;
                DeviceConfigOptions.Instance.Settings.FiglutWebServiceUrl = txtFiglutWebServiceUrl.Text;
                DeviceConfigOptions.Instance.Settings.Save();
                DeviceConfigOptions.Instance.RecreateServices();

                UIHelper.DisplayInformation("Settings saved.");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        } 

        #endregion //Event Handlers
    }
}