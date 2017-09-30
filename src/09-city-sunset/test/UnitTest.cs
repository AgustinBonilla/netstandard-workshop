using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCitySunset;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetCitySunsetClient();
            client.ApiKey = "L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM";
            var result = client.GetData("barcelona").Result;
            Assert.IsNotNull(result);
        }
    }
}
