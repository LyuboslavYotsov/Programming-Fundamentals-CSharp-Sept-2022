using System;
using System.Linq;
using System.Collections.Generic;

namespace P06ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string input;
            bool isChanged = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ");
                string currentCommand = commands[0];

                if (currentCommand == "Add")
                {
                    isChanged = true;
                    int number = int.Parse(commands[1]);
                    numList.Add(number);
                }
                else if (currentCommand == "Remove")
                {
                    isChanged = true;
                    int number = int.Parse(commands[1]);
                    numList.Remove(number);
                }
                else if (currentCommand == "RemoveAt")
                {
                    isChanged = true;
                    int index = int.Parse(commands[1]);
                    numList.RemoveAt(index);
                }
                else if (currentCommand == "Insert")
                {
                    isChanged = true;
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    numList.Insert(index, number);
                }
                else if (currentCommand == "Contains")
                {
                    int number = int.Parse(commands[1]);
                    if (numList.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (currentCommand == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ",numList.Where(x => x % 2 == 0)));
                }
                else if (currentCommand == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numList.Where(x => x % 2 != 0)));
                }
                else if (currentCommand == "GetSum")
                {
                    Console.WriteLine(numList.Sum());
                }
                else if (currentCommand == "Filter")
                {
                    string condition = commands[1];
                    int number = int.Parse(commands[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numList.Where(x => x < number)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numList.Where(x => x <= number)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numList.Where(x => x > number)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numList.Where(x => x >= number)));
                    }
                }
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numList));
            }
        }
    }
}
