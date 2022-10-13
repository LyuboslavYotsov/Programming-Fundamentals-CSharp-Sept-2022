using System;
using System.Linq;
using System.Collections.Generic;

namespace P03MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> listTwo = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < Math.Min(listOne.Count, listTwo.Count); i++)
            {
                resultList.Add(listOne[i]);
                resultList.Add(listTwo[i]);
            }

            if (listOne.Count > listTwo.Count)
            {
                for (int i = listTwo.Count; i < listOne.Count; i++)
                {
                    resultList.Add(listOne[i]);
                }
            }

            else
            {
                for (int i = listOne.Count; i < listTwo.Count; i++)
                {
                    resultList.Add(listTwo[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));

        }  
    }

}
