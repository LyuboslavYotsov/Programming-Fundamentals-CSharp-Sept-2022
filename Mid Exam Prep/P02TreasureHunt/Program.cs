using System;
using System.Collections.Generic;
using System.Linq;

namespace P02TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chestLoot = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] commArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commArgs[0];

                if (command == "Loot")
                {
                    for (int i = 1; i < commArgs.Length; i++)
                    {
                        if (!chestLoot.Contains(commArgs[i]))
                        {
                            chestLoot.Insert(0, commArgs[i]);
                        }
                    }
                }

                else if (command == "Drop")
                {
                    int index = int.Parse(commArgs[1]);
                    if (index < 0 || index >= chestLoot.Count)
                    {
                        continue;
                    }
                    string item = chestLoot[index];
                    chestLoot.RemoveAt(index);
                    chestLoot.Add(item);
                }

                else if (command == "Steal")
                {
                    int count = int.Parse(commArgs[1]);

                    List<string> stolenItems = new List<string>();
                    int startIndex = chestLoot.Count - count;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    for (int i = startIndex; i < chestLoot.Count; i++)
                    {
                        string item = chestLoot[i];
                        stolenItems.Add(item);
                    }
                    if (count > chestLoot.Count)
                    {
                        count = chestLoot.Count;
                    }
                    chestLoot.RemoveRange(startIndex, count);

                    Console.WriteLine(string.Join(", ", stolenItems));
                }
            }

            if (chestLoot.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < chestLoot.Count; i++)
                {
                    sum += chestLoot[i].Length;
                }

                double average = (double)sum / chestLoot.Count;
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
        }
    }
}
