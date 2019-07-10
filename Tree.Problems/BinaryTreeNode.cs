using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Problems
{
    public class BinaryTreeNode
    {
        public int Data { get; }

        public BinaryTreeNode Left { get; }

        public BinaryTreeNode Right { get; }

        public BinaryTreeNode(int data, BinaryTreeNode left, BinaryTreeNode right)
        {
            this.Data = data;
            this.Left = left;
            this.Right = right;
        }
    }
}
