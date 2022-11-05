using System;
using System.Linq;
using System.Collections.Generic;

namespace P01CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            foreach (var item in input)
            {
                if (!numbers.ContainsKey(item))
                {
                    numbers.Add(item, 0);
                }
                numbers[item] += 1;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
