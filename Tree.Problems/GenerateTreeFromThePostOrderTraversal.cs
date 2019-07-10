using System;
using System.Collections.Generic;

namespace Tree.Problems
{
    public class GenerateTreeFromThePreOrderTraversal
    {
        public BinaryTreeNode<T> ReconstructTree<T>(List<T> list)
        {
            var subtreeIndex = 0;
            return ReconstructTree(list, subtreeIndex);
        }

        private BinaryTreeNode<T> ReconstructTree<T>(List<T> list, int subtreeIndex)
        {
            var subtreeData = list[subtreeIndex];
            ++subtreeIndex;

            if (subtreeData == null)
                return null;

            //Note that reconstruct updates subtreeindex, so the order of
            //following calls are important
            var leftSubtree = ReconstructTree<T>(list, subtreeIndex);
            var rightSubtree = ReconstructTree<T>(list, subtreeIndex);

            return new BinaryTreeNode<T>(subtreeData, leftSubtree, rightSubtree);
        }
    }
}
