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
    using Figlut.Desktop.Data;
    using Figlut.Desktop.Utilities;

    #endregion //Using Directives

    public partial class UserAdditionalInfoForm : BorderlessForm
    {
        #region Constructors

        public UserAdditionalInfoForm(User user, EntityOperation operation)
        {
            InitializeComponent();
            _user = user;
            _operation = operation;
        }

        #endregion //Constructors

        #region Fields

        private User _user;
        private EntityOperation _operation;

        #endregion //Fields

        #region Methods

        private void RefreshControls()
        {
            txtName.Text = _user.Name;
            txtSurname.Text = _user.Surname;
            txtEmail.Text = _user.Email;
            txtAddress.Text = _user.Address;
            txtPhone.Text = _user.Phone;
            chkEmailNotifications.Checked = _user.EmailNotifications;
        }

        private void SetControlsEnabled(bool enabled)
        {
            txtName.Enabled = enabled;
            txtSurname.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtAddress.Enabled = enabled;
            txtPhone.Enabled = enabled;
            chkEmailNotifications.Enabled = enabled;
        }

        #endregion //Methods

        #region Event Handlers

        private void UserOptionalForm_Load(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case EntityOperation.Update:
                    FormTitle = "Update User";
                    Status = "Enter user additional information.";
                    mnuUpdateAdd.Text = "Update";
                    RefreshControls();
                    break;
                case EntityOperation.Add:
                    FormTitle = "Add user email signature";
                    Status = "Enter user additional information.";
                    mnuUpdateAdd.Text = "Add";
                    RefreshControls();
                    break;
                case EntityOperation.ReadOnly:
                    FormTitle = "Current User";
                    Status = "(Read only).";
                    mnuMain.Items.Remove(mnuUpdateAdd);
                    RefreshControls();
                    SetControlsEnabled(false);
                    break;
                case EntityOperation.LimitedUpdate:
                    FormTitle = "Update User";
                    Status = "Enter user additional information.";
                    mnuUpdateAdd.Text = "Update";
                    RefreshControls();
                    break;
                default:
                    throw new ArgumentException("Invalid entity operation provided on User Email Signature form.");
            }
        }

        private void mnuUpdateAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Focus();
                throw new UserThrownException("Name not entered.", false, true, false);
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                txtSurname.Focus();
                throw new UserThrownException("Surname not entered.", false, true, false);
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                throw new UserThrownException("Email not entered.", false, true, false);
            }
            _user.Name = string.IsNullOrEmpty(txtName.Text) ? null : txtName.Text;
            _user.Surname = string.IsNullOrEmpty(txtSurname.Text) ? null : txtSurname.Text;
            _user.Email = string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text;
            _user.Address = string.IsNullOrEmpty(txtAddress.Text) ? null : txtAddress.Text;
            _user.Phone = string.IsNullOrEmpty(txtPhone.Text) ? null : txtPhone.Text;
            _user.EmailNotifications = chkEmailNotifications.Checked;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void UserOptionalForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void UserOptionalForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void UserOptionalForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void UserAdditionalInfoForm_KeyUp(object sender, KeyEventArgs e)
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