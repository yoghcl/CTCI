using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.DynamicProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DynamicProblem.Tests
{
    [TestClass()]
    public class PartitionProblemTests
    {
        [TestMethod()]
        public void SubsetsTest()
        {
            int[] set = { 1, 2, 3, 6 };
            var partionProblem = new PartitionProblem();

            Assert.AreEqual(true, partionProblem.Subsets(set));
        }
    }
}