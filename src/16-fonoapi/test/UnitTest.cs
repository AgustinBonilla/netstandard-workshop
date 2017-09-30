using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFonoapi;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetFonoapiClient();
            client.ApiKey = "75d5f68c0bae7032c2d6191f7c13f1d65685e47571cbf434";
            var result = client.GetData("lumia%20850").Result;
            Assert.AreEqual("Microsoft Lumia 850", result[0].DeviceName);
        }
    }
}
