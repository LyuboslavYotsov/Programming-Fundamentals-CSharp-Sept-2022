using System;
using System.Linq;
using System.Collections.Generic;

namespace P09PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> pokemonField = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (pokemonField.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    sum = NegativeIndex(pokemonField, sum);
                    continue;
                }

                else if (index >= pokemonField.Count)
                {
                    sum = IndexGreaterThenCount(pokemonField, sum);
                    continue;
                }

                sum = ChangeElementsValue(pokemonField, sum, index);

            }
            Console.WriteLine(sum);
        }

        private static int ChangeElementsValue(List<int> pokemonField, int sum, int index)
        {
            int number = pokemonField[index];

            sum += pokemonField[index];
            pokemonField.RemoveAt(index);

            for (int i = 0; i < pokemonField.Count; i++)
            {
                if (pokemonField[i] <= number)
                {
                    pokemonField[i] += number;
                }
                else if (pokemonField[i] > number)
                {
                    pokemonField[i] -= number;
                }
            }

            return sum;
        }

        private static int IndexGreaterThenCount(List<int> pokemonField, int sum)
        {
            int value = pokemonField[pokemonField.Count - 1];
            sum += pokemonField[pokemonField.Count - 1];
            pokemonField.RemoveAt(pokemonField.Count - 1);
            pokemonField.Add(pokemonField[0]);
            for (int i = 0; i < pokemonField.Count; i++)
            {
                if (pokemonField[i] <= value)
                {
                    pokemonField[i] += value;
                }
                else if (pokemonField[i] > value)
                {
                    pokemonField[i] -= value;
                }
            }

            return sum;
        }

        private static int NegativeIndex(List<int> pokemonField, int sum)
        {
            int value = pokemonField[0];
            pokemonField.Insert(0, pokemonField[pokemonField.Count - 1]);
            sum += pokemonField[1];
            pokemonField.RemoveAt(1);

            for (int i = 0; i < pokemonField.Count; i++)
            {
                if (pokemonField[i] <= value)
                {
                    pokemonField[i] += value;
                }
                else if (pokemonField[i] > value)
                {
                    pokemonField[i] -= value;
                }
            }

            return sum;
        }
    }
}
