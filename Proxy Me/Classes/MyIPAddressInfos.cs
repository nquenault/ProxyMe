using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMe
{
    class MyIPAddressInfos
    {
        public string IP { get; private set; }
        public string City { get; private set; }
        public string ISP { get; private set; }

        public MyIPAddressInfos(string ip, string city, string isp)
        {
            IP = ip;
            City = city;
            ISP = isp;
        }
    }
}
