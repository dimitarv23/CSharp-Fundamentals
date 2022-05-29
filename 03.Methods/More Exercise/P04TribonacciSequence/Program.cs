using System;

namespace P04TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(" ", GetTribonacciSequence(num)));
        }
        static int[] GetTribonacciSequence(int num)
        {
            int[] tribonacciSequence = new int[num];

            tribonacciSequence[0] = 1;

            if (num == 1)
            {
                return tribonacciSequence;
            }
            else if (num == 2)
            {
                tribonacciSequence[1] = 1;
                return tribonacciSequence;
            }

            tribonacciSequence[1] = 1;
            tribonacciSequence[2] = 2;

            for (int i = 3; i < num; i++)
            {
                tribonacciSequence[i] = tribonacciSequence[i - 3] + tribonacciSequence[i - 2] + tribonacciSequence[i - 1];
            }
            return tribonacciSequence;
        }
    }
}
