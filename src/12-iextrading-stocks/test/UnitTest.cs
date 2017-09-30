using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetIextradingStocks;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetIextradingStocksClient();
            var result = client.GetData("MSFT").Result;
            Assert.AreEqual("Microsoft Corporation", result.companyName);
        }
    }
}
