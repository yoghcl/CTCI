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
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchRecursiveTest_ValidValueTests()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var numberTofind = 2;

            var result = new BinarySearch().SearchRecursive(numbers, numberTofind);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void SearchRecursiveTest_InValidValueTests()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var numberTofind = 10;

            var result = new BinarySearch().SearchRecursive(numbers, numberTofind);
            Assert.AreEqual(-1, result);
        }

        [TestMethod()]
        public void SearchIterativeTest_ValidValueTests()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var numberTofind = 2;

            var result = new BinarySearch().SearchIterative(numbers, numberTofind);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void SearchIterativeTest_InValidValueTests()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var numberTofind = 10;

            var result = new BinarySearch().SearchIterative(numbers, numberTofind);
            Assert.AreEqual(-1, result);
        }
    }
}