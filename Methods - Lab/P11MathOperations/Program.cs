using System;

namespace P11MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = Divide(firstNum, secondNum);
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = Multiply(firstNum, secondNum);
                    Console.WriteLine(result);
                    break;
                case "+":
                    result = Add(firstNum, secondNum);
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = Subtract(firstNum, secondNum);
                    Console.WriteLine(result);
                    break;
            }

        }

        static double Divide(double firstnum, double secondNum)
        {
            return firstnum / secondNum;
            
        }
        static double Multiply(double firstnum, double secondNum)
        {
            return firstnum * secondNum;
        }
        
        static double Add(double firstnum, double secondNum)
        {
            return firstnum + secondNum;
        }

        static double Subtract(double firstnum, double secondNum)
        {
            return firstnum - secondNum;
        }
    }
}
