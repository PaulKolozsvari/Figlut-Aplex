namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public class LogEntry
    {
        #region Inner Types

        public enum EntryType
        {
            Error,
            Warning,
            Info
        }

        #endregion //Inner Types

        #region Constructors

        public LogEntry()
        {
        }

        #endregion //Constructors

        #region Constants

        public const string ID = "ID";
        public const string TYPE = "Type";
        public const string CREATION_DATE = "Creation Date";
        public const string MESSAGE = "Message";
        public const string EXCEPTION_NAME = "Exception Name";

        #endregion //Constants

        #region Properties

        public Guid Id { get; set; }

        public EntryType Type { get; set; }

        public DateTime CreationDate { get; set; }

        public string Message { get; set; }

        public string ExceptionName { get; set; }

        #endregion //Properties

        #region Methods

        public override string ToString()
        {
            Message = Message.Replace("\"", string.Empty);
            Message = Message.Replace("\n\r", string.Empty);
            Message = Message.Replace("\n", string.Empty);
            Message = Message.Replace("\r", string.Empty);
            // enum ToString() docs : //http://msdn.microsoft.com/en-us/library/system.enum.tostring(v=vs.71).aspx
            string exceptionName = string.IsNullOrEmpty(ExceptionName) ? "Logger" : ExceptionName;
            return string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\"",
                Id.ToString(),
                Type.ToString("g"),
                CreationDate.ToString(),
                Message,
                exceptionName);
        }

        #endregion //Methods
    }
}