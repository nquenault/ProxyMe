using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ProxyMe.Properties;
using System.Net.NetworkInformation;
using System.Linq;
using Microsoft.Win32;

namespace ProxyMe
{
    public partial class Main : Form
    {
        private ToolStripItem _connectItem = null;
        private ToolStripItem _disconnectItem = null;

        public Main()
        {
            MessageBox.Show("Here2");
            InitializeComponent();
            MessageBox.Show("Here3");

            /*
            runAtStartupToolStripMenuItem.Checked = IsRunningStartup();

            _connectItem = new ToolStripMenuItem() { Text = "&Connect", Enabled = false };
            _disconnectItem = new ToolStripMenuItem() { Text = "&Disconnect", Enabled = false };

            _connectItem.Click += connectToolStripMenuItem1_Click;
            _disconnectItem.Click += disconnectToolStripMenuItem_Click;

            TaskIconMenuStrip1.Items.Insert(0, _connectItem);
            TaskIconMenuStrip1.Items.Insert(1, _disconnectItem);

            _bgProxyCheckThread = new Thread(BackgroundCheckCurrentProxy);
            _bgProxyCheckThread.IsBackground = true;
            _bgProxyCheckThread.Start();

            RefreshProxies("Loading proxies..");*/
        }

        private Thread _bgProxyCheckThread = null;

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshProxies(string loadingString = "")
        {
            Utility.TryInvoke(ui_Proxies, (Action)delegate {
                ui_Proxies.Items.Clear();
                ui_Proxies.GridLines = false;

                if (!string.IsNullOrEmpty(loadingString))
                    ui_Proxies.Items.Add(loadingString);
            });

            ThreadPool.QueueUserWorkItem(delegate {
                var proxies = Functions.GetProxies();

                if(proxies == null)
                {
                    Utility.TryInvoke(ui_Proxies, (Action)delegate {
                        ui_Proxies.Items.Clear();
                          ui_Proxies.Items.Add("Error : CloudFlare protection"); //Error while getting proxies");
                    });

                    return;
                }

                Utility.TryInvoke(ui_Proxies, (Action)delegate {
                    ui_Proxies.Items.Clear();
                    ui_Proxies.GridLines = true;

                    foreach (Proxy proxy in proxies)
                    {
                        var item = new ListViewItem();
                        item.Tag = proxy;
                        item.Text = proxy.IP;
                        item.SubItems.Add(proxy.Port.ToString());
                        item.SubItems.Add(proxy.Code.ToString());
                        item.SubItems.Add(proxy.Country.ToString());
                        item.SubItems.Add(proxy.Anonymity.ToString());
                        item.SubItems.Add(proxy.Google.ToString());
                        item.SubItems.Add(proxy.HTTPS.ToString());
                        item.SubItems.Add(proxy.LastCheck.ToString());
                        item.SubItems.Add("");
                        item.SubItems.Add("");

                        ui_Proxies.Items.Add(item);
                    }
                });

                rebuildTaskIcon(proxies);
            });
        }

        private void OnProxyStateChanged(RegProxy proxy)
        {
            Icon icon = proxy.Enabled ? Resources.proxy_on : Resources.proxy_off;

            Utility.TryInvoke(this, (Action)delegate {
                this.Icon = icon;
                ui_icon.Icon = icon;
                disconnectToolStripMenuItem.Visible = proxy.Enabled;
                _connectItem.Enabled = !proxy.Enabled;
                _disconnectItem.Enabled = proxy.Enabled;
                ui_Status.Text = proxy.Enabled ? "Proxy running : " + proxy.ToString() : "Currently no proxy running";
                ui_icon.Text = ui_Status.Text;
                ui_ExtraStatus.Text = "";
            });

            if(proxy.Enabled)
            {
                var infos = Functions.GetProxyInfos(proxy);

                Utility.TryInvoke(this, (Action)delegate {
                    if (infos != null)
                    {
                        var sinfos = new List<string>();
                        
                        if(!string.IsNullOrEmpty(infos.IP))
                            sinfos.Add("IP : " + infos.IP);

                        if (!string.IsNullOrEmpty(infos.City))
                        {
                            sinfos.Add("City : " + infos.City);
                            ui_icon.Text += " (" + infos.City + ")";
                        }

                        if (!string.IsNullOrEmpty(infos.ISP))
                            sinfos.Add("ISP : " + infos.ISP);

                        ui_ExtraStatus.Text = "[ " + String.Join(" | ", sinfos) + " ]";
                    }
                });
            }
        }

        private string _lastProxySignature;
        private void BackgroundCheckCurrentProxy()
        {
            while(true)
            {
                var proxy = Functions.GetCurrentProxy();
                
                if(_lastProxySignature != proxy.Signature())
                {
                    _lastProxySignature = proxy.Signature();
                    OnProxyStateChanged(proxy);
                }
                
                Thread.Sleep(1000);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        public void ExitApp()
        {
            if(_bgProxyCheckThread != null)
            _bgProxyCheckThread.Abort();
            Application.Exit();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.UnsetProxy();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ui_Proxies.SelectedItems.Count < 1)
                return;

            var item = ui_Proxies.SelectedItems[0];
            Proxy proxy = (Proxy)item.Tag;
            Functions.SetProxy(proxy);
        }

        private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ui_Proxies.SelectedItems.Count < 1)
                return;

            var item = ui_Proxies.SelectedItems[0];
            Proxy proxy = (Proxy)item.Tag;

            PingProxy(item.Index, proxy);
            CheckIfWorking(item.Index, proxy);
        }

