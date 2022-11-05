using System;

namespace P04SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char currCh = char.Parse(Console.ReadLine());
                sum += (int)currCh;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
