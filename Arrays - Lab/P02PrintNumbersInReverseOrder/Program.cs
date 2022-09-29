using System;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] numArr = new int[numbers];

            for (int i = 0; i < numArr.Length; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                numArr[i] = currNum;
            }

            for (int i = numArr.Length - 1; i >= 0; i--)
            {
                Console.Write(numArr[i]+ " ");
            }
        }
    }    
}        
         