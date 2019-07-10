using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tree.Problems.Test
{
    [TestClass]
    public class BinaryTreeManagerTests
    {
        [TestMethod]
        public void AddNodeTests()
        {
            var treeManager = new BinaryTreeManager<int>();
            treeManager.AddNode(10);
            treeManager.AddNode(20);
            treeManager.AddNode(30);
            treeManager.AddNode(40);
        }
    }
}
