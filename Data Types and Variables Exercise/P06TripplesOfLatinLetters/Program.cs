using System;

namespace P06TripplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            for (int dig1 = 0; dig1 < n; dig1++)
            {
                char ch1 = (char)('a' + dig1);
                for (int dig2 = 0; dig2 < n; dig2++)
                {
                    char ch2 = (char)('a' + dig2);
                    for (int dig3 = 0; dig3 < n; dig3++)
                    {
                        char ch3 = (char)('a' + dig3);
                        Console.WriteLine($"{ch1}{ch2}{ch3}");
                    }
                }
                
            }
        }
    }
}
