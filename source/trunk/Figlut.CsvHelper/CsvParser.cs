namespace Figlut.CsvHelper
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Data;
    using System.Collections;

    #endregion //Using Directives

    public class CsvParser
    {
        #region Methods

        public static DataTable ParseFromFile(string file, bool headers, int columnCount)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException(string.Format("Could not find file {0}.", file));
            }
            return Parse(File.ReadAllText(file), headers, columnCount);
        }

        public static DataTable Parse(string data, bool headers, int columnCount)
        {
            return Parse(new StringReader(data), headers, columnCount);
        }

        public static DataTable Parse(string data, int columnCount)
        {
            return Parse(new StringReader(data), columnCount);
        }

        public static DataTable Parse(TextReader stream, int columnCount)
        {
            return Parse(stream, false, columnCount);
        }

        public static DataTable Parse(TextReader stream, bool headers, int columnCount)
        {
            DataTable table = new DataTable();
            CsvStream csv = new CsvStream(stream);
            string[] row = csv.GetNextRow();
            if (row == null)
                return null;
            if (headers)
            {
                foreach (string header in row)
                {
                    if (header != null && header.Length > 0 && !table.Columns.Contains(header))
                        table.Columns.Add(header, typeof(string));
                    else
                        table.Columns.Add(GetNextColumnHeader(table), typeof(string));
                }
                row = csv.GetNextRow();
            }
            int rowIndex = 0;
            while ((row != null))
            {
                if (row.Length != columnCount)
                {
                    throw new Exception(string.Format(
                        "Expected row of {0} columns and the row at index {1} contains {2} columns.", 
                        columnCount, 
                        rowIndex,
                        row.Length));
                }
                table.Columns.Add(GetNextColumnHeader(table), typeof(string));
                table.Rows.Add(row);
                row = csv.GetNextRow();
                rowIndex++;
            }
            if (table.Rows.Count < 1)
            {
                throw new Exception("No items found in file.");
            }
            return table;
        }

        private static string GetNextColumnHeader(DataTable table)
        {
            int c = 1;
            while (true)
            {
                string h = "Column" + c++;
                if (!table.Columns.Contains(h))
                    return h;
            }
        }

        #endregion //Methods
    }
}