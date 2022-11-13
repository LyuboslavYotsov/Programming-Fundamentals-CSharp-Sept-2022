using System;
using System.Diagnostics;
using System.Text;

namespace P05DigitLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];
                if (char.IsDigit(currCh))
                {
                 digits.Append(currCh);
                }
                else if (char.IsLetter(currCh))
                {
                    letters.Append(currCh);
                }
                else if (!char.IsLetterOrDigit(currCh))
                {
                    others.Append(currCh);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
