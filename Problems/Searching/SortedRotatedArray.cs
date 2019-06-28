using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching
{
    public class SortedRotatedArray
    {
        public int Find(int[] numbers, int numberTofind)
        {
            var index = MaximumElementIndex(numbers, 0, numbers.Length - 1);

            var found = BinarySearch(numbers, 0, index, numberTofind);

            if (found != -1)
                return found;

            found = BinarySearch(numbers, index, numbers.Length - 1, numberTofind);

            if (found != -1)
                return found;

            return -1;
        }

        public int Maximum(int[] numbers)
        {
            var index = MaximumElementIndex(numbers, 0, numbers.Length - 1);
            if (index > -1)
                return numbers[index];
            else
                return -1;
        }

        public int Minimum(int[] numbers)
        {
            var index = MaximumElementIndex(numbers, 0, numbers.Length - 1);
            if (index > -1)
            {
                if (index == numbers.Length - 1)
                    return numbers[0];
                if (index == 0)
                    return numbers[numbers.Length - 1];
                else
                    return numbers[index + 1];
            }
            else
                return -1;
        }

        private int MaximumElementIndex(int[] numbers, int low, int high)
        {
            if (low > high) return -1;

            var mid = low + (high - low) / 2;

            if ((mid == 0 || numbers[low] <= numbers[mid]) && (mid == numbers.Length -1 || numbers[mid] >= numbers[mid + 1]))
                return mid;

            if (numbers[mid] >= numbers[low])
                return MaximumElementIndex(numbers, mid + 1, high);
            else
                return MaximumElementIndex(numbers, low, mid - 1);

        }

        private int MinimumElementIndex(int[] numbers, int low, int high)
        {
            if (low > high) return -1;

            var mid = low + (high - low) / 2;

            if ((numbers[low] > numbers[mid]) && (numbers[mid] < numbers[mid + 1]))
                return mid;

            if (numbers[mid] > numbers[low])
                return MinimumElementIndex(numbers, mid + 1, high);
            else
                return MinimumElementIndex(numbers, low, mid - 1);

        }

        private int BinarySearch(int[] numbers, int low, int high, int numberTofind)
        {
            if (low > high)
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
