using HueWeather.Hue;
using NUnit.Framework;

namespace HueWeather.Tests
{
    class HueBridgeDetectionTests
    {
        [Test]
        public void FindBridgeCanBeCalled()
        {
            HueConnect hueConnect = new HueConnect();
            hueConnect.FindBridge();
        }

    }
}
