namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Figlut.Desktop.BaseForms;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    public partial class ApproveDeviceForm : BorderlessForm
    {
        #region Constructors

        public ApproveDeviceForm(DevicePendingApproval devicePendingApproval)
        {
            InitializeComponent();
            _devicePendingApproval = devicePendingApproval;
        }

        #endregion //Constructors

        #region Fields

        private DevicePendingApproval _devicePendingApproval;
        private Customer _selectedCustomer;

        #endregion //Fields

        #region Event Handlers

        private void ApproveDeviceForm_Load(object sender, EventArgs e)
        {
            txtDeviceId.Text = _devicePendingApproval.DeviceId;
            txtApplicationName.Text = _devicePendingApproval.ApplicationName;
            txtFiglutWebServiceURL.Text = GlobalDataCache.Instance.Settings.WebServiceURL;
            nudDaysToActivate.Maximum =
                GlobalDataCache.Instance.CurrentUserRoleId != UserRoleId.Administrator &&
                GlobalDataCache.Instance.CurrentUser.UserPermissionCache[UserPermissionName.ApproveProductionLicense.ToString()] == null ?
                nudDaysToActivate.Maximum = Convert.ToInt32(GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.MaximumTrialDays]) :
                10000000;
        }

        private void mnuApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeviceId.Text))
            {
                txtDeviceId.Focus();
                throw new UserThrownException("Device id may not be left empty.", false, true, false);
            }
            if (string.IsNullOrEmpty(txtApplicationName.Text))
            {
                txtApplicationName.Focus();
                throw new UserThrownException("Application Name may not be left empty.", false, true, false);
            }
            if (_selectedCustomer == null)
            {
                btnSelectCustomer.Focus();
                throw new UserThrownException("Customer not selected.", false, true, false);
            }
            string originalStatus = Status;
            try
            {
                using (WaitCursor w = new WaitCursor())
                {
                    Status = "Approving device ...";
                    ServiceProcedureResult result = GlobalDataCache.Instance.Service.ApproveDevicePendingApproval(
                        txtDeviceId.Text,
                        txtApplicationName.Text,
                        txtApplicationWebServiceURL.Text,
                        txtApplicationReplicationWebServiceURL.Text,
                        txtFiglutWebServiceURL.Text,
                        Convert.ToInt32(nudDaysToActivate.Value),
                        _selectedCustomer,
                        GlobalDataCache.Instance.CurrentUser);
                    if (ServiceResultHandler.HandleServiceResult(result))
                    {
                        return;
                    }
                }
                UIHelper.DisplayInformation(string.Format("Device {0} approved.", txtDeviceId.Text));
                this.DialogResult = DialogResult.OK;
                Close();
            }
            finally
            {
                if (Status != originalStatus)
                {
                    Status = originalStatus;
                }
            }
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            using (SelectCustomerForm f = new SelectCustomerForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _selectedCustomer = f.Customer;
                    txtCustomerCompanyName.Text = _selectedCustomer.CompanyName;
                }
            }
        }

        private void ApproveDeviceForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void ApproveDeviceForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void ApproveDeviceForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void ApproveDeviceForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuCancel_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.Enter) & e.Control)
            {
                mnuApprove_Click(sender, e);
            }
        }

        #endregion //Event Handlers
    }
}