using System;
using System.Linq;
namespace P08CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            while (numArr.Length > 1)
            {
                int[] condensedArr = new int[numArr.Length - 1];
                for (int i = 0; i < numArr.Length - 1; i++)
                {
                    condensedArr[i] = numArr[i] + numArr[i + 1];
                }
                numArr = condensedArr;
                
            }
            Console.WriteLine(numArr[0]);
        }
    }
}
