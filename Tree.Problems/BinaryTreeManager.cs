using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Problems
{
    public class BinaryTreeManager
    {
        public BinaryTreeNode Root { get; set; }

        public void AddNode(BinaryTreeNode node)
        {
            if (Root != null)
            {

            }
            else
            {
                this.Root = node;
            }
        }
    }
}
