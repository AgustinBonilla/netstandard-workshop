using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetWordDefinition;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetWordDefinitionClient();
            client.ApiKey = "";
            var result = client.GetData("football").Result;
            Assert.AreEqual(result.Word, "football");
        }
    }
}
