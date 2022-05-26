using System;
using System.Linq;

namespace P04_Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < n; rotation++)
            {
                int firstElement = elements[0];

                for (int i = 0; i < elements.Length - 1; i++)
                {
                    elements[i] = elements[i + 1];
                }
                elements[elements.Length - 1] = firstElement;
            }
            Console.WriteLine(String.Join(' ', elements));
        }
    }
}
