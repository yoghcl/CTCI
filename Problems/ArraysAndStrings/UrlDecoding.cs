using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArraysAndStrings
{
    public class UrlDecoding
    {
        public string Decode(char[] input, int stringLength)
        {
            var spaceCount = 0;

            //counting the spaces
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    spaceCount++;
            }

            var index = stringLength + spaceCount * 2;
            if (stringLength < input.Length)
                input[stringLength] = '\0';


        }
    }
}
