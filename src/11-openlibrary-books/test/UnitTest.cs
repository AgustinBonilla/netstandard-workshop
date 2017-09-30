using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetOpenlibraryBooks;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetOpenlibraryBooksClient();
            var result = client.GetData("9780345339706").Result;
            Assert.AreEqual("The fellowship of the ring", result);

            var result2 = client.GetData("9780131101630").Result;
            Assert.AreEqual("The  C programming language", result2);
        }
    }
}
