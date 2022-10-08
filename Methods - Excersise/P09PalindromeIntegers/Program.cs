using System;

namespace P09PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsItPalindrome(input));
            }
        }
        static bool IsItPalindrome(string input)
        {
            string numOne = input;
            string numTwo = string.Empty;
            for (int i = numOne.Length - 1; i >= 0; i--)
            {
                char ch1 = numOne[i];
                numTwo += ch1;
            }
            if (numOne == numTwo)
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
