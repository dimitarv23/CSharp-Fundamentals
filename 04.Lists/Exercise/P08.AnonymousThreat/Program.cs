using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] cmdArgs = input.Split();
                string action = cmdArgs.First();

                if (action == "merge")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int lastIndex = int.Parse(cmdArgs[2]);

                    if (ValidateAndRepairIndexes(names.Count, ref firstIndex, ref lastIndex))
                    {
                        MergeRange(names, firstIndex, lastIndex);
                    }
                }
                else if (action == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int parts = int.Parse(cmdArgs[2]);

                    DivideElement(names, index, parts);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", names));
        }
        static void MergeRange(List<string> data, int startIndex, int endIndex)
        {
            StringBuilder itemsToMerge = new StringBuilder();
            int mergedItems = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                itemsToMerge.Append(data[i]);
                mergedItems++;
            }

            data.RemoveRange(startIndex, mergedItems);
            data.Insert(startIndex, itemsToMerge.ToString());
        }

        static void DivideElement(List<string> data, int index, int parts)
        {
            List<char> elementToDivide = data[index]
                .ToCharArray()
                .ToList();

            data.RemoveAt(index);

            int indexToInsertAt = index;
            int lengthOfParts = elementToDivide.Count / parts;

            for (int i = 1; i < parts; i++)
            {
                string currentPart = string.Empty;

                for (int j = 0; j < lengthOfParts; j++)
                {
                    currentPart += elementToDivide[j];
                }

                elementToDivide.RemoveRange(0, lengthOfParts);

                data.Insert(indexToInsertAt, currentPart);
                indexToInsertAt++;
            }
            data.Insert(indexToInsertAt, string.Join("", elementToDivide));
        }

        //If an index is outside the bonds of a collection, set it to a valid index that is inside the collection
        static bool ValidateAndRepairIndexes(int boundsOfCollection, ref int startIndex, ref int endIndex)
        {
            if (endIndex < 0)
            {
                return false;
            }
            if (startIndex >= boundsOfCollection)
            {
                return false;
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= boundsOfCollection)
            {
                endIndex = boundsOfCollection - 1;
            }
            return true;
        }
    }
}
