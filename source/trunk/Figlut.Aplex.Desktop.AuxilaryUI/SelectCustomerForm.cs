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

    public partial class SelectCustomerForm : BorderlessForm
    {
        #region Constructors

        public SelectCustomerForm()
        {
            InitializeComponent();
            _customerCache = new CustomerCache();
        }

        #endregion //Constructors

        #region Fields

        private CustomerCache _customerCache;
        private Customer _customer;

        #endregion //Fields

        #region Properties

        public Customer Customer
        {
            get { return _customer; }
        }

        #endregion //Properties

        #region Methods

        private void Refresh(bool fromServer)
        {
            string originalStatus = Status;
            try
            {
                using (WaitCursor w = new WaitCursor())
                {
                    if (fromServer)
                    {
                        Status = "Refreshing from server ...";
                        if (_customerCache.RefreshFromServer())
                        {
                            return;
                        }
                    }
                    int index = lstCustomers.SelectedIndex;
                    Dictionary<string, object> properties = new Dictionary<string, object>();
                    properties.Add(EntityReader<Customer>.GetPropertyName(p => p.CompanyName, false), txtCompanyName.Text);
                    List<Customer> customers = _customerCache.GetEntitiesByProperties(properties, false);
                    lstCustomers.Items.Clear();
                    customers.ForEach(p => lstCustomers.Items.Add(p));
                    if (index < lstCustomers.Items.Count)
                    {
                        lstCustomers.SelectedIndex = index;
                    }
                    else if(lstCustomers.Items.Count > 0)
                    {
                        lstCustomers.SelectedIndex = 0;
                    }
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

        private void SelectCustomerForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void SelectCustomerForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void SelectCustomerForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void SelectCustomerForm_Load(object sender, EventArgs e)
        {
            Refresh(true);
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            Refresh(false);
        }

        private void mnuSelect_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex < 0)
            {
                lstCustomers.Focus();
                throw new UserThrownException("No Customer Company Name selected.", false, true, false);
            }
            _customer = (Customer)lstCustomers.SelectedItem;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectCustomerForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuCancel_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.Enter) & e.Control)
            {
                mnuSelect_Click(sender, e);
            }
        }

        #endregion //Event Handlers
    }
}
