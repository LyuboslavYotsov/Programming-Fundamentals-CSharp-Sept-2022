using System;

namespace P10TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool divisibleBy8 = false;
            bool atleastOneOdd = false;
            for (int i = 1; i <= n; i++)
            {
                divisibleBy8 = IsSumOfDigitsDevisibleBy8(i);
                atleastOneOdd = DoesNumHaveOddDigit(i);
                if (divisibleBy8 && atleastOneOdd)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool IsSumOfDigitsDevisibleBy8(int i)
        {
            string numStr = i.ToString();
            int sum = 0;
            for (int j = 0; j < numStr.Length; j++)
            {
                sum += numStr[j];
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool DoesNumHaveOddDigit(int i)
        {
            string numStr = i.ToString();
            for (int j = 0; j < numStr.Length; j++)
            {
                if (numStr[j] % 2 != 0)
                {
                    return true;
                }
               
            }
            return false;
        }

    }
}
