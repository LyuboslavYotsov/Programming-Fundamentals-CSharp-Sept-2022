using System;
using System.Linq;
using System.Collections.Generic;

namespace P03MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            int moves = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                int[] indexes = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstIndex = indexes[0];
                int secondIndex = indexes[1];
                if (numList.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
                moves++;

                if (firstIndex == secondIndex || firstIndex < 0 || firstIndex >= numList.Count
                    || secondIndex < 0 || secondIndex >= numList.Count)
                {
                    numList.Insert(numList.Count / 2, $"-{moves}a");
                    numList.Insert(numList.Count / 2, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (numList[firstIndex] == numList[secondIndex])
                {
                    string element = numList[firstIndex];
                    numList.RemoveAll(x => x == element);
                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                    continue;
                }
                else if (numList[firstIndex] != numList[secondIndex])
                {
                    Console.WriteLine("Try again!");
                    continue;
                }

            }

            if (numList.Count > 0 && input == "end")
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ",numList));
            }
            else
            {
                Console.WriteLine($"You have won in {moves} turns!");
            }
        }
    }
}
