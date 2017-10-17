using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetIpBlacklist;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetIpBlacklistClient();
            client.ApiKey = "L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM";
            var result = client.GetData("8.8.4.4").Result;
            Assert.AreEqual(result.Status, "OK");
        }
    }
}
