using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Problems
{
    public class BinaryTreeManager<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public void AddNode(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            var queue = new Queue<BinaryTreeNode<T>>();

            queue.Enqueue(newNode);

            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();

                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }
                else
                {
                    temp.Left = newNode;
                    break;
                }

                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                    break;
                }
                else
                {
                    temp.Right = newNode;
                }
            }
        }

        public List<T> InOrderTraversal(BinaryTreeNode<T> root)
        {
            var items = new List<T>();
            InOrderTaversal(root, items);

            return items;
        }

        private void InOrderTaversal(BinaryTreeNode<T> root, List<T> items)
        {
            if (root == null)
                return;

            InOrderTaversal(root.Left, items);
            items.Add(root.Data);
            InOrderTaversal(root.Right, items);
        }

        public List<T> PreOrderTraversal(BinaryTreeNode<T> root)
        {
            var items = new List<T>();
            PreOrderTaversal(root, items);

            return items;
        }

        private void PreOrderTaversal(BinaryTreeNode<T> root, List<T> items)
        {
            if (root == null)
                return;

            items.Add(root.Data);
            PreOrderTaversal(root.Left, items);
            PreOrderTaversal(root.Right, items);
        }
    }
}
