using System;

namespace ME02AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char currCh = str[i];
                if (currCh > firstCh && currCh < secondCh)
                {
                    sum += (int)currCh;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
