using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching
{
    public class KCounts
    {
        public int Counts(int[] numbers, int countingNumber)
        {
            var leftMostIndex = LeftIndex(numbers, 0, numbers.Length - 1, countingNumber);
            var rightMostIndex = RightIndex(numbers, numbers.Length, 0, numbers.Length - 1, countingNumber);

            return (leftMostIndex != -1) && (rightMostIndex != -1) ? rightMostIndex - leftMostIndex + 1 : -1;
        }

        private int LeftIndex(int[] numbers, int low, int high, int numberTofind)
        {
            if (low > high) return -1;

            var mid = low + (high - low) / 2;

            if ((numbers[mid] == numberTofind) && (mid == 0 || numbers[mid - 1] != numberTofind))
            {
                return mid;
            }

            if (numbers[mid] >= numberTofind)
                return LeftIndex(numbers, low, mid - 1, numberTofind);
            else
                return LeftIndex(numbers, mid + 1, high, numberTofind);
        }

        private int RightIndex(int[] numbers, int length, int low, int high, int numberTofind)
        {
            if (low > high) return -1;

            var mid = low + (high - low) / 2;

            if ((numbers[mid] == numberTofind) && (mid == length - 1 || numbers[mid + 1] != numberTofind))
            {
                return mid;
            }

            if (numbers[mid] > numberTofind)
                return RightIndex(numbers, length, low, mid - 1, numberTofind);
            else
                return RightIndex(numbers, length, mid + 1, high, numberTofind);
        }
    }
}
