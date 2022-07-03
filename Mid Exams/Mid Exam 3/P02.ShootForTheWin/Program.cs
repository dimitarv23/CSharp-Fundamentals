using System;
using System.Linq;

namespace P02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotTargets = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                int shotIndex = int.Parse(input);

                //If the index is not valid or it's already shot, read next index
                if (!ValidateIndex(targets, shotIndex))
                {
                    input = Console.ReadLine();
                    continue;
                }

                shotTargets++;
                int valueOfTargetShot = targets[shotIndex];
                targets[shotIndex] = -1;

                for (int i = 0; i < targets.Length; i++)
                {

                    if (targets[i] > valueOfTargetShot && targets[i] != -1)
                    {
                        targets[i] -= valueOfTargetShot;
                        continue;
                    }
                    else if (targets[i] <= valueOfTargetShot && targets[i] != -1)
                    {
                        targets[i] += valueOfTargetShot;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
        static bool ValidateIndex(int[] arr, int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                if (arr[index] == -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
