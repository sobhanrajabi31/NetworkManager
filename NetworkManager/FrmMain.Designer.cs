namespace NetworkManager
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TabMain = new System.Windows.Forms.TabControl();
            this.tab_network = new System.Windows.Forms.TabPage();
            this.datagrid_network = new System.Windows.Forms.DataGridView();
            this.network_col_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.network_col_hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.network_col_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.network_option = new System.Windows.Forms.Panel();
            this.lbl_network_end = new System.Windows.Forms.Label();
            this.txtbox_network_end = new System.Windows.Forms.TextBox();
            this.lbl_network_start = new System.Windows.Forms.Label();
            this.txtbox_network_start = new System.Windows.Forms.TextBox();
            this.btn_network_search = new System.Windows.Forms.Button();
            this.tab_ping = new System.Windows.Forms.TabPage();
            this.datagrid_ips = new System.Windows.Forms.DataGridView();
            this.col_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip_option = new System.Windows.Forms.Panel();
            this.btn_ip_ping = new System.Windows.Forms.Button();
            this.btn_ip_pingall = new System.Windows.Forms.Button();
            this.btn_ip_deleteall = new System.Windows.Forms.Button();
            this.btn_ip_delete = new System.Windows.Forms.Button();
            this.btn_ip_addip = new System.Windows.Forms.Button();
            this.tab_setting = new System.Windows.Forms.TabPage();
            this.btn_settings_refresh = new System.Windows.Forms.Button();
            this.btn_settings_delete = new System.Windows.Forms.Button();
            this.btn_settings_edit = new System.Windows.Forms.Button();
            this.btn_settings_add = new System.Windows.Forms.Button();
            this.combobox_networkT = new System.Windows.Forms.ComboBox();
            this.datagrid_settings = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bg_pingall = new System.ComponentModel.BackgroundWorker();
            this.bg_ping = new System.ComponentModel.BackgroundWorker();
            this.bg_addip = new System.ComponentModel.BackgroundWorker();
            this.bg_refresh = new System.ComponentModel.BackgroundWorker();
            this.bg_delete = new System.ComponentModel.BackgroundWorker();
            this.bg_deleteall = new System.ComponentModel.BackgroundWorker();
            this.bg_settings_refresh = new System.ComponentModel.BackgroundWorker();
            this.bg_settings_add = new System.ComponentModel.BackgroundWorker();
            this.bg_settings_edit = new System.ComponentModel.BackgroundWorker();
            this.bg_settings_delete = new System.ComponentModel.BackgroundWorker();
            this.bg_settings_combobox = new System.ComponentModel.BackgroundWorker();
            this.TabMain.SuspendLayout();
            this.tab_network.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_network)).BeginInit();
            this.network_option.SuspendLayout();
            this.tab_ping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ips)).BeginInit();
            this.ip_option.SuspendLayout();
            this.tab_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_settings)).BeginInit();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.tab_network);
            this.TabMain.Controls.Add(this.tab_ping);
            this.TabMain.Controls.Add(this.tab_setting);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Location = new System.Drawing.Point(0, 0);
            this.TabMain.Margin = new System.Windows.Forms.Padding(4);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(644, 269);
            this.TabMain.TabIndex = 0;
            // 
            // tab_network
            // 
            this.tab_network.Controls.Add(this.datagrid_network);
            this.tab_network.Controls.Add(this.network_option);
            this.tab_network.Location = new System.Drawing.Point(4, 25);
            this.tab_network.Name = "tab_network";
            this.tab_network.Padding = new System.Windows.Forms.Padding(3);
            this.tab_network.Size = new System.Drawing.Size(636, 240);
            this.tab_network.TabIndex = 2;
            this.tab_network.Text = "Network";
            this.tab_network.UseVisualStyleBackColor = true;
            // 
            // datagrid_network
            // 
            this.datagrid_network.AllowUserToAddRows = false;
            this.datagrid_network.AllowUserToDeleteRows = false;
            this.datagrid_network.AllowUserToResizeColumns = false;
            this.datagrid_network.AllowUserToResizeRows = false;
            this.datagrid_network.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_network.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_network.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.network_col_ip,
            this.network_col_hostname,
            this.network_col_time});
            this.datagrid_network.Location = new System.Drawing.Point(4, 4);
            this.datagrid_network.MultiSelect = false;
            this.datagrid_network.Name = "datagrid_network";
            this.datagrid_network.ReadOnly = true;
            this.datagrid_network.RowHeadersVisible = false;
            this.datagrid_network.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_network.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_network.ShowEditingIcon = false;
            this.datagrid_network.Size = new System.Drawing.Size(628, 180);
            this.datagrid_network.TabIndex = 2;
            // 
            // network_col_ip
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.network_col_ip.DefaultCellStyle = dataGridViewCellStyle1;
            this.network_col_ip.HeaderText = "IP";
            this.network_col_ip.Name = "network_col_ip";
            this.network_col_ip.ReadOnly = true;
            this.network_col_ip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.network_col_ip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.network_col_ip.Width = 205;
            // 
            // network_col_hostname
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.network_col_hostname.DefaultCellStyle = dataGridViewCellStyle2;
            this.network_col_hostname.HeaderText = "HOSTNAME";
            this.network_col_hostname.Name = "network_col_hostname";
            this.network_col_hostname.ReadOnly = true;
            this.network_col_hostname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.network_col_hostname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.network_col_hostname.Width = 205;
            // 
            // network_col_time
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.network_col_time.DefaultCellStyle = dataGridViewCellStyle3;
            this.network_col_time.HeaderText = "TIME";
            this.network_col_time.Name = "network_col_time";
            this.network_col_time.ReadOnly = true;
            this.network_col_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.network_col_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.network_col_time.Width = 205;
            // 
            // network_option
            // 
            this.network_option.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.network_option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.network_option.Controls.Add(this.lbl_network_end);
            this.network_option.Controls.Add(this.txtbox_network_end);
            this.network_option.Controls.Add(this.lbl_network_start);
            this.network_option.Controls.Add(this.txtbox_network_start);
            this.network_option.Controls.Add(this.btn_network_search);
            this.network_option.Location = new System.Drawing.Point(4, 185);
            this.network_option.Name = "network_option";
            this.network_option.Size = new System.Drawing.Size(628, 51);
            this.network_option.TabIndex = 3;
            // 
            // lbl_network_end
            // 
            this.lbl_network_end.AutoSize = true;
            this.lbl_network_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_network_end.Location = new System.Drawing.Point(403, 10);
            this.lbl_network_end.Name = "lbl_network_end";
            this.lbl_network_end.Size = new System.Drawing.Size(20, 25);
            this.lbl_network_end.TabIndex = 3;
            this.lbl_network_end.Text = "-";
            // 
            // txtbox_network_end
            // 
            this.txtbox_network_end.Location = new System.Drawing.Point(429, 13);
            this.txtbox_network_end.MaxLength = 15;
            this.txtbox_network_end.Name = "txtbox_network_end";
            this.txtbox_network_end.Size = new System.Drawing.Size(114, 23);
            this.txtbox_network_end.TabIndex = 1;
            this.txtbox_network_end.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_network_end.TextChanged += new System.EventHandler(this.txtbox_network_TextChange);
            // 
            // lbl_network_start
            // 
            this.lbl_network_start.AutoSize = true;
            this.lbl_network_start.Location = new System.Drawing.Point(228, 16);
            this.lbl_network_start.Name = "lbl_network_start";
            this.lbl_network_start.Size = new System.Drawing.Size(54, 17);
            this.lbl_network_start.TabIndex = 3;
            this.lbl_network_start.Text = "Range:";
            // 
            // txtbox_network_start
            // 
            this.txtbox_network_start.Location = new System.Drawing.Point(283, 13);
            this.txtbox_network_start.MaxLength = 15;
            this.txtbox_network_start.Name = "txtbox_network_start";
            this.txtbox_network_start.Size = new System.Drawing.Size(114, 23);
            this.txtbox_network_start.TabIndex = 1;
            this.txtbox_network_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_network_start.TextChanged += new System.EventHandler(this.txtbox_network_TextChange);
            // 
            // btn_network_search
            // 
            this.btn_network_search.Enabled = false;
            this.btn_network_search.Location = new System.Drawing.Point(84, 7);
            this.btn_network_search.Name = "btn_network_search";
            this.btn_network_search.Size = new System.Drawing.Size(98, 35);
            this.btn_network_search.TabIndex = 0;
            this.btn_network_search.Text = "Search";
            this.btn_network_search.UseVisualStyleBackColor = true;
            this.btn_network_search.Click += new System.EventHandler(this.buttons);
            // 
            // tab_ping
            // 
            this.tab_ping.Controls.Add(this.datagrid_ips);
            this.tab_ping.Controls.Add(this.ip_option);
            this.tab_ping.Location = new System.Drawing.Point(4, 25);
            this.tab_ping.Margin = new System.Windows.Forms.Padding(4);
            this.tab_ping.Name = "tab_ping";
            this.tab_ping.Padding = new System.Windows.Forms.Padding(4);
            this.tab_ping.Size = new System.Drawing.Size(636, 240);
            this.tab_ping.TabIndex = 0;
            this.tab_ping.Text = "Ping";
            this.tab_ping.UseVisualStyleBackColor = true;
            // 
            // datagrid_ips
            // 
            this.datagrid_ips.AllowUserToAddRows = false;
            this.datagrid_ips.AllowUserToDeleteRows = false;
            this.datagrid_ips.AllowUserToResizeColumns = false;
            this.datagrid_ips.AllowUserToResizeRows = false;
            this.datagrid_ips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_ips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ip,
            this.col_hostname,
            this.col_time,
            this.col_status});
            this.datagrid_ips.Location = new System.Drawing.Point(4, 4);
            this.datagrid_ips.MultiSelect = false;
            this.datagrid_ips.Name = "datagrid_ips";
            this.datagrid_ips.ReadOnly = true;
            this.datagrid_ips.RowHeadersVisible = false;
            this.datagrid_ips.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_ips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_ips.ShowEditingIcon = false;
            this.datagrid_ips.Size = new System.Drawing.Size(628, 180);
            this.datagrid_ips.TabIndex = 0;
            // 
            // col_ip
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_ip.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_ip.HeaderText = "IP";
            this.col_ip.Name = "col_ip";
            this.col_ip.ReadOnly = true;
            this.col_ip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_ip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_ip.Width = 150;
            // 
            // col_hostname
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_hostname.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_hostname.HeaderText = "HOSTNAME";
            this.col_hostname.Name = "col_hostname";
            this.col_hostname.ReadOnly = true;
            this.col_hostname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_hostname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_hostname.Width = 165;
            // 
            // col_time
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_time.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_time.HeaderText = "TIME";
            this.col_time.Name = "col_time";
            this.col_time.ReadOnly = true;
            this.col_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_time.Width = 150;
            // 
            // col_status
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_status.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_status.HeaderText = "STATUS";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_status.Width = 140;
            // 
            // ip_option
            // 
            this.ip_option.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ip_option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip_option.Controls.Add(this.btn_ip_ping);
            this.ip_option.Controls.Add(this.btn_ip_pingall);
            this.ip_option.Controls.Add(this.btn_ip_deleteall);
            this.ip_option.Controls.Add(this.btn_ip_delete);
            this.ip_option.Controls.Add(this.btn_ip_addip);
            this.ip_option.Location = new System.Drawing.Point(4, 185);
            this.ip_option.Name = "ip_option";
            this.ip_option.Size = new System.Drawing.Size(628, 51);
            this.ip_option.TabIndex = 1;
            // 
            // btn_ip_ping
            // 
            this.btn_ip_ping.Enabled = false;
            this.btn_ip_ping.Location = new System.Drawing.Point(115, 7);
            this.btn_ip_ping.Name = "btn_ip_ping";
            this.btn_ip_ping.Size = new System.Drawing.Size(98, 35);
            this.btn_ip_ping.TabIndex = 0;
            this.btn_ip_ping.Text = "Ping";
            this.btn_ip_ping.UseVisualStyleBackColor = true;
            this.btn_ip_ping.Click += new System.EventHandler(this.buttons);
            // 
            // btn_ip_pingall
            // 
            this.btn_ip_pingall.Enabled = false;
            this.btn_ip_pingall.Location = new System.Drawing.Point(13, 7);
            this.btn_ip_pingall.Name = "btn_ip_pingall";
            this.btn_ip_pingall.Size = new System.Drawing.Size(98, 35);
            this.btn_ip_pingall.TabIndex = 0;
            this.btn_ip_pingall.Text = "Ping All";
            this.btn_ip_pingall.UseVisualStyleBackColor = true;
            this.btn_ip_pingall.Click += new System.EventHandler(this.buttons);
            // 
            // btn_ip_deleteall
            // 
            this.btn_ip_deleteall.Enabled = false;
            this.btn_ip_deleteall.Location = new System.Drawing.Point(514, 7);
            this.btn_ip_deleteall.Name = "btn_ip_deleteall";
            this.btn_ip_deleteall.Size = new System.Drawing.Size(98, 35);
            this.btn_ip_deleteall.TabIndex = 0;
            this.btn_ip_deleteall.Text = "DeleteAll";
            this.btn_ip_deleteall.UseVisualStyleBackColor = true;
            this.btn_ip_deleteall.Click += new System.EventHandler(this.buttons);
            // 
            // btn_ip_delete
            // 
            this.btn_ip_delete.Enabled = false;
            this.btn_ip_delete.Location = new System.Drawing.Point(411, 7);
            this.btn_ip_delete.Name = "btn_ip_delete";
            this.btn_ip_delete.Size = new System.Drawing.Size(98, 35);
            this.btn_ip_delete.TabIndex = 0;
            this.btn_ip_delete.Text = "Delete";
            this.btn_ip_delete.UseVisualStyleBackColor = true;
            this.btn_ip_delete.Click += new System.EventHandler(this.buttons);
            // 
            // btn_ip_addip
            // 
            this.btn_ip_addip.Location = new System.Drawing.Point(263, 7);
            this.btn_ip_addip.Name = "btn_ip_addip";
            this.btn_ip_addip.Size = new System.Drawing.Size(98, 35);
            this.btn_ip_addip.TabIndex = 0;
            this.btn_ip_addip.Text = "Add Ip";
            this.btn_ip_addip.UseVisualStyleBackColor = true;
            this.btn_ip_addip.Click += new System.EventHandler(this.buttons);
            // 
            // tab_setting
            // 
            this.tab_setting.Controls.Add(this.btn_settings_refresh);
            this.tab_setting.Controls.Add(this.btn_settings_delete);
            this.tab_setting.Controls.Add(this.btn_settings_edit);
            this.tab_setting.Controls.Add(this.btn_settings_add);
            this.tab_setting.Controls.Add(this.combobox_networkT);
            this.tab_setting.Controls.Add(this.datagrid_settings);
            this.tab_setting.Location = new System.Drawing.Point(4, 25);
            this.tab_setting.Name = "tab_setting";
            this.tab_setting.Padding = new System.Windows.Forms.Padding(3);
            this.tab_setting.Size = new System.Drawing.Size(636, 240);
            this.tab_setting.TabIndex = 3;
            this.tab_setting.Text = "Settings";
            this.tab_setting.UseVisualStyleBackColor = true;
            // 
            // btn_settings_refresh
            // 
            this.btn_settings_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings_refresh.Location = new System.Drawing.Point(19, 195);
            this.btn_settings_refresh.Name = "btn_settings_refresh";
            this.btn_settings_refresh.Size = new System.Drawing.Size(56, 24);
            this.btn_settings_refresh.TabIndex = 4;
            this.btn_settings_refresh.Text = "Refresh";
            this.btn_settings_refresh.UseVisualStyleBackColor = true;
            this.btn_settings_refresh.Click += new System.EventHandler(this.buttons);
            // 
            // btn_settings_delete
            // 
            this.btn_settings_delete.Enabled = false;
            this.btn_settings_delete.Location = new System.Drawing.Point(520, 189);
            this.btn_settings_delete.Name = "btn_settings_delete";
            this.btn_settings_delete.Size = new System.Drawing.Size(98, 35);
            this.btn_settings_delete.TabIndex = 3;
            this.btn_settings_delete.Text = "Delete";
            this.btn_settings_delete.UseVisualStyleBackColor = true;
            this.btn_settings_delete.Click += new System.EventHandler(this.buttons);
            // 
            // btn_settings_edit
            // 
            this.btn_settings_edit.Enabled = false;
            this.btn_settings_edit.Location = new System.Drawing.Point(416, 189);
            this.btn_settings_edit.Name = "btn_settings_edit";
            this.btn_settings_edit.Size = new System.Drawing.Size(98, 35);
            this.btn_settings_edit.TabIndex = 3;
            this.btn_settings_edit.Text = "Edit";
            this.btn_settings_edit.UseVisualStyleBackColor = true;
            this.btn_settings_edit.Click += new System.EventHandler(this.buttons);
            // 
            // btn_settings_add
            // 
            this.btn_settings_add.Enabled = false;
            this.btn_settings_add.Location = new System.Drawing.Point(312, 189);
            this.btn_settings_add.Name = "btn_settings_add";
            this.btn_settings_add.Size = new System.Drawing.Size(98, 35);
            this.btn_settings_add.TabIndex = 3;
            this.btn_settings_add.Text = "Add";
            this.btn_settings_add.UseVisualStyleBackColor = true;
            this.btn_settings_add.Click += new System.EventHandler(this.buttons);
            // 
            // combobox_networkT
            // 
            this.combobox_networkT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_networkT.FormattingEnabled = true;
            this.combobox_networkT.Location = new System.Drawing.Point(81, 195);
            this.combobox_networkT.MaxDropDownItems = 1;
            this.combobox_networkT.Name = "combobox_networkT";
            this.combobox_networkT.Size = new System.Drawing.Size(214, 24);
            this.combobox_networkT.TabIndex = 2;
            this.combobox_networkT.SelectedIndexChanged += new System.EventHandler(this.combobox_networkT_SelectedIndexChanged);
            // 
            // datagrid_settings
            // 
            this.datagrid_settings.AllowUserToAddRows = false;
            this.datagrid_settings.AllowUserToDeleteRows = false;
            this.datagrid_settings.AllowUserToResizeColumns = false;
            this.datagrid_settings.AllowUserToResizeRows = false;
            this.datagrid_settings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_settings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.datagrid_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagrid_settings.Location = new System.Drawing.Point(3, 3);
            this.datagrid_settings.MultiSelect = false;
            this.datagrid_settings.Name = "datagrid_settings";
            this.datagrid_settings.ReadOnly = true;
            this.datagrid_settings.RowHeadersVisible = false;
            this.datagrid_settings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_settings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_settings.ShowEditingIcon = false;
            this.datagrid_settings.Size = new System.Drawing.Size(630, 173);
            this.datagrid_settings.TabIndex = 1;
            this.datagrid_settings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_settings_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.HeaderText = "IP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "SUBMASK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // bg_pingall
            // 
            this.bg_pingall.WorkerReportsProgress = true;
            this.bg_pingall.WorkerSupportsCancellation = true;
            this.bg_pingall.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_pingall_DoWork);
            // 
            // bg_ping
            // 
            this.bg_ping.WorkerReportsProgress = true;
            this.bg_ping.WorkerSupportsCancellation = true;
            this.bg_ping.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_ping_DoWork);
            // 
            // bg_addip
            // 
            this.bg_addip.WorkerReportsProgress = true;
            this.bg_addip.WorkerSupportsCancellation = true;
            this.bg_addip.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_addip_DoWork);
            // 
            // bg_refresh
            // 
            this.bg_refresh.WorkerReportsProgress = true;
            this.bg_refresh.WorkerSupportsCancellation = true;
            this.bg_refresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_refresh_DoWork);
            // 
            // bg_delete
            // 
            this.bg_delete.WorkerReportsProgress = true;
            this.bg_delete.WorkerSupportsCancellation = true;
            this.bg_delete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_delete_DoWork);
            // 
            // bg_deleteall
            // 
            this.bg_deleteall.WorkerReportsProgress = true;
            this.bg_deleteall.WorkerSupportsCancellation = true;
            this.bg_deleteall.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_deleteall_DoWork);
            // 
            // bg_settings_refresh
            // 
            this.bg_settings_refresh.WorkerReportsProgress = true;
            this.bg_settings_refresh.WorkerSupportsCancellation = true;
            this.bg_settings_refresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_settings_refresh_DoWork);
            // 
            // bg_settings_add
            // 
            this.bg_settings_add.WorkerReportsProgress = true;
            this.bg_settings_add.WorkerSupportsCancellation = true;
            this.bg_settings_add.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_settings_add_DoWork);
            // 
            // bg_settings_edit
            // 
            this.bg_settings_edit.WorkerReportsProgress = true;
            this.bg_settings_edit.WorkerSupportsCancellation = true;
            this.bg_settings_edit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_settings_edit_DoWork);
            // 
            // bg_settings_delete
            // 
            this.bg_settings_delete.WorkerReportsProgress = true;
            this.bg_settings_delete.WorkerSupportsCancellation = true;
            this.bg_settings_delete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_settings_delete_DoWork);
            // 
            // bg_settings_combobox
            // 
            this.bg_settings_combobox.WorkerReportsProgress = true;
            this.bg_settings_combobox.WorkerSupportsCancellation = true;
            this.bg_settings_combobox.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_settings_combobox_DoWork);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 269);
            this.Controls.Add(this.TabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TabMain.ResumeLayout(false);
            this.tab_network.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_network)).EndInit();
            this.network_option.ResumeLayout(false);
            this.network_option.PerformLayout();
            this.tab_ping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ips)).EndInit();
            this.ip_option.ResumeLayout(false);
            this.tab_setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_settings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage tab_ping;
        private System.Windows.Forms.Panel ip_option;
        private System.Windows.Forms.TabPage tab_network;
        private System.Windows.Forms.Panel network_option;
        private System.ComponentModel.BackgroundWorker bg_pingall;
        private System.ComponentModel.BackgroundWorker bg_ping;
        private System.ComponentModel.BackgroundWorker bg_addip;
        private System.ComponentModel.BackgroundWorker bg_refresh;
        private System.ComponentModel.BackgroundWorker bg_delete;
        private System.ComponentModel.BackgroundWorker bg_deleteall;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn network_col_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn network_col_hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn network_col_time;
        private System.Windows.Forms.TabPage tab_setting;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.ComponentModel.BackgroundWorker bg_settings_refresh;
        private System.ComponentModel.BackgroundWorker bg_settings_add;
        private System.ComponentModel.BackgroundWorker bg_settings_edit;
        private System.ComponentModel.BackgroundWorker bg_settings_delete;
        private System.ComponentModel.BackgroundWorker bg_settings_combobox;
        public System.Windows.Forms.Button btn_network_search;
        public System.Windows.Forms.TextBox txtbox_network_start;
        public System.Windows.Forms.Label lbl_network_start;
        public System.Windows.Forms.Label lbl_network_end;
        public System.Windows.Forms.TextBox txtbox_network_end;
        public System.Windows.Forms.DataGridView datagrid_network;
        public System.Windows.Forms.DataGridView datagrid_ips;
        public System.Windows.Forms.Button btn_ip_addip;
        public System.Windows.Forms.Button btn_ip_pingall;
        public System.Windows.Forms.Button btn_ip_ping;
        public System.Windows.Forms.Button btn_ip_delete;
        public System.Windows.Forms.Button btn_ip_deleteall;
        public System.Windows.Forms.DataGridView datagrid_settings;
        public System.Windows.Forms.ComboBox combobox_networkT;
        public System.Windows.Forms.Button btn_settings_delete;
        public System.Windows.Forms.Button btn_settings_edit;
        public System.Windows.Forms.Button btn_settings_add;
        public System.Windows.Forms.Button btn_settings_refresh;
    }
}

