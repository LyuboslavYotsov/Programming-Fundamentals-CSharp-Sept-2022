using System;

namespace P02SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numCopy = number;
            int sum = 0;

            while (numCopy > 0)
            {
                int currNum = numCopy % 10;
                sum += currNum;
                numCopy /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
