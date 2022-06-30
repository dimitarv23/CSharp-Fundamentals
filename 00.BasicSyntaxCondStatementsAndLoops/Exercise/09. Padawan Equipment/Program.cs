using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double lightsabersTotal = Math.Ceiling(numberOfStudents * 1.1) * priceOfLightsaber;
            double robeTotal = numberOfStudents * priceOfRobe;
            double beltTotal = (numberOfStudents - numberOfStudents / 6) * priceOfBelt;
            double total = lightsabersTotal + robeTotal + beltTotal;

            if (budget >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - budget:f2}lv more.");
            }
        }
    }
}
