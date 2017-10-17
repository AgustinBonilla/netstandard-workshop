using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetAnApiOfIceAndFire;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetAnApiOfIceAndFireClient();
            var result = client.GetHouses().Result;
            Assert.IsTrue(result.Length > 0);

            var result2 = client.GetHouse("378").Result;
            Assert.IsTrue(result2.name == "House Targaryen of King's Landing");
        }
    }
}
