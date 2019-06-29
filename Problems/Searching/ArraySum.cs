using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching
{
    public class ArraySum
    {
        public bool IsFound(int [] numbers, int sum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsPair(numbers, i + 1, numbers.Length - 1, sum - numbers[i]))
                    return true;
            }

            return false;
        }

        private bool IsPair(int[] numbers, int start, int end, int sum)
        {
            while ( start < end)
            {
                if (numbers[start] + numbers[end] == sum)
                    return true;
                if (numbers[start] + numbers[end] > sum)
                    end--;
                else
                    start++;
            }

            return false;
        }
    }
}
