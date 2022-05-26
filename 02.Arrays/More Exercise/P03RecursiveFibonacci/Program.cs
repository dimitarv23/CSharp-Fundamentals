using System;

namespace P03RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fibonacciNumber = 0;
            int n1 = 1;
            int n2 = 1;

            if (n == 1 || n == 2)
            {
                fibonacciNumber = 1;
            }

            for (int i = 3; i <= n; i++)
            {
                fibonacciNumber = n1 + n2;

                n1 = n2;
                n2 = fibonacciNumber;
            }
            Console.WriteLine(fibonacciNumber);



            //With an array - easier
            //int n = int.Parse(Console.ReadLine());

            //long[] fibonacciSequence = new long[n];
            //fibonacciSequence[0] = 1;

            //if (n > 1)
            //{
            //    fibonacciSequence[1] = 1;

            //    for (int i = 2; i < n; i++)
            //    {
            //        fibonacciSequence[i] = fibonacciSequence[i - 2] + fibonacciSequence[i - 1];
            //    }
            //}
            //Console.WriteLine(fibonacciSequence[n - 1]);
        }
    }
}
