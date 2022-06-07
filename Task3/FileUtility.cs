using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FileUtility
    {
        public void WriteLine(string text)
        {
            string filePath = "../../../Data.txt";
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, text + Environment.NewLine);                
            }

        }
    }
}
