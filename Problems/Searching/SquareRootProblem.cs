using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Searching
{
    public class SquareRootProblem
    {
        public int Sqrt(int n)
        {
            if (n == 0 || n == 1)
                return n;

            var start = 1;
            var end = n;
            var ans = 0;

            while (start <= end)
            {
                var mid = (start + end) / 2;

                if (mid * mid == n)
                    return mid;

                if (mid * mid < n)
                {
                    start = mid + 1;
                    ans = mid;
                }
                else
                    end = mid - 1;
            }

            return ans;
        }
    }
}
