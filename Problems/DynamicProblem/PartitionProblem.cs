using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DynamicProblem
{
    /// <summary>
    /// Partition problem is to determine whether a given set can be partitioned 
    /// into two subsets such that the sum of elements in both subsets is same.
    /// </summary>
    public class PartitionProblem
    {
        public bool Subsets(int[] set)
        {
            var total = 0;
            for (int i = 0; i < set.Length; i++)
            {
                total += set[i];
            }

            if (total % 2 != 0)
                return false;

            return InternalSubset(set, total/2, set.Length);
        }

        private bool InternalSubset(int[] set, int total, int n)
        {
            if (total == 0)
                return true;
            else if (n == 0 && total != 0)
                return false;

            // if the last number is greater than sum
            if (set[n - 1] > total)
            {
                return InternalSubset(set, total, n - 1);
            }

            /* else, check if sum can be obtained by any of  
                the following  
                (a) including the last element  
                (b) excluding the last element  
            */
            return InternalSubset(set, total, n - 1) ||
                InternalSubset(set, total - set[n - 1], n - 1);

        }
    }
}
