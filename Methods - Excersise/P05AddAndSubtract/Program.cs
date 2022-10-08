using System;

namespace P05AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int finalResult = SumOfFirstTwo(numOne, numTwo) - numThree;
            Console.WriteLine(finalResult);
            
        }

        static int SumOfFirstTwo(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
    }
}
