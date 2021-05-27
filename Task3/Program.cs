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

            while (!WorkFile.CheckFile(filePath))
            {
                Console.Write("Enter file path: ");
                filePath = Console.ReadLine();
            }

            string[] data = WorkFile.Processing(filePath);
            
            DataAnalize dataAnalize = new DataAnalize(data);
            dataAnalize.ParseAll();

            Console.WriteLine("Max Sum: " + dataAnalize.MaxSum);
            Console.WriteLine("Error lines: " + string.Join(", ", dataAnalize.ErrorLines));
        }
    }
}
