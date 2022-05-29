using System;

namespace P01SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmallestNumber(firstNumber, secondNumber, thirdNumber));
        }
        static int GetSmallestNumber(int n1, int n2, int n3)
        {
            return Math.Min(Math.Min(n1, n2), n3);
        }
    }
}
