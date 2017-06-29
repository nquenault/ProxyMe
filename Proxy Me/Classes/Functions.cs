using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.Net.Http;

namespace ProxyMe
{
    static class Functions
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;
        private static bool settingsReturn, refreshReturn;

        public static RegProxy GetCurrentProxy()
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            bool en = (int)registry.GetValue("ProxyEnable") == 1 ? true : false;
            string proxy = (string)registry.GetValue("ProxyServer");

            return RegProxy.ParseProxyString(proxy ?? "", en);
        }

        public static void SetProxy(IProxy proxy, bool unset = false)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", unset ? 0 : 1);

            if(!unset && proxy != null)
            registry.SetValue("ProxyServer", proxy.ToString());

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public static void UnsetProxy() { SetProxy(null, true); }
        
        public static IEnumerable<Proxy> GetProxies(bool shuffle = false)
        {
            var proxies = new List<Proxy>();
            var client = new HttpClient();
            string html = null;

            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

            try
            {
                var task = client.GetStringAsync("https://www.sslproxies.org/");
                html = task.Result;
            }
            catch
            {
                return null;
            }

            var matches = Regex.Matches(html, @"<tr[^>]*>\s*<td[^>]*>([^<]+)</td>\s*<td[^>]*>([0-9]+)</td>\s*<td[^>]*>([^<]*)</td>\s*<td[^>]*>([^<]*)</td>[^>]*\s*<td[^>]*>([^<]*)</td>\s*<td[^>]*>([^<]*)</td>\s*<td[^>]*>([^>]*)</td>\s*<td[^>]*>([^<]*)</td>\s*</tr>", RegexOptions.IgnoreCase);
            
            foreach(Match match in matches)
            {
                var proxy = new Proxy(
                    match.Groups[1].Value,
                    int.Parse(match.Groups[2].Value),
                    match.Groups[3].Value,
                    match.Groups[4].Value,
                    match.Groups[5].Value == "elite proxy" ? ProxyAnonymity.Anonymous : ProxyAnonymity.Anonymous,
                    match.Groups[6].Value == "yes" ? true : false,
                    match.Groups[7].Value == "yes" ? true : false,
                    match.Groups[8].Value
                );

                proxies.Add(proxy);
            }

            if(shuffle)
            {
                Random r = new Random();
                proxies = proxies.OrderBy(x => r.Next()).ToList();
            }

            return proxies;
        }

        public static MyIPAddressInfos GetProxyInfos(IProxy proxy)
        {
            var client = new WebClient();
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

            if(!string.IsNullOrEmpty(proxy.IP))
            client.Proxy = new WebProxy(proxy.IP, proxy.Port);

            string html;

            try
            {
                html = client.DownloadString("https://whatismyipaddress.com/fr/mon-ip");
            }
            catch { return null; }

            var match = Regex.Match(html, @"<a\s+href=\x22(https?://(www\.)?whatismyipaddress\.com)?/ip/([^\x22]+)", RegexOptions.IgnoreCase);

            if(!match.Success)
                return null;

            string ip = match.Groups[3].Value;

            match = Regex.Match(html, @"FAI\s*:\s*</th>\s*<td[^>]*>([^<]+)<", RegexOptions.IgnoreCase);
            string isp = match.Groups[1].Value;

            match = Regex.Match(html, @"Ville\s*:\s*</th>\s*<td[^>]*>([^<]+)<", RegexOptions.IgnoreCase);
            string city = match.Groups[1].Value;

            return new MyIPAddressInfos(ip, city, isp);
        }
    }
}
