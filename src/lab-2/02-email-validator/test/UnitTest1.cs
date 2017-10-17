using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetEmailValidator;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new NetEmailValidatorClient();
            client.ApiKey = "L4YbUgwfoRmshRLQsNeoNaL5A06mp1TPGUhjsnCyygB6ISsmUM";
            var result = client.GetData("fakemail1283xx2@gmail.com").Result;
            Assert.AreEqual(result.IsValid, false);
        }
    }
}
