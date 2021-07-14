using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Regex User Registration Validation");

            RegexUserValidation regexUser = new RegexUserValidation();

            Console.Write("\n Enter First Name : ");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.Write(" Enter Last Name : ");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.Write(" Enter Email : ");
            string email = Convert.ToString(Console.ReadLine());
            Console.Write(" Enter Mobile Number : ");
            string mobileNumber = Convert.ToString(Console.ReadLine());

            if (regexUser.ValidateFirstName(firstName))
                Console.WriteLine("\n First Name \"" + firstName + "\" is Valid");
            else
                Console.WriteLine(" First Name \"" + firstName + "\" is InValid");
            if (regexUser.ValidateLastName(lastName))
                Console.WriteLine(" Last Name \"" + lastName + "\" is Valid");
            else
                Console.WriteLine(" Last Name \"" + lastName + "\" is InValid");
            if (regexUser.ValidateEmail(email))
                Console.WriteLine(" Email \"" + email + "\" is Valid");
            else
                Console.WriteLine(" Email \"" + email + "\" is InValid");
            if (regexUser.ValidateMobileNumber(mobileNumber))
                Console.WriteLine(" Mobile Number \"" + mobileNumber + "\" is Valid");
            else
                Console.WriteLine(" Mobile Number \"" + mobileNumber + "\" is InValid");


        }
    }
}
