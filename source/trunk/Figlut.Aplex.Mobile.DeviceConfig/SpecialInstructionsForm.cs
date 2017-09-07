namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Figlut.Aplex.Mobile.UI.Base;

    #endregion //Using Directives

    public partial class SpecialInstructionsForm : FiglutBaseForm
    {
        #region Constructors

        public SpecialInstructionsForm(string specialInstructions)
        {
            InitializeComponent();
            _specialInstructions = specialInstructions;
        }

        #endregion //Constructors

        #region Fields

        private string _specialInstructions;

        #endregion //Fields

        #region Event Handlers

        private void SpecialInstructionsForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtSpecialInstructions.Text = _specialInstructions;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex, true, true);
            }
        }

        #endregion //Event Handlers
    }
}