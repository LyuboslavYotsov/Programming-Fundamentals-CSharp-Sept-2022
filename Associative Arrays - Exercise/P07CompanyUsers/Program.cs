using System;
using System.Collections.Generic;
namespace P07CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input
                    .Split(" -> ");
                string companyName = commandArgs[0];
                string employeeId = commandArgs[1];

                if (!companyEmployees.ContainsKey(companyName))
                {
                    companyEmployees[companyName] = new List<string>();
                }
                if (!companyEmployees[companyName].Contains(employeeId))
                {
                    companyEmployees[companyName].Add(employeeId);
                }
            }

            foreach (var company in companyEmployees)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
