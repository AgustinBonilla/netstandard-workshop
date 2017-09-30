using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetIpInfo;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetIpInfoClient();
            var result = client.GetData("8.8.4.4").Result;
            Assert.AreEqual("Mountain View", result.city);
        }
    }
}
