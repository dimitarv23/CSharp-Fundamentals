using System;

namespace P01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int efficiencyPerHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
            int timeNeeded = (int)Math.Ceiling(studentsCount / (double)efficiencyPerHour);

            if (timeNeeded % 3 == 0 && timeNeeded != 0)
            {
                timeNeeded += timeNeeded / 3 - 1;
            }
            else
            {
                timeNeeded += timeNeeded / 3;
            }

            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
