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

        public bool IsPermuationUsingCharacterCounts(string input1, string input2)
        {
            if (input1.Length != input2.Length) return false;

            //counting the characters in input1
            var characterCounts = new int[128];

            for (int i = 0; i < input1.Length; i++)
            {
                var asciiValue = (int)input1[i];
                characterCounts[asciiValue]++;
            }

            for (int i = 0; i < input2.Length; i++)
            {
                var asciiValue = (int)input2[i];
                characterCounts[asciiValue]--;

                if (characterCounts[asciiValue] < 0)
                    return false;
            }

            return true;
        }
    }
}
