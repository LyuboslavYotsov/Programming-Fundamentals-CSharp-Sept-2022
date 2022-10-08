using System;

namespace P04PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLenghtValid = IsPasswordLenghtValid(password);
            bool isAlphanumeric = IsPasswordAlphanumeric(password);
            bool isPassContaining2Digits = IsPasswordContainingAtleast2Digits(password);

            if (!isLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isAlphanumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPassContaining2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLenghtValid && isAlphanumeric && isPassContaining2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPasswordLenghtValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool IsPasswordAlphanumeric(string password)
        {
            
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPasswordContainingAtleast2Digits(string password)
        {
            int digitsCount = 0;

            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
            if (digitsCount >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
