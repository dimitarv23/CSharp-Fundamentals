using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int removedElementsSum = 0;

            while (pokemons.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                bool isIndexValid = ValidateIndex(pokemons, ref indexToRemove);
                int catchedPokemon = pokemons[indexToRemove];

                if (isIndexValid)
                {
                    pokemons.RemoveAt(indexToRemove);
                }

                for (int curr = 0; curr < pokemons.Count; curr++)
                {
                    if (pokemons[curr] <= catchedPokemon)
                    {
                        pokemons[curr] += catchedPokemon;
                    }
                    else
                    {
                        pokemons[curr] -= catchedPokemon;
                    }
                }

                removedElementsSum += catchedPokemon;
            }
            Console.WriteLine(removedElementsSum);
        }

        //Validates the index and returns true if the index is valid
        static bool ValidateIndex(List<int> data, ref int index)
        {
            if (index < 0)
            {
                index = 0;
                data.RemoveAt(index);
                data.Insert(index, data.Last());
                return false;
            }
            else if (index >= data.Count)
            {
                index = data.Count - 1;
                data.RemoveAt(index);
                data.Add(data.First());
                return false;
            }

            return true;
        }
    }
}
