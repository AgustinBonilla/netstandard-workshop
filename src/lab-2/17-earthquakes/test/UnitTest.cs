using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetEarthquakes;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetEarthquakesClient();
            var result = client.GetData("2017-09-19", "2017-09-20", "6").Result;
            Assert.AreEqual("FeatureCollection", result.type);
        }
    }
}
