using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RefactoredGameProject
{
    public class LoginValidator
    {
        string LoginPattern = @"(?=.*[A-Za-z0-9]$)[A-Za-z][A-Za-z\d.-]{0,19}";

        public bool LoginValidate(string login)
        {
            Match loginmatchresult = Regex.Match(login, LoginPattern);

            if (loginmatchresult.Success)
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
