using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProxyMe
{
    class RegProxy : IProxy
    {
        public string IP { get; private set; }
        public int Port { get; private set; }
        public bool Enabled { get; private set; }

        public RegProxy(string ip, int port, bool enabled)
        {
            IP = ip;
            Port = port;
            Enabled = enabled;
        }

        public static RegProxy ParseProxyString(string ipPort, bool enabled)
        {
            var match = Regex.Match(ipPort, @"^([0-9\.]+):([0-9]+)$");

            if (match.Success)
                return new RegProxy(match.Groups[1].Value, int.Parse(match.Groups[2].Value), enabled);
            return new RegProxy("", 0, enabled);
        }

        public override string ToString()
        {
            return IP + ":" + Port.ToString();
        }

        public string Signature()
        {
            return ToString() + ":" + (Enabled ? "1" : "0");
        }
    }
}
