using System;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Windows.Forms;

namespace NetworkManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            if (!IsUserAdministrator())
            {
                MessageBox.Show("You must run the program with Administrator access", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        // ------------------------------------ { Public Methods } ------------------------------------

        private void FrmMain_Load(object sender, EventArgs e)
        {
            combobox_networkT.MaxDropDownItems = NetworkInterface.GetAllNetworkInterfaces().Length;
            Settings.Refresh_Network(this);
        }

        public bool IsUserAdministrator()
        {
            try
            {
                WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                return false;
            }
        }

        private void buttons(object sender, EventArgs e)
        {
            this.Invoker(() =>
            {
                Button btn = (Button)sender;

                if (btn.Name == btn_ip_addip.Name)
                {
                    if (!bg_addip.IsBusy)
                        bg_addip.RunWorkerAsync();
                }

                if (btn.Name == btn_ip_delete.Name)
                {
                    if (MessageBox.Show("Are you Sure?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!bg_delete.IsBusy)
                            bg_delete.RunWorkerAsync();
                    }
                }

                if (btn.Name == btn_ip_deleteall.Name)
                {
                    if (MessageBox.Show("Are you Sure?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!bg_deleteall.IsBusy)
                            bg_deleteall.RunWorkerAsync();
                    }
                }

                if (btn.Name == btn_ip_ping.Name)
                {
                    if (!bg_ping.IsBusy)
                    {
                        if (datagrid_ips.Rows.Count > 0)
                        {
                            datagrid_ips.CurrentRow.Cells[2].Value = "";
                            datagrid_ips.CurrentRow.Cells[3].Value = "";
                        }

                        bg_ping.RunWorkerAsync();
                    }
                }

                if (btn.Name == btn_ip_pingall.Name)
                {
                    if (!bg_pingall.IsBusy)
                    {
                        if (datagrid_ips.Rows.Count > 1)
                        {
                            for (int i = 0; i < datagrid_ips.Rows.Count; i++)
                            {
                                datagrid_ips.Rows[i].Cells[2].Value = "";
                                datagrid_ips.Rows[i].Cells[3].Value = "";
                            }
                        }

                        bg_pingall.RunWorkerAsync();
                    }
                }

                if (btn.Name == btn_network_search.Name)
                {
                    if (!bg_refresh.IsBusy)
                    {
                        if (datagrid_network.Rows.Count > 0)
                            datagrid_network.Rows.Clear();

                        bg_refresh.RunWorkerAsync();
                    }
                }

                if (btn.Name == btn_settings_refresh.Name)
                {
                    if (!bg_settings_refresh.IsBusy)
                    {
                        bg_settings_refresh.RunWorkerAsync();
                    }
                }

                if (btn.Name == btn_settings_add.Name)
                {
                    if (!bg_settings_add.IsBusy)
                    {
                        bg_settings_add.RunWorkerAsync();
                    }
                }

                if (btn.Name == btn_settings_edit.Name)
                {
                    if (!bg_settings_edit.IsBusy)
                    {
                        bg_settings_edit.RunWorkerAsync();
                    }
                }

                if (btn.Name == btn_settings_delete.Name)
                {
                    if (MessageBox.Show("Are you Sure?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!bg_settings_delete.IsBusy)
                            bg_settings_delete.RunWorkerAsync();
                    }
                }
            });
        }

        private void Design_editor()
        {
            this.Invoker(() =>
            {
                if (datagrid_ips.Rows.Count > 0)
                {
                    btn_ip_delete.Enabled = true;

                    btn_ip_ping.Enabled = true;

                    btn_ip_deleteall.Enabled = true;
                }
                else
                {
                    btn_ip_delete.Enabled = false;

                    btn_ip_ping.Enabled = false;

                    btn_ip_deleteall.Enabled = false;
                }

                if (datagrid_ips.Rows.Count > 1)
                    btn_ip_pingall.Enabled = true;
                else
                    btn_ip_pingall.Enabled = false;

                if (combobox_networkT.SelectedIndex != -1)
                    btn_settings_add.Enabled = true;
                else
                    btn_settings_add.Enabled = false;

                if (datagrid_settings.Rows.Count > 0)
                {
                    btn_settings_edit.Enabled = true;
                    btn_settings_delete.Enabled = true;
                    datagrid_settings.Enabled = true;
                }
                else
                {
                    btn_settings_edit.Enabled = false;
                    btn_settings_delete.Enabled = false;
                    datagrid_settings.Enabled=false;
                }
            });
        }

        private void Settings_Designer(bool status)
        {
            this.Invoker(() => { btn_settings_refresh.Enabled = combobox_networkT.Enabled = datagrid_settings.Enabled = status; });
        }

        private void Ping_Designer(bool status)
        {
            this.Invoker(() => { btn_ip_ping.Enabled = btn_ip_pingall.Enabled = btn_ip_addip.Enabled = btn_ip_delete.Enabled = btn_ip_deleteall.Enabled = datagrid_ips.Enabled = status; });
        }

        private void Network_Designer(bool status)
        {
            this.Invoker(() => { txtbox_network_start.Enabled = txtbox_network_end.Enabled = btn_network_search.Enabled = datagrid_network.Enabled = status; });
        }

        private void datagrid_settings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Invoker(() =>
            {
                if (datagrid_settings.Rows.Count > 0 && e.ColumnIndex == 0)
                    buttons(btn_settings_edit, e);
            });
        }

        // --------------------------------------{ Ping }--------------------------------------

        private void bg_addip_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoker(() =>
            {
                string input = "";

                if (Inputbox.InputBox(ref input, "Add Ip") != DialogResult.OK)
                {
                    bg_addip.CancelAsync();
                    return;
                }

                bool flag = true;

                if (datagrid_ips.Rows.Count > 0)
                {
                    for (int i = 0; i < datagrid_ips.Rows.Count; i++)
                    {
                        if (datagrid_ips.Rows[i].Cells[0].Value.ToString() == input)
                        {
                            flag = false;
                            break;
                        }
                    }
                }

                if (flag)
                {
                    Ping_Designer(false);

                    IP.AddIp(this, input);

                    Ping_Designer(true);
                    Design_editor();
                }
                else
                    MessageBox.Show("IP Already Added!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });
        }

        private void bg_ping_DoWork(object sender, DoWorkEventArgs e)
        {
            Ping_Designer(false);

            IP.Ping(this);

            Ping_Designer(true);
            Design_editor();
        }

        private void bg_delete_DoWork(object sender, DoWorkEventArgs e)
        {
            Ping_Designer(false);

            IP.DeleteIp(this);

            Ping_Designer(true);
            Design_editor();
        }

        private void bg_deleteall_DoWork(object sender, DoWorkEventArgs e)
        {
            Ping_Designer(false);

            IP.DeleteAllIp(this);

            Ping_Designer(true);
            Design_editor();
        }

        private void bg_pingall_DoWork(object sender, DoWorkEventArgs e)
        {
            Ping_Designer(false);

            IP.PingAll(this);

            Ping_Designer(true);
            Design_editor();
        }

        // ------------------------------------ { Network } ------------------------------------

        private void bg_refresh_DoWork(object sender, DoWorkEventArgs e)
        {
            Network_Designer(false);

            Network.Refresh(this);

            Network_Designer(true);
        }

        private void txtbox_network_TextChange(object sender, EventArgs e)
        {
            this.Invoker(() =>
            {
                if (!string.IsNullOrEmpty(txtbox_network_start.Text) && !string.IsNullOrEmpty(txtbox_network_end.Text))
                    btn_network_search.Enabled = true;
                else
                    btn_network_search.Enabled = false;
            });
        }

        // ------------------------------------ { Settings } ------------------------------------

        private void combobox_networkT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bg_settings_combobox.IsBusy)
            {
                bg_settings_combobox.RunWorkerAsync();
            }
        }

        private void bg_settings_refresh_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoker(() =>
            {
                combobox_networkT.SelectedIndex = -1;

            });

            Settings_Designer(false);

            Settings.Refresh_Network(this);

            Settings_Designer(true);
        }

        private void bg_settings_add_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoker(() =>
            {
                if (combobox_networkT.SelectedIndex != -1)
                {
                    string input = "";

                    if (Inputbox.InputBox(ref input, "Add Ip") != DialogResult.OK)
                    {
                        bg_settings_add.CancelAsync();
                        return;
                    }

                    bool flag = true;

                    if (datagrid_settings.Rows.Count > 0)
                    {
                        for (int i = 0; i < datagrid_settings.Rows.Count; i++)
                        {
                            if (datagrid_settings.Rows[i].Cells[0].Value.ToString() == input)
                            {
                                flag = false;
                                break;
                            }
                        }
                    }

                    if (flag)
                    {
                        Settings_Designer(false);

                        Settings.AddIP(this, input);

                        Settings_Designer(true);
                    }
                    else
                        MessageBox.Show("IP Already Added!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            });
        }

        private void bg_settings_edit_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoker(() =>
            {
                if (datagrid_settings.Rows.Count > 0)
                {
                    string ipTarget = datagrid_settings.CurrentRow.Cells[0].Value.ToString();
                    IPAddress oldIpAddress;

                    if (ipTarget.Trim().Split('.').Length != 4 || !IPAddress.TryParse(ipTarget.Trim(), out oldIpAddress))
                    {
                        MessageBox.Show("IP is not accessible", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    string input = "";

                    if (Inputbox.InputBox(ref input, "New Ip", oldIpAddress.ToString()) != DialogResult.OK)
                    {
                        bg_settings_edit.CancelAsync();
                        return;
                    }

                    bool flag = true;

                    if (datagrid_settings.Rows.Count > 0)
                    {
                        for (int i = 0; i < datagrid_settings.Rows.Count; i++)
                        {
                            if (datagrid_settings.Rows[i].Cells[0].Value.ToString() == input)
                            {
                                flag = false;
                                break;
                            }
                        }
                    }

                    if (flag)
                    {
                        Settings_Designer(false);

                        Settings.EditIP(this, input, oldIpAddress);

                        Settings_Designer(true);
                    }
                    else
                        MessageBox.Show("IP Already Added!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            });
        }

        private void bg_settings_delete_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoker(() =>
            {
                if (datagrid_settings.Rows.Count > 0)
                {
                    string ipTarget = datagrid_settings.CurrentRow.Cells[0].Value.ToString();
                    IPAddress IpToRemove;

                    if (ipTarget.Trim().Split('.').Length != 4 || !IPAddress.TryParse(ipTarget.Trim(), out IpToRemove))
                    {
                        MessageBox.Show("IP is not accessible", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }

                    Settings_Designer(false);

                    Settings.DeleteIP(this, IpToRemove);

                    Settings_Designer(true);
                }
            });
        }

        private void bg_settings_combobox_DoWork(object sender, DoWorkEventArgs e)
        {
            Settings_Designer(false);

            Settings.Refresh_datagrid(this);

            Settings_Designer(true);
        }
    }
}
