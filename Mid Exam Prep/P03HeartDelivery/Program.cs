using System;
using System.Linq;

namespace P03HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;
            int index = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] commArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int jumpLenght = int.Parse(commArgs[1]);
                index += jumpLenght;
                if (index >= houses.Length)
                {
                    index = 0;
                }

                if (houses[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                    continue;
                }

                if (houses[index] > 0)
                {
                    houses[index] -= 2;
                }

                if (houses[index] == 0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                }

            }
            Console.WriteLine($"Cupid's last position was {index}.");
            if (houses.All(x => x == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int count = 0;
                for (int i = 0; i < houses.Length; i++)
                {
                    if (houses[i] != 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}
