using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Task3;

namespace Task3test
{
    [TestClass]
    public class UnitTest1
    {
        private string[] dataBlock;
        private List<ulong> errorLines;
        private DataAnalize dataAnalize;

        [TestInitialize]
        public void TestInitialize()
        {
            dataBlock = new string[6];
            dataBlock[0] = "12.45, 45, 67.2, 345.734, 11.233, 5522.989, 1, 324.34, 45.666";
            dataBlock[1] = "345,    345, 786 ,       6457.444, 6";
            dataBlock[2] = "not number <> 343";
            dataBlock[3] = "1, 4, 5664.324, 23.7865, 88.888";
            dataBlock[4] = "zzz, 74, 100500900.456";
            dataBlock[5] = "234, 67465, 345, 6457, 234556, 3434.777";

            errorLines = new List<ulong>() { 3, 5 };

            dataAnalize = new DataAnalize(dataBlock);
            dataAnalize.ParseAll();
        }

        [TestMethod]
        public void TestMaxSumm()
        {
            Assert.AreEqual(312491.777M, dataAnalize.MaxSum);
        }

        [TestMethod]
        public void TestErrorLines()
        {
            Assert.IsTrue(Enumerable.SequenceEqual(errorLines, dataAnalize.ErrorLines));
        }
    }
}
