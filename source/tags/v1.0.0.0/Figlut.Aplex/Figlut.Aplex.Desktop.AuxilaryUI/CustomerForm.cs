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
    using Figlut.Desktop.Data;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data.WebService;

    #endregion //Using Directives

    public partial class CustomerForm : BorderlessForm
    {
        #region Constructors

        public CustomerForm(
            Customer customer,
            EntityOperation operation,
            PropertyValueExists propertyValueExists)
        {
            InitializeComponent();
            _customer = customer;
            _operation = operation;
            _propertyValueExists = propertyValueExists;
        }

        #endregion //Constructors

        #region Fields

        private Customer _customer;
        private EntityOperation _operation;
        private PropertyValueExists _propertyValueExists;

        #endregion //Fields

        #region Methods

        private void RefreshControls()
        {
            txtCompanyName.Text = _customer.CompanyName;
            txtPhysicalAddress.Text = _customer.PhysicalAddress;
            txtPostalAddress.Text = _customer.PostalAddress;
            txtContactName.Text = _customer.ContactName;
            txtContactNumber.Text = _customer.ContactNumber;
            txtContactEmail.Text = _customer.ContactEmail;
        }

        private void SetControlsEnabled(bool enabled)
        {
            txtCompanyName.Enabled = enabled;
            txtPhysicalAddress.Enabled = enabled;
            txtPostalAddress.Enabled = enabled;
            txtContactName.Enabled = enabled;
            txtContactNumber.Enabled = enabled;
            txtContactEmail.Enabled = enabled;
        }

        private void SetLimitedUpdateControlsEnabled()
        {
            txtCompanyName.Enabled = false;
            txtPhysicalAddress.Enabled = true;
            txtPostalAddress.Enabled = true;
            txtContactName.Enabled = true;
            txtContactNumber.Enabled = true;
            txtContactEmail.Enabled = true;
        }

        #endregion //Methods

        #region Event Handlers

        private void CustomerForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void CustomerForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void CustomerForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case EntityOperation.Update:
                    FormTitle = "Update Customer";
                    Status = "Enter customer details.";
                    mnuUpdateAdd.Text = "Update";
                    mnuUpdateAdd.ShortcutKeys = Keys.Control | Keys.U;
                    RefreshControls();
                    break;
                case EntityOperation.Add:
                    FormTitle = "Add Customer";
                    Status = "Enter user details.";
                    mnuUpdateAdd.Text = "Add";
                    mnuUpdateAdd.ShortcutKeys = Keys.Control | Keys.A;
                    break;
                case EntityOperation.ReadOnly:
                    FormTitle = "Customer details";
                    Status = "(Read only)";
                    mnuMain.Items.Remove(mnuUpdateAdd);
                    RefreshControls();
                    SetControlsEnabled(false);
                    break;
                case EntityOperation.LimitedUpdate:
                    FormTitle = "Customer";
                    Status = "Enter customer details.";
                    mnuUpdateAdd.Text = "Update";
                    mnuUpdateAdd.ShortcutKeys = Keys.Control | Keys.U;
                    RefreshControls();
                    SetLimitedUpdateControlsEnabled();
                    break;
                default:
                    break;
            }
        }

        private void mnuUpdateAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                txtCompanyName.Focus();
                throw new UserThrownException("Company Name may not be left empty.", false, true, false);
            }
            if (_propertyValueExists(EntityReader<Customer>.GetPropertyName(p => p.CompanyName, false), txtCompanyName.Text))
            {
                throw new UserThrownException(string.Format(
                    "A customer with the Company Name {0} alreadpy exists.", txtCompanyName.Text), false, true, false);
            }
            _customer.CompanyName = txtCompanyName.Text;
            _customer.PhysicalAddress = txtPhysicalAddress.Text;
            _customer.PostalAddress = txtPostalAddress.Text;
            _customer.ContactName = txtContactName.Text;
            _customer.ContactNumber = txtContactNumber.Text;
            _customer.ContactEmail = txtContactEmail.Text;
            if (_operation == EntityOperation.Add)
            {
                _customer.DateCreated = DateTime.Now;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CustomerForm_KeyUp(object sender, KeyEventArgs e)
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
