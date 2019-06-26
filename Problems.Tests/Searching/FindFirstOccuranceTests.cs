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
    public class FindFirstOccuranceTests
    {
        [TestMethod()]
        public void FirstOccuranceTest_ValidTest()
        {
            var numbers = new int[] { 1, 3, 3, 4, 5, 6 };
            var numberTofind = 3;

            var result = new FindFirstOccurance().FirstOccurance(numbers, numberTofind);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void FirstOccuranceTest_ValidTest_For_1()
        {
            var numbers = new int[] { 1, 3, 3, 4, 5, 6 };
            var numberTofind = 1;

            var result = new FindFirstOccurance().FirstOccurance(numbers, numberTofind);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void FirstOccuranceTest_ValidTest_For_4()
        {
            var numbers = new int[] { 1, 3, 3, 4, 5, 6 };
            var numberTofind = 4;

            var result = new FindFirstOccurance().FirstOccurance(numbers, numberTofind);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void FirstOccuranceTest_InValidTest_For_10()
        {
            var numbers = new int[] { 1, 3, 3, 4, 5, 6 };
            var numberTofind = 10;

            var result = new FindFirstOccurance().FirstOccurance(numbers, numberTofind);
            Assert.AreEqual(-1, result);
        }
    }
}