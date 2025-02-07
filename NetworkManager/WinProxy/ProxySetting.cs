using Microsoft.Win32;

namespace NetworkManager.WinProxy
{
    public class ProxySetting
    {
        const string REG_PATH = @"Software\Microsoft\Windows\Currentversion\Internet Settings";
        const string ENALBE = "ProxyEnable";
        const string SERVER = "ProxyServer";

        public static void SetWinProxy(bool enableProxy, string proxyIP)
        {
            using (var key = Registry.CurrentUser.OpenSubKey(REG_PATH, true))
            {
                key.SetValue(ENALBE, enableProxy ? 1 : 0);
                key.SetValue(SERVER, proxyIP);
            }
        }

        public static (bool, string) GetWinProxy()
        {
            int enableProxy;
            string proxyIP;
            using (var key = Registry.CurrentUser.OpenSubKey(REG_PATH, true))
            {
                enableProxy = (int)key.GetValue(ENALBE);
                proxyIP = key.GetValue(SERVER).ToString();
            }
            return (enableProxy == 1 ? true : false, proxyIP);
        }
    }
}
