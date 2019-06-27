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
    public class SortedRotatedArrayTests
    {
        [TestMethod()]
        public void MaximumTest_ShouldReturn_50()
        {
            var numbers = new int[] { 10, 20, 40, 50, 6, 7, 8 };

            Assert.AreEqual(50, new SortedRotatedArray().Maximum(numbers));
        }

        [TestMethod()]
        public void MaximumTest_ShouldReturn_20()
        {
            var numbers = new int[] { 10, 20, 1, 2, 3, 4, 5 };

            Assert.AreEqual(20, new SortedRotatedArray().Maximum(numbers));
        }

        [TestMethod()]
        public void MaximumTest_ShouldReturn_60()
        {
            var numbers = new int[] { 10, 20, 30, 40, 50, 60, 1 };

            Assert.AreEqual(60, new SortedRotatedArray().Maximum(numbers));
        }

        [TestMethod()]
        public void MaximumTest_ShouldReturn_70()
        {
            var numbers = new int[] { 10, 20, 30, 40, 60, 70, 1 };

            Assert.AreEqual(70, new SortedRotatedArray().Maximum(numbers));
        }

        [TestMethod()]
        public void MaximumTest_FoundAtIndex_1()
        {
            var numbers = new int[] { 10, 20, 40, 50, 6, 7, 8 };
            var numberTofind = 20;

            Assert.AreEqual(1, new SortedRotatedArray().Find(numbers, numberTofind));
        }

        [TestMethod()]
        public void MaximumTest_FoundAtIndex_6()
        {
            var numbers = new int[] { 10, 20, 40, 50, 6, 7, 8 };
            var numberTofind = 8;

            Assert.AreEqual(6, new SortedRotatedArray().Find(numbers, numberTofind));
        }
    }
}