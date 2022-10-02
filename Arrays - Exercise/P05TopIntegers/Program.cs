using System;
using System.Linq;

namespace P05TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                bool topInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    if (nextNum >= currNum)
                    {
                        topInteger = false;
                        break;
                    }

                }
                if (topInteger)
                {
                    Console.Write(currNum + " ");
                }
                //for (int k = 0; k < i; k++)
                //{
                //to Left
                //}
            }
        }
    }
}
