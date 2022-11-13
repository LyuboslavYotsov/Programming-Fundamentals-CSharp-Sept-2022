using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multipliyer = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            if (number == "0" || multipliyer == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                List<char> numList = number
                    .Reverse()
                    .ToList();
                int reminder = 0;
                foreach (char ch in numList)
                {
                    int currNum = int.Parse(ch.ToString());
                    int result = currNum * multipliyer + reminder;
                    reminder = result / 10;
                    result %= 10;
                    sb.Insert(0, result);
                }
                if (reminder > 0)
                {
                    sb.Insert(0, reminder);
                }
                
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
