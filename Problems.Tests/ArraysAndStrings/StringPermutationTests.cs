using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArraysAndStrings.Tests
{
    [TestClass()]
    public class StringPermutationTests
    {
        [TestMethod()]
        public void IsPermutationNaiveMethodTest_WhenStringsArePermuationOfAnother()
        {
            var input1 = "God is great";
            var input2 = "odg si taerG";

            Assert.AreEqual(true, new StringPermutation().IsPermutationNaiveMethod(input1, input2));
        }

        [TestMethod()]
        public void IsPermutationNaiveMethodTest_WhenStringsAreNotPermuationOfAnother()
        {
            var input1 = "God is great";
            var input2 = "odg si taega";

            Assert.AreEqual(false, new StringPermutation().IsPermutationNaiveMethod(input1, input2));
        }

        [TestMethod()]
        public void IsPermutationNaiveMethodTest_WhenStringsAreUnqualLength()
        {
            var input1 = "God is great";
            var input2 = "odg sitaerg";

            Assert.AreEqual(false, new StringPermutation().IsPermutationNaiveMethod(input1, input2));
        }
    }
}