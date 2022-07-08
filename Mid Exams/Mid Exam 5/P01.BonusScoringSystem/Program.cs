using System;

namespace P01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudent = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            
            double maxBonus = 0;
            double maxBonusAttendance = 0;

            for (int i = 1; i <= numberOfStudent; i++)
            {
                int attendanceOfStudent = int.Parse(Console.ReadLine());
                double studentBonus = (double)attendanceOfStudent / numberOfLectures * (5 + additionalBonus);

                if (studentBonus > maxBonus)
                {
                    maxBonus = studentBonus;
                    maxBonusAttendance = attendanceOfStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {Math.Ceiling(maxBonusAttendance)} lectures.");
        }
    }
}
