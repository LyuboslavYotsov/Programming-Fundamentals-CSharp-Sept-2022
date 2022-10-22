using System;
using System.Linq;
using System.Collections.Generic;
namespace P03Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double average = numList.Average(); 
            int topNumber = int.MaxValue;
            
            List<int> topNumbers = new List<int>();

            for (int i = 0; i < numList.Count; i++)
            {
                
                if (numList[i] > average)
                {
                    topNumber = numList[i];
                    topNumbers.Add(numList[i]);
                }
            }
            if (topNumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            topNumbers.Sort();
            topNumbers.Reverse();
            

            if (topNumbers.Count > 5)
            {
                topNumbers.RemoveRange(5, topNumbers.Count - 5);
            }

            

            Console.WriteLine(String.Join(" ", topNumbers));

        }
    }
}
