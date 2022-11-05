using System;

namespace P10LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputChar = char.Parse(Console.ReadLine());

            if ((int)inputChar >= 97)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
