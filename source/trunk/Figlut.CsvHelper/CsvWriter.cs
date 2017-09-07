namespace Figlut.CsvHelper
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Data;

    #endregion //Using Directives

    public class CsvWriter
    {
        #region Methods

        public static void WriteToFile(DataTable table, bool header, bool quoteball, string file, string footer)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            File.WriteAllText(file, WriteToString(table, header, quoteball, footer));
        }

        public static string WriteToString(DataTable table, bool header, bool quoteall, string footer)
        {
            using (StringWriter writer = new StringWriter())
            {
                WriteToStream(writer, table, header, quoteall, footer);
                return writer.ToString();
            }
        }

        public static void WriteToStream(TextWriter stream, DataTable table, bool header, bool quoteall, string footer)
        {
            if (header)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    WriteItem(stream, table.Columns[i].Caption, quoteall);
                    if (i < table.Columns.Count - 1)
                    {
                        stream.Write(',');
                    }
                    else
                    {
                        stream.Write('\n');
                    }
                }
            }
            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    WriteItem(stream, row[i], quoteall);
                    if (i < table.Columns.Count - 1)
                    {
                        stream.Write(',');
                    }
                    else
                    {
                        stream.Write("\n");
                    }
                }
            }
            if (!string.IsNullOrEmpty(footer))
            {
                stream.WriteLine();
                stream.WriteLine(footer);
            }
        }

        private static void WriteItem(TextWriter stream, object item, bool quoteall)
        {
            if (item == null)
            {
                return;
            }
            string s = null;
            if (item.GetType() == typeof(Byte[]))
            {
                s = Convert.ToBase64String((byte[])item);
            }
            else
            {
                s = item.ToString();
            }
            if (quoteall || s.IndexOfAny("\",\x0A\x0D".ToCharArray()) > -1)
            {
                stream.Write("\"" + s.Replace("\"", "\"\"") + "\"");
            }
            else
            {
                stream.Write(s);
            }
        }
        
        #endregion //Methods
    }
}
