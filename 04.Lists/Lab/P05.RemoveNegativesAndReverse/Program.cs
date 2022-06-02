using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(x => x < 0);

            //The same as the upper one:
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] < 0)
            //    {
            //        numbers.RemoveAt(i);
            //    }
            //}

            numbers.Reverse();

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
