using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    public class RegexUserValidation
    {
        public const string UserFirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string UserLastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string UserEmail = "^[A-Za-z0-9]+([._+-][A-Za-z0-9]+)*@[0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public const string UserMobileNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        public const string UserPassword = "^(?=.*[A-Z])(?=.*[0-9])(?=[\\w]*[\\W][\\w]*$)[A-Za-z1-9.@!#$&%^*]{8,}$";

        // Throwing Custom Exceptions if User Details are InValid.........
        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, UserFirstName))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, UserLastName))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
        }
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, UserEmail))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_EMAIL, "Invalid Email");
        }
        public bool ValidateMobileNumber(string mobileNum)
        {
            if (Regex.IsMatch(mobileNum, UserMobileNumber))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");
        }
        public bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, UserPassword))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }

    }
}
