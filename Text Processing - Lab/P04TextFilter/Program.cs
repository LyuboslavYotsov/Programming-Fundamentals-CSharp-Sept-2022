using System;

namespace P04TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
                .Split(", ");

            string text = Console.ReadLine();

            foreach (var word in banWords)
            {
                string censorWord = new string('*', word.Length);
                text = text.Replace(word, censorWord);
            }
            Console.WriteLine(text);
        }
    }
}
