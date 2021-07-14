using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class RegexUserValidation
    {
        public const string UserFirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string UserLastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string UserEmail = "^abc.[A-Za-z1-9]*@bl.co.[a-z]*$";


        public bool ValidateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, UserFirstName);
        }
        public bool ValidateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, UserLastName);
        }
        public bool ValidateEmail(String email)
        {
            return Regex.IsMatch(email, UserEmail);
        }


    }
}
