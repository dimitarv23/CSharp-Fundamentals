using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort centuries = ushort.Parse(Console.ReadLine());
            uint years = centuries * 100u;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
