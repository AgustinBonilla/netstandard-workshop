using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetMetaweather;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetMetaweatherClient();
            var result = client.GetCities("buenos+aires").Result;
            Assert.IsTrue(result.Length > 0);

            var result2 = client.GetWeather("468739").Result;
            Assert.AreEqual("Buenos Aires", result2.title);
        }
    }
}
