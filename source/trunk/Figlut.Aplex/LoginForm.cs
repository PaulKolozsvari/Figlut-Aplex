namespace Figlut.Aplex
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
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    public partial class LoginForm : BorderlessForm
    {
        #region Constructors

        public LoginForm()
        {
            InitializeComponent();
        }

        #endregion //Constructors

        #region Event Handlers

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            string originalStatus = Status;
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    txtUserName.Focus();
                    throw new UserThrownException("Username not entered.", false, true, false);
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                    throw new UserThrownException("Password not entered.", false, true, false);
                }
                using (WaitCursor w = new WaitCursor())
                {
                    Status = "Attempting to login ...";
                    ServiceFunctionResultOfUser result = GlobalDataCache.Instance.Service.Login(txtUserName.Text, txtPassword.Text, UserRoleId.Web);
                    if (ServiceResultHandler.HandleServiceResult(result))
                    {
                        return;
                    }
                    User u = result.Contents;
                    if (u == null)
                    {
                        throw new UserThrownException("Invalid username/password", false, true, false);
                    }
                    GlobalDataCache.Instance.CurrentUser = u;
                    Status = "Downloading user permissions ...";
                    if (GlobalDataCache.Instance.CurrentUser.UserPermissionCache.RefreshFromServerForUser(GlobalDataCache.Instance.CurrentUser))
                    {
                        return;
                    }
                    Status = "Downloading global server variables ...";
                    if(GlobalDataCache.Instance.GlobalServerVariables.RefreshFromServer())
                    {
                        return;
                    }
                }
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

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(this, e);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuCancel_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.Enter) & e.Control)
            {
                mnuLogin_Click(sender, e);
            }
        }

        #endregion //Event Handlers
    }
}