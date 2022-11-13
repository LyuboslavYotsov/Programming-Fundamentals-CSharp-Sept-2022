using System;

namespace ME01ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int nameStartIndex = input.IndexOf('@');
                int nameEndIndex = input.IndexOf('|');
                string name = input[(nameStartIndex + 1)..nameEndIndex];

                int ageStartIndex = input.IndexOf('#');
                int ageEndIndex = input.IndexOf('*');
                string age = input[(ageStartIndex + 1)..ageEndIndex];

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
