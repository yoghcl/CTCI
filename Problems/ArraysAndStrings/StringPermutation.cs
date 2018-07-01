using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArraysAndStrings
{
    public class StringPermutation
    {
        //given two strings, check whether one is permutation of another or not.
        public bool IsPermutationNaiveMethod(string input1, string input2)
        {
            if (input1.Length != input2.Length) return false;

            if (Sort(input1).Equals(Sort(input2)))
            {
                Trace.WriteLine(input1);
                Trace.WriteLine(input2);
                return true;
            }
            else
                return false;
        }

        private string Sort(string s)
        {
            var characters = s.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
