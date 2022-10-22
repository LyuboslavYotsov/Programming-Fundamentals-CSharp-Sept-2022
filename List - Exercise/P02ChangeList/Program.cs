using System;
using System.Linq;
using System.Collections.Generic;

namespace P02ChangeList
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
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ");
                string command = commands[0];

                if (command == "Delete")
                {
                    int number = int.Parse(commands[1]);
                    numList.RemoveAll(x => x == number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    numList.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
