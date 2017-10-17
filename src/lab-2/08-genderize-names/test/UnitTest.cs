using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetGenderizeNames;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetGenderizeNamesClient();
            var result = client.GetData("juan").Result;
            Assert.AreEqual("male", result.Gender);
        }
    }
}
