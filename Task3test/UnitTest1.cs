using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Task3;

namespace Task3test
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> dataBlock;
        private List<int> errorLines;

        [TestInitialize]
        public void TestInitialize()
        {
            dataBlock = new List<string>();
            dataBlock.Add("12.45, 45, 67.2, 345.734, 11.233, 5522.989, 1, 324.34, 45.666");
            dataBlock.Add("345,    345, 786 ,       6457.444, 6");
            dataBlock.Add("not number <> 343");
            dataBlock.Add("1, 4, 5664.324, 23.7865, 88.888");
            dataBlock.Add("zzz, 74, 100500900.456");
            dataBlock.Add("234, 67465, 345, 6457, 234556, 3434.777");

            errorLines = new List<int>() { 3, 5 };
        }

        [TestMethod]
        public void TestMaxSumm()
        {
            Assert.AreEqual(312491.777M, LoadData().MaxSum);
        }

        [TestMethod]
        public void TestErrorLines()
        {
            Assert.IsTrue(Enumerable.SequenceEqual(errorLines, LoadData().errorLines));
        }

        private DataAnalize LoadData()
        {
            DataAnalize data = new DataAnalize();
            foreach (string line in dataBlock)
            {
                data.ParseLine(line);
            }
            return data;
        }
    }
}
