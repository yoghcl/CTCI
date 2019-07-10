using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Problems
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T data)
        {
            this.Data = data;
        }

        public BinaryTreeNode()
        {

        }

        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.Data = data;
            this.Left = left;
            this.Right = right;
        }
    }
}
