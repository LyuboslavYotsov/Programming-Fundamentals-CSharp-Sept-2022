using System;
using System.Linq;

namespace P09KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLenght = int.Parse(Console.ReadLine());
            string input;
            int bestIndex = int.MaxValue;
            int sequence = 0;
            int bestDna = 0;
            int bestSum = int.MinValue;
            string dna = string.Empty;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                
                int[] array = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (array.Length > sequenceLenght)
                {
                    return;
                }
                sequence++;
                int sum = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] == array[i - 1] && array[i] == 1)
                    {
                        foreach (int item in array)
                        {
                            sum += item;
                        }
                        if (i - 1 < bestIndex)
                        {
                            bestIndex = i - 1;
                            bestDna = sequence;
                            dna = string.Join(" ", array);
                            bestSum = sum;
                        }
                        else if (i - 1 == bestIndex && sum > bestSum)
                        {
                            bestIndex = i - 1;
                            bestDna = sequence;
                            dna = string.Join(" ", array);
                            bestSum = sum;
                        }
                    } 
                }
            }
            Console.WriteLine($"Best DNA sample {bestDna} with sum: {bestSum}.");
            Console.WriteLine(dna);
            
        }
    }
}
