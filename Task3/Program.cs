using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "";
            if (args.Length > 0)
                filePath = args[0];

            while (!CheckFile(filePath))
            {
                Console.Write("Enter file path: ");
                filePath = Console.ReadLine();
            }

            string[] data = ReadFile.Processing(filePath);
            
            DataAnalize dataAnalize = new DataAnalize(data);
            dataAnalize.ParseAll();

            Console.WriteLine("Max Sum: " + dataAnalize.MaxSum);
            Console.WriteLine("Error lines: " + string.Join(", ", dataAnalize.ErrorLines));
        }

        private static bool CheckFile(string path)
        {
            return File.Exists(path);
        }
    }
}
