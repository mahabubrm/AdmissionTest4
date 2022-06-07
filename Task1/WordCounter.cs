using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    public class WordCounter
    {
        public int Count(string text)
        {
            int textLength = 0;
            int totalCount = 0;

            if (!string.IsNullOrEmpty(text.Trim()))
            {                
                string textParts = Regex.Replace(text, "[0-9]", " ");
                textParts = Regex.Replace(textParts, "[0-9]{3,}", " ");
                textParts = Regex.Replace(textParts, "[^a-zA-Z0-9_.]+", " ");
                if (!string.IsNullOrWhiteSpace(textParts))
                {
                    totalCount = 1;
                    while (textLength <= textParts.Length - 1)
                    {
                        if (textParts[textLength] == ' ')
                        {
                            totalCount++;
                        }

                        textLength++;
                    }
                }
            }

            return totalCount;
        }
    }
}
