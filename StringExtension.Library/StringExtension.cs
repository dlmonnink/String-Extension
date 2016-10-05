using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension.Library
{
    public static class StringExtension
    {
        /* Method: IndexesOf(subtext)
         * Input: String subtext
         * Output: List<int> (for convenience of the example program the return type is string. In most cases it would be a
         *         list or array of integer representing each position in the text that the subtext matches.
         * Description: This method is a string extension similar to that of string.IndexOf(subtext) but returns all match indexes
         */

        public static List<int> IndexesOf(this string text, string subtext)
        {
            List<int> indexes = new List<int>();

            if ((text.Length >= subtext.Length) && (subtext.Length > 0))
            {
                text = text.ToLower();
                subtext = subtext.ToLower();
                bool found = false;
                
                for (int x = 0; x < text.Length; x++)
                {
                    if (text[x] == subtext[0])
                    {
                        found = true;
                        for (int y = x; y < (x + subtext.Length); y++)
                        {
                            if (y < text.Length)
                            {
                                if (text[y] != subtext[y - x])
                                {
                                    found = false;
                                    break;
                                }
                            }
                            else
                            {
                                found = false;
                            }
                        }

                        if (found)
                        {
                            indexes.Add(x + 1);
                        }
                    }
                }
            }

            return indexes;
        }
    }
}
