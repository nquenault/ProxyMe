using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMe
{
    enum ProxyAnonymity
    {
        Anonymous,
        Elite
    }
        
    class Proxy : IProxy
    {
        public string IP { get; private set; }
        public int Port { get; private set; }
        public string Code { get; private set; }
        public string Country { get; private set; }
        public ProxyAnonymity Anonymity { get; private set; }
        public bool Google { get; private set; }
        public bool HTTPS { get; private set; }
        public string LastCheck { get; private set; }

        public Proxy(string ip, int port, string code, string country, ProxyAnonymity anon, bool google, bool https, string lcheck)
        {
            IP = ip;
            Port = port;
            Code = code;
            Country = country;
            Anonymity = anon;
            Google = google;
            HTTPS = https;
            LastCheck = lcheck;
        }

        public override string ToString()
        {
            return IP + ":" + Port.ToString();
        }
    }
}
