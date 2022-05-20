using System;

namespace P01_Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataType = string.Empty;

            while (input != "END")
            {
                //bool checkInt = int.TryParse(input, out int value);

                if (int.TryParse(input, out _))
                {
                    dataType = "integer";
                }
                else if (double.TryParse(input, out _))
                {
                    dataType = "floating point";
                }
                else if (char.TryParse(input, out _))
                {
                    dataType = "character";
                }
                else if (bool.TryParse(input, out _))
                {
                    dataType = "boolean";
                }
                else
                {
                    dataType = "string";
                }

                Console.WriteLine($"{input} is {dataType} type");

                input = Console.ReadLine();
            }
        }
    }
}
