using System;
using System.Linq;

namespace P00LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] field = new int[n];
            //bool[] boolField = new bool[n];

            int[] initialIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (int index in initialIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] commandArg = comand
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int ladyBugIndex = int.Parse(commandArg[0]);
                string directions = commandArg[1];
                int flyLenghts = int.Parse(commandArg[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    continue;
                }

                if (field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (directions == "left")
                {
                    flyLenghts *= -1;
                }

                int nextIndex = ladyBugIndex + flyLenghts;

                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLenghts;
                }

                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    continue;
                }

                field[nextIndex] = 1;


            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
