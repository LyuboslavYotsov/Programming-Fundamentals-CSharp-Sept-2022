using System;
using System.Collections.Generic;
using System.Linq;

namespace P06CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> playerTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (Math.Min(playerOne.Count, playerTwo.Count) > 0)
            {
                int end = Math.Min(playerOne.Count, playerTwo.Count);
                CompareCards(playerOne, playerTwo, end);
            }
            if (playerOne.Count > playerTwo.Count)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
            else if (playerTwo.Count > playerOne.Count)
            {

                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
        }

        private static void CompareCards(List<int> playerOne, List<int> playerTwo, int end)
        {
            for (int i = 0; i < end; i++)
            {
                if (playerOne[i] == playerTwo[i])
                {
                    playerOne[i] = 0;
                    playerTwo[i] = 0;
                }

                else if (playerOne[i] > playerTwo[i])
                {
                    playerOne.Add(playerOne[i]);
                    playerOne.Add(playerTwo[i]);
                    playerOne[i] = 0;
                    playerTwo[i] = 0;
                }

                else if (playerTwo[i] > playerOne[i])
                {
                    playerTwo.Add(playerTwo[i]);
                    playerTwo.Add(playerOne[i]);
                    playerOne[i] = 0;
                    playerTwo[i] = 0;
                }
            }
            playerOne.RemoveAll(x => x == 0);
            playerTwo.RemoveAll(x => x == 0);
        }
    }
}
