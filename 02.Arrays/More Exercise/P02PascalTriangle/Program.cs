using System;

namespace P02PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[] lastRowElements = { 0 };

            for (int row = 0; row < n; row++)
            {
                long[] currentRowElements = new long[row + 1];
                currentRowElements[0] = 1;
                currentRowElements[row] = 1;

                for (int col = 1; col < row; col++)
                {
                    currentRowElements[col] = lastRowElements[col] + lastRowElements[col - 1];
                }
                Console.WriteLine(String.Join(" ", currentRowElements));

                lastRowElements = currentRowElements;
            }
        }
    }
}
