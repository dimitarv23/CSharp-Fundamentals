using System;

namespace P03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] directory = Console.ReadLine()
                .Split(new char[] { ':', '\\' }, StringSplitOptions.RemoveEmptyEntries);

            string[] fileInfo = directory[directory.Length - 1].Split('.');
            string fileExtension = fileInfo[fileInfo.Length - 1];
            string fileName = string.Empty;

            for (int i = 0; i < fileInfo.Length - 1; i++)
            {
                fileName += fileInfo[i];
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
