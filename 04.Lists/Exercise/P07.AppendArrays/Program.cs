using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersList = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            numbersList.Reverse();

            List<int> result = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                List<int> currentSubList = numbersList[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < currentSubList.Count; j++)
                {
                    result.Add(currentSubList[j]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
