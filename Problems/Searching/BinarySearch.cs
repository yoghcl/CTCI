using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching
{
    public class BinarySearch
    {
        public int SearchRecursive(int[] numbers, int numberTofind)
        {
            if (numbers == null || numbers.Length == 0)
                return -1;
            return BinarySearchRecursive(numbers, 0, numbers.Length - 1, numberTofind);
        }

        private int BinarySearchRecursive(int[] numbers, int low, int high, int numberTofind)
        {
            if (low > high) return -1;

            var mid = low + (high - low) / 2;

            if (numbers[mid] == numberTofind)
                return mid;

            if (numbers[mid] > numberTofind)
                return BinarySearchRecursive(numbers, low, mid - 1, numberTofind);
            else
                return BinarySearchRecursive(numbers, mid + 1, high, numberTofind);
        }

        public int SearchIterative(int[] numbers, int numberTofind)
        {
            if (numbers == null || numbers.Length == 0)
                return -1;

            var low = 0;
            var high = numbers.Length - 1;
            var index = -1;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (numbers[mid] == numberTofind)
                {
                    index = mid;
                    break;
                }

                if (numbers[mid] > numberTofind)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return index;
        }
    }
}
