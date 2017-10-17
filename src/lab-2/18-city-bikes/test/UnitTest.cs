using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCityBikes;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetCityBikesClient();
            var result = client.GetNetworks().Result;
            Assert.IsTrue(result.networks.Count > 0);

            var result2 = client.GetNetwork("movete").Result;
            Assert.IsTrue(result2.network.name == "Movete");
        }
    }
}
