using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArraysAndStrings
{
    public class StringPermutations
    {
        public string GetAllPermutations(string input)
        {
            var permutations = new List<string>();
            Permute(input.ToCharArray(), 0, input.Length - 1, permutations);
            return string.Join(" ", permutations);
        }

        private void Permute(char[] input, int left, int right, IList<string> permutations)
        {
            if (left != right)
            {
                for (int i = left; i <= right; i++)
                {
                    Swap(ref input[left], ref input[i]);
                    Permute(input, left + 1, right, permutations);
                    Swap(ref input[left], ref input[i]);
                }
            }
            else
            {
                permutations.Add(new string(input));
            }
        }

        private void Swap(ref char v1, ref char v2)
        {
            var temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
