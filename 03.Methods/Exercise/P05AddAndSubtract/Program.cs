using System;

namespace P05AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = Subtract(Sum(firstNum, secondNum), thirdNum);
            Console.WriteLine(result);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
