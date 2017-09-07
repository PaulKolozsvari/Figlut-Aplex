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
    using Figlut.Aplex.Desktop.Data.WebService;
    using Figlut.Aplex.Desktop.Data;
    using Figlut.Desktop.Utilities;

    #endregion //Using Directives

    public partial class UserForm : BorderlessForm
    {
        #region Constructors

        public UserForm(
            User user, 
            EntityOperation operation, 
            PropertyValueExists propertyValueExists)
        {
            InitializeComponent();
            _user = user;
            _operation = operation;
            _propertyValueExists = propertyValueExists;
        }

        #endregion //Constructors

        #region Fields

        private User _user;
        private EntityOperation _operation;
        private PropertyValueExists _propertyValueExists;

        #endregion //Fields

        #region Methods

        private void RefreshControls()
        {
            txtUserName.Text = _user.UserName;
            txtPassword.Text = _user.Password;
            txtConfirmPassword.Text = _user.Password;
            UserRoleId roleId = (UserRoleId)_user.RoleId;
            chkMobile.Checked = (roleId & UserRoleId.Mobile) == UserRoleId.Mobile;
            chkDesktop.Checked = (roleId & UserRoleId.Web) == UserRoleId.Web;
            chkSystem.Checked = (roleId & UserRoleId.System) == UserRoleId.System;
            chkAdministrator.Checked = (roleId & UserRoleId.Administrator) == UserRoleId.Administrator;
        }

        private void SetControlsEnabled(bool enabled)
        {
            txtUserName.Enabled = enabled;
            txtPassword.Enabled = enabled;
            txtConfirmPassword.Enabled = enabled;
            gpbRoles.Enabled = enabled;
        }

        private void SetLimitedUpdateControlsEnabled()
        {
            txtUserName.Enabled = false;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
            gpbRoles.Enabled = false;
        }

        #endregion //Methods

        #region Event Handlers

        private void UserForm_Load(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case EntityOperation.Update:
                    FormTitle = "Update User";
                    Status = "Enter user details.";
                    mnuUpdateAdd.Text = "Update";
                    mnuUpdateAdd.ShortcutKeys = Keys.Control | Keys.U;
                    RefreshControls();
                    break;
                case EntityOperation.Add:
                    FormTitle = "Add User";
                    Status = "Enter user details.";
                    mnuUpdateAdd.Text = "Add";
                    mnuUpdateAdd.ShortcutKeys = Keys.Control | Keys.A;
                    break;
                case EntityOperation.ReadOnly:
                    FormTitle = "Current User";
                    Status = "(Read only)";
                    mnuMain.Items.Remove(mnuUpdateAdd);
                    RefreshControls();
                    SetControlsEnabled(false);
                    break;
                case EntityOperation.LimitedUpdate:
                    FormTitle = "Current User";
                    Status = "Enter user details.";
                    mnuUpdateAdd.Text = "Update";
                    mnuUpdateAdd.ShortcutKeys = Keys.Control | Keys.U;
                    RefreshControls();
                    SetLimitedUpdateControlsEnabled();
                    break;
                default:
                    throw new ArgumentException("Invalid entity operation provided on User form.");
            }
        }

        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void UserForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void UserForm_MouseUp(object sender, MouseEventArgs e)
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
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                throw new UserThrownException("Username may not be left empty.", false, true, false);
            }
            if (txtUserName.Text != _user.UserName && _propertyValueExists(EntityReader<User>.GetPropertyName(p => p.UserName, false), txtUserName.Text))
            {
                txtUserName.Focus();
                throw new UserThrownException(string.Format("A user with username {0} already exists.", txtUserName.Text), false, true, false);
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                throw new UserThrownException("Password may not be left empty.", false, true, false);
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                throw new UserThrownException("Password must be confirmed.", false, true, false);
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                txtPassword.Focus();
                throw new UserThrownException("Passwords entered do not match.", false, true, false);
            }
            if (!chkMobile.Checked && !chkDesktop.Checked && !chkSystem.Checked && !chkAdministrator.Checked)
            {
                chkMobile.Focus();
                throw new UserThrownException("At least one role must be applied to the user.", false, true, false);
            }
            if ((_user.UserId == GlobalDataCache.Instance.CurrentUser.UserId) && 
                !chkAdministrator.Checked &&
                _operation != EntityOperation.LimitedUpdate)
            {
                chkDesktop.Focus();
                throw new UserThrownException(
                    "Cannot demote currently logged on user. Please login with a different user to change the roles for this user.",
                    false,
                    true,
                    false);
            }
            _user.UserName = txtUserName.Text;
            _user.Password = txtPassword.Text;
            int roleId = 0;
            if (chkMobile.Checked)
            {
                roleId = roleId | (int)UserRoleId.Mobile;
            }
            if (chkDesktop.Checked)
            {
                roleId = roleId | (int)UserRoleId.Web;
            }
            if (chkSystem.Checked)
            {
                roleId = roleId | (int)UserRoleId.System;
            }
            if (chkAdministrator.Checked)
            {
                roleId = roleId | (int)UserRoleId.Administrator;
            }
            _user.RoleId = roleId;
            if (_operation == EntityOperation.Add)
            {
                _user.DateCreated = DateTime.Now;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAdditionalInfo_Click(object sender, EventArgs e)
        {
            using (UserAdditionalInfoForm f = new UserAdditionalInfoForm(_user, _operation))
            {
                f.ShowDialog();
            }
        }

        private void chkAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            chkMobile.Checked = chkAdministrator.Checked;
            chkDesktop.Checked = chkAdministrator.Checked;
            chkSystem.Checked = chkAdministrator.Checked;

            chkMobile.Enabled = !chkAdministrator.Checked;
            chkDesktop.Enabled = !chkAdministrator.Checked;
            chkSystem.Enabled = !chkAdministrator.Checked;
        }

        private void chkRegularRole_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdministrator.Checked)
            {
                return;
            }
            chkAdministrator.Checked = chkMobile.Checked && chkDesktop.Checked && chkSystem.Checked;
        }

        private void UserForm_KeyUp(object sender, KeyEventArgs e)
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

        private void btnUserPermissions_Click(object sender, EventArgs e)
        {
            using (UserPermissionsForm f = new UserPermissionsForm(_user, _operation))
            {
                f.ShowDialog();
            }
        }

        #endregion //Event Handlers
    }
}