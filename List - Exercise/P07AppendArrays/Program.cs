using System;
using System.Linq;
using System.Collections.Generic;

namespace P07AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringsList = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> SubList = new List<string>();
            for (int i = stringsList.Count - 1; i >= 0; i--)
            {
                string[] currString = stringsList[i].Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < currString.Length; j++)
                {
                    SubList.Add(currString[j]);
                }
            }
            
            Console.WriteLine(string.Join(" ",SubList));
        }
    }
}
