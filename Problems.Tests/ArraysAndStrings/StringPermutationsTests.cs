using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArraysAndStrings.Tests
{
    [TestClass()]
    public class StringPermutationsTests
    {
        [TestMethod()]
        public void GetAllPermutationsTest()
        {
            var stringPermutations = new StringPermutations();
            var result = stringPermutations.GetAllPermutations("ABC");
            Assert.AreEqual("ABC ACB BAC BCA CBA CAB", result);
        }

        [TestMethod()]
        public void GetAllPermutationsTest_WithFourCharacters()
        {
            var stringPermutations = new StringPermutations();
            var result = stringPermutations.GetAllPermutations("ABCD");
            Assert.AreEqual("ABCD ABDC ACBD ACDB ADCB ADBC BACD BADC BCAD BCDA BDCA BDAC CBAD CBDA CABD CADB CDAB CDBA DBCA DBAC DCBA DCAB DACB DABC", result);
        }

        [TestMethod()]
        public void GetAllPermutationsTest_WithFiveCharacters()
        {
            var stringPermutations = new StringPermutations();
            var result = stringPermutations.GetAllPermutations("ABCDE");
            Assert.AreEqual("ABCDE ABCED ABDCE ABDEC ABEDC ABECD ACBDE ACBED ACDBE ACDEB ACEDB ACEBD ADCBE ADCEB ADBCE ADBEC ADEBC ADECB AECDB AECBD AEDCB AEDBC AEBDC AEBCD BACDE BACED BADCE BADEC BAEDC BAECD BCADE BCAED BCDAE BCDEA BCEDA BCEAD BDCAE BDCEA BDACE BDAEC BDEAC BDECA BECDA BECAD BEDCA BEDAC BEADC BEACD CBADE CBAED CBDAE CBDEA CBEDA CBEAD CABDE CABED CADBE CADEB CAEDB CAEBD CDABE CDAEB CDBAE CDBEA CDEBA CDEAB CEADB CEABD CEDAB CEDBA CEBDA CEBAD DBCAE DBCEA DBACE DBAEC DBEAC DBECA DCBAE DCBEA DCABE DCAEB DCEAB DCEBA DACBE DACEB DABCE DABEC DAEBC DAECB DECAB DECBA DEACB DEABC DEBAC DEBCA EBCDA EBCAD EBDCA EBDAC EBADC EBACD ECBDA ECBAD ECDBA ECDAB ECADB ECABD EDCBA EDCAB EDBCA EDBAC EDABC EDACB EACDB EACBD EADCB EADBC EABDC EABCD", result);
        }
    }
}