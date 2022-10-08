using System;
using System.Linq;

namespace P11ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mainArr = (Console.ReadLine())
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input
                    .Split(" ");

                if (inputArr[0] == "exchange")
                {
                    int index = int.Parse(inputArr[1]);
                    if (index >= mainArr.Length || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    mainArr = ExchangeArray(mainArr, index);

                }
                else if (inputArr[0] == "max" && inputArr[1] == "even" || inputArr[1] == "odd")
                {
                    string type = inputArr[1];
                    int bestIndex = GetMaxEvenOrOdd(mainArr, type);
                    if (bestIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(bestIndex);
                    }
                }
                else if (inputArr[0] == "min" && inputArr[1] == "even" || inputArr[1] == "odd")
                {
                    string type = inputArr[1];
                    int bestIndex = GetMinEvenOrOdd(mainArr, type);
                    if (bestIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(bestIndex);
                    }
                }
                else if (inputArr[0] == "first")
                {

                    int count = int.Parse(inputArr[1]);
                    if (count > mainArr.Length || count <= 0)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string type = inputArr[2];
                    int[] firstNums = GetFirstNEvenOrOdd(mainArr, type, count);
                    Console.WriteLine($"[{String.Join(", ", firstNums)}]");

                }
                else if (inputArr[0] == "last")
                {
                    int count = int.Parse(inputArr[1]);
                    if (count > mainArr.Length || count <= 0)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string type = inputArr[2];
                    int[] lastNums = GetLastNEvenOrOdd(mainArr, type,count);
                    Console.WriteLine($"[{String.Join(", ", lastNums)}]");
                }

            }
            Console.WriteLine($"[{String.Join(", ", mainArr)}]");
        }
        static int[] ExchangeArray(int[] mainArr, int index)
        {
            int[] copyArr = new int[mainArr.Length];
            int copyIndex = 0;
            for (int i = index + 1; i < mainArr.Length; i++)
            {
                copyArr[copyIndex++] = mainArr[i];
            }
            for (int j = 0; j <= index; j++)
            {
                copyArr[copyIndex++] = mainArr[j];
            }
            return copyArr;
        }

        static int GetMaxEvenOrOdd(int[] mainArr, string type)
        {
            int max = int.MinValue;
            int bestIndex = -1;
            if (type == "even")
            {
                for (int i = 0; i < mainArr.Length; i++)
                {
                    if (mainArr[i] % 2 != 0)
                    {
                        continue;
                    }
                    if (mainArr[i] >= max)
                    {
                        max = mainArr[i];
                        bestIndex = i;
                    }
                }
                return bestIndex;
            }

            else
            {
                for (int i = 0; i < mainArr.Length; i++)
                {
                    if (mainArr[i] % 2 == 0)
                    {
                        continue;
                    }
                    if (mainArr[i] >= max)
                    {
                        max = mainArr[i];
                        bestIndex = i;
                    }
                }
                return bestIndex;
            }
        }

        static int GetMinEvenOrOdd(int[] mainArr, string type)
        {
            int min = int.MaxValue;
            int bestIndex = -1;
            if (type == "even")
            {
                for (int i = 0; i < mainArr.Length; i++)
                {
                    if (mainArr[i] % 2 != 0)
                    {
                        continue;
                    }
                    if (mainArr[i] <= min)
                    {
                        min = mainArr[i];
                        bestIndex = i;
                    }
                }
                return bestIndex;
            }

            else
            {
                for (int i = 0; i < mainArr.Length; i++)
                {
                    if (mainArr[i] % 2 == 0)
                    {
                        continue;
                    }
                    if (mainArr[i] <= min)
                    {
                        min = mainArr[i];
                        bestIndex = i;
                    }
                }
                return bestIndex;
            }
        }

        static int[] GetFirstNEvenOrOdd(int[] mainArr, string type, int count)
        {
            int[] copyArr = new int[count];
            int matches = 0;
            int copyIndex = 0;

            if (type == "even")
            {
                for (int i = 0; i < mainArr.Length; i++)
                {
                    if (matches >= count)
                    {
                        break;
                    }
                    if (mainArr[i] % 2 == 0)
                    {
                        copyArr[copyIndex++] = mainArr[i];
                        matches++;
                    }
                }
                int[] condensed = new int[matches];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = copyArr[i];
                }
                copyArr = condensed;

                return copyArr;
            }
            else
            {
                for (int i = 0; i < mainArr.Length; i++)
                {
                    if (matches >= count)
                    {
                        break;
                    }
                    if (mainArr[i] % 2 != 0)
                    {
                        copyArr[copyIndex++] = mainArr[i];
                        matches++;
                    }
                }
                int[] condensed = new int[matches];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = copyArr[i];
                }
                copyArr = condensed;

                return copyArr;
            }
        }

        static int[] GetLastNEvenOrOdd(int[] mainArr, string type, int count)
        {
            int[] copyArr = new int[count];
            int matches = 0;
            int copyIndex = 0;

            if (type == "even")
            {
                for (int i = mainArr.Length - 1; i >= 0; i--)
                {
                    if (mainArr[i] % 2 == 0)
                    {
                        copyArr[copyIndex++] = mainArr[i];
                        matches++;
                    }
                }
                int[] condensed = new int[matches];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = copyArr[i];
                }
                copyArr = condensed;
                Array.Reverse(copyArr);
                return copyArr;
            }
            else
            {
                for (int i = mainArr.Length - 1; i >= 0; i--)
                {
                    if (mainArr[i] % 2 != 0)
                    {
                        copyArr[copyIndex++] = mainArr[i];
                        matches++;
                    }
                }
                int[] condensed = new int[matches];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = copyArr[i];
                }
                copyArr = condensed;
                Array.Reverse(copyArr);
                return copyArr;
                
            }
        }
    }
}
