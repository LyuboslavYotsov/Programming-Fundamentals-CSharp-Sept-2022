using System;

namespace P08MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());
            double result = MathPowFromNum(baseNum, powerNum);
            Console.WriteLine(result);

        }

        private static double MathPowFromNum(double baseNum, double powerNum)
        {
            double result = Math.Pow(baseNum, powerNum);
            return result;
        }
    }
}
