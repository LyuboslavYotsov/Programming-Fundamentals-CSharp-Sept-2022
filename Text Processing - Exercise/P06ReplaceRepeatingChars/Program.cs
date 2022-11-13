using System;
using System.Text;
namespace P06ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            char currCh = input[0];
            sb.Append(currCh);

            foreach (char ch in input)
            {
                if (currCh == ch)
                {
                    continue;
                }
                else
                {
                    currCh = ch;
                    sb.Append(currCh);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
