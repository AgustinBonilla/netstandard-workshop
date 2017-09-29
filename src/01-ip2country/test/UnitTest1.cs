using Ip2CountryNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new Ip2CountryClient();
            var result = client.GetData("8.8.4.4").Result;
            Assert.AreEqual(result.CountryCode, "US");
        }
    }
}
