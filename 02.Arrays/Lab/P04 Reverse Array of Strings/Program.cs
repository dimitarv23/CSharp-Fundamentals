using System;
using System.Linq;

namespace P04_Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //string[] reversedElements = new string[elements.Length];

            //for (int i = 0; i < reversedElements.Length; i++)
            //{
            //    reversedElements[i] = elements[(elements.Length - 1) - i];
            //}
            //Console.WriteLine(String.Join(' ', reversedElements));

            Array.Reverse(elements);

            Console.WriteLine(String.Join(' ', elements));
        }
    }
}
