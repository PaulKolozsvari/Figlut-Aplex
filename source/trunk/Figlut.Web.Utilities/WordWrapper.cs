namespace Figlut.Web.Utilities
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion //Using Directives

    public class WordWrapper
    {
        #region Constants

        private const string NEW_LINE = "\r\n";

        #endregion //Constants

        #region Methods

        public static string DrawTimesheetItemField(string text, int width)
        {
            int position, nextLinePosition = 0;
            StringBuilder result = new StringBuilder();
            if (width < 1)
            {
                return text;
            }
            for (position = 0; position < text.Length; position = nextLinePosition)
            {
                int eolPosition = text.IndexOf(NEW_LINE, position);
                if (eolPosition == -1)
                {
                    nextLinePosition = eolPosition = text.Length;
                }
                else
                {
                    nextLinePosition = eolPosition + NEW_LINE.Length;
                }
                if (eolPosition > position)
                {
                    do
                    {
                        int len = eolPosition - position;
                        if (len > width)
                        {
                            len = BreakLine(text, position, width);
                        }
                        result.Append(text, position, len);
                        result.Append(NEW_LINE);
                        // Trim whitespace following break
                        position += len;
                        while (position < eolPosition && Char.IsWhiteSpace(text[position]))
                        {
                            position++;
                        }
                    } while (eolPosition > position);
                }
                else
                {
                    result.Append(NEW_LINE);
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Locates position to break the given line so as to avoid
        /// breaking words.
        /// </summary>
        /// <param name="text">String that contains line of text</param>
        /// <param name="pos">Index where line of text starts</param>
        /// <param name="max">Maximum line length</param>
        /// <returns>The modified line length</returns>
        public static int BreakLine(string text, int pos, int max)
        {
            // Find last whitespace in line
            int i = max - 1;
            while (i >= 0 && !Char.IsWhiteSpace(text[pos + i]))
            {
                i--;
            }
            if (i < 0)
            {
                return max; // No whitespace found; break at maximum length
            }
            // Find start of whitespace
            while (i >= 0 && Char.IsWhiteSpace(text[pos + i]))
            {
                i--;
            }
            // Return length of text before whitespace
            return i + 1;
        }

        #endregion //Methods
    }
}