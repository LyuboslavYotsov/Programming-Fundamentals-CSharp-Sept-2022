using System;
using System.Linq;

namespace P02ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commArg = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commArg[0];

                if (command == "swap")
                {
                    numbArr = SwapIndexes(numbArr, commArg);
                }

                else if (command == "multiply")
                {
                    numbArr = MultiplyIndexes(numbArr, commArg);
                }

                else if (command == "decrease")
                {
                    numbArr = DecreaseValueOfElements(numbArr);
                }


            }
            Console.WriteLine(String.Join(", ", numbArr));
        }

        private static int[] DecreaseValueOfElements(int[] numbArr)
        {
            int[] modArr = new int[numbArr.Length];

            for (int i = 0; i < modArr.Length; i++)
            {
                modArr[i] = numbArr[i] - 1;
            }

            numbArr = modArr;
            return numbArr;
        }

        private static int[] MultiplyIndexes(int[] numbArr, string[] commArg)
        {
            int firstIndex = int.Parse(commArg[1]);
            int secondIndex = int.Parse(commArg[2]);

            int result = numbArr[firstIndex] * numbArr[secondIndex];
            int[] modArr = new int[numbArr.Length];

            for (int i = 0; i < numbArr.Length; i++)
            {
                if (i == firstIndex)
                {
                    modArr[i] = result;
                    continue;
                }
                modArr[i] = numbArr[i];
            }
            numbArr = modArr;
            return numbArr;
        }

        private static int[] SwapIndexes(int[] numbArr, string[] commArg)
        {
            int firstIndex = int.Parse(commArg[1]);
            int secondIndex = int.Parse(commArg[2]);

            int[] modArray = new int[numbArr.Length];

            for (int i = 0; i < numbArr.Length; i++)
            {
                if (i == firstIndex)
                {
                    modArray[i] = numbArr[secondIndex];
                    continue;
                }
                else if (i == secondIndex)
                {
                    modArray[i] = numbArr[firstIndex];
                    continue;
                }
                modArray[i] = numbArr[i];
            }
            numbArr = modArray;
            return numbArr;
        }
    }
}
