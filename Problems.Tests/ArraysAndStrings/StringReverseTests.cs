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
    public class StringReverseTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            var s = "I am a peacefull soul";
            var r = new StringReverse().Reverse(s);
            Assert.AreEqual("soul peacefull a am I", r);
        }
    }
}