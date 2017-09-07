namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    #endregion //Using Directives

    public class UIHelper
    {
        #region Methods

        public static void DisplayException(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand,
                MessageBoxDefaultButton.Button1);
        }

        public static void DisplayError(string message)
        {
            MessageBox.Show(
                message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand,
                MessageBoxDefaultButton.Button1);
        }

        public static void DisplayInformation(string info)
        {
            MessageBox.Show(
                info, 
                "Information", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Asterisk, 
                MessageBoxDefaultButton.Button1);
        }

        public static void DisplayWarning(string warning)
        {
            MessageBox.Show(
                warning,
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        public static DialogResult AskQuestion(string question)
        {
            return MessageBox.Show(
                question,
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }

        #endregion //Methods
    }
}
