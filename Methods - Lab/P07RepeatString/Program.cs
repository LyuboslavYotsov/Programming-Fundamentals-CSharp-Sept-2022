using System;

namespace P07RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            string output = RepeatString(input, repeats);
            Console.WriteLine(output);
        }

        private static string RepeatString(string input, int repeats)
        {
            string output = string.Empty;
            for (int i = 1; i <= repeats; i++)
            {
               output += input;
            }
            return output;
        }
    }
}
