using System;
using System.Linq;
using System.Collections.Generic;

namespace P03Invertory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> itemsList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commArgs = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commArgs[0];

                if (command == "Collect")
                {
                    string item = commArgs[1];

                    if (!itemsList.Contains(item))
                    {
                        itemsList.Add(item);
                    }
                }

                else if (command == "Drop")
                {
                    string item = commArgs[1];

                    if (itemsList.Contains(item))
                    {
                        itemsList.Remove(item);
                    }
                }

                else if (command == "Combine Items")
                {
                    string[] combineArr = commArgs[1].
                        Split(":")
                        .ToArray();
                    string oldItem = combineArr[0];
                    string newItem = combineArr[1];

                    if (itemsList.Contains(oldItem))
                    {
                        int newItemIndex = itemsList.IndexOf(oldItem) + 1;
                        itemsList.Insert(newItemIndex, newItem);
                    }
                }

                else if (command == "Renew")
                {
                    string item = commArgs[1];

                    if (itemsList.Contains(item))
                    {
                        itemsList.Remove(item);
                        itemsList.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", itemsList));
        }
    }
}
