using System;
using System.Linq;

namespace P03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "find")
            {
                if (input.Length > key.Length)
                {
                    bool flag = false;

                    for (int i = 0; i < Math.Ceiling((double)input.Length / key.Length); i++)
                    {
                        for (int j = 0; j < key.Length; j++)
                        {
                            int indexInString = (key.Length * i) + j;

                            if (indexInString >= input.Length)
                            {
                                flag = true;
                                break; 
                            }

                            string newItem = ((char)(input[indexInString] - key[j])).ToString();
                            input = input.Remove(indexInString, 1);
                            input = input.Insert(indexInString, newItem);
                        }

                        if (flag)
                        {
                            break;
                        }
                    }
                }
                else
                {

                }

                int indexOfAnd = input.IndexOf('&');
                int lastIndexOfAnd = input.LastIndexOf('&');
                string treasureName = input.Substring(indexOfAnd + 1, lastIndexOfAnd - indexOfAnd - 1);

                int indexOfSmaller = input.IndexOf('<');
                int indexOfLarger = input.IndexOf('>');
                string treasureCoordinates = input.Substring(indexOfSmaller + 1, indexOfLarger - indexOfSmaller - 1);

                Console.WriteLine($"Found {treasureName} at {treasureCoordinates}");

                input = Console.ReadLine();
            }
        }
    }
}
