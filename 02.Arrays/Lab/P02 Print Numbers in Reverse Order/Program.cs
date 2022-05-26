using System;

namespace P02_Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
