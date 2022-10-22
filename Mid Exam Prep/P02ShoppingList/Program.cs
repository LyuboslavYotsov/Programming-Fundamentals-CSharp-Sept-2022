using System;
using System.Linq;
using System.Collections.Generic;

namespace P02ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> grocerisList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commArgs[0];
                if (command == "Urgent")
                {
                    string item = commArgs[1];

                    if (!grocerisList.Contains(item))
                    {
                        grocerisList.Insert(0, item);
                    }
                }

                else if (command == "Unnecessary")
                {
                    string item = commArgs[1];

                    if (grocerisList.Contains(item))
                    {
                        grocerisList.Remove(item);
                    }
                }

                else if (command == "Correct")
                {
                    string oldItem = commArgs[1];
                    string newItem = commArgs[2];

                    if (grocerisList.Contains(oldItem))
                    {
                        grocerisList[grocerisList.IndexOf(oldItem)] = newItem;
                    }
                }

                else if (command == "Rearrange")
                {
                    string item = commArgs[1];
                    if (grocerisList.Contains(item))
                    {
                        grocerisList.Remove(item);
                        grocerisList.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", grocerisList));
        }
    }
}
