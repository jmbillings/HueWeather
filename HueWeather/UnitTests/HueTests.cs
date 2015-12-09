using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using HueWeather.Hue;

namespace UnitTests
{
    [TestClass]
    public class HueTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            HueConnect hueConnect = new HueConnect();
            hueConnect.FindBridge();
            Assert.IsTrue(true);
        }
    }
}
