using System;
using System.Collections.Generic;

namespace P01CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charOccurance = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];
                if (currCh == ' ')
                {
                    continue;
                }
                if (!charOccurance.ContainsKey(currCh))
                {
                    charOccurance.Add(currCh, 0);
                }
                charOccurance[currCh]++;
            }
            foreach (var @char in charOccurance)
            {
                Console.WriteLine($"{@char.Key} -> {@char.Value}");
            }
        }
    }
}
