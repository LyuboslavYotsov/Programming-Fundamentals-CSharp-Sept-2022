using System;
using System.Linq;

namespace P02MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currRoom = rooms[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).
                    ToArray();

                string command = currRoom[0];
                int value = int.Parse(currRoom[1]);
                bestRoom++;

                if (command == "potion")
                {
                    int healing = 0;
                    if (health + value > 100)
                    {
                        healing = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        health += value;
                        healing = value;
                    }

                    Console.WriteLine($"You healed for {healing} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }

                else if (command == "chest")
                {
                    bitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }

                else
                {
                    string monster = command;
                    int damage = value;
                    health -= damage;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }

                    else if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        return;
                    }
                }
                
            }

            if (bestRoom == rooms.Length)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
