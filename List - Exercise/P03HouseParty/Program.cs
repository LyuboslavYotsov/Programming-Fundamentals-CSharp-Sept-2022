using System;
using System.Linq;
using System.Collections.Generic;

namespace P03HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 1; i <= commandsCount; i++)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split(" ");

                string name = commands[0];

                if (commands.Length == 3)
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else if (commands.Length == 4)
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
