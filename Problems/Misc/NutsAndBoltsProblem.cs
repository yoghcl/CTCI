using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Misc
{
    public class NutsAndBoltsProblem
    {
        public void MatchPairs(char[] nuts, char[] bolts, int high, int low)
        {
            if (low < high)
            {
                int pivot = Parition(nuts, high, low, bolts[high]);
                Parition(bolts, high, low, nuts[pivot]);
                MatchPairs(nuts, bolts, pivot - 1, low);
                MatchPairs(nuts, bolts, high, pivot + 1);
            }
        }

        private static int Parition(char[] array, int high, int low, char pivot)
        {
            int i = low;
            char temp1, temp2;

            for (int j = low; j < high; j++) 
            {
                if (array[j] < pivot)
                {
                    temp1 = array[i];
                    array[i] = array[j];
                    array[j] = temp1;
                    i++;
                }
                else if (array[j] == pivot)
                {
                    temp1 = array[j];
                    array[j] = array[high];
                    array[high] = temp1;
                    j--;
                }
            }

            temp2 = array[i];
            array[i] = array[high];
            array[high] = temp2;

            return i;
        }
    }
}
