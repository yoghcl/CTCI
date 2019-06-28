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
    public class PeakElementProblemTests
    {
        [TestMethod()]
        public void PeakTest_Should_Return_5()
        {
            var numbers = new int[] { 1, 2, 3, 5, 4, 2, 1 };
            Assert.AreEqual(5, new PeakElementProblem().Peak(numbers));
        }

        [TestMethod()]
        public void PeakTest_Should_Return_3()
        {
            var numbers = new int[] { 1, 2, 3 };
            Assert.AreEqual(3, new PeakElementProblem().Peak(numbers));
        }

        [TestMethod()]
        public void PeakTest_Should_Return_4()
        {
            var numbers = new int[] { 4, 2, 3 };
            Assert.AreEqual(4, new PeakElementProblem().Peak(numbers));
        }

        [TestMethod()]
        public void PeakTest_Should_Return_7()
        {
            var numbers = new int[] { 7, 3, 2 };
            Assert.AreEqual(7, new PeakElementProblem().Peak(numbers));
        }
    }
}