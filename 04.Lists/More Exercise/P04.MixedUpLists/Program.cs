using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            secondList.Reverse(); //The second list is always taken in a reverse order

            int startRange = 0;
            int endRange = 0;

            //Set values to the start and the end of a range
            if (firstList.Count > secondList.Count)
            {
                startRange = firstList[firstList.Count - 1];
                firstList.RemoveAt(firstList.Count - 1);
                endRange = firstList[firstList.Count - 1];
                firstList.RemoveAt(firstList.Count - 1);
            }
            else
            {
                startRange = secondList[secondList.Count - 1];
                secondList.RemoveAt(secondList.Count - 1);
                endRange = secondList[secondList.Count - 1];
                secondList.RemoveAt(secondList.Count - 1);
            }

            //if the start of the range is greater than the end, reverse them
            if (startRange > endRange)
            {
                int temp = startRange;
                startRange = endRange;
                endRange = temp;
            }

            List<int> mixedList = new List<int>();

            //Fill the new list with the elements that fulfill the range (greater than start and smaller than end)
            for (int i = 0; i < firstList.Count; i++)
            {
                int firstListElement = firstList[i];

                if (firstListElement > startRange && firstListElement < endRange)
                {
                    mixedList.Add(firstListElement);
                }

                int secondListElement = secondList[i];

                if (secondListElement > startRange && secondListElement < endRange)
                {
                    mixedList.Add(secondListElement);
                }
            }

            mixedList.Sort();
            Console.WriteLine(string.Join(" ", mixedList));
        }
    }
}
