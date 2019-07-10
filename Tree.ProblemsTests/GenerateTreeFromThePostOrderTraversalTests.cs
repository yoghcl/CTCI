using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Problems.Tests
{
    [TestClass()]
    public class GenerateTreeFromThePostOrderTraversalTests
    {
        [TestMethod()]
        public void ReconstructTreeTest()
        {
            var nodes = new List<char?>
            {
                'H',
                'B',
                null,
                null,
                'E',
                'A',
                null,
                null,
                null,
                'C',
                null,
                'D',
                null,
                'G',
                'I',
                null,
                null,
                null
            };

            var node = new GenerateTreeFromThePreOrderTraversal().ReconstructTree<char?>(nodes);
        }

    }
}