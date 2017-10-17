using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetOnWater;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetOnWaterClient();
            var result = client.GetData("23.92323","-66.3").Result;
            Assert.IsTrue(result.water);
        }
    }
}
