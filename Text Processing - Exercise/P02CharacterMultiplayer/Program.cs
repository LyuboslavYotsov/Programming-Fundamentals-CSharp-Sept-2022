using System;

namespace P02CharacterMultiplayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            string firstString = input[0];
            string secondString = input[1];
            int sum = 0;
            int minLenght = Math.Min(firstString.Length, secondString.Length);
            int maxLenght = Math.Max(firstString.Length, secondString.Length);

            for (int i = 0; i < minLenght; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            string biggestString = firstString;
            if (secondString.Length > firstString.Length)
            {
                biggestString = secondString;
            }
            for (int i = minLenght; i < maxLenght; i++)
            {
                sum += biggestString[i];
            }
            Console.WriteLine(sum);

        }
    }
}
