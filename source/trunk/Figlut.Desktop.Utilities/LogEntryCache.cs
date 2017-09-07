namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Data;
    using Figlut.CsvHelper;

    #endregion //Using Directives

    public class LogEntryCache : IEnumerable<LogEntry>
    {
        #region Constructors

        public LogEntryCache()
        {
            _logEntries = new Dictionary<Guid, LogEntry>();
        }

        #endregion //Constructors

        #region Fields

        private Dictionary<Guid, LogEntry> _logEntries;

        #endregion //Fields

        #region Properties

        public int Count
        {
            get { return _logEntries.Count; }
        }

        #endregion //Properties

        #region Methods

        public void Add(LogEntry logEntry)
        {
            if (logEntry == null)
            {
                throw new UserThrownException("logEntry may not be null.", true, true, false);
            }
            if (_logEntries.ContainsKey(logEntry.Id))
            {
                throw new UserThrownException(
                    string.Format("A LogEntry with the Id {0} already exists in this collection.", logEntry.Id),
                    true,
                    true,
                    false);
            }
            _logEntries.Add(logEntry.Id, logEntry);
        }

        public void Delete(Guid id)
        {
            if (!_logEntries.ContainsKey(id))
            {
                throw new UserThrownException(
                    string.Format("There is no LogEntry with the Id {0} in this collection to be deleted.", id),
                    true,
                    true,
                    false);
            }
            _logEntries.Remove(id);
        }

        public LogEntry this[Guid id]
        {
            get
            {
                if (!_logEntries.ContainsKey(id))
                {
                    throw new UserThrownException(
                        string.Format("No Log Entry with the ID {0} exists in this collection.", id.ToString()),
                        true,
                        true,
                        false);
                }
                return _logEntries[id];
            }
        }

        public DataTable GetDataTable(string message, string exceptionName)
        {
            DataTable result = EntityReader<LogEntry>.GetDataTable(true);
            string messageLower = message.ToLower();
            string exceptionNameLower = exceptionName.ToLower();
            foreach (LogEntry le in _logEntries.Values)
            {
                if (le.Message.ToLower().Contains(messageLower) &&
                    le.ExceptionName.ToLower().Contains(exceptionNameLower))
                {
                    result.Rows.Add(
                        le.Id,
                        le.Type,
                        le.CreationDate,
                        le.Message,
                        le.ExceptionName);
                }
            }
            return result;
        }

        public Dictionary<Guid, LogEntry> DataTableToDictionary(DataTable table)
        {
            Dictionary<Guid, LogEntry> result = new Dictionary<Guid, LogEntry>();
            foreach (DataRow row in table.Rows)
            {
                LogEntry le = EntityReader<LogEntry>.PopulateFromDataRow(new LogEntry(), row);
                result.Add(le.Id, le);
            }
            return result;
        }

        public void Clear()
        {
            _logEntries.Clear();
            GC.Collect();
        }

        public void ImportFromCsv(string filePath)
        {
            Clear();
            _logEntries = null;
            _logEntries = DataTableToDictionary(CsvParser.ParseFromFile(filePath, true, EntityReader<LogEntry>.GetDataTable(true).Columns.Count));
        }

        public string GetHeader()
        {
            StringBuilder result = new StringBuilder();
            foreach (DataColumn c in EntityReader<LogEntry>.GetDataTable(false).Columns)
            {
                result.Append(string.Format("{0},", c.ColumnName));
            }
            return result.ToString().Remove(result.Length - 1);
        }

        public IEnumerator<LogEntry> GetEnumerator()
        {
            return _logEntries.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion //Methods
    }
}