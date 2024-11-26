using NetworkManager;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

internal sealed class Network
{
    internal static void Refresh(FrmMain frm)
    {
        try
        {
            if (!string.IsNullOrEmpty(frm.txtbox_network_start.Text) && !string.IsNullOrEmpty(frm.txtbox_network_end.Text))
            {
                string[] arr_start = frm.txtbox_network_start.Text.Trim().Split('.');
                string[] arr_end = frm.txtbox_network_end.Text.Trim().Split('.');

                if (arr_start.Length == 4 && arr_end.Length == 4
                        && arr_start[0] == arr_end[0]
                        && arr_start[1] == arr_end[1]
                        && arr_start[2] == arr_end[2])
                {
                    for (int i = int.Parse(arr_start[3]); i <= int.Parse(arr_end[3]); i++)
                    {
                        Ping ping = new Ping();
                        PingReply pingReply;

                        long tripTime = 0;
                        string HostName;

                        IPAddress ip = IPAddress.Parse(string.Format("{0}.{1}.{2}.{3}", arr_start[0], arr_start[1], arr_start[2], i));

                        try
                        {
                            pingReply = ping.Send(ip);
                            tripTime = pingReply.RoundtripTime;

                            if (pingReply.Status == IPStatus.Success)
                            {
                                try
                                {
                                    HostName = Dns.GetHostEntry(ip).HostName;
                                }
                                catch
                                {
                                    HostName = "-";
                                }

                                frm.Invoker(() =>
                                {
                                    frm.datagrid_network.Rows.Add(ip);

                                    frm.datagrid_network.Rows[frm.datagrid_network.Rows.Count - 1].Cells[1].Value = HostName;

                                    frm.datagrid_network.Rows[frm.datagrid_network.Rows.Count - 1].Cells[2].Value = (int)tripTime + "ms";
                                });
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                else
                    MessageBox.Show("IP Range is not correct", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("IP Range is not correct", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch
        { }
    }
}
