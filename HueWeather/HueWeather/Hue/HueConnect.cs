using Q42.HueApi.Interfaces;
using Q42.HueApi.WinRT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueWeather.Hue
{
    class HueConnect
    {
        private IBridgeLocator m_BridgeLocator;
        private IEnumerable<string> m_BridgeIPs;
        private readonly TimeSpan m_SearchTimeout = new TimeSpan(0,0,30);

        async void FindBridge()
        {
            m_BridgeLocator = new SSDPBridgeLocator();
            m_BridgeIPs = await m_BridgeLocator.LocateBridgesAsync(m_SearchTimeout);
        }
    }
}
