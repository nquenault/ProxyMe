namespace ProxyMe
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ui_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TaskIconMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAtStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingAllProxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllProxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_SpecProxy = new System.Windows.Forms.ToolStripTextBox();
            this.refreshProxiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_Proxies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProxiesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ui_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ui_ExtraStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskIconMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ProxiesMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_icon
            // 
            this.ui_icon.ContextMenuStrip = this.TaskIconMenuStrip1;
            this.ui_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("ui_icon.Icon")));
            this.ui_icon.Text = "Proxy Me";
            this.ui_icon.Visible = true;
            this.ui_icon.DoubleClick += new System.EventHandler(this.ui_Icon_DoubleClick);
            // 
            // TaskIconMenuStrip1
            // 
            this.TaskIconMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.TaskIconMenuStrip1.Name = "TaskIconMenuStrip1";
            this.TaskIconMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TaskIconMenuStrip1.Size = new System.Drawing.Size(153, 76);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.proxiesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ui_Connect,
            this.ui_SpecProxy,
            this.refreshProxiesToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(923, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runAtStartupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // runAtStartupToolStripMenuItem
            // 
            this.runAtStartupToolStripMenuItem.CheckOnClick = true;
            this.runAtStartupToolStripMenuItem.Name = "runAtStartupToolStripMenuItem";
            this.runAtStartupToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.runAtStartupToolStripMenuItem.Text = "Run at startup";
            this.runAtStartupToolStripMenuItem.Click += new System.EventHandler(this.runAtStartupToolStripMenuItem_Click);
            // 
            // proxiesToolStripMenuItem
            // 
            this.proxiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingAllProxiesToolStripMenuItem,
            this.checkAllProxiesToolStripMenuItem});
            this.proxiesToolStripMenuItem.Name = "proxiesToolStripMenuItem";
            this.proxiesToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.proxiesToolStripMenuItem.Text = "&Proxies";
            // 
            // pingAllProxiesToolStripMenuItem
            // 
            this.pingAllProxiesToolStripMenuItem.Name = "pingAllProxiesToolStripMenuItem";
            this.pingAllProxiesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pingAllProxiesToolStripMenuItem.Text = "Ping all proxies";
            this.pingAllProxiesToolStripMenuItem.Click += new System.EventHandler(this.pingAllProxiesToolStripMenuItem_Click);
            // 
            // checkAllProxiesToolStripMenuItem
            // 
            this.checkAllProxiesToolStripMenuItem.Name = "checkAllProxiesToolStripMenuItem";
            this.checkAllProxiesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.checkAllProxiesToolStripMenuItem.Text = "Check all proxies";
            this.checkAllProxiesToolStripMenuItem.Click += new System.EventHandler(this.checkAllProxiesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 23);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ui_Connect
            // 
            this.ui_Connect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ui_Connect.Image = ((System.Drawing.Image)(resources.GetObject("ui_Connect.Image")));
            this.ui_Connect.Name = "ui_Connect";
            this.ui_Connect.Size = new System.Drawing.Size(80, 23);
            this.ui_Connect.Text = "Connect";
            this.ui_Connect.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ui_SpecProxy
            // 
            this.ui_SpecProxy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ui_SpecProxy.Name = "ui_SpecProxy";
            this.ui_SpecProxy.Size = new System.Drawing.Size(150, 23);
            // 
            // refreshProxiesToolStripMenuItem
            // 
            this.refreshProxiesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshProxiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshProxiesToolStripMenuItem.Image")));
            this.refreshProxiesToolStripMenuItem.Name = "refreshProxiesToolStripMenuItem";
            this.refreshProxiesToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.refreshProxiesToolStripMenuItem.Text = "Refresh proxies";
            this.refreshProxiesToolStripMenuItem.Click += new System.EventHandler(this.refreshProxiesToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.disconnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disconnectToolStripMenuItem.Image")));
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Visible = false;
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // ui_Proxies
            // 
            this.ui_Proxies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_Proxies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader9});
            this.ui_Proxies.ContextMenuStrip = this.ProxiesMenuStrip;
            this.ui_Proxies.FullRowSelect = true;
            this.ui_Proxies.Location = new System.Drawing.Point(0, 26);
            this.ui_Proxies.MultiSelect = false;
            this.ui_Proxies.Name = "ui_Proxies";
            this.ui_Proxies.ShowGroups = false;
            this.ui_Proxies.Size = new System.Drawing.Size(923, 419);
            this.ui_Proxies.TabIndex = 1;
            this.ui_Proxies.UseCompatibleStateImageBehavior = false;
            this.ui_Proxies.View = System.Windows.Forms.View.Details;
            this.ui_Proxies.DoubleClick += new System.EventHandler(this.ui_Proxies_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Port";
            this.columnHeader2.Width = 56;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Code";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Country";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Anonymity";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Google";
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "HTTPS";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Last Check";
            this.columnHeader8.Width = 99;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ping";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Working";
            this.columnHeader9.Width = 122;
            // 
            // ProxiesMenuStrip
            // 
            this.ProxiesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.checkProxyToolStripMenuItem});
            this.ProxiesMenuStrip.Name = "ProxiesMenuStrip";
            this.ProxiesMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ProxiesMenuStrip.Size = new System.Drawing.Size(190, 48);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.connectToolStripMenuItem.Text = "Connect..";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // checkProxyToolStripMenuItem
            // 
            this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
            this.checkProxyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.checkProxyToolStripMenuItem.Text = "Check and ping proxy";
            this.checkProxyToolStripMenuItem.Click += new System.EventHandler(this.checkProxyToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ui_Status,
            this.ui_ExtraStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(923, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ui_Status
            // 
            this.ui_Status.Name = "ui_Status";
            this.ui_Status.Size = new System.Drawing.Size(150, 17);
            this.ui_Status.Text = "Currently no proxy running";
            // 
            // ui_ExtraStatus
            // 
            this.ui_ExtraStatus.Name = "ui_ExtraStatus";
            this.ui_ExtraStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "&Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 468);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ui_Proxies);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy Me";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.TaskIconMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProxiesMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ui_icon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ListView ui_Proxies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ui_Status;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip ProxiesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkProxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshProxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ui_ExtraStatus;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripMenuItem proxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingAllProxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllProxiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ui_SpecProxy;
        private System.Windows.Forms.ToolStripMenuItem ui_Connect;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TaskIconMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAtStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    }
}

