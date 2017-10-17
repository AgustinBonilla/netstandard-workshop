using System;
using Xunit;
using NetGoogleGeocode;

namespace test
{
    public class UnitTest
    {
        [Fact]
        public void TestMethod()
        {
            var client = new NetGoogleGeocodeClient();
            var data = client.GetData("Oxford%20University,%20uk").Result;
            Assert.True(data.results.Count > 0);
        }
    }
}
