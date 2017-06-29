using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMe
{
    interface IProxy
    {
        string IP { get; }
        int Port { get; }
        string ToString();
    }
}
