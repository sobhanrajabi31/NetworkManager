using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Net;
using System;
using System.Linq;

namespace NetworkManager.WinDns
{
    public class DNSSetting
    {
        const string DNS_REG_PATH = @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\";
        const string REG_KEY_SERVER = "NameServer";

        public static NetworkInterface[] GetNetworkInterface()
        {
            var networks = NetworkInterface.GetAllNetworkInterfaces();
            //var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
            //    a => a.OperationalStatus == OperationalStatus.Up &&
            //    (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
            //    a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));
            return networks;
        }

        public static void SetDns(string settingId, string dns1, string dns2)
        {
            var regPath = $@"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces\{settingId}";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath, true))
            {
                var value = GetDnsValue(dns1, dns2);
                key.SetValue(REG_KEY_SERVER, value, RegistryValueKind.String);
            }

            string GetDnsValue(string d1, string d2)
            {
                bool isNullDns1 = string.IsNullOrWhiteSpace(d1);
                bool isNullDns2 = string.IsNullOrWhiteSpace(d2);
                bool tryConvertDns1 = IPAddress.TryParse(d1, out IPAddress ip1);
                bool tryConvertDns2 = IPAddress.TryParse(d2, out IPAddress ip2);

                if (!isNullDns1 && !tryConvertDns1)
                    throw new ArgumentException("The ip format is not valid", nameof(dns1));
                if (!isNullDns2 && !tryConvertDns2)
                    throw new ArgumentException("The ip format is not valid", nameof(dns2));

                if (tryConvertDns1 && tryConvertDns2)
                    return $"{ip1},{ip2}";
                else if (!tryConvertDns1 && tryConvertDns2)
                    return d2;
                else
                    return d1;
            }
        }

        public static (string, string) GetDns(string settingId)
        {
            var regPath = $"{DNS_REG_PATH}{settingId}";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath, true))
            {
                var value = key.GetValue(REG_KEY_SERVER).ToString();
                if (value.Length > 0)
                    if (value.IndexOf(",") >= 0)
                    {
                        var dns = value.Split(',');
                        return (dns[0], dns[1]);
                    }
                    else
                        return (value, "");
                else
                    return ("", "");
            }
        }

        public static string[] GetGateways(string settingId)
        {
            string[] gateways = null;

            var adaptors = GetNetworkInterface();

            foreach (var adaptor in adaptors)
            {
                if (adaptor.Id.Equals(settingId))
                {
                    var ipProp = adaptor.GetIPProperties();
                    gateways = ipProp.GatewayAddresses.Select(info => info.Address.ToString()).ToArray();
                    break;
                }
            }
            return gateways;
        }
    }
}
