using System;
using System.Text;

namespace P04CeasarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char currCh in text)
            {
                int currPos = currCh + 3;
                char newCh = (char)currPos;
                sb.Append(newCh);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
