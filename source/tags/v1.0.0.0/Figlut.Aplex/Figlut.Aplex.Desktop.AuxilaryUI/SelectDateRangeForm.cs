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

    #endregion //Using Directives

    public partial class SelectDateRangeForm : BorderlessForm
    {
        #region Event Handlers

        public SelectDateRangeForm()
        {
            InitializeComponent();
        }

        #endregion //Event Handlers

        #region Fields

        private DateTime _startDate;
        private DateTime _endDate;

        #endregion //Fields

        #region Properties

        public DateTime StartDate
        {
            get { return _startDate; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
        }

        #endregion //Properties

        #region Event Handlers

        private void SelectDateRangeForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));
            dtpEndDate.Value = DateTime.Now.AddDays(1);
        }

        private void mnuSelect_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                dtpStartDate.Focus();
                throw new UserThrownException("Start Date may not be greater than the End Date.", false, true, false);
            }
            _startDate = dtpStartDate.Value;
            _endDate = dtpEndDate.Value;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectDateRangeForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void SelectDateRangeForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void SelectDateRangeForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void SelectDateRangeForm_KeyUp(object sender, KeyEventArgs e)
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