namespace Figlut.Desktop.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public class DataShaper
    {
        #region Methods

        public static string FormatEntityColumnName(string columnName)
        {
            List<int> spaceIndexes = new List<int>();
            for (int i = 0; i < columnName.Length; i++)
            {
                if (char.IsUpper(columnName[i]))
                {
                    spaceIndexes.Add(i);
                }
            }
            for (int i = 1; i < spaceIndexes.Count; i++)
            {
                columnName = columnName.Insert(spaceIndexes[i], " ");
                for (int j = i; j < spaceIndexes.Count; j++)
                {
                    spaceIndexes[j] += 1;
                }
            }
            return columnName;
        }

        #endregion //Methods
    }
}