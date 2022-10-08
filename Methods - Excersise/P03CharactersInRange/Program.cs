using System;

namespace P03CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char start;
            char end;

            if ((int)ch1 <= (int)ch2)
            {
                start = ch1;
                end = ch2;
            }
            else
            {
                start = ch2;
                end = ch1;
            }
            PrintBetweenChars(start, end);
        }

        static void PrintBetweenChars(char start, char end)
        {
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
