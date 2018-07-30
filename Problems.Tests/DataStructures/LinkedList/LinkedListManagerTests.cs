using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DataStructures.LinkedList.Tests
{
    [TestClass()]
    public class LinkedListManagerTests
    {
        [TestMethod()]
        public void LinkedListManagerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddNodeTest()
        {
            var linkedListNodeManager = new LinkedListManager<int>();
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 1, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 2, Next = null });
            linkedListNodeManager.PrintNodes();
        }

        [TestMethod()]
        public void PrintNodesTest()
        {
            Assert.Fail();
        }
    }
}