using System;

namespace P09CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            string combinedChars = $"{ch1}{ch2}{ch3}";
            Console.WriteLine(combinedChars);
        }
    }
}
