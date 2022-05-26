using System;
using System.Linq;

namespace P01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] peopleInEachWagon = new int[n];
            int peopleInTrain = 0;

            for (int i = 0; i < n; i++)
            {
                peopleInEachWagon[i] = int.Parse(Console.ReadLine());
                peopleInTrain += peopleInEachWagon[i];
            }
            Console.WriteLine(String.Join(' ', peopleInEachWagon));
            Console.WriteLine(peopleInTrain);
        }
    }
}
