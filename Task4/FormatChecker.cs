using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public class FormatChecker
    {
        public bool IsValid(string mobileNumber)
        {
            bool isValid = false;
            if (!string.IsNullOrEmpty(mobileNumber))
            {
                if (mobileNumber.Trim().Length == 11)
                {
                    Regex spchr = new Regex("[^a-zA-Z0-9_.]+");
                    bool isValidNUmber = int.TryParse(mobileNumber, out _);
                    bool isSpeicalCharExists = spchr.IsMatch(mobileNumber.ToString()) || isValidNUmber;
                    isValid = (isSpeicalCharExists) ? false : true;
                }
            }
            
            return isValid;
        }
    }
}
