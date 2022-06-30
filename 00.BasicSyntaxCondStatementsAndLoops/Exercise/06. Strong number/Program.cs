using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());

            uint currNum = num;
            ulong factorialSum = 0;

            while (currNum != 0)
            {
                uint currDigit = currNum % 10;
                currNum /= 10;

                ulong currentFactorial = 1;

                for (uint i = currDigit; i > 1; i--)
                {
                    currentFactorial *= i;
                }
                factorialSum += currentFactorial;
            }

            if (factorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
