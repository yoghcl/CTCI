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
    public class SquareRootProblemTests
    {
        [TestMethod()]
        public void Should_Return_4()
        {
            var n = 16;
            Assert.AreEqual(4, new SquareRootProblem().Sqrt(n));
        }

        [TestMethod()]
        public void Should_Return_3()
        {
            var n = 15;
            Assert.AreEqual(3, new SquareRootProblem().Sqrt(n));
        }

    }
}