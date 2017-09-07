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

    public partial class ManageCustomersForm : BorderlessForm
    {
        #region Constructors

        public ManageCustomersForm()
        {
            InitializeComponent();
            _customerCache = new CustomerCache();
            InitHiddenColumns();
        }

        #endregion //Constructors

        #region Fields

        private CustomerCache _customerCache;
        private bool _unsavedChanges;
        private List<string> _hiddenColumns;

        #endregion //Fields

        #region Methods

        private void InitHiddenColumns()
        {
            _hiddenColumns = new List<string>();
            _hiddenColumns.Add(EntityReader<Customer>.GetPropertyName(p => p.CustomerId, true));
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
                        if (_customerCache.RefreshFromServer())
                        {
                            return;
                        }
                        _unsavedChanges = false;
                    }
                    int index = UIHelper.GetSelectedGridRowIndex(grdCustomers);
                    Dictionary<string, object> properties = new Dictionary<string, object>();
                    properties.Add(EntityReader<Customer>.GetPropertyName(p => p.CompanyName, false), txtCompanyName.Text);
                    grdCustomers.DataSource = _customerCache.GetDataTable(properties, false, true);
                    _hiddenColumns.ForEach(p => grdCustomers.Columns[p].Visible = false);
                    UIHelper.SelectGridRow(grdCustomers, index);
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

        private void ManageCustomersForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void ManageCustomersForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void ManageCustomersForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void picResizeWindow_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderLessFormResize(sender, e);
        }

        private void ManageCustomersForm_Load(object sender, EventArgs e)
        {
            Refresh(true);
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
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
                    if (_customerCache.SaveToServer())
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

        private void mnuEditAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer() { CustomerId = Guid.NewGuid() };
            using (CustomerForm f = new CustomerForm(
                customer,
                EntityOperation.Add,
                new PropertyValueExists(_customerCache.PropertyValueExists)))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _customerCache.Add(customer);
                    Refresh(false);
                    _unsavedChanges = true;
                }
            }
        }

        private void mnuEditUpdate_Click(object sender, EventArgs e)
        {
            Nullable<Guid> selectedId = UIHelper.GetSelectedRowId(
                grdCustomers,
                EntityReader<Customer>.GetPropertyName(p => p.CustomerId, true),
                true);
            Customer customer = _customerCache[selectedId.Value];
            using (CustomerForm f = new CustomerForm(
                customer,
                EntityOperation.Update,
                new PropertyValueExists(_customerCache.PropertyValueExists)))
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
                grdCustomers,
                EntityReader<Customer>.GetPropertyName(p => p.CustomerId, true),
                true);
            Customer customer = _customerCache[selectedId.Value];
            if (UIHelper.AskQuestion(
                "Deleting a customer will delete all the data associated with this customer. Are you sure you want to delete the selected customer?")
                != DialogResult.Yes)
            {
                return;
            }
            _customerCache.Delete(selectedId.Value);
            Refresh(false);
            _unsavedChanges = true;
        }

        private void ManageCustomersForm_KeyUp(object sender, KeyEventArgs e)
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