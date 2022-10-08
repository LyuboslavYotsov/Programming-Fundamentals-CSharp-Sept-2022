using System;

namespace P08FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            decimal numOneF = GetFactoriel(numOne);
            decimal numTwoF = GetFactoriel(numTwo);
            Console.WriteLine($"{numOneF / numTwoF:f2}");


        }

        static decimal GetFactoriel(decimal num)
        {
            for (int i = (int)num - 1 ; i >= 1; i--)
            {
                num *= i;
            }
            return num;
        }
    }
}
