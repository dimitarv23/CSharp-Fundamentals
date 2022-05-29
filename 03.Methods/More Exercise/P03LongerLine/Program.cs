using System;

namespace P03LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = GetLineLength(x1, y1, x2, y2);
            double secondLineLength = GetLineLength(x3, y3, x4, y4);

            if (firstLineLength >= secondLineLength)
            {
                double firstPointDistance = GetPointDistance(x1, y1);
                double secondPointDistance = GetPointDistance(x2, y2);

                if (firstPointDistance <= secondPointDistance)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double firstPointDistance = GetPointDistance(x3, y3);
                double secondPointDistance = GetPointDistance(x4, y4);

                if (firstPointDistance <= secondPointDistance)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
        static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            //Make a triangle with a 90-degree angle and hypotenuse - the length of the line

            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return c;
        }
        static double GetPointDistance(double x1, double y1)
        {
            //Get the line from center to a certain point using a 90-degree angle triangle with hypotenuse - length of line

            double lengthOfLine = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return lengthOfLine;
        }
    }
}
