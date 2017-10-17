using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetRestCountries;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetRestCountriesClient();
            client.ApiKey = "L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM";
            var result = client.GetData("ar").Result;
            Assert.AreEqual(result.name, "Argentina");
        }
    }
}
