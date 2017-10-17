using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetDuckDuckGoSearch;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetDuckDuckGoSearchClient();
            client.ApiKey = "";
            var result = client.GetData("microsoft").Result;
            Assert.AreEqual(result.Heading, "Microsoft");
        }
    }
}
