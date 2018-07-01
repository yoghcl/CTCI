using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Assert.IsTrue(1 == 1);
        }
    }
}