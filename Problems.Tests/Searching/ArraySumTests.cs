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
    public class ArraySumTests
    {
        [TestMethod()]
        public void IsFoundTest()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.AreEqual(true, new ArraySum().IsFound(numbers, 21));
        }
    }
}