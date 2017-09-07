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
    using System.IO;
    using Figlut.Desktop.BaseForms;
    using Figlut.Desktop.Utilities;
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    public partial class LogViewerForm : BorderlessForm
    {
        #region Constructors

        public LogViewerForm()
        {
            InitializeComponent();
            InitHiddenColumns();
        }

        #endregion //Constructors

        #region Fields

        private LogEntryCache _logEntryCache;
        private List<string> _hiddenColumns;

        #endregion //Fields

        #region Methods

        private void InitHiddenColumns()
        {
            _hiddenColumns = new List<string>();
            _hiddenColumns.Add(EntityReader<LogEntry>.GetPropertyName(p => p.Id, true));
        }

        private void RefreshGrid()
        {
            int selectedRowIndex = -1;
            if (grdLogViewer.SelectedRows.Count > 0)
            {
                selectedRowIndex = grdLogViewer.SelectedRows[0].Index;
            }
            grdLogViewer.DataSource = _logEntryCache.GetDataTable(txtMessage.Text, txtExceptionName.Text);
            _hiddenColumns.ForEach(c => grdLogViewer.Columns[c].Visible = false);
            if (selectedRowIndex < grdLogViewer.SelectedRows.Count && selectedRowIndex > -1)
            {
                grdLogViewer.Rows[selectedRowIndex].Selected = true;
            }
            grdLogViewer.Refresh();
        }

        public Nullable<Guid> GetSelectedRowId()
        {
            if (grdLogViewer.SelectedRows.Count < 1)
            {
                return null;
            }
            DataRow row = ((DataRowView)(grdLogViewer.SelectedRows[0].DataBoundItem)).Row;
            return new Guid(row[LogEntry.ID].ToString());
        }

        #endregion //Methods

        #region Event Handlers

        private void LogViewerForm_Load(object sender, EventArgs e)
        {
            using (WaitCursor w = new WaitCursor())
            {
                _logEntryCache = new LogEntryCache();
                _logEntryCache.ImportFromCsv(Path.Combine(Information.GetExecutingDirectory(), GlobalDataCache.Instance.Settings.LogFileName));
                RefreshGrid();
            }
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void picResizeWindow_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderLessFormResize(this, e);
        }

        private void LogViewerForm_MouseUp(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseUp(sender, e);
        }

        private void LogViewerForm_MouseMove(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseMove(sender, e);
        }

        private void LogViewerForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.BorderlessForm_MouseDown(sender, e);
        }

        private void grdLogViewer_SelectionChanged(object sender, EventArgs e)
        {
            Nullable<Guid> id = GetSelectedRowId();
            if(!id.HasValue)
            {
                return;
            }
            LogEntry le = _logEntryCache[id.Value];
            Status = le.Message;
        }

        private void FilterTextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void LogViewerForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuCancel_Click(sender, e);
            }
        }

        #endregion //Event Handlers
    }
}