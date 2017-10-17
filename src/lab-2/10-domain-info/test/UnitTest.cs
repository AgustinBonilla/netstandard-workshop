using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetDomainInfo;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetDomainInfoClient();
            client.ApiKey = "L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM";
            var result = client.GetData("microsoft.com").Result;
            Assert.AreEqual("ns1.msft.net.", result.response.domain.ns[0]);
        }
    }
}
