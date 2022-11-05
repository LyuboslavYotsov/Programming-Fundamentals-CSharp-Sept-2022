using System;
using System.Collections.Generic;

namespace P03Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> productsInfo = new Dictionary<string, double[]>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] commArgs = input
                    .Split(' ');

                string product = commArgs[0];
                double price = double.Parse(commArgs[1]);
                double quantity = double.Parse(commArgs[2]);

                if (!productsInfo.ContainsKey(product))
                {
                    productsInfo[product] = new double[2];
                }
                productsInfo[product][0] = price;
                productsInfo[product][1] += quantity;
            }

            foreach (var kvp in productsInfo)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value[0] * kvp.Value[1]):f2}");
            }
        }
    }
}
