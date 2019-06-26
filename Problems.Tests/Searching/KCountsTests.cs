using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching.Tests
{
    [TestClass()]
    public class KCountsTests
    {
        [TestMethod()]
        public void CountsTest_ShouldReturn_3()
        {
            var numbers = new int[] { 0, 1, 2, 3, 5, 5, 5, 6, 8, 19 };
            var countingNumber = 5;

            var result = new KCounts().Counts(numbers, countingNumber);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CountsTest_ShouldReturn_1()
        {
            var numbers = new int[] { 0, 1, 2, 3, 5, 5, 5, 6, 8, 19 };
            var countingNumber = 19;

            var result = new KCounts().Counts(numbers, countingNumber);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void CountsTest_ShouldReturn_Negavtive_1()
        {
            var numbers = new int[] { 0, 1, 2, 3, 5, 5, 5, 6, 8, 19 };
            var countingNumber = 100;

            var result = new KCounts().Counts(numbers, countingNumber);
            Assert.AreEqual(-1, result);
        }
    }
}