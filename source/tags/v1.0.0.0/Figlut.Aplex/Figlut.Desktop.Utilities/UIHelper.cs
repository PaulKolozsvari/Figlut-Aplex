namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;
    using System.Data;

    #endregion //Using Directives

    public class UIHelper
    {
        #region Methods

        public static void DisplayException(Exception ex)
        {
            StringBuilder message = new StringBuilder(ex.Message);
            if (ex.InnerException != null)
            {
                message.AppendLine(string.Format("\r\n", message));
            }
            if (!string.IsNullOrEmpty(ex.HelpLink))
            {
                message.AppendLine();
                message.AppendLine();
                message.AppendLine(string.Format("Support: {0}", ex.HelpLink));
            }
            MessageBox.Show(
                message.ToString(),
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

        public static int GetSelectedGridRowIndex(DataGridView grid)
        {
            int result = -1;
            if (grid.SelectedRows.Count > 0)
            {
                result = grid.SelectedRows[0].Index;
            }
            return result;
        }

        public static void SelectGridRow(DataGridView grid, int index)
        {
            if (index < grid.Rows.Count && index > -1)
            {
                grid.Rows[index].Selected = true;
            }
        }

        public static Nullable<Guid> GetSelectedRowId(DataGridView grid, string columnName, bool throwException)
        {
            if (grid.SelectedRows.Count < 1)
            {
                if (throwException)
                {
                    throw new UserThrownException("No item selected to be loaded.", false, true, false);
                }
                return null;
            }
            DataRow row = ((DataRowView)(grid.SelectedRows[0].DataBoundItem)).Row;
            return new Guid(row[columnName].ToString());
        }

        #endregion //Methods
    }
}
