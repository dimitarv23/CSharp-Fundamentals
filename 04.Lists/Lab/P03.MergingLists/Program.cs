using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int iterations = Math.Min(firstList.Count, secondList.Count);

            List<int> resultList = new List<int>();

            for (int i = 0; i < iterations; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                //for (int i = secondList.Count; i < firstList.Count; i++)
                //{
                //    resultList.Add(firstList[i]);
                //}

                resultList.AddRange(firstList.Skip(secondList.Count));
            }
            else if (secondList.Count > firstList.Count)
            {
                //for (int i = firstList.Count; i < secondList.Count; i++)
                //{
                //    resultList.Add(secondList[i]);
                //}

                resultList.AddRange(secondList.Skip(firstList.Count));
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
