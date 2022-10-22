using System;
using System.Linq;

namespace P03ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] warShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxHealth = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] commArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commArgs[0];

                if (command == "Fire")
                {
                    int index = int.Parse(commArgs[1]);
                    int damage = int.Parse(commArgs[2]);
                    if (index < 0 || index >= warShip.Length)
                    {
                        continue;
                    }

                    warShip[index] -= damage;
                    if (warShip[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }
                }

                else if (command == "Defend")
                {
                    int startIndex = int.Parse(commArgs[1]);
                    int endIndex = int.Parse(commArgs[2]);
                    int damage = int.Parse(commArgs[3]);

                    if (startIndex < 0 || endIndex >= pirateShip.Length 
                        || startIndex >= pirateShip.Length || endIndex < 0)
                    {
                        continue;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        pirateShip[i] -= damage;

                        if (pirateShip[i] <= 0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                    }
                }

                else if (command == "Repair")
                {
                    int index = int.Parse(commArgs[1]);
                    int health = int.Parse(commArgs[2]);

                    if (index < 0 || index >= pirateShip.Length)
                    {
                        continue;
                    }

                    pirateShip[index] += health;
                    if (pirateShip[index] > maxHealth)
                    {
                        pirateShip[index] = maxHealth;
                    }
                }

                else if (command == "Status")
                {
                    double lowHealth = maxHealth * 0.20;
                    int lowCount = 0;
                    for (int i = 0; i < pirateShip.Length; i++)
                    {
                        if (pirateShip[i] < lowHealth)
                        {
                            lowCount++;
                        }
                    }
                    Console.WriteLine($"{lowCount} sections need repair.");
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