        private void CheckIfWorking(int itemIndex, Proxy proxy)
        {
            var index = columnHeader9.DisplayIndex;

            Utility.TryInvoke(ui_Proxies, (Action)delegate {
                ui_Proxies.Items[itemIndex].SubItems[index].Text = "Checking..";
            });

            ThreadPool.QueueUserWorkItem(delegate {
                var infos = Functions.GetProxyInfos(proxy);
                var str = "Down";

                Utility.TryInvoke(this, (Action)delegate {
                    if (infos != null)
                    {
                        var sinfos = new List<string>();

                        if (!string.IsNullOrEmpty(infos.City))
                            sinfos.Add("City : " + infos.City);


                        if (string.IsNullOrEmpty(infos.City) && !string.IsNullOrEmpty(infos.ISP))
                            sinfos.Add("ISP : " + infos.ISP);

                        str = "OK (" + String.Join(" | ", sinfos) + ")";
                    }

                    ui_Proxies.Items[itemIndex].SubItems[index].Text = str;
                });
            });
        }

        private void PingProxy(int itemIndex, Proxy proxy)
        {
            var index = columnHeader10.DisplayIndex;

            Utility.TryInvoke(ui_Proxies, (Action)delegate {
                ui_Proxies.Items[itemIndex].SubItems[index].Text = "Ping..";
            });

            ThreadPool.QueueUserWorkItem(delegate {
                var str = "FAIL";

                using (var ptool = new Ping())
                {
                    try
                    {
                        var pong = ptool.Send(proxy.IP);

                        if (pong.Status == System.Net.NetworkInformation.IPStatus.Success)
                        {
                            str = pong.RoundtripTime + "ms";
                        }
                    }
                    catch { }
                }

                Utility.TryInvoke(ui_Proxies, (Action)delegate {
                    ui_Proxies.Items[itemIndex].SubItems[index].Text = str;
                });                
            });
        }

        private void refreshProxiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshProxies("Refreshing proxies..");
        }

        private void pingAllProxiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate {
                var opt = new ParallelOptions();
                opt.MaxDegreeOfParallelism = 10;

                Parallel.For(0, ui_Proxies.Items.Count - 1, opt, i => {
                    ListViewItem item = null;
                    int itemIndex = -1;
                    Utility.TryInvoke(ui_Proxies, (Action)delegate {
                        item = ui_Proxies.Items[i];
                        itemIndex = item.Index;
                    });
                    Proxy proxy = (Proxy)item.Tag;

                    PingProxy(itemIndex, proxy);
                });
            });
        }

        private void checkAllProxiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate {
                var opt = new ParallelOptions();
                opt.MaxDegreeOfParallelism = 10;

                Parallel.For(0, ui_Proxies.Items.Count - 1, opt, i => {
                    ListViewItem item = null;
                    int itemIndex = -1;
                    Utility.TryInvoke(ui_Proxies, (Action)delegate {
                        item = ui_Proxies.Items[i];
                        itemIndex = item.Index;
                    });
                    Proxy proxy = (Proxy)item.Tag;

                    CheckIfWorking(itemIndex, proxy);
                });
            });
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var proxy = RegProxy.ParseProxyString(ui_SpecProxy.Text, true);

            if (!string.IsNullOrEmpty(proxy.IP))
            {
                var infos = Functions.GetProxyInfos(proxy);

                if (infos != null)
                    Functions.SetProxy(proxy);
                else MessageBox.Show("Proxy down", "Proxy Me", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Malformed Proxy host & ip", "Proxy Me", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ui_Proxies_DoubleClick(object sender, EventArgs e)
        {
            var item = ui_Proxies.SelectedItems[0];
            Proxy proxy = (Proxy)item.Tag;
            Functions.SetProxy(proxy);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void ui_Icon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void rebuildTaskIcon(IEnumerable<Proxy> proxies = null)
        {
            _connectItem = new ToolStripMenuItem() { Text = "&Connect", Enabled = !_disconnectItem.Enabled };

            Utility.TryInvoke(TaskIconMenuStrip1, (Action)delegate {
                TaskIconMenuStrip1.Items.Clear();
                TaskIconMenuStrip1.Items.AddRange(new ToolStripItem[] { _connectItem, _disconnectItem });
                TaskIconMenuStrip1.Items.Add("-");
            });            

            var countries = proxies.GroupBy(p => p.Country).Select(g => g.First()).OrderBy(p => p.Country).ToList();

            if(countries.Count() > 0)
            {
                _connectItem.Click += delegate {
                    Functions.SetProxy(Utility.Rand(proxies));
                };

                countries.ForEach(p => {
                    Utility.TryInvoke(TaskIconMenuStrip1, (Action)delegate {
                        TaskIconMenuStrip1.Items.Add("Connect " + p.Country, null, delegate {
                            Functions.SetProxy(p);
                        });
                    });
                });

                Utility.TryInvoke(TaskIconMenuStrip1, (Action)delegate {
                    TaskIconMenuStrip1.Items.Add("-");
                });
            }

            Utility.TryInvoke(TaskIconMenuStrip1, (Action)delegate {
                TaskIconMenuStrip1.Items.Add("&Exit", null, exitToolStripMenuItem1_Click);
            });
        }

        private void connectToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void disconnectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Functions.UnsetProxy();
        }

        private void runAtStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStartup(runAtStartupToolStripMenuItem.Checked);
        }

        private void SetStartup(bool set = true)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (set)
                rk.SetValue("ProxyMe", Application.ExecutablePath.ToString());
            else
                rk.DeleteValue("ProxyMe", false);

        }

        private bool IsRunningStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            return rk.GetValue("ProxyMe") != null ? true : false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
