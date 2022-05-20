using System;

namespace P01_Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int forthNum = int.Parse(Console.ReadLine());

            long operation1 = firstNum + secondNum;
            long operation2 = operation1 / thirdNum;
            long operation3 = operation2 * forthNum;

            Console.WriteLine(operation3);
        }
    }
}
