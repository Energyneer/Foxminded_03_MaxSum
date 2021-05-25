using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            if (args.Length > 0)
                path = args[0];

            while (!CheckFile(path))
            {
                Console.Write("Enter file path: ");
                path = Console.ReadLine();
            }

            DataAnalize data = new DataAnalize();
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.Peek() >= 0)
                {
                    data.ParseLine(reader.ReadLine());
                }
            }

            Console.WriteLine("Max Sum: " + data.MaxSum);
            Console.WriteLine("Error lines: " + string.Join(", ", data.errorLines));
        }

        private static bool CheckFile(string path)
        {
            if (!File.Exists(path))
                return false;

            return true;
        }
    }
}
