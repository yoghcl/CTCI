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
    public class UrlShortnerTests
    {
        [TestMethod()]
        public void IdToShortUrlTest()
        {
            var id = 12345;
            var urlShortner = new UrlShortner();
            var result = urlShortner.IdToShortUrl(id);

            Assert.AreEqual("dnh", result);
        }
    }
}