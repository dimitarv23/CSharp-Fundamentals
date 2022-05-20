using System;

namespace P03_Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfpeople = int.Parse(Console.ReadLine());
            byte elevatorCapacity = byte.Parse(Console.ReadLine());

            ushort courses = (ushort)Math.Ceiling((double)numberOfpeople / elevatorCapacity);

            Console.WriteLine(courses);
        }
    }
}
