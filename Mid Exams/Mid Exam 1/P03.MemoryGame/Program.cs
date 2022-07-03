using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int moves = 0;
            string input = Console.ReadLine();

            while (input != "end")
            {
                int[] indexes = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                moves++;
                bool checkFirstIndex = ValidateIndex(elements.Count, indexes[0]);
                bool checkSecondIndex = ValidateIndex(elements.Count, indexes[1]);

                //If the player tries to cheat
                if (indexes[0] == indexes[1] || !checkFirstIndex || !checkSecondIndex)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    string[] insertion = { $"-{moves}a", $"-{moves}a" };
                    elements.InsertRange(elements.Count / 2, insertion);
                    input = Console.ReadLine();
                    continue;
                }

                //The player found equal elements
                if (elements[indexes[0]] == elements[indexes[1]])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[indexes[0]]}!");

                    //If the first given index is smaller, replace them
                    if (indexes[0] < indexes[1])
                    {
                        ReplaceIndexes(ref indexes[0], ref indexes[1]);
                    }

                    elements.RemoveAt(indexes[0]);
                    elements.RemoveAt(indexes[1]);

                    //The player has won the game
                    if (elements.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                input = Console.ReadLine();
            }

            //The player has lost the game
            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }

        //Checks whether an index lies inside a collection
        static bool ValidateIndex(int length, int index)
        {
            if (index >= 0 && index < length)
            {
                return true;
            }
            return false;
        }

        //Replaces indexes
        static void ReplaceIndexes(ref int index1, ref int index2)
        {
            int temp = index1;
            index1 = index2;
            index2 = temp;
        }
    }
}
