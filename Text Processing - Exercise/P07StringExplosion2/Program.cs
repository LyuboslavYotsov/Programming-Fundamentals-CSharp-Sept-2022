using System;
using System.Text;
namespace P07StringExplosion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int bombPower = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];
                if (currCh == '>')
                {
                    sb.Append(currCh);
                }
                else if (char.IsDigit(currCh))
                {
                    bombPower += int.Parse(currCh.ToString());
                    bombPower--;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                        continue;
                    }
                    else
                    {
                        sb.Append(currCh);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
