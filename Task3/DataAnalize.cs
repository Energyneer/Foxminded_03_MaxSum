using System;
using System.Collections.Generic;

namespace Task3
{
    public class DataAnalize
    {
        public List<ulong> ErrorLines { get; set; }
        public decimal MaxSum { get; set; }
        private readonly string[] Data;
        private ulong LineCounter;

        public DataAnalize(string[] data)
        {
            Data = data;
            ErrorLines = new List<ulong>();
        }

        public void ParseAll()
        {
            foreach (string line in Data)
            {
                ParseLine(line);
            }
        }

        private void ParseLine(string line)
        {
            LineCounter++;
            try
            {
                string[] numbers = line.Split(",");
                decimal sum = 0;
                foreach (string num in numbers)
                {
                    sum += decimal.Parse(num);
                }

                if (sum > MaxSum)
                    MaxSum = sum;
            }
            catch
            {
                ErrorLines.Add(LineCounter);
            }
        }
    }
}
