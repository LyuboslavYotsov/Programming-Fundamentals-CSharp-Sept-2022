using System;

namespace P05SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numCount; i++)
            {
                int numCopy = i;
                int sum = 0;

                while (numCopy > 0)
                {
                    sum += numCopy % 10;
                    numCopy /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
