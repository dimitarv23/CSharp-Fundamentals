using System;
using System.Linq;
using System.Text;

namespace P05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            int leftover = 0;

            if (multiplier == 0)
            {
                result.Append(0);
            }
            else
            {
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    int currDigit = int.Parse(number[i].ToString());
                    int currNumber = currDigit * multiplier + leftover;

                    result.Append(currNumber % 10);
                    leftover = currNumber / 10;
                }

                if (leftover != 0)
                {
                    result.Append(leftover);
                }
            }

            char[] reversed = result.ToString().ToCharArray();
            Array.Reverse(reversed);

            Console.WriteLine(string.Join("", reversed));
        }
    }
}
