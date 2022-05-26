using System;
using System.Linq;

namespace P08_Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j] + numbers[j + 1];
                }
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
