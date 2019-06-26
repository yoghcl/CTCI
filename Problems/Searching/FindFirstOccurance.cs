using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching
{
    public class FindFirstOccurance
    {
        public int FirstOccurance(int[] numbers, int numberTofind)
        {
            return FirstOccurance(numbers, 0, numbers.Length - 1, numberTofind);
        }

        private int FirstOccurance(int[] numbers, int low, int high, int numberTofind)
        {
            if (low > high) return -1;

            var mid = low + (high - low) / 2;

            if ((numbers[mid] == numberTofind) && (mid == 0 || numbers[mid - 1] != numberTofind))
            {
                return mid;
            }

            if (numbers[mid] >= numberTofind)
                return FirstOccurance(numbers, low, mid - 1, numberTofind);
            else
                return FirstOccurance(numbers, mid + 1, high, numberTofind);
        }
    }
}
