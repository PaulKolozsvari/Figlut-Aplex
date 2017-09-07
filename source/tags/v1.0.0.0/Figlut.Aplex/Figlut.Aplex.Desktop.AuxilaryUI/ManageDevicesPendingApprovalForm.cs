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
    using Figlut.Aplex.Desktop.Data;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.Utilities;

    #endregion //Using Directives

    public partial class ManageDevicesPendingApprovalForm : BorderlessForm
    {
        #region Constructors

        public ManageDevicesPendingApprovalForm()
        {
            InitializeComponent();
            _devicePendingApprovalCache = new DevicePendingApprovalCache();
            InitHiddenColumns();
        }

        #endregion //Constructors

        #region Fields

        private DevicePendingApprovalCache _devicePendingApprovalCache;
        private bool _unsavedChanges;
        private List<string> _hiddenColumns;

        #endregion //Fields

        #region Methods

        private void InitHiddenColumns()
        {
            _hiddenColumns = new List<string>();
            _hiddenColumns.Add(EntityReader<DevicePendingApproval>.GetPropertyName(p => p.DevicePendingApprovalId, true));
        }

        private void Refresh(bool fromServer)
        {
            string originalStatus = Status;
            try
            {
                if ((_unsavedChanges) && (fromServer) &&
                    (UIHelper.AskQuestion("There are unsaved changes. Are you sure you want to refresh from server. All unsaved changes will be lost.") !=
                    DialogResult.Yes))
                {
                    return;
                }
                using (WaitCursor w = new WaitCursor())
                {
                    if (fromServer)
                    {
                        Status = "Refreshing from server ...";
                        if (_devicePendingApprovalCache.RefreshFromServer())
                        {
                            return;
                        }
                        _unsavedChanges = false;
                    }
                    int index = UIHelper.GetSelectedGridRowIndex(grdDevicesPendingApproval);
                    Dictionary<string, object> properties = new Dictionary<string, object>();
                    properties.Add(EntityReader<DevicePendingApproval>.GetPropertyName(p => p.DeviceId, false), txtDeviceId.Text);
                    grdDevicesPendingApproval.DataSource = _devicePendingApprovalCache.GetDataTable(properties, false, true);
                    _hiddenColumns.ForEach(p => grdDevicesPendingApproval.Columns[p].Visible = false);
                    UIHelper.SelectGridRow(grdDevicesPendingApproval, index);
                }
            }
            finally
            {
                if (Status != originalStatus)
                {
                    Status = originalStatus;
                }
            }
        }

        #endregion //Methods

        #region Event Handlers

        private void ManageDevicesPendingApprovalForm_Load(object sender, EventArgs e)
        {
            Refresh(true);
        }

        private void txtDeviceId_TextChanged(object sender, EventArgs e)
        {
            Refresh(false);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            string originalStatus = Status;
            try
            {
                using (WaitCursor w = new WaitCursor())
                {
                    Status = "Saving to server ...";
                    if (_devicePendingApprovalCache.SaveToServer())
                    {
                        return;
                    }
                }
                UIHelper.DisplayInformation("Saved to server.");
                _unsavedChanges = false;
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
            if ((_unsavedChanges) &&
                (UIHelper.AskQuestion("There are unsaved changes. Are you sure you want to cancel. All unsaved changes will be lost.") !=
                DialogResult.Yes))
            {
                return;
            }
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void mnuEditApprove_Click(object sender, EventArgs e)
        {
            Nullable<Guid> selectedId = UIHelper.GetSelectedRowId(
                grdDevicesPendingApproval,
                EntityReader<DevicePendingApproval>.GetPropertyName(p => p.DevicePendingApprovalId, true),
                true);
            DevicePendingApproval devicePendingApproval = _devicePendingApprovalCache[selectedId.Value];
            using (ApproveDeviceForm f = new ApproveDeviceForm(devicePendingApproval))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Refresh(true);
                }
            }
        }

        private void mnuEditDelete_Click(object sender, EventArgs e)
        {
            Nullable<Guid> selectedId = UIHelper.GetSelectedRowId(
                grdDevicesPendingApproval,
                EntityReader<DevicePendingApproval>.GetPropertyName(p => p.DevicePendingApprovalId, true),
                true);
            _devicePendingApprovalCache.Delete(selectedId.Value);
            Refresh(false);
            _unsavedChanges = true;
        }

        private void ManageDevicesPendingApprovalForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuCancel_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.Enter) & e.Control)
            {
                mnuSave_Click(sender, e);
            }
        }

        #endregion //Event Handlers
    }
}