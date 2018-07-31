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
        public void AddNodeToTheBeginingTest()
        {
            var linkedListNodeManager = new LinkedListManager<int>();
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 1, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 2, Next = null });
            linkedListNodeManager.PrintNodes();
        }

        [TestMethod()]
        public void ReverseNodesTest()
        {
            var linkedListNodeManager = new LinkedListManager<int>();
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 1, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 2, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 3, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 4, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 5, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 6, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 7, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 8, Next = null });
            linkedListNodeManager.PrintNodes();
            linkedListNodeManager.ReverseNode();
            linkedListNodeManager.PrintNodes();

        }

        [TestMethod]
        public void PrintUsingRecursion()
        {
            var linkedListNodeManager = new LinkedListManager<int>();
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 1, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 2, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 3, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 4, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 5, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 6, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 7, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 8, Next = null });
            linkedListNodeManager.PrintUsingRecursion();
        }

        [TestMethod()]
        public void PrintReverseUsingRecursionTest()
        {
            var linkedListNodeManager = new LinkedListManager<int>();
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 1, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 2, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 3, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 4, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 5, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 6, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 7, Next = null });
            linkedListNodeManager.AddNodeToTheBegining(new LinkedListNode<int>() { Data = 8, Next = null });
            linkedListNodeManager.PrintReverseUsingRecursion();

        }
    }
}