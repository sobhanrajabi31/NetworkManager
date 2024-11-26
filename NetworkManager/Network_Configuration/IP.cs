using NetworkManager;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

internal sealed class IP
{
    public static string GetSubnetMask(string ip)
    {
        string ReturnSubnetmask()
        {
            uint firstOctet = ReturnFirtsOctet();
            if (firstOctet >= 0 && firstOctet <= 127)
                return "255.0.0.0";
            else if (firstOctet >= 128 && firstOctet <= 191)
                return "255.255.0.0";
            else if (firstOctet >= 192 && firstOctet <= 223)
                return "255.255.255.0";
            else return "0.0.0.0";
        }

        uint ReturnFirtsOctet()
        {
            IPAddress iPAddress = IPAddress.Parse(ip);
            byte[] byteIP = iPAddress.GetAddressBytes();
            uint ipInUint = (uint)byteIP[0];
            return ipInUint;
        }

        return ReturnSubnetmask();
    }

    public static void AddIp(FrmMain frm, string input)
    {
        try
        {
            IPAddress ip;

            if (input.Trim().Split('.').Length != 4 || !IPAddress.TryParse(input.Trim(), out ip))
            {
                MessageBox.Show("IP is not accessible", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            frm.Invoker(() =>
            {
                frm.datagrid_ips.Rows.Add(ip, "-");
            });

            string text = string.Format("IP: ( {0} )", ip);

            MessageBox.Show(text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch
        { }
    }

    public static void DeleteIp(FrmMain frm)
    {
        try
        {
            frm.Invoker(() =>
            {
                if (frm.datagrid_ips.Rows.Count > 0 && frm.datagrid_ips.CurrentRow.Index != -1)
                    frm.datagrid_ips.Rows.RemoveAt(frm.datagrid_ips.CurrentRow.Index);
                else
                    MessageBox.Show("There is nothing to delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });
        }
        catch
        { }
    }

    public static void Ping(FrmMain frm)
    {
        try
        {
            Ping ping = new Ping();
            PingReply pingReply;

            long tripTime = 0;
            string status = "";
            string hostname = "";

            int success = 0;
            int failure = 0;

            int step = 4;

            bool continues = false;

            frm.Invoker(() =>
            {
                if (frm.datagrid_ips.Rows.Count > 0 && frm.datagrid_ips.CurrentRow.Index != -1)
                {
                    continues = true;
                }
                else
                    MessageBox.Show("There is nothing to ping", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });

            if (continues)
            {
                try
                {
                    bool once = true;

                    for (int i = 0; i < step; i++)
                    {
                        IPAddress ip = null;

                        frm.Invoker(() =>
                        {
                            ip = IPAddress.Parse(frm.datagrid_ips.CurrentRow.Cells[0].Value.ToString());
                        });

                        pingReply = ping.Send(ip);

                        tripTime += pingReply.RoundtripTime;

                        if (pingReply.Status == IPStatus.Success)
                        {
                            success++;

                            if (once)
                            {
                                try
                                {
                                    hostname = Dns.GetHostEntry(ip).HostName;
                                }
                                catch
                                {
                                    hostname = "-";
                                }
                            }

                            once = false;
                        }
                        else
                        {
                            failure++;
                            hostname = "-";
                        }
                    }

                    if (success >= failure)
                        status = "Success";
                    else
                        status = "Timedout";

                    tripTime /= step;
                }
                catch
                {
                    tripTime = 0;
                    status = "Failure";
                    hostname = "-";
                }

                frm.Invoker(() =>
                {
                    frm.datagrid_ips.CurrentRow.Cells[1].Value = hostname;

                    frm.datagrid_ips.CurrentRow.Cells[2].Value = (int)tripTime + "ms";

                    frm.datagrid_ips.CurrentRow.Cells[3].Value = status;
                });
            }
        }
        catch
        { }
    }

    internal static void DeleteAllIp(FrmMain frm)
    {
        try
        {
            frm.Invoker(() =>
            {
                if (frm.datagrid_ips.Rows.Count > 0)
                    frm.datagrid_ips.Rows.Clear();
                else
                    MessageBox.Show("At least two IPs are required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });
        }
        catch
        { }
    }

    internal static void PingAll(FrmMain frm)
    {
        try
        {
            IPAddress[] ips = null;

            Ping ping = new Ping();
            PingReply pingReply;

            long tripTime = 0;
            string status = "";
            string hostname = "";

            int success = 0;
            int failure = 0;

            int step = 4;

            bool continues = false;

            frm.Invoker(() =>
            {
                if (frm.datagrid_ips.Rows.Count > 1)
                {
                    ips = new IPAddress[frm.datagrid_ips.Rows.Count];

                    for (int i = 0; i < frm.datagrid_ips.Rows.Count; i++)
                    {
                        ips[i] = (IPAddress.Parse(frm.datagrid_ips.Rows[i].Cells[0].Value.ToString()));
                    }
                }
                else
                    MessageBox.Show("At least two IPs are required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });

            if (continues)
            {
                for (int i = 0; i < ips.Length; i++)
                {
                    try
                    {
                        bool once = true;

                        for (int j = 0; j < step; j++)
                        {
                            pingReply = ping.Send(ips[i]);

                            tripTime += pingReply.RoundtripTime;

                            if (pingReply.Status == IPStatus.Success)
                            {
                                success++;

                                if (once)
                                {
                                    try
                                    {
                                        hostname = Dns.GetHostEntry(ips[i].ToString()).HostName;
                                    }
                                    catch
                                    {
                                        hostname = "-";
                                    }
                                }

                                once = false;
                            }
                            else
                            {
                                failure++;
                                hostname = "-";
                            }
                        }

                        if (success >= failure)
                            status = "Success";
                        else
                            status = "Timedout";

                        tripTime /= step;
                    }
                    catch
                    {
                        tripTime = 0;
                        status = "Failure";
                        hostname = "-";
                    }

                    frm.Invoker(() =>
                    {
                        frm.datagrid_ips.Rows[i].Cells[1].Value = hostname;

                        frm.datagrid_ips.Rows[i].Cells[2].Value = (int)tripTime + "ms";

                        frm.datagrid_ips.Rows[i].Cells[3].Value = status;
                    });
                }
            }
        }
        catch
        { }
    }
}
