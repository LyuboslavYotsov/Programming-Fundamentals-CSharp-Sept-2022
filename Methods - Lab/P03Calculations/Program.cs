using System;

namespace P03Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    add(a, b);
                    break;
                case "subtract":
                    subtract(a, b);
                    break;
                case "multiply":
                    multiply(a, b);
                    break;
                case "divide":
                    devide(a, b);
                    break;
            }
        }
        static void add (int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        static void subtract (int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        static void multiply (int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        static void devide (int a, int b)
        {
            double result = (double)a / (double)b;
            Console.WriteLine(result);
        }
    }
}
