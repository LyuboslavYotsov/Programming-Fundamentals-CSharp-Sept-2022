using System;

namespace P09GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            if (type == "int")
            {
                int firstInt = int.Parse(value1);
                int secondInt = int.Parse(value2);

                int reuslt = GetMax(firstInt, secondInt);
                Console.WriteLine(reuslt);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(value1);
                char secondChar = char.Parse(value2);

                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string result = GetMax(value1, value2);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) == 1)
            {
                return a;
            }
            return b;
        }
    }
}
