using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Misc.Tests
{
    [TestClass()]
    public class NutsAndBoltsProblemTests
    {
        [TestMethod()]
        public void MatchPairsTest()
        {
            // Nuts and bolts are represented as array of characters 
            char[] nuts =  { '2', '5', '3', '6', '4', '1' };
            char[] bolts = { '1', '6', '2', '3', '4', '5' };

            var nutsAndBolts = new NutsAndBoltsProblem();

            // Method based on quick sort which matches nuts and bolts 
            nutsAndBolts.MatchPairs(nuts, bolts, 5, 0);

            Console.WriteLine("Matched nuts and bolts are : ");
            PrintArray(nuts);
            PrintArray(bolts);
        }

        private void PrintArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
        }
    }
}