using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching
{
    public class InfiniteArraySearch
    {
        public int Find(int[] numbers, int numberTofind)
        {
            if (numbers[0] == numberTofind)
                return 0;

            var index = 1;
            while (numbers[index] < numberTofind)
                index *= 2;

            if (numbers[index] == numberTofind)
                return index;

            //else do binary search
            return BinarySearch(numbers, index / 2, index, numberTofind);
        }

        private int BinarySearch(int[] numbers, int low, int high, int numberTofind)
        {
            if (low < high)
                return -1;

            var mid = low + (high - low) / 2;

            if (numbers[mid] == numberTofind)
                return mid;

            if (numbers[mid] > numberTofind)
                return BinarySearch(numbers, low, mid - 1, numberTofind);
            else
                return BinarySearch(numbers, mid + 1, high, numberTofind);
        }
    }
}
