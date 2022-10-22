using System;
using System.Linq;
using System.Collections.Generic;

namespace P04ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string command = commands[0];

                if (command == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numList.Add(number);
                }

                else if (command == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index >= numList.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numList.Insert(index, number);
                }

                else if (command == "Remove")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= numList.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numList.RemoveAt(index);
                }

                else if (command == "Shift")
                {
                    string direction = commands[1];
                    int count = int.Parse(commands[2]);

                    if (direction == "left")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            numList.Add(numList[0]);
                            numList.RemoveAt(0);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            numList.Insert(0, numList[numList.Count - 1]);
                            numList.RemoveAt(numList.Count - 1);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
