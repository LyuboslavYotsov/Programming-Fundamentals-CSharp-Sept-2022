using System;

namespace P06MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                GetMiddleCharsEven(input);
            }
            else
            {
                GetMiddleCharOdd(input);
            }
        }

        static void GetMiddleCharsEven(string input)
        {
            char ch1 = input[input.Length / 2 - 1];
            char ch2 = input[input.Length / 2];
            Console.WriteLine($"{ch1}{ch2}");
            
        }

        static void GetMiddleCharOdd(string input)
        {
            char ch1 = input[input.Length / 2];
            Console.WriteLine(ch1);
        }
    }
}
