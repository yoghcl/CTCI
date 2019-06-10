using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CTCI.Tests.Misc
{
    public class SnakeNLadders
    {
        public void DisplayBoard(int n)
        {
            var totalNos = n * n;
            var nos = new int[totalNos];

            for (int i = 0; i < totalNos; i++)
                nos[i] = i + 1;

            var flag = false;
            var index = 0;

            for (int i = 1; i <= n; i++)
            {
                if (!flag)
                {
                    while (index < n * i)
                    {
                        Console.Write("\t" + (totalNos + 1 - nos[index]));
                        index++;
                    }
                }
                else
                {
                    var lastNumber = index + n - 1;
                    while (lastNumber >= index)
                    {
                        Console.Write("\t" + (totalNos + 1 - nos[lastNumber]));
                        lastNumber--;
                    }
                    index += n;
                }

                flag = !flag;
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}
