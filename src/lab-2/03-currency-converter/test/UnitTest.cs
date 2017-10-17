using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCurrencyConverter;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetCurrencyConverterClient();
            client.ApiKey = "";
            var result = client.GetData("USD", "100", "EUR").Result;
            Assert.AreEqual(result.To, "EUR");
        }
    }
}
