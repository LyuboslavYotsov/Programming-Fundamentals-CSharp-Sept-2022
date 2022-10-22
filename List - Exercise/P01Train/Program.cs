using System;
using System.Linq;
using System.Collections.Generic;

namespace P01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passangersList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');
                if (command.Length == 1)
                {
                    int number = int.Parse(command[0]);
                    for (int i = 0; i < passangersList.Count; i++)
                    {
                        if (passangersList[i] + number <= maxCapacity)
                        {
                            passangersList[i] += number;
                            break;
                        }
                    }
                }
                else if (command.Length == 2)
                {
                    int number = int.Parse(command[1]);
                    passangersList.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", passangersList));

        }
    }
}
