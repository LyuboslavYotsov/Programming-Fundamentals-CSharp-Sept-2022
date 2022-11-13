using System;

namespace P01ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string reverse = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i];
                }
                Console.WriteLine($"{input} = {reverse}");
            }

        }
    }
}
