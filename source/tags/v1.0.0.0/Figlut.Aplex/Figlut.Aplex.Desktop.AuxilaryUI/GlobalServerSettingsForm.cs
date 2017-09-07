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
    using Figlut.Desktop.Data;
    using Figlut.Aplex.Desktop.Data;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.Utilities;

    #endregion //Using Directives

    public partial class GlobalServerSettingsForm : BorderlessForm
    {
        #region Constructors

        public GlobalServerSettingsForm(EntityOperation operation)
        {
            InitializeComponent();
            _operation = operation;
        }

        #endregion //Constructors

        #region Fields

        private EntityOperation _operation;

        #endregion //Fields

        #region Methods

        public void RefreshControls()
        {
            txtCompanyName.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyName];
            txtCompanyVatRegistrationNumber.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyVatRegistrationNumber];
            txtCompanyAddressLine1.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine1];
            txtCompanyAddressLine2.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine2];
            txtCompanyAddressLine3.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine3];
            txtCompanyAddressLine4.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine4];
            txtCompanyAddressLine5.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine5];
            txtCompanyAddressLine6.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine6];
            txtMonetarySymbol.Text = GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.MonetarySymbol];
            nudMaximumTrialDays.Value = Convert.ToInt32(GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.MaximumTrialDays]);
            chkLogActionGetDeviceConfig.Checked = bool.Parse(GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.LogActionGetDeviceConfig]);
            chkEmailDevicePendingApproval.Checked = bool.Parse(GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.EmailDevicePendingApproval]);
        }

        public void SetControlsEnabled(bool enabled)
        {
            txtCompanyName.Enabled = enabled;
            txtCompanyVatRegistrationNumber.Enabled = enabled;
            txtCompanyAddressLine1.Enabled = enabled;
            txtCompanyAddressLine2.Enabled = enabled;
            txtCompanyAddressLine3.Enabled = enabled;
            txtCompanyAddressLine4.Enabled = enabled;
            txtCompanyAddressLine5.Enabled = enabled;
            txtCompanyAddressLine6.Enabled = enabled;
            txtMonetarySymbol.Enabled = enabled;
            nudMaximumTrialDays.Enabled = enabled;
            gpbOptions.Enabled = enabled;
        }

        #endregion //Methods

        #region Event Handlers

        private void GlobalServerSettingsForm_Load(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case EntityOperation.Update:
                    FormTitle = "Update Global Server Settings";
                    Status = "Enter global server settings.";
                    mnuUpdateAdd.Text = "Update";
                    mnuUpdateAdd.ShortcutKeys = Keys.Control | Keys.U;
                    RefreshControls();
                    break;
                case EntityOperation.ReadOnly:
                    FormTitle = "Current Global Server Settings";
                    Status = "(Read only)";
                    mnuMain.Items.Remove(mnuUpdateAdd);
                    RefreshControls();
                    SetControlsEnabled(false);
                    break;
                default:
                    throw new ArgumentException("Invalid entity operation provided on Global Server Settings form.");
            }
        }

        private void GlobalServerSettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void GlobalServerSettingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void GlobalServerSettingsForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void mnuUpdateAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                txtCompanyName.Focus();
                throw new UserThrownException("Company Name may not be left empty.", false, true, false);
            }
            long tempVatRegNumber = 0;
            if(!long.TryParse(txtCompanyVatRegistrationNumber.Text, out tempVatRegNumber))
            {
                txtCompanyVatRegistrationNumber.Focus();
                throw new UserThrownException("Invalid Company Registration Number. Expected numeric value.", false, true, false);
            }
            if (string.IsNullOrEmpty(txtMonetarySymbol.Text))
            {
                txtMonetarySymbol.Focus();
                throw new UserThrownException("Monetary value may not be null or empty.", false, true, false);
            }
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyName] = txtCompanyName.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyVatRegistrationNumber] = txtCompanyVatRegistrationNumber.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine1] = txtCompanyAddressLine1.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine2] = txtCompanyAddressLine2.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine3] = txtCompanyAddressLine3.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine4] = txtCompanyAddressLine4.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine5] = txtCompanyAddressLine5.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.CompanyAddressLine6] = txtCompanyAddressLine6.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.MonetarySymbol] = txtMonetarySymbol.Text;
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.MaximumTrialDays] = Convert.ToInt32(nudMaximumTrialDays.Value).ToString();
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.LogActionGetDeviceConfig] = chkLogActionGetDeviceConfig.Checked.ToString();
            GlobalDataCache.Instance.GlobalServerVariables[GlobalVariableName.EmailDevicePendingApproval] = chkEmailDevicePendingApproval.Checked.ToString();
            Status = "Saving global server settings to server ...";
            if (GlobalDataCache.Instance.GlobalServerVariables.SaveToServer())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void GlobalServerSettingsForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuCancel_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.Enter) & e.Control)
            {
                mnuUpdateAdd_Click(sender, e);
            }
        }

        #endregion //Event Handlers
    }
}