using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RefactoredGameProject
{
    public class PasswordValidator
    {
        string PasswordPattern = @"(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}";

        public bool PasswordValidate(string password)
        {
            Match passwordmatchresult = Regex.Match(password, PasswordPattern);

            if (passwordmatchresult.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
