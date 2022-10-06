using System;

namespace P10MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = Math.Abs(int.Parse(input));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits (int number)
        {
            string numString = number.ToString();
            int evenSum = 0;
            for (int i = 1; i <= numString.Length; i++)
            {
                int currNum = number % 10;
                if (currNum % 2 == 0)
                {
                    evenSum += currNum;
                }
                number /= 10;
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {

            string numString = number.ToString();
            int oddSum = 0;
            for (int i = 1; i <= numString.Length; i++)
            {
                int currNum = number % 10;
                if (currNum % 2 != 0)
                {
                    oddSum += currNum;
                }
                number /= 10;
            }
            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            return result;
        }
    }
}
