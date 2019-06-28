using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching
{
    public class PeakElementProblem
    {
        public int Peak(int[] numbers)
        {
            return Peak(numbers, 0, numbers.Length - 1, numbers.Length);
        }

        private int Peak(int[] numbers, int low, int high, int size)
        {
            if (low > high) return -1;

            var mid = low + (high - low) / 2;

            // middle element is greater then its two neighbours
            if ((mid == 0 || numbers[mid - 1] <= numbers[mid]) && (mid == size - 1 || numbers[mid] > numbers[mid + 1]))
                return numbers[mid];

            // If middle element is not peak and its left neighbour is greater  
            // than it, then left half must have a peak element 
            else if (mid > 0 && numbers[mid - 1] > numbers[mid])
                return Peak(numbers, low, mid - 1, size);

            // If middle element is not peak and its right neighbour is greater 
            // than it, then right half must have a peak element 
            else
                return Peak(numbers, (mid + 1), high, size);
        }
    }
}
