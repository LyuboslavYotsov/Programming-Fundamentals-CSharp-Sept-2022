using System;
using System.Linq;
using System.Collections.Generic;

namespace P03MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commArgs[0];
                int index = int.Parse(commArgs[1]);
                int value = int.Parse(commArgs[2]);

                if (command == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }

                else if (command == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                else if (command == "Strike")
                {
                    if (index - value >= 0 && index + value < targets.Count)
                    {
                        targets.RemoveRange(index - value, 2 * value + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(String.Join("|", targets));
        }
    }
}
