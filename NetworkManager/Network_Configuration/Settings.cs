using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using NetworkManager;
using System.Net.Sockets;

internal sealed class Settings
{
    public static void Refresh_Network(FrmMain frm)
    {
        frm.Invoker(() =>
        {
            frm.combobox_networkT.Items.Clear();
            frm.datagrid_settings.Rows.Clear();

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    frm.combobox_networkT.Items.Add(ni.Name);
            }
        });

    }

    public static void Refresh_datagrid(FrmMain frm)
    {
        frm.Invoker(() =>
        {
            if (frm.combobox_networkT.SelectedIndex != -1)
            {
                frm.datagrid_settings.Rows.Clear();
                frm.btn_settings_add.Enabled = true;
                frm.btn_settings_edit.Enabled = true;
                frm.btn_settings_delete.Enabled = true;

                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    var prop = ni.GetIPProperties();

                    if (frm.combobox_networkT.SelectedItem.ToString() == ni.Name)
                    {
                        foreach (var ip in prop.UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                                frm.datagrid_settings.Rows.Add(ip.Address, ip.IPv4Mask);
                        }

                        break;
                    }
                }
            }
            else
            {
                frm.btn_settings_add.Enabled = false;
                frm.btn_settings_edit.Enabled = false;
                frm.btn_settings_delete.Enabled = false;
            }
        });
    }

    public static void AddIP(FrmMain frm, string input)
    {
        try
        {
            IPAddress ip;
            string adapterName = "";

            frm.Invoker(() =>
            {
                adapterName = frm.combobox_networkT.SelectedItem.ToString();
            });

            if (string.IsNullOrEmpty(adapterName))
            {
                MessageBox.Show("Adapter Name is not accessible", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (input.Trim().Split('.').Length != 4 || !IPAddress.TryParse(input.Trim(), out ip))
            {
                MessageBox.Show("IP is not accessible", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string SubNetMask = IP.GetSubnetMask(ip.ToString());

            try
            {
                Process p = Process.Start(new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = string.Format("interface ip add address \"{0}\" {1} {2}", adapterName, ip, SubNetMask),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                });

                Refresh_datagrid(frm);

                MessageBox.Show(string.Format("IP: ( {0} ) \nAdapterName: ( {1} )", ip, adapterName));
            }
            catch
            {
                MessageBox.Show("Access Denied", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch
        { }
    }

    public static void EditIP(FrmMain frm, string input, IPAddress oldIpAddress)
    {
        try
        {
            IPAddress newIpAddress;

            if (input.Trim().Split('.').Length != 4 || !IPAddress.TryParse(input.Trim(), out newIpAddress))
            {
                MessageBox.Show("IP is not accessible", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string subnetMask = IP.GetSubnetMask(newIpAddress.ToString());

            string adapterName = "";

            frm.Invoker(() =>
            {
                adapterName = frm.combobox_networkT.SelectedItem.ToString();
            });

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = string.Format("interface ip delete address \"{0}\" {1}", adapterName, oldIpAddress),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }).WaitForExit();

                Process.Start(new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = string.Format("interface ip add address \"{0}\" {1} {2}", adapterName, newIpAddress, subnetMask),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }).WaitForExit();

                Refresh_datagrid(frm);

                MessageBox.Show(string.Format("OldIP: ( {0} ) \nNewIP: ( {1} )", oldIpAddress, newIpAddress));
            }
            catch
            {
                MessageBox.Show("Access Denied", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch
        { }
    }

    public static void DeleteIP(FrmMain frm, IPAddress IpToRemove)
    {
        try
        {
            string adapterName = "";

            frm.Invoker(() =>
            {
                adapterName = frm.combobox_networkT.SelectedItem.ToString();
            });

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = string.Format("interface ip delete address \"{0}\" {1}", adapterName, IpToRemove),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }).WaitForExit();

                Refresh_datagrid(frm);
            }
            catch
            {
                MessageBox.Show("Access Denied", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch
        { }
    }
}
