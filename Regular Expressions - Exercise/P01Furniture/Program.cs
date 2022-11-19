using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace P01Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\>\>(?<product>[A-Za-z]+)\<\<(?<price>\d+(\.\d+)*)\!(?<quantity>\d+)";
            Regex regex = new Regex(pattern);
            List<string> furnitureList = new List<string>();
            double totalMoney = 0;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string furnitureName = match.Groups["product"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    totalMoney += price * quantity;
                    furnitureList.Add(furnitureName);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (string item in furnitureList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
