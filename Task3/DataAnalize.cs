using System;
using System.Collections.Generic;

namespace Task3
{
    public class DataAnalize
    {
        public List<int> errorLines { get; set; }
        public decimal MaxSum { get; set; }
        private int LineCounter;

        public DataAnalize()
        {
            errorLines = new List<int>();
        }

        public void ParseLine(string line)
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
                errorLines.Add(LineCounter);
            }
        }
    }
}
