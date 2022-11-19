using System;
using System.Text.RegularExpressions;

namespace P03SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(^\||\$|\%|.)*?\%(?<customer>[A-Z][a-z]+)\%(^\||\$|\%|.)*?\<(?<product>\w+)\>(^\||\$|\%|.)*?(^\||\$|\%|.)*?\|(?<count>\d+)\|(^|\$|\%|.)*?(?<price>\d+(\.\d+)*)\$(^\||\$|\%|.)*$";
            double totalIncome = 0;

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;

                    double count = double.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double totalPrice = count * price;
                    totalIncome += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
