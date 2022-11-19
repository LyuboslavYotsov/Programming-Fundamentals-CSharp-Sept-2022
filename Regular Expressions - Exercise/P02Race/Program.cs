namespace P02Race
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(", ");
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string namePattern = @"[A-Za-z]+";
            string distancePattern = @"\d+";
            Regex nameRegex = new Regex(namePattern);
            Regex distanceRegex = new Regex(distancePattern);
            foreach (var participant in participants)
            {
                racers.Add(participant, 0);
            }
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder nameBuilder = new StringBuilder();
                StringBuilder digits = new StringBuilder();
                MatchCollection nameMatches = nameRegex.Matches(input);
                MatchCollection distanceMatches = distanceRegex.Matches(input);
                foreach (Match namematch in nameMatches)
                {
                    nameBuilder.Append(namematch.Value);
                }
                string name = nameBuilder.ToString();
                foreach (Match digit in distanceMatches)
                {
                    digits.Append(digit.Value);
                }
                string numbers = digits.ToString();
                if (racers.ContainsKey(name))
                {
                    int distance = 0;
                    foreach (var digit in numbers)
                    {
                        int num = int.Parse(digit.ToString());
                        distance += num;
                    }
                    racers[name] += distance;
                }
            }
            var ordered = racers
                .OrderByDescending(x => x.Value)
                .Take(3);
            int count = 1;
            string pos = "st";
            foreach (var racer in ordered)
            {
                if (count == 2)
                {
                    pos = "nd";
                }
                else if (count == 3)
                {
                    pos = "rd";
                }
                Console.WriteLine($"{count}{pos} place: {racer.Key}");
                count++;
            }
            //foreach (var racer in racers)
            //{
            //    Console.WriteLine($"{racer.Key}:{racer.Value}");
            //}
        }
    }
}
