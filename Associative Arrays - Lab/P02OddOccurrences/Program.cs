using System;
using System.Linq;
using System.Collections.Generic;

namespace P02OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ");
            
            
            Dictionary<string, int> oddWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerWord = word.ToLower();
                if (!oddWords.ContainsKey(lowerWord))
                {
                    oddWords.Add(lowerWord, 0);
                }
                oddWords[lowerWord] += 1;
            }

            foreach (var item in oddWords)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
                
        }
    }
}
