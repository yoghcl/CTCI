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
    public class InfiniteArraySearchTests
    {
        [TestMethod()]
        public void FindTest_ValidItemIntheArray()
        {
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            var numberTofind = 8;

            Assert.AreEqual(8, new InfiniteArraySearch().Find(numbers, numberTofind));
        }
    }
}