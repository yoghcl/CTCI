using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tree.Problems.Tests
{
    [TestClass()]
    public class BinaryTreeManagerTests
    {
        [TestMethod()]
        public void InorderTraversalTest()
        {
            /*
                                10
                        20               30
                    40      50      60      70
            */

            var root = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(20),
                Right = new BinaryTreeNode<int>(30)
            };

            root.Left.Left = new BinaryTreeNode<int>(40);
            root.Left.Right = new BinaryTreeNode<int>(50);

            root.Right.Left = new BinaryTreeNode<int>(60);
            root.Right.Right = new BinaryTreeNode<int>(70);

            var treeManager = new BinaryTreeManager<int>();
            List<int> results = treeManager.InOrderTraversal(root);

            Assert.AreEqual(root.Left.Left.Data, results[0]);
            Assert.AreEqual(root.Left.Data, results[1]);
            Assert.AreEqual(root.Left.Right.Data, results[2]);
            Assert.AreEqual(root.Data, results[3]);
            Assert.AreEqual(root.Right.Left.Data, results[4]);
            Assert.AreEqual(root.Right.Data, results[5]);
            Assert.AreEqual(root.Right.Right.Data, results[6]);
        }

        [TestMethod()]
        public void PreOrderTraversalTest()
        {
            /*
                                10
                        20               30
                    40      50      60      70
            */

            var root = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(20),
                Right = new BinaryTreeNode<int>(30)
            };

            root.Left.Left = new BinaryTreeNode<int>(40);
            root.Left.Right = new BinaryTreeNode<int>(50);

            root.Right.Left = new BinaryTreeNode<int>(60);
            root.Right.Right = new BinaryTreeNode<int>(70);

            var treeManager = new BinaryTreeManager<int>();
            List<int> results = treeManager.PreOrderTraversal(root);


            Assert.AreEqual(root.Data, results[0]);
            Assert.AreEqual(root.Left.Data, results[1]);
            Assert.AreEqual(root.Left.Left.Data, results[2]);
            Assert.AreEqual(root.Left.Right.Data, results[3]);
            Assert.AreEqual(root.Right.Data, results[4]);
            Assert.AreEqual(root.Right.Left.Data, results[5]);
            Assert.AreEqual(root.Right.Right.Data, results[6]);
        }
    }
}