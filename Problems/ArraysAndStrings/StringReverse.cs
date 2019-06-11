using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArraysAndStrings
{
    public class StringReverse
    {
        public string Reverse(string input)
        {
            string[] array = input.Split(' ');
            string ans = string.Empty;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                ans += array[i] + " ";
            }

            return ans.Substring(0, ans.Length - 1);
        }

    }
}
