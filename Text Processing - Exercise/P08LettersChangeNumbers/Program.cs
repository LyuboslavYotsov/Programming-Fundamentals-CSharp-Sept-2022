using System;

namespace P08LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (string sequence in input)
            {
                char firstLetter = sequence[0];
                char secondLetter = sequence[sequence.Length - 1];
                double number = double.Parse(sequence[1..(sequence.Length - 1)].ToString());

                if (char.IsUpper(firstLetter))
                {
                    int letterPosition = (int)(firstLetter) - 64;
                    sum += number / letterPosition;
                }
                else
                {
                    int letterPosition = (int)(firstLetter) - 96;
                    sum += number * letterPosition;
                }

                if (char.IsUpper(secondLetter))
                {
                    int letterPosition = (int)(secondLetter) - 64;
                    sum -= letterPosition;
                }
                else
                {
                    int letterPosition = (int)(secondLetter) - 96;
                    sum += letterPosition;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
