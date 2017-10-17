using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCotizacionBCU;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var client = new NetCotizacionBCUClient();
            var result = client.GetData().Result;
            Assert.AreEqual("Acceso Correcto", result.mensaje);
        }
    }
}
