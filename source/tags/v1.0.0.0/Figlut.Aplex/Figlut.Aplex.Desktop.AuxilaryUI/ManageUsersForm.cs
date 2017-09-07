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
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Desktop.Data;
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    public partial class ManageUsersForm : BorderlessForm
    {
        #region Constructors

        public ManageUsersForm()
        {
            InitializeComponent();
            _userCache = new UserCache();
            InitHiddenColumns();
        }

        #endregion //Constructors

        #region Fields

        private UserCache _userCache;
        private bool _unsavedChanges;
        private List<string> _hiddenColumns;

        #endregion //Fields

        #region Methods

        private void InitHiddenColumns()
        {
            _hiddenColumns = new List<string>();
            _hiddenColumns.Add(EntityReader<User>.GetPropertyName(p => p.UserId, true));
            _hiddenColumns.Add(EntityReader<User>.GetPropertyName(p => p.Password, true));
            _hiddenColumns.Add(EntityReader<User>.GetPropertyName(p => p.RoleId, true));
            _hiddenColumns.Add(EntityReader<User>.GetPropertyName(p => p.UserPermissionCache, true));
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
                        if (_userCache.RefreshFromServerWithPermissions())
                        {
                            return;
                        }
                        _unsavedChanges = false;
                    }
                    int index = UIHelper.GetSelectedGridRowIndex(grdUsers);
                    Dictionary<string, object> properties = new Dictionary<string, object>();
                    properties.Add(EntityReader<User>.GetPropertyName(p => p.UserName, false), txtUserName.Text);
                    grdUsers.DataSource = _userCache.GetDataTable(properties, false, true);
                    _hiddenColumns.ForEach(c => grdUsers.Columns[c].Visible = false);
                    UIHelper.SelectGridRow(grdUsers, index);
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

        private void ManageUsersForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void ManageUsersForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void ManageUsersForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void picResizeWindow_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderLessFormResize(sender, e);
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            Refresh(true);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
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
                    if (_userCache.SaveToServerWithPermissions())
                    {
                        return;
                    }
                    User currentUser = _userCache[GlobalDataCache.Instance.CurrentUser.UserId];
                    GlobalDataCache.Instance.CurrentUser = currentUser;
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

        private void mnuEditAdd_Click(object sender, EventArgs e)
        {
            User u = new User() { UserId = Guid.NewGuid() };
            using (UserForm f = new UserForm(
                u, 
                EntityOperation.Add, 
                new PropertyValueExists(_userCache.PropertyValueExists)))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _userCache.Add(u);
                    Refresh(false);
                    _unsavedChanges = true;
                }
            }
        }

        private void mnuEditUpdate_Click(object sender, EventArgs e)
        {
            Nullable<Guid> selectedId = UIHelper.GetSelectedRowId(
                grdUsers,
                EntityReader<User>.GetPropertyName(p => p.UserId, true),
                true);
            User u = _userCache[selectedId.Value];
            using (UserForm f = new UserForm(
                u, 
                EntityOperation.Update, 
                new PropertyValueExists(_userCache.PropertyValueExists)))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Refresh(false);
                    _unsavedChanges = true;
                }
            }
        }

        private void mnuEditDelete_Click(object sender, EventArgs e)
        {
            Nullable<Guid> selectedId = UIHelper.GetSelectedRowId(
                grdUsers,
                EntityReader<User>.GetPropertyName(p => p.UserId, true),
                true);
            if (_userCache[selectedId.Value].UserId == GlobalDataCache.Instance.CurrentUser.UserId)
            {
                throw new UserThrownException(
                    "May not delete current user. Please logon as different user to delete the selected user.",
                    false,
                    true,
                    false);
            }
            if (UIHelper.AskQuestion(
                "Deleting a user will delete all the data associated with this user. Are you sure you want to delete the selected user?")
                != DialogResult.Yes)
            {
                return;
            }
            _userCache.Delete(selectedId.Value);
            Refresh(false);
            _unsavedChanges = true;
        }

        private void ManageUsersForm_KeyUp(object sender, KeyEventArgs e)
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