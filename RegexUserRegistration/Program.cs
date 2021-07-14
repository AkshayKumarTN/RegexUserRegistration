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
            if (regexUser.ValidateFirstName(firstName))
                Console.WriteLine(" First Name \"" + firstName + "\" is Valid");
            else
                Console.WriteLine(" First Name \"" + firstName + "\" is InValid");

        }
    }
}
