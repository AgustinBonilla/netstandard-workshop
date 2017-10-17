using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetBandsInTown;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetBandsInTownClient();
            var result = client.GetData("divididos").Result;
            Assert.IsNotNull(result);
        }
    }
}
