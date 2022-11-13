using System;
using System.Text;

namespace P02RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
