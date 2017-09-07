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
    using Figlut.Desktop.Data;
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    public partial class UserPermissionsForm : BorderlessForm
    {
        #region Constructors

        public UserPermissionsForm(User user, EntityOperation operation)
        {
            InitializeComponent();
            _user = user;
            _unassignedPermissions = new Dictionary<string, object>();
            _assignedPermissions = new Dictionary<string, object>();
            _operation = operation;
        }

        #endregion //Constructors

        #region Fields

        private User _user;
        private EntityOperation _operation;
        private Dictionary<string, object> _unassignedPermissions;
        private Dictionary<string, object> _assignedPermissions;

        #endregion //Fields

        #region Methods

        private void InitCaches()
        {
            foreach (string p in GlobalDataCache.Instance.AvailableUserPermissionNames.Keys)
            {
                if (_user.UserPermissionCache[p] == null)
                {
                    _unassignedPermissions.Add(p, null);
                }
                else
                {
                    _assignedPermissions.Add(p, null);
                }
            }
        }

        private void RefreshLists(bool initCaches)
        {
            using (WaitCursor w = new WaitCursor())
            {
                if (initCaches)
                {
                    InitCaches();
                }
                string[] unassigned = _unassignedPermissions.Keys.ToArray();
                string[] assigned = _assignedPermissions.Keys.ToArray();
                Array.Sort(unassigned);
                Array.Sort(assigned);

                lstUnassignedPermissions.Items.Clear();
                lstAssignedPermissions.Items.Clear();
                foreach (string s in unassigned)
                {
                    lstUnassignedPermissions.Items.Add(s);
                }
                foreach (string s in assigned)
                {
                    lstAssignedPermissions.Items.Add(s);
                }
            }
        }

        private void SetControlsEnabled(bool enabled)
        {
            lstUnassignedPermissions.Enabled = enabled;
            lstAssignedPermissions.Enabled = enabled;
            btnAssignPermission.Enabled = enabled;
            btnUnassignPermission.Enabled = enabled;
            btnAssignAllPermissions.Enabled = enabled;
            btnUnassignAllPermissions.Enabled = enabled;
        }

        #endregion //Methods

        #region Event Handlers

        private void UserPermissionsForm_Load(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case EntityOperation.Update:
                    FormTitle = "User Permissions";
                    Status = "Assign or unassign permissions to user.";
                    mnuUpdate.Text = "Update";
                    RefreshLists(true);
                    break;
                case EntityOperation.Add:
                    FormTitle = "User Permissions";
                    Status = "Assign or unassign permissions to user.";
                    mnuUpdate.Text = "Add";
                    RefreshLists(true);
                    break;
                case EntityOperation.ReadOnly:
                    FormTitle = "Current User Permissions";
                    Status = "(Read only).";
                    mnuMain.Items.Remove(mnuUpdate);
                    RefreshLists(true);
                    SetControlsEnabled(false);
                    break;
                case EntityOperation.LimitedUpdate:
                    FormTitle = "User Permissions";
                    Status = "Assign or unassign permissions to user.";
                    mnuUpdate.Text = "Update";
                    RefreshLists(true);
                    SetControlsEnabled(false);
                    break;
                default:
                    break;
            }
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void mnuUpdateAdd(object sender, EventArgs e)
        {
            foreach (string s in _unassignedPermissions.Keys)
            {
                UserPermission up = _user.UserPermissionCache[s];
                if (up != null)
                {
                    _user.UserPermissionCache.Delete(up.UserPermissionId);
                }
            }
            foreach (string s in _assignedPermissions.Keys)
            {
                UserPermission up = _user.UserPermissionCache[s.ToString()];
                if (up == null)
                {
                    _user.UserPermissionCache.Add(new UserPermission()
                    {
                        UserPermissionId = Guid.NewGuid(),
                        PermissionName = s.ToString(),
                        UserId = _user.UserId,
                        DateCreated = DateTime.Now
                    });
                }
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAssignPermission_Click(object sender, EventArgs e)
        {
            if (lstUnassignedPermissions.SelectedIndex < 0)
            {
                lstUnassignedPermissions.Focus();
                throw new UserThrownException("No permission selected to be assigned.", false, true, false);
            }
            string p = lstUnassignedPermissions.SelectedItem.ToString();
            _assignedPermissions.Add(p, null);
            _unassignedPermissions.Remove(p);
            RefreshLists(false);
        }

        private void btnUnassignPermission_Click(object sender, EventArgs e)
        {
            if (lstAssignedPermissions.SelectedIndex < 0)
            {
                lstAssignedPermissions.Focus();
                throw new UserThrownException("No permission selected to be unassigned.", false, true, false);
            }
            string p = lstAssignedPermissions.SelectedItem.ToString();
            _unassignedPermissions.Add(p, null);
            _assignedPermissions.Remove(p);
            RefreshLists(false);
        }

        private void btnAssignAllPermissions_Click(object sender, EventArgs e)
        {
            foreach (object i in lstUnassignedPermissions.Items)
            {
                _assignedPermissions.Add(i.ToString(), null);
                _unassignedPermissions.Remove(i.ToString());
            }
            RefreshLists(false);
        }

        private void btnUnassignAllPermissions_Click(object sender, EventArgs e)
        {
            foreach (object i in lstAssignedPermissions.Items)
            {
                _unassignedPermissions.Add(i.ToString(), null);
                _assignedPermissions.Remove(i.ToString());
            }
            RefreshLists(false);
        }

        private void UserPermissionsForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void UserPermissionsForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void UserPermissionsForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void UserPermissionsForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuCancel_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.Enter) & e.Control)
            {
                mnuUpdateAdd(sender, e);
            }
        }

        #endregion //Event Handlers
    }
}