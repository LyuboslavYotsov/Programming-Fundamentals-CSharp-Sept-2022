using System;
using System.Linq;

namespace P01RanomizrWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ")
                .ToArray();

            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomNum = random.Next(0, words.Length);
                string currWord = words[i];
                string newWord = words[randomNum];
                words[i] = newWord;
                words[randomNum] = currWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
