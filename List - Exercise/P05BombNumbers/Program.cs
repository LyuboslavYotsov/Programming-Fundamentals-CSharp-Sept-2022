using System;
using System.Linq;
using System.Collections.Generic;

namespace P05BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bombNum = bombArgs[0];
            int power = bombArgs[1];
            BombNumberInCollection(numbers, bombNum, power);
            numbers.RemoveAll(x => x == 0);
            Console.WriteLine(numbers.Sum());

        }

        private static void BombNumberInCollection(List<int> numbers, int bombNum, int power)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNum)
                {
                    for (int j = 1; j <= power; j++)
                    {
                        if (i + j >= numbers.Count)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + j] = 0;
                        }
                    }

                    for (int j = 0; j <= power; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                    }


                }
            }
        }
    }
}
