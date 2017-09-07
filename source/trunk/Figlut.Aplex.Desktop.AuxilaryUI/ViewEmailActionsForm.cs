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
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;

    #endregion //Using Directives

    public partial class ViewEmailActionsForm : BorderlessForm
    {
        #region Event Handlers

        public ViewEmailActionsForm(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            _emailActionCache = new EmailActionCache();
            InitHiddenColumns();
            _startDate = startDate;
            _endDate = endDate;
        } 

        #endregion //Event Handlers

        #region Fields

        private EmailActionCache _emailActionCache;
        private bool _unsavedChanges;
        private List<string> _hiddenColumns;
        private DateTime _startDate;
        private DateTime _endDate;

        #endregion //Fields

        #region Methods

        private void InitHiddenColumns()
        {
            _hiddenColumns = new List<string>();
            _hiddenColumns.Add(EntityReader<EmailAction>.GetPropertyName(p => p.EmailActionId, true));
            _hiddenColumns.Add(EntityReader<EmailAction>.GetPropertyName(p => p.UserId, true));
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
                        if (_emailActionCache.RefreshFromServerByFilters(
                            _startDate,
                            _endDate))
                        {
                            return;
                        }
                        _unsavedChanges = false;
                    }
                    int index = UIHelper.GetSelectedGridRowIndex(grdEmailActions);
                    Dictionary<string, object> properties = new Dictionary<string, object>();
                    properties.Add(EntityReader<EmailAction>.GetPropertyName(p => p.ToEmailAddress, false), txtToEmailAddress.Text);
                    grdEmailActions.DataSource = _emailActionCache.GetDataTable(properties, false, true);
                    _hiddenColumns.ForEach(p => grdEmailActions.Columns[p].Visible = false);
                    UIHelper.SelectGridRow(grdEmailActions, index);
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

        private void ViewEmailActionsForm_Load(object sender, EventArgs e)
        {
            Refresh(true);
        }

        private void txtToEmailAddress_TextChanged(object sender, EventArgs e)
        {
            Refresh(false);
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ViewEmailActionsForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void ViewEmailActionsForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void ViewEmailActionsForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void picResizeWindow_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderLessFormResize(sender, e);
        }

        private void ViewEmailActionsForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuCancel_Click(sender, e);
            }
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            base.BorderlessForm_Maximize(sender, e);
        }

        #endregion //Event Handlers
    }
}
