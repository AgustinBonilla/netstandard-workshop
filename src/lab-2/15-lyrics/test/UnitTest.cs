using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetLyrics;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetLyricsClient();
            var result = client.GetData("therollingstones", "satisfaction").Result;
            Assert.IsTrue(result.lyrics.Contains("satisfaction"));
        }
    }
}
