using System;

namespace P02CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPoint = GetPointDistance(x1, y1);
            double secondPoint = GetPointDistance(x2, y2);

            if (firstPoint <= secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
        static double GetPointDistance(double x1, double y1)
        {
            //Get the line from center to a certain point using a 90-degree angle triangle with hypotenuse - length of line

            double lengthOfLine = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return lengthOfLine;
        }
    }
}
