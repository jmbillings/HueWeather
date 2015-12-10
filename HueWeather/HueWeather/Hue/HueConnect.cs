using Q42.HueApi.Interfaces;
using Q42.HueApi.WinRT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueWeather.Hue
{
    internal class HueConnect
    {
        private IBridgeLocator m_BridgeLocator;
        private IEnumerable<string> m_BridgeIPs;

        internal delegate void BridgeLocatorEventHandler(object sender, LocateBridgeEventArgs e);
        internal event BridgeLocatorEventHandler LocateBridgeComplete;

        internal async void FindBridge()
        {
            m_BridgeLocator = new SSDPBridgeLocator();
            m_BridgeIPs = await m_BridgeLocator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            OnLocateBridgeComplete(new LocateBridgeEventArgs(m_BridgeIPs));
        }

        protected virtual void OnLocateBridgeComplete(LocateBridgeEventArgs e)
        {
            LocateBridgeComplete?.Invoke(this, e);
        }
    }

    internal class LocateBridgeEventArgs : EventArgs
    {
        internal IEnumerable<string> m_BridgeIPs { get; set; }

        internal LocateBridgeEventArgs(IEnumerable<string> BridgeIPs)
        {
            m_BridgeIPs = BridgeIPs;
        }
    }
}
