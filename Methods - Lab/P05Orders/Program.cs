using System;

namespace P05Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            CalculatePrice(product, quantity);
           
            
        }
        static double CalculatePrice (string product, int quantity)
        {
            double[] prices = new double[] { 1.50, 1.00, 1.40, 2.00 };
            double totalPrice = 0;

            switch (product)
            {
                case "coffee":
                    totalPrice = quantity * prices[0];
                    break;
                case "water":
                    totalPrice = quantity * prices[1];
                    break;
                case "coke":
                    totalPrice = quantity * prices[2];
                    break;
                case "snacks":
                    totalPrice = quantity * prices[3];
                    break;
            }
            Console.WriteLine($"{totalPrice:f2}");
            return totalPrice;
        }
    }
}
