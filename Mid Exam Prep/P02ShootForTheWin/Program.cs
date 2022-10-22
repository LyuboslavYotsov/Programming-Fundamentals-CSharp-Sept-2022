using System;
using System.Linq;

namespace P02ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int shotTargets = 0;
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                if (index < 0 || index >= targets.Length)
                {
                    continue;
                }

                int value = targets[index];

                if (targets[index] != -1)
                {
                    targets[index] = -1;
                    shotTargets++;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > value && targets[i] != -1)
                        {
                            targets[i] -= value;
                        }
                        else if (targets[i] <= value && targets[i] != -1)
                        {
                            targets[i] += value;
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
    }
}
